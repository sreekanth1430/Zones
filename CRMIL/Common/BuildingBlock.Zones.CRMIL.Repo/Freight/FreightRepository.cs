using BuildingBlock.Zones.CRMIL.Model.Shipping;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using BuildingBlock.Zones.Model.Shipping;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public class FreightRepository: IFreightRepository
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="configuration"></param>
        public FreightRepository(OrderDbContext dbContext, IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shippingRequest"></param>
        /// <returns></returns>
        public async Task<ShipRateContract> getOrderLevelShipMethods(ShippingRequest shippingRequest)
        {
            try 
            { 
                HTTPClientWrapper<ShipRateContract> hTTPClientWrapper = new HTTPClientWrapper<ShipRateContract>(_configuration);
                var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("ShipRateURL").Value, shippingRequest);
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        /// <summary>
        ///  Convert AX model to IL model and consolidate rates for whole level
        /// </summary>
        /// <param name="entity : OrderDetailsForFreightCalc"></param>
        /// <returns></returns>
        public ShippingRate GroupShipMethodsByWareHouse(ShipRateContract shipRateContract)
        {
            //Map the ShippingToDetails
            var shippingToDetailsList = new List<ShipToDetails>();

            //Map the ShippingLineDetails
            var shippingLineDetailsList = new List<ShipLineDetails>();

            // This is just part of request, so just select onle line for whole order level, this is not needed for CRM.

            var ShipToDetails = shipRateContract.ShipToDetails.Select(a => a.ShipLineDetails).ToList();

            // Join all shipfromloactions by comma(,) and total weight for whole order level
            var shippingLineDetails = new ShipLineDetails();
            foreach (var lines in ShipToDetails)
            {
                var line = lines.FirstOrDefault();
                shippingLineDetails.ShipFromLocation += string.IsNullOrEmpty(shippingLineDetails.ShipFromLocation) ? line.ShipFromLocation : "," + line.ShipFromLocation;
                shippingLineDetails.Weight += line.Weight;
            }

            shippingLineDetailsList.Add(shippingLineDetails);

            //Get list of ShippingRateDetails by warehouse.
            var rateDetailsList = shipRateContract.ShipToDetails.Select(a => a.ShipRateDetails);

            var shippingRateDetailsList = new List<ShipRateDetails>();

            //This is flag for total number of warehouses in order level.
            int warehousesCount = rateDetailsList != null ? rateDetailsList.Count() : 0;

            // Iterate ratelist for each warehouse.
            if (rateDetailsList != null && rateDetailsList.Count() > 0)
                foreach (var rateList in rateDetailsList)
                {
                    // Check if rates avaliable for current warehouse.
                    if (rateList != null)
                    {
                        // Iterate shipmethods for current warehouse.
                        foreach (var rate in rateList)
                        {
                            var shippingRateDetails = new ShipRateDetails
                            {
                                CustomerOverride = rate.CustomerOverride,
                                OverrideReason = rate.OverrideReason,
                                ShipMethod = rate.ShipMethod,
                                Description = rate.Description,
                                ShipRate = rate.ShipRate,
                                MarginCalculation = rate.MarginCalculation,
                                ShipBaseRate = rate.ShipBaseRate,
                                DisplaySeq = rate.DisplaySeq,
                                IsOvernight = rate.IsOvernight,
                                AdditionalFreightRates = rate.AdditionalFreightRates, //!= null && rate.AdditionalFreightRates.Any() ? rate.AdditionalFreightRates.ToList() : null,
                                DownliftPercent = rate.DownliftPercent,
                                UpliftPercent = rate.UpliftPercent,
                                IsUpDownliftapplied = rate.IsUpDownliftapplied
                            };

                            // if this ShippingRateDetail already exists, then add rate and basic rate of this to existing one.
                            // MethodCounts helps to identify that if any shippingmethod is missing for any warehouse.
                            if (shippingRateDetailsList.Any(a => a.MethodCode == shippingRateDetails.MethodCode))
                            {
                                shippingRateDetailsList.Where(a => a.MethodCode == shippingRateDetails.MethodCode).ToList()
                                    .ForEach(b => { b.Rate += shippingRateDetails.Rate; b.ShipBaseRate += shippingRateDetails.ShipBaseRate; ++b.MethodCounts; });
                            }
                            // if Shippingmethod is not exists then add this to collection.
                            else
                            {
                                shippingRateDetails.MethodCounts = 1;
                                shippingRateDetailsList.Add(shippingRateDetails);
                            }
                        }
                    }
                }

            // Remove all shipmethods from collection which are missing for some warehouses.
            shippingRateDetailsList.RemoveAll(a => a.MethodCounts < warehousesCount);

            // Sort ship methods by display seq Ascending order.
            shippingRateDetailsList = shippingRateDetailsList.OrderBy(a => a.DisplaySeq).ToList();

            var shipTo = shipRateContract.ShipToDetails.FirstOrDefault();

            var shippingToDetails =
                new ShipToDetails()
                {
                    ShipToCountry = shipTo.ShipToCountry,
                    ShipToState = shipTo.ShipToState,
                    ShipToZIP = shipTo.ShipToZIP,
                    ShipLineDetails = shippingLineDetailsList,
                    ShipRateDetails = shippingRateDetailsList
                };
            shippingToDetailsList.Add(shippingToDetails);

            var model = new ShippingRate()
            {
                Division = shipRateContract.Division,
                OnyxId = shipRateContract.OnyxId,
                ShipToDetails = shippingToDetailsList
            };

            return model;
        }
    }
}
