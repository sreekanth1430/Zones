using BuildingBlock.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.OrderModel
{
    public class RecycleFee : BaseResponse
    {
        public string RecycleFeeCode { get; set; }
        /// <summary>
        /// Recycle Fee Name
        /// </summary>
        public string RecycleFeeName { get; set; }
        /// <summary>
        /// Recycle Fee Description
        /// </summary>
        public string RecycleFeeDescription { get; set; }
        /// <summary>
        /// Fee Amount
        /// </summary>
        public decimal FeeAmount { get; set; }
        /// <summary>
        /// Stock Kit Unit 
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        /// Recycle EDP Number 
        /// </summary>
        public string RecycleEDPNumber { get; set; }
        /// <summary>
        /// Actual EDP Number
        /// </summary>
        public string OriginalEDPNumber { get; set; }
    }
}
