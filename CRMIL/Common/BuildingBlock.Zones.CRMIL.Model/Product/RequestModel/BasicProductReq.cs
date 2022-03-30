

using BuildingBlock.Zones.Model.Customer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product.RequestModel
{
    public class BasicProductReq
    {
        public string[] _edpList { get; set; }
        public string _offerCode { get; set; }
        public string customerAccount { get; set; }
        public string Country { get; set; }
        public int roundOff { get; set; }
        public string _companyId { get; set; }
        public string _currencyCode { get; set; }
    }
}
