
namespace InstaIssue.CallCenter.UILayer
{
    partial class CallCenterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallCenterForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCContract = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.imgStatus = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.pnlLogo);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(159, 530);
            this.pnlControls.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.DimGray;
            this.pnlLogo.Controls.Add(this.imgLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(157, 81);
            this.pnlLogo.TabIndex = 1;
            // 
            // imgLogo
            // 
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgLogo.Image = global::InstaIssue.Properties.Resources.Logo;
            this.imgLogo.Location = new System.Drawing.Point(39, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(78, 78);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCID.ForeColor = System.Drawing.Color.White;
            this.lblCID.Location = new System.Drawing.Point(5, 8);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(63, 17);
            this.lblCID.TabIndex = 2;
            this.lblCID.Text = "Client ID";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.pnlSeperator);
            this.pnlInfo.Controls.Add(this.lblContract);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Controls.Add(this.lblID);
            this.pnlInfo.Controls.Add(this.lblCContract);
            this.pnlInfo.Controls.Add(this.lblCName);
            this.pnlInfo.Controls.Add(this.imgStatus);
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Controls.Add(this.lblCID);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(159, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(768, 81);
            this.pnlInfo.TabIndex = 3;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.White;
            this.pnlSeperator.Location = new System.Drawing.Point(122, 8);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(10, 52);
            this.pnlSeperator.TabIndex = 0;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContract.ForeColor = System.Drawing.Color.White;
            this.lblContract.Location = new System.Drawing.Point(138, 43);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(40, 17);
            this.lblContract.TabIndex = 11;
            this.lblContract.Text = "Gold";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(138, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Gustaf Delport";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(138, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "0004175144080";
            this.lblID.MouseLeave += new System.EventHandler(this.lblID_MouseLeave);
            this.lblID.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // lblCContract
            // 
            this.lblCContract.AutoSize = true;
            this.lblCContract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCContract.ForeColor = System.Drawing.Color.White;
            this.lblCContract.Location = new System.Drawing.Point(5, 43);
            this.lblCContract.Name = "lblCContract";
            this.lblCContract.Size = new System.Drawing.Size(109, 17);
            this.lblCContract.TabIndex = 8;
            this.lblCContract.Text = "Client Contract";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCName.ForeColor = System.Drawing.Color.White;
            this.lblCName.Location = new System.Drawing.Point(5, 25);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(90, 17);
            this.lblCName.TabIndex = 7;
            this.lblCName.Text = "Client Name";
            // 
            // imgStatus
            // 
            this.imgStatus.Image = global::InstaIssue.Properties.Resources.GreenStatus;
            this.imgStatus.Location = new System.Drawing.Point(402, 25);
            this.imgStatus.Name = "imgStatus";
            this.imgStatus.Size = new System.Drawing.Size(25, 25);
            this.imgStatus.TabIndex = 6;
            this.imgStatus.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(635, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "2021-04-17";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(635, 43);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "14:23";
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(159, 81);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(768, 449);
            this.pnlBody.TabIndex = 4;
            // 
            // CallCenterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(927, 530);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlControls);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CallCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Center";
            this.Load += new System.EventHandler(this.CallCenterForm_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox imgStatus;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCContract;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Panel pnlSeperator;
    }
}