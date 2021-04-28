
namespace InstaIssue.AdminCenter.UILayer
{
    partial class AdminCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCenterForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnMngContracts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMngClients = new System.Windows.Forms.Button();
            this.btnMngStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlIssues = new System.Windows.Forms.Panel();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.pnlControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlIssues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnMngContracts);
            this.pnlControls.Controls.Add(this.button1);
            this.pnlControls.Controls.Add(this.btnMngClients);
            this.pnlControls.Controls.Add(this.btnMngStaff);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(178, 512);
            this.pnlControls.TabIndex = 0;
            // 
            // btnMngContracts
            // 
            this.btnMngContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngContracts.FlatAppearance.BorderSize = 0;
            this.btnMngContracts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnMngContracts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMngContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMngContracts.Image = global::InstaIssue.Properties.Resources.Review;
            this.btnMngContracts.Location = new System.Drawing.Point(0, 369);
            this.btnMngContracts.Name = "btnMngContracts";
            this.btnMngContracts.Size = new System.Drawing.Size(178, 82);
            this.btnMngContracts.TabIndex = 12;
            this.btnMngContracts.Text = "Manage Contracts";
            this.btnMngContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMngContracts.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = global::InstaIssue.Properties.Resources.Issues;
            this.button1.Location = new System.Drawing.Point(0, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 82);
            this.button1.TabIndex = 11;
            this.button1.Text = "Track Issues";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMngClients
            // 
            this.btnMngClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngClients.FlatAppearance.BorderSize = 0;
            this.btnMngClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnMngClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMngClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMngClients.Image = global::InstaIssue.Properties.Resources.Clients;
            this.btnMngClients.Location = new System.Drawing.Point(0, 281);
            this.btnMngClients.Name = "btnMngClients";
            this.btnMngClients.Size = new System.Drawing.Size(178, 82);
            this.btnMngClients.TabIndex = 10;
            this.btnMngClients.Text = "Manage Clients";
            this.btnMngClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMngClients.UseVisualStyleBackColor = true;
            this.btnMngClients.Click += new System.EventHandler(this.btnMngClients_Click);
            // 
            // btnMngStaff
            // 
            this.btnMngStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngStaff.FlatAppearance.BorderSize = 0;
            this.btnMngStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnMngStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMngStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMngStaff.Image = global::InstaIssue.Properties.Resources.Home;
            this.btnMngStaff.Location = new System.Drawing.Point(0, 193);
            this.btnMngStaff.Name = "btnMngStaff";
            this.btnMngStaff.Size = new System.Drawing.Size(178, 82);
            this.btnMngStaff.TabIndex = 9;
            this.btnMngStaff.Text = "Manage Staff";
            this.btnMngStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMngStaff.UseVisualStyleBackColor = true;
            this.btnMngStaff.Click += new System.EventHandler(this.btnMngStaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 81);
            this.panel1.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgLogo.Image = global::InstaIssue.Properties.Resources.LogoGreen;
            this.imgLogo.Location = new System.Drawing.Point(49, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(78, 78);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(178, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(748, 81);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(616, 9);
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
            this.lblTime.Location = new System.Drawing.Point(616, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 24);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "14:23";
            // 
            // pnlIssues
            // 
            this.pnlIssues.Controls.Add(this.dgvIssues);
            this.pnlIssues.Location = new System.Drawing.Point(184, 88);
            this.pnlIssues.Name = "pnlIssues";
            this.pnlIssues.Size = new System.Drawing.Size(729, 413);
            this.pnlIssues.TabIndex = 2;
            // 
            // dgvIssues
            // 
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(23, 19);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.RowTemplate.Height = 25;
            this.dgvIssues.Size = new System.Drawing.Size(706, 394);
            this.dgvIssues.TabIndex = 0;
            // 
            // AdminCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(926, 512);
            this.Controls.Add(this.pnlIssues);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlControls);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCenterForm";
            this.Text = "Admin Center";
            this.Load += new System.EventHandler(this.AdminCenterForm_Load);
            this.pnlControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlIssues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnMngContracts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMngClients;
        private System.Windows.Forms.Button btnMngStaff;
        private System.Windows.Forms.Panel pnlIssues;
        private System.Windows.Forms.DataGridView dgvIssues;
    }
}