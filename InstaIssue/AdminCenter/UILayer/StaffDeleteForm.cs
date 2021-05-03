using InstaIssue.AdminCenter.LogicLayer;
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
    public partial class StaffDeleteForm : Form
    {
        public StaffDeleteForm()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteSaff_Click(object sender, EventArgs e)
        {
            StaffManagment staffmanagement = new StaffManagment();
            staffmanagement.DeleteStaff(txtName.Text);
       
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.staffDeleteForm.Hide();
            Globals.AdminCenterForm.Show();
        }
    }
}
