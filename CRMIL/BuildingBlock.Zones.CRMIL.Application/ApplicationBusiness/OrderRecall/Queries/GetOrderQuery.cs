using MediatR;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries
{
    public class GetOrderQuery : IRequest<OrderDetailsDTO>
    {
        public string? OrderAccount { get; set; }
       
    }
}
