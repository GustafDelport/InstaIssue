using InstaIssue.AdminCenter.LogicLayer;
using InstaIssue.AdminCenter.LogicLayer.DesignPattern;
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
    public partial class AdminCenterForm : Form
    {
        private String staffID;
        private Panel activePanel;

        public AdminCenterForm()
        {
            InitializeComponent();
        }

        private void AdminCenterForm_Load(object sender, EventArgs e)
        {
            activePanel = pnlIssues;
            activePanel.Visible = true;
            tmrTime.Start();
            lblID.Text = Globals.StaffID;
        }

        //Fancy Animations
        #region

        private void btnMngClients_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlClients.Visible = true;
            activePanel = pnlClients;
        }

        private void btnMngStaff_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlStaff.Visible = true;
            activePanel = pnlStaff;
        }

        private void btnMngContracts_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlContracts.Visible = true;
            activePanel = pnlContracts;
        }

        private void btnMngIssues_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;

            dgvIssues.DataSource = new IssuesCenter().GetIssues();
        }
        #endregion

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            new StaffSelectManagement("Add").doWork();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            new StaffSelectManagement("View").doWork();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            new StaffSelectManagement("Edit").doWork();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new ClientSelectManagement("Add").doWork();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            new ClientSelectManagement("View").doWork();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            new ClientSelectManagement("Edit").doWork();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            new ClientSelectManagement("Delete").doWork();
        }

        private void btnAddCont_Click(object sender, EventArgs e)
        {
            new ContractSelectManagement("Add").doWork();
        }

        private void btnViewCont_Click(object sender, EventArgs e)
        {
            new ContractSelectManagement("View").doWork();
        }

        private void btnEditCont_Click(object sender, EventArgs e)
        {
            new ContractSelectManagement("Edit").doWork();
        }

        private void AdminCenterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
