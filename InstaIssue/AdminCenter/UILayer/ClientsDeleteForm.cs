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
    public partial class ClientsDeleteForm : Form
    {
        private List<Clients> clients;

        public ClientsDeleteForm()
        {
            InitializeComponent();
        }

        private void ClientsDeleteForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            lblID.Text = Globals.StaffID;
            //Load all clients in combobox
            clients = new ClientTracker().GetClients();

            foreach (Clients item in clients)
            {
                cmbClients.Items.Add(item.ClientID + " " + item.Name);
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsDeleteForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void btnDeleteSaff_Click(object sender, EventArgs e)
        {
            //DeleteAll data asociated with the clientID
            
            string[] split = cmbClients.Text.Split(' ');
            string clientID = split[0];

            bool flag = new GeneralAdminHandler().DeleteClient(clientID);
            if (flag)
            {
                MessageBox.Show("Client was deleted", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clients = new ClientTracker().GetClients();

                cmbClients.Items.Clear();
                foreach (Clients item in clients)
                {
                    cmbClients.Items.Add(item.ClientID + " " + item.Name);
                }
            }
            else
            {
                MessageBox.Show("Error client was not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
