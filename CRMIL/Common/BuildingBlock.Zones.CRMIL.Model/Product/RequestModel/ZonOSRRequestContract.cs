using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product.RequestModel
{
    public class ZonOSRRequestContract
    {
        [JsonProperty(PropertyName = "$id")]
        public int Id { get; set; }
        public string Country { get; set; }
        public decimal DiscountAmount { get; set; }
        public string EDP { get; set; }
        public decimal OSRAmount { get; set; }
        public System.DateTime OSRExpirationDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal WebDiscountAmount { get; set; }
        public decimal WebOSRAmount { get; set; }
    }
}
