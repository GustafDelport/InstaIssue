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
    public partial class AdminCenterForm : Form
    {
        private String staffID;
        private Panel activePanel;

        public AdminCenterForm()
        {
            InitializeComponent();
        }

        private void AdminCenterForm_Load(object sender, EventArgs e)
        {
            activePanel = pnlIssues;
            activePanel.Visible = true;
            tmrTime.Start();
        }

        //Fancy Animations
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;
        }

        private void btnMngClients_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlClients.Visible = true;
            activePanel = pnlClients;
        }

        private void btnMngStaff_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlStaff.Visible = true;
            activePanel = pnlStaff;
        }

        private void btnMngContracts_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlContracts.Visible = true;
            activePanel = pnlContracts;
        }
        #endregion

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }
    }
}
