using BuildingBlock.Core.ErrorHandling;
using BuildingBlock.Core.Logger;
using BuildingBlock.Zones.CRMIL.Api.Common;
using BuildingBlock.Zones.CRMIL.Api.Controllers;
using Microsoft.Extensions.Localization;

namespace BuildingBlock.Zones.CRMIL.Api
{
    public static class LoggingHelper<T> where T : class
    {
        /// <summary>
        /// Log attempt to create order
        /// </summary>
        /// <returns></returns>
        internal static LogData CreateAttempt()
        {
            return new LogData()
            {
                EventId = 201,
                Message = $"Attempt to create {typeof(T).Name}."
            };
        }
        internal static LogData CreateSucceeded()
        {
            return new LogData()
            {
                EventId = 202,
                Message = $"Attempt to create {typeof(T).Name} succeeded."
            };
        }

        internal static LogData CreateFailed()
        {
            return new LogData()
            {
                EventId = 203,
                Message = $"Attempt to create {typeof(T).Name} failed."
            };
        }
        internal static ApiErrorDetail NotFoundError(IStringLocalizer<OrderController> stringLocalizer)
        {
            return new ApiErrorDetail
            {
                Code = 404,
                Message = stringLocalizer[OrderConstants.OrderIdNotFound],
                Detail = ": "
            };
        }
        internal static LogData UpdateAttempt()
        {
            return new LogData()
            {
                EventId = 211,
                Message = $"Attempt to update {typeof(T).Name}."
            };
        }

        internal static LogData UpdateSucceeded()
        {
            return new LogData()
            {
                EventId = 212,
                Message = $"Attempt to update {typeof(T).Name} succeeded."
            };
        }
        internal static LogData UpdateFailed()
        {
            return new LogData()
            {
                EventId = 213,
                Message = $"Attempt to update {typeof(T).Name} failed."
            };
        }

        internal static LogData DeleteAttempt()
        {
            return new LogData()
            {
                EventId = 211,
                Message = $"Attempt to delete {typeof(T).Name}."
            };
        }

        internal static LogData DeleteSucceeded()
        {
            return new LogData()
            {
                EventId = 212,
                Message = $"Attempt to delete {typeof(T).Name} succeeded."
            };
        }
        internal static LogData DeleteFailed()
        {
            return new LogData()
            {
                EventId = 213,
                Message = $"Attempt to delete {typeof(T).Name} failed."
            };
        }

        internal static LogData DeleteNotFound(int id)
        {
            return new LogData()
            {
                EventId = 214,
                Message = $"Attempt to Get {typeof(T).Name} - {id} Not found."
            };
        }

        internal static LogData GetAttempt()
        {
            return new LogData()
            {
                EventId = 221,
                Message = $"Attempt to Get {typeof(T).Name}."
            };
        }

        internal static LogData GetSucceeded()
        {
            return new LogData()
            {
                EventId = 222,
                Message = $"Attempt to Get {typeof(T).Name} succeeded."
            };
        }
        internal static LogData GetFailed()
        {
            return new LogData()
            {
                EventId = 223,
                Message = $"Attempt to Get {typeof(T).Name} failed."
            };
        }

        internal static LogData GetNotFound()
        {
            return new LogData()
            {
                EventId = 224,
                Message = $"Attempt to Get for custom query Not found."
            };
        }
        internal static LogData GetNotFound(int id)
        {
            return new LogData()
            {
                EventId = 224,
                Message = $"Attempt to Get {typeof(T).Name} - {id} Not found."
            };
        }
    }
}
