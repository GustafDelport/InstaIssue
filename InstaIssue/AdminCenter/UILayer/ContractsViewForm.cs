using InstaIssue.AdminCenter.LogicLayer;
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
    public partial class ContractsViewForm : Form
    {
        public ContractsViewForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.contractsViewForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ContractsViewForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            lblID.Text = Globals.StaffID;
        }

        private void ContractsViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewContracts_Click(object sender, EventArgs e)
        {
            dgvSContracts.DataSource = new ContractsManagment().GetContracts();
        }

        private void btnViewSLA_Click(object sender, EventArgs e)
        {
            dgvSContracts.DataSource = new ContractsManagment().GetSLAs();
        }
    }
}
