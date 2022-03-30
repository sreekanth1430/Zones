using BuildingBlock.Core.Logger;

namespace BuildingBlock.Zones.CRMIL.Api
{
    /// <summary>
    /// Logging Helper
    /// </summary>
    public static class OrderLoggingHelper
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
                    Message = $"Attempt to create {nameof(BuildingBlock.Zones.Model.CRMIL.Order)}."
                };
            }
            internal static LogData CreateSucceeded()
            {
                return new LogData()
                {
                    EventId = 202,
                    Message = $"Attempt to create {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} succeeded."
                };
            }

            internal static LogData CreateFailed()
            {
                return new LogData()
                {
                    EventId = 203,
                    Message = $"Attempt to create {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} failed."
                };
            }

            internal static LogData UpdateAttempt()
            {
                return new LogData()
                {
                    EventId = 211,
                    Message = $"Attempt to update {nameof(BuildingBlock.Zones.Model.CRMIL.Order)}."
                };
            }

            internal static LogData UpdateSucceeded()
            {
                return new LogData()
                {
                    EventId = 212,
                    Message = $"Attempt to update {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} succeeded."
                };
            }
            internal static LogData UpdateFailed()
            {
                return new LogData()
                {
                    EventId = 213,
                    Message = $"Attempt to update {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} failed."
                };
            }

            internal static LogData DeleteAttempt()
            {
                return new LogData()
                {
                    EventId = 211,
                    Message = $"Attempt to delete {nameof(BuildingBlock.Zones.Model.CRMIL.Order)}."
                };
            }

            internal static LogData DeleteSucceeded()
            {
                return new LogData()
                {
                    EventId = 212,
                    Message = $"Attempt to delete {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} succeeded."
                };
            }
            internal static LogData DeleteFailed()
            {
                return new LogData()
                {
                    EventId = 213,
                    Message = $"Attempt to delete {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} failed."
                };
            }

            internal static LogData DeleteNotFound(int id)
            {
                return new LogData()
                {
                    EventId = 214,
                    Message = $"Attempt to Get {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} - {id} Not found."
                };
            }


            internal static LogData GetAttempt()
            {
                return new LogData()
                {
                    EventId = 221,
                    Message = $"Attempt to Get {nameof(BuildingBlock.Zones.Model.CRMIL.Order)}."
                };
            }

            internal static LogData GetSucceeded()
            {
                return new LogData()
                {
                    EventId = 222,
                    Message = $"Attempt to Get {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} succeeded."
                };
            }
            internal static LogData GetFailed()
            {
                return new LogData()
                {
                    EventId = 223,
                    Message = $"Attempt to Get {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} failed."
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

        internal static LogData InputQueryStringNotValid()
        {
            return new LogData()
            {
                EventId = 224,
                Message = $"Input Query String Is Not Valid."
            };
        }

        internal static LogData GetNotFound(int id)
            {
                return new LogData()
                {
                    EventId = 224,
                    Message = $"Attempt to Get {nameof(BuildingBlock.Zones.Model.CRMIL.Order)} - {id} Not found."
                };
            }

        }
    }
