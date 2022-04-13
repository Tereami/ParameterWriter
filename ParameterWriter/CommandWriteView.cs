#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2022, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2022, all rigths reserved.
*/
#endregion
#region usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
#endregion


namespace ParameterWriter
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    class CommandWriteView : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            WriterSettings sets = WriterSettings.Activate();
            FormWriteView form = new FormWriteView(sets);
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return Result.Cancelled;

            sets = form.curSettings;

            List<View> views = new FilteredElementCollector(doc)
                    .WhereElementIsNotElementType()
                    .OfClass(typeof(View))
                    .Cast<View>()
                    .ToList();
            if (sets.WriteViewOnlySheets)
            {
                views = views
                    .Where(i => ViewIsOnSheet(i))
                    .ToList();
            }

            Dictionary<int, List<View>> elementsOnViews = new Dictionary<int, List<View>>();

            foreach (View curView in views)
            {
                if (curView.IsTemplate) continue;
                FilteredElementCollector viewCol = new FilteredElementCollector(doc, curView.Id)
                    .WhereElementIsNotElementType();

                foreach (Element elem in viewCol)
                {
                    int elemId = elem.Id.IntegerValue;
                    if (elementsOnViews.ContainsKey(elemId))
                    {
                        if (sets.WriteViewAll)
                            elementsOnViews[elemId].Add(curView);
                        else
                            continue;
                    }
                    else
                    {
                        elementsOnViews.Add(elemId, new List<View> { curView });
                    }
                }
            }


            using (Transaction t = new Transaction(doc))
            {
                t.Start("Заполнение по виду");
                foreach (var kvp in elementsOnViews)
                {
                    Element elem = doc.GetElement(new ElementId(kvp.Key));
                    Dictionary<string, HashSet<string>> paramNameAndValues = new Dictionary<string, HashSet<string>>();

                    foreach (View curView in kvp.Value)
                    {
                        foreach (string[] paramsRow in sets.WriteViewParameters)
                        {
                            string viewParamName = paramsRow[0];
                            string elemParamName = paramsRow[1];
                            Parameter viewParam = curView.LookupParameter(viewParamName);
                            if (viewParam == null || !viewParam.HasValue)
                                continue;

                            string curViewVal = MyParameter.GetParameterValAsString(curView, viewParamName);
                            if (paramNameAndValues.ContainsKey(elemParamName))
                                paramNameAndValues[elemParamName].Add(curViewVal);
                            else
                                paramNameAndValues.Add(elemParamName, new HashSet<string> { curViewVal });

                        }
                    }

                    foreach (string[] paramsRow in sets.WriteViewParameters)
                    {
                        string elemParamName = paramsRow[1];
                        Parameter elemParam = elem.LookupParameter(elemParamName);
                        if (elemParam == null) continue;
                        if (elemParam.IsReadOnly) continue;
                        if (elemParam.StorageType != StorageType.String)
                        {
                            string msg = "Допускается заполнение только текстовых параметров. " +
                                elemParamName + " не текстовый параметр";
                            TaskDialog.Show("Error", msg);
                            throw new Exception(msg);
                        }

                        HashSet<string> paramValues = paramNameAndValues[elemParamName];
                        string elemParamVal = string.Join(sets.WriteViewSeparator, paramValues);
                        elemParam.Set(elemParamVal);
                    }

                }

                t.Commit();
            }

            sets.Save();

            return Result.Succeeded;
        }

        private bool ViewIsOnSheet(View vw)
        {
            Parameter sheetNumberParam = vw.get_Parameter(BuiltInParameter.VIEWER_SHEET_NUMBER);
            if (sheetNumberParam == null) return false;
            string sheetNumber = sheetNumberParam.AsString();
            if (sheetNumber == "---") return false;

            return true;
        }

    }
}
