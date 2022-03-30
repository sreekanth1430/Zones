using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.Model.CRMIL;
using AutoMapper;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDetailsDTO>
    {
        private readonly IOrderRepository _iorderRepository;
        private readonly IMapper _mapper;
        public GetOrderQueryHandler(IOrderRepository iorderRepository, IMapper mapper) 
        {
            _iorderRepository = iorderRepository;
            _mapper = mapper;
        }
        public async Task<OrderDetailsDTO> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            OrderDetail orderDetail=_iorderRepository.GetOrderById(request.OrderAccount);
            OrderDetailsDTO orderDetailsDTO= _mapper.Map<OrderDetailsDTO>(orderDetail);

            return orderDetailsDTO;
        }
    }
}
