using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product
{
    public class OraProductSummary
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Description { get; set; }
    }
}
