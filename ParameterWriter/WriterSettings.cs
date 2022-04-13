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
        public string sourceParameterName = "Комментарии";
        public SourceMode sourceMode = SourceMode.FixValue;
        public string currentCostructor = "<Марка>_<Комментарии>";
        public List<string> constructorHistory = new List<string>();

        public List<string[]> WriteViewParameters = new List<string[]> { };
        public bool WriteViewOnlySheets = true;
        public bool WriteViewAll = true;
        public string WriteViewSeparator = "$";

        private static string xmlPath = "";

        public static WriterSettings Activate()
        {
            string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rbspath = Path.Combine(appdataPath, "bim-starter");
            if (!Directory.Exists(rbspath))
            {
                Directory.CreateDirectory(rbspath);
            }
            string solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string solutionFolder = Path.Combine(rbspath, solutionName);
            if (!Directory.Exists(solutionFolder))
            {
                Directory.CreateDirectory(solutionFolder);
            }
            xmlPath = Path.Combine(solutionFolder, "settings.xml");
            WriterSettings s = null;

            if (File.Exists(xmlPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(WriterSettings));
                using (StreamReader reader = new StreamReader(xmlPath))
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
            
            if(s.WriteViewParameters.Count == 0)
            {
                s.WriteViewParameters.Add(new string[] { "Имя вида", "Марка" });
                s.WriteViewParameters.Add(new string[] { "Номер листа", "Комментарии" });
            }

            return s;
        }

        public void Save()
        {
            if (File.Exists(xmlPath)) File.Delete(xmlPath);
            XmlSerializer serializer = new XmlSerializer(typeof(WriterSettings));
            using (FileStream writer = new FileStream(xmlPath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
