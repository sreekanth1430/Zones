using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public interface IFreightServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shipRate"></param>
        /// <returns></returns>
        Task<ShippingRate> GetShippingRates(ShippingRequest shipRate);
        public SurchargeAddress surchargedetails();
    }
}
