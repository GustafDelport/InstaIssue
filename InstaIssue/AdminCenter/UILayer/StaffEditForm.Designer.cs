
namespace InstaIssue.AdminCenter.UILayer
{
    partial class StaffEditForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlEditStaff = new System.Windows.Forms.Panel();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnFindStaff = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblAStatus = new System.Windows.Forms.Label();
            this.lblASurname = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.cmbData = new MetroFramework.Controls.MetroComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlEditStaff.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlSeperator);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblCID);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 81);
            this.panel2.TabIndex = 7;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.White;
            this.pnlSeperator.Location = new System.Drawing.Point(152, 12);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(10, 22);
            this.pnlSeperator.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(168, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 21);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "JA0221";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCID.Location = new System.Drawing.Point(8, 12);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(67, 21);
            this.lblCID.TabIndex = 14;
            this.lblCID.Text = "Staff ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(635, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "2021-04-17";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(635, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 24);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "14:23";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 512);
            this.panel1.TabIndex = 6;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashboard.Image = global::InstaIssue.Properties.Resources.Home;
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(159, 82);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.imgLogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 81);
            this.panel4.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgLogo.Image = global::InstaIssue.Properties.Resources.LogoGreen;
            this.imgLogo.Location = new System.Drawing.Point(40, 1);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(78, 78);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlEditStaff
            // 
            this.pnlEditStaff.Controls.Add(this.txtStaffID);
            this.pnlEditStaff.Controls.Add(this.btnFindStaff);
            this.pnlEditStaff.Location = new System.Drawing.Point(419, 87);
            this.pnlEditStaff.Name = "pnlEditStaff";
            this.pnlEditStaff.Size = new System.Drawing.Size(193, 139);
            this.pnlEditStaff.TabIndex = 10;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaffID.Location = new System.Drawing.Point(16, 21);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(159, 22);
            this.txtStaffID.TabIndex = 7;
            this.txtStaffID.Text = "Staff ID";
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStaffID.Click += new System.EventHandler(this.txtStaffID_Click);
            // 
            // btnFindStaff
            // 
            this.btnFindStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindStaff.FlatAppearance.BorderSize = 0;
            this.btnFindStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnFindStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnFindStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFindStaff.Image = global::InstaIssue.Properties.Resources.TrackB;
            this.btnFindStaff.Location = new System.Drawing.Point(16, 49);
            this.btnFindStaff.Name = "btnFindStaff";
            this.btnFindStaff.Size = new System.Drawing.Size(159, 82);
            this.btnFindStaff.TabIndex = 8;
            this.btnFindStaff.Text = "Find Staff";
            this.btnFindStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFindStaff.UseVisualStyleBackColor = true;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lblAStatus);
            this.pnlEdit.Controls.Add(this.lblASurname);
            this.pnlEdit.Controls.Add(this.lblAName);
            this.pnlEdit.Controls.Add(this.lblStatus);
            this.pnlEdit.Controls.Add(this.pnlSep);
            this.pnlEdit.Controls.Add(this.lblSurname);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.lblCV);
            this.pnlEdit.Controls.Add(this.txtNewData);
            this.pnlEdit.Controls.Add(this.btnEditStaff);
            this.pnlEdit.Controls.Add(this.cmbData);
            this.pnlEdit.Location = new System.Drawing.Point(327, 232);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(376, 268);
            this.pnlEdit.TabIndex = 11;
            // 
            // lblAStatus
            // 
            this.lblAStatus.AutoSize = true;
            this.lblAStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAStatus.Location = new System.Drawing.Point(124, 112);
            this.lblAStatus.Name = "lblAStatus";
            this.lblAStatus.Size = new System.Drawing.Size(22, 21);
            this.lblAStatus.TabIndex = 22;
            this.lblAStatus.Text = "...";
            // 
            // lblASurname
            // 
            this.lblASurname.AutoSize = true;
            this.lblASurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblASurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblASurname.Location = new System.Drawing.Point(124, 79);
            this.lblASurname.Name = "lblASurname";
            this.lblASurname.Size = new System.Drawing.Size(22, 21);
            this.lblASurname.TabIndex = 21;
            this.lblASurname.Text = "...";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAName.Location = new System.Drawing.Point(124, 49);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(22, 21);
            this.lblAName.TabIndex = 20;
            this.lblAName.Text = "...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(13, 112);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 21);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // pnlSep
            // 
            this.pnlSep.BackColor = System.Drawing.Color.White;
            this.pnlSep.Location = new System.Drawing.Point(108, 53);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(10, 80);
            this.pnlSep.TabIndex = 18;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(13, 79);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 21);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(13, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCV.Location = new System.Drawing.Point(11, 16);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(125, 21);
            this.lblCV.TabIndex = 15;
            this.lblCV.Text = "Current Values";
            // 
            // txtNewData
            // 
            this.txtNewData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewData.Location = new System.Drawing.Point(248, 53);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(119, 27);
            this.txtNewData.TabIndex = 10;
            this.txtNewData.Text = "New Data";
            this.txtNewData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewData.Click += new System.EventHandler(this.txtNewData_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnEditStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditStaff.Image = global::InstaIssue.Properties.Resources.TrackB;
            this.btnEditStaff.Location = new System.Drawing.Point(117, 177);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(159, 82);
            this.btnEditStaff.TabIndex = 9;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            // 
            // cmbData
            // 
            this.cmbData.FormattingEnabled = true;
            this.cmbData.ItemHeight = 23;
            this.cmbData.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Status"});
            this.cmbData.Location = new System.Drawing.Point(248, 18);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(119, 29);
            this.cmbData.TabIndex = 0;
            this.cmbData.UseSelectable = true;
            // 
            // StaffEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(926, 512);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlEditStaff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StaffEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffEditForm_FormClosed);
            this.Load += new System.EventHandler(this.StaffEditForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlEditStaff.ResumeLayout(false);
            this.pnlEditStaff.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel pnlEditStaff;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnFindStaff;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnEditStaff;
        private MetroFramework.Controls.MetroComboBox cmbData;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Panel pnlSep;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAStatus;
        private System.Windows.Forms.Label lblASurname;
        private System.Windows.Forms.Label lblAName;
    }
}