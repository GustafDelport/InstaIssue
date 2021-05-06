using InstaIssue.CallCenter.LogicLayer;
using InstaIssue.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.CallCenter.UILayer
{
    public partial class Information : Form
    {
        private SqlDataReader reader;
        public Information()
        {
            InitializeComponent();
            
        }

        private void Information_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.callCenterForm.Show();
            Globals.informationForm.Hide();
        }

        //Fancy animations
        #region
        #endregion
        
        public void SeeIssues(string clietID)
        {
            reader = new GeneralHandler().GetData(clietID, "tblissues", "clientID");
            //Read dat from here
            DataTable table = new DataTable();
            table.Load(reader);

            dgvData.AutoGenerateColumns = true;
            dgvData.DataSource = table;
            dgvData.Refresh();
        }

        public void SeeJobs(string clietID)
        {
            reader = new GeneralHandler().GetData(clietID, "tbljobs", "clientID");
            //Read dat from here
            DataTable table = new DataTable();
            table.Load(reader);

            dgvData.AutoGenerateColumns = true;
            dgvData.DataSource = table;
            dgvData.Refresh();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
