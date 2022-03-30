using BuildingBlock.Core.Model;
using BuildingBlock.Zones.CRMIL.Model.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Shipping
{
    public class ShippingRate: BaseResponse
    {
        public string OnyxId { get; set; }
        public string Division { get; set; }
        public List<ShipToDetails> ShipToDetails { get; set; }
    }
}
