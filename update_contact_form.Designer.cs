
namespace marathon_contacts
{
    partial class update_contact_form
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(304, 205);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 34);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(166, 205);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(112, 34);
            this.update_btn.TabIndex = 18;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(166, 145);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(606, 31);
            this.phone_txt.TabIndex = 17;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(166, 106);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(606, 31);
            this.mail_txt.TabIndex = 16;
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(166, 65);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(606, 31);
            this.last_name_txt.TabIndex = 15;
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(166, 27);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(606, 31);
            this.first_name_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "First name:";
            // 
            // update_contact_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 266);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.last_name_txt);
            this.Controls.Add(this.first_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "update_contact_form";
            this.Text = "Update contact";
            this.Load += new System.EventHandler(this.update_contact_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}