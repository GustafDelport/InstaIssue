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
        public ServiceCenter()
        {
            InitializeComponent();
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            activePanel = pnlRequests;
            activePanel.Visible = true;
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
        }
        #endregion
    }
}
