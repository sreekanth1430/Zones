using BuildingBlock.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer
{
    public class AccountOption : BaseResponse
    {
        public string OnyxId { get; set; }
        public string TaxId { get; set; }
        public string AdditEmail { get; set; }
        public string POissuesEmailTO { get; set; }
        public string POissuesEmailCC { get; set; }
        public string EscalationEmail { get; set; }
        public bool AutoPO { get; set; }
        public bool DisableQuote { get; set; }
        public bool ExpressCheckout { get; set; }
        public bool EducationCust { get; set; }
        public bool GovernmentCust { get; set; }
        public bool HoldComplete { get; set; }
        public bool ShipNotification { get; set; }
        public bool CustWait { get; set; }
        public bool AdditionalOrderLabel { get; set; }
        public bool ReleaseDate { get; set; }
        public bool DisableOpenQuote { get; set; }
        public bool POAttach { get; set; }
        public bool CustomFreight { get; set; }
    }
}
