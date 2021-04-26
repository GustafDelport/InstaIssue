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
        }

        public void TrackIssues()
        {

        }

        public void StaffControls()
        {

        }
        public void ClientControls()
        {

        }
        public void ContractControls()
        {

        }

        //Fancy Animations
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            pnlIssues.Visible = true;
            activePanel = pnlIssues;
        }
        #endregion
    }
}
