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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.callCenterForm.Show();
            Globals.informationForm.Hide();
        }

        //Fancy animations
        #region
        #endregion
    }
}
