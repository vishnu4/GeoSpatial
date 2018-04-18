using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// WFS Model for http://www.opengis.net/wfs
/// </summary>
namespace GeoSpatial.WFS110
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class XlinkPropertyName
    {

        private string traverseXlinkDepthField;

        private string traverseXlinkExpiryField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traverseXlinkDepth
        {
            get
            {
                return this.traverseXlinkDepthField;
            }
            set
            {
                this.traverseXlinkDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string traverseXlinkExpiry
        {
            get
            {
                return this.traverseXlinkExpiryField;
            }
            set
            {
                this.traverseXlinkExpiryField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("ContactInfo", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestMethodType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    public partial class DomainType
    {

        private string[] valueField;

        private MetadataType[] metadataField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("Metadata", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("Role", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("PointOfContact", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeClockPropertyType
    {

        private TimeClockType timeClockField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeClockType TimeClock
        {
            get
            {
                return this.timeClockField;
            }
            set
            {
                this.timeClockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeClock", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeClockType : AbstractTimeReferenceSystemType
    {

        private StringOrRefType referenceEventField;

        private System.DateTime referenceTimeField;

        private System.DateTime utcReferenceField;

        private TimeCalendarPropertyType[] dateBasisField;

        /// <remarks/>
        public StringOrRefType referenceEvent
        {
            get
            {
                return this.referenceEventField;
            }
            set
            {
                this.referenceEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime referenceTime
        {
            get
            {
                return this.referenceTimeField;
            }
            set
            {
                this.referenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime utcReference
        {
            get
            {
                return this.utcReferenceField;
            }
            set
            {
                this.utcReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateBasis")]
        public TimeCalendarPropertyType[] dateBasis
        {
            get
            {
                return this.dateBasisField;
            }
            set
            {
                this.dateBasisField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("description", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class StringOrRefType
    {

        private string remoteSchemaField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeCalendarPropertyType
    {

        private TimeCalendarType timeCalendarField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeCalendarType TimeCalendar
        {
            get
            {
                return this.timeCalendarField;
            }
            set
            {
                this.timeCalendarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendar", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeCalendarType : AbstractTimeReferenceSystemType
    {

        private TimeCalendarEraPropertyType[] referenceFrameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("referenceFrame")]
        public TimeCalendarEraPropertyType[] referenceFrame
        {
            get
            {
                return this.referenceFrameField;
            }
            set
            {
                this.referenceFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeCalendarEraPropertyType
    {

        private TimeCalendarEraType timeCalendarEraField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeCalendarEraType TimeCalendarEra
        {
            get
            {
                return this.timeCalendarEraField;
            }
            set
            {
                this.timeCalendarEraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendarEra", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeCalendarEraType : DefinitionType
    {

        private StringOrRefType referenceEventField;

        private System.DateTime referenceDateField;

        private decimal julianReferenceField;

        private TimePeriodPropertyType epochOfUseField;

        public TimeCalendarEraType()
        {
            this.referenceDateField = new System.DateTime(0);
        }

        /// <remarks/>
        public StringOrRefType referenceEvent
        {
            get
            {
                return this.referenceEventField;
            }
            set
            {
                this.referenceEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        [System.ComponentModel.DefaultValueAttribute(typeof(System.DateTime), "0001-01-01")]
        public System.DateTime referenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }

        /// <remarks/>
        public decimal julianReference
        {
            get
            {
                return this.julianReferenceField;
            }
            set
            {
                this.julianReferenceField = value;
            }
        }

        /// <remarks/>
        public TimePeriodPropertyType epochOfUse
        {
            get
            {
                return this.epochOfUseField;
            }
            set
            {
                this.epochOfUseField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimePeriodPropertyType
    {

        private TimePeriodType timePeriodField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimePeriodType TimePeriod
        {
            get
            {
                return this.timePeriodField;
            }
            set
            {
                this.timePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimePeriod", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimePeriodType : AbstractTimeGeometricPrimitiveType
    {

        private object itemField;

        private object item1Field;

        private string durationField;

        private TimeIntervalLengthType timeIntervalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("begin", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("beginPosition", typeof(TimePositionType))]
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
        [System.Xml.Serialization.XmlElementAttribute("end", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("endPosition", typeof(TimePositionType))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public TimeIntervalLengthType timeInterval
        {
            get
            {
                return this.timeIntervalField;
            }
            set
            {
                this.timeIntervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeInstantPropertyType
    {

        private TimeInstantType timeInstantField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeInstantType TimeInstant
        {
            get
            {
                return this.timeInstantField;
            }
            set
            {
                this.timeInstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeInstant", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeInstantType : AbstractTimeGeometricPrimitiveType
    {

        private TimePositionType timePositionField;

        /// <remarks/>
        public TimePositionType timePosition
        {
            get
            {
                return this.timePositionField;
            }
            set
            {
                this.timePositionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("timePosition", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimePositionType
    {

        private string frameField;

        private string calendarEraNameField;

        private TimeIndeterminateValueType indeterminatePositionField;

        private bool indeterminatePositionFieldSpecified;

        private string valueField;

        public TimePositionType()
        {
            this.frameField = "#ISO-8601";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        public string frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string calendarEraName
        {
            get
            {
                return this.calendarEraNameField;
            }
            set
            {
                this.calendarEraNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeIndeterminateValueType indeterminatePosition
        {
            get
            {
                return this.indeterminatePositionField;
            }
            set
            {
                this.indeterminatePositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indeterminatePositionSpecified
        {
            get
            {
                return this.indeterminatePositionFieldSpecified;
            }
            set
            {
                this.indeterminatePositionFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum TimeIndeterminateValueType
    {

        /// <remarks/>
        after,

        /// <remarks/>
        before,

        /// <remarks/>
        now,

        /// <remarks/>
        unknown,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType
    {

        private string frameField;

        public AbstractTimeGeometricPrimitiveType()
        {
            this.frameField = "#ISO-8601";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        public string frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeTopologyPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType
    {

        private RelatedTimeType[] relatedTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime
        {
            get
            {
                return this.relatedTimeField;
            }
            set
            {
                this.relatedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class RelatedTimeType : TimePrimitivePropertyType
    {

        private RelatedTimeTypeRelativePosition relativePositionField;

        private bool relativePositionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelatedTimeTypeRelativePosition relativePosition
        {
            get
            {
                return this.relativePositionField;
            }
            set
            {
                this.relativePositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativePositionSpecified
        {
            get
            {
                return this.relativePositionFieldSpecified;
            }
            set
            {
                this.relativePositionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public enum RelatedTimeTypeRelativePosition
    {

        /// <remarks/>
        Before,

        /// <remarks/>
        After,

        /// <remarks/>
        Begins,

        /// <remarks/>
        Ends,

        /// <remarks/>
        During,

        /// <remarks/>
        Equals,

        /// <remarks/>
        Contains,

        /// <remarks/>
        Overlaps,

        /// <remarks/>
        Meets,

        /// <remarks/>
        OverlappedBy,

        /// <remarks/>
        MetBy,

        /// <remarks/>
        BegunBy,

        /// <remarks/>
        EndedBy,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedTimeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("validTime", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimePrimitivePropertyType
    {

        private AbstractTimePrimitiveType _TimePrimitiveField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractTimePrimitiveType _TimePrimitive
        {
            get
            {
                return this._TimePrimitiveField;
            }
            set
            {
                this._TimePrimitiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeTopologyComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeTopologyPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeObjectType : AbstractGMLType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseStyleDescriptorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologyStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometryStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarEraType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalEraType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionProxyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DictionaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralOperationParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceSystemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopologyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoVolumeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopoPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricAggregateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundedFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeTopologyComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeTopologyPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BagType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGMLType
    {

        private MetaDataPropertyType[] metaDataPropertyField;

        private StringOrRefType descriptionField;

        private CodeType1[] nameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metaDataProperty")]
        public MetaDataPropertyType[] metaDataProperty
        {
            get
            {
                return this.metaDataPropertyField;
            }
            set
            {
                this.metaDataPropertyField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType description
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
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public CodeType1[] name
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "ID")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("metaDataProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MetaDataPropertyType
    {

        private System.Xml.XmlElement anyField;

        private string remoteSchemaField;

        private string aboutField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSTypeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumTypeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PixelInCellType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CodeType", Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("name", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CodeType1
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("derivedCRSType", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DerivedCRSTypeType : CodeType1
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("verticalDatumType", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalDatumTypeType : CodeType1
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("pixelInCell", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PixelInCellType : CodeType1
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopologyStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelStyleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometryStyleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class BaseStyleDescriptorType : AbstractGMLType
    {

        private ScaleType spatialResolutionField;

        private StyleVariationType[] styleVariationField;

        private animateType[] animateField;

        private animateMotionType[] animateMotionField;

        private animateColorType[] animateColorField;

        private setType[] setField;

        /// <remarks/>
        public ScaleType spatialResolution
        {
            get
            {
                return this.spatialResolutionField;
            }
            set
            {
                this.spatialResolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("styleVariation")]
        public StyleVariationType[] styleVariation
        {
            get
            {
                return this.styleVariationField;
            }
            set
            {
                this.styleVariationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animate", Namespace = "http://www.w3.org/2001/SMIL20/")]
        public animateType[] animate
        {
            get
            {
                return this.animateField;
            }
            set
            {
                this.animateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animateMotion", Namespace = "http://www.w3.org/2001/SMIL20/")]
        public animateMotionType[] animateMotion
        {
            get
            {
                return this.animateMotionField;
            }
            set
            {
                this.animateMotionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("animateColor", Namespace = "http://www.w3.org/2001/SMIL20/")]
        public animateColorType[] animateColor
        {
            get
            {
                return this.animateColorField;
            }
            set
            {
                this.animateColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("set", Namespace = "http://www.w3.org/2001/SMIL20/")]
        public setType[] set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class ScaleType : MeasureType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpeedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VolumeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridLengthType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScaleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Quantity", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MeasureType
    {

        private string uomField;

        private double valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AngleType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class SpeedType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class VolumeType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AreaType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class GridLengthType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class LengthType : MeasureType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class StyleVariationType
    {

        private string stylePropertyField;

        private string featurePropertyRangeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string styleProperty
        {
            get
            {
                return this.stylePropertyField;
            }
            set
            {
                this.stylePropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featurePropertyRange
        {
            get
            {
                return this.featurePropertyRangeField;
            }
            set
            {
                this.featurePropertyRangeField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/Language")]
    [System.Xml.Serialization.XmlRootAttribute("animate", Namespace = "http://www.w3.org/2001/SMIL20/", IsNullable = false)]
    public partial class animateType : animatePrototype
    {

        private System.Xml.XmlElement[] itemsField;

        private string targetElementField;

        private animateTypeCalcMode calcModeField;

        private bool skipcontentField;

        private System.Xml.XmlAttribute[] anyAttrField;

        public animateType()
        {
            this.calcModeField = animateTypeCalcMode.linear;
            this.skipcontentField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string targetElement
        {
            get
            {
                return this.targetElementField;
            }
            set
            {
                this.targetElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animateTypeCalcMode.linear)]
        public animateTypeCalcMode calcMode
        {
            get
            {
                return this.calcModeField;
            }
            set
            {
                this.calcModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("skip-content")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool skipcontent
        {
            get
            {
                return this.skipcontentField;
            }
            set
            {
                this.skipcontentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/SMIL20/")]
    public enum animateTypeCalcMode
    {

        /// <remarks/>
        discrete,

        /// <remarks/>
        linear,

        /// <remarks/>
        paced,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(animateType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/")]
    public partial class animatePrototype
    {

        private string attributeNameField;

        private animatePrototypeAttributeType attributeTypeField;

        private animatePrototypeAdditive additiveField;

        private animatePrototypeAccumulate accumulateField;

        private string fromField;

        private string byField;

        private string valuesField;

        public animatePrototype()
        {
            this.attributeTypeField = animatePrototypeAttributeType.auto;
            this.additiveField = animatePrototypeAdditive.replace;
            this.accumulateField = animatePrototypeAccumulate.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeName
        {
            get
            {
                return this.attributeNameField;
            }
            set
            {
                this.attributeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAttributeType.auto)]
        public animatePrototypeAttributeType attributeType
        {
            get
            {
                return this.attributeTypeField;
            }
            set
            {
                this.attributeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAdditive.replace)]
        public animatePrototypeAdditive additive
        {
            get
            {
                return this.additiveField;
            }
            set
            {
                this.additiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAccumulate.none)]
        public animatePrototypeAccumulate accumulate
        {
            get
            {
                return this.accumulateField;
            }
            set
            {
                this.accumulateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string by
        {
            get
            {
                return this.byField;
            }
            set
            {
                this.byField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/SMIL20/")]
    public enum animatePrototypeAttributeType
    {

        /// <remarks/>
        XML,

        /// <remarks/>
        CSS,

        /// <remarks/>
        auto,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/SMIL20/")]
    public enum animatePrototypeAdditive
    {

        /// <remarks/>
        replace,

        /// <remarks/>
        sum,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/SMIL20/")]
    public enum animatePrototypeAccumulate
    {

        /// <remarks/>
        none,

        /// <remarks/>
        sum,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/Language")]
    [System.Xml.Serialization.XmlRootAttribute("animateMotion", Namespace = "http://www.w3.org/2001/SMIL20/", IsNullable = false)]
    public partial class animateMotionType : animateMotionPrototype
    {

        private System.Xml.XmlElement[] itemsField;

        private string targetElementField;

        private animateTypeCalcMode calcModeField;

        private bool skipcontentField;

        private System.Xml.XmlAttribute[] anyAttrField;

        public animateMotionType()
        {
            this.calcModeField = animateTypeCalcMode.linear;
            this.skipcontentField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string targetElement
        {
            get
            {
                return this.targetElementField;
            }
            set
            {
                this.targetElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animateTypeCalcMode.linear)]
        public animateTypeCalcMode calcMode
        {
            get
            {
                return this.calcModeField;
            }
            set
            {
                this.calcModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("skip-content")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool skipcontent
        {
            get
            {
                return this.skipcontentField;
            }
            set
            {
                this.skipcontentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(animateMotionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/")]
    public partial class animateMotionPrototype
    {

        private animatePrototypeAdditive additiveField;

        private animatePrototypeAccumulate accumulateField;

        private string fromField;

        private string byField;

        private string valuesField;

        private string originField;

        public animateMotionPrototype()
        {
            this.additiveField = animatePrototypeAdditive.replace;
            this.accumulateField = animatePrototypeAccumulate.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAdditive.replace)]
        public animatePrototypeAdditive additive
        {
            get
            {
                return this.additiveField;
            }
            set
            {
                this.additiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAccumulate.none)]
        public animatePrototypeAccumulate accumulate
        {
            get
            {
                return this.accumulateField;
            }
            set
            {
                this.accumulateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string by
        {
            get
            {
                return this.byField;
            }
            set
            {
                this.byField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/Language")]
    [System.Xml.Serialization.XmlRootAttribute("animateColor", Namespace = "http://www.w3.org/2001/SMIL20/", IsNullable = false)]
    public partial class animateColorType : animateColorPrototype
    {

        private System.Xml.XmlElement[] itemsField;

        private string targetElementField;

        private animateTypeCalcMode calcModeField;

        private bool skipcontentField;

        private System.Xml.XmlAttribute[] anyAttrField;

        public animateColorType()
        {
            this.calcModeField = animateTypeCalcMode.linear;
            this.skipcontentField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string targetElement
        {
            get
            {
                return this.targetElementField;
            }
            set
            {
                this.targetElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animateTypeCalcMode.linear)]
        public animateTypeCalcMode calcMode
        {
            get
            {
                return this.calcModeField;
            }
            set
            {
                this.calcModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("skip-content")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool skipcontent
        {
            get
            {
                return this.skipcontentField;
            }
            set
            {
                this.skipcontentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(animateColorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/")]
    public partial class animateColorPrototype
    {

        private string attributeNameField;

        private animatePrototypeAttributeType attributeTypeField;

        private animatePrototypeAdditive additiveField;

        private animatePrototypeAccumulate accumulateField;

        private string fromField;

        private string byField;

        private string valuesField;

        public animateColorPrototype()
        {
            this.attributeTypeField = animatePrototypeAttributeType.auto;
            this.additiveField = animatePrototypeAdditive.replace;
            this.accumulateField = animatePrototypeAccumulate.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeName
        {
            get
            {
                return this.attributeNameField;
            }
            set
            {
                this.attributeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAttributeType.auto)]
        public animatePrototypeAttributeType attributeType
        {
            get
            {
                return this.attributeTypeField;
            }
            set
            {
                this.attributeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAdditive.replace)]
        public animatePrototypeAdditive additive
        {
            get
            {
                return this.additiveField;
            }
            set
            {
                this.additiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAccumulate.none)]
        public animatePrototypeAccumulate accumulate
        {
            get
            {
                return this.accumulateField;
            }
            set
            {
                this.accumulateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string by
        {
            get
            {
                return this.byField;
            }
            set
            {
                this.byField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/Language")]
    [System.Xml.Serialization.XmlRootAttribute("set", Namespace = "http://www.w3.org/2001/SMIL20/", IsNullable = false)]
    public partial class setType : setPrototype
    {

        private System.Xml.XmlElement[] itemsField;

        private string targetElementField;

        private bool skipcontentField;

        private System.Xml.XmlAttribute[] anyAttrField;

        public setType()
        {
            this.skipcontentField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string targetElement
        {
            get
            {
                return this.targetElementField;
            }
            set
            {
                this.targetElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("skip-content")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool skipcontent
        {
            get
            {
                return this.skipcontentField;
            }
            set
            {
                this.skipcontentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(setType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/SMIL20/")]
    public partial class setPrototype
    {

        private string attributeNameField;

        private animatePrototypeAttributeType attributeTypeField;

        private string toField;

        public setPrototype()
        {
            this.attributeTypeField = animatePrototypeAttributeType.auto;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeName
        {
            get
            {
                return this.attributeNameField;
            }
            set
            {
                this.attributeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAttributeType.auto)]
        public animatePrototypeAttributeType attributeType
        {
            get
            {
                return this.attributeTypeField;
            }
            set
            {
                this.attributeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GraphStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GraphStyleType : BaseStyleDescriptorType
    {

        private bool planarField;

        private bool planarFieldSpecified;

        private bool directedField;

        private bool directedFieldSpecified;

        private bool gridField;

        private bool gridFieldSpecified;

        private double minDistanceField;

        private bool minDistanceFieldSpecified;

        private double minAngleField;

        private bool minAngleFieldSpecified;

        private GraphTypeType graphTypeField;

        private bool graphTypeFieldSpecified;

        private DrawingTypeType drawingTypeField;

        private bool drawingTypeFieldSpecified;

        private LineTypeType lineTypeField;

        private bool lineTypeFieldSpecified;

        private AesheticCriteriaType[] aestheticCriteriaField;

        /// <remarks/>
        public bool planar
        {
            get
            {
                return this.planarField;
            }
            set
            {
                this.planarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool planarSpecified
        {
            get
            {
                return this.planarFieldSpecified;
            }
            set
            {
                this.planarFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool directed
        {
            get
            {
                return this.directedField;
            }
            set
            {
                this.directedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directedSpecified
        {
            get
            {
                return this.directedFieldSpecified;
            }
            set
            {
                this.directedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool grid
        {
            get
            {
                return this.gridField;
            }
            set
            {
                this.gridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gridSpecified
        {
            get
            {
                return this.gridFieldSpecified;
            }
            set
            {
                this.gridFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double minDistance
        {
            get
            {
                return this.minDistanceField;
            }
            set
            {
                this.minDistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minDistanceSpecified
        {
            get
            {
                return this.minDistanceFieldSpecified;
            }
            set
            {
                this.minDistanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double minAngle
        {
            get
            {
                return this.minAngleField;
            }
            set
            {
                this.minAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minAngleSpecified
        {
            get
            {
                return this.minAngleFieldSpecified;
            }
            set
            {
                this.minAngleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public GraphTypeType graphType
        {
            get
            {
                return this.graphTypeField;
            }
            set
            {
                this.graphTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool graphTypeSpecified
        {
            get
            {
                return this.graphTypeFieldSpecified;
            }
            set
            {
                this.graphTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DrawingTypeType drawingType
        {
            get
            {
                return this.drawingTypeField;
            }
            set
            {
                this.drawingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawingTypeSpecified
        {
            get
            {
                return this.drawingTypeFieldSpecified;
            }
            set
            {
                this.drawingTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LineTypeType lineType
        {
            get
            {
                return this.lineTypeField;
            }
            set
            {
                this.lineTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineTypeSpecified
        {
            get
            {
                return this.lineTypeFieldSpecified;
            }
            set
            {
                this.lineTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("aestheticCriteria")]
        public AesheticCriteriaType[] aestheticCriteria
        {
            get
            {
                return this.aestheticCriteriaField;
            }
            set
            {
                this.aestheticCriteriaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum GraphTypeType
    {

        /// <remarks/>
        TREE,

        /// <remarks/>
        BICONNECTED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum DrawingTypeType
    {

        /// <remarks/>
        POLYLINE,

        /// <remarks/>
        ORTHOGONAL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum LineTypeType
    {

        /// <remarks/>
        STRAIGHT,

        /// <remarks/>
        BENT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum AesheticCriteriaType
    {

        /// <remarks/>
        MIN_CROSSINGS,

        /// <remarks/>
        MIN_AREA,

        /// <remarks/>
        MIN_BENDS,

        /// <remarks/>
        MAX_BENDS,

        /// <remarks/>
        UNIFORM_BENDS,

        /// <remarks/>
        MIN_SLOPES,

        /// <remarks/>
        MIN_EDGE_LENGTH,

        /// <remarks/>
        MAX_EDGE_LENGTH,

        /// <remarks/>
        UNIFORM_EDGE_LENGTH,

        /// <remarks/>
        MAX_ANGULAR_RESOLUTION,

        /// <remarks/>
        MIN_ASPECT_RATIO,

        /// <remarks/>
        MAX_SYMMETRIES,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopologyStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopologyStyleType : BaseStyleDescriptorType
    {

        private object itemField;

        private LabelStylePropertyType labelStyleField;

        private string topologyPropertyField;

        private string topologyTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("style", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("symbol", typeof(SymbolType))]
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
        public LabelStylePropertyType labelStyle
        {
            get
            {
                return this.labelStyleField;
            }
            set
            {
                this.labelStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string topologyProperty
        {
            get
            {
                return this.topologyPropertyField;
            }
            set
            {
                this.topologyPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string topologyType
        {
            get
            {
                return this.topologyTypeField;
            }
            set
            {
                this.topologyTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("symbol", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SymbolType
    {

        private System.Xml.XmlElement[] anyField;

        private SymbolTypeEnumeration symbolTypeField;

        private string transformField;

        private string aboutField;

        private string remoteSchemaField;

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
        public SymbolTypeEnumeration symbolType
        {
            get
            {
                return this.symbolTypeField;
            }
            set
            {
                this.symbolTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum SymbolTypeEnumeration
    {

        /// <remarks/>
        svg,

        /// <remarks/>
        xpath,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("labelStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LabelStylePropertyType
    {

        private LabelStyleType labelStyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public LabelStyleType LabelStyle
        {
            get
            {
                return this.labelStyleField;
            }
            set
            {
                this.labelStyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LabelStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LabelStyleType : BaseStyleDescriptorType
    {

        private string styleField;

        private LabelType labelField;

        /// <remarks/>
        public string style
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
        public LabelType label
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class LabelType
    {

        private string[] labelExpressionField;

        private string[] textField;

        private string transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LabelExpression")]
        public string[] LabelExpression
        {
            get
            {
                return this.labelExpressionField;
            }
            set
            {
                this.labelExpressionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeometryStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeometryStyleType : BaseStyleDescriptorType
    {

        private object itemField;

        private LabelStylePropertyType labelStyleField;

        private string geometryPropertyField;

        private string geometryTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("style", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("symbol", typeof(SymbolType))]
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
        public LabelStylePropertyType labelStyle
        {
            get
            {
                return this.labelStyleField;
            }
            set
            {
                this.labelStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string geometryProperty
        {
            get
            {
                return this.geometryPropertyField;
            }
            set
            {
                this.geometryPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string geometryType
        {
            get
            {
                return this.geometryTypeField;
            }
            set
            {
                this.geometryTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FeatureStyleType : AbstractGMLType
    {

        private string featureConstraintField;

        private GeometryStylePropertyType[] geometryStyleField;

        private TopologyStylePropertyType[] topologyStyleField;

        private LabelStylePropertyType labelStyleField;

        private string featureTypeField;

        private string baseTypeField;

        private QueryGrammarEnumeration queryGrammarField;

        private bool queryGrammarFieldSpecified;

        /// <remarks/>
        public string featureConstraint
        {
            get
            {
                return this.featureConstraintField;
            }
            set
            {
                this.featureConstraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geometryStyle")]
        public GeometryStylePropertyType[] geometryStyle
        {
            get
            {
                return this.geometryStyleField;
            }
            set
            {
                this.geometryStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("topologyStyle")]
        public TopologyStylePropertyType[] topologyStyle
        {
            get
            {
                return this.topologyStyleField;
            }
            set
            {
                this.topologyStyleField = value;
            }
        }

        /// <remarks/>
        public LabelStylePropertyType labelStyle
        {
            get
            {
                return this.labelStyleField;
            }
            set
            {
                this.labelStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureType
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QueryGrammarEnumeration queryGrammar
        {
            get
            {
                return this.queryGrammarField;
            }
            set
            {
                this.queryGrammarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool queryGrammarSpecified
        {
            get
            {
                return this.queryGrammarFieldSpecified;
            }
            set
            {
                this.queryGrammarFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geometryStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeometryStylePropertyType
    {

        private GeometryStyleType geometryStyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public GeometryStyleType GeometryStyle
        {
            get
            {
                return this.geometryStyleField;
            }
            set
            {
                this.geometryStyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topologyStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopologyStylePropertyType
    {

        private TopologyStyleType topologyStyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public TopologyStyleType TopologyStyle
        {
            get
            {
                return this.topologyStyleField;
            }
            set
            {
                this.topologyStyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum QueryGrammarEnumeration
    {

        /// <remarks/>
        xpath,

        /// <remarks/>
        xquery,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StyleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractStyleType : AbstractGMLType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Style", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class StyleType : AbstractStyleType
    {

        private FeatureStylePropertyType[] featureStyleField;

        private GraphStylePropertyType graphStyleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureStyle")]
        public FeatureStylePropertyType[] featureStyle
        {
            get
            {
                return this.featureStyleField;
            }
            set
            {
                this.featureStyleField = value;
            }
        }

        /// <remarks/>
        public GraphStylePropertyType graphStyle
        {
            get
            {
                return this.graphStyleField;
            }
            set
            {
                this.graphStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("featureStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FeatureStylePropertyType
    {

        private FeatureStyleType featureStyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public FeatureStyleType FeatureStyle
        {
            get
            {
                return this.featureStyleField;
            }
            set
            {
                this.featureStyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("graphStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GraphStylePropertyType
    {

        private GraphStyleType graphStyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public GraphStyleType GraphStyle
        {
            get
            {
                return this.graphStyleField;
            }
            set
            {
                this.graphStyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarEraType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalEraType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionProxyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DictionaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralOperationParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceSystemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Definition", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DefinitionType : AbstractGMLType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalEra", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeOrdinalEraType : DefinitionType
    {

        private RelatedTimeType[] relatedTimeField;

        private TimeNodePropertyType startField;

        private TimeNodePropertyType endField;

        private TimePeriodPropertyType extentField;

        private TimeOrdinalEraPropertyType[] memberField;

        private ReferenceType groupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime
        {
            get
            {
                return this.relatedTimeField;
            }
            set
            {
                this.relatedTimeField = value;
            }
        }

        /// <remarks/>
        public TimeNodePropertyType start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        public TimeNodePropertyType end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public TimePeriodPropertyType extent
        {
            get
            {
                return this.extentField;
            }
            set
            {
                this.extentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public TimeOrdinalEraPropertyType[] member
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
        public ReferenceType group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeNodePropertyType
    {

        private TimeNodeType timeNodeField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeNodeType TimeNode
        {
            get
            {
                return this.timeNodeField;
            }
            set
            {
                this.timeNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeNode", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeNodeType : AbstractTimeTopologyPrimitiveType
    {

        private TimeEdgePropertyType[] previousEdgeField;

        private TimeEdgePropertyType[] nextEdgeField;

        private TimeInstantPropertyType positionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("previousEdge")]
        public TimeEdgePropertyType[] previousEdge
        {
            get
            {
                return this.previousEdgeField;
            }
            set
            {
                this.previousEdgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextEdge")]
        public TimeEdgePropertyType[] nextEdge
        {
            get
            {
                return this.nextEdgeField;
            }
            set
            {
                this.nextEdgeField = value;
            }
        }

        /// <remarks/>
        public TimeInstantPropertyType position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeEdgePropertyType
    {

        private TimeEdgeType timeEdgeField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeEdgeType TimeEdge
        {
            get
            {
                return this.timeEdgeField;
            }
            set
            {
                this.timeEdgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeEdge", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeEdgeType : AbstractTimeTopologyPrimitiveType
    {

        private TimeNodePropertyType startField;

        private TimeNodePropertyType endField;

        private TimePeriodPropertyType extentField;

        /// <remarks/>
        public TimeNodePropertyType start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        public TimeNodePropertyType end
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public TimePeriodPropertyType extent
        {
            get
            {
                return this.extentField;
            }
            set
            {
                this.extentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType
    {

        private ReferenceType complexField;

        /// <remarks/>
        public ReferenceType complex
        {
            get
            {
                return this.complexField;
            }
            set
            {
                this.complexField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("definitionRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ReferenceType
    {

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeOrdinalEraPropertyType
    {

        private TimeOrdinalEraType timeOrdinalEraField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeOrdinalEraType TimeOrdinalEra
        {
            get
            {
                return this.timeOrdinalEraField;
            }
            set
            {
                this.timeOrdinalEraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeReferenceSystemType : DefinitionType
    {

        private string domainOfValidityField;

        /// <remarks/>
        public string domainOfValidity
        {
            get
            {
                return this.domainOfValidityField;
            }
            set
            {
                this.domainOfValidityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalReferenceSystem", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeOrdinalReferenceSystemType : AbstractTimeReferenceSystemType
    {

        private TimeOrdinalEraPropertyType[] componentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("component")]
        public TimeOrdinalEraPropertyType[] component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCoordinateSystem", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeCoordinateSystemType : AbstractTimeReferenceSystemType
    {

        private object itemField;

        private TimeIntervalLengthType intervalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("origin", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("originPosition", typeof(TimePositionType))]
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
        public TimeIntervalLengthType interval
        {
            get
            {
                return this.intervalField;
            }
            set
            {
                this.intervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("timeInterval", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeIntervalLengthType
    {

        private string unitField;

        private string radixField;

        private string factorField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string radix
        {
            get
            {
                return this.radixField;
            }
            set
            {
                this.radixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string factor
        {
            get
            {
                return this.factorField;
            }
            set
            {
                this.factorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("UnitDefinition", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class UnitDefinitionType : DefinitionType
    {

        private StringOrRefType quantityTypeField;

        private CodeType1 catalogSymbolField;

        /// <remarks/>
        public StringOrRefType quantityType
        {
            get
            {
                return this.quantityTypeField;
            }
            set
            {
                this.quantityTypeField = value;
            }
        }

        /// <remarks/>
        public CodeType1 catalogSymbol
        {
            get
            {
                return this.catalogSymbolField;
            }
            set
            {
                this.catalogSymbolField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ConventionalUnit", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConventionalUnitType : UnitDefinitionType
    {

        private ConversionToPreferredUnitType itemField;

        private ItemChoiceType3 itemElementNameField;

        private DerivationUnitTermType[] derivationUnitTermField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conversionToPreferredUnit", typeof(ConversionToPreferredUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("roughConversionToPreferredUnit", typeof(ConversionToPreferredUnitType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ConversionToPreferredUnitType Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
        public DerivationUnitTermType[] derivationUnitTerm
        {
            get
            {
                return this.derivationUnitTermField;
            }
            set
            {
                this.derivationUnitTermField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("conversionToPreferredUnit", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConversionToPreferredUnitType : UnitOfMeasureType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("factor", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("formula", typeof(FormulaType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class FormulaType
    {

        private double aField;

        private bool aFieldSpecified;

        private double bField;

        private double cField;

        private double dField;

        private bool dFieldSpecified;

        /// <remarks/>
        public double a
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aSpecified
        {
            get
            {
                return this.aFieldSpecified;
            }
            set
            {
                this.aFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public double c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        /// <remarks/>
        public double d
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dSpecified
        {
            get
            {
                return this.dFieldSpecified;
            }
            set
            {
                this.dFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionToPreferredUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivationUnitTermType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("unitOfMeasure", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class UnitOfMeasureType
    {

        private string uomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("derivationUnitTerm", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DerivationUnitTermType : UnitOfMeasureType
    {

        private string exponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        conversionToPreferredUnit,

        /// <remarks/>
        roughConversionToPreferredUnit,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedUnit", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DerivedUnitType : UnitDefinitionType
    {

        private DerivationUnitTermType[] derivationUnitTermField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
        public DerivationUnitTermType[] derivationUnitTerm
        {
            get
            {
                return this.derivationUnitTermField;
            }
            set
            {
                this.derivationUnitTermField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("BaseUnit", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class BaseUnitType : UnitDefinitionType
    {

        private ReferenceType unitsSystemField;

        /// <remarks/>
        public ReferenceType unitsSystem
        {
            get
            {
                return this.unitsSystemField;
            }
            set
            {
                this.unitsSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DefinitionProxy", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DefinitionProxyType : DefinitionType
    {

        private ReferenceType definitionRefField;

        /// <remarks/>
        public ReferenceType definitionRef
        {
            get
            {
                return this.definitionRefField;
            }
            set
            {
                this.definitionRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Dictionary", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DictionaryType : DefinitionType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dictionaryEntry", typeof(DictionaryEntryType))]
        [System.Xml.Serialization.XmlElementAttribute("indirectEntry", typeof(IndirectEntryType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("dictionaryEntry", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DictionaryEntryType
    {

        private DefinitionType definitionField;

        private string remoteSchemaField;

        /// <remarks/>
        public DefinitionType Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("indirectEntry", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class IndirectEntryType
    {

        private DefinitionProxyType definitionProxyField;

        /// <remarks/>
        public DefinitionProxyType DefinitionProxy
        {
            get
            {
                return this.definitionProxyField;
            }
            set
            {
                this.definitionProxyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralOperationParameterType : DefinitionType
    {

        private string minimumOccursField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string minimumOccurs
        {
            get
            {
                return this.minimumOccursField;
            }
            set
            {
                this.minimumOccursField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class OperationParameterGroupBaseType : AbstractGeneralOperationParameterType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationParameterGroup", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationParameterGroupType : OperationParameterGroupBaseType
    {

        private IdentifierType[] groupIDField;

        private StringOrRefType remarksField;

        private string maximumOccursField;

        private AbstractGeneralOperationParameterRefType[] includesParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groupID")]
        public IdentifierType[] groupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string maximumOccurs
        {
            get
            {
                return this.maximumOccursField;
            }
            set
            {
                this.maximumOccursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesParameter")]
        public AbstractGeneralOperationParameterRefType[] includesParameter
        {
            get
            {
                return this.includesParameterField;
            }
            set
            {
                this.includesParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("srsID", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class IdentifierType
    {

        private CodeType1 nameField;

        private string versionField;

        private StringOrRefType remarksField;

        /// <remarks/>
        public CodeType1 name
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
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesParameter", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AbstractGeneralOperationParameterRefType
    {

        private AbstractGeneralOperationParameterType _GeneralOperationParameterField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractGeneralOperationParameterType _GeneralOperationParameter
        {
            get
            {
                return this._GeneralOperationParameterField;
            }
            set
            {
                this._GeneralOperationParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class OperationParameterBaseType : AbstractGeneralOperationParameterType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationParameter", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationParameterType : OperationParameterBaseType
    {

        private IdentifierType[] parameterIDField;

        private StringOrRefType remarksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameterID")]
        public IdentifierType[] parameterID
        {
            get
            {
                return this.parameterIDField;
            }
            set
            {
                this.parameterIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationMethodType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class OperationMethodBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationMethod", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationMethodType : OperationMethodBaseType
    {

        private IdentifierType[] methodIDField;

        private StringOrRefType remarksField;

        private CodeType1 methodFormulaField;

        private string sourceDimensionsField;

        private string targetDimensionsField;

        private AbstractGeneralOperationParameterRefType[] usesParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("methodID")]
        public IdentifierType[] methodID
        {
            get
            {
                return this.methodIDField;
            }
            set
            {
                this.methodIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public CodeType1 methodFormula
        {
            get
            {
                return this.methodFormulaField;
            }
            set
            {
                this.methodFormulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string sourceDimensions
        {
            get
            {
                return this.sourceDimensionsField;
            }
            set
            {
                this.sourceDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string targetDimensions
        {
            get
            {
                return this.targetDimensionsField;
            }
            set
            {
                this.targetDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesParameter")]
        public AbstractGeneralOperationParameterRefType[] usesParameter
        {
            get
            {
                return this.usesParameterField;
            }
            set
            {
                this.usesParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateOperationBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateOperationType : AbstractCoordinateOperationBaseType
    {

        private IdentifierType[] coordinateOperationIDField;

        private StringOrRefType remarksField;

        private string operationVersionField;

        private ExtentType validAreaField;

        private string scopeField;

        private AbstractPositionalAccuracyType[] _positionalAccuracyField;

        private CRSRefType sourceCRSField;

        private CRSRefType targetCRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinateOperationID")]
        public IdentifierType[] coordinateOperationID
        {
            get
            {
                return this.coordinateOperationIDField;
            }
            set
            {
                this.coordinateOperationIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public string operationVersion
        {
            get
            {
                return this.operationVersionField;
            }
            set
            {
                this.operationVersionField = value;
            }
        }

        /// <remarks/>
        public ExtentType validArea
        {
            get
            {
                return this.validAreaField;
            }
            set
            {
                this.validAreaField = value;
            }
        }

        /// <remarks/>
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_positionalAccuracy")]
        public AbstractPositionalAccuracyType[] _positionalAccuracy
        {
            get
            {
                return this._positionalAccuracyField;
            }
            set
            {
                this._positionalAccuracyField = value;
            }
        }

        /// <remarks/>
        public CRSRefType sourceCRS
        {
            get
            {
                return this.sourceCRSField;
            }
            set
            {
                this.sourceCRSField = value;
            }
        }

        /// <remarks/>
        public CRSRefType targetCRS
        {
            get
            {
                return this.targetCRSField;
            }
            set
            {
                this.targetCRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("validArea", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ExtentType
    {

        private StringOrRefType descriptionField;

        private object[] itemsField;

        private EnvelopeType[] verticalExtentField;

        private TimePeriodType[] temporalExtentField;

        /// <remarks/>
        public StringOrRefType description
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
        [System.Xml.Serialization.XmlElementAttribute("boundingBox", typeof(EnvelopeType))]
        [System.Xml.Serialization.XmlElementAttribute("boundingPolygon", typeof(PolygonType))]
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
        [System.Xml.Serialization.XmlElementAttribute("verticalExtent")]
        public EnvelopeType[] verticalExtent
        {
            get
            {
                return this.verticalExtentField;
            }
            set
            {
                this.verticalExtentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporalExtent")]
        public TimePeriodType[] temporalExtent
        {
            get
            {
                return this.temporalExtentField;
            }
            set
            {
                this.temporalExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnvelopeWithTimePeriodType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("boundingBox", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EnvelopeType
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string srsNameField;

        private string srsDimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("lowerCorner", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("upperCorner", typeof(DirectPositionType))]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string srsDimension
        {
            get
            {
                return this.srsDimensionField;
            }
            set
            {
                this.srsDimensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coord", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordType
    {

        private decimal xField;

        private decimal yField;

        private bool yFieldSpecified;

        private decimal zField;

        private bool zFieldSpecified;

        /// <remarks/>
        public decimal X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("tupleList", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinatesType
    {

        private string decimalField;

        private string csField;

        private string tsField;

        private string valueField;

        public CoordinatesType()
        {
            this.decimalField = ".";
            this.csField = ",";
            this.tsField = " ";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(".")]
        public string @decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(",")]
        public string cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(" ")]
        public string ts
        {
            get
            {
                return this.tsField;
            }
            set
            {
                this.tsField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("pos", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectPositionType
    {

        private string srsNameField;

        private string srsDimensionField;

        private double[] textField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string srsDimension
        {
            get
            {
                return this.srsDimensionField;
            }
            set
            {
                this.srsDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double[] Text
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        coord,

        /// <remarks/>
        coordinates,

        /// <remarks/>
        lowerCorner,

        /// <remarks/>
        pos,

        /// <remarks/>
        upperCorner,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EnvelopeWithTimePeriod", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EnvelopeWithTimePeriodType : EnvelopeType
    {

        private TimePositionType[] timePositionField;

        private string frameField;

        public EnvelopeWithTimePeriodType()
        {
            this.frameField = "#ISO-8601";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timePosition")]
        public TimePositionType[] timePosition
        {
            get
            {
                return this.timePositionField;
            }
            set
            {
                this.timePositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        public string frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Polygon", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolygonType : AbstractSurfaceType
    {

        private AbstractRingPropertyType exteriorField;

        private AbstractRingPropertyType[] interiorField;

        /// <remarks/>
        public AbstractRingPropertyType exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public AbstractRingPropertyType[] interior
        {
            get
            {
                return this.interiorField;
            }
            set
            {
                this.interiorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AbstractRingPropertyType
    {

        private AbstractRingType _RingField;

        /// <remarks/>
        public AbstractRingType _Ring
        {
            get
            {
                return this._RingField;
            }
            set
            {
                this._RingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearRingType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractRingType : AbstractGeometryType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometricComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricAggregateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearRingType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeometryType : AbstractGMLType
    {

        private string gidField;

        private string srsNameField;

        private string srsDimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string srsDimension
        {
            get
            {
                return this.srsDimensionField;
            }
            set
            {
                this.srsDimensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Grid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GridType : AbstractGeometryType
    {

        private GridLimitsType limitsField;

        private string[] axisNameField;

        private string dimensionField;

        /// <remarks/>
        public GridLimitsType limits
        {
            get
            {
                return this.limitsField;
            }
            set
            {
                this.limitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axisName")]
        public string[] axisName
        {
            get
            {
                return this.axisNameField;
            }
            set
            {
                this.axisNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string dimension
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class GridLimitsType
    {

        private GridEnvelopeType gridEnvelopeField;

        /// <remarks/>
        public GridEnvelopeType GridEnvelope
        {
            get
            {
                return this.gridEnvelopeField;
            }
            set
            {
                this.gridEnvelopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class GridEnvelopeType
    {

        private string lowField;

        private string highField;

        /// <remarks/>
        public string low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        public string high
        {
            get
            {
                return this.highField;
            }
            set
            {
                this.highField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("RectifiedGrid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RectifiedGridType : GridType
    {

        private PointPropertyType originField;

        private VectorType[] offsetVectorField;

        /// <remarks/>
        public PointPropertyType origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offsetVector")]
        public VectorType[] offsetVector
        {
            get
            {
                return this.offsetVectorField;
            }
            set
            {
                this.offsetVectorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("centerOf", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PointPropertyType
    {

        private PointType pointField;

        private string remoteSchemaField;

        /// <remarks/>
        public PointType Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Point", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PointType : AbstractGeometricPrimitiveType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeometricPrimitiveType : AbstractGeometryType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SolidType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AbstractSolidType : AbstractGeometricPrimitiveType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeSolid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompositeSolidType : AbstractSolidType
    {

        private SolidPropertyType[] solidMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("solidMember")]
        public SolidPropertyType[] solidMember
        {
            get
            {
                return this.solidMemberField;
            }
            set
            {
                this.solidMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("solidProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SolidPropertyType
    {

        private AbstractSolidType _SolidField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractSolidType _Solid
        {
            get
            {
                return this._SolidField;
            }
            set
            {
                this._SolidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Solid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SolidType : AbstractSolidType
    {

        private SurfacePropertyType exteriorField;

        private SurfacePropertyType[] interiorField;

        /// <remarks/>
        public SurfacePropertyType exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public SurfacePropertyType[] interior
        {
            get
            {
                return this.interiorField;
            }
            set
            {
                this.interiorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("surfaceProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SurfacePropertyType
    {

        private AbstractSurfaceType _SurfaceField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractSurfaceType _Surface
        {
            get
            {
                return this._SurfaceField;
            }
            set
            {
                this._SurfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AbstractSurfaceType : AbstractGeometricPrimitiveType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompositeSurfaceType : AbstractSurfaceType
    {

        private SurfacePropertyType[] surfaceMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember
        {
            get
            {
                return this.surfaceMemberField;
            }
            set
            {
                this.surfaceMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OrientableSurfaceType : AbstractSurfaceType
    {

        private SurfacePropertyType baseSurfaceField;

        private SignType orientationField;

        public OrientableSurfaceType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public SurfacePropertyType baseSurface
        {
            get
            {
                return this.baseSurfaceField;
            }
            set
            {
                this.baseSurfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum SignType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("-")]
        Item,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+")]
        Item1,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Surface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SurfaceType : AbstractSurfaceType
    {

        private SurfacePatchArrayPropertyType patchesField;

        /// <remarks/>
        public SurfacePatchArrayPropertyType patches
        {
            get
            {
                return this.patchesField;
            }
            set
            {
                this.patchesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrianglePatchArrayPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonPatchArrayPropertyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("patches", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SurfacePatchArrayPropertyType
    {

        private AbstractSurfacePatchType[] _SurfacePatchField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_SurfacePatch")]
        public AbstractSurfacePatchType[] _SurfacePatch
        {
            get
            {
                return this._SurfacePatchField;
            }
            set
            {
                this._SurfacePatchField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractParametricCurveSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGriddedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonPatchType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractSurfacePatchType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGriddedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType
    {

        private AbstractGriddedSurfaceTypeRow[] rowField;

        private string rowsField;

        private string columnsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public AbstractGriddedSurfaceTypeRow[] row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class AbstractGriddedSurfaceTypeRow
    {

        private DirectPositionListType posListField;

        private DirectPositionType[] posField;

        private PointPropertyType[] pointPropertyField;

        /// <remarks/>
        public DirectPositionListType posList
        {
            get
            {
                return this.posListField;
            }
            set
            {
                this.posListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public DirectPositionType[] pos
        {
            get
            {
                return this.posField;
            }
            set
            {
                this.posField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public PointPropertyType[] pointProperty
        {
            get
            {
                return this.pointPropertyField;
            }
            set
            {
                this.pointPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("posList", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectPositionListType
    {

        private string srsNameField;

        private string srsDimensionField;

        private string countField;

        private double[] textField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string srsDimension
        {
            get
            {
                return this.srsDimensionField;
            }
            set
            {
                this.srsDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public double[] Text
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Sphere", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SphereType : AbstractGriddedSurfaceType
    {

        private CurveInterpolationType horizontalCurveTypeField;

        private bool horizontalCurveTypeFieldSpecified;

        private CurveInterpolationType verticalCurveTypeField;

        private bool verticalCurveTypeFieldSpecified;

        public SphereType()
        {
            this.horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
            this.verticalCurveTypeField = CurveInterpolationType.circularArc3Points;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType horizontalCurveType
        {
            get
            {
                return this.horizontalCurveTypeField;
            }
            set
            {
                this.horizontalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalCurveTypeSpecified
        {
            get
            {
                return this.horizontalCurveTypeFieldSpecified;
            }
            set
            {
                this.horizontalCurveTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType verticalCurveType
        {
            get
            {
                return this.verticalCurveTypeField;
            }
            set
            {
                this.verticalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalCurveTypeSpecified
        {
            get
            {
                return this.verticalCurveTypeFieldSpecified;
            }
            set
            {
                this.verticalCurveTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum CurveInterpolationType
    {

        /// <remarks/>
        linear,

        /// <remarks/>
        geodesic,

        /// <remarks/>
        circularArc3Points,

        /// <remarks/>
        circularArc2PointWithBulge,

        /// <remarks/>
        circularArcCenterPointWithRadius,

        /// <remarks/>
        elliptical,

        /// <remarks/>
        clothoid,

        /// <remarks/>
        conic,

        /// <remarks/>
        polynomialSpline,

        /// <remarks/>
        cubicSpline,

        /// <remarks/>
        rationalSpline,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Cylinder", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CylinderType : AbstractGriddedSurfaceType
    {

        private CurveInterpolationType horizontalCurveTypeField;

        private bool horizontalCurveTypeFieldSpecified;

        private CurveInterpolationType verticalCurveTypeField;

        private bool verticalCurveTypeFieldSpecified;

        public CylinderType()
        {
            this.horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
            this.verticalCurveTypeField = CurveInterpolationType.linear;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType horizontalCurveType
        {
            get
            {
                return this.horizontalCurveTypeField;
            }
            set
            {
                this.horizontalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalCurveTypeSpecified
        {
            get
            {
                return this.horizontalCurveTypeFieldSpecified;
            }
            set
            {
                this.horizontalCurveTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType verticalCurveType
        {
            get
            {
                return this.verticalCurveTypeField;
            }
            set
            {
                this.verticalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalCurveTypeSpecified
        {
            get
            {
                return this.verticalCurveTypeFieldSpecified;
            }
            set
            {
                this.verticalCurveTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Cone", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConeType : AbstractGriddedSurfaceType
    {

        private CurveInterpolationType horizontalCurveTypeField;

        private bool horizontalCurveTypeFieldSpecified;

        private CurveInterpolationType verticalCurveTypeField;

        private bool verticalCurveTypeFieldSpecified;

        public ConeType()
        {
            this.horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
            this.verticalCurveTypeField = CurveInterpolationType.linear;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType horizontalCurveType
        {
            get
            {
                return this.horizontalCurveTypeField;
            }
            set
            {
                this.horizontalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalCurveTypeSpecified
        {
            get
            {
                return this.horizontalCurveTypeFieldSpecified;
            }
            set
            {
                this.horizontalCurveTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType verticalCurveType
        {
            get
            {
                return this.verticalCurveTypeField;
            }
            set
            {
                this.verticalCurveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalCurveTypeSpecified
        {
            get
            {
                return this.verticalCurveTypeFieldSpecified;
            }
            set
            {
                this.verticalCurveTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Rectangle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RectangleType : AbstractSurfacePatchType
    {

        private AbstractRingPropertyType exteriorField;

        private SurfaceInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        public RectangleType()
        {
            this.interpolationField = SurfaceInterpolationType.planar;
        }

        /// <remarks/>
        public AbstractRingPropertyType exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum SurfaceInterpolationType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        planar,

        /// <remarks/>
        spherical,

        /// <remarks/>
        elliptical,

        /// <remarks/>
        conic,

        /// <remarks/>
        tin,

        /// <remarks/>
        parametricCurve,

        /// <remarks/>
        polynomialSpline,

        /// <remarks/>
        rationalSpline,

        /// <remarks/>
        triangulatedSpline,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Triangle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TriangleType : AbstractSurfacePatchType
    {

        private AbstractRingPropertyType exteriorField;

        private SurfaceInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        public TriangleType()
        {
            this.interpolationField = SurfaceInterpolationType.planar;
        }

        /// <remarks/>
        public AbstractRingPropertyType exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PolygonPatch", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolygonPatchType : AbstractSurfacePatchType
    {

        private AbstractRingPropertyType exteriorField;

        private AbstractRingPropertyType[] interiorField;

        private SurfaceInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        public PolygonPatchType()
        {
            this.interpolationField = SurfaceInterpolationType.planar;
        }

        /// <remarks/>
        public AbstractRingPropertyType exterior
        {
            get
            {
                return this.exteriorField;
            }
            set
            {
                this.exteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public AbstractRingPropertyType[] interior
        {
            get
            {
                return this.interiorField;
            }
            set
            {
                this.interiorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("trianglePatches", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TrianglePatchArrayPropertyType : SurfacePatchArrayPropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("polygonPatches", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolygonPatchArrayPropertyType : SurfacePatchArrayPropertyType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TriangulatedSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TriangulatedSurfaceType : SurfaceType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Tin", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TinType : TriangulatedSurfaceType
    {

        private LineStringSegmentType[][] stopLinesField;

        private LineStringSegmentType[][] breakLinesField;

        private LengthType maxLengthField;

        private TinTypeControlPoint controlPointField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LineStringSegment", typeof(LineStringSegmentType), IsNullable = false)]
        public LineStringSegmentType[][] stopLines
        {
            get
            {
                return this.stopLinesField;
            }
            set
            {
                this.stopLinesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LineStringSegment", typeof(LineStringSegmentType), IsNullable = false)]
        public LineStringSegmentType[][] breakLines
        {
            get
            {
                return this.breakLinesField;
            }
            set
            {
                this.breakLinesField = value;
            }
        }

        /// <remarks/>
        public LengthType maxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        public TinTypeControlPoint controlPoint
        {
            get
            {
                return this.controlPointField;
            }
            set
            {
                this.controlPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LineStringSegment", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LineStringSegmentType : AbstractCurveSegmentType
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        public LineStringSegmentType()
        {
            this.interpolationField = CurveInterpolationType.linear;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BSplineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CubicSplineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClothoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OffsetCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByCenterPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringByBulgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringSegmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCurveSegmentType
    {

        private string numDerivativesAtStartField;

        private string numDerivativesAtEndField;

        private string numDerivativeInteriorField;

        public AbstractCurveSegmentType()
        {
            this.numDerivativesAtStartField = "0";
            this.numDerivativesAtEndField = "0";
            this.numDerivativeInteriorField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativesAtStart
        {
            get
            {
                return this.numDerivativesAtStartField;
            }
            set
            {
                this.numDerivativesAtStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativesAtEnd
        {
            get
            {
                return this.numDerivativesAtEndField;
            }
            set
            {
                this.numDerivativesAtEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativeInterior
        {
            get
            {
                return this.numDerivativeInteriorField;
            }
            set
            {
                this.numDerivativeInteriorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("BSpline", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class BSplineType : AbstractCurveSegmentType
    {

        private object[] itemsField;

        private ItemsChoiceType6[] itemsElementNameField;

        private string degreeField;

        private KnotPropertyType[] knotField;

        private CurveInterpolationType interpolationField;

        private bool isPolynomialField;

        private bool isPolynomialFieldSpecified;

        private KnotTypesType knotTypeField;

        private bool knotTypeFieldSpecified;

        public BSplineType()
        {
            this.interpolationField = CurveInterpolationType.polynomialSpline;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType6[] ItemsElementName
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string degree
        {
            get
            {
                return this.degreeField;
            }
            set
            {
                this.degreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("knot")]
        public KnotPropertyType[] knot
        {
            get
            {
                return this.knotField;
            }
            set
            {
                this.knotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(CurveInterpolationType.polynomialSpline)]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isPolynomial
        {
            get
            {
                return this.isPolynomialField;
            }
            set
            {
                this.isPolynomialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPolynomialSpecified
        {
            get
            {
                return this.isPolynomialFieldSpecified;
            }
            set
            {
                this.isPolynomialFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public KnotTypesType knotType
        {
            get
            {
                return this.knotTypeField;
            }
            set
            {
                this.knotTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool knotTypeSpecified
        {
            get
            {
                return this.knotTypeFieldSpecified;
            }
            set
            {
                this.knotTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType6
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class KnotPropertyType
    {

        private KnotType knotField;

        /// <remarks/>
        public KnotType Knot
        {
            get
            {
                return this.knotField;
            }
            set
            {
                this.knotField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class KnotType
    {

        private double valueField;

        private string multiplicityField;

        private double weightField;

        /// <remarks/>
        public double value
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string multiplicity
        {
            get
            {
                return this.multiplicityField;
            }
            set
            {
                this.multiplicityField = value;
            }
        }

        /// <remarks/>
        public double weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum KnotTypesType
    {

        /// <remarks/>
        uniform,

        /// <remarks/>
        quasiUniform,

        /// <remarks/>
        piecewiseBezier,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Bezier", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class BezierType : BSplineType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CubicSpline", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CubicSplineType : AbstractCurveSegmentType
    {

        private object[] itemsField;

        private ItemsChoiceType5[] itemsElementNameField;

        private VectorType vectorAtStartField;

        private VectorType vectorAtEndField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        private string degreeField;

        public CubicSplineType()
        {
            this.interpolationField = CurveInterpolationType.cubicSpline;
            this.degreeField = "3";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType5[] ItemsElementName
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
        public VectorType vectorAtStart
        {
            get
            {
                return this.vectorAtStartField;
            }
            set
            {
                this.vectorAtStartField = value;
            }
        }

        /// <remarks/>
        public VectorType vectorAtEnd
        {
            get
            {
                return this.vectorAtEndField;
            }
            set
            {
                this.vectorAtEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string degree
        {
            get
            {
                return this.degreeField;
            }
            set
            {
                this.degreeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("vector", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VectorType
    {

        private string srsNameField;

        private string srsDimensionField;

        private double[] textField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string srsDimension
        {
            get
            {
                return this.srsDimensionField;
            }
            set
            {
                this.srsDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double[] Text
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeodesicString", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeodesicStringType : AbstractCurveSegmentType
    {

        private object itemField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        public GeodesicStringType()
        {
            this.interpolationField = CurveInterpolationType.geodesic;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Geodesic", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeodesicType : GeodesicStringType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Clothoid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ClothoidType : AbstractCurveSegmentType
    {

        private ClothoidTypeRefLocation refLocationField;

        private decimal scaleFactorField;

        private double startParameterField;

        private double endParameterField;

        /// <remarks/>
        public ClothoidTypeRefLocation refLocation
        {
            get
            {
                return this.refLocationField;
            }
            set
            {
                this.refLocationField = value;
            }
        }

        /// <remarks/>
        public decimal scaleFactor
        {
            get
            {
                return this.scaleFactorField;
            }
            set
            {
                this.scaleFactorField = value;
            }
        }

        /// <remarks/>
        public double startParameter
        {
            get
            {
                return this.startParameterField;
            }
            set
            {
                this.startParameterField = value;
            }
        }

        /// <remarks/>
        public double endParameter
        {
            get
            {
                return this.endParameterField;
            }
            set
            {
                this.endParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class ClothoidTypeRefLocation
    {

        private AffinePlacementType affinePlacementField;

        /// <remarks/>
        public AffinePlacementType AffinePlacement
        {
            get
            {
                return this.affinePlacementField;
            }
            set
            {
                this.affinePlacementField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("AffinePlacement", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AffinePlacementType
    {

        private DirectPositionType locationField;

        private VectorType[] refDirectionField;

        private string inDimensionField;

        private string outDimensionField;

        /// <remarks/>
        public DirectPositionType location
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
        [System.Xml.Serialization.XmlElementAttribute("refDirection")]
        public VectorType[] refDirection
        {
            get
            {
                return this.refDirectionField;
            }
            set
            {
                this.refDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string inDimension
        {
            get
            {
                return this.inDimensionField;
            }
            set
            {
                this.inDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string outDimension
        {
            get
            {
                return this.outDimensionField;
            }
            set
            {
                this.outDimensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OffsetCurve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OffsetCurveType : AbstractCurveSegmentType
    {

        private CurvePropertyType offsetBaseField;

        private LengthType distanceField;

        private VectorType refDirectionField;

        /// <remarks/>
        public CurvePropertyType offsetBase
        {
            get
            {
                return this.offsetBaseField;
            }
            set
            {
                this.offsetBaseField = value;
            }
        }

        /// <remarks/>
        public LengthType distance
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

        /// <remarks/>
        public VectorType refDirection
        {
            get
            {
                return this.refDirectionField;
            }
            set
            {
                this.refDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("edgeOf", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CurvePropertyType
    {

        private LineStringType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineString")]
        public LineStringType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LineString", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LineStringType : AbstractCurveType
    {

        private object[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType4[] ItemsElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        /// <remarks/>
        coord,

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCurveType : AbstractGeometricPrimitiveType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeCurve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompositeCurveType : AbstractCurveType
    {

        private CurvePropertyType[] curveMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember
        {
            get
            {
                return this.curveMemberField;
            }
            set
            {
                this.curveMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableCurve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OrientableCurveType : AbstractCurveType
    {

        private CurvePropertyType baseCurveField;

        private SignType orientationField;

        public OrientableCurveType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public CurvePropertyType baseCurve
        {
            get
            {
                return this.baseCurveField;
            }
            set
            {
                this.baseCurveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Curve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CurveType : AbstractCurveType
    {

        private AbstractCurveSegmentType[] segmentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_CurveSegment", IsNullable = false)]
        public AbstractCurveSegmentType[] segments
        {
            get
            {
                return this.segmentsField;
            }
            set
            {
                this.segmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ArcByCenterPoint", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArcByCenterPointType : AbstractCurveSegmentType
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private LengthType radiusField;

        private AngleType startAngleField;

        private AngleType endAngleField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        private string numArcField;

        public ArcByCenterPointType()
        {
            this.interpolationField = CurveInterpolationType.circularArcCenterPointWithRadius;
            this.numArcField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public LengthType radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }

        /// <remarks/>
        public AngleType startAngle
        {
            get
            {
                return this.startAngleField;
            }
            set
            {
                this.startAngleField = value;
            }
        }

        /// <remarks/>
        public AngleType endAngle
        {
            get
            {
                return this.endAngleField;
            }
            set
            {
                this.endAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string numArc
        {
            get
            {
                return this.numArcField;
            }
            set
            {
                this.numArcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CircleByCenterPoint", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CircleByCenterPointType : ArcByCenterPointType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ArcStringByBulge", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArcStringByBulgeType : AbstractCurveSegmentType
    {

        private object[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private double[] bulgeField;

        private VectorType[] normalField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        private string numArcField;

        public ArcStringByBulgeType()
        {
            this.interpolationField = CurveInterpolationType.circularArc2PointWithBulge;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType3[] ItemsElementName
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
        [System.Xml.Serialization.XmlElementAttribute("bulge")]
        public double[] bulge
        {
            get
            {
                return this.bulgeField;
            }
            set
            {
                this.bulgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("normal")]
        public VectorType[] normal
        {
            get
            {
                return this.normalField;
            }
            set
            {
                this.normalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string numArc
        {
            get
            {
                return this.numArcField;
            }
            set
            {
                this.numArcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ArcByBulge", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArcByBulgeType : ArcStringByBulgeType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ArcString", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArcStringType : AbstractCurveSegmentType
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private CurveInterpolationType interpolationField;

        private bool interpolationFieldSpecified;

        private string numArcField;

        public ArcStringType()
        {
            this.interpolationField = CurveInterpolationType.circularArc3Points;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType2[] ItemsElementName
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation
        {
            get
            {
                return this.interpolationField;
            }
            set
            {
                this.interpolationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified
        {
            get
            {
                return this.interpolationFieldSpecified;
            }
            set
            {
                this.interpolationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string numArc
        {
            get
            {
                return this.numArcField;
            }
            set
            {
                this.numArcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Arc", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArcType : ArcStringType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Circle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CircleType : ArcType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    public partial class TinTypeControlPoint
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PolyhedralSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolyhedralSurfaceType : SurfaceType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeometricComplex", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeometricComplexType : AbstractGeometryType
    {

        private GeometricPrimitivePropertyType[] elementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public GeometricPrimitivePropertyType[] element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class GeometricPrimitivePropertyType
    {

        private PointType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public PointType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeometricAggregateType : AbstractGeometryType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPolygon", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiPolygonType : AbstractGeometricAggregateType
    {

        private PolygonPropertyType[] polygonMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("polygonMember")]
        public PolygonPropertyType[] polygonMember
        {
            get
            {
                return this.polygonMemberField;
            }
            set
            {
                this.polygonMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("polygonProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolygonPropertyType
    {

        private PolygonType polygonField;

        private string remoteSchemaField;

        /// <remarks/>
        public PolygonType Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiLineString", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiLineStringType : AbstractGeometricAggregateType
    {

        private LineStringPropertyType[] lineStringMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineStringMember")]
        public LineStringPropertyType[] lineStringMember
        {
            get
            {
                return this.lineStringMemberField;
            }
            set
            {
                this.lineStringMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("lineStringMember", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LineStringPropertyType
    {

        private LineStringType lineStringField;

        private string remoteSchemaField;

        /// <remarks/>
        public LineStringType LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSolid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSolidType : AbstractGeometricAggregateType
    {

        private SolidPropertyType[] solidMemberField;

        private SolidArrayPropertyType solidMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("solidMember")]
        public SolidPropertyType[] solidMember
        {
            get
            {
                return this.solidMemberField;
            }
            set
            {
                this.solidMemberField = value;
            }
        }

        /// <remarks/>
        public SolidArrayPropertyType solidMembers
        {
            get
            {
                return this.solidMembersField;
            }
            set
            {
                this.solidMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("solidArrayProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SolidArrayPropertyType
    {

        private AbstractSolidType[] _SolidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Solid")]
        public AbstractSolidType[] _Solid
        {
            get
            {
                return this._SolidField;
            }
            set
            {
                this._SolidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSurfaceType : AbstractGeometricAggregateType
    {

        private SurfacePropertyType[] surfaceMemberField;

        private AbstractSurfaceType[] surfaceMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember
        {
            get
            {
                return this.surfaceMemberField;
            }
            set
            {
                this.surfaceMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Surface", IsNullable = false)]
        public AbstractSurfaceType[] surfaceMembers
        {
            get
            {
                return this.surfaceMembersField;
            }
            set
            {
                this.surfaceMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiCurve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiCurveType : AbstractGeometricAggregateType
    {

        private CurvePropertyType[] curveMemberField;

        private AbstractCurveType[] curveMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember
        {
            get
            {
                return this.curveMemberField;
            }
            set
            {
                this.curveMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Curve", IsNullable = false)]
        public AbstractCurveType[] curveMembers
        {
            get
            {
                return this.curveMembersField;
            }
            set
            {
                this.curveMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPoint", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiPointType : AbstractGeometricAggregateType
    {

        private PointPropertyType[] pointMemberField;

        private PointType[] pointMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointMember")]
        public PointPropertyType[] pointMember
        {
            get
            {
                return this.pointMemberField;
            }
            set
            {
                this.pointMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable = false)]
        public PointType[] pointMembers
        {
            get
            {
                return this.pointMembersField;
            }
            set
            {
                this.pointMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiGeometry", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiGeometryType : AbstractGeometricAggregateType
    {

        private GeometryPropertyType[] geometryMemberField;

        private AbstractGeometryType[] geometryMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geometryMember")]
        public GeometryPropertyType[] geometryMember
        {
            get
            {
                return this.geometryMemberField;
            }
            set
            {
                this.geometryMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Geometry", IsNullable = false)]
        public AbstractGeometryType[] geometryMembers
        {
            get
            {
                return this.geometryMembersField;
            }
            set
            {
                this.geometryMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geometryMember", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeometryPropertyType
    {

        private AbstractGeometryType _GeometryField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractGeometryType _Geometry
        {
            get
            {
                return this._GeometryField;
            }
            set
            {
                this._GeometryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Ring", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RingType : AbstractRingType
    {

        private CurvePropertyType[] curveMemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember
        {
            get
            {
                return this.curveMemberField;
            }
            set
            {
                this.curveMemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LinearRing", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LinearRingType : AbstractRingType
    {

        private object[] itemsField;

        private ItemsChoiceType7[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coord", typeof(CoordType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof(CoordinatesType))]
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
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
        public ItemsChoiceType7[] ItemsElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType7
    {

        /// <remarks/>
        coord,

        /// <remarks/>
        coordinates,

        /// <remarks/>
        pointProperty,

        /// <remarks/>
        pointRep,

        /// <remarks/>
        pos,

        /// <remarks/>
        posList,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CovarianceMatrixType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativeInternalPositionalAccuracyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbsoluteExternalPositionalAccuracyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractPositionalAccuracyType
    {

        private CodeType1 measureDescriptionField;

        /// <remarks/>
        public CodeType1 measureDescription
        {
            get
            {
                return this.measureDescriptionField;
            }
            set
            {
                this.measureDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("covarianceMatrix", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CovarianceMatrixType : AbstractPositionalAccuracyType
    {

        private UnitOfMeasureType[] unitOfMeasureField;

        private CovarianceElementType[] includesElementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitOfMeasure")]
        public UnitOfMeasureType[] unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesElement")]
        public CovarianceElementType[] includesElement
        {
            get
            {
                return this.includesElementField;
            }
            set
            {
                this.includesElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("includesElement", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CovarianceElementType
    {

        private string rowIndexField;

        private string columnIndexField;

        private double covarianceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string rowIndex
        {
            get
            {
                return this.rowIndexField;
            }
            set
            {
                this.rowIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string columnIndex
        {
            get
            {
                return this.columnIndexField;
            }
            set
            {
                this.columnIndexField = value;
            }
        }

        /// <remarks/>
        public double covariance
        {
            get
            {
                return this.covarianceField;
            }
            set
            {
                this.covarianceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("relativeInternalPositionalAccuracy", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RelativeInternalPositionalAccuracyType : AbstractPositionalAccuracyType
    {

        private MeasureType resultField;

        /// <remarks/>
        public MeasureType result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("absoluteExternalPositionalAccuracy", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AbsoluteExternalPositionalAccuracyType : AbstractPositionalAccuracyType
    {

        private MeasureType resultField;

        /// <remarks/>
        public MeasureType result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("crsRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CRSRefType
    {

        private AbstractReferenceSystemType _CRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractReferenceSystemType _CRS
        {
            get
            {
                return this._CRSField;
            }
            set
            {
                this._CRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractReferenceSystemType : AbstractReferenceSystemBaseType
    {

        private IdentifierType[] srsIDField;

        private StringOrRefType remarksField;

        private ExtentType validAreaField;

        private string scopeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("srsID")]
        public IdentifierType[] srsID
        {
            get
            {
                return this.srsIDField;
            }
            set
            {
                this.srsIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public ExtentType validArea
        {
            get
            {
                return this.validAreaField;
            }
            set
            {
                this.validAreaField = value;
            }
        }

        /// <remarks/>
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeocentricCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundCRSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractReferenceSystemBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalCRSType : AbstractReferenceSystemType
    {

        private TemporalCSRefType usesTemporalCSField;

        private TemporalDatumRefType usesTemporalDatumField;

        /// <remarks/>
        public TemporalCSRefType usesTemporalCS
        {
            get
            {
                return this.usesTemporalCSField;
            }
            set
            {
                this.usesTemporalCSField = value;
            }
        }

        /// <remarks/>
        public TemporalDatumRefType usesTemporalDatum
        {
            get
            {
                return this.usesTemporalDatumField;
            }
            set
            {
                this.usesTemporalDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("temporalCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalCSRefType
    {

        private TemporalCSType temporalCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public TemporalCSType TemporalCS
        {
            get
            {
                return this.temporalCSField;
            }
            set
            {
                this.temporalCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateSystemType : AbstractCoordinateSystemBaseType
    {

        private IdentifierType[] csIDField;

        private StringOrRefType remarksField;

        private CoordinateSystemAxisRefType[] usesAxisField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("csID")]
        public IdentifierType[] csID
        {
            get
            {
                return this.csIDField;
            }
            set
            {
                this.csIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesAxis")]
        public CoordinateSystemAxisRefType[] usesAxis
        {
            get
            {
                return this.usesAxisField;
            }
            set
            {
                this.usesAxisField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateSystemAxisRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinateSystemAxisRefType
    {

        private CoordinateSystemAxisType coordinateSystemAxisField;

        private string remoteSchemaField;

        /// <remarks/>
        public CoordinateSystemAxisType CoordinateSystemAxis
        {
            get
            {
                return this.coordinateSystemAxisField;
            }
            set
            {
                this.coordinateSystemAxisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinateSystemAxisType : CoordinateSystemAxisBaseType
    {

        private IdentifierType[] axisIDField;

        private StringOrRefType remarksField;

        private CodeType1 axisAbbrevField;

        private CodeType1 axisDirectionField;

        private string uomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axisID")]
        public IdentifierType[] axisID
        {
            get
            {
                return this.axisIDField;
            }
            set
            {
                this.axisIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public CodeType1 axisAbbrev
        {
            get
            {
                return this.axisAbbrevField;
            }
            set
            {
                this.axisAbbrevField = value;
            }
        }

        /// <remarks/>
        public CodeType1 axisDirection
        {
            get
            {
                return this.axisDirectionField;
            }
            set
            {
                this.axisDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class CoordinateSystemAxisBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateSystemBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ObliqueCartesianCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ObliqueCartesianCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CylindricalCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CylindricalCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PolarCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolarCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("SphericalCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SphericalCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("UserDefinedCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class UserDefinedCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LinearCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LinearCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CartesianCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CartesianCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EllipsoidalCS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EllipsoidalCSType : AbstractCoordinateSystemType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("temporalDatumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalDatumRefType
    {

        private TemporalDatumType temporalDatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public TemporalDatumType TemporalDatum
        {
            get
            {
                return this.temporalDatumField;
            }
            set
            {
                this.temporalDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalDatum", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalDatumType : TemporalDatumBaseType
    {

        private System.DateTime originField;

        /// <remarks/>
        public System.DateTime origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class TemporalDatumBaseType : AbstractDatumType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractDatumType : AbstractDatumBaseType
    {

        private IdentifierType[] datumIDField;

        private StringOrRefType remarksField;

        private CodeType1 anchorPointField;

        private System.DateTime realizationEpochField;

        private bool realizationEpochFieldSpecified;

        private ExtentType validAreaField;

        private string scopeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("datumID")]
        public IdentifierType[] datumID
        {
            get
            {
                return this.datumIDField;
            }
            set
            {
                this.datumIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public CodeType1 anchorPoint
        {
            get
            {
                return this.anchorPointField;
            }
            set
            {
                this.anchorPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime realizationEpoch
        {
            get
            {
                return this.realizationEpochField;
            }
            set
            {
                this.realizationEpochField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool realizationEpochSpecified
        {
            get
            {
                return this.realizationEpochFieldSpecified;
            }
            set
            {
                this.realizationEpochFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ExtentType validArea
        {
            get
            {
                return this.validAreaField;
            }
            set
            {
                this.validAreaField = value;
            }
        }

        /// <remarks/>
        public string scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractDatumBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeodeticDatumType : AbstractDatumType
    {

        private PrimeMeridianRefType usesPrimeMeridianField;

        private EllipsoidRefType usesEllipsoidField;

        /// <remarks/>
        public PrimeMeridianRefType usesPrimeMeridian
        {
            get
            {
                return this.usesPrimeMeridianField;
            }
            set
            {
                this.usesPrimeMeridianField = value;
            }
        }

        /// <remarks/>
        public EllipsoidRefType usesEllipsoid
        {
            get
            {
                return this.usesEllipsoidField;
            }
            set
            {
                this.usesEllipsoidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesPrimeMeridian", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PrimeMeridianRefType
    {

        private PrimeMeridianType primeMeridianField;

        private string remoteSchemaField;

        /// <remarks/>
        public PrimeMeridianType PrimeMeridian
        {
            get
            {
                return this.primeMeridianField;
            }
            set
            {
                this.primeMeridianField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PrimeMeridianType : PrimeMeridianBaseType
    {

        private IdentifierType[] meridianIDField;

        private StringOrRefType remarksField;

        private AngleChoiceType greenwichLongitudeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("meridianID")]
        public IdentifierType[] meridianID
        {
            get
            {
                return this.meridianIDField;
            }
            set
            {
                this.meridianIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public AngleChoiceType greenwichLongitude
        {
            get
            {
                return this.greenwichLongitudeField;
            }
            set
            {
                this.greenwichLongitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("greenwichLongitude", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AngleChoiceType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("angle", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("dmsAngle", typeof(DMSAngleType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("dmsAngleValue", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DMSAngleType
    {

        private DegreesType degreesField;

        private object[] itemsField;

        private ItemsChoiceType10[] itemsElementNameField;

        /// <remarks/>
        public DegreesType degrees
        {
            get
            {
                return this.degreesField;
            }
            set
            {
                this.degreesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("decimalMinutes", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("minutes", typeof(string), DataType = "nonNegativeInteger")]
        [System.Xml.Serialization.XmlElementAttribute("seconds", typeof(decimal))]
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
        public ItemsChoiceType10[] ItemsElementName
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("degrees", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DegreesType
    {

        private string directionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType10
    {

        /// <remarks/>
        decimalMinutes,

        /// <remarks/>
        minutes,

        /// <remarks/>
        seconds,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class PrimeMeridianBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesEllipsoid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EllipsoidRefType
    {

        private EllipsoidType ellipsoidField;

        private string remoteSchemaField;

        /// <remarks/>
        public EllipsoidType Ellipsoid
        {
            get
            {
                return this.ellipsoidField;
            }
            set
            {
                this.ellipsoidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EllipsoidType : EllipsoidBaseType
    {

        private IdentifierType[] ellipsoidIDField;

        private StringOrRefType remarksField;

        private MeasureType semiMajorAxisField;

        private SecondDefiningParameterType secondDefiningParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ellipsoidID")]
        public IdentifierType[] ellipsoidID
        {
            get
            {
                return this.ellipsoidIDField;
            }
            set
            {
                this.ellipsoidIDField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public MeasureType semiMajorAxis
        {
            get
            {
                return this.semiMajorAxisField;
            }
            set
            {
                this.semiMajorAxisField = value;
            }
        }

        /// <remarks/>
        public SecondDefiningParameterType secondDefiningParameter
        {
            get
            {
                return this.secondDefiningParameterField;
            }
            set
            {
                this.secondDefiningParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("secondDefiningParameter", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SecondDefiningParameterType
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inverseFlattening", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("isSphere", typeof(isSphere))]
        [System.Xml.Serialization.XmlElementAttribute("semiMinorAxis", typeof(MeasureType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public enum isSphere
    {

        /// <remarks/>
        sphere,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        inverseFlattening,

        /// <remarks/>
        isSphere,

        /// <remarks/>
        semiMinorAxis,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class EllipsoidBaseType : DefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalDatum", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalDatumType : AbstractDatumType
    {

        private VerticalDatumTypeType verticalDatumTypeField;

        /// <remarks/>
        public VerticalDatumTypeType verticalDatumType
        {
            get
            {
                return this.verticalDatumTypeField;
            }
            set
            {
                this.verticalDatumTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ImageDatum", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ImageDatumType : AbstractDatumType
    {

        private PixelInCellType pixelInCellField;

        /// <remarks/>
        public PixelInCellType pixelInCell
        {
            get
            {
                return this.pixelInCellField;
            }
            set
            {
                this.pixelInCellField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EngineeringDatum", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EngineeringDatumType : AbstractDatumType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ImageCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ImageCRSType : AbstractReferenceSystemType
    {

        private object itemField;

        private ImageDatumRefType usesImageDatumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof(CartesianCSRefType))]
        [System.Xml.Serialization.XmlElementAttribute("usesObliqueCartesianCS", typeof(ObliqueCartesianCSRefType))]
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
        public ImageDatumRefType usesImageDatum
        {
            get
            {
                return this.usesImageDatumField;
            }
            set
            {
                this.usesImageDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("cartesianCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CartesianCSRefType
    {

        private CartesianCSType cartesianCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public CartesianCSType CartesianCS
        {
            get
            {
                return this.cartesianCSField;
            }
            set
            {
                this.cartesianCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("obliqueCartesianCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ObliqueCartesianCSRefType
    {

        private ObliqueCartesianCSType obliqueCartesianCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public ObliqueCartesianCSType ObliqueCartesianCS
        {
            get
            {
                return this.obliqueCartesianCSField;
            }
            set
            {
                this.obliqueCartesianCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("imageDatumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ImageDatumRefType
    {

        private ImageDatumType imageDatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public ImageDatumType ImageDatum
        {
            get
            {
                return this.imageDatumField;
            }
            set
            {
                this.imageDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EngineeringCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EngineeringCRSType : AbstractReferenceSystemType
    {

        private CoordinateSystemRefType usesCSField;

        private EngineeringDatumRefType usesEngineeringDatumField;

        /// <remarks/>
        public CoordinateSystemRefType usesCS
        {
            get
            {
                return this.usesCSField;
            }
            set
            {
                this.usesCSField = value;
            }
        }

        /// <remarks/>
        public EngineeringDatumRefType usesEngineeringDatum
        {
            get
            {
                return this.usesEngineeringDatumField;
            }
            set
            {
                this.usesEngineeringDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateSystemRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinateSystemRefType
    {

        private AbstractCoordinateSystemType _CoordinateSystemField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractCoordinateSystemType _CoordinateSystem
        {
            get
            {
                return this._CoordinateSystemField;
            }
            set
            {
                this._CoordinateSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("engineeringDatumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EngineeringDatumRefType
    {

        private EngineeringDatumType engineeringDatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public EngineeringDatumType EngineeringDatum
        {
            get
            {
                return this.engineeringDatumField;
            }
            set
            {
                this.engineeringDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralDerivedCRSType : AbstractReferenceSystemType
    {

        private CoordinateReferenceSystemRefType baseCRSField;

        private GeneralConversionRefType definedByConversionField;

        /// <remarks/>
        public CoordinateReferenceSystemRefType baseCRS
        {
            get
            {
                return this.baseCRSField;
            }
            set
            {
                this.baseCRSField = value;
            }
        }

        /// <remarks/>
        public GeneralConversionRefType definedByConversion
        {
            get
            {
                return this.definedByConversionField;
            }
            set
            {
                this.definedByConversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateReferenceSystemRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinateReferenceSystemRefType
    {

        private AbstractReferenceSystemType _CoordinateReferenceSystemField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractReferenceSystemType _CoordinateReferenceSystem
        {
            get
            {
                return this._CoordinateReferenceSystemField;
            }
            set
            {
                this._CoordinateReferenceSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("generalConversionRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeneralConversionRefType
    {

        private AbstractGeneralConversionType _GeneralConversionField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractGeneralConversionType _GeneralConversion
        {
            get
            {
                return this._GeneralConversionField;
            }
            set
            {
                this._GeneralConversionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralConversionType : AbstractCoordinateOperationType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Conversion", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConversionType : AbstractGeneralConversionType
    {

        private OperationMethodRefType usesMethodField;

        private ParameterValueType[] usesValueField;

        /// <remarks/>
        public OperationMethodRefType usesMethod
        {
            get
            {
                return this.usesMethodField;
            }
            set
            {
                this.usesMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesValue")]
        public ParameterValueType[] usesValue
        {
            get
            {
                return this.usesValueField;
            }
            set
            {
                this.usesValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesMethod", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationMethodRefType
    {

        private OperationMethodType operationMethodField;

        private string remoteSchemaField;

        /// <remarks/>
        public OperationMethodType OperationMethod
        {
            get
            {
                return this.operationMethodField;
            }
            set
            {
                this.operationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesValue", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ParameterValueType : AbstractGeneralParameterValueType
    {

        private object itemField;

        private ItemChoiceType2 itemElementNameField;

        private OperationParameterRefType valueOfParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("booleanValue", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("dmsAngleValue", typeof(DMSAngleType))]
        [System.Xml.Serialization.XmlElementAttribute("integerValue", typeof(string), DataType = "positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("integerValueList", typeof(string), DataType = "integer")]
        [System.Xml.Serialization.XmlElementAttribute("stringValue", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("valueFile", typeof(string), DataType = "anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("valueList", typeof(MeasureListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public OperationParameterRefType valueOfParameter
        {
            get
            {
                return this.valueOfParameterField;
            }
            set
            {
                this.valueOfParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueList", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MeasureListType
    {

        private string uomField;

        private double[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
        public double[] Text
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        booleanValue,

        /// <remarks/>
        dmsAngleValue,

        /// <remarks/>
        integerValue,

        /// <remarks/>
        integerValueList,

        /// <remarks/>
        stringValue,

        /// <remarks/>
        value,

        /// <remarks/>
        valueFile,

        /// <remarks/>
        valueList,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueOfParameter", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationParameterRefType
    {

        private OperationParameterType operationParameterField;

        private string remoteSchemaField;

        /// <remarks/>
        public OperationParameterType OperationParameter
        {
            get
            {
                return this.operationParameterField;
            }
            set
            {
                this.operationParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValueGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParameterValueType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("includesValue", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public abstract partial class AbstractGeneralParameterValueType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("parameterValueGroup", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ParameterValueGroupType : AbstractGeneralParameterValueType
    {

        private AbstractGeneralParameterValueType[] includesValueField;

        private OperationParameterGroupRefType valuesOfGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesValue")]
        public AbstractGeneralParameterValueType[] includesValue
        {
            get
            {
                return this.includesValueField;
            }
            set
            {
                this.includesValueField = value;
            }
        }

        /// <remarks/>
        public OperationParameterGroupRefType valuesOfGroup
        {
            get
            {
                return this.valuesOfGroupField;
            }
            set
            {
                this.valuesOfGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valuesOfGroup", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationParameterGroupRefType
    {

        private OperationParameterGroupType operationParameterGroupField;

        private string remoteSchemaField;

        /// <remarks/>
        public OperationParameterGroupType OperationParameterGroup
        {
            get
            {
                return this.operationParameterGroupField;
            }
            set
            {
                this.operationParameterGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DerivedCRSType : AbstractGeneralDerivedCRSType
    {

        private DerivedCRSTypeType derivedCRSTypeField;

        private CoordinateSystemRefType usesCSField;

        /// <remarks/>
        public DerivedCRSTypeType derivedCRSType
        {
            get
            {
                return this.derivedCRSTypeField;
            }
            set
            {
                this.derivedCRSTypeField = value;
            }
        }

        /// <remarks/>
        public CoordinateSystemRefType usesCS
        {
            get
            {
                return this.usesCSField;
            }
            set
            {
                this.usesCSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType
    {

        private CartesianCSRefType usesCartesianCSField;

        /// <remarks/>
        public CartesianCSRefType usesCartesianCS
        {
            get
            {
                return this.usesCartesianCSField;
            }
            set
            {
                this.usesCartesianCSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeocentricCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeocentricCRSType : AbstractReferenceSystemType
    {

        private object itemField;

        private GeodeticDatumRefType usesGeodeticDatumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof(CartesianCSRefType))]
        [System.Xml.Serialization.XmlElementAttribute("usesSphericalCS", typeof(SphericalCSRefType))]
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
        public GeodeticDatumRefType usesGeodeticDatum
        {
            get
            {
                return this.usesGeodeticDatumField;
            }
            set
            {
                this.usesGeodeticDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("sphericalCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SphericalCSRefType
    {

        private SphericalCSType sphericalCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public SphericalCSType SphericalCS
        {
            get
            {
                return this.sphericalCSField;
            }
            set
            {
                this.sphericalCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geodeticDatumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeodeticDatumRefType
    {

        private GeodeticDatumType geodeticDatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public GeodeticDatumType GeodeticDatum
        {
            get
            {
                return this.geodeticDatumField;
            }
            set
            {
                this.geodeticDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalCRSType : AbstractReferenceSystemType
    {

        private VerticalCSRefType usesVerticalCSField;

        private VerticalDatumRefType usesVerticalDatumField;

        /// <remarks/>
        public VerticalCSRefType usesVerticalCS
        {
            get
            {
                return this.usesVerticalCSField;
            }
            set
            {
                this.usesVerticalCSField = value;
            }
        }

        /// <remarks/>
        public VerticalDatumRefType usesVerticalDatum
        {
            get
            {
                return this.usesVerticalDatumField;
            }
            set
            {
                this.usesVerticalDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("verticalCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalCSRefType
    {

        private VerticalCSType verticalCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public VerticalCSType VerticalCS
        {
            get
            {
                return this.verticalCSField;
            }
            set
            {
                this.verticalCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("verticalDatumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalDatumRefType
    {

        private VerticalDatumType verticalDatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public VerticalDatumType VerticalDatum
        {
            get
            {
                return this.verticalDatumField;
            }
            set
            {
                this.verticalDatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeographicCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeographicCRSType : AbstractReferenceSystemType
    {

        private EllipsoidalCSRefType usesEllipsoidalCSField;

        private GeodeticDatumRefType usesGeodeticDatumField;

        /// <remarks/>
        public EllipsoidalCSRefType usesEllipsoidalCS
        {
            get
            {
                return this.usesEllipsoidalCSField;
            }
            set
            {
                this.usesEllipsoidalCSField = value;
            }
        }

        /// <remarks/>
        public GeodeticDatumRefType usesGeodeticDatum
        {
            get
            {
                return this.usesGeodeticDatumField;
            }
            set
            {
                this.usesGeodeticDatumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoidalCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EllipsoidalCSRefType
    {

        private EllipsoidalCSType ellipsoidalCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public EllipsoidalCSType EllipsoidalCS
        {
            get
            {
                return this.ellipsoidalCSField;
            }
            set
            {
                this.ellipsoidalCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompoundCRS", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompoundCRSType : AbstractReferenceSystemType
    {

        private CoordinateReferenceSystemRefType[] includesCRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesCRS")]
        public CoordinateReferenceSystemRefType[] includesCRS
        {
            get
            {
                return this.includesCRSField;
            }
            set
            {
                this.includesCRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralTransformationType : AbstractCoordinateOperationType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Transformation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TransformationType : AbstractGeneralTransformationType
    {

        private OperationMethodRefType usesMethodField;

        private ParameterValueType[] usesValueField;

        /// <remarks/>
        public OperationMethodRefType usesMethod
        {
            get
            {
                return this.usesMethodField;
            }
            set
            {
                this.usesMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesValue")]
        public ParameterValueType[] usesValue
        {
            get
            {
                return this.usesValueField;
            }
            set
            {
                this.usesValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PassThroughOperation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PassThroughOperationType : AbstractCoordinateOperationType
    {

        private string[] modifiedCoordinateField;

        private OperationRefType usesOperationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modifiedCoordinate", DataType = "positiveInteger")]
        public string[] modifiedCoordinate
        {
            get
            {
                return this.modifiedCoordinateField;
            }
            set
            {
                this.modifiedCoordinateField = value;
            }
        }

        /// <remarks/>
        public OperationRefType usesOperation
        {
            get
            {
                return this.usesOperationField;
            }
            set
            {
                this.usesOperationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesOperation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class OperationRefType
    {

        private AbstractCoordinateOperationType _OperationField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractCoordinateOperationType _Operation
        {
            get
            {
                return this._OperationField;
            }
            set
            {
                this._OperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ConcatenatedOperation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConcatenatedOperationType : AbstractCoordinateOperationType
    {

        private SingleOperationRefType[] usesSingleOperationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesSingleOperation")]
        public SingleOperationRefType[] usesSingleOperation
        {
            get
            {
                return this.usesSingleOperationField;
            }
            set
            {
                this.usesSingleOperationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesSingleOperation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SingleOperationRefType
    {

        private AbstractCoordinateOperationType _SingleOperationField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractCoordinateOperationType _SingleOperation
        {
            get
            {
                return this._SingleOperationField;
            }
            set
            {
                this._SingleOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoVolumeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTopoPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTopologyType : AbstractGMLType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoComplex", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoComplexType : AbstractTopologyType
    {

        private TopoComplexMemberType maximalComplexField;

        private TopoComplexMemberType[] superComplexField;

        private TopoComplexMemberType[] subComplexField;

        private TopoPrimitiveMemberType[] topoPrimitiveMemberField;

        private TopoPrimitiveArrayAssociationType topoPrimitiveMembersField;

        private bool isMaximalField;

        public TopoComplexType()
        {
            this.isMaximalField = false;
        }

        /// <remarks/>
        public TopoComplexMemberType maximalComplex
        {
            get
            {
                return this.maximalComplexField;
            }
            set
            {
                this.maximalComplexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("superComplex")]
        public TopoComplexMemberType[] superComplex
        {
            get
            {
                return this.superComplexField;
            }
            set
            {
                this.superComplexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subComplex")]
        public TopoComplexMemberType[] subComplex
        {
            get
            {
                return this.subComplexField;
            }
            set
            {
                this.subComplexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("topoPrimitiveMember")]
        public TopoPrimitiveMemberType[] topoPrimitiveMember
        {
            get
            {
                return this.topoPrimitiveMemberField;
            }
            set
            {
                this.topoPrimitiveMemberField = value;
            }
        }

        /// <remarks/>
        public TopoPrimitiveArrayAssociationType topoPrimitiveMembers
        {
            get
            {
                return this.topoPrimitiveMembersField;
            }
            set
            {
                this.topoPrimitiveMembersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMaximal
        {
            get
            {
                return this.isMaximalField;
            }
            set
            {
                this.isMaximalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoComplexProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoComplexMemberType
    {

        private TopoComplexType topoComplexField;

        private string remoteSchemaField;

        /// <remarks/>
        public TopoComplexType TopoComplex
        {
            get
            {
                return this.topoComplexField;
            }
            set
            {
                this.topoComplexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMember", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoPrimitiveMemberType
    {

        private AbstractTopoPrimitiveType _TopoPrimitiveField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractTopoPrimitiveType _TopoPrimitive
        {
            get
            {
                return this._TopoPrimitiveField;
            }
            set
            {
                this._TopoPrimitiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTopoPrimitiveType : AbstractTopologyType
    {

        private IsolatedPropertyType[] isolatedField;

        private ContainerPropertyType containerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isolated")]
        public IsolatedPropertyType[] isolated
        {
            get
            {
                return this.isolatedField;
            }
            set
            {
                this.isolatedField = value;
            }
        }

        /// <remarks/>
        public ContainerPropertyType container
        {
            get
            {
                return this.containerField;
            }
            set
            {
                this.containerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("isolated", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class IsolatedPropertyType
    {

        private AbstractTopoPrimitiveType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Edge", typeof(EdgeType))]
        [System.Xml.Serialization.XmlElementAttribute("Node", typeof(NodeType))]
        public AbstractTopoPrimitiveType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Edge", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EdgeType : AbstractTopoPrimitiveType
    {

        private DirectedNodePropertyType[] directedNodeField;

        private DirectedFacePropertyType[] directedFaceField;

        private CurvePropertyType curvePropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedNode")]
        public DirectedNodePropertyType[] directedNode
        {
            get
            {
                return this.directedNodeField;
            }
            set
            {
                this.directedNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace
        {
            get
            {
                return this.directedFaceField;
            }
            set
            {
                this.directedFaceField = value;
            }
        }

        /// <remarks/>
        public CurvePropertyType curveProperty
        {
            get
            {
                return this.curvePropertyField;
            }
            set
            {
                this.curvePropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("directedNode", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedNodePropertyType
    {

        private NodeType nodeField;

        private SignType orientationField;

        private string remoteSchemaField;

        public DirectedNodePropertyType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public NodeType Node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Node", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class NodeType : AbstractTopoPrimitiveType
    {

        private DirectedEdgePropertyType[] directedEdgeField;

        private PointPropertyType pointPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge
        {
            get
            {
                return this.directedEdgeField;
            }
            set
            {
                this.directedEdgeField = value;
            }
        }

        /// <remarks/>
        public PointPropertyType pointProperty
        {
            get
            {
                return this.pointPropertyField;
            }
            set
            {
                this.pointPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("directedEdge", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedEdgePropertyType
    {

        private EdgeType edgeField;

        private SignType orientationField;

        private string remoteSchemaField;

        public DirectedEdgePropertyType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public EdgeType Edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("directedFace", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedFacePropertyType
    {

        private FaceType faceField;

        private SignType orientationField;

        private string remoteSchemaField;

        public DirectedFacePropertyType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public FaceType Face
        {
            get
            {
                return this.faceField;
            }
            set
            {
                this.faceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Face", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FaceType : AbstractTopoPrimitiveType
    {

        private DirectedEdgePropertyType[] directedEdgeField;

        private DirectedTopoSolidPropertyType[] directedTopoSolidField;

        private SurfacePropertyType surfacePropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge
        {
            get
            {
                return this.directedEdgeField;
            }
            set
            {
                this.directedEdgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid
        {
            get
            {
                return this.directedTopoSolidField;
            }
            set
            {
                this.directedTopoSolidField = value;
            }
        }

        /// <remarks/>
        public SurfacePropertyType surfaceProperty
        {
            get
            {
                return this.surfacePropertyField;
            }
            set
            {
                this.surfacePropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("directedTopoSolid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedTopoSolidPropertyType
    {

        private TopoSolidType topoSolidField;

        private SignType orientationField;

        private string remoteSchemaField;

        public DirectedTopoSolidPropertyType()
        {
            this.orientationField = SignType.Item1;
        }

        /// <remarks/>
        public TopoSolidType TopoSolid
        {
            get
            {
                return this.topoSolidField;
            }
            set
            {
                this.topoSolidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoSolid", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoSolidType : AbstractTopoPrimitiveType
    {

        private DirectedFacePropertyType[] directedFaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace
        {
            get
            {
                return this.directedFaceField;
            }
            set
            {
                this.directedFaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("container", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ContainerPropertyType
    {

        private AbstractTopoPrimitiveType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Face", typeof(FaceType))]
        [System.Xml.Serialization.XmlElementAttribute("TopoSolid", typeof(TopoSolidType))]
        public AbstractTopoPrimitiveType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMembers", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoPrimitiveArrayAssociationType
    {

        private AbstractTopoPrimitiveType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_TopoPrimitive")]
        public AbstractTopoPrimitiveType[] Items
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoVolume", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoVolumeType : AbstractTopologyType
    {

        private DirectedTopoSolidPropertyType[] directedTopoSolidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid
        {
            get
            {
                return this.directedTopoSolidField;
            }
            set
            {
                this.directedTopoSolidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoSurface", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoSurfaceType : AbstractTopologyType
    {

        private DirectedFacePropertyType[] directedFaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace
        {
            get
            {
                return this.directedFaceField;
            }
            set
            {
                this.directedFaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoCurve", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoCurveType : AbstractTopologyType
    {

        private DirectedEdgePropertyType[] directedEdgeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge
        {
            get
            {
                return this.directedEdgeField;
            }
            set
            {
                this.directedEdgeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoPoint", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoPointType : AbstractTopologyType
    {

        private DirectedNodePropertyType directedNodeField;

        /// <remarks/>
        public DirectedNodePropertyType directedNode
        {
            get
            {
                return this.directedNodeField;
            }
            set
            {
                this.directedNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeValue", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompositeValueType : AbstractGMLType
    {

        private ValuePropertyType[] valueComponentField;

        private ValueArrayPropertyType valueComponentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valueComponent")]
        public ValuePropertyType[] valueComponent
        {
            get
            {
                return this.valueComponentField;
            }
            set
            {
                this.valueComponentField = value;
            }
        }

        /// <remarks/>
        public ValueArrayPropertyType valueComponents
        {
            get
            {
                return this.valueComponentsField;
            }
            set
            {
                this.valueComponentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScalarValuePropertyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ValuePropertyType
    {

        private bool booleanField;

        private CodeType1 categoryField;

        private MeasureType quantityField;

        private string countField;

        private string booleanListField;

        private CodeOrNullListType categoryListField;

        private MeasureOrNullListType quantityListField;

        private string countListField;

        private CategoryExtentType categoryExtentField;

        private QuantityExtentType quantityExtentField;

        private string countExtentField;

        private CompositeValueType compositeValueField;

        private object _ObjectField;

        private string nullField;

        private string remoteSchemaField;

        /// <remarks/>
        public bool Boolean
        {
            get
            {
                return this.booleanField;
            }
            set
            {
                this.booleanField = value;
            }
        }

        /// <remarks/>
        public CodeType1 Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public MeasureType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Count
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
        public string BooleanList
        {
            get
            {
                return this.booleanListField;
            }
            set
            {
                this.booleanListField = value;
            }
        }

        /// <remarks/>
        public CodeOrNullListType CategoryList
        {
            get
            {
                return this.categoryListField;
            }
            set
            {
                this.categoryListField = value;
            }
        }

        /// <remarks/>
        public MeasureOrNullListType QuantityList
        {
            get
            {
                return this.quantityListField;
            }
            set
            {
                this.quantityListField = value;
            }
        }

        /// <remarks/>
        public string CountList
        {
            get
            {
                return this.countListField;
            }
            set
            {
                this.countListField = value;
            }
        }

        /// <remarks/>
        public CategoryExtentType CategoryExtent
        {
            get
            {
                return this.categoryExtentField;
            }
            set
            {
                this.categoryExtentField = value;
            }
        }

        /// <remarks/>
        public QuantityExtentType QuantityExtent
        {
            get
            {
                return this.quantityExtentField;
            }
            set
            {
                this.quantityExtentField = value;
            }
        }

        /// <remarks/>
        public string CountExtent
        {
            get
            {
                return this.countExtentField;
            }
            set
            {
                this.countExtentField = value;
            }
        }

        /// <remarks/>
        public CompositeValueType CompositeValue
        {
            get
            {
                return this.compositeValueField;
            }
            set
            {
                this.compositeValueField = value;
            }
        }

        /// <remarks/>
        public object _Object
        {
            get
            {
                return this._ObjectField;
            }
            set
            {
                this._ObjectField = value;
            }
        }

        /// <remarks/>
        public string Null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryExtentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CategoryList", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CodeOrNullListType
    {

        private string codeSpaceField;

        private string[] textField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CategoryExtent", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CategoryExtentType : CodeOrNullListType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityExtentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("QuantityList", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MeasureOrNullListType
    {

        private string uomField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("QuantityExtent", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class QuantityExtentType : MeasureOrNullListType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class CountPropertyType : ValuePropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class QuantityPropertyType : ValuePropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class CategoryPropertyType : ValuePropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class BooleanPropertyType : ValuePropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class ScalarValuePropertyType : ValuePropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueComponents", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ValueArrayPropertyType
    {

        private bool[] booleanField;

        private CodeType1[] categoryField;

        private MeasureType[] quantityField;

        private string[] countField;

        private string[] booleanListField;

        private CodeOrNullListType[] categoryListField;

        private MeasureOrNullListType[] quantityListField;

        private string[] countListField;

        private CategoryExtentType[] categoryExtentField;

        private QuantityExtentType[] quantityExtentField;

        private string[] countExtentField;

        private CompositeValueType[] compositeValueField;

        private object[] _ObjectField;

        private string[] nullField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Boolean")]
        public bool[] Boolean
        {
            get
            {
                return this.booleanField;
            }
            set
            {
                this.booleanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public CodeType1[] Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public MeasureType[] Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Count", DataType = "integer")]
        public string[] Count
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
        [System.Xml.Serialization.XmlElementAttribute("BooleanList")]
        public string[] BooleanList
        {
            get
            {
                return this.booleanListField;
            }
            set
            {
                this.booleanListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CategoryList")]
        public CodeOrNullListType[] CategoryList
        {
            get
            {
                return this.categoryListField;
            }
            set
            {
                this.categoryListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuantityList")]
        public MeasureOrNullListType[] QuantityList
        {
            get
            {
                return this.quantityListField;
            }
            set
            {
                this.quantityListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountList")]
        public string[] CountList
        {
            get
            {
                return this.countListField;
            }
            set
            {
                this.countListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CategoryExtent")]
        public CategoryExtentType[] CategoryExtent
        {
            get
            {
                return this.categoryExtentField;
            }
            set
            {
                this.categoryExtentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuantityExtent")]
        public QuantityExtentType[] QuantityExtent
        {
            get
            {
                return this.quantityExtentField;
            }
            set
            {
                this.quantityExtentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountExtent")]
        public string[] CountExtent
        {
            get
            {
                return this.countExtentField;
            }
            set
            {
                this.countExtentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompositeValue")]
        public CompositeValueType[] CompositeValue
        {
            get
            {
                return this.compositeValueField;
            }
            set
            {
                this.compositeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Object")]
        public object[] _Object
        {
            get
            {
                return this._ObjectField;
            }
            set
            {
                this._ObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Null")]
        public string[] Null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ValueArray", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ValueArrayType : CompositeValueType
    {

        private string codeSpaceField;

        private string uomField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MovingObjectStatusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeSliceType : AbstractGMLType
    {

        private TimePrimitivePropertyType validTimeField;

        private StringOrRefType dataSourceField;

        /// <remarks/>
        public TimePrimitivePropertyType validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType dataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MovingObjectStatus", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MovingObjectStatusType : AbstractTimeSliceType
    {

        private LocationPropertyType locationField;

        private MeasureType speedField;

        private DirectionPropertyType bearingField;

        private MeasureType accelerationField;

        private MeasureType elevationField;

        private StringOrRefType statusField;

        /// <remarks/>
        public LocationPropertyType location
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
        public MeasureType speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        public DirectionPropertyType bearing
        {
            get
            {
                return this.bearingField;
            }
            set
            {
                this.bearingField = value;
            }
        }

        /// <remarks/>
        public MeasureType acceleration
        {
            get
            {
                return this.accelerationField;
            }
            set
            {
                this.accelerationField = value;
            }
        }

        /// <remarks/>
        public MeasureType elevation
        {
            get
            {
                return this.elevationField;
            }
            set
            {
                this.elevationField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType status
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PriorityLocationPropertyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("location", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LocationPropertyType
    {

        private object itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationKeyWord", typeof(CodeType1))]
        [System.Xml.Serialization.XmlElementAttribute("LocationString", typeof(StringOrRefType))]
        [System.Xml.Serialization.XmlElementAttribute("Null", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("priorityLocation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PriorityLocationPropertyType : LocationPropertyType
    {

        private string priorityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("direction", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectionPropertyType
    {

        private object itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompassPoint", typeof(CompassPointEnumeration))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionKeyword", typeof(CodeType1))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionString", typeof(StringOrRefType))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionVector", typeof(DirectionVectorType))]
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompassPoint", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public enum CompassPointEnumeration
    {

        /// <remarks/>
        N,

        /// <remarks/>
        NNE,

        /// <remarks/>
        NE,

        /// <remarks/>
        ENE,

        /// <remarks/>
        E,

        /// <remarks/>
        ESE,

        /// <remarks/>
        SE,

        /// <remarks/>
        SSE,

        /// <remarks/>
        S,

        /// <remarks/>
        SSW,

        /// <remarks/>
        SW,

        /// <remarks/>
        WSW,

        /// <remarks/>
        W,

        /// <remarks/>
        WNW,

        /// <remarks/>
        NW,

        /// <remarks/>
        NNW,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectionVector", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectionVectorType
    {

        private object[] itemsField;

        private ItemsChoiceType8[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("horizontalAngle", typeof(AngleType))]
        [System.Xml.Serialization.XmlElementAttribute("vector", typeof(VectorType))]
        [System.Xml.Serialization.XmlElementAttribute("verticalAngle", typeof(AngleType))]
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
        public ItemsChoiceType8[] ItemsElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType8
    {

        /// <remarks/>
        horizontalAngle,

        /// <remarks/>
        vector,

        /// <remarks/>
        verticalAngle,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundedFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractFeatureType : AbstractGMLType
    {

        private BoundingShapeType boundedByField;

        private LocationPropertyType locationField;

        /// <remarks/>
        public BoundingShapeType boundedBy
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
        public LocationPropertyType location
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("boundedBy", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class BoundingShapeType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType))]
        [System.Xml.Serialization.XmlElementAttribute("Null", typeof(string))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Observation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ObservationType : AbstractFeatureType
    {

        private TimePrimitivePropertyType validTimeField;

        private FeaturePropertyType usingField;

        private TargetPropertyType targetField;

        private AssociationType resultOfField;

        /// <remarks/>
        public TimePrimitivePropertyType validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        /// <remarks/>
        public FeaturePropertyType @using
        {
            get
            {
                return this.usingField;
            }
            set
            {
                this.usingField = value;
            }
        }

        /// <remarks/>
        public TargetPropertyType target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        public AssociationType resultOf
        {
            get
            {
                return this.resultOfField;
            }
            set
            {
                this.resultOfField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("featureMember", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FeaturePropertyType
    {

        private AbstractFeatureType _FeatureField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractFeatureType _Feature
        {
            get
            {
                return this._FeatureField;
            }
            set
            {
                this._FeatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("target", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TargetPropertyType
    {

        private AbstractGMLType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Feature", typeof(AbstractFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
        public AbstractGMLType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("member", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class AssociationType
    {

        private object _ObjectField;

        private string remoteSchemaField;

        /// <remarks/>
        public object _Object
        {
            get
            {
                return this._ObjectField;
            }
            set
            {
                this._ObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservation", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedObservationType : ObservationType
    {

        private DirectionPropertyType directionField;

        /// <remarks/>
        public DirectionPropertyType direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservationAtDistance", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DirectedObservationAtDistanceType : DirectedObservationType
    {

        private MeasureType distanceField;

        /// <remarks/>
        public MeasureType distance
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContinuousCoverageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractCoverageType : AbstractFeatureType
    {

        private DomainSetType domainSetField;

        private RangeSetType rangeSetField;

        private string dimensionField;

        /// <remarks/>
        public DomainSetType domainSet
        {
            get
            {
                return this.domainSetField;
            }
            set
            {
                this.domainSetField = value;
            }
        }

        /// <remarks/>
        public RangeSetType rangeSet
        {
            get
            {
                return this.rangeSetField;
            }
            set
            {
                this.rangeSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string dimension
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointDomainType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("domainSet", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DomainSetType
    {

        private AbstractGMLType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
        [System.Xml.Serialization.XmlElementAttribute("_TimeObject", typeof(AbstractTimeObjectType))]
        public AbstractGMLType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("rectifiedGridDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RectifiedGridDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("gridDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GridDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiSolidDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSolidDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiSurfaceDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSurfaceDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiCurveDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiCurveDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiPointDomain", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiPointDomainType : DomainSetType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("rangeSet", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RangeSetType
    {

        private object[] itemsField;

        private ItemsChoiceType9[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BooleanList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CategoryList", typeof(CodeOrNullListType))]
        [System.Xml.Serialization.XmlElementAttribute("CountList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DataBlock", typeof(DataBlockType))]
        [System.Xml.Serialization.XmlElementAttribute("File", typeof(FileType))]
        [System.Xml.Serialization.XmlElementAttribute("QuantityList", typeof(MeasureOrNullListType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueArray", typeof(ValueArrayType))]
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
        public ItemsChoiceType9[] ItemsElementName
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DataBlock", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DataBlockType
    {

        private RangeParametersType rangeParametersField;

        private object itemField;

        /// <remarks/>
        public RangeParametersType rangeParameters
        {
            get
            {
                return this.rangeParametersField;
            }
            set
            {
                this.rangeParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("doubleOrNullTupleList", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("tupleList", typeof(CoordinatesType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("rangeParameters", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RangeParametersType
    {

        private bool booleanField;

        private CodeType1 categoryField;

        private MeasureType quantityField;

        private string countField;

        private string booleanListField;

        private CodeOrNullListType categoryListField;

        private MeasureOrNullListType quantityListField;

        private string countListField;

        private CategoryExtentType categoryExtentField;

        private QuantityExtentType quantityExtentField;

        private string countExtentField;

        private CompositeValueType compositeValueField;

        private string remoteSchemaField;

        /// <remarks/>
        public bool Boolean
        {
            get
            {
                return this.booleanField;
            }
            set
            {
                this.booleanField = value;
            }
        }

        /// <remarks/>
        public CodeType1 Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public MeasureType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Count
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
        public string BooleanList
        {
            get
            {
                return this.booleanListField;
            }
            set
            {
                this.booleanListField = value;
            }
        }

        /// <remarks/>
        public CodeOrNullListType CategoryList
        {
            get
            {
                return this.categoryListField;
            }
            set
            {
                this.categoryListField = value;
            }
        }

        /// <remarks/>
        public MeasureOrNullListType QuantityList
        {
            get
            {
                return this.quantityListField;
            }
            set
            {
                this.quantityListField = value;
            }
        }

        /// <remarks/>
        public string CountList
        {
            get
            {
                return this.countListField;
            }
            set
            {
                this.countListField = value;
            }
        }

        /// <remarks/>
        public CategoryExtentType CategoryExtent
        {
            get
            {
                return this.categoryExtentField;
            }
            set
            {
                this.categoryExtentField = value;
            }
        }

        /// <remarks/>
        public QuantityExtentType QuantityExtent
        {
            get
            {
                return this.quantityExtentField;
            }
            set
            {
                this.quantityExtentField = value;
            }
        }

        /// <remarks/>
        public string CountExtent
        {
            get
            {
                return this.countExtentField;
            }
            set
            {
                this.countExtentField = value;
            }
        }

        /// <remarks/>
        public CompositeValueType CompositeValue
        {
            get
            {
                return this.compositeValueField;
            }
            set
            {
                this.compositeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("File", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FileType
    {

        private RangeParametersType rangeParametersField;

        private string fileNameField;

        private FileValueModelType fileStructureField;

        private string mimeTypeField;

        private string compressionField;

        /// <remarks/>
        public RangeParametersType rangeParameters
        {
            get
            {
                return this.rangeParametersField;
            }
            set
            {
                this.rangeParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public FileValueModelType fileStructure
        {
            get
            {
                return this.fileStructureField;
            }
            set
            {
                this.fileStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string mimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string compression
        {
            get
            {
                return this.compressionField;
            }
            set
            {
                this.compressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum FileValueModelType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Record Interleaved")]
        RecordInterleaved,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
    public enum ItemsChoiceType9
    {

        /// <remarks/>
        BooleanList,

        /// <remarks/>
        CategoryList,

        /// <remarks/>
        CountList,

        /// <remarks/>
        DataBlock,

        /// <remarks/>
        File,

        /// <remarks/>
        QuantityList,

        /// <remarks/>
        ValueArray,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractDiscreteCoverageType : AbstractCoverageType
    {

        private CoverageFunctionType coverageFunctionField;

        /// <remarks/>
        public CoverageFunctionType coverageFunction
        {
            get
            {
                return this.coverageFunctionField;
            }
            set
            {
                this.coverageFunctionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coverageFunction", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoverageFunctionType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GridFunction", typeof(GridFunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("MappingRule", typeof(StringOrRefType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndexMapType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GridFunction", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GridFunctionType
    {

        private SequenceRuleType sequenceRuleField;

        private string startPointField;

        /// <remarks/>
        public SequenceRuleType sequenceRule
        {
            get
            {
                return this.sequenceRuleField;
            }
            set
            {
                this.sequenceRuleField = value;
            }
        }

        /// <remarks/>
        public string startPoint
        {
            get
            {
                return this.startPointField;
            }
            set
            {
                this.startPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class SequenceRuleType
    {

        private IncrementOrder orderField;

        private bool orderFieldSpecified;

        private SequenceRuleNames valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IncrementOrder order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderSpecified
        {
            get
            {
                return this.orderFieldSpecified;
            }
            set
            {
                this.orderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public SequenceRuleNames Value
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum IncrementOrder
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+x+y")]
        xy,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+y+x")]
        yx,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("+x-y")]
        xy1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("-x-y")]
        xy2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public enum SequenceRuleNames
    {

        /// <remarks/>
        Linear,

        /// <remarks/>
        Boustrophedonic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cantor-diagonal")]
        Cantordiagonal,

        /// <remarks/>
        Spiral,

        /// <remarks/>
        Morton,

        /// <remarks/>
        Hilbert,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("IndexMap", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class IndexMapType : GridFunctionType
    {

        private string lookUpTableField;

        /// <remarks/>
        public string lookUpTable
        {
            get
            {
                return this.lookUpTableField;
            }
            set
            {
                this.lookUpTableField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("RectifiedGridCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class RectifiedGridCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GridCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GridCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSolidCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSolidCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSurfaceCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSurfaceCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiCurveCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiCurveCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPointCoverage", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiPointCoverageType : AbstractDiscreteCoverageType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractContinuousCoverageType : AbstractCoverageType
    {

        private CoverageFunctionType coverageFunctionField;

        /// <remarks/>
        public CoverageFunctionType coverageFunction
        {
            get
            {
                return this.coverageFunctionField;
            }
            set
            {
                this.coverageFunctionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class DynamicFeatureType : AbstractFeatureType
    {

        private TimePrimitivePropertyType validTimeField;

        private HistoryPropertyType historyField;

        private StringOrRefType dataSourceField;

        /// <remarks/>
        public TimePrimitivePropertyType validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        /// <remarks/>
        public HistoryPropertyType history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType dataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("history", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class HistoryPropertyType
    {

        private AbstractTimeSliceType[] _TimeSliceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_TimeSlice")]
        public AbstractTimeSliceType[] _TimeSlice
        {
            get
            {
                return this._TimeSliceField;
            }
            set
            {
                this._TimeSliceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("track", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TrackType : HistoryPropertyType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class BoundedFeatureType : AbstractFeatureType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractFeatureCollectionType : AbstractFeatureType
    {

        private FeaturePropertyType[] featureMemberField;

        private AbstractFeatureType[] featureMembersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureMember")]
        public FeaturePropertyType[] featureMember
        {
            get
            {
                return this.featureMemberField;
            }
            set
            {
                this.featureMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Feature", IsNullable = false)]
        public AbstractFeatureType[] featureMembers
        {
            get
            {
                return this.featureMembersField;
            }
            set
            {
                this.featureMembersField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicFeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeatureCollectionType", Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureCollection", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FeatureCollectionType1 : AbstractFeatureCollectionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class DynamicFeatureCollectionType : FeatureCollectionType1
    {

        private TimePrimitivePropertyType validTimeField;

        private HistoryPropertyType historyField;

        private StringOrRefType dataSourceField;

        /// <remarks/>
        public TimePrimitivePropertyType validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        /// <remarks/>
        public HistoryPropertyType history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }

        /// <remarks/>
        public StringOrRefType dataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Array", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArrayType : AbstractGMLType
    {

        private object[] membersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Object", IsNullable = false)]
        public object[] members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Bag", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class BagType : AbstractGMLType
    {

        private AssociationType[] memberField;

        private object[] membersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public AssociationType[] member
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
        [System.Xml.Serialization.XmlArrayItemAttribute("_Object", IsNullable = false)]
        public object[] members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeTopologyComplexType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeComplexType : AbstractTimeObjectType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeTopologyComplex", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimeTopologyComplexType : AbstractTimeComplexType
    {

        private TimeTopologyPrimitivePropertyType[] primitiveField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primitive")]
        public TimeTopologyPrimitivePropertyType[] primitive
        {
            get
            {
                return this.primitiveField;
            }
            set
            {
                this.primitiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeTopologyPrimitivePropertyType
    {

        private AbstractTimeTopologyPrimitiveType _TimeTopologyPrimitiveField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractTimeTopologyPrimitiveType _TimeTopologyPrimitive
        {
            get
            {
                return this._TimeTopologyPrimitiveField;
            }
            set
            {
                this._TimeTopologyPrimitiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeTopologyComplexPropertyType
    {

        private TimeTopologyComplexType timeTopologyComplexField;

        private string remoteSchemaField;

        /// <remarks/>
        public TimeTopologyComplexType TimeTopologyComplex
        {
            get
            {
                return this.timeTopologyComplexField;
            }
            set
            {
                this.timeTopologyComplexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("defaultStyle", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DefaultStylePropertyType
    {

        private AbstractStyleType _StyleField;

        private string aboutField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractStyleType _Style
        {
            get
            {
                return this._StyleField;
            }
            set
            {
                this._StyleField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("temporalCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TemporalCRSRefType
    {

        private TemporalCRSType temporalCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public TemporalCRSType TemporalCRS
        {
            get
            {
                return this.temporalCRSField;
            }
            set
            {
                this.temporalCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("imageCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ImageCRSRefType
    {

        private ImageCRSType imageCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public ImageCRSType ImageCRS
        {
            get
            {
                return this.imageCRSField;
            }
            set
            {
                this.imageCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("engineeringCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class EngineeringCRSRefType
    {

        private EngineeringCRSType engineeringCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public EngineeringCRSType EngineeringCRS
        {
            get
            {
                return this.engineeringCRSField;
            }
            set
            {
                this.engineeringCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("derivedCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DerivedCRSRefType
    {

        private DerivedCRSType derivedCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public DerivedCRSType DerivedCRS
        {
            get
            {
                return this.derivedCRSField;
            }
            set
            {
                this.derivedCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("projectedCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ProjectedCRSRefType
    {

        private ProjectedCRSType projectedCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public ProjectedCRSType ProjectedCRS
        {
            get
            {
                return this.projectedCRSField;
            }
            set
            {
                this.projectedCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geocentricCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeocentricCRSRefType
    {

        private GeocentricCRSType geocentricCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public GeocentricCRSType GeocentricCRS
        {
            get
            {
                return this.geocentricCRSField;
            }
            set
            {
                this.geocentricCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("verticalCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class VerticalCRSRefType
    {

        private VerticalCRSType verticalCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public VerticalCRSType VerticalCRS
        {
            get
            {
                return this.verticalCRSField;
            }
            set
            {
                this.verticalCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geographicCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeographicCRSRefType
    {

        private GeographicCRSType geographicCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public GeographicCRSType GeographicCRS
        {
            get
            {
                return this.geographicCRSField;
            }
            set
            {
                this.geographicCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("compoundCRSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CompoundCRSRefType
    {

        private CompoundCRSType compoundCRSField;

        private string remoteSchemaField;

        /// <remarks/>
        public CompoundCRSType CompoundCRS
        {
            get
            {
                return this.compoundCRSField;
            }
            set
            {
                this.compoundCRSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("transformationRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TransformationRefType
    {

        private TransformationType transformationField;

        private string remoteSchemaField;

        /// <remarks/>
        public TransformationType Transformation
        {
            get
            {
                return this.transformationField;
            }
            set
            {
                this.transformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("generalTransformationRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeneralTransformationRefType
    {

        private AbstractGeneralTransformationType _GeneralTransformationField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractGeneralTransformationType _GeneralTransformation
        {
            get
            {
                return this._GeneralTransformationField;
            }
            set
            {
                this._GeneralTransformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("conversionRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConversionRefType
    {

        private ConversionType conversionField;

        private string remoteSchemaField;

        /// <remarks/>
        public ConversionType Conversion
        {
            get
            {
                return this.conversionField;
            }
            set
            {
                this.conversionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("passThroughOperationRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PassThroughOperationRefType
    {

        private PassThroughOperationType passThroughOperationField;

        private string remoteSchemaField;

        /// <remarks/>
        public PassThroughOperationType PassThroughOperation
        {
            get
            {
                return this.passThroughOperationField;
            }
            set
            {
                this.passThroughOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("concatenatedOperationRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ConcatenatedOperationRefType
    {

        private ConcatenatedOperationType concatenatedOperationField;

        private string remoteSchemaField;

        /// <remarks/>
        public ConcatenatedOperationType ConcatenatedOperation
        {
            get
            {
                return this.concatenatedOperationField;
            }
            set
            {
                this.concatenatedOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateOperationRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CoordinateOperationRefType
    {

        private AbstractCoordinateOperationType _CoordinateOperationField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractCoordinateOperationType _CoordinateOperation
        {
            get
            {
                return this._CoordinateOperationField;
            }
            set
            {
                this._CoordinateOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("datumRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class DatumRefType
    {

        private AbstractDatumType _DatumField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractDatumType _Datum
        {
            get
            {
                return this._DatumField;
            }
            set
            {
                this._DatumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("cylindricalCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CylindricalCSRefType
    {

        private CylindricalCSType cylindricalCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public CylindricalCSType CylindricalCS
        {
            get
            {
                return this.cylindricalCSField;
            }
            set
            {
                this.cylindricalCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("polarCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PolarCSRefType
    {

        private PolarCSType polarCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public PolarCSType PolarCS
        {
            get
            {
                return this.polarCSField;
            }
            set
            {
                this.polarCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("userDefinedCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class UserDefinedCSRefType
    {

        private UserDefinedCSType userDefinedCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public UserDefinedCSType UserDefinedCS
        {
            get
            {
                return this.userDefinedCSField;
            }
            set
            {
                this.userDefinedCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("linearCSRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class LinearCSRefType
    {

        private LinearCSType linearCSField;

        private string remoteSchemaField;

        /// <remarks/>
        public LinearCSType LinearCS
        {
            get
            {
                return this.linearCSField;
            }
            set
            {
                this.linearCSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("referenceSystemRef", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ReferenceSystemRefType
    {

        private AbstractReferenceSystemType _ReferenceSystemField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractReferenceSystemType _ReferenceSystem
        {
            get
            {
                return this._ReferenceSystemField;
            }
            set
            {
                this._ReferenceSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoVolumeProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoVolumePropertyType
    {

        private TopoVolumeType topoVolumeField;

        /// <remarks/>
        public TopoVolumeType TopoVolume
        {
            get
            {
                return this.topoVolumeField;
            }
            set
            {
                this.topoVolumeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoSurfaceProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoSurfacePropertyType
    {

        private TopoSurfaceType topoSurfaceField;

        /// <remarks/>
        public TopoSurfaceType TopoSurface
        {
            get
            {
                return this.topoSurfaceField;
            }
            set
            {
                this.topoSurfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoCurveProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoCurvePropertyType
    {

        private TopoCurveType topoCurveField;

        /// <remarks/>
        public TopoCurveType TopoCurve
        {
            get
            {
                return this.topoCurveField;
            }
            set
            {
                this.topoCurveField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPointProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TopoPointPropertyType
    {

        private TopoPointType topoPointField;

        /// <remarks/>
        public TopoPointType TopoPoint
        {
            get
            {
                return this.topoPointField;
            }
            set
            {
                this.topoPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class GeometricComplexPropertyType
    {

        private AbstractGeometryType itemField;

        private string remoteSchemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompositeCurve", typeof(CompositeCurveType))]
        [System.Xml.Serialization.XmlElementAttribute("CompositeSolid", typeof(CompositeSolidType))]
        [System.Xml.Serialization.XmlElementAttribute("CompositeSurface", typeof(CompositeSurfaceType))]
        [System.Xml.Serialization.XmlElementAttribute("GeometricComplex", typeof(GeometricComplexType))]
        public AbstractGeometryType Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class CompositeSolidPropertyType
    {

        private CompositeSolidType compositeSolidField;

        private string remoteSchemaField;

        /// <remarks/>
        public CompositeSolidType CompositeSolid
        {
            get
            {
                return this.compositeSolidField;
            }
            set
            {
                this.compositeSolidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class CompositeSurfacePropertyType
    {

        private CompositeSurfaceType compositeSurfaceField;

        private string remoteSchemaField;

        /// <remarks/>
        public CompositeSurfaceType CompositeSurface
        {
            get
            {
                return this.compositeSurfaceField;
            }
            set
            {
                this.compositeSurfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class CompositeCurvePropertyType
    {

        private CompositeCurveType compositeCurveField;

        private string remoteSchemaField;

        /// <remarks/>
        public CompositeCurveType CompositeCurve
        {
            get
            {
                return this.compositeCurveField;
            }
            set
            {
                this.compositeCurveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class MultiPolygonPropertyType
    {

        private MultiPolygonType multiPolygonField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiPolygonType MultiPolygon
        {
            get
            {
                return this.multiPolygonField;
            }
            set
            {
                this.multiPolygonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class MultiLineStringPropertyType
    {

        private MultiLineStringType multiLineStringField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiLineStringType MultiLineString
        {
            get
            {
                return this.multiLineStringField;
            }
            set
            {
                this.multiLineStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiSolidProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSolidPropertyType
    {

        private MultiSolidType multiSolidField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiSolidType MultiSolid
        {
            get
            {
                return this.multiSolidField;
            }
            set
            {
                this.multiSolidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiSurfaceProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiSurfacePropertyType
    {

        private MultiSurfaceType multiSurfaceField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiSurfaceType MultiSurface
        {
            get
            {
                return this.multiSurfaceField;
            }
            set
            {
                this.multiSurfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiCurveProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiCurvePropertyType
    {

        private MultiCurveType multiCurveField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiCurveType MultiCurve
        {
            get
            {
                return this.multiCurveField;
            }
            set
            {
                this.multiCurveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiPointProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiPointPropertyType
    {

        private MultiPointType multiPointField;

        private string remoteSchemaField;

        /// <remarks/>
        public MultiPointType MultiPoint
        {
            get
            {
                return this.multiPointField;
            }
            set
            {
                this.multiPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiGeometryProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class MultiGeometryPropertyType
    {

        private AbstractGeometricAggregateType _GeometricAggregateField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractGeometricAggregateType _GeometricAggregate
        {
            get
            {
                return this._GeometricAggregateField;
            }
            set
            {
                this._GeometricAggregateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class RingPropertyType
    {

        private RingType ringField;

        /// <remarks/>
        public RingType Ring
        {
            get
            {
                return this.ringField;
            }
            set
            {
                this.ringField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class TimeGeometricPrimitivePropertyType
    {

        private AbstractTimeGeometricPrimitiveType _TimeGeometricPrimitiveField;

        private string remoteSchemaField;

        /// <remarks/>
        public AbstractTimeGeometricPrimitiveType _TimeGeometricPrimitive
        {
            get
            {
                return this._TimeGeometricPrimitiveField;
            }
            set
            {
                this._TimeGeometricPrimitiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericMetaDataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public abstract partial class AbstractMetaDataType
    {

        private string idField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "ID")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GenericMetaData", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GenericMetaDataType : AbstractMetaDataType
    {

        private System.Xml.XmlElement[] anyField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    public partial class LinearRingPropertyType
    {

        private LinearRingType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinearRing")]
        public LinearRingType Item
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class FunctionNameType
    {

        private string nArgsField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nArgs
        {
            get
            {
                return this.nArgsField;
            }
            set
            {
                this.nArgsField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class FunctionNamesType
    {

        private FunctionNameType[] functionNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionName")]
        public FunctionNameType[] FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class FunctionsType
    {

        private FunctionNamesType functionNamesField;

        /// <remarks/>
        public FunctionNamesType FunctionNames
        {
            get
            {
                return this.functionNamesField;
            }
            set
            {
                this.functionNamesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public enum ComparisonOperatorType
    {

        /// <remarks/>
        LessThan,

        /// <remarks/>
        GreaterThan,

        /// <remarks/>
        LessThanEqualTo,

        /// <remarks/>
        GreaterThanEqualTo,

        /// <remarks/>
        EqualTo,

        /// <remarks/>
        NotEqualTo,

        /// <remarks/>
        Like,

        /// <remarks/>
        Between,

        /// <remarks/>
        NullCheck,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class Scalar_CapabilitiesType
    {

        private LogicalOperators logicalOperatorsField;

        private ComparisonOperatorsType comparisonOperatorsField;

        private object[] arithmeticOperatorsField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Functions", typeof(FunctionsType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SimpleArithmetic", typeof(SimpleArithmetic), IsNullable = false)]
        public object[] ArithmeticOperators
        {
            get
            {
                return this.arithmeticOperatorsField;
            }
            set
            {
                this.arithmeticOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class LogicalOperators
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class SimpleArithmetic
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class SpatialOperatorType
    {

        private System.Xml.XmlQualifiedName[] geometryOperandsField;

        private SpatialOperatorNameType nameField;

        private bool nameFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public System.Xml.XmlQualifiedName[] GeometryOperands
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
        public SpatialOperatorNameType name
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nameSpecified
        {
            get
            {
                return this.nameFieldSpecified;
            }
            set
            {
                this.nameFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public enum SpatialOperatorNameType
    {

        /// <remarks/>
        BBOX,

        /// <remarks/>
        Equals,

        /// <remarks/>
        Disjoint,

        /// <remarks/>
        Intersects,

        /// <remarks/>
        Touches,

        /// <remarks/>
        Crosses,

        /// <remarks/>
        Within,

        /// <remarks/>
        Contains,

        /// <remarks/>
        Overlaps,

        /// <remarks/>
        Beyond,

        /// <remarks/>
        DWithin,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class Spatial_CapabilitiesType
    {

        private System.Xml.XmlQualifiedName[] geometryOperandsField;

        private SpatialOperatorType[] spatialOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public System.Xml.XmlQualifiedName[] GeometryOperands
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class InsertedFeatureType
    {

        private FeatureIdType[] featureIdField;

        private string handleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureId", Namespace = "http://www.opengis.net/ogc")]
        public FeatureIdType[] FeatureId
        {
            get
            {
                return this.featureIdField;
            }
            set
            {
                this.featureIdField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureId", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class FeatureIdType : AbstractIdType
    {

        private string fidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string fid
        {
            get
            {
                return this.fidField;
            }
            set
            {
                this.fidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GmlObjectIdType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureIdType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract partial class AbstractIdType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("GmlObjectId", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class GmlObjectIdType : AbstractIdType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class ActionType
    {

        private string messageField;

        private string locatorField;

        private string codeField;

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class TransactionSummaryType
    {

        private string totalInsertedField;

        private string totalUpdatedField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class FeaturesNotLockedType
    {

        private FeatureIdType[] featureIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureId", Namespace = "http://www.opengis.net/ogc")]
        public FeatureIdType[] FeatureId
        {
            get
            {
                return this.featureIdField;
            }
            set
            {
                this.featureIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class FeaturesLockedType
    {

        private FeatureIdType[] featureIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureId", Namespace = "http://www.opengis.net/ogc")]
        public FeatureIdType[] FeatureId
        {
            get
            {
                return this.featureIdField;
            }
            set
            {
                this.featureIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class GMLObjectTypeType
    {

        private System.Xml.XmlQualifiedName nameField;

        private string titleField;

        private string abstractField;

        private KeywordsType[] keywordsField;

        private OutputFormatListType outputFormatsField;

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
        [System.Xml.Serialization.XmlElementAttribute("Keywords", Namespace = "http://www.opengis.net/ows")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
    public partial class KeywordsType
    {

        private string[] keywordField;

        private CodeType typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public string[] Keyword
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class MetadataURLType
    {

        private MetadataURLTypeType typeField;

        private MetadataURLTypeFormat formatField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MetadataURLTypeType type
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
        public MetadataURLTypeFormat format
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs")]
    public enum MetadataURLTypeType
    {

        /// <remarks/>
        TC211,

        /// <remarks/>
        FGDC,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19115")]
        Item19115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19139")]
        Item19139,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs")]
    public enum MetadataURLTypeFormat
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/xml")]
        textxml,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/html")]
        texthtml,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/sgml")]
        textsgml,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/plain")]
        textplain,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class FeatureTypeType
    {

        private System.Xml.XmlQualifiedName nameField;

        private string titleField;

        private string abstractField;

        private KeywordsType[] keywordsField;

        private object[] itemsField;

        private ItemsChoiceType11[] itemsElementNameField;

        private OperationType[] operationsField;

        private OutputFormatListType outputFormatsField;

        private WGS84BoundingBoxType[] wGS84BoundingBoxField;

        private MetadataURLType[] metadataURLField;

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
        [System.Xml.Serialization.XmlElementAttribute("Keywords", Namespace = "http://www.opengis.net/ows")]
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
        [System.Xml.Serialization.XmlElementAttribute("DefaultSRS", typeof(string), DataType = "anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("NoSRS", typeof(FeatureTypeTypeNoSRS))]
        [System.Xml.Serialization.XmlElementAttribute("OtherSRS", typeof(string), DataType = "anyURI")]
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
        public ItemsChoiceType11[] ItemsElementName
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Operation", IsNullable = false)]
        public OperationType[] Operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox", Namespace = "http://www.opengis.net/ows")]
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wfs")]
    public partial class FeatureTypeTypeNoSRS
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs", IncludeInSchema = false)]
    public enum ItemsChoiceType11
    {

        /// <remarks/>
        DefaultSRS,

        /// <remarks/>
        NoSRS,

        /// <remarks/>
        OtherSRS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public enum OperationType
    {

        /// <remarks/>
        Insert,

        /// <remarks/>
        Update,

        /// <remarks/>
        Delete,

        /// <remarks/>
        Query,

        /// <remarks/>
        Lock,

        /// <remarks/>
        GetGmlObject,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("WGS84BoundingBox", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
    public partial class WGS84BoundingBoxType : BoundingBoxType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WGS84BoundingBoxType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("BoundingBox", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public partial class LockType
    {

        private FilterType filterField;

        private string handleField;

        private System.Xml.XmlQualifiedName typeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Filter", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class FilterType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Id", typeof(AbstractIdType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsBetweenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsNullType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsLikeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryComparisonOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract partial class ComparisonOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class PropertyIsBetweenType : ComparisonOpsType
    {

        private ExpressionType expressionField;

        private LowerBoundaryType lowerBoundaryField;

        private UpperBoundaryType upperBoundaryField;

        /// <remarks/>
        public ExpressionType expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LiteralType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryOperatorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract partial class ExpressionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyName", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class PropertyNameType : ExpressionType
    {

        private string[] textField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Literal", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class LiteralType : ExpressionType
    {

        private System.Xml.XmlNode[] anyField;

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class FunctionType : ExpressionType
    {

        private ExpressionType[] expressionField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType[] expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Add", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class BinaryOperatorType : ExpressionType
    {

        private ExpressionType[] expressionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType[] expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class LowerBoundaryType
    {

        private ExpressionType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType Item
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class UpperBoundaryType
    {

        private ExpressionType expressionField;

        /// <remarks/>
        public ExpressionType expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNull", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class PropertyIsNullType : ComparisonOpsType
    {

        private PropertyNameType propertyNameField;

        /// <remarks/>
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class PropertyIsLikeType : ComparisonOpsType
    {

        private PropertyNameType propertyNameField;

        private LiteralType literalField;

        private string wildCardField;

        private string singleCharField;

        private string escapeCharField;

        private bool matchCaseField;

        public PropertyIsLikeType()
        {
            this.matchCaseField = true;
        }

        /// <remarks/>
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        /// <remarks/>
        public LiteralType Literal
        {
            get
            {
                return this.literalField;
            }
            set
            {
                this.literalField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsEqualTo", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class BinaryComparisonOpType : ComparisonOpsType
    {

        private ExpressionType[] expressionField;

        private bool matchCaseField;

        public BinaryComparisonOpType()
        {
            this.matchCaseField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType[] expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnaryLogicOpType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryLogicOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract partial class LogicOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Not", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class UnaryLogicOpType : LogicOpsType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBufferType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BBOXType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySpatialOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract partial class SpatialOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class DistanceBufferType : SpatialOpsType
    {

        private PropertyNameType propertyNameField;

        private AbstractGeometryType _GeometryField;

        private DistanceType distanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml", Order = 1)]
        public AbstractGeometryType _Geometry
        {
            get
            {
                return this._GeometryField;
            }
            set
            {
                this._GeometryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DistanceType Distance
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class DistanceType
    {

        private string unitsField;

        private double valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("BBOX", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class BBOXType : SpatialOpsType
    {

        private PropertyNameType propertyNameField;

        private EnvelopeType envelopeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml", Order = 1)]
        public EnvelopeType Envelope
        {
            get
            {
                return this.envelopeField;
            }
            set
            {
                this.envelopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Equals", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class BinarySpatialOpType : SpatialOpsType
    {

        private PropertyNameType propertyNameField;

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType), Namespace = "http://www.opengis.net/gml", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType), Namespace = "http://www.opengis.net/gml", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("PropertyName", typeof(PropertyNameType), Order = 1)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("And", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class BinaryLogicOpType : LogicOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public partial class SortPropertyType
    {

        private PropertyNameType propertyNameField;

        private SortOrderType sortOrderField;

        private bool sortOrderFieldSpecified;

        /// <remarks/>
        public PropertyNameType PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public enum SortOrderType
    {

        /// <remarks/>
        DESC,

        /// <remarks/>
        ASC,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LockFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureWithLockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetGmlObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeFeatureTypeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public abstract partial class BaseRequestType
    {

        private string serviceField;

        private string versionField;

        private string handleField;

        public BaseRequestType()
        {
            this.serviceField = "WFS";
            this.versionField = "1.1.0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("WFS")]
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
        [System.ComponentModel.DefaultValueAttribute("1.1.0")]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    public partial class DescriptionType
    {

        private string titleField;

        private string abstractField;

        private KeywordsType[] keywordsField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    public partial class IdentificationType : DescriptionType
    {

        private CodeType identifierField;

        private BoundingBoxType[] boundingBoxField;

        private string[] outputFormatField;

        private string[] availableCRSField;

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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WFS_CapabilitiesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
    public partial class ServiceIdentification : DescriptionType
    {

        private CodeType serviceTypeField;

        private string[] serviceTypeVersionField;

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows", IsNullable = false)]
    public partial class HTTP
    {

        private RequestMethodType[] itemsField;

        private ItemsChoiceType12[] itemsElementNameField;

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
        public ItemsChoiceType12[] ItemsElementName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows", IncludeInSchema = false)]
    public enum ItemsChoiceType12
    {

        /// <remarks/>
        Get,

        /// <remarks/>
        Post,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetCapabilitiesType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/ows", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GetCapabilitiesType", Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class GetCapabilitiesType1 : GetCapabilitiesType
    {

        private string serviceField;

        public GetCapabilitiesType1()
        {
            this.serviceField = "WFS";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("WFS")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("WFS_Capabilities", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class WFS_CapabilitiesType : CapabilitiesBaseType
    {

        private FeatureTypeListType featureTypeListField;

        private GMLObjectTypeType[] servesGMLObjectTypeListField;

        private GMLObjectTypeType[] supportsGMLObjectTypeListField;

        private Filter_Capabilities filter_CapabilitiesField;

        /// <remarks/>
        public FeatureTypeListType FeatureTypeList
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
        [System.Xml.Serialization.XmlArrayItemAttribute("GMLObjectType", IsNullable = false)]
        public GMLObjectTypeType[] ServesGMLObjectTypeList
        {
            get
            {
                return this.servesGMLObjectTypeListField;
            }
            set
            {
                this.servesGMLObjectTypeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GMLObjectType", IsNullable = false)]
        public GMLObjectTypeType[] SupportsGMLObjectTypeList
        {
            get
            {
                return this.supportsGMLObjectTypeListField;
            }
            set
            {
                this.supportsGMLObjectTypeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureTypeList", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class FeatureTypeListType
    {

        private OperationType[] operationsField;

        private FeatureTypeType[] featureTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Operation", IsNullable = false)]
        public OperationType[] Operations
        {
            get
            {
                return this.operationsField;
            }
            set
            {
                this.operationsField = value;
            }
        }

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class Filter_Capabilities
    {

        private Spatial_CapabilitiesType spatial_CapabilitiesField;

        private Scalar_CapabilitiesType scalar_CapabilitiesField;

        private object[] id_CapabilitiesField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("EID", typeof(EID), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FID", typeof(FID), IsNullable = false)]
        public object[] Id_Capabilities
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class EID
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public partial class FID
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("ServesGMLObjectTypeList", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class GMLObjectTypeListType
    {

        private GMLObjectTypeType[] gMLObjectTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GMLObjectType")]
        public GMLObjectTypeType[] GMLObjectType
        {
            get
            {
                return this.gMLObjectTypeField;
            }
            set
            {
                this.gMLObjectTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeFeatureType", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class DescribeFeatureTypeType : BaseRequestType
    {

        private System.Xml.XmlQualifiedName[] typeNameField;

        private string outputFormatField;

        public DescribeFeatureTypeType()
        {
            this.outputFormatField = "text/xml; subtype=gml/3.1.1";
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
        [System.ComponentModel.DefaultValueAttribute("text/xml; subtype=gml/3.1.1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeature", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class GetFeatureType : BaseRequestType
    {

        private QueryType[] queryField;

        private ResultTypeType resultTypeField;

        private string outputFormatField;

        private string maxFeaturesField;

        private string traverseXlinkDepthField;

        private string traverseXlinkExpiryField;

        public GetFeatureType()
        {
            this.resultTypeField = ResultTypeType.results;
            this.outputFormatField = "text/xml; subtype=gml/3.1.1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Query")]
        public QueryType[] Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
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
        [System.ComponentModel.DefaultValueAttribute("text/xml; subtype=gml/3.1.1")]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string maxFeatures
        {
            get
            {
                return this.maxFeaturesField;
            }
            set
            {
                this.maxFeaturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traverseXlinkDepth
        {
            get
            {
                return this.traverseXlinkDepthField;
            }
            set
            {
                this.traverseXlinkDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string traverseXlinkExpiry
        {
            get
            {
                return this.traverseXlinkExpiryField;
            }
            set
            {
                this.traverseXlinkExpiryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Query", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class QueryType
    {

        private object[] itemsField;

        private FilterType filterField;

        private SortPropertyType[] sortByField;

        private string handleField;

        private System.Xml.XmlQualifiedName[] typeNameField;

        private string featureVersionField;

        private string srsNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("PropertyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("XlinkPropertyName", typeof(XlinkPropertyName))]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
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
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlArrayItemAttribute("SortProperty", IsNullable = false)]
        public SortPropertyType[] SortBy
        {
            get
            {
                return this.sortByField;
            }
            set
            {
                this.sortByField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName[] typeName
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureCollection", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class FeatureCollectionType : AbstractFeatureCollectionType
    {

        private string lockIdField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private string numberOfFeaturesField;

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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeStampSpecified
        {
            get
            {
                return this.timeStampFieldSpecified;
            }
            set
            {
                this.timeStampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string numberOfFeatures
        {
            get
            {
                return this.numberOfFeaturesField;
            }
            set
            {
                this.numberOfFeaturesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("GetGmlObject", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class GetGmlObjectType : BaseRequestType
    {

        private GmlObjectIdType gmlObjectIdField;

        private string outputFormatField;

        private string traverseXlinkDepthField;

        private string traverseXlinkExpiryField;

        public GetGmlObjectType()
        {
            this.outputFormatField = "GML3";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
        public GmlObjectIdType GmlObjectId
        {
            get
            {
                return this.gmlObjectIdField;
            }
            set
            {
                this.gmlObjectIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("GML3")]
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
        public string traverseXlinkDepth
        {
            get
            {
                return this.traverseXlinkDepthField;
            }
            set
            {
                this.traverseXlinkDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string traverseXlinkExpiry
        {
            get
            {
                return this.traverseXlinkExpiryField;
            }
            set
            {
                this.traverseXlinkExpiryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureWithLock", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class GetFeatureWithLockType : BaseRequestType
    {

        private QueryType[] queryField;

        private string expiryField;

        private ResultTypeType resultTypeField;

        private string outputFormatField;

        private string maxFeaturesField;

        private string traverseXlinkDepthField;

        private string traverseXlinkExpiryField;

        public GetFeatureWithLockType()
        {
            this.expiryField = "5";
            this.resultTypeField = ResultTypeType.results;
            this.outputFormatField = "text/xml; subtype=gml/3.1.1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Query")]
        public QueryType[] Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("5")]
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
        [System.ComponentModel.DefaultValueAttribute("text/xml; subtype=gml/3.1.1")]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string maxFeatures
        {
            get
            {
                return this.maxFeaturesField;
            }
            set
            {
                this.maxFeaturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string traverseXlinkDepth
        {
            get
            {
                return this.traverseXlinkDepthField;
            }
            set
            {
                this.traverseXlinkDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string traverseXlinkExpiry
        {
            get
            {
                return this.traverseXlinkExpiryField;
            }
            set
            {
                this.traverseXlinkExpiryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeature", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class LockFeatureType : BaseRequestType
    {

        private LockType[] lockField;

        private string expiryField;

        private AllSomeType lockActionField;

        public LockFeatureType()
        {
            this.expiryField = "5";
            this.lockActionField = AllSomeType.ALL;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lock")]
        public LockType[] Lock
        {
            get
            {
                return this.lockField;
            }
            set
            {
                this.lockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("5")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeatureResponse", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class LockFeatureResponseType
    {

        private string lockIdField;

        private FeaturesLockedType featuresLockedField;

        private FeaturesNotLockedType featuresNotLockedField;

        /// <remarks/>
        public string LockId
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Transaction", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class TransactionType : BaseRequestType
    {

        private string lockIdField;

        private object[] itemsField;

        private AllSomeType releaseActionField;

        private bool releaseActionFieldSpecified;

        /// <remarks/>
        public string LockId
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
        [System.Xml.Serialization.XmlElementAttribute("Delete", typeof(DeleteElementType))]
        [System.Xml.Serialization.XmlElementAttribute("Insert", typeof(InsertElementType))]
        [System.Xml.Serialization.XmlElementAttribute("Native", typeof(NativeType))]
        [System.Xml.Serialization.XmlElementAttribute("Update", typeof(UpdateElementType))]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseActionSpecified
        {
            get
            {
                return this.releaseActionFieldSpecified;
            }
            set
            {
                this.releaseActionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Delete", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class DeleteElementType
    {

        private FilterType filterField;

        private string handleField;

        private System.Xml.XmlQualifiedName typeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Insert", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class InsertElementType
    {

        private AbstractFeatureType[] _FeatureField;

        private IdentifierGenerationOptionType idgenField;

        private string handleField;

        private string inputFormatField;

        private string srsNameField;

        public InsertElementType()
        {
            this.idgenField = IdentifierGenerationOptionType.GenerateNew;
            this.inputFormatField = "text/xml; subtype=gml/3.1.1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Feature", Namespace = "http://www.opengis.net/gml")]
        public AbstractFeatureType[] _Feature
        {
            get
            {
                return this._FeatureField;
            }
            set
            {
                this._FeatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(IdentifierGenerationOptionType.GenerateNew)]
        public IdentifierGenerationOptionType idgen
        {
            get
            {
                return this.idgenField;
            }
            set
            {
                this.idgenField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("text/xml; subtype=gml/3.1.1")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    public enum IdentifierGenerationOptionType
    {

        /// <remarks/>
        UseExisting,

        /// <remarks/>
        ReplaceDuplicate,

        /// <remarks/>
        GenerateNew,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Native", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class NativeType
    {

        private string vendorIdField;

        private bool safeToIgnoreField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Update", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class UpdateElementType
    {

        private PropertyType[] propertyField;

        private FilterType filterField;

        private string handleField;

        private System.Xml.XmlQualifiedName typeNameField;

        private string inputFormatField;

        private string srsNameField;

        public UpdateElementType()
        {
            this.inputFormatField = "x-application/gml:3";
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ogc")]
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
        [System.ComponentModel.DefaultValueAttribute("x-application/gml:3")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("Property", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class PropertyType
    {

        private System.Xml.XmlQualifiedName nameField;

        private object valueField;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/wfs")]
    [System.Xml.Serialization.XmlRootAttribute("TransactionResponse", Namespace = "http://www.opengis.net/wfs", IsNullable = false)]
    public partial class TransactionResponseType
    {

        private TransactionSummaryType transactionSummaryField;

        private ActionType[] transactionResultsField;

        private InsertedFeatureType[] insertResultsField;

        private string versionField;

        public TransactionResponseType()
        {
            this.versionField = "1.1.0";
        }

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
        [System.Xml.Serialization.XmlArrayItemAttribute("Action", IsNullable = false)]
        public ActionType[] TransactionResults
        {
            get
            {
                return this.transactionResultsField;
            }
            set
            {
                this.transactionResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable = false)]
        public InsertedFeatureType[] InsertResults
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("SortBy", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("surfaceArrayProperty", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class SurfaceArrayPropertyType
    {

        private AbstractSurfaceType[] _SurfaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Surface")]
        public AbstractSurfaceType[] _Surface
        {
            get
            {
                return this._SurfaceField;
            }
            set
            {
                this._SurfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("members", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class ArrayAssociationType
    {

        private object[] _ObjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Object")]
        public object[] _Object
        {
            get
            {
                return this._ObjectField;
            }
            set
            {
                this._ObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("featureMembers", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class FeatureArrayPropertyType
    {

        private AbstractFeatureType[] _FeatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Feature")]
        public AbstractFeatureType[] _Feature
        {
            get
            {
                return this._FeatureField;
            }
            set
            {
                this._FeatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("segments", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CurveSegmentArrayPropertyType
    {

        private AbstractCurveSegmentType[] _CurveSegmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_CurveSegment")]
        public AbstractCurveSegmentType[] _CurveSegment
        {
            get
            {
                return this._CurveSegmentField;
            }
            set
            {
                this._CurveSegmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geometryMembers", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class GeometryArrayPropertyType
    {

        private AbstractGeometryType[] _GeometryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Geometry")]
        public AbstractGeometryType[] _Geometry
        {
            get
            {
                return this._GeometryField;
            }
            set
            {
                this._GeometryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("pointMembers", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class PointArrayPropertyType
    {

        private PointType[] pointField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public PointType[] Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("curveMembers", Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class CurveArrayPropertyType
    {

        private LineStringType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineString")]
        public LineStringType[] Items
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
