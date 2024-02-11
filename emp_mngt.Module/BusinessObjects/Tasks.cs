using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace emp_mngt.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Task")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Tasks : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Tasks(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string subject;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Subject
        {
            get => subject;
            set => SetPropertyValue(nameof(Subject), ref subject, value);
        }

        Status status;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public Status Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }

        string assignedto;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AssignedTo
        {
            get => assignedto;
            set => SetPropertyValue(nameof(AssignedTo), ref assignedto, value);
        }

        DateTime startday;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime StartDay
        {
            get => startday;
            set => SetPropertyValue(nameof(StartDay), ref startday, value);
        }

        DateTime duedate;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime DueDate
        {
            get => duedate;
            set => SetPropertyValue(nameof(DueDate), ref duedate, value);
        }

        Priority priority;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public Priority Priority
        {
            get => priority;
            set => SetPropertyValue(nameof(Priority), ref priority, value);
        }

        int estimatedWorkHours;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public int EstimatedWorkHours
        {
            get => estimatedWorkHours;
            set => SetPropertyValue(nameof(EstimatedWorkHours), ref estimatedWorkHours, value);
        }

        int actualWorkHours;
        [VisibleInListView(false)]
        public int ActualWorkHours
        {
            get => actualWorkHours;
            set => SetPropertyValue(nameof(ActualWorkHours), ref actualWorkHours, value);
        }

        int percentCompleted;
        [VisibleInListView(false)]
        public int PercentCompleted
        {
            get => percentCompleted;
            set => SetPropertyValue(nameof(PercentCompleted), ref percentCompleted, value);
        }

        DateTime dateCompleted;
        [VisibleInListView(false)]
        public DateTime DateCompleted
        {
            get => dateCompleted;
            set => SetPropertyValue(nameof(DateCompleted), ref dateCompleted, value);
        }
        string description;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }

        [Association]
        public XPCollection<Employee> Employee { get { return GetCollection<Employee>(nameof(Employee)); } }
    }

    public enum Status
    {
        [ImageName("State_Task_NotStarted")] NotStarted = 0,
        [ImageName("State_Task_InProgress")] InProgress = 1,
        [ImageName("State_Task_WaitingForSomeoneElse")] WaitingForSomeoneElse = 2,
        [ImageName("State_Task_Deferred")] Deferred = 3,
        [ImageName("State_Task_Completed")] Completed = 4

    }

    public enum Priority
    {
        [ImageName("State_Priority_Low")] Low = 0,
        [ImageName("State_Priority_Normal")] Normal = 1,
        [ImageName("State_Priority_High")] High = 2,
    }
}