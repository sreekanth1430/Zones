using BuildingBlock.Zones.Model.Customer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Product.RequestModel
{
    public class ProductFnORequest
    {
        public string[] sEDP { get; set; }
        public string p_VPACode { get; set; }
        public string p_AXAccountNum { get; set; }
        public NoYes p_VPARoundingOff { get; set; }
        public string sCallContextCompany { get; set; }
        public string p_CountryCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
