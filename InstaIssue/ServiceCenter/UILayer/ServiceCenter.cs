using InstaIssue.AdminCenter.DomainLayer;
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
        private String staffID;
        private Panel activePanel;
        private List<Jobs> jobs;

        public ServiceCenter()
        {
            InitializeComponent();
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            activePanel = pnlRequests;
            activePanel.Visible = true;
            tmrTime.Start();
        }

        public void GetAllRequest()
        {

        }

        public void ViewRequestOnDate()
        {

        }

        public void ViewClientRequests()
        {

        }

        public void ScheduleAllJobs()
        {

        }

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
        }

        private void btnSchedJobs_Click(object sender, EventArgs e)
        {
            //Schedule Jobs
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void pnlJobs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
