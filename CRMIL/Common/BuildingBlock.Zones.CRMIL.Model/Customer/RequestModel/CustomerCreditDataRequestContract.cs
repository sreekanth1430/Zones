using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer.RequestModel
{
    public class CustomerCreditDataRequestContract
    {
        public List<CustomerAccount> _customerList { get; set; }
        public bool _creditLimit { get; set; }
        public bool _creditStatus { get; set; }
        public bool _firstDate { get; set; }
        public bool _lastDate { get; set; }
        public bool _orderCount { get; set; }
        public bool _p3MthSales { get; set; }
        public bool _p12MthSales { get; set; }
        public bool _openQuotes { get; set; }
        public bool _paymTermDays { get; set; }
        public bool _billComplete { get; set; }
        public bool _totalOpen { get; set; }
        public bool _potentialAR { get; set; }
        public bool _creditAvailable { get; set; }
    }
    public class CustomerAccount 
    { 
        public string CustAccount { get; set; }
        public string companyId { get; set; }
    }
}
