using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Shipping
{
    public class ShippingLineDetails
    {
        public decimal _weight;
        public decimal Weight
        {
            get
            {
                return Math.Ceiling(_weight);
            }
            set
            {
                _weight = value;
            }
        }
        public string ShipFromLocation { get; set; }
    }
}
