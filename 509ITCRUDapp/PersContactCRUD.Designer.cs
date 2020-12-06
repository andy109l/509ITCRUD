namespace _509ITCRUDapp
{
    partial class PersContactCRUD
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
            this.dgvPers = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSel = new System.Windows.Forms.Button();
            this.btnDeleteSel = new System.Windows.Forms.Button();
            this.btnSaveSel = new System.Windows.Forms.Button();
            this.tbFirstNamePers = new System.Windows.Forms.TextBox();
            this.tbLastNamePers = new System.Windows.Forms.TextBox();
            this.tbPostcodePers = new System.Windows.Forms.TextBox();
            this.tbAddressLine1Pers = new System.Windows.Forms.TextBox();
            this.tbEmailPers = new System.Windows.Forms.TextBox();
            this.tbPhonePers = new System.Windows.Forms.TextBox();
            this.tbAddressLine2Pers = new System.Windows.Forms.TextBox();
            this.tbCountryPers = new System.Windows.Forms.TextBox();
            this.lblFirstNamePers = new System.Windows.Forms.Label();
            this.lblLastNamePers = new System.Windows.Forms.Label();
            this.lblEmailPers = new System.Windows.Forms.Label();
            this.lblAddressLine1Pers = new System.Windows.Forms.Label();
            this.lblAddressLine2Pers = new System.Windows.Forms.Label();
            this.lblPostcodePers = new System.Windows.Forms.Label();
            this.lblCountryPers = new System.Windows.Forms.Label();
            this.lblPhonePers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPers
            // 
            this.dgvPers.AllowUserToResizeColumns = false;
            this.dgvPers.AllowUserToResizeRows = false;
            this.dgvPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPers.Location = new System.Drawing.Point(12, 200);
            this.dgvPers.Name = "dgvPers";
            this.dgvPers.ReadOnly = true;
            this.dgvPers.RowHeadersWidth = 62;
            this.dgvPers.RowTemplate.Height = 28;
            this.dgvPers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPers.Size = new System.Drawing.Size(1055, 266);
            this.dgvPers.TabIndex = 0;
            this.dgvPers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPers_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(947, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(119, 41);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(947, 85);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(119, 41);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(947, 165);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 29);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateSel
            // 
            this.btnUpdateSel.Location = new System.Drawing.Point(763, 12);
            this.btnUpdateSel.Name = "btnUpdateSel";
            this.btnUpdateSel.Size = new System.Drawing.Size(163, 41);
            this.btnUpdateSel.TabIndex = 4;
            this.btnUpdateSel.Text = "Update Selected";
            this.btnUpdateSel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSel
            // 
            this.btnDeleteSel.Location = new System.Drawing.Point(763, 109);
            this.btnDeleteSel.Name = "btnDeleteSel";
            this.btnDeleteSel.Size = new System.Drawing.Size(163, 41);
            this.btnDeleteSel.TabIndex = 5;
            this.btnDeleteSel.Text = "Delete Selected";
            this.btnDeleteSel.UseVisualStyleBackColor = true;
            // 
            // btnSaveSel
            // 
            this.btnSaveSel.Enabled = false;
            this.btnSaveSel.Location = new System.Drawing.Point(763, 62);
            this.btnSaveSel.Name = "btnSaveSel";
            this.btnSaveSel.Size = new System.Drawing.Size(163, 41);
            this.btnSaveSel.TabIndex = 6;
            this.btnSaveSel.Text = "Save Selected";
            this.btnSaveSel.UseVisualStyleBackColor = true;
            // 
            // tbFirstNamePers
            // 
            this.tbFirstNamePers.Enabled = false;
            this.tbFirstNamePers.Location = new System.Drawing.Point(127, 19);
            this.tbFirstNamePers.Name = "tbFirstNamePers";
            this.tbFirstNamePers.Size = new System.Drawing.Size(103, 26);
            this.tbFirstNamePers.TabIndex = 7;
            // 
            // tbLastNamePers
            // 
            this.tbLastNamePers.Enabled = false;
            this.tbLastNamePers.Location = new System.Drawing.Point(127, 59);
            this.tbLastNamePers.Name = "tbLastNamePers";
            this.tbLastNamePers.Size = new System.Drawing.Size(103, 26);
            this.tbLastNamePers.TabIndex = 8;
            // 
            // tbPostcodePers
            // 
            this.tbPostcodePers.Enabled = false;
            this.tbPostcodePers.Location = new System.Drawing.Point(492, 100);
            this.tbPostcodePers.Name = "tbPostcodePers";
            this.tbPostcodePers.Size = new System.Drawing.Size(96, 26);
            this.tbPostcodePers.TabIndex = 9;
            // 
            // tbAddressLine1Pers
            // 
            this.tbAddressLine1Pers.Enabled = false;
            this.tbAddressLine1Pers.Location = new System.Drawing.Point(492, 16);
            this.tbAddressLine1Pers.Name = "tbAddressLine1Pers";
            this.tbAddressLine1Pers.Size = new System.Drawing.Size(225, 26);
            this.tbAddressLine1Pers.TabIndex = 10;
            // 
            // tbEmailPers
            // 
            this.tbEmailPers.Enabled = false;
            this.tbEmailPers.Location = new System.Drawing.Point(127, 103);
            this.tbEmailPers.Name = "tbEmailPers";
            this.tbEmailPers.Size = new System.Drawing.Size(225, 26);
            this.tbEmailPers.TabIndex = 11;
            // 
            // tbPhonePers
            // 
            this.tbPhonePers.Enabled = false;
            this.tbPhonePers.Location = new System.Drawing.Point(127, 148);
            this.tbPhonePers.Name = "tbPhonePers";
            this.tbPhonePers.Size = new System.Drawing.Size(225, 26);
            this.tbPhonePers.TabIndex = 12;
            // 
            // tbAddressLine2Pers
            // 
            this.tbAddressLine2Pers.Enabled = false;
            this.tbAddressLine2Pers.Location = new System.Drawing.Point(492, 59);
            this.tbAddressLine2Pers.Name = "tbAddressLine2Pers";
            this.tbAddressLine2Pers.Size = new System.Drawing.Size(225, 26);
            this.tbAddressLine2Pers.TabIndex = 13;
            // 
            // tbCountryPers
            // 
            this.tbCountryPers.Enabled = false;
            this.tbCountryPers.Location = new System.Drawing.Point(492, 148);
            this.tbCountryPers.Name = "tbCountryPers";
            this.tbCountryPers.Size = new System.Drawing.Size(225, 26);
            this.tbCountryPers.TabIndex = 14;
            // 
            // lblFirstNamePers
            // 
            this.lblFirstNamePers.AutoSize = true;
            this.lblFirstNamePers.Location = new System.Drawing.Point(12, 19);
            this.lblFirstNamePers.Name = "lblFirstNamePers";
            this.lblFirstNamePers.Size = new System.Drawing.Size(86, 20);
            this.lblFirstNamePers.TabIndex = 15;
            this.lblFirstNamePers.Text = "First Name";
            // 
            // lblLastNamePers
            // 
            this.lblLastNamePers.AutoSize = true;
            this.lblLastNamePers.Location = new System.Drawing.Point(12, 62);
            this.lblLastNamePers.Name = "lblLastNamePers";
            this.lblLastNamePers.Size = new System.Drawing.Size(86, 20);
            this.lblLastNamePers.TabIndex = 16;
            this.lblLastNamePers.Text = "Last Name";
            // 
            // lblEmailPers
            // 
            this.lblEmailPers.AutoSize = true;
            this.lblEmailPers.Location = new System.Drawing.Point(12, 106);
            this.lblEmailPers.Name = "lblEmailPers";
            this.lblEmailPers.Size = new System.Drawing.Size(48, 20);
            this.lblEmailPers.TabIndex = 17;
            this.lblEmailPers.Text = "Email";
            // 
            // lblAddressLine1Pers
            // 
            this.lblAddressLine1Pers.AutoSize = true;
            this.lblAddressLine1Pers.Location = new System.Drawing.Point(355, 22);
            this.lblAddressLine1Pers.Name = "lblAddressLine1Pers";
            this.lblAddressLine1Pers.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine1Pers.TabIndex = 18;
            this.lblAddressLine1Pers.Text = "Address Line 1";
            // 
            // lblAddressLine2Pers
            // 
            this.lblAddressLine2Pers.AutoSize = true;
            this.lblAddressLine2Pers.Location = new System.Drawing.Point(355, 65);
            this.lblAddressLine2Pers.Name = "lblAddressLine2Pers";
            this.lblAddressLine2Pers.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine2Pers.TabIndex = 19;
            this.lblAddressLine2Pers.Text = "Address Line 2";
            // 
            // lblPostcodePers
            // 
            this.lblPostcodePers.AutoSize = true;
            this.lblPostcodePers.Location = new System.Drawing.Point(394, 106);
            this.lblPostcodePers.Name = "lblPostcodePers";
            this.lblPostcodePers.Size = new System.Drawing.Size(76, 20);
            this.lblPostcodePers.TabIndex = 20;
            this.lblPostcodePers.Text = "Postcode";
            // 
            // lblCountryPers
            // 
            this.lblCountryPers.AutoSize = true;
            this.lblCountryPers.Location = new System.Drawing.Point(406, 151);
            this.lblCountryPers.Name = "lblCountryPers";
            this.lblCountryPers.Size = new System.Drawing.Size(64, 20);
            this.lblCountryPers.TabIndex = 21;
            this.lblCountryPers.Text = "Country";
            // 
            // lblPhonePers
            // 
            this.lblPhonePers.AutoSize = true;
            this.lblPhonePers.Location = new System.Drawing.Point(12, 151);
            this.lblPhonePers.Name = "lblPhonePers";
            this.lblPhonePers.Size = new System.Drawing.Size(113, 20);
            this.lblPhonePers.TabIndex = 22;
            this.lblPhonePers.Text = "Phone number";
            // 
            // PersContactCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 480);
            this.Controls.Add(this.lblPhonePers);
            this.Controls.Add(this.lblCountryPers);
            this.Controls.Add(this.lblPostcodePers);
            this.Controls.Add(this.lblAddressLine2Pers);
            this.Controls.Add(this.lblAddressLine1Pers);
            this.Controls.Add(this.lblEmailPers);
            this.Controls.Add(this.lblLastNamePers);
            this.Controls.Add(this.lblFirstNamePers);
            this.Controls.Add(this.tbCountryPers);
            this.Controls.Add(this.tbAddressLine2Pers);
            this.Controls.Add(this.tbPhonePers);
            this.Controls.Add(this.tbEmailPers);
            this.Controls.Add(this.tbAddressLine1Pers);
            this.Controls.Add(this.tbPostcodePers);
            this.Controls.Add(this.tbLastNamePers);
            this.Controls.Add(this.tbFirstNamePers);
            this.Controls.Add(this.btnSaveSel);
            this.Controls.Add(this.btnDeleteSel);
            this.Controls.Add(this.btnUpdateSel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvPers);
            this.Name = "PersContactCRUD";
            this.Text = "Personal Contacts Editor";
            this.Load += new System.EventHandler(this.PersContactCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPers;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSel;
        private System.Windows.Forms.Button btnDeleteSel;
        private System.Windows.Forms.Button btnSaveSel;
        private System.Windows.Forms.TextBox tbFirstNamePers;
        private System.Windows.Forms.TextBox tbLastNamePers;
        private System.Windows.Forms.TextBox tbPostcodePers;
        private System.Windows.Forms.TextBox tbAddressLine1Pers;
        private System.Windows.Forms.TextBox tbEmailPers;
        private System.Windows.Forms.TextBox tbPhonePers;
        private System.Windows.Forms.TextBox tbAddressLine2Pers;
        private System.Windows.Forms.TextBox tbCountryPers;
        private System.Windows.Forms.Label lblFirstNamePers;
        private System.Windows.Forms.Label lblLastNamePers;
        private System.Windows.Forms.Label lblEmailPers;
        private System.Windows.Forms.Label lblAddressLine1Pers;
        private System.Windows.Forms.Label lblAddressLine2Pers;
        private System.Windows.Forms.Label lblPostcodePers;
        private System.Windows.Forms.Label lblCountryPers;
        private System.Windows.Forms.Label lblPhonePers;
    }
}