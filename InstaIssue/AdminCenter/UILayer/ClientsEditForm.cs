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
    }
}
