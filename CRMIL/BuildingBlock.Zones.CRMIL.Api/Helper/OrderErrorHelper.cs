using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Zones.CRMIL.Api.Common;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using Microsoft.Extensions.Localization;

namespace BuildingBlock.Zones.CRMIL.Api
{
    /// <summary>
    /// 
    /// </summary>
    public static class OrderErrorHelper<T> where T : class
    {
        /// <summary>
        /// Generic Server Error
        /// </summary>
        /// <returns></returns>
        internal static ApiErrorDetail GenericInternalServerError(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 500,
                Message = stringLocalizer["GenericInternalServerError"],
                Detail = ":'("
            };
        }
        /// <summary>
        /// CreateOrderAsync Order Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail CreateOrderFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 501,
                Message = stringLocalizer["CreateOrderFailed"],
                Detail = ":'("
            };
        }

        /// <summary>
        /// CreateOrderAsync Order Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail GetOrderFailed(IStringLocalizer<T> stringLocalizer) 
        {
            return new ApiErrorDetail
            {
                Code = 400,
                Message = stringLocalizer[OrderConstants.InvalidOrderId],
                Detail = ": Pass proper oerder id"
            };
        }

        internal static ApiErrorDetail GetInvalidData(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 400,
                Message = stringLocalizer[OrderConstants.InvalidOrderId],
                Detail = ": Data is not valid"
            };
        }


        internal static ApiErrorDetail OrderNotFound(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 404,
                Message = stringLocalizer[OrderConstants.OrderIdNotFound],
                Detail = ": "
            };
        }
        /// <summary>
        /// Update Order Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail UpdateOrderFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 502,
                Message = stringLocalizer["UpdateOrderFailed"],
                Detail = ":'("
            };
        }

    }
}
