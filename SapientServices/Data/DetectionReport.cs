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
    public partial class subClass
    {
        private float confidenceField;

        private bool confidenceFieldSpecified;

        private subClass[] subClass1Field;

        private int levelField;

        private bool levelFieldSpecified;

        private string typeField;

        private string valueField;

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
        [System.Xml.Serialization.XmlElementAttribute("subClass")]
        public subClass[] subClass1
        {
            get
            {
                return this.subClass1Field;
            }
            set
            {
                this.subClass1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }

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
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DetectionReport
    {

        private System.DateTime timestampField;

        private int sourceIDField;

        private long reportIDField;

        private long objectIDField;

        private int taskIDField;

        private long detectionSensorIDField;

        private bool detectionSensorIDFieldSpecified;

        private string stateField;

        private location locationField;

        private rangeBearing rangeBearingField;

        private float detectionConfidenceField;

        private bool detectionConfidenceFieldSpecified;

        private DetectionReportTrackInfo[] trackInfoField;

        private DetectionReportPredictedLocation predictedLocationField;

        private DetectionReportObjectInfo[] objectInfoField;

        private string colourField;

        private DetectionReportClass[] classField;

        private DetectionReportBehaviour[] behaviourField;

        private DetectionReportAssociatedFile[] associatedFileField;

        private DetectionReportAffiliation affiliationField;

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
        public long reportID
        {
            get
            {
                return this.reportIDField;
            }
            set
            {
                this.reportIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int taskID
        {
            get
            {
                return this.taskIDField;
            }
            set
            {
                this.taskIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long detectionSensorID
        {
            get
            {
                return this.detectionSensorIDField;
            }
            set
            {
                this.detectionSensorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detectionSensorIDSpecified
        {
            get
            {
                return this.detectionSensorIDFieldSpecified;
            }
            set
            {
                this.detectionSensorIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
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
        public float detectionConfidence
        {
            get
            {
                return this.detectionConfidenceField;
            }
            set
            {
                this.detectionConfidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool detectionConfidenceSpecified
        {
            get
            {
                return this.detectionConfidenceFieldSpecified;
            }
            set
            {
                this.detectionConfidenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trackInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportTrackInfo[] trackInfo
        {
            get
            {
                return this.trackInfoField;
            }
            set
            {
                this.trackInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportPredictedLocation predictedLocation
        {
            get
            {
                return this.predictedLocationField;
            }
            set
            {
                this.predictedLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objectInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportObjectInfo[] objectInfo
        {
            get
            {
                return this.objectInfoField;
            }
            set
            {
                this.objectInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string colour
        {
            get
            {
                return this.colourField;
            }
            set
            {
                this.colourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportClass[] @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("behaviour", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportBehaviour[] behaviour
        {
            get
            {
                return this.behaviourField;
            }
            set
            {
                this.behaviourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("associatedFile", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportAssociatedFile[] associatedFile
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DetectionReportAffiliation affiliation
        {
            get
            {
                return this.affiliationField;
            }
            set
            {
                this.affiliationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportTrackInfo
    {

        private string typeField;

        private float valueField;

        private float eField;

        private bool eFieldSpecified;

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
        public float value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float e
        {
            get
            {
                return this.eField;
            }
            set
            {
                this.eField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eSpecified
        {
            get
            {
                return this.eFieldSpecified;
            }
            set
            {
                this.eFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportPredictedLocation
    {

        private location locationField;

        private rangeBearing rangeBearingField;

        private System.DateTime predictionTimestampField;

        private bool predictionTimestampFieldSpecified;

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
        public System.DateTime predictionTimestamp
        {
            get
            {
                return this.predictionTimestampField;
            }
            set
            {
                this.predictionTimestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool predictionTimestampSpecified
        {
            get
            {
                return this.predictionTimestampFieldSpecified;
            }
            set
            {
                this.predictionTimestampFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportObjectInfo
    {

        private string typeField;

        private float valueField;

        private float eField;

        private bool eFieldSpecified;

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
        public float value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float e
        {
            get
            {
                return this.eField;
            }
            set
            {
                this.eField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eSpecified
        {
            get
            {
                return this.eFieldSpecified;
            }
            set
            {
                this.eFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportClass
    {

        private float confidenceField;

        private bool confidenceFieldSpecified;

        private subClass[] subClassField;

        private string typeField;

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
        [System.Xml.Serialization.XmlElementAttribute("subClass")]
        public subClass[] subClass
        {
            get
            {
                return this.subClassField;
            }
            set
            {
                this.subClassField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportBehaviour
    {

        private float confidenceField;

        private bool confidenceFieldSpecified;

        private string typeField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DetectionReportAssociatedFile
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
    public partial class DetectionReportAffiliation
    {

        private string typeField;

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
    }
}
