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

        public CallCenterForm()
        {
            InitializeComponent();
        }

        private void CallCenterForm_Load(object sender, EventArgs e)
        {
            imgStatus.Image = Properties.Resources.RedStatus;
            activePanel = pnlDash;
            activePanel.Visible = true;

            callStatus = true;
            CallTest();
        }

        //Methods
        #region
        public void BeginCall()
        {
            //Delegate goes here
        }

        public void EndCall()
        {
            //Delegate goes here
        }

        private void picPhoneButton_Click(object sender, EventArgs e)
        {
            CallTest();
        }

        #endregion

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

        public void CallTest()
        {
            if (callStatus)
            {
                picPhoneButton.Image = Properties.Resources.Awnser;
                imgStatus.Image = Properties.Resources.RedStatus;
                btnFind.Visible = false;
                txtNationalID.Visible = false;
                lblNationalID.Visible = false;
                picUserLarge.Visible = false;
                callStatus = false;
            }
            else
            {
                picPhoneButton.Image = Properties.Resources.End;
                imgStatus.Image = Properties.Resources.GreenStatus;
                btnFind.Visible = true;
                txtNationalID.Visible = true;
                lblNationalID.Visible = true;
                picUserLarge.Visible = true;
                callStatus = true;
            }
        }

        private void pnlClients_VisibleChanged(object sender, EventArgs e)
        {
            pnlAddClient.Visible = false;
            pnlJobs.Visible = false;
            pnlReqs.Visible = false;
            button6.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlAddClient.Visible = true;
            button3.Visible = false;
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            pnlReqs.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlJobs.Visible = true;
            button6.Visible = false;
        }

        private void btnTopTrackIss_Click(object sender, EventArgs e)
        {
            pnlTrackIssue.Visible = true;
            btnTopTrackIss.Visible = false;
        }

        private void btnTopAddIss_Click(object sender, EventArgs e)
        {
            pnlCreateIss.Visible = true;
            btnTopAddIss.Visible = false;
        }

        private void pnlIssues_VisibleChanged(object sender, EventArgs e)
        {
            pnlCreateIss.Visible = false;
            pnlTrackIssue.Visible = false;
            btnTopAddIss.Visible = true;
            btnTopTrackIss.Visible = true;
        }

        private void picOneStar_MouseHover(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.StarYellow;
        }

        private void picOneStar_MouseLeave(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.Star;
        }

        private void picTwoStar_MouseHover(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.StarYellow;
            picTwoStar.Image = Properties.Resources.StarYellow;
        }

        private void picTwoStar_MouseLeave(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.Star;
            picTwoStar.Image = Properties.Resources.Star;
        }

        private void picThreeStar_MouseHover(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.StarYellow;
            picTwoStar.Image = Properties.Resources.StarYellow;
            picThreeStar.Image = Properties.Resources.StarYellow;
        }

        private void picThreeStar_MouseLeave(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.Star;
            picTwoStar.Image = Properties.Resources.Star;
            picThreeStar.Image = Properties.Resources.Star;
        }

        private void picFourStar_MouseHover(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.StarYellow;
            picTwoStar.Image = Properties.Resources.StarYellow;
            picThreeStar.Image = Properties.Resources.StarYellow;
            picFourStar.Image = Properties.Resources.StarYellow;
        }

        private void picFourStar_MouseLeave(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.Star;
            picTwoStar.Image = Properties.Resources.Star;
            picThreeStar.Image = Properties.Resources.Star;
            picFourStar.Image = Properties.Resources.Star;
        }

        private void picFiveStar_MouseHover(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.StarYellow;
            picTwoStar.Image = Properties.Resources.StarYellow;
            picThreeStar.Image = Properties.Resources.StarYellow;
            picFourStar.Image = Properties.Resources.StarYellow;
            picFiveStar.Image = Properties.Resources.StarYellow;
        }

        private void picFiveStar_MouseLeave(object sender, EventArgs e)
        {
            picOneStar.Image = Properties.Resources.Star;
            picTwoStar.Image = Properties.Resources.Star;
            picThreeStar.Image = Properties.Resources.Star;
            picFourStar.Image = Properties.Resources.Star;
            picFiveStar.Image = Properties.Resources.Star;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlRev.Visible = true;
            button7.Visible = false;
        }

        private void pnlReviews_VisibleChanged(object sender, EventArgs e)
        {
            //pnlRev.Visible = false;
            //button7.Visible = true;
        }

        private void pnlReviews_VisibleChanged_1(object sender, EventArgs e)
        {
            pnlRev.Visible = false;
            button7.Visible = true;
        }
        #endregion

        //Button Clicks
        #region
        private void btnFind_Click(object sender, EventArgs e)
        {
            //Qury here
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Add Client
        }

        private void btnCreateReq_Click(object sender, EventArgs e)
        {
            //Create Req
        }

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            //Track Job

        }

        private void btnTrackIssue_Click(object sender, EventArgs e)
        {
            //Track Issues => take to info form
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            //Create Issue
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Create a Review
        }

        private void picOneStar_Click(object sender, EventArgs e)
        {
            //Event rating trigger
        }

        private void picTwoStar_Click(object sender, EventArgs e)
        {
            //Event rating trigger
        }

        private void picThreeStar_Click(object sender, EventArgs e)
        {
            //Event rating trigger
        }

        private void picFourStar_Click(object sender, EventArgs e)
        {
            //Event rating trigger
        }

        private void picFiveStar_Click(object sender, EventArgs e)
        {
            //Event rating trigger
        }
        #endregion
    }
}
