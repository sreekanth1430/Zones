using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order
{
    public class SendQuote
    {
        public string QuoteId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }
        public string FaxNumber { get; set; }
        public string Comments { get; set; }
        public bool IsEDPOnQuote { get; set; }
        public bool IsAttachPDF { get; set; }
    }
}
