﻿using InstaIssue.AdminCenter.UILayer;
using InstaIssue.CallCenter.UILayer;
using Authentication;
using System;
using System.Windows.Forms;
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

            Globals.serviceCenterForm = new ServiceCenterForm();

            Globals.informationForm = new Information();
            Globals.callCenterForm = new CallCenterForm();

            Globals.AdminCenterForm = new AdminCenterForm();
            Globals.clientsAddForm = new ClientsAddForm();
            Globals.clientsDeleteForm = new ClientsDeleteForm();
            Globals.clientsEditForm = new ClientsEditForm();
            Globals.clientsViewForm = new ClientsViewForm();
            Globals.contractsAddForm = new ContractsAddForm();
            Globals.contractsEditForm = new ContractsEditForm();
            Globals.contractsViewForm = new ContractsViewForm();
            Globals.staffAddForm = new StaffAddForm();
            Globals.staffEditForm = new StaffEditForm();
            Globals.staffViewForm = new StaffViewForm();


            //Shortcut
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = "", password = "";

            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                username = txtUsername.Text;
                password = txtPassword.Text;

                Login login = new Login();

                if (login.LoginUser(username, password))
                {
                    StaffDataHandler handler = new StaffDataHandler();
                    Globals.StaffID = handler.ReturnStaffID(username);

                    switch (new Validations().ValidateStaffRank(Globals.StaffID))
                    {
                        case 1:
                            {
                                //Call Agent
                                Globals.callCenterForm.Show();
                                this.Hide();
                            }
                            break;
                        case 2:
                            {
                                //Admin
                                Globals.AdminCenterForm.Show();
                                this.Hide();
                            }
                            break;
                        case 3:
                            {
                                //Service Manager
                                Globals.serviceCenterForm.Show();
                                this.Hide();
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorect Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please check Format of username of password", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
