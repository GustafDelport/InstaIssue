using Authentication;
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
            lblID.Text = Globals.StaffID;
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

            bool flag = new Validations().ValidateStaffRegister(pnlAddStaff);
            if (flag)
            {
                flag = new StaffManagment().AddStaff(txtName.Text, txtSurname.Text, cmbSkills.Text, txtAddress.Text, txtUsername.Text, txtPassword.Text);
                if (flag)
                {
                    MessageBox.Show("Staff was added succesfully", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Staff was not added succesfully", "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StaffAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
