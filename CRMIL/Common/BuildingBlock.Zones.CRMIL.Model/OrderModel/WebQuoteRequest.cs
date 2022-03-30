using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.OrderModel
{
    public class WebQuoteRequest
    {
        public string SalesId { get; set; }

        public string PONumber { get; set; }

        public string AxBillingId { get; set; }

        public string CustomerId { get; set; }

        public string VersionNumber { get; set; }

        public string Company { get; set; } = "USA";

        public string CustomerRef { get; set; }

        public string AdditionalEmails { get; set; }
    }
}
