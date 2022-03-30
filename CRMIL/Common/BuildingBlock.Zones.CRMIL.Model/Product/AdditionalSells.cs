using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Product
{
    public class AdditionalSells
    {
        //[JsonIgnore]
        //public int RowNum { get; set; }

        public string OID { get; set; }
        public string NAME { get; set; }
        public string PROD_ID { get; set; }
        public decimal PRICE { get; set; }
        public string PreviewImage { get; set; }
        public string FullImage { get; set; }
        public string DISPLAY_ACCESS_NM { get; set; }
        public int TYPE { get; set; }
        public Product Product { get; set; }
        public string Id { get; set; }
    }
}
