using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product.ResponseModel
{
    public class PurchaseAgreementData
    {
        public System.DateTime agreementExpiryDateField { get; set; }
        public bool agreementExpiryDateFieldSpecified { get; set; }
        public string purchAgreementNumberField { get; set; }
        public string quoteNumberField { get; set; }
        public string vendorNameField { get; set; }
        public decimal costField { get; set; }
        public bool costFieldSpecified { get; set; }


    }
}
