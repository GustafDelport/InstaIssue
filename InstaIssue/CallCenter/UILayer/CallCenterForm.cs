using InstaIssue.CallCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaIssue.CallCenter.UILayer
{
    public partial class CallCenterForm : Form
    {
        private String staffID;
        private Clients client;
        private String Status;

        public CallCenterForm()
        {
            InitializeComponent();
        }

        private void CallCenterForm_Load(object sender, EventArgs e)
        {

        }

        public void BeginCall()
        {
            //Delegate goes here
        }

        public void EndCall()
        {
            //Delegate goes here
        }

        public void LogIssue(Clients client, String staffID, String status)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void LogSatisfaction(String staffID)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void LogRequest(DateTime plannedDate,DateTime deadlineDate)
        {
            //Use client.prop to pass data becuase CLients is not public
        }

        public void TrackClient(String nationalID)
        {

        }

        public void TrackClientJobs(String nationalID)
        {

        }
        public void TrackClientIssue(String nationalID)
        {

        }
        public void RegisterNewClient()
        {
            //Add fields later in param
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            lblID.Font = new Font("Arial", lblID.Font.Size+1);
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            lblID.Font = new Font("Century Gothic", lblID.Font.Size);
        }
    }
}
