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
    public partial class ClientsViewForm : Form
    {
        public ClientsViewForm()
        {
            InitializeComponent();
        }

        private void ClientsViewForm_Load(object sender, EventArgs e)
        {

        }

        public void ViewAllClients() { }

        public void ViewClients() { }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.clientsViewForm.Hide();
            Globals.AdminCenterForm.Show();
        }
    }
}
