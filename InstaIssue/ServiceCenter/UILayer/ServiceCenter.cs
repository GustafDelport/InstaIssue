using InstaIssue.AdminCenter.DomainLayer;
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
    public partial class ServiceCenter : Form
    {
        private Panel activePanel;
        private List<Jobs> jobs;
        private List<Clients> clients;

        public ServiceCenter()
        {
            InitializeComponent();
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            activePanel = pnlRequests;
            activePanel.Visible = true;
            tmrTime.Start();
            lblID.Text = Globals.StaffID;

            clients = new ClientTracker().GetClients();
            foreach (Clients item in clients)
            {
                cmbAllClients.Items.Add(item.ClientID + " " + item.Name);
            }
        }
    
        //Button clicks
        #region
        private void btnROD_Click(object sender, EventArgs e)
        {
            //Request on date

        }

        private void btnLatestReq_Click(object sender, EventArgs e)
        {
            //Latest Req

        }

        private void btnCReq_Click(object sender, EventArgs e)
        {
            //CLient Req

        }

        private void btnAReq_Click(object sender, EventArgs e)
        {
            //All Reqs
        }

        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            //View All Jobs
            DataTable table = new JobsCenter().GetJobs();
            dgvJobs.AutoGenerateColumns = true;
            dgvJobs.DataSource = table;
        }

        private void btnSchedJobs_Click(object sender, EventArgs e)
        {
            DataTable table = new JobsCenter().GetRequests();
            dgvJobs.AutoGenerateColumns = true;
            dgvJobs.DataSource = table;
        }

        #endregion
        //Fancy Animations
        #region
        private void btnRequests_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlRequests.Visible = true;
            activePanel = pnlRequests;
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlJobs.Visible = true;
            activePanel = pnlJobs;

            //pnlJobs.Visible = true;
            //pnlRequests.Visible = false;
        }
        #endregion
        //Other
        #region
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ServiceCenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
