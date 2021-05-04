using InstaIssue.CallCenter.DomainLayer;
using System;
using Authentication;
using System.Drawing;
using System.Windows.Forms;
using InstaIssue.CallCenter.LogicLayer;

namespace InstaIssue.CallCenter.UILayer
{
    public partial class CallCenterForm : Form
    {
        private String staffID;
        private Clients client;
        private String Status;
        private Boolean callStatus;
        private Panel activePanel;
        private bool flag;
        private readonly Validations validations = new Validations();


        public CallCenterForm()
        {
            InitializeComponent();
        }

        private void CallCenterForm_Load(object sender, EventArgs e)
        {
            imgStatus.Image = Properties.Resources.RedStatus;
            activePanel = pnlDash;
            activePanel.Visible = true;

            callStatus = true;
            CallTest();
            tmrTime.Start();
            //Data loading here

        }

        //Methods
        #region
        public void BeginCall()
        {
            //Delegate goes here
        }

        public void EndCall()
        {
            //Delegate goes here
        }

        private void picPhoneButton_Click(object sender, EventArgs e)
        {
            CallTest();
        }

        #endregion

        //Fancy Animations
        #region

        private void label6_MouseHover(object sender, EventArgs e)
        {
            lblID.Font = new Font("Arial", 13);
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            lblID.Font = new Font("Century Gothic", 12);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlDash.Visible = true;
            activePanel = pnlDash;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlClients.Visible = true;
            activePanel = pnlClients;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;
        }

        public void CallTest()
        {
            if (callStatus)
            {
                picPhoneButton.Image = Properties.Resources.Awnser;
                imgStatus.Image = Properties.Resources.RedStatus;
                btnFind.Visible = false;
                txtNationalID.Visible = false;
                lblNationalID.Visible = false;
                picUserLarge.Visible = false;
                callStatus = false;
            }
            else
            {
                picPhoneButton.Image = Properties.Resources.End;
                imgStatus.Image = Properties.Resources.GreenStatus;
                btnFind.Visible = true;
                txtNationalID.Visible = true;
                lblNationalID.Visible = true;
                picUserLarge.Visible = true;
                callStatus = true;
            }
        }

        private void pnlClients_VisibleChanged(object sender, EventArgs e)
        {
            pnlAddClient.Visible = false;
            pnlJobs.Visible = false;
            pnlReqs.Visible = false;
            button6.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlAddClient.Visible = true;
            button3.Visible = false;
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            pnlReqs.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlJobs.Visible = true;
            button6.Visible = false;
        }

        private void btnTopTrackIss_Click(object sender, EventArgs e)
        {
            pnlTrackIssue.Visible = true;
            btnTopTrackIss.Visible = false;
        }

        private void btnTopAddIss_Click(object sender, EventArgs e)
        {
            pnlCreateIss.Visible = true;
            btnTopAddIss.Visible = false;
        }

        private void pnlIssues_VisibleChanged(object sender, EventArgs e)
        {
            pnlCreateIss.Visible = false;
            pnlTrackIssue.Visible = false;
            btnTopAddIss.Visible = true;
            btnTopTrackIss.Visible = true;
        }

        public void ResetBoxes()
        {
            txtName.Text = "Name";
            txtSurname.Text = "Surname";
            txtNatID.Text = "National ID";
            txtPhone.Text = "Phone Number";
            txtEmail.Text = "Email";
            txtAddress.Text = "Address";
        }
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

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            //Track Job
            Globals.informationForm.Show();
            Globals.callCenterForm.Hide();
        }

        private void btnTrackIssue_Click(object sender, EventArgs e)
        {
            //Track Issues => take to info form
            Globals.informationForm.Show();
            Globals.callCenterForm.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Globals.serviceCenterForm.Show();
            Globals.callCenterForm.Hide();
        }
        #endregion

        //Button Clicks
        #region
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (validations.ValidateID(txtNationalID.Text))
            {
                //Validate if ID is a valid ID
                Globals.nationalID = txtNationalID.Text;

                //Now we find the client
                client = new ClientTracker().GetClient(Globals.nationalID);

                if (client == null)
                {
                    MessageBox.Show("The client does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Client Found", "The ID entered is correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Now we have access to client aslong as the instace is open
                activePanel.Visible = false;
                pnlClients.Visible = true;
                activePanel = pnlClients;

                lblName.Text = client.Name;
                lblID.Text = client.NationalID;
                //Add Contract Tracker later
            }
            else
            {
                MessageBox.Show("The ID entered is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNationalID.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Validate if the text is correct!
            Panel ClientPanel = pnlAddClient;

            //Major validations happen here
            flag = validations.ValidateRegisterClient(ClientPanel);

            String name = txtName.Text;
            String surname = txtSurname.Text;
            String natID = txtNatID.Text;
            String phone = txtPhone.Text;
            String eMail = txtEmail.Text;
            String address = txtAddress.Text;
            String SLA = cmbContractsC.Text;

            flag = true;

            if (flag)
            {
                flag = new RegisterClient().RegisterNewClient(name, surname, natID, phone, eMail, address, SLA);
                if (flag)
                {
                    MessageBox.Show("A new client was registered", "Addidtion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add client", "Addidtion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBoxes();
                }
                
            }
            else
            {
                ResetBoxes();
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCreateReq_Click(object sender, EventArgs e)
        {
            //Create Req
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            //Create Issue
        }
        #endregion

        //Other
        #region


        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("T");
        }
        #endregion
    }
}
