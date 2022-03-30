using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuildingBlock.Zones.CRMIL.Model.Product.Enum.ProductEnums;

namespace BuildingBlock.Zones.Model.Product
{
    public class ProductSearch
    {
        public string SearchText { get; set; }

        public string[] EDPList { get; set; }

        public string EDP { get; set; }

        public string SKU { get; set; }

        public string Geography { get; set; }
        public string ConfigurationFilter { get; set; }
        public string[] N { get; set; }
        public string[] Ne { get; set; }
        public string No { get; set; }
        public string Ns { get; set; }

        public string VPACode { get; set; }

        public string OnyxId { get; set; }

        public string AXAccountNum { get; set; }

        public string CountryCode { get; set; }

        public bool VPARoundOff { get; set; }
        public string CallContextCompany { get; set; }

        public long CategoryAxRecId { get; set; }

        public int PageIndex { get; set; }

        public int MaxLimit { get; set; }

        public bool IsStandard { get; set; }

        public bool Sold { get; set; }

        public bool Quoted { get; set; }
        public ZonSalesChannel SalesChannel { get; set; }
        public ZonOrganizationalSize OrganizationSize { get; set; }
    }
}
