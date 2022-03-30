using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Repo;
using BuildingBlock.Zones.Model.Shipping;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Service
{
    public class FreightService : IFreightServices
    {
        private IFreightRepository _repository;
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="freightRepository"></param>
        /// <param name="coreLogger"></param>
        /// <param name="mediator"></param>
        /// <param name="config"></param>
        public FreightService(IFreightRepository freightRepository, ICoreLogger<FreightService> coreLogger, IMediator mediator, IConfiguration config)
        {
            _repository = freightRepository;
            _mediator = mediator;
            _configuration = config;
        }
        /// <summary>
        /// Get ShippingRates
        /// </summary>
        /// <param name="shippingRequest"></param>
        /// <returns></returns>
        public async Task<ShippingRate> GetShippingRates(ShippingRequest shippingRequest)
        {
            try
            {
                ShippingRate result = null;
                if (shippingRequest.shipRateContract != null) //ShipToDetails
                {
                    var res = _repository.getOrderLevelShipMethods(shippingRequest).Result;
                    result = _repository.GroupShipMethodsByWareHouse(res);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SurchargeAddress surchargedetails()
        {
            SurchargeAddress surchargeAddress = new SurchargeAddress();
            VertexAddress vertexAddress = new VertexAddress();
            vertexAddress.TaxAreaId = "null";
            vertexAddress.ConfidenceIndicator = "null";
            vertexAddress.Error = "null";

            PostalAddress postalAddress = new PostalAddress();
            postalAddress.StreetAddress1 = "null";
            postalAddress.Country = "null";
            postalAddress.StreetAddress2 = "null";
            postalAddress.PostalCode = "null";
            postalAddress.State = "null";

            vertexAddress.SuggestedAddress = postalAddress;
            surchargeAddress.vertexAddress = vertexAddress;

            return surchargeAddress;
        }
    }
}
