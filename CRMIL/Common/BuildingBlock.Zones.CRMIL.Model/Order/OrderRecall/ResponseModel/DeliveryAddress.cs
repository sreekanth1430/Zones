using BuildingBlock.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.ResponseModel
{
    public class DeliveryAddress
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
    }
}
