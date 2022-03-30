using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel
{
    public class CreditLimitInfo 
    {
        public string CustomerAccount { get; set; }
        public string CreditLimit { get; set; } 
        public string _companyId { get; set; } 
    }
}
