using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries
{
    public class GetOrderDetailsQueryHandler 
    {
        private readonly IOrderRepository _iorderRepository;
        private readonly IConfiguration _configuration;
        public GetOrderDetailsQueryHandler(IOrderRepository iorderRepository, IConfiguration config)
        {
            _iorderRepository = iorderRepository;
            _configuration= config;
        }
        public async Task<List<OrderResponseData>> Handle(OrderDetailsQuery orderDetails)
        {            
            OrderRecallQuery orderRecallQueryData = new OrderRecallQuery { _salesOrderList= new string[] { orderDetails._salesOrderList[0] } , _companyId= orderDetails._companyId  };

            List<OrderResponseData> response =await _iorderRepository.GetOrderRecall(orderRecallQueryData);
            return response;
        }
    }
}

