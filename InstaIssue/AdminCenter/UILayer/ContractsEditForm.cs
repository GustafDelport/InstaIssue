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
    public partial class ContractsEditForm : Form
    {
        private List<SLA> SLAs;
        private SLA SLA;

        public ContractsEditForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.contractsEditForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ContractsEditForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            lblID.Text = Globals.StaffID;

            ContractsManagment contractsM = new ContractsManagment();
            SLAs = contractsM.GetListSLAs();

            foreach (var item in SLAs)
            {
                cmbSLAs.Items.Add(item.SLAID1 + " " + item.Name);
            }
        }

        private void txtNewData_Click(object sender, EventArgs e)
        {
            txtNewData.Text = "";
        }

        private void ContractsEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFindSLA_Click(object sender, EventArgs e)
        {
            string slaID = cmbSLAs.Text.Split(' ')[0];

            foreach (SLA item in SLAs)
            {
                if (item.SLAID1 == slaID)
                {
                    SLA = item;
                }
            }

            lblAName.Text = SLA.Name;
            lblADescription.Text = SLA.Description;
            lblATarif.Text = SLA.Tarif;
        }

        private void btnEditSLA_Click(object sender, EventArgs e)
        {
            switch (cmbData.Text)
            {
                case "Name":
                    {
                        SLA.Name = txtNewData.Text;
                    }
                    break;
                case "Description":
                    {
                        SLA.Description = txtNewData.Text;
                    }
                    break;
                case "Tarif":
                    {
                        SLA.Tarif = txtNewData.Text;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Please select data to edit in the drop down menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            bool flag = new ContractsManagment().EditSLA(SLA);

            if (flag)
            {
                MessageBox.Show("New SLA data was registered", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was a error updating SLA data", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
