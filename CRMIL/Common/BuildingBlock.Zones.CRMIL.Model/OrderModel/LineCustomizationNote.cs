using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customNotes = BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;

namespace BuildingBlock.Zones.Model.OrderModel
{
    public class LineCustomizationNote
    {
        public LineCustomizationNote()
        {
            lstCNotes = new List<CustomizationNote>();
        }

        private List<CustomizationNote> lstCNotes = null;

        public void AddCustomizationNote(CustomizationNote p_Object)
        {
            lstCNotes.Add(p_Object);
        }

        public CustomizationNote[] CustomizationNote
        {
            get
            {
                return lstCNotes.ToArray();
            }
        }

        public string SalesID { get; set; }
        public string LineNumber { get; set; }
        public long RecId { get; set; }
        public customNotes.CustomizationNotes[] CustomizationNoteInput { get; set; }
    }
    
}
