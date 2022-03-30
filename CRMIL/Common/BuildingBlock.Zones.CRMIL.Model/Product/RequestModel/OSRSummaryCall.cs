using BuildingBlock.Zones.Model.Product.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product.RequestModel
{
    public class OSRSummaryCall
    {
        /// <summary>
        /// OSR Details
        /// </summary>
        public ZonOSRRequestContract[] OSRDetails { get; set; }
        /// <summary>
        /// Customer Account Name
        /// </summary>
        public string Customeraccount { get; set; }
        /// <summary>
        /// Sales Id
        /// </summary>
        public string SalesId { get; set; }
        /// <summary>
        /// Call Context Company Name
        /// </summary>
        public string CallContextCompany { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        public string CurrencyCode { get; set; }
    }
}
