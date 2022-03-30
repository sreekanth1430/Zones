using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Zones.CRMIL.Api.Common;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using Microsoft.Extensions.Localization;

namespace BuildingBlock.Zones.CRMIL.Api
{
    public static class ErrorHelper<T> where T : class
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
        internal static ApiErrorDetail CreateFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 501,
                Message = stringLocalizer["CreateFailed"],
                Detail = ":'("
            };
        }
        /// <summary>
        /// Update Order Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail UpdateFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 502,
                Message = stringLocalizer["UpdateFailed"],
                Detail = ":'("
            };
        }
        /// <summary>
        /// CreateOrderAsync Order Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail GetOrderFailed(IStringLocalizer<OrderController> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 400,
                Message = stringLocalizer[OrderConstants.InvalidOrderId],
                Detail = ": Pass proper order id"
            };
        }
        /// <summary>
        /// Product Search Failed
        /// </summary>
        /// <param name="stringLocalizer"></param>
        /// <returns></returns>
        internal static ApiErrorDetail SearchFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 502,
                Message = stringLocalizer["SearchFailed"],
                Detail = ":'("
            };
        }

        internal static ApiErrorDetail ConvertQuoteFailed(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 502,
                Message = stringLocalizer["ConvertQuoteFailed, Requested object is received as null. Please check the request"],
                Detail = ":'("
            };
        }
        internal static ApiErrorDetail MethodNotFoundError(IStringLocalizer<T> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 404,
                Message = stringLocalizer["Not found error"],
                Detail = ":'("
            };
        }
    }
}