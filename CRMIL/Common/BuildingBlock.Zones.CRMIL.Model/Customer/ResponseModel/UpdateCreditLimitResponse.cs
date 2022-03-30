using BuildingBlock.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel
{
    public class UpdateCreditLimitResponse : BaseResponse
    {
        public bool CreditLimitStatus { get; set; }
    }
}
