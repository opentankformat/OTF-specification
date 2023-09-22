using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace otfSampleDataGenerator.utils
{
    public class SerializationUtilsJson
    {
        public static void SerializeToJson(object obj, string targetfilename)
        {
            var jsonSettings = JsonSerializationConfig.DefaultSettings();

            string json = JsonConvert.SerializeObject(obj, jsonSettings);
            File.WriteAllText(string.Format("{0}.json", targetfilename), json);
        }

        public static T DeserializeFromJson<T>(string sourcefilename)
        {
            var jsonSettings = JsonSerializationConfig.DefaultSettings();

            string jsonContent = File.ReadAllText(string.Format("{0}.json", sourcefilename));
            return JsonConvert.DeserializeObject<T>(jsonContent, jsonSettings);
        }

    }

    public static class JsonSerializationConfig
    {
        public static JsonSerializerSettings DefaultSettings()
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new myContractResolver("Specified")
                {
                    IgnoreIsSpecifiedMembers = true
                },
                Formatting = Formatting.Indented
            };

            settings.Converters.Add(new StringEnumConverter());

            return settings;
        }

    }

    public class myContractResolver : DefaultContractResolver
    {
        private readonly string _suffix;

        public myContractResolver(string suffix)
        {
            _suffix = suffix;
        }

        protected override JsonProperty CreateProperty(
            System.Reflection.MemberInfo member,
            MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyName.EndsWith(_suffix))
            {
                property.ShouldSerialize = instance => false;
            }

            return property;
        }

    }
}
