using InstaIssue.AdminCenter.LogicLayer;
using InstaIssue.CallCenter.DomainLayer;
using InstaIssue.CallCenter.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.UILayer
{
    public partial class ClientsEditForm : Form
    {
        private List<Clients> clients;
        private Clients client;

        public ClientsEditForm()
        {
            InitializeComponent();
        }

        private void ClientsEditForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            lblID.Text = Globals.StaffID;
            clients = new ClientTracker().GetClients();

            foreach (Clients item in clients)
            {
                cmbClientIDs.Items.Add(item.ClientID + " " + item.Name);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsEditForm.Hide();
            Globals.AdminCenterForm.Show();

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ClientsEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSetClient_Click(object sender, EventArgs e)
        {
            string clientID = cmbClientIDs.Text.Split(' ')[0];

            foreach (Clients item in clients)
            {
                if (item.ClientID == clientID)
                {
                    client = item;
                }
            }

            lblAAdress.Text = client.Address;
            lblAEmail.Text = client.EMail;
            lblAName.Text = client.Name;
            lblASurname.Text = client.Surname;
            lblAPhone.Text = client.PhoneNumber;
        }

        private void txtNewData_Click(object sender, EventArgs e)
        {
            txtNewData.Text = "";
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            switch (cmbData.Text)
            {
                case "Name":
                    {
                        client.Name = txtNewData.Text;
                    }
                    break;
                case "Surname":
                    {
                        client.Surname = txtNewData.Text;
                    }
                    break;
                case "Phone":
                    {
                        client.PhoneNumber = txtNewData.Text;
                    }
                    break;
                case "Email":
                    {
                        client.EMail = txtNewData.Text;
                    }
                    break;
                case "Address":
                    {
                        client.Address = txtNewData.Text;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Please select data to edit in the drop down menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            bool flag = new GeneralAdminHandler().EditClient(client);

            if (flag)
            {
                MessageBox.Show("New client data was registered", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was a error updating client data", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
