using InstaIssue.AdminCenter.UILayer;
using InstaIssue.CallCenter.UILayer;
using Authentication;
using System;
using System.Windows.Forms;
using Database;
using InstaIssue.AdminCenter.DomainLayer;

namespace InstaIssue
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            //this.Hide();
            //Globals.callCenterForm.Show();

            //Events 
            //EventsHandler eventsHandler = new EventsHandler();
            //eventsHandler.IntialLaunch += assignStaff;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String username = "", password = "";

            //Login login = new Login();
            //if (login.LoginUser("username", "password"))
            //{

            //    StaffDataHandler handler = new StaffDataHandler();
            //    Globals.StaffID = handler.ReturnStaffID(username);
            //}
            //else
            //{
            //    //Wrong password
            //}

            //Jissis !!!!!
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Password")
            {
                Globals.callCenterForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorect Password or Username","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
