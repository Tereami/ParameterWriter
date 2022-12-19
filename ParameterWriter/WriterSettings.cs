#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2021, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2021, all rigths reserved.
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
#endregion

namespace ParameterWriter
{
    [Serializable]
    public class WriterSettings
    {
        public string targetParamName = "Марка";
        public string ConstValue = "СТм-1";
        public string sourceParameterName = "Комментарии";
        public string levelParamName = "Имя";
        public SourceMode sourceMode = SourceMode.FixValue;
        public string constructor = "<Марка>_<Комментарии>";
        //public List<string> constructorHistory = new List<string>();

        //[System.Xml.Serialization.XmlIgnore]
        //public static string xmlPath = "";

        public override string ToString()
        {
            string name = targetParamName + "_";

            switch (sourceMode)
            {
                case SourceMode.FixValue:
                    name += ConstValue;
                    break;
                case SourceMode.OtherParameter:
                    name += "param_" + sourceParameterName;
                    break;
                case SourceMode.Constructor:
                    name += constructor;
                    break;
                case SourceMode.Level:
                    name += "level_" + levelParamName;
                    break;
                default:
                    break;
            }
            name = string.Join("_", name.Split(Path.GetInvalidFileNameChars()));
            return name;
        }

        public static WriterSettings Load(string xmlFilePath)
        {
            //string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string rbspath = Path.Combine(appdataPath, "bim-starter");
            //if (!Directory.Exists(rbspath))
            //{
            //    Directory.CreateDirectory(rbspath);
            //}
            //string solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            //string solutionFolder = Path.Combine(rbspath, solutionName);
            //if (!Directory.Exists(solutionFolder))
            //{
            //    Directory.CreateDirectory(solutionFolder);
            //}
            //xmlPath = Path.Combine(solutionFolder, "settings.xml");
            WriterSettings s = null;

            if (File.Exists(xmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(WriterSettings));
                using (StreamReader reader = new StreamReader(xmlFilePath))
                {
                    try
                    {
                        s = (WriterSettings)serializer.Deserialize(reader);
                    }
                    catch { }
                }
            }
            if (s == null)
            {
                s = new WriterSettings();
            }

            return s;
        }

        public static void Save(WriterSettings sets, string xmlFilePath)
        {
            if (File.Exists(xmlFilePath)) File.Delete(xmlFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(WriterSettings));
            using (FileStream writer = new FileStream(xmlFilePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, sets);
            }
        }
    }
}
