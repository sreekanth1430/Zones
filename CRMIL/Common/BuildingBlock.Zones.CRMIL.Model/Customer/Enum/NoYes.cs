using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer.Enum
{
    public enum NoYes
    {
        No,
        Yes
    }
    public enum CreditCardProcessorStatus
    {

        NA,

        Approved,

        Declined,

        Error,

        Settled,
    }
    public enum CreditCardType
    {

        Visa,

        MasterCard,

        AmericanExpress,

        Discover,

        Diners,

        JCB,

        Solo,

        PayPal,

        Stored,

        MCOneCard,

        AMEXCPC,
    }
}
