﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Quartz.Xml.JobSchedulingData20 {
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    [XmlRoot("job-scheduling-data", Namespace="http://quartznet.sourceforge.net/JobSchedulingData", IsNullable=false)]
    public partial class QuartzXmlConfiguration20 {
        
        private preprocessingcommandsType[] preprocessingcommandsField;
        
        private processingdirectivesType[] processingdirectivesField;
        
        private jobschedulingdataSchedule[] scheduleField;
        
        private string versionField;
        
        /// <remarks/>
        [XmlElement("pre-processing-commands")]
        public preprocessingcommandsType[] preprocessingcommands {
            get {
                return this.preprocessingcommandsField;
            }
            set {
                this.preprocessingcommandsField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("processing-directives")]
        public processingdirectivesType[] processingdirectives {
            get {
                return this.processingdirectivesField;
            }
            set {
                this.processingdirectivesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("schedule")]
        public jobschedulingdataSchedule[] schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
            }
        }
        
        /// <remarks/>
        [XmlAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(TypeName="pre-processing-commandsType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsType {
        
        private string[] deletejobsingroupField;
        
        private string[] deletetriggersingroupField;
        
        private preprocessingcommandsTypeDeletejob[] deletejobField;
        
        private preprocessingcommandsTypeDeletetrigger[] deletetriggerField;
        
        /// <remarks/>
        [XmlElement("delete-jobs-in-group")]
        public string[] deletejobsingroup {
            get {
                return this.deletejobsingroupField;
            }
            set {
                this.deletejobsingroupField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("delete-triggers-in-group")]
        public string[] deletetriggersingroup {
            get {
                return this.deletetriggersingroupField;
            }
            set {
                this.deletetriggersingroupField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("delete-job")]
        public preprocessingcommandsTypeDeletejob[] deletejob {
            get {
                return this.deletejobField;
            }
            set {
                this.deletejobField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("delete-trigger")]
        public preprocessingcommandsTypeDeletetrigger[] deletetrigger {
            get {
                return this.deletetriggerField;
            }
            set {
                this.deletetriggerField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsTypeDeletejob {
        
        private string nameField;
        
        private string groupField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
    
    /// <remarks/>
    [XmlInclude(typeof(calendarIntervalTriggerType))]
    [XmlInclude(typeof(cronTriggerType))]
    [XmlInclude(typeof(simpleTriggerType))]
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public abstract partial class abstractTriggerType {
        
        private string nameField;
        
        private string groupField;
        
        private string descriptionField;
        
        private string jobnameField;
        
        private string jobgroupField;
        
        private string priorityField;
        
        private string calendarnameField;
        
        private jobdatamapType jobdatamapField;
        
        private object itemField;
        
        private DateTime endtimeField;
        
        private bool endtimeFieldSpecified;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("job-name")]
        public string jobname {
            get {
                return this.jobnameField;
            }
            set {
                this.jobnameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("job-group")]
        public string jobgroup {
            get {
                return this.jobgroupField;
            }
            set {
                this.jobgroupField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(DataType="nonNegativeInteger")]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("calendar-name")]
        public string calendarname {
            get {
                return this.calendarnameField;
            }
            set {
                this.calendarnameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("job-data-map")]
        public jobdatamapType jobdatamap {
            get {
                return this.jobdatamapField;
            }
            set {
                this.jobdatamapField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("start-time", typeof(DateTime))]
        [XmlElement("start-time-seconds-in-future", typeof(string), DataType="nonNegativeInteger")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("end-time")]
        public DateTime endtime {
            get {
                return this.endtimeField;
            }
            set {
                this.endtimeField = value;
            }
        }
        
        /// <remarks/>
        [XmlIgnore()]
        public bool endtimeSpecified {
            get {
                return this.endtimeFieldSpecified;
            }
            set {
                this.endtimeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(TypeName="job-data-mapType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobdatamapType {
        
        private entryType[] entryField;
        
        /// <remarks/>
        [XmlElement("entry")]
        public entryType[] entry {
            get {
                return this.entryField;
            }
            set {
                this.entryField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class entryType {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class calendarIntervalTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string repeatintervalField;
        
        private string repeatintervalunitField;
        
        /// <remarks/>
        [XmlElement("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("repeat-interval", DataType="nonNegativeInteger")]
        public string repeatinterval {
            get {
                return this.repeatintervalField;
            }
            set {
                this.repeatintervalField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("repeat-interval-unit")]
        public string repeatintervalunit {
            get {
                return this.repeatintervalunitField;
            }
            set {
                this.repeatintervalunitField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class cronTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string cronexpressionField;
        
        private string timezoneField;
        
        /// <remarks/>
        [XmlElement("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("cron-expression")]
        public string cronexpression {
            get {
                return this.cronexpressionField;
            }
            set {
                this.cronexpressionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("time-zone")]
        public string timezone {
            get {
                return this.timezoneField;
            }
            set {
                this.timezoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class simpleTriggerType : abstractTriggerType {
        
        private string misfireinstructionField;
        
        private string repeatcountField;
        
        private string repeatintervalField;
        
        /// <remarks/>
        [XmlElement("misfire-instruction")]
        public string misfireinstruction {
            get {
                return this.misfireinstructionField;
            }
            set {
                this.misfireinstructionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("repeat-count", DataType="integer")]
        public string repeatcount {
            get {
                return this.repeatcountField;
            }
            set {
                this.repeatcountField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("repeat-interval", DataType="nonNegativeInteger")]
        public string repeatinterval {
            get {
                return this.repeatintervalField;
            }
            set {
                this.repeatintervalField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class triggerType {
        
        private abstractTriggerType itemField;
        
        /// <remarks/>
        [XmlElement("calendar-interval", typeof(calendarIntervalTriggerType))]
        [XmlElement("cron", typeof(cronTriggerType))]
        [XmlElement("simple", typeof(simpleTriggerType))]
        public abstractTriggerType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(TypeName="job-detailType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobdetailType {
        
        private string nameField;
        
        private string groupField;
        
        private string descriptionField;
        
        private string jobtypeField;
        
        private bool durableField;
        
        private bool recoverField;
        
        private jobdatamapType jobdatamapField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("job-type")]
        public string jobtype {
            get {
                return this.jobtypeField;
            }
            set {
                this.jobtypeField = value;
            }
        }
        
        /// <remarks/>
        public bool durable {
            get {
                return this.durableField;
            }
            set {
                this.durableField = value;
            }
        }
        
        /// <remarks/>
        public bool recover {
            get {
                return this.recoverField;
            }
            set {
                this.recoverField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("job-data-map")]
        public jobdatamapType jobdatamap {
            get {
                return this.jobdatamapField;
            }
            set {
                this.jobdatamapField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(TypeName="processing-directivesType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class processingdirectivesType {
        
        private bool overwriteexistingdataField;
        
        private bool ignoreduplicatesField;
        
        private bool scheduletriggerrelativetoreplacedtriggerField;
        
        public processingdirectivesType() {
            this.overwriteexistingdataField = true;
            this.ignoreduplicatesField = false;
            this.scheduletriggerrelativetoreplacedtriggerField = false;
        }
        
        /// <remarks/>
        [XmlElement("overwrite-existing-data")]
        [DefaultValue(true)]
        public bool overwriteexistingdata {
            get {
                return this.overwriteexistingdataField;
            }
            set {
                this.overwriteexistingdataField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("ignore-duplicates")]
        [DefaultValue(false)]
        public bool ignoreduplicates {
            get {
                return this.ignoreduplicatesField;
            }
            set {
                this.ignoreduplicatesField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("schedule-trigger-relative-to-replaced-trigger")]
        [DefaultValue(false)]
        public bool scheduletriggerrelativetoreplacedtrigger {
            get {
                return this.scheduletriggerrelativetoreplacedtriggerField;
            }
            set {
                this.scheduletriggerrelativetoreplacedtriggerField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class preprocessingcommandsTypeDeletetrigger {
        
        private string nameField;
        
        private string groupField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
    
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
#if BINARY_SERIALIZATION
    [Serializable()]
#endif // BINARY_SERIALIZATION
    [DebuggerStepThrough()]
#if DESIGNER
    [DesignerCategory("code")]
#endif // DESIGNER
    [XmlType(AnonymousType=true, Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public partial class jobschedulingdataSchedule {
        
        private jobdetailType[] jobField;
        
        private triggerType[] triggerField;
        
        /// <remarks/>
        [XmlElement("job")]
        public jobdetailType[] job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement("trigger")]
        public triggerType[] trigger {
            get {
                return this.triggerField;
            }
            set {
                this.triggerField = value;
            }
        }
    }
}
