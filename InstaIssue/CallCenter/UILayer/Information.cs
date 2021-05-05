using InstaIssue.Handlers;
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
        public Information()
        {
            InitializeComponent();
            
        }

        private void Information_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.callCenterForm.Show();
            Globals.informationForm.Hide();
        }

        //Fancy animations
        #region
        #endregion

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }
    }
}
