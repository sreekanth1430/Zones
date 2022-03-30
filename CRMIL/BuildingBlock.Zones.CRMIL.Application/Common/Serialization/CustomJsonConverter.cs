using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Application.Common.Serialization
{
   
    public static class CustomJsonConverter
    {
        /// <summary>
        /// Serialize it Generic way
        /// </summary>
        public static string Serialize(object o)
        {
            return JsonConvert.SerializeObject(o,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }
                );
        }

        /// <summary>
        /// Deserialize it in a Generic way
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static JObject Parse(string json)
        {
            return JObject.Parse(json);
        }

    }
}
