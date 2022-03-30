using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuildingBlock.Zones.CRMIL.Model.Shipping.Enum.enums;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class SurchargeAddress
    {
        public AddressType AddressType { get; set; }
        public bool OutOfArea { get; set; }
        public bool IsAddressFedexVerified { get; set; }
        public VertexAddress vertexAddress { get; set; }
    }

}
