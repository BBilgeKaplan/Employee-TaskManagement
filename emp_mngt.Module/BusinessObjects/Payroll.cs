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
    [ImageName("BO_Sale_Item")]
    // [ListViewFilter]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Payroll : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Payroll(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string employee;
        [RuleRequiredField]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Employee
        {
            get => employee;
            set => SetPropertyValue(nameof(Employee), ref employee, value);
        }

        string eMail;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public string EMail
        {
            get => eMail;
            set => SetPropertyValue(nameof(EMail), ref eMail, value);
        }

        int payPeriod;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public int PayPeriod
        {
            get => payPeriod;
            set => SetPropertyValue(nameof(PayPeriod), ref payPeriod, value);
        }

        DateTime payPeriodStart;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime PayPeriodStart
        {
            get => payPeriodStart;
            set => SetPropertyValue(nameof(PayPeriodStart), ref payPeriodStart, value);
        }

        DateTime payPeriodEnd;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime PayPeriodEnd
        {
            get => payPeriodEnd;
            set => SetPropertyValue(nameof(PayPeriodEnd), ref payPeriodEnd, value);
        }

        DateTime paymentDay;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime PaymentDay
        {
            get => paymentDay;
            set => SetPropertyValue(nameof(PaymentDay), ref paymentDay, value);
        }
        double payRate;
        public double PayRate
        {
            get => payRate;
            set => SetPropertyValue(nameof(PayRate), ref payRate, value);
        }
        int hours;
        public int Hours
        {
            get => hours;
            set => SetPropertyValue(nameof(Hours), ref hours, value);
        }
        double overtimePayRate;
        public double OvertimePayRate
        {
            get => overtimePayRate;
            set => SetPropertyValue(nameof(OvertimePayRate), ref overtimePayRate, value);
        }
        int overtimeHours;
        public int OvertimeHours
        {
            get => overtimeHours;
            set => SetPropertyValue(nameof(OvertimeHours), ref overtimeHours, value);
        }

        double taxRate;
        public double TaxRate
        {
            get => taxRate;
            set => SetPropertyValue(nameof(TaxRate), ref taxRate, value);
        }

        double totalTax;
        public double TotalTax
        {
            get => totalTax;
            set => SetPropertyValue(nameof(TotalTax), ref totalTax, value);
        }

        double grossPay;
        public double GrossPay
        {
            get => grossPay;
            set => SetPropertyValue(nameof(GrossPay), ref grossPay, value);
        }

        double netPay;
        public double NetPay
        {
            get => netPay;
            set => SetPropertyValue(nameof(NetPay), ref netPay, value);
        }

        string note;
        [Size(SizeAttribute.Unlimited)]
        public string Note
        {
            get => note;
            set => SetPropertyValue(nameof(Note), ref note, value);
        }
    }
}