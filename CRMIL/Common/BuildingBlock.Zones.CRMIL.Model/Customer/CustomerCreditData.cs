using BuildingBlock.Zones.Model.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Customer
{
    public class CustomerCreditData
    {
        [Required]
        public string companyId { get; set; }
        public List<CreditData> creditdata { get; set; }
    }
}
