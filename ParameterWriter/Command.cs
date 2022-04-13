using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB; //для работы с элементами модели Revit
using Autodesk.Revit.UI; //для работы с элементами интерфейса
using Autodesk.Revit.UI.Selection; //работы с выделенными элементами

namespace ParameterWriter
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            View curView = doc.ActiveView;
            //Dictionary<string, HashSet<object>> paramsbase = new Dictionary<string, HashSet<object>>();
            //HashSet<string> parameters = new HashSet<string>();

            WriterSettings sets = WriterSettings.Activate();

            List<ElementId> elemIds = new List<ElementId>();
            FilteredElementCollector col;

            Selection sel = commandData.Application.ActiveUIDocument.Selection;
            List<ElementId> selids = sel.GetElementIds().ToList();
            bool haveSelectedElems = selids.Count > 0;

            if (haveSelectedElems)
            {
                elemIds = selids;
            }
            else
            {
                col = new FilteredElementCollector(doc, curView.Id)
                    .WhereElementIsNotElementType();
                elemIds = col
                    .ToElementIds()
                    .ToList();
            }

            //заполняю варианты значений для всех параметров
            Dictionary<string, HashSet<string>> valuesBase = new Dictionary<string, HashSet<string>>();
            foreach (ElementId id in elemIds)
            {
                Element elem = doc.GetElement(id);
                List<Parameter> allParams = new List<Parameter>();
                foreach (Parameter p in elem.Parameters)
                {
                    allParams.Add(p);
                }

                ElementId typeId = elem.GetTypeId();
                if (typeId == null) continue;
                if (typeId == ElementId.InvalidElementId) continue;
                ElementType elemType = doc.GetElement(typeId) as ElementType;
                if (elemType == null) continue;
                foreach(Parameter p in elemType.Parameters)
                {
                    allParams.Add(p);
                }

                foreach(Parameter p in allParams)
                {
                    string pname = p.Definition.Name;
                    string val = MyParameter.GetParameterValAsString(elem, pname);

                    if (valuesBase.ContainsKey(pname))
                        valuesBase[pname].Add(val);
                    else
                        valuesBase.Add(pname, new HashSet<string> { val });
                }
            }

            
            //открываю диалоговое окно
            FormWriter form = new FormWriter(haveSelectedElems, valuesBase, sets);
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return Result.Cancelled;
            sets = form.sets;
            //string sourceParamName = form.otherParamName;


            int count = 0;

            using (Transaction t = new Transaction(doc))
            {
                t.Start("Заполнятор");

                if(form.writerMode == WriterMode.AllInProject)
                {
                    FilteredElementCollector col2 = new FilteredElementCollector(doc)
                        .WhereElementIsNotElementType();

                    foreach(Element elem in col2)
                    {
                        MyParameter.SetValue(elem, sets);
                        count++;
                    }
                        
                }
                else
                {
                    foreach (ElementId id in elemIds)
                    {
                        Element elem = doc.GetElement(id);
                        MyParameter.SetValue(elem, sets);
                        count++;
                    }
                }

                t.Commit();
            }

            sets.Save();
            BalloonTip.Show(sets.targetParamName + " заполнен!", "Обработано элементов: " + count.ToString());

            return Result.Succeeded;
        }
    }
}
