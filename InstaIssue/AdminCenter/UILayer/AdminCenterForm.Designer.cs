﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCenterForm));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnMngContracts = new System.Windows.Forms.Button();
            this.btnMngIssues = new System.Windows.Forms.Button();
            this.btnMngClients = new System.Windows.Forms.Button();
            this.btnMngStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlIssues = new System.Windows.Forms.Panel();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.pnlContracts = new System.Windows.Forms.Panel();
            this.btnEditCont = new System.Windows.Forms.Button();
            this.btnViewCont = new System.Windows.Forms.Button();
            this.btnAddCont = new System.Windows.Forms.Button();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlIssues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.pnlStaff.SuspendLayout();
            this.pnlContracts.SuspendLayout();
            this.pnlClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnMngContracts);
            this.pnlControls.Controls.Add(this.btnMngIssues);
            this.pnlControls.Controls.Add(this.btnMngClients);
            this.pnlControls.Controls.Add(this.btnMngStaff);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(178, 508);
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
            this.btnMngContracts.Click += new System.EventHandler(this.btnMngContracts_Click);
            // 
            // btnMngIssues
            // 
            this.btnMngIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngIssues.FlatAppearance.BorderSize = 0;
            this.btnMngIssues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnMngIssues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnMngIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMngIssues.Image = global::InstaIssue.Properties.Resources.Issues;
            this.btnMngIssues.Location = new System.Drawing.Point(0, 105);
            this.btnMngIssues.Name = "btnMngIssues";
            this.btnMngIssues.Size = new System.Drawing.Size(178, 82);
            this.btnMngIssues.TabIndex = 11;
            this.btnMngIssues.Text = "Track Issues";
            this.btnMngIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMngIssues.UseVisualStyleBackColor = true;
            this.btnMngIssues.Click += new System.EventHandler(this.btnMngIssues_Click);
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
            this.btnMngStaff.Image = global::InstaIssue.Properties.Resources.TrackB;
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
            this.pnlInfo.Controls.Add(this.pnlSeperator);
            this.pnlInfo.Controls.Add(this.lblID);
            this.pnlInfo.Controls.Add(this.lblCID);
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblTime);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(178, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(752, 81);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.White;
            this.pnlSeperator.Location = new System.Drawing.Point(150, 12);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(10, 22);
            this.pnlSeperator.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(166, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 21);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "JA0221";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCID.Location = new System.Drawing.Point(6, 12);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(67, 21);
            this.lblCID.TabIndex = 17;
            this.lblCID.Text = "Staff ID";
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
            this.pnlIssues.Size = new System.Drawing.Size(738, 413);
            this.pnlIssues.TabIndex = 2;
            // 
            // dgvIssues
            // 
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(14, 11);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.RowTemplate.Height = 25;
            this.dgvIssues.Size = new System.Drawing.Size(706, 394);
            this.dgvIssues.TabIndex = 0;
            // 
            // pnlStaff
            // 
            this.pnlStaff.Controls.Add(this.btnEditStaff);
            this.pnlStaff.Controls.Add(this.btnViewStaff);
            this.pnlStaff.Controls.Add(this.btnAddStaff);
            this.pnlStaff.Location = new System.Drawing.Point(184, 87);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(737, 413);
            this.pnlStaff.TabIndex = 3;
            this.pnlStaff.Visible = false;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnEditStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditStaff.Image = global::InstaIssue.Properties.Resources.EditB;
            this.btnEditStaff.Location = new System.Drawing.Point(256, 206);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(240, 147);
            this.btnEditStaff.TabIndex = 12;
            this.btnEditStaff.Text = "Edit Staff";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStaff.FlatAppearance.BorderSize = 0;
            this.btnViewStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnViewStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewStaff.Image = global::InstaIssue.Properties.Resources.ViewB;
            this.btnViewStaff.Location = new System.Drawing.Point(371, 53);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(240, 147);
            this.btnViewStaff.TabIndex = 11;
            this.btnViewStaff.Text = "View Staff";
            this.btnViewStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewStaff.UseVisualStyleBackColor = true;
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddStaff.Image = global::InstaIssue.Properties.Resources.StaffB;
            this.btnAddStaff.Location = new System.Drawing.Point(125, 53);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(240, 147);
            this.btnAddStaff.TabIndex = 10;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // pnlContracts
            // 
            this.pnlContracts.Controls.Add(this.btnEditCont);
            this.pnlContracts.Controls.Add(this.btnViewCont);
            this.pnlContracts.Controls.Add(this.btnAddCont);
            this.pnlContracts.Location = new System.Drawing.Point(184, 87);
            this.pnlContracts.Name = "pnlContracts";
            this.pnlContracts.Size = new System.Drawing.Size(737, 413);
            this.pnlContracts.TabIndex = 5;
            this.pnlContracts.Visible = false;
            // 
            // btnEditCont
            // 
            this.btnEditCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCont.FlatAppearance.BorderSize = 0;
            this.btnEditCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnEditCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnEditCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditCont.Image = global::InstaIssue.Properties.Resources.EditB;
            this.btnEditCont.Location = new System.Drawing.Point(247, 209);
            this.btnEditCont.Name = "btnEditCont";
            this.btnEditCont.Size = new System.Drawing.Size(240, 147);
            this.btnEditCont.TabIndex = 20;
            this.btnEditCont.Text = "Edit Contract";
            this.btnEditCont.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditCont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCont.UseVisualStyleBackColor = true;
            this.btnEditCont.Click += new System.EventHandler(this.btnEditCont_Click);
            // 
            // btnViewCont
            // 
            this.btnViewCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCont.FlatAppearance.BorderSize = 0;
            this.btnViewCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnViewCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnViewCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewCont.Image = global::InstaIssue.Properties.Resources.ViewB;
            this.btnViewCont.Location = new System.Drawing.Point(367, 56);
            this.btnViewCont.Name = "btnViewCont";
            this.btnViewCont.Size = new System.Drawing.Size(240, 147);
            this.btnViewCont.TabIndex = 19;
            this.btnViewCont.Text = "View Contract";
            this.btnViewCont.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewCont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewCont.UseVisualStyleBackColor = true;
            this.btnViewCont.Click += new System.EventHandler(this.btnViewCont_Click);
            // 
            // btnAddCont
            // 
            this.btnAddCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCont.FlatAppearance.BorderSize = 0;
            this.btnAddCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnAddCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnAddCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCont.Image = global::InstaIssue.Properties.Resources.CreateB;
            this.btnAddCont.Location = new System.Drawing.Point(121, 56);
            this.btnAddCont.Name = "btnAddCont";
            this.btnAddCont.Size = new System.Drawing.Size(240, 147);
            this.btnAddCont.TabIndex = 18;
            this.btnAddCont.Text = "Add Contract";
            this.btnAddCont.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddCont.UseVisualStyleBackColor = true;
            this.btnAddCont.Click += new System.EventHandler(this.btnAddCont_Click);
            // 
            // pnlClients
            // 
            this.pnlClients.Controls.Add(this.btnDeleteClient);
            this.pnlClients.Controls.Add(this.btnEditClient);
            this.pnlClients.Controls.Add(this.btnViewClient);
            this.pnlClients.Controls.Add(this.btnAddClient);
            this.pnlClients.Location = new System.Drawing.Point(184, 87);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(737, 413);
            this.pnlClients.TabIndex = 4;
            this.pnlClients.Visible = false;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteClient.Image = global::InstaIssue.Properties.Resources.DeleteB;
            this.btnDeleteClient.Location = new System.Drawing.Point(367, 209);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(240, 147);
            this.btnDeleteClient.TabIndex = 17;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditClient.Image = global::InstaIssue.Properties.Resources.EditB;
            this.btnEditClient.Location = new System.Drawing.Point(121, 209);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(240, 147);
            this.btnEditClient.TabIndex = 16;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnViewClient
            // 
            this.btnViewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewClient.FlatAppearance.BorderSize = 0;
            this.btnViewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnViewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnViewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewClient.Image = global::InstaIssue.Properties.Resources.ViewB;
            this.btnViewClient.Location = new System.Drawing.Point(367, 56);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(240, 147);
            this.btnViewClient.TabIndex = 15;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddClient.Image = global::InstaIssue.Properties.Resources.ClientAddL;
            this.btnAddClient.Location = new System.Drawing.Point(121, 56);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(240, 147);
            this.btnAddClient.TabIndex = 14;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // AdminCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(930, 508);
            this.Controls.Add(this.pnlContracts);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.pnlClients);
            this.Controls.Add(this.pnlIssues);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlControls);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Center";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminCenterForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminCenterForm_Load);
            this.pnlControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlIssues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.pnlStaff.ResumeLayout(false);
            this.pnlContracts.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMngIssues;
        private System.Windows.Forms.Button btnMngClients;
        private System.Windows.Forms.Button btnMngStaff;
        private System.Windows.Forms.Panel pnlIssues;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Panel pnlContracts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditCont;
        private System.Windows.Forms.Button btnViewCont;
        private System.Windows.Forms.Button btnAddCont;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCID;
    }
}