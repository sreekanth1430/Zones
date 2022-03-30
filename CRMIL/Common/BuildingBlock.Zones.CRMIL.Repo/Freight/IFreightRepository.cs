using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public interface IFreightRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shippingRequest"></param>
        /// <returns></returns>
        Task<ShipRateContract> getOrderLevelShipMethods(ShippingRequest shippingRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ShippingRate GroupShipMethodsByWareHouse(ShipRateContract shipRateContract);
    }
}
