using BuildingBlock.Zones.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class ShipToDetails
    {
        public List<ShipLineDetails> ShipLineDetails { get; set; }
        public List<ShipRateDetails> ShipRateDetails { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZIP { get; set; }
    }
}
