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
    public partial class ClientsViewForm : Form
    {
        public ClientsViewForm()
        {
            InitializeComponent();
        }

        private void ClientsViewForm_Load(object sender, EventArgs e)
        {
            tmrTyd.Start();
            lblID.Text = Globals.StaffID;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsViewForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTyd_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ClientsViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
