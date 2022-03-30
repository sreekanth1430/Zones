using BuildingBlock.Zones.Model.CRMIL.OrderRecall;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries
{
    public class OrderDetailsQuery: IRequest<List<OrderResponseData>>
    {
        public string[] _salesOrderList { get; set; }
        public string _companyId { get; set; } 
    }
} 
