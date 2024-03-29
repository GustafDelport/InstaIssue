﻿using InstaIssue.CallCenter.DomainLayer;
using System;
using Authentication;
using System.Drawing;
using System.Windows.Forms;
using InstaIssue.CallCenter.LogicLayer;
using System.Collections.Generic;
using InstaIssue.Handlers;
using InstaIssue.AdminCenter.LogicLayer;
using InstaIssue.AdminCenter.DomainLayer;

namespace InstaIssue.CallCenter.UILayer
{
    public partial class CallCenterForm : Form
    {
        private Clients client;
        private bool callStatus;
        private Panel activePanel;
        private bool flag;
        private List<String> SLAlist;
        private readonly Validations validations = new Validations();
        private List<Jobs> jobs;
        private List<Products> products; 
        private List<Contracts> contracts;
        private DateTime beginCallStamp;
        private DateTime endCallStamp;

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

            //Load all contracts in cmb
            SLAlist = new PopulationHandler().GetSla();
            foreach (string item in SLAlist)
            {
                cmbContractsC.Items.Add(item);
            }       
        }

        //Methods
        #region
        private void picPhoneButton_Click(object sender, EventArgs e)
        {
            //Set timestamps here
            if (!callStatus)
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                beginCallStamp = DateTime.Parse(time);
            }
            else
            {
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                endCallStamp = DateTime.Parse(time);
                bool tFlag = new GeneralHandler().CreateCallLog(client.ClientID, Globals.StaffID, beginCallStamp, endCallStamp);
                if (tFlag)
                {
                    MessageBox.Show("The Call was logged", "Log Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Call was not logged", "Log Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

            if (client != null)
            {
                Refresher();
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlClients.Visible = true;
            activePanel = pnlClients;

            if (client != null)
            {
                Refresher();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;

            if (client != null)
            {
                Refresher();
            }
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

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlNewProd.Visible = true;
            activePanel = pnlNewProd;

            if (client != null)
            {
                Refresher();
            }
        }

        private void txtProdName_Click(object sender, EventArgs e)
        {
            txtProdName.Text = "";
        }

        private void txtSerial_Click(object sender, EventArgs e)
        {
            txtSerial.Text = "";
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
                    lblName.Text = client.Name;
                    lblID.Text = client.NationalID;
                    lblContract.Text = new ClientTracker().GetClientContract(client.ClientID);
                }
                //Now we have access to client aslong as the instace is open
                activePanel.Visible = false;
                pnlClients.Visible = true;
                activePanel = pnlClients;
            }
            else
            {
                MessageBox.Show("The ID entered is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNationalID.Text = "";
            products = new ClientTracker().GetClientProducts(client.ClientID);

            foreach (var item in products)
            {
                cmbProducts.Items.Add(item.Name);
            }
            jobs = new ClientTracker().GetClientJobs(client.ClientID);

            foreach (var item in jobs)
            {
                cmbJobs.Items.Add(item.Service);
            }
            contracts = new ClientTracker().GetClientContracts(client.ClientID);

            foreach (var item in contracts)
            {
                cmbNewCont.Items.Add(item.ContractID + " " + item.SLAID1);
            }
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
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            flag = true;

            if (flag)
            {
                flag = new RegisterClient().RegisterNewClient(name, surname, natID, phone, eMail, address, SLA, username, password);
                if (flag)
                {
                    MessageBox.Show("A new client was registered", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add client", "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Panel ClientPanel = pnlReqs;

            //Major validations happen here
            flag = validations.validateReqCreation(ClientPanel);

            String name = txtName.Text;
            DateTime planedDate = dtpPlannedDate.Value;
            DateTime deadlineDate = dtpDeadlineDate.Value;
            string service = cmbService.Text;

            flag = true;

            if (flag)
            {
                flag = new GeneralHandler().CreateReq(client.ClientID, planedDate, deadlineDate,service);
                if (flag)
                {
                    MessageBox.Show("A new request was registered", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add request", "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBoxes();
                }

            }
            else
            {
                ResetBoxes();
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            //Create Issue
            flag = true;
            string description = rtbDescription.Text;
            DateTime dateReported = new DateTime();
            dateReported = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            if (flag)
            {
                flag = new IssuesCenter().CreateIssue(client, dateReported, Globals.StaffID, "Ongoing", description);
                if (flag)
                {
                    MessageBox.Show("A new issue was registered", "Creation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBoxes();
                }
            }
            else
            {
                ResetBoxes();
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddNewProd_Click(object sender, EventArgs e)
        {
            Panel ProductsPanel = pnlNewProd;

            //Major validations happen here
            flag = validations.validateReqCreation(ProductsPanel);

            String name = txtProdName.Text;
            String serial = txtSerial.Text;

            String[] arr = cmbNewCont.Text.Split(' ');

            String contractID = arr[0];
            string slaID = arr[1];

            DateTime ExpDate = dtpWarDate.Value;

            flag = true;

            if (flag)
            {
                flag = new GeneralHandler().CreateProd(name, serial, contractID, client.ClientID, ExpDate);
                if (flag)
                {
                    MessageBox.Show("A new client product was registered", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add client product", "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetBoxes();
                }

            }
            else
            {
                ResetBoxes();
                MessageBox.Show("A mistake was made when entering details please try again", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrackJob_Click(object sender, EventArgs e)
        {
            //Track Job
            Globals.informationForm.Show();
            Globals.callCenterForm.Hide();
            Globals.informationForm.SeeJobs(client.ClientID);

        }

        private void btnTrackIssue_Click(object sender, EventArgs e)
        {
            //Track Issues => take to info form
            Globals.informationForm.Show();
            Globals.callCenterForm.Hide();
            Globals.informationForm.SeeIssues(client.ClientID);
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

        private void CallCenterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Refresher()
        {
            cmbProducts.Items.Clear();
            cmbJobs.Items.Clear();
            cmbNewCont.Items.Clear();

            products = new ClientTracker().GetClientProducts(client.ClientID);
            foreach (var item in products)
            {
                cmbProducts.Items.Add(item.Name);
            }

            jobs = new ClientTracker().GetClientJobs(client.ClientID);
            foreach (var item in jobs)
            {
                cmbJobs.Items.Add(item.Service);
            }

            contracts = new ClientTracker().GetClientContracts(client.ClientID);
            foreach (var item in contracts)
            {
                cmbNewCont.Items.Add(item.ContractID + " " + item.SLAID1);
            }
        }
    }
}
