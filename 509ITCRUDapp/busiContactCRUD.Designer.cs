namespace _509ITCRUDapp
{
    partial class BusiContactCRUD
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
            this.dgvBusi = new System.Windows.Forms.DataGridView();
            this.btnAddNewBusi = new System.Windows.Forms.Button();
            this.btnSaveNewBusi = new System.Windows.Forms.Button();
            this.btnRefreshBusi = new System.Windows.Forms.Button();
            this.btnUpdateSelBusi = new System.Windows.Forms.Button();
            this.btnSaveSelBusi = new System.Windows.Forms.Button();
            this.btnDeleteSelBusi = new System.Windows.Forms.Button();
            this.tbFirstNameBusi = new System.Windows.Forms.TextBox();
            this.tbLastNameBusi = new System.Windows.Forms.TextBox();
            this.tbEmailBusi = new System.Windows.Forms.TextBox();
            this.tbPhoneBusi = new System.Windows.Forms.TextBox();
            this.tbAddressLine1Busi = new System.Windows.Forms.TextBox();
            this.tbAddressLine2Busi = new System.Windows.Forms.TextBox();
            this.tbCountryBusi = new System.Windows.Forms.TextBox();
            this.tbCompanyBusi = new System.Windows.Forms.TextBox();
            this.tbPostcodeBusi = new System.Windows.Forms.TextBox();
            this.lblFirstNameBusi = new System.Windows.Forms.Label();
            this.lblLastNameBusi = new System.Windows.Forms.Label();
            this.lblEmailBusi = new System.Windows.Forms.Label();
            this.lblPhoneBusi = new System.Windows.Forms.Label();
            this.lblAddressLine1Busi = new System.Windows.Forms.Label();
            this.lblAddressLine2Busi = new System.Windows.Forms.Label();
            this.lblPostcodeBusi = new System.Windows.Forms.Label();
            this.lblCountryBusi = new System.Windows.Forms.Label();
            this.lblCompanyBusi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusi
            // 
            this.dgvBusi.AllowUserToAddRows = false;
            this.dgvBusi.AllowUserToDeleteRows = false;
            this.dgvBusi.AllowUserToResizeColumns = false;
            this.dgvBusi.AllowUserToResizeRows = false;
            this.dgvBusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusi.Location = new System.Drawing.Point(12, 275);
            this.dgvBusi.Name = "dgvBusi";
            this.dgvBusi.ReadOnly = true;
            this.dgvBusi.RowHeadersWidth = 62;
            this.dgvBusi.RowTemplate.Height = 28;
            this.dgvBusi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusi.Size = new System.Drawing.Size(1231, 262);
            this.dgvBusi.TabIndex = 0;
            this.dgvBusi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusi_CellClick);
            // 
            // btnAddNewBusi
            // 
            this.btnAddNewBusi.Location = new System.Drawing.Point(1117, 12);
            this.btnAddNewBusi.Name = "btnAddNewBusi";
            this.btnAddNewBusi.Size = new System.Drawing.Size(126, 45);
            this.btnAddNewBusi.TabIndex = 1;
            this.btnAddNewBusi.Text = "Add New";
            this.btnAddNewBusi.UseVisualStyleBackColor = true;
            this.btnAddNewBusi.Click += new System.EventHandler(this.btnAddNewBusi_Click);
            // 
            // btnSaveNewBusi
            // 
            this.btnSaveNewBusi.Enabled = false;
            this.btnSaveNewBusi.Location = new System.Drawing.Point(1117, 70);
            this.btnSaveNewBusi.Name = "btnSaveNewBusi";
            this.btnSaveNewBusi.Size = new System.Drawing.Size(126, 45);
            this.btnSaveNewBusi.TabIndex = 2;
            this.btnSaveNewBusi.Text = "Save New";
            this.btnSaveNewBusi.UseVisualStyleBackColor = true;
            this.btnSaveNewBusi.Click += new System.EventHandler(this.btnSaveNewBusi_Click);
            // 
            // btnRefreshBusi
            // 
            this.btnRefreshBusi.Location = new System.Drawing.Point(1044, 220);
            this.btnRefreshBusi.Name = "btnRefreshBusi";
            this.btnRefreshBusi.Size = new System.Drawing.Size(124, 45);
            this.btnRefreshBusi.TabIndex = 3;
            this.btnRefreshBusi.Text = "Refresh";
            this.btnRefreshBusi.UseVisualStyleBackColor = true;
            this.btnRefreshBusi.Click += new System.EventHandler(this.btnRefreshBusi_Click);
            // 
            // btnUpdateSelBusi
            // 
            this.btnUpdateSelBusi.Location = new System.Drawing.Point(906, 12);
            this.btnUpdateSelBusi.Name = "btnUpdateSelBusi";
            this.btnUpdateSelBusi.Size = new System.Drawing.Size(172, 45);
            this.btnUpdateSelBusi.TabIndex = 4;
            this.btnUpdateSelBusi.Text = "Update Selelected";
            this.btnUpdateSelBusi.UseVisualStyleBackColor = true;
            this.btnUpdateSelBusi.Click += new System.EventHandler(this.btnUpdateSelBusi_Click);
            // 
            // btnSaveSelBusi
            // 
            this.btnSaveSelBusi.Enabled = false;
            this.btnSaveSelBusi.Location = new System.Drawing.Point(906, 66);
            this.btnSaveSelBusi.Name = "btnSaveSelBusi";
            this.btnSaveSelBusi.Size = new System.Drawing.Size(172, 45);
            this.btnSaveSelBusi.TabIndex = 5;
            this.btnSaveSelBusi.Text = "Save Selected";
            this.btnSaveSelBusi.UseVisualStyleBackColor = true;
            this.btnSaveSelBusi.Click += new System.EventHandler(this.btnSaveSelBusi_Click);
            // 
            // btnDeleteSelBusi
            // 
            this.btnDeleteSelBusi.Location = new System.Drawing.Point(906, 117);
            this.btnDeleteSelBusi.Name = "btnDeleteSelBusi";
            this.btnDeleteSelBusi.Size = new System.Drawing.Size(172, 45);
            this.btnDeleteSelBusi.TabIndex = 6;
            this.btnDeleteSelBusi.Text = "Delete Selected";
            this.btnDeleteSelBusi.UseVisualStyleBackColor = true;
            this.btnDeleteSelBusi.Click += new System.EventHandler(this.btnDeleteSelBusi_Click);
            // 
            // tbFirstNameBusi
            // 
            this.tbFirstNameBusi.Enabled = false;
            this.tbFirstNameBusi.Location = new System.Drawing.Point(195, 37);
            this.tbFirstNameBusi.Name = "tbFirstNameBusi";
            this.tbFirstNameBusi.Size = new System.Drawing.Size(151, 26);
            this.tbFirstNameBusi.TabIndex = 7;
            // 
            // tbLastNameBusi
            // 
            this.tbLastNameBusi.Enabled = false;
            this.tbLastNameBusi.Location = new System.Drawing.Point(195, 75);
            this.tbLastNameBusi.Name = "tbLastNameBusi";
            this.tbLastNameBusi.Size = new System.Drawing.Size(151, 26);
            this.tbLastNameBusi.TabIndex = 8;
            // 
            // tbEmailBusi
            // 
            this.tbEmailBusi.Enabled = false;
            this.tbEmailBusi.Location = new System.Drawing.Point(195, 111);
            this.tbEmailBusi.Name = "tbEmailBusi";
            this.tbEmailBusi.Size = new System.Drawing.Size(230, 26);
            this.tbEmailBusi.TabIndex = 9;
            // 
            // tbPhoneBusi
            // 
            this.tbPhoneBusi.Enabled = false;
            this.tbPhoneBusi.Location = new System.Drawing.Point(195, 153);
            this.tbPhoneBusi.Name = "tbPhoneBusi";
            this.tbPhoneBusi.Size = new System.Drawing.Size(230, 26);
            this.tbPhoneBusi.TabIndex = 10;
            // 
            // tbAddressLine1Busi
            // 
            this.tbAddressLine1Busi.Enabled = false;
            this.tbAddressLine1Busi.Location = new System.Drawing.Point(195, 195);
            this.tbAddressLine1Busi.Name = "tbAddressLine1Busi";
            this.tbAddressLine1Busi.Size = new System.Drawing.Size(230, 26);
            this.tbAddressLine1Busi.TabIndex = 11;
            // 
            // tbAddressLine2Busi
            // 
            this.tbAddressLine2Busi.Enabled = false;
            this.tbAddressLine2Busi.Location = new System.Drawing.Point(596, 28);
            this.tbAddressLine2Busi.Name = "tbAddressLine2Busi";
            this.tbAddressLine2Busi.Size = new System.Drawing.Size(230, 26);
            this.tbAddressLine2Busi.TabIndex = 12;
            // 
            // tbCountryBusi
            // 
            this.tbCountryBusi.Enabled = false;
            this.tbCountryBusi.Location = new System.Drawing.Point(596, 139);
            this.tbCountryBusi.Name = "tbCountryBusi";
            this.tbCountryBusi.Size = new System.Drawing.Size(230, 26);
            this.tbCountryBusi.TabIndex = 13;
            // 
            // tbCompanyBusi
            // 
            this.tbCompanyBusi.Enabled = false;
            this.tbCompanyBusi.Location = new System.Drawing.Point(596, 189);
            this.tbCompanyBusi.Name = "tbCompanyBusi";
            this.tbCompanyBusi.Size = new System.Drawing.Size(230, 26);
            this.tbCompanyBusi.TabIndex = 14;
            // 
            // tbPostcodeBusi
            // 
            this.tbPostcodeBusi.Enabled = false;
            this.tbPostcodeBusi.Location = new System.Drawing.Point(596, 82);
            this.tbPostcodeBusi.Name = "tbPostcodeBusi";
            this.tbPostcodeBusi.Size = new System.Drawing.Size(230, 26);
            this.tbPostcodeBusi.TabIndex = 15;
            // 
            // lblFirstNameBusi
            // 
            this.lblFirstNameBusi.AutoSize = true;
            this.lblFirstNameBusi.Location = new System.Drawing.Point(85, 43);
            this.lblFirstNameBusi.Name = "lblFirstNameBusi";
            this.lblFirstNameBusi.Size = new System.Drawing.Size(86, 20);
            this.lblFirstNameBusi.TabIndex = 16;
            this.lblFirstNameBusi.Text = "First Name";
            // 
            // lblLastNameBusi
            // 
            this.lblLastNameBusi.AutoSize = true;
            this.lblLastNameBusi.Location = new System.Drawing.Point(85, 81);
            this.lblLastNameBusi.Name = "lblLastNameBusi";
            this.lblLastNameBusi.Size = new System.Drawing.Size(86, 20);
            this.lblLastNameBusi.TabIndex = 17;
            this.lblLastNameBusi.Text = "Last Name";
            // 
            // lblEmailBusi
            // 
            this.lblEmailBusi.AutoSize = true;
            this.lblEmailBusi.Location = new System.Drawing.Point(85, 117);
            this.lblEmailBusi.Name = "lblEmailBusi";
            this.lblEmailBusi.Size = new System.Drawing.Size(48, 20);
            this.lblEmailBusi.TabIndex = 18;
            this.lblEmailBusi.Text = "Email";
            // 
            // lblPhoneBusi
            // 
            this.lblPhoneBusi.AutoSize = true;
            this.lblPhoneBusi.Location = new System.Drawing.Point(8, 156);
            this.lblPhoneBusi.Name = "lblPhoneBusi";
            this.lblPhoneBusi.Size = new System.Drawing.Size(181, 20);
            this.lblPhoneBusi.TabIndex = 19;
            this.lblPhoneBusi.Text = "Business phone number";
            // 
            // lblAddressLine1Busi
            // 
            this.lblAddressLine1Busi.AutoSize = true;
            this.lblAddressLine1Busi.Location = new System.Drawing.Point(56, 201);
            this.lblAddressLine1Busi.Name = "lblAddressLine1Busi";
            this.lblAddressLine1Busi.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine1Busi.TabIndex = 20;
            this.lblAddressLine1Busi.Text = "Address Line 1";
            // 
            // lblAddressLine2Busi
            // 
            this.lblAddressLine2Busi.AutoSize = true;
            this.lblAddressLine2Busi.Location = new System.Drawing.Point(475, 34);
            this.lblAddressLine2Busi.Name = "lblAddressLine2Busi";
            this.lblAddressLine2Busi.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine2Busi.TabIndex = 21;
            this.lblAddressLine2Busi.Text = "Address Line 2";
            // 
            // lblPostcodeBusi
            // 
            this.lblPostcodeBusi.AutoSize = true;
            this.lblPostcodeBusi.Location = new System.Drawing.Point(514, 82);
            this.lblPostcodeBusi.Name = "lblPostcodeBusi";
            this.lblPostcodeBusi.Size = new System.Drawing.Size(76, 20);
            this.lblPostcodeBusi.TabIndex = 22;
            this.lblPostcodeBusi.Text = "Postcode";
            // 
            // lblCountryBusi
            // 
            this.lblCountryBusi.AutoSize = true;
            this.lblCountryBusi.Location = new System.Drawing.Point(514, 139);
            this.lblCountryBusi.Name = "lblCountryBusi";
            this.lblCountryBusi.Size = new System.Drawing.Size(64, 20);
            this.lblCountryBusi.TabIndex = 23;
            this.lblCountryBusi.Text = "Country";
            // 
            // lblCompanyBusi
            // 
            this.lblCompanyBusi.AutoSize = true;
            this.lblCompanyBusi.Location = new System.Drawing.Point(514, 195);
            this.lblCompanyBusi.Name = "lblCompanyBusi";
            this.lblCompanyBusi.Size = new System.Drawing.Size(76, 20);
            this.lblCompanyBusi.TabIndex = 24;
            this.lblCompanyBusi.Text = "Company";
            // 
            // BusiContactCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 549);
            this.Controls.Add(this.lblCompanyBusi);
            this.Controls.Add(this.lblCountryBusi);
            this.Controls.Add(this.lblPostcodeBusi);
            this.Controls.Add(this.lblAddressLine2Busi);
            this.Controls.Add(this.lblAddressLine1Busi);
            this.Controls.Add(this.lblPhoneBusi);
            this.Controls.Add(this.lblEmailBusi);
            this.Controls.Add(this.lblLastNameBusi);
            this.Controls.Add(this.lblFirstNameBusi);
            this.Controls.Add(this.tbPostcodeBusi);
            this.Controls.Add(this.tbCompanyBusi);
            this.Controls.Add(this.tbCountryBusi);
            this.Controls.Add(this.tbAddressLine2Busi);
            this.Controls.Add(this.tbAddressLine1Busi);
            this.Controls.Add(this.tbPhoneBusi);
            this.Controls.Add(this.tbEmailBusi);
            this.Controls.Add(this.tbLastNameBusi);
            this.Controls.Add(this.tbFirstNameBusi);
            this.Controls.Add(this.btnDeleteSelBusi);
            this.Controls.Add(this.btnSaveSelBusi);
            this.Controls.Add(this.btnUpdateSelBusi);
            this.Controls.Add(this.btnRefreshBusi);
            this.Controls.Add(this.btnSaveNewBusi);
            this.Controls.Add(this.btnAddNewBusi);
            this.Controls.Add(this.dgvBusi);
            this.Name = "BusiContactCRUD";
            this.Text = "Business Contacts Editor";
            this.Load += new System.EventHandler(this.BusiContactCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusi;
        private System.Windows.Forms.Button btnAddNewBusi;
        private System.Windows.Forms.Button btnSaveNewBusi;
        private System.Windows.Forms.Button btnRefreshBusi;
        private System.Windows.Forms.Button btnUpdateSelBusi;
        private System.Windows.Forms.Button btnSaveSelBusi;
        private System.Windows.Forms.Button btnDeleteSelBusi;
        private System.Windows.Forms.TextBox tbFirstNameBusi;
        private System.Windows.Forms.TextBox tbLastNameBusi;
        private System.Windows.Forms.TextBox tbEmailBusi;
        private System.Windows.Forms.TextBox tbPhoneBusi;
        private System.Windows.Forms.TextBox tbAddressLine1Busi;
        private System.Windows.Forms.TextBox tbAddressLine2Busi;
        private System.Windows.Forms.TextBox tbCountryBusi;
        private System.Windows.Forms.TextBox tbCompanyBusi;
        private System.Windows.Forms.TextBox tbPostcodeBusi;
        private System.Windows.Forms.Label lblFirstNameBusi;
        private System.Windows.Forms.Label lblLastNameBusi;
        private System.Windows.Forms.Label lblEmailBusi;
        private System.Windows.Forms.Label lblPhoneBusi;
        private System.Windows.Forms.Label lblAddressLine1Busi;
        private System.Windows.Forms.Label lblAddressLine2Busi;
        private System.Windows.Forms.Label lblPostcodeBusi;
        private System.Windows.Forms.Label lblCountryBusi;
        private System.Windows.Forms.Label lblCompanyBusi;
    }
}