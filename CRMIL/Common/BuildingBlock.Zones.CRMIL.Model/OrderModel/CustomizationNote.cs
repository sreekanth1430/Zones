using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.OrderModel
{
    public class CustomizationNote
    {
        public CustomizationNote()
        {

        }

        private string sFieldName;
        public string FieldName
        {
            get { return sFieldName; }
            set { sFieldName = value; }
        }

        private string sFieldType;
        public string FieldType
        {
            get { return sFieldType; }
            set { sFieldType = value; }
        }

        private string sFieldDataType;
        public string FieldDataType
        {
            get { return sFieldDataType; }
            set { sFieldDataType = value; }
        }

        private int sFieldMaxLength;
        public int FieldMaxLength
        {
            get { return sFieldMaxLength; }
            set { sFieldMaxLength = value; }
        }
    }
}
