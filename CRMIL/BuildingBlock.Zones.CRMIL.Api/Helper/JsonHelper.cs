using System.IO;
using System.Text.Json;

namespace BuildingBlock.Zones.CRMIL.Api.Helper
{
    public static class JsonHelper
    {

        public static string LoadJson(string fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string jsonData = r.ReadToEnd();
                jsonData = jsonData.Replace("\r\n", "");

                return jsonData;
            }
        }

        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

    }
}
