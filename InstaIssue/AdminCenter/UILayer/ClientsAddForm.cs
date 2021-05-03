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

        }

        public void AddClient() { }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsAddForm.Hide();
            Globals.AdminCenterForm.Show();
        }
    }
}
