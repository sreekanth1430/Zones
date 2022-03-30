using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Shipping
{
    public class VertexAddress
    {
        public PostalAddress SuggestedAddress { get; set; }
        public string TaxAreaId { get; set; }
        public string ConfidenceIndicator { get; set; }

        public string Error { get; set; }
        public bool IsVerified { get; set; }
    }
}
