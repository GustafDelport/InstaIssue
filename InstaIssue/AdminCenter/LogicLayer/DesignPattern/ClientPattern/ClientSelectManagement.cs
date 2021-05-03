using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaIssue.AdminCenter.LogicLayer.DesignPattern
{
    class ClientSelectManagement
    {
        private String type;
        private ClientContext context;

        public ClientSelectManagement(string type)
        {
            this.type = type;
        }

        public void doWork()
        {
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
    }
}
