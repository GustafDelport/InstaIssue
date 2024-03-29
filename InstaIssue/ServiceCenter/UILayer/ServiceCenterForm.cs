﻿using InstaIssue.AdminCenter.DomainLayer;
using InstaIssue.AdminCenter.LogicLayer;
using InstaIssue.CallCenter.DomainLayer;
using InstaIssue.CallCenter.LogicLayer;
using InstaIssue.ServiceCenter.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InstaIssue;

namespace InstaIssue.AdminCenter.UILayer
{
    public partial class ServiceCenterForm : Form
    {
        private Panel activePanel;
        private List<Jobs> jobs;
        private List<Clients> clients;

        public ServiceCenterForm()
        {
            InitializeComponent();
        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {
            activePanel = pnlRequests;
            activePanel.Visible = true;
            tmrTime.Start();
            lblID.Text = Globals.StaffID;

            clients = new ClientTracker().GetClients();
            foreach (Clients item in clients)
            {
                cmbAllClients.Items.Add(item.ClientID + " " + item.Name);
            }
        }

        //Button clicks
        #region

        //Data Views
        #region
        private void btnROD_Click(object sender, EventArgs e)
        {
            //Request on date
            DateTime date = dtpDate.Value;
            DataTable table = new RequestTracker().GetRequestsOnDate(date);
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = table;
        }

        private void btnLatestReq_Click(object sender, EventArgs e)
        {
            //Latest Req
            DataTable table = new RequestTracker().GetLatestRequests();
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = table;
        }

        private void btnCReq_Click(object sender, EventArgs e)
        {
            //CLient Req
            string clientID = cmbAllClients.Text.Split(' ')[0];

            DataTable table = new RequestTracker().GetRequestsByClient(clientID);
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = table;
        }

        private void btnAReq_Click(object sender, EventArgs e)
        {
            DataTable table = new RequestTracker().GetRequests();
            dgvRequests.AutoGenerateColumns = true;
            dgvRequests.DataSource = table;
        }

        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            //View All Jobs
            DataTable table = new JobsCenter().GetJobs();
            dgvJobs.AutoGenerateColumns = true;
            dgvJobs.DataSource = table;
        }

        #endregion

        private void btnSchedJobs_Click(object sender, EventArgs e)
        {
            //Schedule reqs
            bool flag = new RequestScheduler().ScheduleRequests();

            if (flag)
            {
                MessageBox.Show("All currect requests have been scheduled","Schedulation Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Either there are no requests or an unforseen error has occured", "Schedulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        //Fancy Animations
        #region
        private void btnRequests_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlRequests.Visible = true;
            activePanel = pnlRequests;
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlJobs.Visible = true;
            activePanel = pnlJobs;

            //pnlJobs.Visible = true;
            //pnlRequests.Visible = false;
        }
        #endregion

        //Other
        #region
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ServiceCenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
