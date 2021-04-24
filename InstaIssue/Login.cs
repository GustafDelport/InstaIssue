using InstaIssue.AdminCenter.UILayer;
using InstaIssue.CallCenter.UILayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //We Load A new instance of all the Forms here in a global class so we can use them without creating new instances
            Globals.loginForm = this;

            Globals.serviceCenterForm = new ServiceCenter();

            Globals.informationForm = new Information();
            Globals.callCenterForm = new CallCenterForm();

            Globals.AdminCenterForm = new AdminCenterForm();
            Globals.clientsAddForm = new ClientsAddForm();
            Globals.clientsDeleteForm = new ClientsDeleteForm();
            Globals.clientsEditForm = new ClientsEditForm();
            Globals.clientsViewForm = new ClientsViewForm();
            Globals.contractsAddForm = new ContractsAddForm();
            Globals.contractsDeleteForm = new ContractsDeleteForm();
            Globals.contractsEditForm = new ContractsEditForm();
            Globals.contractsViewForm = new ContractsViewForm();
            Globals.staffAddForm = new StaffAddForm();
            Globals.staffDeleteForm = new StaffDeleteForm();
            Globals.staffEditForm = new StaffEditForm();
            Globals.staffViewForm = new StaffViewForm();


            //Shortcut
            this.Hide();
            Globals.serviceCenterForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
