using InstaIssue.AdminCenter.LogicLayer.DesignPattern.ContractPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ContractSelectManagement
    {
        private String type;
        private ContractContext context;

        public ContractSelectManagement(string type)
        {
            this.type = type;
        }

        public void doWork()
        {
            Globals.handler.ContractEvent += Switch;

            switch (type)
            {
                case "Edit":
                    {
                        context = new ContractContext(new ContractEdit());
                    }
                    break;
                case "View":
                    {
                        context = new ContractContext(new ContractView());
                    }
                    break;
                case "Delete":
                    {
                        context = new ContractContext(new ContractDelete());
                    }
                    break;
                case "Add":
                    {
                        context = new ContractContext(new ContractAdd());
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
                        Globals.contractsEditForm.Show();
                    }
                    break;
                case "Delete":
                    {
                        Globals.contractsDeleteForm.Show();
                    }
                    break;
                case "Add":
                    {
                        Globals.contractsAddForm.Show();
                    }
                    break;
                case "View":
                    {
                        Globals.contractsViewForm.Show();
                    }
                    break;
            }
        }
    }
}
