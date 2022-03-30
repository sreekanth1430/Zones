using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order
{
    public class OrderDocument
    {
        public long RecordID { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string CreatedBy { get; set; }
        public string DocumentTypeText { get; set; }
        public string SalesID { get; set; }
        public string PONumber { get; set; }
        public byte[] Content { get; set; }
    }
}
