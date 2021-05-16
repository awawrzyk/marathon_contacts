
namespace marathon_contacts
{
    partial class add_contact_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(161, 48);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(606, 31);
            this.first_name_txt.TabIndex = 4;
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(161, 88);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(606, 31);
            this.last_name_txt.TabIndex = 5;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(161, 130);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(606, 31);
            this.mail_txt.TabIndex = 6;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(161, 172);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(606, 31);
            this.phone_txt.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(161, 230);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 34);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(299, 230);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 34);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_contact_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 279);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.last_name_txt);
            this.Controls.Add(this.first_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_contact_form";
            this.Text = "Add contact";
            this.Load += new System.EventHandler(this.add_contact_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}