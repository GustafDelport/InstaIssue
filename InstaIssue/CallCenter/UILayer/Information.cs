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
    public partial class Information : Form
    {

        private Panel activePanel;

        public Information()
        {
            InitializeComponent();
            activePanel = pnlBlank;
            activePanel.Visible = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.callCenterForm.Show();
            Globals.informationForm.Hide();

            activePanel.Visible = false;
            pnlBlank.Visible = true;
            activePanel = pnlBlank;
        }

        //Fancy animations
        #region
        private void button2_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlReviews.Visible = true;
            activePanel = pnlReviews;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;
        }
        #endregion
    }
}
