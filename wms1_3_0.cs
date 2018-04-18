using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// WMS 1.3.0
/// </summary>
namespace GeoSpatial.WMS
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class WMS_Capabilities
    {

        private Service serviceField;

        private Capability capabilityField;

        private string versionField;

        private string updateSequenceField;

        public WMS_Capabilities()
        {
            this.versionField = "1.3.0";
        }

        /// <remarks/>
        public Service Service
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
        public Capability Capability
        {
            get
            {
                return this.capabilityField;
            }
            set
            {
                this.capabilityField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Service
    {

        private ServiceName nameField;

        private string titleField;

        private string abstractField;

        private Keyword[] keywordListField;

        private OnlineResource onlineResourceField;

        private ContactInformation contactInformationField;

        private string feesField;

        private string accessConstraintsField;

        private string layerLimitField;

        private string maxWidthField;

        private string maxHeightField;

        /// <remarks/>
        public ServiceName Name
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
        public string Title
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
        public string Abstract
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Keyword", IsNullable = false)]
        public Keyword[] KeywordList
        {
            get
            {
                return this.keywordListField;
            }
            set
            {
                this.keywordListField = value;
            }
        }

        /// <remarks/>
        public OnlineResource OnlineResource
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
        public ContactInformation ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
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
        public string AccessConstraints
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LayerLimit
        {
            get
            {
                return this.layerLimitField;
            }
            set
            {
                this.layerLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxWidth
        {
            get
            {
                return this.maxWidthField;
            }
            set
            {
                this.maxWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxHeight
        {
            get
            {
                return this.maxHeightField;
            }
            set
            {
                this.maxHeightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    public enum ServiceName
    {

        /// <remarks/>
        WMS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Keyword
    {

        private string vocabularyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vocabulary
        {
            get
            {
                return this.vocabularyField;
            }
            set
            {
                this.vocabularyField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class OnlineResource
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

        public OnlineResource()
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class ContactInformation
    {

        private ContactPersonPrimary contactPersonPrimaryField;

        private string contactPositionField;

        private ContactAddress contactAddressField;

        private string contactVoiceTelephoneField;

        private string contactFacsimileTelephoneField;

        private string contactElectronicMailAddressField;

        /// <remarks/>
        public ContactPersonPrimary ContactPersonPrimary
        {
            get
            {
                return this.contactPersonPrimaryField;
            }
            set
            {
                this.contactPersonPrimaryField = value;
            }
        }

        /// <remarks/>
        public string ContactPosition
        {
            get
            {
                return this.contactPositionField;
            }
            set
            {
                this.contactPositionField = value;
            }
        }

        /// <remarks/>
        public ContactAddress ContactAddress
        {
            get
            {
                return this.contactAddressField;
            }
            set
            {
                this.contactAddressField = value;
            }
        }

        /// <remarks/>
        public string ContactVoiceTelephone
        {
            get
            {
                return this.contactVoiceTelephoneField;
            }
            set
            {
                this.contactVoiceTelephoneField = value;
            }
        }

        /// <remarks/>
        public string ContactFacsimileTelephone
        {
            get
            {
                return this.contactFacsimileTelephoneField;
            }
            set
            {
                this.contactFacsimileTelephoneField = value;
            }
        }

        /// <remarks/>
        public string ContactElectronicMailAddress
        {
            get
            {
                return this.contactElectronicMailAddressField;
            }
            set
            {
                this.contactElectronicMailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class ContactPersonPrimary
    {

        private string contactPersonField;

        private string contactOrganizationField;

        /// <remarks/>
        public string ContactPerson
        {
            get
            {
                return this.contactPersonField;
            }
            set
            {
                this.contactPersonField = value;
            }
        }

        /// <remarks/>
        public string ContactOrganization
        {
            get
            {
                return this.contactOrganizationField;
            }
            set
            {
                this.contactOrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class ContactAddress
    {

        private string addressTypeField;

        private string addressField;

        private string cityField;

        private string stateOrProvinceField;

        private string postCodeField;

        private string countryField;

        /// <remarks/>
        public string AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }

        /// <remarks/>
        public string Address
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
        public string StateOrProvince
        {
            get
            {
                return this.stateOrProvinceField;
            }
            set
            {
                this.stateOrProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Capability
    {

        private Request requestField;

        private string[] exceptionField;

        private object[] _ExtendedCapabilitiesField;

        private Layer layerField;

        /// <remarks/>
        public Request Request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Format", IsNullable = false)]
        public string[] Exception
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
        [System.Xml.Serialization.XmlElementAttribute("_ExtendedCapabilities")]
        public object[] _ExtendedCapabilities
        {
            get
            {
                return this._ExtendedCapabilitiesField;
            }
            set
            {
                this._ExtendedCapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Layer Layer
        {
            get
            {
                return this.layerField;
            }
            set
            {
                this.layerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Request
    {

        private OperationType getCapabilitiesField;

        private OperationType getMapField;

        private OperationType getFeatureInfoField;

        private OperationType[] _ExtendedOperationField;

        /// <remarks/>
        public OperationType GetCapabilities
        {
            get
            {
                return this.getCapabilitiesField;
            }
            set
            {
                this.getCapabilitiesField = value;
            }
        }

        /// <remarks/>
        public OperationType GetMap
        {
            get
            {
                return this.getMapField;
            }
            set
            {
                this.getMapField = value;
            }
        }

        /// <remarks/>
        public OperationType GetFeatureInfo
        {
            get
            {
                return this.getFeatureInfoField;
            }
            set
            {
                this.getFeatureInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_ExtendedOperation")]
        public OperationType[] _ExtendedOperation
        {
            get
            {
                return this._ExtendedOperationField;
            }
            set
            {
                this._ExtendedOperationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class OperationType
    {

        private string[] formatField;

        private DCPType[] dCPTypeField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DCPType")]
        public DCPType[] DCPType
        {
            get
            {
                return this.dCPTypeField;
            }
            set
            {
                this.dCPTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class DCPType
    {

        private HTTP hTTPField;

        /// <remarks/>
        public HTTP HTTP
        {
            get
            {
                return this.hTTPField;
            }
            set
            {
                this.hTTPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class HTTP
    {

        private Get getField;

        private Post postField;

        /// <remarks/>
        public Get Get
        {
            get
            {
                return this.getField;
            }
            set
            {
                this.getField = value;
            }
        }

        /// <remarks/>
        public Post Post
        {
            get
            {
                return this.postField;
            }
            set
            {
                this.postField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Get
    {

        private OnlineResource onlineResourceField;

        /// <remarks/>
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Post
    {

        private OnlineResource onlineResourceField;

        /// <remarks/>
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Layer
    {

        private string nameField;

        private string titleField;

        private string abstractField;

        private Keyword[] keywordListField;

        private string[] cRSField;

        private EX_GeographicBoundingBox eX_GeographicBoundingBoxField;

        private BoundingBox[] boundingBoxField;

        private Dimension[] dimensionField;

        private Attribution attributionField;

        private AuthorityURL[] authorityURLField;

        private Identifier[] identifierField;

        private MetadataURL[] metadataURLField;

        private DataURL[] dataURLField;

        private FeatureListURL[] featureListURLField;

        private Style[] styleField;

        private double minScaleDenominatorField;

        private bool minScaleDenominatorFieldSpecified;

        private double maxScaleDenominatorField;

        private bool maxScaleDenominatorFieldSpecified;

        private Layer[] layer1Field;

        private bool queryableField;

        private string cascadedField;

        private bool opaqueField;

        private bool noSubsetsField;

        private string fixedWidthField;

        private string fixedHeightField;

        public Layer()
        {
            this.queryableField = false;
            this.opaqueField = false;
            this.noSubsetsField = false;
        }

        /// <remarks/>
        public string Name
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
        public string Title
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
        public string Abstract
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Keyword", IsNullable = false)]
        public Keyword[] KeywordList
        {
            get
            {
                return this.keywordListField;
            }
            set
            {
                this.keywordListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CRS")]
        public string[] CRS
        {
            get
            {
                return this.cRSField;
            }
            set
            {
                this.cRSField = value;
            }
        }

        /// <remarks/>
        public EX_GeographicBoundingBox EX_GeographicBoundingBox
        {
            get
            {
                return this.eX_GeographicBoundingBoxField;
            }
            set
            {
                this.eX_GeographicBoundingBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public BoundingBox[] BoundingBox
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
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public Dimension[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        /// <remarks/>
        public Attribution Attribution
        {
            get
            {
                return this.attributionField;
            }
            set
            {
                this.attributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthorityURL")]
        public AuthorityURL[] AuthorityURL
        {
            get
            {
                return this.authorityURLField;
            }
            set
            {
                this.authorityURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public Identifier[] Identifier
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
        [System.Xml.Serialization.XmlElementAttribute("MetadataURL")]
        public MetadataURL[] MetadataURL
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
        [System.Xml.Serialization.XmlElementAttribute("DataURL")]
        public DataURL[] DataURL
        {
            get
            {
                return this.dataURLField;
            }
            set
            {
                this.dataURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureListURL")]
        public FeatureListURL[] FeatureListURL
        {
            get
            {
                return this.featureListURLField;
            }
            set
            {
                this.featureListURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Style")]
        public Style[] Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        public double MinScaleDenominator
        {
            get
            {
                return this.minScaleDenominatorField;
            }
            set
            {
                this.minScaleDenominatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinScaleDenominatorSpecified
        {
            get
            {
                return this.minScaleDenominatorFieldSpecified;
            }
            set
            {
                this.minScaleDenominatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double MaxScaleDenominator
        {
            get
            {
                return this.maxScaleDenominatorField;
            }
            set
            {
                this.maxScaleDenominatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxScaleDenominatorSpecified
        {
            get
            {
                return this.maxScaleDenominatorFieldSpecified;
            }
            set
            {
                this.maxScaleDenominatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Layer")]
        public Layer[] Layer1
        {
            get
            {
                return this.layer1Field;
            }
            set
            {
                this.layer1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool queryable
        {
            get
            {
                return this.queryableField;
            }
            set
            {
                this.queryableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string cascaded
        {
            get
            {
                return this.cascadedField;
            }
            set
            {
                this.cascadedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool opaque
        {
            get
            {
                return this.opaqueField;
            }
            set
            {
                this.opaqueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool noSubsets
        {
            get
            {
                return this.noSubsetsField;
            }
            set
            {
                this.noSubsetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string fixedWidth
        {
            get
            {
                return this.fixedWidthField;
            }
            set
            {
                this.fixedWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string fixedHeight
        {
            get
            {
                return this.fixedHeightField;
            }
            set
            {
                this.fixedHeightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class EX_GeographicBoundingBox
    {

        private double westBoundLongitudeField;

        private double eastBoundLongitudeField;

        private double southBoundLatitudeField;

        private double northBoundLatitudeField;

        /// <remarks/>
        public double westBoundLongitude
        {
            get
            {
                return this.westBoundLongitudeField;
            }
            set
            {
                this.westBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public double eastBoundLongitude
        {
            get
            {
                return this.eastBoundLongitudeField;
            }
            set
            {
                this.eastBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public double southBoundLatitude
        {
            get
            {
                return this.southBoundLatitudeField;
            }
            set
            {
                this.southBoundLatitudeField = value;
            }
        }

        /// <remarks/>
        public double northBoundLatitude
        {
            get
            {
                return this.northBoundLatitudeField;
            }
            set
            {
                this.northBoundLatitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class BoundingBox
    {

        private string cRSField;

        private double minxField;

        private double minyField;

        private double maxxField;

        private double maxyField;

        private double resxField;

        private bool resxFieldSpecified;

        private double resyField;

        private bool resyFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CRS
        {
            get
            {
                return this.cRSField;
            }
            set
            {
                this.cRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double minx
        {
            get
            {
                return this.minxField;
            }
            set
            {
                this.minxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double miny
        {
            get
            {
                return this.minyField;
            }
            set
            {
                this.minyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxx
        {
            get
            {
                return this.maxxField;
            }
            set
            {
                this.maxxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double maxy
        {
            get
            {
                return this.maxyField;
            }
            set
            {
                this.maxyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double resx
        {
            get
            {
                return this.resxField;
            }
            set
            {
                this.resxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resxSpecified
        {
            get
            {
                return this.resxFieldSpecified;
            }
            set
            {
                this.resxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double resy
        {
            get
            {
                return this.resyField;
            }
            set
            {
                this.resyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resySpecified
        {
            get
            {
                return this.resyFieldSpecified;
            }
            set
            {
                this.resyFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Dimension
    {

        private string nameField;

        private string unitsField;

        private string unitSymbolField;

        private string defaultField;

        private bool multipleValuesField;

        private bool multipleValuesFieldSpecified;

        private bool nearestValueField;

        private bool nearestValueFieldSpecified;

        private bool currentField;

        private bool currentFieldSpecified;

        private string valueField;

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
        public string units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unitSymbol
        {
            get
            {
                return this.unitSymbolField;
            }
            set
            {
                this.unitSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool multipleValues
        {
            get
            {
                return this.multipleValuesField;
            }
            set
            {
                this.multipleValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool multipleValuesSpecified
        {
            get
            {
                return this.multipleValuesFieldSpecified;
            }
            set
            {
                this.multipleValuesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nearestValue
        {
            get
            {
                return this.nearestValueField;
            }
            set
            {
                this.nearestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nearestValueSpecified
        {
            get
            {
                return this.nearestValueFieldSpecified;
            }
            set
            {
                this.nearestValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentSpecified
        {
            get
            {
                return this.currentFieldSpecified;
            }
            set
            {
                this.currentFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Attribution
    {

        private string titleField;

        private OnlineResource onlineResourceField;

        private LogoURL logoURLField;

        /// <remarks/>
        public string Title
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
        public OnlineResource OnlineResource
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
        public LogoURL LogoURL
        {
            get
            {
                return this.logoURLField;
            }
            set
            {
                this.logoURLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class LogoURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

        private string widthField;

        private string heightField;

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
        public OnlineResource OnlineResource
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class AuthorityURL
    {

        private OnlineResource onlineResourceField;

        private string nameField;

        /// <remarks/>
        public OnlineResource OnlineResource
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Identifier
    {

        private string authorityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authority
        {
            get
            {
                return this.authorityField;
            }
            set
            {
                this.authorityField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class MetadataURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

        private string typeField;

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
        public OnlineResource OnlineResource
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class DataURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

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
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class FeatureListURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

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
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Style
    {

        private string nameField;

        private string titleField;

        private string abstractField;

        private LegendURL[] legendURLField;

        private StyleSheetURL styleSheetURLField;

        private StyleURL styleURLField;

        /// <remarks/>
        public string Name
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
        public string Title
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
        public string Abstract
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
        [System.Xml.Serialization.XmlElementAttribute("LegendURL")]
        public LegendURL[] LegendURL
        {
            get
            {
                return this.legendURLField;
            }
            set
            {
                this.legendURLField = value;
            }
        }

        /// <remarks/>
        public StyleSheetURL StyleSheetURL
        {
            get
            {
                return this.styleSheetURLField;
            }
            set
            {
                this.styleSheetURLField = value;
            }
        }

        /// <remarks/>
        public StyleURL StyleURL
        {
            get
            {
                return this.styleURLField;
            }
            set
            {
                this.styleURLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class LegendURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

        private string widthField;

        private string heightField;

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
        public OnlineResource OnlineResource
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class StyleSheetURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

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
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class StyleURL
    {

        private string formatField;

        private OnlineResource onlineResourceField;

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
        public OnlineResource OnlineResource
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class KeywordList
    {

        private Keyword[] keywordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public Keyword[] Keyword
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wms", IsNullable = false)]
    public partial class Exception
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

}
