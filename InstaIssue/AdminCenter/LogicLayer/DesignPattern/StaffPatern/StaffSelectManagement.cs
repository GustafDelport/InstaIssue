using InstaIssue.AdminCenter.LogicLayer.DesignPattern.StaffPatern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class StaffSelectManagement
    {
        private String type;
        private StaffContext context;

        public StaffSelectManagement(string type)
        {
            this.type = type;
        }

        public void doWork()
        {
            Globals.handler.StaffEvent += Switch;

            switch (type)
            {
                case "Edit":
                    {
                        context = new StaffContext(new StaffView());
                    }
                    break;
                case "View":
                    {
                        context = new StaffContext(new StaffView());
                    }
                    break;
                case "Delete":
                    {
                        context = new StaffContext(new StaffDelete());
                    }
                    break;
                case "Add":
                    {
                        context = new StaffContext(new StaffAdd());
                    }
                    break;
                default:
                    break;
            }

            context.doWork();
        }

        public void Switch(String formName)
        {
            Globals.AdminCenterForm.Hide();
            switch (formName)
            {
                case "Edit":
                    {
                        Globals.staffEditForm.Show();
                    }
                    break;
                case "Delete":
                    {
                        Globals.staffDeleteForm.Show();
                    }
                    break;
                case "Add":
                    {
                        Globals.staffAddForm.Show();
                    }
                    break;
                case "View":
                    {
                        Globals.staffViewForm.Show();
                    }
                    break;
            }
        }
    }
}
