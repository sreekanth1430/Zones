using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Shipping
{
    public class ShippingAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
