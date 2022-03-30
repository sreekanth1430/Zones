using BuildingBlock.Zones.Model.Customer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel
{
    public class ActiveCreditCardInfo
    {

        public CreditCardType cardTypeField { get; set; }

        public bool cardTypeFieldSpecified { get; set; }

        public string creditCardNumberField { get; set; }

        public CreditCardProcessorStatus creditCardStatusField { get; set; }

        public bool creditCardStatusFieldSpecified { get; set; }
    }
    
}
