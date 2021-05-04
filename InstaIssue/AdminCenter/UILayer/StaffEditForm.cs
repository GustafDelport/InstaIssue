﻿using System;
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
    public partial class StaffEditForm : Form
    {

        //Not hide the below panel then return a staff entity and populate relavent data and use that to edit staff

        public StaffEditForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.staffEditForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void StaffEditForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        private void txtNewData_Click(object sender, EventArgs e)
        {
            txtNewData.Text = "";
        }

        private void txtStaffID_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
        }
    }
}
