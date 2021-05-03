using InstaIssue.Handlers;
using System;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    public class ClientSelectManagement
    {
        private String type;
        private ClientContext context;


        public ClientSelectManagement(string type)
        {
            this.type = type;
        }

        public void doWork()
        {
            Globals.handler.ClientEvent += Switch;

            switch (type)
            {
                case "Edit":
                    {
                        context = new ClientContext(new ClientEdit());
                    }
                    break;
                case "View":
                    {
                        context = new ClientContext(new ClientView());
                    }
                    break;
                case "Delete":
                    {
                        context = new ClientContext(new ClientDelete());
                    }
                    break;
                case "Add":
                    {
                        context = new ClientContext(new ClientAdd());
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
                        Globals.clientsEditForm.Show();
                    }
                    break;
                case "Delete":
                    {
                        Globals.clientsEditForm.Show();
                    }
                    break;
                case "Add":
                    {
                        Globals.clientsEditForm.Show();
                    }
                    break;
                case "View":
                    {
                        Globals.clientsEditForm.Show();
                    }
                    break;
            }
        }
    }
}
