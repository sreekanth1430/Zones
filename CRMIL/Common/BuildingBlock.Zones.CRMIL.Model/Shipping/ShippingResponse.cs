using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class ShippingResponse
    {
        public int Id { get; set; }
        public string Division { get; set; }
        public string OnyxId { get; set; }
        public List<ShipToDetails> ShipToDetails { get; set; }
    }
}
