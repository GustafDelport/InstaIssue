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
    public partial class ClientsAddForm : Form
    {
        public ClientsAddForm()
        {
            InitializeComponent();
        }

        private void ClientsAddForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsAddForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
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

        private void txtNatID_Click(object sender, EventArgs e)
        {
            txtNatID.Text = "";

        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";

        }

        #endregion
    }
}
