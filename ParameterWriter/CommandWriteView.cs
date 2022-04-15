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
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
#endregion


namespace ParameterWriter
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    class CommandWriteView : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            List<View> views = doc.GetFiller3dViews();
            if (views.Count == 0)
            {
                string msg = "Не найдены подходящие виды. "
                    + "Имя вида должно быть: Filler#Параметр=Значение.";
                TaskDialog.Show("Error", msg);
                return Result.Failed;
            }

            Dictionary<int, Dictionary<string, string>> elemsAndParams = doc.GetElementParametersByViews(views);
            int counter = 0;

            using (Transaction t = new Transaction(doc))
            {
                t.Start("Заполнение по виду");
                foreach (KeyValuePair<int, Dictionary<string, string>> kvp in elemsAndParams)
                {
                    Element elem = doc.GetElement(new ElementId(kvp.Key));
                    Dictionary<string, string> paramNameAndValues = kvp.Value;

                    foreach(var paramsAndValues in kvp.Value)
                    {
                        string paramName = paramsAndValues.Key;
                        string paramValue = paramsAndValues.Value;
                        Parameter elemParam = elem.LookupParameter(paramName);
                        if (elemParam == null) continue;
                        if (elemParam.IsReadOnly) continue;
                        if (elemParam.StorageType != StorageType.String)
                        {
                            string msg = "Допускается заполнение только текстовых параметров. " +
                                paramName + " не текстовый параметр";
                            TaskDialog.Show("Error", msg);
                            throw new Exception(msg);
                        }

                        elemParam.Set(paramValue);
                        counter++;
                    }
                }

                t.Commit();
            }

            BalloonTip.Show("Обработано элементов: " + counter.ToString(), "Использовано видов: " + views.Count.ToString());
            return Result.Succeeded;
        }
    }
}
