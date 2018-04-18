using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// WFS model for http://www.opengis.net/wfs/2.0
/// </summary>
namespace GeoSpatial.WFS2
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class Title
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetCapabilitiesType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class GetCapabilitiesType
    {

        private string[] acceptVersionsField;

        private string[] sectionsField;

        private string[] acceptFormatsField;

        private string updateSequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Version", IsNullable = false)]
        public string[] AcceptVersions
        {
            get
            {
                return this.acceptVersionsField;
            }
            set
            {
                this.acceptVersionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Section", IsNullable = false)]
        public string[] Sections
        {
            get
            {
                return this.sectionsField;
            }
            set
            {
                this.sectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputFormat", IsNullable = false)]
        public string[] AcceptFormats
        {
            get
            {
                return this.acceptFormatsField;
            }
            set
            {
                this.acceptFormatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string updateSequence
        {
            get
            {
                return this.updateSequenceField;
            }
            set
            {
                this.updateSequenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ExtensionOperatorType
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Extended_CapabilitiesType
    {

        private ExtensionOperatorType[] additionalOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Operator", IsNullable = false)]
        public ExtensionOperatorType[] AdditionalOperators
        {
            get
            {
                return this.additionalOperatorsField;
            }
            set
            {
                this.additionalOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ArgumentType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName typeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlQualifiedName Type
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
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("OtherSource", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class MetadataType
    {

        private object abstractMetaDataField;

        private typeType typeField;

        private bool typeFieldSpecified;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        private string aboutField;

        public MetadataType()
        {
            this.typeField = typeType.simple;
        }

        /// <remarks/>
        public object AbstractMetaData
        {
            get
            {
                return this.abstractMetaDataField;
            }
            set
            {
                this.abstractMetaDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public typeType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string about
        {
            get
            {
                return this.aboutField;
            }
            set
            {
                this.aboutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public enum typeType
    {

        /// <remarks/>
        simple,

        /// <remarks/>
        extended,

        /// <remarks/>
        title,

        /// <remarks/>
        resource,

        /// <remarks/>
        locator,

        /// <remarks/>
        arc,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public enum showType
    {

        /// <remarks/>
        @new,

        /// <remarks/>
        replace,

        /// <remarks/>
        embed,

        /// <remarks/>
        other,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public enum actuateType
    {

        /// <remarks/>
        onLoad,

        /// <remarks/>
        onRequest,

        /// <remarks/>
        other,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class AvailableFunctionType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName returnsField;

        private ArgumentType[] argumentsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlQualifiedName Returns
        {
            get
            {
                return this.returnsField;
            }
            set
            {
                this.returnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable = false)]
        public ArgumentType[] Arguments
        {
            get
            {
                return this.argumentsField;
            }
            set
            {
                this.argumentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class TemporalOperatorType
    {

        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable = false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands
        {
            get
            {
                return this.temporalOperandsField;
            }
            set
            {
                this.temporalOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class TemporalOperandsTypeTemporalOperand
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Temporal_CapabilitiesType
    {

        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;

        private TemporalOperatorType[] temporalOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable = false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands
        {
            get
            {
                return this.temporalOperandsField;
            }
            set
            {
                this.temporalOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperator", IsNullable = false)]
        public TemporalOperatorType[] TemporalOperators
        {
            get
            {
                return this.temporalOperatorsField;
            }
            set
            {
                this.temporalOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class SpatialOperatorType
    {

        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands
        {
            get
            {
                return this.geometryOperandsField;
            }
            set
            {
                this.geometryOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class GeometryOperandsTypeGeometryOperand
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Spatial_CapabilitiesType
    {

        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;

        private SpatialOperatorType[] spatialOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands
        {
            get
            {
                return this.geometryOperandsField;
            }
            set
            {
                this.geometryOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SpatialOperator", IsNullable = false)]
        public SpatialOperatorType[] SpatialOperators
        {
            get
            {
                return this.spatialOperatorsField;
            }
            set
            {
                this.spatialOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ComparisonOperatorType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ComparisonOperatorsType
    {

        private ComparisonOperatorType[] comparisonOperatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComparisonOperator")]
        public ComparisonOperatorType[] ComparisonOperator
        {
            get
            {
                return this.comparisonOperatorField;
            }
            set
            {
                this.comparisonOperatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Scalar_CapabilitiesType
    {

        private LogicalOperators logicalOperatorsField;

        private ComparisonOperatorsType comparisonOperatorsField;

        /// <remarks/>
        public LogicalOperators LogicalOperators
        {
            get
            {
                return this.logicalOperatorsField;
            }
            set
            {
                this.logicalOperatorsField = value;
            }
        }

        /// <remarks/>
        public ComparisonOperatorsType ComparisonOperators
        {
            get
            {
                return this.comparisonOperatorsField;
            }
            set
            {
                this.comparisonOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class LogicalOperators
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ResourceIdentifierType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WFS_CapabilitiesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class CapabilitiesBaseType
    {

        private ServiceIdentification serviceIdentificationField;

        private ServiceProvider serviceProviderField;

        private OperationsMetadata operationsMetadataField;

        private string versionField;

        private string updateSequenceField;

        /// <remarks/>
        public ServiceIdentification ServiceIdentification
        {
            get
            {
                return this.serviceIdentificationField;
            }
            set
            {
                this.serviceIdentificationField = value;
            }
        }

        /// <remarks/>
        public ServiceProvider ServiceProvider
        {
            get
            {
                return this.serviceProviderField;
            }
            set
            {
                this.serviceProviderField = value;
            }
        }

        /// <remarks/>
        public OperationsMetadata OperationsMetadata
        {
            get
            {
                return this.operationsMetadataField;
            }
            set
            {
                this.operationsMetadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string updateSequence
        {
            get
            {
                return this.updateSequenceField;
            }
            set
            {
                this.updateSequenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ServiceIdentification : DescriptionType
    {

        private CodeType serviceTypeField;

        private string[] serviceTypeVersionField;

        private string[] profileField;

        private string feesField;

        private string[] accessConstraintsField;

        /// <remarks/>
        public CodeType ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceTypeVersion")]
        public string[] ServiceTypeVersion
        {
            get
            {
                return this.serviceTypeVersionField;
            }
            set
            {
                this.serviceTypeVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Profile", DataType = "anyURI")]
        public string[] Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }

        /// <remarks/>
        public string Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessConstraints")]
        public string[] AccessConstraints
        {
            get
            {
                return this.accessConstraintsField;
            }
            set
            {
                this.accessConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Role", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class CodeType
    {

        private string codeSpaceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BasicIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatasetDescriptionSummaryBaseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class DescriptionType
    {

        private LanguageStringType[] titleField;

        private LanguageStringType[] abstractField;

        private KeywordsType[] keywordsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public LanguageStringType[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public LanguageStringType[] Abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keywords")]
        public KeywordsType[] Keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Title", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class LanguageStringType
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class KeywordsType
    {

        private LanguageStringType[] keywordField;

        private CodeType typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public LanguageStringType[] Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        public CodeType Type
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class BasicIdentificationType : DescriptionType
    {

        private CodeType identifierField;

        private MetadataType[] metadataField;

        /// <remarks/>
        public CodeType Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("OperationResponse", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ManifestType : BasicIdentificationType
    {

        private ReferenceGroupType[] referenceGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceGroup")]
        public ReferenceGroupType[] ReferenceGroup
        {
            get
            {
                return this.referenceGroupField;
            }
            set
            {
                this.referenceGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceGroup", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ReferenceGroupType : BasicIdentificationType
    {

        private ReferenceType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ReferenceType : AbstractReferenceBaseType
    {

        private CodeType identifierField;

        private LanguageStringType[] abstractField;

        private string formatField;

        private MetadataType[] metadataField;

        /// <remarks/>
        public CodeType Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public LanguageStringType[] Abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class AbstractReferenceBaseType
    {

        private string typeField;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        public AbstractReferenceBaseType()
        {
            this.typeField = "simple";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceReference", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ServiceReferenceType : ReferenceType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestMessage", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("RequestMessageReference", typeof(string), DataType = "anyURI")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class IdentificationType : BasicIdentificationType
    {

        private BoundingBoxType[] boundingBoxField;

        private string[] outputFormatField;

        private string[] availableCRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public BoundingBoxType[] BoundingBox
        {
            get
            {
                return this.boundingBoxField;
            }
            set
            {
                this.boundingBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputFormat")]
        public string[] OutputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailableCRS", DataType = "anyURI")]
        public string[] AvailableCRS
        {
            get
            {
                return this.availableCRSField;
            }
            set
            {
                this.availableCRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WGS84BoundingBoxType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("BoundingBox", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class BoundingBoxType
    {

        private string lowerCornerField;

        private string upperCornerField;

        private string crsField;

        private string dimensionsField;

        /// <remarks/>
        public string LowerCorner
        {
            get
            {
                return this.lowerCornerField;
            }
            set
            {
                this.lowerCornerField = value;
            }
        }

        /// <remarks/>
        public string UpperCorner
        {
            get
            {
                return this.upperCornerField;
            }
            set
            {
                this.upperCornerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string dimensions
        {
            get
            {
                return this.dimensionsField;
            }
            set
            {
                this.dimensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("WGS84BoundingBox", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class WGS84BoundingBoxType : BoundingBoxType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("DatasetDescriptionSummary", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class DatasetDescriptionSummaryBaseType : DescriptionType
    {

        private WGS84BoundingBoxType[] wGS84BoundingBoxField;

        private CodeType identifierField;

        private BoundingBoxType[] boundingBoxField;

        private MetadataType[] metadataField;

        private DatasetDescriptionSummaryBaseType[] datasetDescriptionSummaryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox")]
        public WGS84BoundingBoxType[] WGS84BoundingBox
        {
            get
            {
                return this.wGS84BoundingBoxField;
            }
            set
            {
                this.wGS84BoundingBoxField = value;
            }
        }

        /// <remarks/>
        public CodeType Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public BoundingBoxType[] BoundingBox
        {
            get
            {
                return this.boundingBoxField;
            }
            set
            {
                this.boundingBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public DatasetDescriptionSummaryBaseType[] DatasetDescriptionSummary
        {
            get
            {
                return this.datasetDescriptionSummaryField;
            }
            set
            {
                this.datasetDescriptionSummaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ServiceProvider
    {

        private string providerNameField;

        private OnlineResourceType providerSiteField;

        private ResponsiblePartySubsetType serviceContactField;

        /// <remarks/>
        public string ProviderName
        {
            get
            {
                return this.providerNameField;
            }
            set
            {
                this.providerNameField = value;
            }
        }

        /// <remarks/>
        public OnlineResourceType ProviderSite
        {
            get
            {
                return this.providerSiteField;
            }
            set
            {
                this.providerSiteField = value;
            }
        }

        /// <remarks/>
        public ResponsiblePartySubsetType ServiceContact
        {
            get
            {
                return this.serviceContactField;
            }
            set
            {
                this.serviceContactField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestMethodType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class OnlineResourceType
    {

        private typeType typeField;

        private bool typeFieldSpecified;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        public OnlineResourceType()
        {
            this.typeField = typeType.simple;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public typeType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class RequestMethodType : OnlineResourceType
    {

        private DomainType[] constraintField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint
        {
            get
            {
                return this.constraintField;
            }
            set
            {
                this.constraintField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class DomainType : UnNamedDomainType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class UnNamedDomainType
    {

        private object[] allowedValuesField;

        private AnyValue anyValueField;

        private NoValues noValuesField;

        private ValuesReference valuesReferenceField;

        private ValueType defaultValueField;

        private DomainMetadataType meaningField;

        private DomainMetadataType dataTypeField;

        private DomainMetadataType uOMField;

        private DomainMetadataType referenceSystemField;

        private MetadataType[] metadataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Range", typeof(RangeType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", typeof(ValueType), IsNullable = false)]
        public object[] AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        public AnyValue AnyValue
        {
            get
            {
                return this.anyValueField;
            }
            set
            {
                this.anyValueField = value;
            }
        }

        /// <remarks/>
        public NoValues NoValues
        {
            get
            {
                return this.noValuesField;
            }
            set
            {
                this.noValuesField = value;
            }
        }

        /// <remarks/>
        public ValuesReference ValuesReference
        {
            get
            {
                return this.valuesReferenceField;
            }
            set
            {
                this.valuesReferenceField = value;
            }
        }

        /// <remarks/>
        public ValueType DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        public DomainMetadataType Meaning
        {
            get
            {
                return this.meaningField;
            }
            set
            {
                this.meaningField = value;
            }
        }

        /// <remarks/>
        public DomainMetadataType DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        public DomainMetadataType UOM
        {
            get
            {
                return this.uOMField;
            }
            set
            {
                this.uOMField = value;
            }
        }

        /// <remarks/>
        public DomainMetadataType ReferenceSystem
        {
            get
            {
                return this.referenceSystemField;
            }
            set
            {
                this.referenceSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Range", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class RangeType
    {

        private ValueType minimumValueField;

        private ValueType maximumValueField;

        private ValueType spacingField;

        private RangeTypeRangeClosure rangeClosureField;

        private bool rangeClosureFieldSpecified;

        public RangeType()
        {
            this.rangeClosureField = RangeTypeRangeClosure.closed;
        }

        /// <remarks/>
        public ValueType MinimumValue
        {
            get
            {
                return this.minimumValueField;
            }
            set
            {
                this.minimumValueField = value;
            }
        }

        /// <remarks/>
        public ValueType MaximumValue
        {
            get
            {
                return this.maximumValueField;
            }
            set
            {
                this.maximumValueField = value;
            }
        }

        /// <remarks/>
        public ValueType Spacing
        {
            get
            {
                return this.spacingField;
            }
            set
            {
                this.spacingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        [System.ComponentModel.DefaultValueAttribute(RangeTypeRangeClosure.closed)]
        public RangeTypeRangeClosure rangeClosure
        {
            get
            {
                return this.rangeClosureField;
            }
            set
            {
                this.rangeClosureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rangeClosureSpecified
        {
            get
            {
                return this.rangeClosureFieldSpecified;
            }
            set
            {
                this.rangeClosureFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Value", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ValueType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    public enum RangeTypeRangeClosure
    {

        /// <remarks/>
        closed,

        /// <remarks/>
        open,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("open-closed")]
        openclosed,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("closed-open")]
        closedopen,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class AnyValue
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class NoValues
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ValuesReference
    {

        private string referenceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Meaning", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class DomainMetadataType
    {

        private string referenceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class ResponsiblePartySubsetType
    {

        private string individualNameField;

        private string positionNameField;

        private ContactType contactInfoField;

        private CodeType roleField;

        /// <remarks/>
        public string IndividualName
        {
            get
            {
                return this.individualNameField;
            }
            set
            {
                this.individualNameField = value;
            }
        }

        /// <remarks/>
        public string PositionName
        {
            get
            {
                return this.positionNameField;
            }
            set
            {
                this.positionNameField = value;
            }
        }

        /// <remarks/>
        public ContactType ContactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                this.contactInfoField = value;
            }
        }

        /// <remarks/>
        public CodeType Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ContactInfo", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ContactType
    {

        private TelephoneType phoneField;

        private AddressType addressField;

        private OnlineResourceType onlineResourceField;

        private string hoursOfServiceField;

        private string contactInstructionsField;

        /// <remarks/>
        public TelephoneType Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public OnlineResourceType OnlineResource
        {
            get
            {
                return this.onlineResourceField;
            }
            set
            {
                this.onlineResourceField = value;
            }
        }

        /// <remarks/>
        public string HoursOfService
        {
            get
            {
                return this.hoursOfServiceField;
            }
            set
            {
                this.hoursOfServiceField = value;
            }
        }

        /// <remarks/>
        public string ContactInstructions
        {
            get
            {
                return this.contactInstructionsField;
            }
            set
            {
                this.contactInstructionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class TelephoneType
    {

        private string[] voiceField;

        private string[] facsimileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Voice")]
        public string[] Voice
        {
            get
            {
                return this.voiceField;
            }
            set
            {
                this.voiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Facsimile")]
        public string[] Facsimile
        {
            get
            {
                return this.facsimileField;
            }
            set
            {
                this.facsimileField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class AddressType
    {

        private string[] deliveryPointField;

        private string cityField;

        private string administrativeAreaField;

        private string postalCodeField;

        private string countryField;

        private string[] electronicMailAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPoint")]
        public string[] DeliveryPoint
        {
            get
            {
                return this.deliveryPointField;
            }
            set
            {
                this.deliveryPointField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string AdministrativeArea
        {
            get
            {
                return this.administrativeAreaField;
            }
            set
            {
                this.administrativeAreaField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicMailAddress")]
        public string[] ElectronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class OperationsMetadata
    {

        private Operation[] operationField;

        private DomainType[] parameterField;

        private DomainType[] constraintField;

        private object extendedCapabilitiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public Operation[] Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public DomainType[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint
        {
            get
            {
                return this.constraintField;
            }
            set
            {
                this.constraintField = value;
            }
        }

        /// <remarks/>
        public object ExtendedCapabilities
        {
            get
            {
                return this.extendedCapabilitiesField;
            }
            set
            {
                this.extendedCapabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class Operation
    {

        private DCP[] dCPField;

        private DomainType[] parameterField;

        private DomainType[] constraintField;

        private MetadataType[] metadataField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DCP")]
        public DCP[] DCP
        {
            get
            {
                return this.dCPField;
            }
            set
            {
                this.dCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public DomainType[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint
        {
            get
            {
                return this.constraintField;
            }
            set
            {
                this.constraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class DCP
    {

        private HTTP itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTTP")]
        public HTTP Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class HTTP
    {

        private RequestMethodType[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Get", typeof(RequestMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Post", typeof(RequestMethodType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public RequestMethodType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        Get,

        /// <remarks/>
        Post,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("PointOfContact", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ResponsiblePartyType
    {

        private string individualNameField;

        private string organisationNameField;

        private string positionNameField;

        private ContactType contactInfoField;

        private CodeType roleField;

        /// <remarks/>
        public string IndividualName
        {
            get
            {
                return this.individualNameField;
            }
            set
            {
                this.individualNameField = value;
            }
        }

        /// <remarks/>
        public string OrganisationName
        {
            get
            {
                return this.organisationNameField;
            }
            set
            {
                this.organisationNameField = value;
            }
        }

        /// <remarks/>
        public string PositionName
        {
            get
            {
                return this.positionNameField;
            }
            set
            {
                this.positionNameField = value;
            }
        }

        /// <remarks/>
        public ContactType ContactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                this.contactInfoField = value;
            }
        }

        /// <remarks/>
        public CodeType Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class arcType
    {

        private titleEltType[] titleField;

        private typeType typeField;

        private string arcroleField;

        private string title1Field;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        private string fromField;

        private string toField;

        public arcType()
        {
            this.typeField = typeType.arc;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public titleEltType[] title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string title1
        {
            get
            {
                return this.title1Field;
            }
            set
            {
                this.title1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "NCName")]
        public string from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "NCName")]
        public string to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class titleEltType
    {

        private System.Xml.XmlNode[] anyField;

        private typeType typeField;

        private string langField;

        public titleEltType()
        {
            this.typeField = typeType.title;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class locatorType
    {

        private titleEltType[] titleField;

        private typeType typeField;

        private string hrefField;

        private string roleField;

        private string title1Field;

        private string labelField;

        public locatorType()
        {
            this.typeField = typeType.locator;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public titleEltType[] title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string title1
        {
            get
            {
                return this.title1Field;
            }
            set
            {
                this.title1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "NCName")]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class resourceType
    {

        private System.Xml.XmlNode[] anyField;

        private typeType typeField;

        private string roleField;

        private string titleField;

        private string labelField;

        public resourceType()
        {
            this.typeField = typeType.resource;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "NCName")]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class extended
    {

        private object[] itemsField;

        private typeType typeField;

        private string roleField;

        private string titleField;

        public extended()
        {
            this.typeField = typeType.extended;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arc", typeof(arcType))]
        [System.Xml.Serialization.XmlElementAttribute("locator", typeof(locatorType))]
        [System.Xml.Serialization.XmlElementAttribute("resource", typeof(resourceType))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(titleEltType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    public partial class simple
    {

        private System.Xml.XmlNode[] anyField;

        private typeType typeField;

        private bool typeFieldSpecified;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        public simple()
        {
            this.typeField = typeType.simple;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public typeType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public partial class ContentsBaseType
    {

        private DatasetDescriptionSummaryBaseType[] datasetDescriptionSummaryField;

        private MetadataType[] otherSourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public DatasetDescriptionSummaryBaseType[] DatasetDescriptionSummary
        {
            get
            {
                return this.datasetDescriptionSummaryField;
            }
            set
            {
                this.datasetDescriptionSummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherSource")]
        public MetadataType[] OtherSource
        {
            get
            {
                return this.otherSourceField;
            }
            set
            {
                this.otherSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("GetResourceByID", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class GetResourceByIdType
    {

        private string[] resourceIDField;

        private string outputFormatField;

        private string serviceField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceID", DataType = "anyURI")]
        public string[] ResourceID
        {
            get
            {
                return this.resourceIDField;
            }
            set
            {
                this.resourceIDField = value;
            }
        }

        /// <remarks/>
        public string OutputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class SortPropertyType
    {

        private string valueReferenceField;

        private SortOrderType sortOrderField;

        private bool sortOrderFieldSpecified;

        /// <remarks/>
        public string ValueReference
        {
            get
            {
                return this.valueReferenceField;
            }
            set
            {
                this.valueReferenceField = value;
            }
        }

        /// <remarks/>
        public SortOrderType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public enum SortOrderType
    {

        /// <remarks/>
        DESC,

        /// <remarks/>
        ASC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractSortingClauseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractProjectionClauseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class EmptyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class CreatedOrModifiedFeatureType
    {

        private ResourceIdType[] resourceIdField;

        private string handleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceId", Namespace = "http://www.opengis.net/fes/2.0")]
        public ResourceIdType[] ResourceId
        {
            get
            {
                return this.resourceIdField;
            }
            set
            {
                this.resourceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle
        {
            get
            {
                return this.handleField;
            }
            set
            {
                this.handleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ResourceId", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class ResourceIdType : AbstractIdType
    {

        private string ridField;

        private string previousRidField;

        private string versionField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rid
        {
            get
            {
                return this.ridField;
            }
            set
            {
                this.ridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string previousRid
        {
            get
            {
                return this.previousRidField;
            }
            set
            {
                this.previousRidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResourceIdType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractIdType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class TransactionSummaryType
    {

        private string totalInsertedField;

        private string totalUpdatedField;

        private string totalReplacedField;

        private string totalDeletedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string totalInserted
        {
            get
            {
                return this.totalInsertedField;
            }
            set
            {
                this.totalInsertedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string totalUpdated
        {
            get
            {
                return this.totalUpdatedField;
            }
            set
            {
                this.totalUpdatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string totalReplaced
        {
            get
            {
                return this.totalReplacedField;
            }
            set
            {
                this.totalReplacedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string totalDeleted
        {
            get
            {
                return this.totalDeletedField;
            }
            set
            {
                this.totalDeletedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class FeaturesNotLockedType
    {

        private ResourceIdType[] resourceIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceId", Namespace = "http://www.opengis.net/fes/2.0")]
        public ResourceIdType[] ResourceId
        {
            get
            {
                return this.resourceIdField;
            }
            set
            {
                this.resourceIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class FeaturesLockedType
    {

        private ResourceIdType[] resourceIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceId", Namespace = "http://www.opengis.net/fes/2.0")]
        public ResourceIdType[] ResourceId
        {
            get
            {
                return this.resourceIdField;
            }
            set
            {
                this.resourceIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class StoredQueryListItemType
    {

        private Title[] titleField;

        private System.Xml.XmlQualifiedName[] returnFeatureTypeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnFeatureType")]
        public System.Xml.XmlQualifiedName[] ReturnFeatureType
        {
            get
            {
                return this.returnFeatureTypeField;
            }
            set
            {
                this.returnFeatureTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Exception", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ExceptionType
    {

        private string[] exceptionTextField;

        private string exceptionCodeField;

        private string locatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExceptionText")]
        public string[] ExceptionText
        {
            get
            {
                return this.exceptionTextField;
            }
            set
            {
                this.exceptionTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exceptionCode
        {
            get
            {
                return this.exceptionCodeField;
            }
            set
            {
                this.exceptionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string locator
        {
            get
            {
                return this.locatorField;
            }
            set
            {
                this.locatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class MetadataURLType
    {

        private typeType typeField;

        private bool typeFieldSpecified;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        private string aboutField;

        public MetadataURLType()
        {
            this.typeField = typeType.simple;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public typeType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string about
        {
            get
            {
                return this.aboutField;
            }
            set
            {
                this.aboutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class OutputFormatListType
    {

        private string[] formatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public string[] Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class FeatureTypeType
    {

        private System.Xml.XmlQualifiedName nameField;

        private Title[] titleField;

        private Abstract[] abstractField;

        private KeywordsType[] keywordsField;

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private OutputFormatListType outputFormatsField;

        private WGS84BoundingBoxType[] wGS84BoundingBoxField;

        private MetadataURLType[] metadataURLField;

        private ElementType[] extendedDescriptionField;

        /// <remarks/>
        public System.Xml.XmlQualifiedName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keywords", Namespace = "http://www.opengis.net/ows/1.1")]
        public KeywordsType[] Keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefaultCRS", typeof(string), DataType = "anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("NoCRS", typeof(FeatureTypeTypeNoCRS))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCRS", typeof(string), DataType = "anyURI")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public OutputFormatListType OutputFormats
        {
            get
            {
                return this.outputFormatsField;
            }
            set
            {
                this.outputFormatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox", Namespace = "http://www.opengis.net/ows/1.1")]
        public WGS84BoundingBoxType[] WGS84BoundingBox
        {
            get
            {
                return this.wGS84BoundingBoxField;
            }
            set
            {
                this.wGS84BoundingBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MetadataURL")]
        public MetadataURLType[] MetadataURL
        {
            get
            {
                return this.metadataURLField;
            }
            set
            {
                this.metadataURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable = false)]
        public ElementType[] ExtendedDescription
        {
            get
            {
                return this.extendedDescriptionField;
            }
            set
            {
                this.extendedDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class Abstract
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class FeatureTypeTypeNoCRS
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        DefaultCRS,

        /// <remarks/>
        NoCRS,

        /// <remarks/>
        OtherCRS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Element", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ElementType
    {

        private MetadataType metadataField;

        private ValueListType valueListField;

        private string nameField;

        private System.Xml.XmlQualifiedName typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        public ValueListType ValueList
        {
            get
            {
                return this.valueListField;
            }
            set
            {
                this.valueListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName type
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ValueList", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ValueListType
    {

        private object[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public object[] Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class ExtensionOpsType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnaryLogicOpType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryLogicOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class LogicOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Not", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class UnaryLogicOpType : LogicOpsType
    {

        private object itemField;

        /// <remarks/>
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("And", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryLogicOpType : LogicOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryTemporalOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class TemporalOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("After", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryTemporalOpType : TemporalOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class FunctionType
    {

        private object[] itemsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Literal", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class LiteralType
    {

        private System.Xml.XmlNode[] anyField;

        private System.Xml.XmlQualifiedName typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName type
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class MeasureType
    {

        private string uomField;

        private double valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom
        {
            get
            {
                return this.uomField;
            }
            set
            {
                this.uomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBufferType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BBOXType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySpatialOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class SpatialOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class DistanceBufferType : SpatialOpsType
    {

        private object[] itemsField;

        private MeasureType distanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public MeasureType Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("BBOX", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BBOXType : SpatialOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Equals", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinarySpatialOpType : SpatialOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class UpperBoundaryType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class LowerBoundaryType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsBetweenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsNilType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsNullType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsLikeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryComparisonOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class ComparisonOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsBetweenType : ComparisonOpsType
    {

        private object itemField;

        private LowerBoundaryType lowerBoundaryField;

        private UpperBoundaryType upperBoundaryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public LowerBoundaryType LowerBoundary
        {
            get
            {
                return this.lowerBoundaryField;
            }
            set
            {
                this.lowerBoundaryField = value;
            }
        }

        /// <remarks/>
        public UpperBoundaryType UpperBoundary
        {
            get
            {
                return this.upperBoundaryField;
            }
            set
            {
                this.upperBoundaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNil", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsNilType : ComparisonOpsType
    {

        private object itemField;

        private string nilReasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNull", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsNullType : ComparisonOpsType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsLikeType : ComparisonOpsType
    {

        private object[] itemsField;

        private string wildCardField;

        private string singleCharField;

        private string escapeCharField;

        private bool matchCaseField;

        public PropertyIsLikeType()
        {
            this.matchCaseField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wildCard
        {
            get
            {
                return this.wildCardField;
            }
            set
            {
                this.wildCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string singleChar
        {
            get
            {
                return this.singleCharField;
            }
            set
            {
                this.singleCharField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string escapeChar
        {
            get
            {
                return this.escapeCharField;
            }
            set
            {
                this.escapeCharField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase
        {
            get
            {
                return this.matchCaseField;
            }
            set
            {
                this.matchCaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsEqualTo", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryComparisonOpType : ComparisonOpsType
    {

        private object[] itemsField;

        private bool matchCaseField;

        private MatchActionType matchActionField;

        public BinaryComparisonOpType()
        {
            this.matchCaseField = true;
            this.matchActionField = MatchActionType.Any;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase
        {
            get
            {
                return this.matchCaseField;
            }
            set
            {
                this.matchCaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MatchActionType.Any)]
        public MatchActionType matchAction
        {
            get
            {
                return this.matchActionField;
            }
            set
            {
                this.matchActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public enum MatchActionType
    {

        /// <remarks/>
        All,

        /// <remarks/>
        Any,

        /// <remarks/>
        One,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractSelectionClauseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Filter", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class FilterType : AbstractSelectionClauseType
    {

        private ComparisonOpsType comparisonOpsField;

        private SpatialOpsType spatialOpsField;

        private TemporalOpsType temporalOpsField;

        private LogicOpsType logicOpsField;

        private ExtensionOpsType extensionOpsField;

        private FunctionType functionField;

        private AbstractIdType[] _IdField;

        /// <remarks/>
        public ComparisonOpsType comparisonOps
        {
            get
            {
                return this.comparisonOpsField;
            }
            set
            {
                this.comparisonOpsField = value;
            }
        }

        /// <remarks/>
        public SpatialOpsType spatialOps
        {
            get
            {
                return this.spatialOpsField;
            }
            set
            {
                this.spatialOpsField = value;
            }
        }

        /// <remarks/>
        public TemporalOpsType temporalOps
        {
            get
            {
                return this.temporalOpsField;
            }
            set
            {
                this.temporalOpsField = value;
            }
        }

        /// <remarks/>
        public LogicOpsType logicOps
        {
            get
            {
                return this.logicOpsField;
            }
            set
            {
                this.logicOpsField = value;
            }
        }

        /// <remarks/>
        public ExtensionOpsType extensionOps
        {
            get
            {
                return this.extensionOpsField;
            }
            set
            {
                this.extensionOpsField = value;
            }
        }

        /// <remarks/>
        public FunctionType Function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Id")]
        public AbstractIdType[] _Id
        {
            get
            {
                return this._IdField;
            }
            set
            {
                this._IdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NativeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReplaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsertType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public abstract partial class AbstractTransactionActionType
    {

        private string handleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle
        {
            get
            {
                return this.handleField;
            }
            set
            {
                this.handleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class QueryExpressionTextType
    {

        private System.Xml.XmlElement itemField;

        private string[] textField;

        private System.Xml.XmlQualifiedName[] returnFeatureTypesField;

        private string languageField;

        private bool isPrivateField;

        public QueryExpressionTextType()
        {
            this.isPrivateField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName[] returnFeatureTypes
        {
            get
            {
                return this.returnFeatureTypesField;
            }
            set
            {
                this.returnFeatureTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isPrivate
        {
            get
            {
                return this.isPrivateField;
            }
            set
            {
                this.isPrivateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class ParameterExpressionType
    {

        private Title[] titleField;

        private Abstract[] abstractField;

        private MetadataType[] metadataField;

        private string nameField;

        private System.Xml.XmlQualifiedName typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName type
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class StoredQueryDescriptionType
    {

        private Title[] titleField;

        private Abstract[] abstractField;

        private MetadataType[] metadataField;

        private ParameterExpressionType[] parameterField;

        private QueryExpressionTextType[] queryExpressionTextField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract
        {
            get
            {
                return this.abstractField;
            }
            set
            {
                this.abstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterExpressionType[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryExpressionText")]
        public QueryExpressionTextType[] QueryExpressionText
        {
            get
            {
                return this.queryExpressionTextField;
            }
            set
            {
                this.queryExpressionTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LockFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateStoredQueryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeStoredQueriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListStoredQueriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureWithLockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetPropertyValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeFeatureTypeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public abstract partial class BaseRequestType
    {

        private string serviceField;

        private string versionField;

        private string handleField;

        public BaseRequestType()
        {
            this.serviceField = "WFS";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle
        {
            get
            {
                return this.handleField;
            }
            set
            {
                this.handleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class ParameterType
    {

        private System.Xml.XmlNode[] anyField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractAdhocQueryExpressionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StoredQueryType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractQueryExpressionType
    {

        private string handleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle
        {
            get
            {
                return this.handleField;
            }
            set
            {
                this.handleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractAdhocQueryExpressionType : AbstractQueryExpressionType
    {

        private object[] abstractProjectionClauseField;

        private object abstractSelectionClauseField;

        private object abstractSortingClauseField;

        private string[] typeNamesField;

        private string[] aliasesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractProjectionClause")]
        public object[] AbstractProjectionClause
        {
            get
            {
                return this.abstractProjectionClauseField;
            }
            set
            {
                this.abstractProjectionClauseField = value;
            }
        }

        /// <remarks/>
        public object AbstractSelectionClause
        {
            get
            {
                return this.abstractSelectionClauseField;
            }
            set
            {
                this.abstractSelectionClauseField = value;
            }
        }

        /// <remarks/>
        public object AbstractSortingClause
        {
            get
            {
                return this.abstractSortingClauseField;
            }
            set
            {
                this.abstractSortingClauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] typeNames
        {
            get
            {
                return this.typeNamesField;
            }
            set
            {
                this.typeNamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string[] aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Query", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class QueryType : AbstractAdhocQueryExpressionType
    {

        private string srsNameField;

        private string featureVersionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string srsName
        {
            get
            {
                return this.srsNameField;
            }
            set
            {
                this.srsNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureVersion
        {
            get
            {
                return this.featureVersionField;
            }
            set
            {
                this.featureVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("StoredQuery", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class StoredQueryType : AbstractQueryExpressionType
    {

        private ParameterType[] parameterField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GetCapabilitiesType", Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class GetCapabilitiesType1 : GetCapabilitiesType
    {

        private string serviceField;

        public GetCapabilitiesType1()
        {
            this.serviceField = "WFS";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("WFS_Capabilities", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class WFS_CapabilitiesType : CapabilitiesBaseType
    {

        private WFS_CapabilitiesTypeWSDL wSDLField;

        private FeatureTypeType[] featureTypeListField;

        private Filter_Capabilities filter_CapabilitiesField;

        /// <remarks/>
        public WFS_CapabilitiesTypeWSDL WSDL
        {
            get
            {
                return this.wSDLField;
            }
            set
            {
                this.wSDLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FeatureType", IsNullable = false)]
        public FeatureTypeType[] FeatureTypeList
        {
            get
            {
                return this.featureTypeListField;
            }
            set
            {
                this.featureTypeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
        public Filter_Capabilities Filter_Capabilities
        {
            get
            {
                return this.filter_CapabilitiesField;
            }
            set
            {
                this.filter_CapabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class WFS_CapabilitiesTypeWSDL
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class Filter_Capabilities
    {

        private DomainType[] conformanceField;

        private ResourceIdentifierType[] id_CapabilitiesField;

        private Scalar_CapabilitiesType scalar_CapabilitiesField;

        private Spatial_CapabilitiesType spatial_CapabilitiesField;

        private Temporal_CapabilitiesType temporal_CapabilitiesField;

        private AvailableFunctionType[] functionsField;

        private Extended_CapabilitiesType extended_CapabilitiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Constraint", IsNullable = false)]
        public DomainType[] Conformance
        {
            get
            {
                return this.conformanceField;
            }
            set
            {
                this.conformanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceIdentifier", IsNullable = false)]
        public ResourceIdentifierType[] Id_Capabilities
        {
            get
            {
                return this.id_CapabilitiesField;
            }
            set
            {
                this.id_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Scalar_CapabilitiesType Scalar_Capabilities
        {
            get
            {
                return this.scalar_CapabilitiesField;
            }
            set
            {
                this.scalar_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Spatial_CapabilitiesType Spatial_Capabilities
        {
            get
            {
                return this.spatial_CapabilitiesField;
            }
            set
            {
                this.spatial_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Temporal_CapabilitiesType Temporal_Capabilities
        {
            get
            {
                return this.temporal_CapabilitiesField;
            }
            set
            {
                this.temporal_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Function", IsNullable = false)]
        public AvailableFunctionType[] Functions
        {
            get
            {
                return this.functionsField;
            }
            set
            {
                this.functionsField = value;
            }
        }

        /// <remarks/>
        public Extended_CapabilitiesType Extended_Capabilities
        {
            get
            {
                return this.extended_CapabilitiesField;
            }
            set
            {
                this.extended_CapabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureTypeList", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class FeatureTypeListType
    {

        private FeatureTypeType[] featureTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureType")]
        public FeatureTypeType[] FeatureType
        {
            get
            {
                return this.featureTypeField;
            }
            set
            {
                this.featureTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeFeatureType", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class DescribeFeatureTypeType : BaseRequestType
    {

        private System.Xml.XmlQualifiedName[] typeNameField;

        private string outputFormatField;

        public DescribeFeatureTypeType()
        {
            this.outputFormatField = "application/gml+xml; version=3.2";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TypeName")]
        public System.Xml.XmlQualifiedName[] TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string outputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetPropertyValue", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class GetPropertyValueType : BaseRequestType
    {

        private AbstractQueryExpressionType abstractQueryExpressionField;

        private string valueReferenceField;

        private string resolvePathField;

        private string startIndexField;

        private string countField;

        private ResultTypeType resultTypeField;

        private string outputFormatField;

        private ResolveValueType resolveField;

        private string resolveDepthField;

        private string resolveTimeoutField;

        public GetPropertyValueType()
        {
            this.startIndexField = "0";
            this.resultTypeField = ResultTypeType.results;
            this.outputFormatField = "application/gml+xml; version=3.2";
            this.resolveField = ResolveValueType.none;
            this.resolveDepthField = "*";
            this.resolveTimeoutField = "300";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
        public AbstractQueryExpressionType AbstractQueryExpression
        {
            get
            {
                return this.abstractQueryExpressionField;
            }
            set
            {
                this.abstractQueryExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string valueReference
        {
            get
            {
                return this.valueReferenceField;
            }
            set
            {
                this.valueReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resolvePath
        {
            get
            {
                return this.resolvePathField;
            }
            set
            {
                this.resolvePathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string startIndex
        {
            get
            {
                return this.startIndexField;
            }
            set
            {
                this.startIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResultTypeType.results)]
        public ResultTypeType resultType
        {
            get
            {
                return this.resultTypeField;
            }
            set
            {
                this.resultTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string outputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResolveValueType.none)]
        public ResolveValueType resolve
        {
            get
            {
                return this.resolveField;
            }
            set
            {
                this.resolveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("*")]
        public string resolveDepth
        {
            get
            {
                return this.resolveDepthField;
            }
            set
            {
                this.resolveDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string resolveTimeout
        {
            get
            {
                return this.resolveTimeoutField;
            }
            set
            {
                this.resolveTimeoutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public enum ResultTypeType
    {

        /// <remarks/>
        results,

        /// <remarks/>
        hits,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public enum ResolveValueType
    {

        /// <remarks/>
        local,

        /// <remarks/>
        remote,

        /// <remarks/>
        all,

        /// <remarks/>
        none,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ValueCollection", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ValueCollectionType
    {

        private MemberPropertyType[] memberField;

        private additionalValues additionalValuesField;

        private truncatedResponse truncatedResponseField;

        private System.DateTime timeStampField;

        private string numberMatchedField;

        private string numberReturnedField;

        private string nextField;

        private string previousField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }

        /// <remarks/>
        public additionalValues additionalValues
        {
            get
            {
                return this.additionalValuesField;
            }
            set
            {
                this.additionalValuesField = value;
            }
        }

        /// <remarks/>
        public truncatedResponse truncatedResponse
        {
            get
            {
                return this.truncatedResponseField;
            }
            set
            {
                this.truncatedResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime timeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numberMatched
        {
            get
            {
                return this.numberMatchedField;
            }
            set
            {
                this.numberMatchedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string numberReturned
        {
            get
            {
                return this.numberReturnedField;
            }
            set
            {
                this.numberReturnedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string next
        {
            get
            {
                return this.nextField;
            }
            set
            {
                this.nextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string previous
        {
            get
            {
                return this.previousField;
            }
            set
            {
                this.previousField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("member", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class MemberPropertyType
    {

        private object itemField;

        private string[] textField;

        private string stateField;

        private typeType typeField;

        private bool typeFieldSpecified;

        private string hrefField;

        private string roleField;

        private string arcroleField;

        private string titleField;

        private showType showField;

        private bool showFieldSpecified;

        private actuateType actuateField;

        private bool actuateFieldSpecified;

        public MemberPropertyType()
        {
            this.typeField = typeType.simple;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof(FeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleFeatureCollection", typeof(SimpleFeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Tuple", typeof(TupleType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public typeType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string arcrole
        {
            get
            {
                return this.arcroleField;
            }
            set
            {
                this.arcroleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public showType show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified
        {
            get
            {
                return this.showFieldSpecified;
            }
            set
            {
                this.showFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public actuateType actuate
        {
            get
            {
                return this.actuateField;
            }
            set
            {
                this.actuateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified
        {
            get
            {
                return this.actuateFieldSpecified;
            }
            set
            {
                this.actuateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureCollection", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class FeatureCollectionType : SimpleFeatureCollectionType
    {

        private additionalObjects additionalObjectsField;

        private truncatedResponse truncatedResponseField;

        private System.DateTime timeStampField;

        private string numberMatchedField;

        private string numberReturnedField;

        private string nextField;

        private string previousField;

        private string lockIdField;

        /// <remarks/>
        public additionalObjects additionalObjects
        {
            get
            {
                return this.additionalObjectsField;
            }
            set
            {
                this.additionalObjectsField = value;
            }
        }

        /// <remarks/>
        public truncatedResponse truncatedResponse
        {
            get
            {
                return this.truncatedResponseField;
            }
            set
            {
                this.truncatedResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime timeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numberMatched
        {
            get
            {
                return this.numberMatchedField;
            }
            set
            {
                this.numberMatchedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string numberReturned
        {
            get
            {
                return this.numberReturnedField;
            }
            set
            {
                this.numberReturnedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string next
        {
            get
            {
                return this.nextField;
            }
            set
            {
                this.nextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string previous
        {
            get
            {
                return this.previousField;
            }
            set
            {
                this.previousField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId
        {
            get
            {
                return this.lockIdField;
            }
            set
            {
                this.lockIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class additionalObjects
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof(FeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleFeatureCollection", typeof(SimpleFeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueCollection", typeof(ValueCollectionType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SimpleFeatureCollection", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class SimpleFeatureCollectionType
    {

        private System.Xml.XmlElement boundedByField;

        private MemberPropertyType[] memberField;

        /// <remarks/>
        public System.Xml.XmlElement boundedBy
        {
            get
            {
                return this.boundedByField;
            }
            set
            {
                this.boundedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class truncatedResponse
    {

        private ExceptionReport exceptionReportField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public ExceptionReport ExceptionReport
        {
            get
            {
                return this.exceptionReportField;
            }
            set
            {
                this.exceptionReportField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class ExceptionReport
    {

        private ExceptionType[] exceptionField;

        private string versionField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exception")]
        public ExceptionType[] Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Tuple", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class TupleType
    {

        private MemberPropertyType[] memberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class additionalValues
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof(FeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleFeatureCollection", typeof(SimpleFeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueCollection", typeof(ValueCollectionType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureWithLockType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeature", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class GetFeatureType : BaseRequestType
    {

        private AbstractQueryExpressionType[] abstractQueryExpressionField;

        private string startIndexField;

        private string countField;

        private ResultTypeType resultTypeField;

        private string outputFormatField;

        private ResolveValueType resolveField;

        private string resolveDepthField;

        private string resolveTimeoutField;

        public GetFeatureType()
        {
            this.startIndexField = "0";
            this.resultTypeField = ResultTypeType.results;
            this.outputFormatField = "application/gml+xml; version=3.2";
            this.resolveField = ResolveValueType.none;
            this.resolveDepthField = "*";
            this.resolveTimeoutField = "300";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractQueryExpression", Namespace = "http://www.opengis.net/fes/2.0")]
        public AbstractQueryExpressionType[] AbstractQueryExpression
        {
            get
            {
                return this.abstractQueryExpressionField;
            }
            set
            {
                this.abstractQueryExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string startIndex
        {
            get
            {
                return this.startIndexField;
            }
            set
            {
                this.startIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResultTypeType.results)]
        public ResultTypeType resultType
        {
            get
            {
                return this.resultTypeField;
            }
            set
            {
                this.resultTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string outputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResolveValueType.none)]
        public ResolveValueType resolve
        {
            get
            {
                return this.resolveField;
            }
            set
            {
                this.resolveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("*")]
        public string resolveDepth
        {
            get
            {
                return this.resolveDepthField;
            }
            set
            {
                this.resolveDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string resolveTimeout
        {
            get
            {
                return this.resolveTimeoutField;
            }
            set
            {
                this.resolveTimeoutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureWithLock", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class GetFeatureWithLockType : GetFeatureType
    {

        private string expiryField;

        private AllSomeType lockActionField;

        public GetFeatureWithLockType()
        {
            this.expiryField = "300";
            this.lockActionField = AllSomeType.ALL;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType lockAction
        {
            get
            {
                return this.lockActionField;
            }
            set
            {
                this.lockActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public enum AllSomeType
    {

        /// <remarks/>
        ALL,

        /// <remarks/>
        SOME,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class PropertyName
    {

        private ResolveValueType resolveField;

        private string resolveDepthField;

        private string resolveTimeoutField;

        private string resolvePathField;

        private System.Xml.XmlQualifiedName valueField;

        public PropertyName()
        {
            this.resolveField = ResolveValueType.none;
            this.resolveDepthField = "*";
            this.resolveTimeoutField = "300";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResolveValueType.none)]
        public ResolveValueType resolve
        {
            get
            {
                return this.resolveField;
            }
            set
            {
                this.resolveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("*")]
        public string resolveDepth
        {
            get
            {
                return this.resolveDepthField;
            }
            set
            {
                this.resolveDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string resolveTimeout
        {
            get
            {
                return this.resolveTimeoutField;
            }
            set
            {
                this.resolveTimeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resolvePath
        {
            get
            {
                return this.resolvePathField;
            }
            set
            {
                this.resolvePathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.Xml.XmlQualifiedName Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ListStoredQueries", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ListStoredQueriesType : BaseRequestType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ListStoredQueriesResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ListStoredQueriesResponseType
    {

        private StoredQueryListItemType[] storedQueryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredQuery")]
        public StoredQueryListItemType[] StoredQuery
        {
            get
            {
                return this.storedQueryField;
            }
            set
            {
                this.storedQueryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeStoredQueries", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class DescribeStoredQueriesType : BaseRequestType
    {

        private string[] storedQueryIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryId", DataType = "anyURI")]
        public string[] StoredQueryId
        {
            get
            {
                return this.storedQueryIdField;
            }
            set
            {
                this.storedQueryIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeStoredQueriesResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class DescribeStoredQueriesResponseType
    {

        private StoredQueryDescriptionType[] storedQueryDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryDescription")]
        public StoredQueryDescriptionType[] StoredQueryDescription
        {
            get
            {
                return this.storedQueryDescriptionField;
            }
            set
            {
                this.storedQueryDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CreateStoredQuery", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class CreateStoredQueryType : BaseRequestType
    {

        private StoredQueryDescriptionType[] storedQueryDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryDefinition")]
        public StoredQueryDescriptionType[] StoredQueryDefinition
        {
            get
            {
                return this.storedQueryDefinitionField;
            }
            set
            {
                this.storedQueryDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CreateStoredQueryResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class CreateStoredQueryResponseType : ExecutionStatusType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateStoredQueryResponseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DropStoredQueryResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ExecutionStatusType
    {

        private string statusField;

        public ExecutionStatusType()
        {
            this.statusField = "OK";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class DropStoredQuery : BaseRequestType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeature", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class LockFeatureType : BaseRequestType
    {

        private AbstractQueryExpressionType[] abstractQueryExpressionField;

        private string lockIdField;

        private string expiryField;

        private AllSomeType lockActionField;

        public LockFeatureType()
        {
            this.expiryField = "300";
            this.lockActionField = AllSomeType.ALL;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractQueryExpression", Namespace = "http://www.opengis.net/fes/2.0")]
        public AbstractQueryExpressionType[] AbstractQueryExpression
        {
            get
            {
                return this.abstractQueryExpressionField;
            }
            set
            {
                this.abstractQueryExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId
        {
            get
            {
                return this.lockIdField;
            }
            set
            {
                this.lockIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string expiry
        {
            get
            {
                return this.expiryField;
            }
            set
            {
                this.expiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType lockAction
        {
            get
            {
                return this.lockActionField;
            }
            set
            {
                this.lockActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeatureResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class LockFeatureResponseType
    {

        private FeaturesLockedType featuresLockedField;

        private FeaturesNotLockedType featuresNotLockedField;

        private string lockIdField;

        /// <remarks/>
        public FeaturesLockedType FeaturesLocked
        {
            get
            {
                return this.featuresLockedField;
            }
            set
            {
                this.featuresLockedField = value;
            }
        }

        /// <remarks/>
        public FeaturesNotLockedType FeaturesNotLocked
        {
            get
            {
                return this.featuresNotLockedField;
            }
            set
            {
                this.featuresNotLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId
        {
            get
            {
                return this.lockIdField;
            }
            set
            {
                this.lockIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Transaction", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class TransactionType : BaseRequestType
    {

        private AbstractTransactionActionType[] itemsField;

        private string lockIdField;

        private AllSomeType releaseActionField;

        private string srsNameField;

        public TransactionType()
        {
            this.releaseActionField = AllSomeType.ALL;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delete", typeof(DeleteType))]
        [System.Xml.Serialization.XmlElementAttribute("Insert", typeof(InsertType))]
        [System.Xml.Serialization.XmlElementAttribute("Native", typeof(NativeType))]
        [System.Xml.Serialization.XmlElementAttribute("Replace", typeof(ReplaceType))]
        [System.Xml.Serialization.XmlElementAttribute("Update", typeof(UpdateType))]
        public AbstractTransactionActionType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId
        {
            get
            {
                return this.lockIdField;
            }
            set
            {
                this.lockIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType releaseAction
        {
            get
            {
                return this.releaseActionField;
            }
            set
            {
                this.releaseActionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string srsName
        {
            get
            {
                return this.srsNameField;
            }
            set
            {
                this.srsNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Delete", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class DeleteType : AbstractTransactionActionType
    {

        private FilterType filterField;

        private System.Xml.XmlQualifiedName typeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
        public FilterType Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName typeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Insert", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class InsertType : AbstractTransactionActionType
    {

        private System.Xml.XmlElement[] anyField;

        private string inputFormatField;

        private string srsNameField;

        public InsertType()
        {
            this.inputFormatField = "application/gml+xml; version=3.2";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string inputFormat
        {
            get
            {
                return this.inputFormatField;
            }
            set
            {
                this.inputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string srsName
        {
            get
            {
                return this.srsNameField;
            }
            set
            {
                this.srsNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Native", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class NativeType : AbstractTransactionActionType
    {

        private System.Xml.XmlNode[] anyField;

        private string vendorIdField;

        private bool safeToIgnoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vendorId
        {
            get
            {
                return this.vendorIdField;
            }
            set
            {
                this.vendorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool safeToIgnore
        {
            get
            {
                return this.safeToIgnoreField;
            }
            set
            {
                this.safeToIgnoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Replace", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class ReplaceType : AbstractTransactionActionType
    {

        private System.Xml.XmlElement anyField;

        private FilterType filterField;

        private string inputFormatField;

        private string srsNameField;

        public ReplaceType()
        {
            this.inputFormatField = "application/gml+xml; version=3.2";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
        public FilterType Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string inputFormat
        {
            get
            {
                return this.inputFormatField;
            }
            set
            {
                this.inputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string srsName
        {
            get
            {
                return this.srsNameField;
            }
            set
            {
                this.srsNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Update", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class UpdateType : AbstractTransactionActionType
    {

        private PropertyType[] propertyField;

        private FilterType filterField;

        private System.Xml.XmlQualifiedName typeNameField;

        private string inputFormatField;

        private string srsNameField;

        public UpdateType()
        {
            this.inputFormatField = "application/gml+xml; version=3.2";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public PropertyType[] Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
        public FilterType Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName typeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string inputFormat
        {
            get
            {
                return this.inputFormatField;
            }
            set
            {
                this.inputFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string srsName
        {
            get
            {
                return this.srsNameField;
            }
            set
            {
                this.srsNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Property", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class PropertyType
    {

        private PropertyTypeValueReference valueReferenceField;

        private object valueField;

        /// <remarks/>
        public PropertyTypeValueReference ValueReference
        {
            get
            {
                return this.valueReferenceField;
            }
            set
            {
                this.valueReferenceField = value;
            }
        }

        /// <remarks/>
        public object Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs/2.0")]
    public partial class PropertyTypeValueReference
    {

        private UpdateActionType actionField;

        private string valueField;

        public PropertyTypeValueReference()
        {
            this.actionField = UpdateActionType.replace;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(UpdateActionType.replace)]
        public UpdateActionType action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    public enum UpdateActionType
    {

        /// <remarks/>
        replace,

        /// <remarks/>
        insertBefore,

        /// <remarks/>
        insertAfter,

        /// <remarks/>
        remove,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TransactionResponse", Namespace = "http://www.opengis.net/wfs/2.0", IsNullable = false)]
    public partial class TransactionResponseType
    {

        private TransactionSummaryType transactionSummaryField;

        private CreatedOrModifiedFeatureType[] insertResultsField;

        private CreatedOrModifiedFeatureType[] updateResultsField;

        private CreatedOrModifiedFeatureType[] replaceResultsField;

        private string versionField;

        /// <remarks/>
        public TransactionSummaryType TransactionSummary
        {
            get
            {
                return this.transactionSummaryField;
            }
            set
            {
                this.transactionSummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable = false)]
        public CreatedOrModifiedFeatureType[] InsertResults
        {
            get
            {
                return this.insertResultsField;
            }
            set
            {
                this.insertResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable = false)]
        public CreatedOrModifiedFeatureType[] UpdateResults
        {
            get
            {
                return this.updateResultsField;
            }
            set
            {
                this.updateResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable = false)]
        public CreatedOrModifiedFeatureType[] ReplaceResults
        {
            get
            {
                return this.replaceResultsField;
            }
            set
            {
                this.replaceResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SortBy", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class SortByType
    {

        private SortPropertyType[] sortPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SortProperty")]
        public SortPropertyType[] SortProperty
        {
            get
            {
                return this.sortPropertyField;
            }
            set
            {
                this.sortPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public partial class AllowedValues
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Range", typeof(RangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(ValueType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }


}
