using BuildingBlock.Core.Repo;
using BuildingBlock.Zones.CRMIL.Model.Order;
using BuildingBlock.Zones.Model.CRMIL;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using order1 = BuildingBlock.Zones.Model.OrderModel;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public interface IOrderRepository 
    {
        public OrderDetail GetOrderById(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<bool>CreateOrder();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oOrderDocument"></param>
        /// <returns></returns>
        Task<bool> SaveRecallOtherDocs(OrderDocument[] oOrderDocument);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Order"></param>
        /// <returns></returns>
        Task<order1.Order> AddOrderAttachmentPOMultiple(order1.Order p_Order);
        public Task<List<OrderResponseData>> GetOrderRecall(OrderRecallQuery orderDetails);

    }

}
