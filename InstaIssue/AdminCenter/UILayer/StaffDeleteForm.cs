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

        private void btnDeleteSaff_Click(object sender, EventArgs e)
        {
            //NEEEEEEEEEEEEEEEEEEEEEEEE wie was die ?
            //StaffManagment staffmanagement = new StaffManagment();
            //staffmanagement.DeleteStaff(txtName.Text);
       
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.staffDeleteForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void StaffDeleteForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }
    }
}
