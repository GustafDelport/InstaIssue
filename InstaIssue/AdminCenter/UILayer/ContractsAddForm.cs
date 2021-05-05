using Authentication;
using InstaIssue.AdminCenter.LogicLayer;
using System;
using System.Windows.Forms;

namespace InstaIssue.AdminCenter.UILayer
{
    public partial class ContractsAddForm : Form
    {
        public ContractsAddForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Globals.contractsAddForm.Hide();
            Globals.AdminCenterForm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void ContractsAddForm_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void textTarif_Click(object sender, EventArgs e)
        {
            txtTarif.Text = "";
        }

        private void btnAddSLA_Click(object sender, EventArgs e)
        {
            ContractsManagment managment = new ContractsManagment();
            Validations validation = new Validations();
            Boolean flag = validation.validateSLACreation(pnlAddSLA);

            String name = txtName.Text;
            String descrip = rtbDescription.Text;
            String tarif = txtTarif.Text;
            String code = cmbType.Text + "," + cmbImportance.Text;

            if (flag)
            {
                flag = managment.AddSLA(name,descrip,tarif,code);
                if (flag)
                {
                    MessageBox.Show("A new SLA was registered", "Creation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create SLA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //ResetBoxes();
                }
            }
            else
            {
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
