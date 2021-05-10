
namespace InstaIssue.AdminCenter.UILayer
{
    partial class ServiceCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceCenterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlRequests = new System.Windows.Forms.Panel();
            this.cmbAllClients = new MetroFramework.Controls.MetroComboBox();
            this.btnAReq = new System.Windows.Forms.Button();
            this.btnCReq = new System.Windows.Forms.Button();
            this.btnLatestReq = new System.Windows.Forms.Button();
            this.btnROD = new System.Windows.Forms.Button();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.pnlJobs = new System.Windows.Forms.Panel();
            this.btnSchedJobs = new System.Windows.Forms.Button();
            this.btnViewJobs = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.pnlJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJobs);
            this.panel1.Controls.Add(this.btnRequests);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 505);
            this.panel1.TabIndex = 0;
            // 
            // btnJobs
            // 
            this.btnJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnJobs.Image = global::InstaIssue.Properties.Resources.JobsS;
            this.btnJobs.Location = new System.Drawing.Point(0, 259);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(159, 82);
            this.btnJobs.TabIndex = 9;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.FlatAppearance.BorderSize = 0;
            this.btnRequests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRequests.Image = global::InstaIssue.Properties.Resources.RequestsS;
            this.btnRequests.Location = new System.Drawing.Point(0, 171);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(159, 82);
            this.btnRequests.TabIndex = 8;
            this.btnRequests.Text = "Requests";
            this.btnRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.imgLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 81);
            this.panel3.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlSeperator);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblCID);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 81);
            this.panel2.TabIndex = 1;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.White;
            this.pnlSeperator.Location = new System.Drawing.Point(149, 9);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(10, 22);
            this.pnlSeperator.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(165, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 21);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "JA0221";
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
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCID.Location = new System.Drawing.Point(5, 9);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(67, 21);
            this.lblCID.TabIndex = 11;
            this.lblCID.Text = "Staff ID";
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
            // pnlRequests
            // 
            this.pnlRequests.Controls.Add(this.cmbAllClients);
            this.pnlRequests.Controls.Add(this.btnAReq);
            this.pnlRequests.Controls.Add(this.btnCReq);
            this.pnlRequests.Controls.Add(this.btnLatestReq);
            this.pnlRequests.Controls.Add(this.btnROD);
            this.pnlRequests.Controls.Add(this.dtpDate);
            this.pnlRequests.Controls.Add(this.dgvRequests);
            this.pnlRequests.Location = new System.Drawing.Point(167, 90);
            this.pnlRequests.Name = "pnlRequests";
            this.pnlRequests.Size = new System.Drawing.Size(747, 406);
            this.pnlRequests.TabIndex = 2;
            this.pnlRequests.Visible = false;
            // 
            // cmbAllClients
            // 
            this.cmbAllClients.FormattingEnabled = true;
            this.cmbAllClients.ItemHeight = 23;
            this.cmbAllClients.Location = new System.Drawing.Point(14, 243);
            this.cmbAllClients.Name = "cmbAllClients";
            this.cmbAllClients.Size = new System.Drawing.Size(159, 29);
            this.cmbAllClients.TabIndex = 20;
            this.cmbAllClients.UseSelectable = true;
            // 
            // btnAReq
            // 
            this.btnAReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAReq.FlatAppearance.BorderSize = 0;
            this.btnAReq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnAReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnAReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAReq.Image = global::InstaIssue.Properties.Resources.RequestsS;
            this.btnAReq.Location = new System.Drawing.Point(16, 344);
            this.btnAReq.Name = "btnAReq";
            this.btnAReq.Size = new System.Drawing.Size(159, 57);
            this.btnAReq.TabIndex = 19;
            this.btnAReq.Text = "All Request";
            this.btnAReq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAReq.UseVisualStyleBackColor = true;
            this.btnAReq.Click += new System.EventHandler(this.btnAReq_Click);
            // 
            // btnCReq
            // 
            this.btnCReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCReq.FlatAppearance.BorderSize = 0;
            this.btnCReq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnCReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnCReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCReq.Image = global::InstaIssue.Properties.Resources.LatestReq;
            this.btnCReq.Location = new System.Drawing.Point(14, 278);
            this.btnCReq.Name = "btnCReq";
            this.btnCReq.Size = new System.Drawing.Size(159, 57);
            this.btnCReq.TabIndex = 18;
            this.btnCReq.Text = "Client Request";
            this.btnCReq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCReq.UseVisualStyleBackColor = true;
            this.btnCReq.Click += new System.EventHandler(this.btnCReq_Click);
            // 
            // btnLatestReq
            // 
            this.btnLatestReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLatestReq.FlatAppearance.BorderSize = 0;
            this.btnLatestReq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnLatestReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnLatestReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLatestReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLatestReq.Image = global::InstaIssue.Properties.Resources.RequestsS;
            this.btnLatestReq.Location = new System.Drawing.Point(14, 159);
            this.btnLatestReq.Name = "btnLatestReq";
            this.btnLatestReq.Size = new System.Drawing.Size(159, 80);
            this.btnLatestReq.TabIndex = 16;
            this.btnLatestReq.Text = "Latest Request";
            this.btnLatestReq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLatestReq.UseVisualStyleBackColor = true;
            this.btnLatestReq.Click += new System.EventHandler(this.btnLatestReq_Click);
            // 
            // btnROD
            // 
            this.btnROD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnROD.FlatAppearance.BorderSize = 0;
            this.btnROD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnROD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnROD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnROD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnROD.Image = global::InstaIssue.Properties.Resources.Date;
            this.btnROD.Location = new System.Drawing.Point(14, 73);
            this.btnROD.Name = "btnROD";
            this.btnROD.Size = new System.Drawing.Size(159, 80);
            this.btnROD.TabIndex = 15;
            this.btnROD.Text = "Requests On Date";
            this.btnROD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnROD.UseVisualStyleBackColor = true;
            this.btnROD.Click += new System.EventHandler(this.btnROD_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(14, 38);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 29);
            this.dtpDate.TabIndex = 14;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(181, 11);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(555, 389);
            this.dgvRequests.TabIndex = 13;
            // 
            // pnlJobs
            // 
            this.pnlJobs.Controls.Add(this.btnSchedJobs);
            this.pnlJobs.Controls.Add(this.btnViewJobs);
            this.pnlJobs.Controls.Add(this.dgvJobs);
            this.pnlJobs.Location = new System.Drawing.Point(165, 87);
            this.pnlJobs.Name = "pnlJobs";
            this.pnlJobs.Size = new System.Drawing.Size(750, 411);
            this.pnlJobs.TabIndex = 3;
            this.pnlJobs.Visible = false;
            // 
            // btnSchedJobs
            // 
            this.btnSchedJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedJobs.FlatAppearance.BorderSize = 0;
            this.btnSchedJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnSchedJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnSchedJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSchedJobs.Image = global::InstaIssue.Properties.Resources.RequestsS;
            this.btnSchedJobs.Location = new System.Drawing.Point(14, 169);
            this.btnSchedJobs.Name = "btnSchedJobs";
            this.btnSchedJobs.Size = new System.Drawing.Size(159, 82);
            this.btnSchedJobs.TabIndex = 15;
            this.btnSchedJobs.Text = "Schedule All Request";
            this.btnSchedJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSchedJobs.UseVisualStyleBackColor = true;
            this.btnSchedJobs.Click += new System.EventHandler(this.btnSchedJobs_Click);
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewJobs.FlatAppearance.BorderSize = 0;
            this.btnViewJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnViewJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnViewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewJobs.Image = global::InstaIssue.Properties.Resources.JobsS;
            this.btnViewJobs.Location = new System.Drawing.Point(14, 81);
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(159, 82);
            this.btnViewJobs.TabIndex = 14;
            this.btnViewJobs.Text = "View All Jobs";
            this.btnViewJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewJobs.UseVisualStyleBackColor = true;
            this.btnViewJobs.Click += new System.EventHandler(this.btnViewJobs_Click);
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(181, 17);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowTemplate.Height = 25;
            this.dgvJobs.Size = new System.Drawing.Size(555, 389);
            this.dgvJobs.TabIndex = 13;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // ServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(924, 505);
            this.Controls.Add(this.pnlJobs);
            this.Controls.Add(this.pnlRequests);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceCenter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceCenter_FormClosed);
            this.Load += new System.EventHandler(this.ServiceCenter_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.pnlJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Panel pnlRequests;
        private System.Windows.Forms.Panel pnlJobs;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnROD;
        private System.Windows.Forms.Button btnLatestReq;
        private System.Windows.Forms.Button btnCReq;
        private System.Windows.Forms.Button btnAReq;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Button btnViewJobs;
        private System.Windows.Forms.Button btnSchedJobs;
        private System.Windows.Forms.Timer tmrTime;
        private MetroFramework.Controls.MetroComboBox cmbAllClients;
    }
}