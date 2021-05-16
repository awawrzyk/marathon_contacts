using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace marathon_contacts
{
    public partial class settings_form : Form
    {
        public settings_form()
        {
            InitializeComponent();
            show_settings();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void show_settings()
        {
            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");
            if (Directory.Exists(directory_path))
            {
                using (StreamReader sr = new StreamReader(file_path, Encoding.Default))
                {
                    string text = sr.ReadToEnd();
                    string[] sets = text.Split(';');
                    foreach (string s in sets)
                    {

                    }
                    ip_txt.Text = sets[0];
                    user_txt.Text = sets[1];
                    password_txt.Text = sets[2];
                }
            }
        }
        private void connect_btn_Click(object sender, EventArgs e)
        {
            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");

            if (!Directory.Exists(directory_path))
            {
                Directory.CreateDirectory(directory_path);
            }
            else
            {
                using (FileStream fs = File.Create(file_path))
                {
                    Byte[] set_conn = new UTF8Encoding(true).GetBytes(ip_txt.Text + ";" + user_txt.Text + ";" + password_txt.Text);
                    fs.Write(set_conn, 0, set_conn.Length);

                }
                
            }

            this.Close();
        }
    }
}
