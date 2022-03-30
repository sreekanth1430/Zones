using BuildingBlock.Core.Model;
using Newtonsoft.Json;

namespace BuildingBlock.Zones.Model.CRMIL
{
    public partial class Order : IBaseEntity
    {

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
