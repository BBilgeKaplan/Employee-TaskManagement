//     Created a class to show the task as crossed out when the task is marked as completed.

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using emp_mngt.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_mngt.Module.Controllers
{
    public class TaskCompletedController : ViewController
    {
        SimpleAction Complete;
        public TaskCompletedController()
        {
            TargetObjectType = typeof(Task);

            Complete = new SimpleAction(this, "Complete", PredefinedCategory.Edit);
            Complete.SelectionDependencyType = SelectionDependencyType.RequireSingleObject;
            Complete.Execute += Complete_Execute;
        }

        protected override void OnActivated()
        {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }
        void Complete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var currentObj = e.CurrentObject as Tasks;
            if (currentObj != null)
            {
                currentObj.Status = Status.Completed;
            }

            if (this.ObjectSpace.IsModified)
            {
                this.ObjectSpace.CommitChanges();
            }
        }
    }
}

