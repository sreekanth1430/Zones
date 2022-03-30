using BuildingBlock.Zones.CRMIL.Model.Order.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Model.Order
{
    public partial class AttachDocument  
    {
        private string authorField;

        private System.DateTime createdField;

        private bool createdFieldSpecified;

        private string descriptionField;

        private System.DateTime modifiedField;

        private bool modifiedFieldSpecified;

        private string notesField;

        private long recIdField;

        private bool recIdFieldSpecified;

        private string relatedKeyField;

        private string relatedValueField;

        private DocuRestriction restrictionField;

        private bool restrictionFieldSpecified;

        private string typeField;

        private System.DateTime zonCommentDateTimeField;

        private bool zonCommentDateTimeFieldSpecified;

        /// <remarks/>
        
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedSpecified
        {
            get
            {
                return this.createdFieldSpecified;
            }
            set
            {
                this.createdFieldSpecified = value;
            }
        }

        /// <remarks/>
       
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedSpecified
        {
            get
            {
                return this.modifiedFieldSpecified;
            }
            set
            {
                this.modifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
       
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public long RecId
        {
            get
            {
                return this.recIdField;
            }
            set
            {
                this.recIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecIdSpecified
        {
            get
            {
                return this.recIdFieldSpecified;
            }
            set
            {
                this.recIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string RelatedKey
        {
            get
            {
                return this.relatedKeyField;
            }
            set
            {
                this.relatedKeyField = value;
            }
        }

        /// <remarks/>
        
        public string RelatedValue
        {
            get
            {
                return this.relatedValueField;
            }
            set
            {
                this.relatedValueField = value;
            }
        }

        /// <remarks/>
        public DocuRestriction Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }

        /// <remarks/>
        
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ZonCommentDateTime
        {
            get
            {
                return this.zonCommentDateTimeField;
            }
            set
            {
                this.zonCommentDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZonCommentDateTimeSpecified
        {
            get
            {
                return this.zonCommentDateTimeFieldSpecified;
            }
            set
            {
                this.zonCommentDateTimeFieldSpecified = value;
            }
        }
    }
}
