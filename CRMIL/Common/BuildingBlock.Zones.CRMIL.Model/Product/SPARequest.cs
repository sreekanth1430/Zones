using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product
{
    public class SPARequest
    {
        public string AccountNumber { get; set; }
        public string EDPNumber { get; set; }
        public string Quantity { get; set; }
        public string ShippingDate { get; set; }
        public string CallContextCompany { get; set; }
        public string CurrencyCode { get; set; }
    }
}
