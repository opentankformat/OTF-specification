using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace otfSampleDataGenerator.utils
{
    public static class Utils
    {
        public static void GenerateSamples(object o, string targetfolder, string targetfilename)
        {
            string targetfolderXml = string.Format("{0}\\{1}\\", targetfolder, "xml");
            if (!Directory.Exists(targetfolderXml))
            {
                Directory.CreateDirectory(targetfolderXml);
            }
            string targetfolderJson = string.Format("{0}\\{1}\\", targetfolder, "json");
            if (!Directory.Exists(targetfolderJson))
            {
                Directory.CreateDirectory(targetfolderJson);
            }

            XMLExporter(o, string.Format("{0}{1}", targetfolderXml, targetfilename));
            jsonExporter(o, string.Format("{0}{1}", targetfolderJson, targetfilename));
        }

        public static void XMLExporter(object obj, string targetfilename)
        {
            var serializer = new XmlSerializer(obj.GetType());
            var fileStream = new FileStream(string.Format("{0}.xml", targetfilename), FileMode.Create);
            serializer.Serialize(fileStream, obj);
            fileStream.Close();
        }

        public static void jsonExporter(object obj, string targetfilename)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(string.Format("{0}.json", targetfilename), json);
        }
    }
}