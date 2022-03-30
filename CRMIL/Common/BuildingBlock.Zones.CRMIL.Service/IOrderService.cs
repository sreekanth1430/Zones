using BuildingBlock.Core.Model;
using BuildingBlock.Zones.Model.CRMIL;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using order1 = BuildingBlock.Zones.Model.OrderModel;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;

namespace BuildingBlock.Zones.CRMIL.Api.Service
{
    /// <summary>
    /// IOrderService
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Order"></param>
        /// <returns></returns>
        Task<bool>CreateOrderAsync(order1.Order p_Order);
        Task<OrderDetailsDTO> GetOrderById(string id);

        /// <summary>
        /// Get Order Details by Sales Id and Company 
        /// </summary>
        /// <returns></returns>     

        Task<List<OrderResponseData>> RecallOrderAsync(OrderDetailsRequest orderDetailsRequest);

        public string getrcyclefee();
    }
}
