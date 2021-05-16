
namespace marathon_contacts
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contacts_list = new System.Windows.Forms.ListView();
            this.first_name = new System.Windows.Forms.ColumnHeader();
            this.last_name = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contacts_list
            // 
            this.contacts_list.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.contacts_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contacts_list.BackColor = System.Drawing.SystemColors.Control;
            this.contacts_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.email,
            this.phone});
            this.contacts_list.HideSelection = false;
            this.contacts_list.Location = new System.Drawing.Point(13, 13);
            this.contacts_list.Name = "contacts_list";
            this.contacts_list.Size = new System.Drawing.Size(775, 354);
            this.contacts_list.TabIndex = 0;
            this.contacts_list.UseCompatibleStateImageBehavior = false;
            this.contacts_list.View = System.Windows.Forms.View.Details;
            // 
            // first_name
            // 
            this.first_name.Text = "First name";
            this.first_name.Width = 200;
            // 
            // last_name
            // 
            this.last_name.Text = "Last name";
            this.last_name.Width = 200;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.Width = 200;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 200;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_btn.AutoSize = true;
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.Location = new System.Drawing.Point(13, 388);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(144, 72);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete_btn.AutoSize = true;
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.Location = new System.Drawing.Point(163, 388);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(144, 72);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_btn.AutoSize = true;
            this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settings_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings_btn.Location = new System.Drawing.Point(644, 388);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(144, 72);
            this.settings_btn.TabIndex = 3;
            this.settings_btn.Text = "SETTINGS";
            this.settings_btn.UseVisualStyleBackColor = false;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh_btn.AutoSize = true;
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh_btn.Location = new System.Drawing.Point(463, 388);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(144, 72);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "REFRESH";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.update_btn.AutoSize = true;
            this.update_btn.BackColor = System.Drawing.Color.Violet;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.Location = new System.Drawing.Point(313, 388);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(144, 72);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.contacts_list);
            this.Name = "main_form";
            this.Text = "MARATHON CONTACTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.ColumnHeader first_name;
        public System.Windows.Forms.ColumnHeader last_name;
        public System.Windows.Forms.ColumnHeader email;
        public System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.ListView contacts_list;
    }
}

