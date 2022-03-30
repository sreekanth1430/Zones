using BuildingBlock.Zones.Model.Customer.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer.ResponseModel
{
    public class CustomerCreditDataContract
    {
        [JsonProperty(PropertyName = "$id")]
        public int Id { get; set; }
        public string CustomerCurrCode { get; set; }
        public string? ARCollector { get; set; }
        public NoYes BillComplete { get; set; }
        public decimal AvailableCredit { get; set; }
        public decimal CreditLimit { get; set; }
        public ZonCustStatus CreditStatus { get; set; }
        public string CustAccount { get; set; }
        public System.DateTime Firstdate { get; set; }
        public decimal LargeOrderReviewAmount { get; set; }
        public System.DateTime LastDate { get; set; }
        public decimal OpenQuotes { get; set; }
        public decimal P12MthSales { get; set; }
        public decimal P3MthSales { get; set; }
        public string? TermDays { get; set; }
        public decimal PotentialAR { get; set; }
        public ZonInvoiceType PrimaryInvoiceType { get; set; }
        public ZonInvoiceType SecondaryInvoiceType { get; set; }
        public NoYes TaxExempt { get; set; }
        public decimal TotalOpen { get; set; }
        public int TotalOrders { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public string companyId { get; set; }
    }
}
