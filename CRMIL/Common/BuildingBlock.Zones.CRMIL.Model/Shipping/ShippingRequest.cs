using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class ShippingRequest
    {
        public ShipRateContract shipRateContract { get; set; }
        public string _companyId { get; set; }
        public string _currencyCode { get; set; }
    }
}
