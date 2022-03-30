using BuildingBlock.Core.Model;
using Newtonsoft.Json;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    public class WarehouseAddress : BaseResponse, IBaseEntity
    {
        [JsonProperty(PropertyName = "id")] 
        public int Id { get; set; }
        public string CityField { get;set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        #nullable enable
        public string? City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        #nullable disable


    }
}
