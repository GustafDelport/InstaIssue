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
    public partial class StaffEditForm : Form
    {

        //Not hide the below panel then return a staff entity and populate relavent data and use that to edit staff
        private List<Staff> Lstaff;
        private Staff staff;

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
            lblID.Text = Globals.StaffID;
            StaffManagment staffM = new StaffManagment();
            Lstaff = staffM.GetLstaff();
            foreach (var item in Lstaff)
            {
                cmbStaff.Items.Add(item.StaffID + " " + item.Name);
            }
        }

        private void txtNewData_Click(object sender, EventArgs e)
        {
            txtNewData.Text = "";
        }

        private void StaffEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            string staffID = cmbStaff.Text.Split(' ')[0];

            foreach (Staff item in Lstaff)
            {
                if (item.StaffID == staffID)
                {
                    staff = item;
                }
            }

            lblAName.Text = staff.Name;
            lblASurname.Text = staff.Surname;
            lblAStatus.Text = staff.Status;
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            switch (cmbData.Text)
            {
                case "Name":
                    {
                        staff.Name = txtNewData.Text;
                    }
                    break;
                case "Surname":
                    {
                        staff.Surname = txtNewData.Text;
                    }
                    break;
                case "Status":
                    {
                        staff.Status = txtNewData.Text;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Please select data to edit in the drop down menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            bool flag = new StaffManagment().EditStaff(staff);

            if (flag)
            {
                MessageBox.Show("New Staff data was registered", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was a error updating Staff data", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
