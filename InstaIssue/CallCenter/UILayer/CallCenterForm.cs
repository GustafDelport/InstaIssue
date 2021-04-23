using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.CallCenter.UILayer
{
    public partial class CallCenterForm : Form
    {
        private String staffID;
        private Clients client;
        private String Status;
        private Boolean callStatus;
        private Panel activePanel;

        private delegate void CallEvent();

        public CallCenterForm()
        {
            InitializeComponent();
        }

        private void CallCenterForm_Load(object sender, EventArgs e)
        {
            imgStatus.Image = Properties.Resources.RedStatus;
            activePanel = pnlDash;
            activePanel.Visible = true;

            callStatus = false;
            CallTest();
        }

        public void BeginCall()
        {
            //Delegate goes here
        }

        public void EndCall()
        {
            //Delegate goes here
        }

        public void LogIssue(Clients client, String staffID, String status)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void LogSatisfaction(String staffID)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void LogRequest(DateTime plannedDate,DateTime deadlineDate)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void TrackClient(String nationalID)
        {

        }

        public void TrackClientJobs(String nationalID)
        {

        }
        public void TrackClientIssue(String nationalID)
        {

        }
        public void RegisterNewClient()
        {
            //Add fields later in param
        }

        //Fancy Animations

        #region

        private void label6_MouseHover(object sender, EventArgs e)
        {
            lblID.Font = new Font("Arial", 13);
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            lblID.Font = new Font("Century Gothic", 12);
        }
        #endregion

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlReviews.Visible = true;
            activePanel = pnlReviews;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlDash.Visible = true;
            activePanel = pnlDash;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlClients.Visible = true;
            activePanel = pnlClients;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            callStatus = false;
            CallTest();
            imgStatus.Image = Properties.Resources.RedStatus;
        }

        private void picGreenPhone_Click(object sender, EventArgs e)
        {
            callStatus = true;
            CallTest();
            imgStatus.Image = Properties.Resources.GreenStatus;
        }

        public void CallTest()
        {
            if (callStatus)
            {
                picRedPhone.Visible = true;
                picGreenPhone.Visible = false;
            }
            else
            {
                picGreenPhone.Visible = true;
                picRedPhone.Visible = false;
            }
        }
    }
}
