using InstaIssue.Handlers;
using System;
using System.Collections.Generic;
using Authentication;
using System.Windows.Forms;
using InstaIssue.CallCenter.LogicLayer;

namespace InstaIssue.AdminCenter.UILayer
{
    public partial class ClientsAddForm : Form
    {
        private List<String> SLAlist;
        private bool flag;
        private readonly Validations validations = new Validations();

        public ClientsAddForm()
        {
            InitializeComponent();
        }

        private void ClientsAddForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            SLAlist = new PopulationHandler().GetSla();
            foreach (string item in SLAlist)
            {
                cmbContracts.Items.Add(item);
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsAddForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        //Fancy Animations
        #region

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Text = "";

        }

        private void txtNatID_Click(object sender, EventArgs e)
        {
            txtNatID.Text = "";

        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";

        }

        #endregion

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Validate if the text is correct!
            Panel ClientPanel = pnlAddClient;

            //Major validations happen here
            flag = validations.ValidateRegisterClient(ClientPanel);

            String name = txtName.Text;
            String surname = txtSurname.Text;
            String natID = txtNatID.Text;
            String phone = txtPhone.Text;
            String eMail = txtEmail.Text;
            String address = txtAddress.Text;
            String SLA = cmbContracts.Text;

            flag = true;

            if (flag)
            {
                flag = new RegisterClient().RegisterNewClient(name, surname, natID, phone, eMail, address, SLA);
                if (flag)
                {
                    MessageBox.Show("A new client was registered", "Addidtion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add client", "Addidtion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBoxes();
                }
            }
            else
            {
                ResetBoxes();
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetBoxes()
        {
            txtName.Text = "Name";
            txtSurname.Text = "Surname";
            txtNatID.Text = "National ID";
            txtPhone.Text = "Phone Number";
            txtEmail.Text = "Email";
            txtAddress.Text = "Address";
        }
    }
}
