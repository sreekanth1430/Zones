using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product.RequestModel
{
    public class SPARequest
    {
        public string CustomerAccount { get; set; }
        public string EDPNumber { get; set; }
        public Decimal ItemQuantity { get; set; }
        public string ShippingDate { get; set; }
        public string _companyId { get; set; }
        public string _currencyCode { get; set; }

    }
}
