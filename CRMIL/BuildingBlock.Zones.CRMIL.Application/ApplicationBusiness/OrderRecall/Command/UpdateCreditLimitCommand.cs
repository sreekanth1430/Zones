using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command
{
    public  class UpdateCreditLimitCommand : IRequest<bool>
    {
        [Required]
        public string CustomerAccount { get; set; }
        [Required]
        public string CreditLimit { get; set; }
        [Required]
        public string CompanyId { get; set; }

    }
}
