using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace otfSampleDataGenerator.utils
{
    public class SerializationUtilsXml
    {
        public static void SerializeToXml(object obj, string targetfilename)
        {
            var serializer = new XmlSerializer(obj.GetType());
            var fileStream = new FileStream(string.Format("{0}.xml", targetfilename), FileMode.Create);
            serializer.Serialize(fileStream, obj);
            fileStream.Close();
        }

        public static T DeserializeFromXml<T>(string sourcefilename)
        {
            var serializer = new XmlSerializer(typeof(T));
            T obj;

            using (var fileStream = new FileStream(string.Format("{0}.xml", sourcefilename), FileMode.Open))
            {
                obj = (T)serializer.Deserialize(fileStream);
            }

            return obj;
        }
    }
}
