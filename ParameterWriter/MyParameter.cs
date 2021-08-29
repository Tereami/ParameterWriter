using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace ParameterWriter
{
    public class MyParameter : IEquatable<MyParameter>
    {
        public Parameter RevitParameter { get; }
        public string Name { get; }
        public StorageType RevitStorageType { get; }

        private double doubleValue;
        private int intValue;
        private string stringValue;
        private ElementId elemIdValue;

        public bool HasValue;

        //Интерфейсы
        public bool Equals(MyParameter other)
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return false;
                case StorageType.Integer:
                    return this.AsInteger() == other.AsInteger();
                case StorageType.Double:
                    return Math.Round(this.AsDouble(), 6) == Math.Round(other.AsDouble(), 6);
                case StorageType.String:
                    return this.AsString() == other.AsString();
                case StorageType.ElementId:
                    return this.AsElementId().IntegerValue == other.AsElementId().IntegerValue;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return Name;
        }


        //Конструктор
        public MyParameter(Parameter revitParameter)
        {
            RevitParameter = revitParameter;
            RevitStorageType = revitParameter.StorageType;
            HasValue = false;
        }

        //Методы
        public void Set(object value)
        {
            switch (RevitStorageType)
            {
                case StorageType.None:
                    break;
                case StorageType.Integer:
                    intValue = (int)value;
                    HasValue = true;
                    break;
                case StorageType.Double:
                    doubleValue = (double)value;
                    HasValue = true;
                    break;
                case StorageType.String:
                    stringValue = (string)value;
                    HasValue = true;
                    break;
                case StorageType.ElementId:
                    elemIdValue = (ElementId)value;
                    HasValue = true;
                    break;
                default:
                    break;
            }
        }

        public double AsDouble()
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return 0.0;
                case StorageType.Integer:
                    return (double)intValue;
                case StorageType.Double:
                    return doubleValue;
                case StorageType.String:
                    return 0.0;
                case StorageType.ElementId:
                    return 0.0;
                default:
                    return 0.0;
            }
        }

        public int AsInteger()
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return 0;
                case StorageType.Integer:
                    return intValue;
                case StorageType.Double:
                    return (int)doubleValue;
                case StorageType.String:
                    return 0;
                case StorageType.ElementId:
                    return 0;
                default:
                    return 0; ;
            }
        }

        public string AsString()
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return "";
                case StorageType.Integer:
                    return "";
                case StorageType.Double:
                    return "";
                case StorageType.String:
                    return stringValue;
                case StorageType.ElementId:
                    return "";
                default:
                    return "";
            }
        }

        public ElementId AsElementId()
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return ElementId.InvalidElementId;
                case StorageType.Integer:
                    return ElementId.InvalidElementId;
                case StorageType.Double:
                    return ElementId.InvalidElementId;
                case StorageType.String:
                    return ElementId.InvalidElementId;
                case StorageType.ElementId:
                    return elemIdValue;
                default:
                    return ElementId.InvalidElementId;
            }
        }

        public string AsValueString()
        {
            switch (this.RevitStorageType)
            {
                case StorageType.None:
                    return "";
                case StorageType.Integer:
                    return intValue.ToString();
                case StorageType.Double:
                    return doubleValue.ToString(); ;
                case StorageType.String:
                    return stringValue;
                case StorageType.ElementId:
                    return elemIdValue.IntegerValue.ToString();
                default:
                    return "";
            }
        }

        /// <summary>
        /// Запись в элемент значения параметра
        /// </summary>
        /// <param name="elem">Элемент для записи</param>
        /// <param name="targetParamName">Имя параметр, в который будем записывать</param>
        /// <param name="source">Фиксированное значения для записи или имя параметра-источника</param>
        /// <param name="sourceMode">Определяет, будет записывать фиксирвоанное значение или будет копировать из другого параметра</param>
        public static void SetValue(Element elem, WriterSettings sets)
        {
            Parameter targetParam = elem.LookupParameter(sets.targetParamName);
            string source = sets.sourceParameterName;
            if (targetParam == null) return;
            if (targetParam.IsReadOnly) return;
            switch (sets.sourceMode)
            {
                case SourceMode.FixValue:
                    SetFixValue(targetParam, source);
                    break;
                case SourceMode.OtherParameter:
                    Parameter sourceParam = elem.LookupParameter(source);
                    SetValueByParam(sourceParam, targetParam);
                    break;
                case SourceMode.Constructor:
                    SetValueByConstructor(source, elem, targetParam);
                    break;
            }
        }

        public static void SetValueByConstructor(string constructor, Element sourceElem, Parameter targetParam)
        {
            if (targetParam.Definition.ParameterType != ParameterType.Text)
            {
                string msg = "Заполнение через Конструктор доступно только для текстовых параметров";
                Autodesk.Revit.UI.TaskDialog.Show("Ошибка", msg);
                throw new Exception(msg);
            }
            string result = "";

            string prefix = constructor.Split('<').First();
            result = result + prefix;

            string[] sa = constructor.Split('<');
            for (int i = 0; i < sa.Length; i++)
            {
                string s = sa[i];
                if (!s.Contains(">")) continue;

                string paramName = s.Split('>').First();
                string separator = s.Split('>').Last();

                string val = GetParameterValAsString(sourceElem, paramName);

                result = result + val + separator;
            }
            targetParam.Set(result);
        }

        public static Parameter SuperGetParameter(Element Elem, string ParamName)
        {
            Parameter param = Elem.LookupParameter(ParamName);
            if (param == null)
            {
                Element eltype = Elem.Document.GetElement(Elem.GetTypeId());
                param = eltype.LookupParameter(ParamName);
            }
            return param;
        }

        public static string GetParameterValAsString(Element e, string paramName)
        {
            Parameter param = SuperGetParameter(e, paramName);
            if (param == null) return string.Empty;

            string val = string.Empty;

            switch (param.StorageType)
            {
                case StorageType.None:
                    return string.Empty;
                case StorageType.Integer:
                    val = param.AsInteger().ToString();
                    break;
                case StorageType.Double:
                    double doubval = param.AsDouble();
#if R2022
                    doubval = UnitUtils.ConvertFromInternalUnits(param.AsDouble(), param.GetUnitTypeId());
#else
                    doubval = UnitUtils.ConvertFromInternalUnits(param.AsDouble(), param.DisplayUnitType);
#endif
                    val = doubval.ToString("F0");
                    break;
                case StorageType.String:
                    val = param.AsString();
                    break;
                case StorageType.ElementId:
                    val = param.AsElementId().IntegerValue.ToString();
                    break;
            }
            if (string.IsNullOrEmpty(val))
                return string.Empty;
            else
                return val;
        }

        public static void SetValueByParam(Parameter sourceParam, Parameter targetParam)
        {
            if (sourceParam == null) return;
            if (!sourceParam.HasValue) return;

            if (sourceParam.StorageType != targetParam.StorageType)
                throw new Exception("StorageType of parameters are different!");

            switch (targetParam.StorageType)
            {
                case StorageType.None:
                    break;
                case StorageType.Integer:
                    targetParam.Set(sourceParam.AsInteger());
                    break;
                case StorageType.Double:
                    targetParam.Set(sourceParam.AsDouble());
                    break;
                case StorageType.String:
                    targetParam.Set(sourceParam.AsString());
                    break;
                case StorageType.ElementId:
                    targetParam.Set(sourceParam.AsElementId());
                    break;
                default:
                    break;
            }
        }

        public static void SetFixValue(Parameter param, string value)
        {
            switch (param.StorageType)
            {
                case StorageType.None:
                    break;
                case StorageType.Integer:
                    param.Set(int.Parse(value));
                    break;
                case StorageType.Double:
                    double doubleVal = double.Parse(value);

                    if (ParamIsLength(param))
                        doubleVal /= 304.8;

                    param.Set(doubleVal);
                    break;
                case StorageType.String:
                    param.Set(value);
                    break;
                case StorageType.ElementId:
                    int intval = int.Parse(value);
                    ElementId newId = new ElementId(intval);
                    param.Set(newId);
                    break;
                default:
                    break;
            }
        }

        public static string GetAsString(Parameter param)
        {
            switch (param.StorageType)
            {
                case StorageType.None:
                    return "";
                case StorageType.Integer:
                    return param.AsInteger().ToString();
                case StorageType.Double:
                    double doubleval = param.AsDouble();
                    if (ParamIsLength(param))
                        doubleval *= 304.8;
                    return doubleval.ToString("F1");
                case StorageType.String:
                    return param.AsString();
                case StorageType.ElementId:
                    int intval = param.AsElementId().IntegerValue;
                    return intval.ToString();
                default:
                    return "";
            }
        }

        private static bool ParamIsLength(Parameter param)
        {
            bool isMillimeters = false;
#if R2022
            ForgeTypeId forgeType = param.GetUnitTypeId();
            string unittype = forgeType.TypeId;
            isMillimeters = unittype.Contains("millimeters");
#else
            isMillimeters = param.Definition.UnitType == UnitType.UT_Length;
#endif
            return isMillimeters;
        }
    }
}
