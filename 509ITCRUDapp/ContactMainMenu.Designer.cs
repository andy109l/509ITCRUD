namespace _509ITCRUDapp
{
    partial class ContactMainMenu
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
            this.btnPersContacts = new System.Windows.Forms.Button();
            this.btnBusiContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersContacts
            // 
            this.btnPersContacts.Location = new System.Drawing.Point(139, 120);
            this.btnPersContacts.Name = "btnPersContacts";
            this.btnPersContacts.Size = new System.Drawing.Size(137, 79);
            this.btnPersContacts.TabIndex = 0;
            this.btnPersContacts.Text = "Personal Contacts";
            this.btnPersContacts.UseVisualStyleBackColor = true;
            this.btnPersContacts.Click += new System.EventHandler(this.btn_pers_contacts_click);
            // 
            // btnBusiContacts
            // 
            this.btnBusiContacts.Location = new System.Drawing.Point(478, 120);
            this.btnBusiContacts.Name = "btnBusiContacts";
            this.btnBusiContacts.Size = new System.Drawing.Size(137, 79);
            this.btnBusiContacts.TabIndex = 1;
            this.btnBusiContacts.Text = "Business Contacts";
            this.btnBusiContacts.UseVisualStyleBackColor = true;
            this.btnBusiContacts.Click += new System.EventHandler(this.btn_busi_contacts_click);
            // 
            // ContactMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 309);
            this.Controls.Add(this.btnBusiContacts);
            this.Controls.Add(this.btnPersContacts);
            this.Name = "ContactMainMenu";
            this.Text = "509IT CRUDapp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersContacts;
        private System.Windows.Forms.Button btnBusiContacts;
    }
}