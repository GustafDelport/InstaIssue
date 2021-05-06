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
    public partial class StaffAddForm : Form
    {
        public StaffAddForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.staffAddForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void StaffAddForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        //Fancy Animations
        #region
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Text = "";
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
        }

        #endregion

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
