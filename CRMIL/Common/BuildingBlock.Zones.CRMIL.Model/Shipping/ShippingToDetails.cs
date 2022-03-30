using BuildingBlock.Zones.CRMIL.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Shipping
{
    public class ShippingToDetails
    {
        //public List<ShipLineDetails> ShipLineDetails { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public List<ShipLineDetails> ShippingLineDetails { get; set; }
        public List<ShipRateDetails> ShippingRateDetails { get; set; }
    }
}
