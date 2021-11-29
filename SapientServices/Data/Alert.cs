﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace SapientServices.Data
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Alert
    {
        private System.DateTime timestampField;

        private int sourceIDField;

        private int alertIDField;

        private string alertTypeField;

        private string statusField;

        private string descriptionField;

        private location locationField;

        private rangeBearing rangeBearingField;

        private int regionIDField;

        private bool regionIDFieldSpecified;

        private string priorityField;

        private double rankingField;

        private bool rankingFieldSpecified;

        private float confidenceField;

        private bool confidenceFieldSpecified;

        private string debugTextField;

        private AlertAssociatedFile[] associatedFileField;

        private AlertAssociatedDetection[] associatedDetectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int sourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int alertID
        {
            get
            {
                return this.alertIDField;
            }
            set
            {
                this.alertIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string alertType
        {
            get
            {
                return this.alertTypeField;
            }
            set
            {
                this.alertTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
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
        public location location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public rangeBearing rangeBearing
        {
            get
            {
                return this.rangeBearingField;
            }
            set
            {
                this.rangeBearingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int regionID
        {
            get
            {
                return this.regionIDField;
            }
            set
            {
                this.regionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool regionIDSpecified
        {
            get
            {
                return this.regionIDFieldSpecified;
            }
            set
            {
                this.regionIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ranking
        {
            get
            {
                return this.rankingField;
            }
            set
            {
                this.rankingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rankingSpecified
        {
            get
            {
                return this.rankingFieldSpecified;
            }
            set
            {
                this.rankingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool confidenceSpecified
        {
            get
            {
                return this.confidenceFieldSpecified;
            }
            set
            {
                this.confidenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string debugText
        {
            get
            {
                return this.debugTextField;
            }
            set
            {
                this.debugTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("associatedFile", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AlertAssociatedFile[] associatedFile
        {
            get
            {
                return this.associatedFileField;
            }
            set
            {
                this.associatedFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("associatedDetection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AlertAssociatedDetection[] associatedDetection
        {
            get
            {
                return this.associatedDetectionField;
            }
            set
            {
                this.associatedDetectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AlertAssociatedFile
    {

        private string typeField;

        private string urlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AlertAssociatedDetection
    {

        private location locationField;

        private string descriptionField;

        private System.DateTime timestampField;

        private bool timestampFieldSpecified;

        private int sourceIDField;

        private long objectIDField;

        /// <remarks/>
        public location location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timestampSpecified
        {
            get
            {
                return this.timestampFieldSpecified;
            }
            set
            {
                this.timestampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int sourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long objectID
        {
            get
            {
                return this.objectIDField;
            }
            set
            {
                this.objectIDField = value;
            }
        }
    }
}
