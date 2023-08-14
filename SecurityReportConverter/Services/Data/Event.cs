using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SecurityReportConverter.Services.Data
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public partial class Events {
	    
	    private EventsEvent[] eventField;
	    
	    private System.DateTime endDateTimeField;
	    
	    private bool endDateTimeFieldSpecified;
	    
	    private System.DateTime startDateTimeField;
	    
	    private bool startDateTimeFieldSpecified;
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlElementAttribute("Event")]
	    public EventsEvent[] Event {
	        get {
	            return this.eventField;
	        }
	        set {
	            this.eventField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public System.DateTime endDateTime {
	        get {
	            return this.endDateTimeField;
	        }
	        set {
	            this.endDateTimeField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlIgnoreAttribute()]
	    public bool endDateTimeSpecified {
	        get {
	            return this.endDateTimeFieldSpecified;
	        }
	        set {
	            this.endDateTimeFieldSpecified = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public System.DateTime startDateTime {
	        get {
	            return this.startDateTimeField;
	        }
	        set {
	            this.startDateTimeField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlIgnoreAttribute()]
	    public bool startDateTimeSpecified {
	        get {
	            return this.startDateTimeFieldSpecified;
	        }
	        set {
	            this.startDateTimeFieldSpecified = value;
	        }
	    }
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public partial class EventsEvent {
	    
	    private System.DateTime eventDateTimeField;
	    
	    private bool eventDateTimeFieldSpecified;
	    
	    private string userUIDField;
	    
	    private string directionField;
	    
	    private string eventTypeField;
	    
	    private string pointNameField;
	    
	    private string firstNameField;
	    
	    private string lastNameField;
	    
	    private string middleNameField;
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public System.DateTime eventDateTime {
	        get {
	            return this.eventDateTimeField;
	        }
	        set {
	            this.eventDateTimeField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlIgnoreAttribute()]
	    public bool eventDateTimeSpecified {
	        get {
	            return this.eventDateTimeFieldSpecified;
	        }
	        set {
	            this.eventDateTimeFieldSpecified = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string userUID {
	        get {
	            return this.userUIDField;
	        }
	        set {
	            this.userUIDField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string direction {
	        get {
	            return this.directionField;
	        }
	        set {
	            this.directionField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string eventType {
	        get {
	            return this.eventTypeField;
	        }
	        set {
	            this.eventTypeField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string pointName {
	        get {
	            return this.pointNameField;
	        }
	        set {
	            this.pointNameField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string firstName {
	        get {
	            return this.firstNameField;
	        }
	        set {
	            this.firstNameField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string lastName {
	        get {
	            return this.lastNameField;
	        }
	        set {
	            this.lastNameField = value;
	        }
	    }
	    
	    /// <remarks/>
	    [System.Xml.Serialization.XmlAttributeAttribute()]
	    public string middleName {
	        get {
	            return this.middleNameField;
	        }
	        set {
	            this.middleNameField = value;
	        }
	    }
	}
}
