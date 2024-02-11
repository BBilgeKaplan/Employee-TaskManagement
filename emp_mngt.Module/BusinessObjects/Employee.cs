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
    [ImageName("BO_Employee")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Employee : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Employee(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string title;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        string firstName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }

        string lastname;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        public string LastName
        {
            get => lastname;
            set => SetPropertyValue(nameof(LastName), ref lastname, value);
        }

        string fullName;
        [NonPersistent]
        [VisibleInListView(false)]
        public string FullName
        {
            get { return String.Format("{0} {1}", firstName ?? "", lastname ?? ""); }
        }

        string position;
        [VisibleInListView(false)]
        public string Position
        {
            get => position;
            set => SetPropertyValue(nameof(Position), ref position, value);
        }

        string email;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [RuleRequiredField]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }

        DateTime birthday;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime BirthDay
        {
            get => birthday;
            set => SetPropertyValue(nameof(BirthDay), ref birthday, value);
        }

        string address;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
        }

        byte[] _image;
        [ImageEditor]
        [VisibleInListView(false)]
        public byte[] Image
        {
            get => _image;
            set => SetPropertyValue(nameof(Image), ref _image, value);
        }

        string nickName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public string NickName
        {
            get => nickName;
            set => SetPropertyValue(nameof(NickName), ref nickName, value);
        }

        string spouse;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public string Spouse
        {
            get => spouse;
            set => SetPropertyValue(nameof(Spouse), ref spouse, value);
        }

        DateTime weddingDate;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public DateTime WeddingDate
        {
            get => weddingDate;
            set => SetPropertyValue(nameof(WeddingDate), ref weddingDate, value);
        }

        string office;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [VisibleInListView(false)]
        public string Office
        {
            get => office;
            set => SetPropertyValue(nameof(Office), ref office, value);
        }


        /*
        Position position;
        [VisibleInListView(false)]
        [Association]
        public Position Position
        {
            get { return position; }
            set { SetPropertyValue(nameof(Position), ref position, value); }
        }
        */

        string note;
        [VisibleInListView(false)]
        [Size(SizeAttribute.Unlimited)]
        public string Note
        {
            get => note;
            set => SetPropertyValue(nameof(Note), ref note, value);
        }

        Departments departments;
        [VisibleInListView(false)]
        [Association]
        public Departments Departments
        {
            get { return departments; }
            set { SetPropertyValue(nameof(Departments), ref departments, value); }
        }

        bool _isActive;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public bool isActive
        {
            get => _isActive;
            set => SetPropertyValue(nameof(isActive), ref _isActive, value);
        }

        [Association]
        public XPCollection<Tasks> Task { get { return GetCollection<Tasks>(nameof(Task)); } }

        /*
        [Association]
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        public XPCollection<Resumes> Resume { get { return GetCollection<Resumes>(nameof(Resume)); } }
        */

    }
}