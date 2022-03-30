using BuildingBlock.Zones.Model.Product.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product.RequestModel
{
    public class OSRRequest
    {
        public ZonOSRRequestContract[] OSRDetails { get; set; }

        public string Customeraccount { get; set; }

        public string _salesId { get; set; }

        public string _companyId { get; set; }

        public string _currencyCode { get; set; }
    }
}
