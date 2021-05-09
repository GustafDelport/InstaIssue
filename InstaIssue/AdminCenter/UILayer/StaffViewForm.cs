using InstaIssue.AdminCenter.DomainLayer;
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
    public partial class StaffViewForm : Form
    {
        private List<Staff> staff;

        public StaffViewForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.AdminCenterForm.Show();
            Globals.staffViewForm.Hide();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void StaffViewForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            lblID.Text = Globals.StaffID;
            StaffManagment staffM = new StaffManagment();
            staff = staffM.GetAllStaff();
            foreach (var item in staff)
            {
                cmbStaffAll.Items.Add(item.StaffID + " " + item.Name);
            }
        }

        private void StaffViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewIDStaff_Click(object sender, EventArgs e)
        {
            string staffID = cmbStaffAll.Text.Split(' ')[0];

            dgvStaff.DataSource = new StaffManagment().GetStaff(staffID);
        }

        private void btnViewAllStaff_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            List<Staff> staffs = new StaffManagment().GetAllStaff();

            //Rework this
            foreach (Staff item in staffs)
            {
                data.Rows.Add(item);
            }
            dgvStaff.AutoGenerateColumns = true;
            dgvStaff.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Look at this
        }
    }
}
