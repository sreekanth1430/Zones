using BuildingBlock.Zones.CRMIL.Model.Customer.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Customer.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Command
{
    public class UpdateCreditLimitCommandHandler : IRequestHandler<UpdateCreditLimitCommand, bool>
    {
        private readonly ICustomerRepository _iCustomerRepository;
        private readonly IConfiguration _configuration;
        public UpdateCreditLimitCommandHandler(ICustomerRepository iCustomerRepository, IConfiguration configuration)
        {
            _iCustomerRepository = iCustomerRepository;
            _configuration = configuration;
        }
        public Task<bool> Handle(UpdateCreditLimitCommand request, CancellationToken cancellationToken)
        {
            CreditLimitInfo creditLimitInfo = new CreditLimitInfo { CustomerAccount = request.CustomerAccount ,  CreditLimit = request.CreditLimit, _companyId = request.CompanyId };
            var updateCreditLimitResponse= _iCustomerRepository.UpdateCreditLimit(creditLimitInfo);
            return updateCreditLimitResponse;
        }
    }
}
