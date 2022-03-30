using BuildingBlock.Core.Model;
using System;

namespace BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel
{
    public class OrderComment : BaseResponse 
    {
        public string Description { get; set; }
        public string Notes { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
        public string SalesID { get; set; }
        public string NoteType { get; set; }
        public string CallContextCompany { get; set; }
        public long RecId { get; set; }
        public bool RecIdSpecified { get; set; }
        public string CommentCreateTime { get; set; }
        public DateTime ZonCommentDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool Modified { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
