using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace marathon_contacts
{
    public partial class add_contact_form : Form
    {
        public add_contact_form()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string first_name = first_name_txt.Text;
            string last_name = last_name_txt.Text;
            string mail = mail_txt.Text;
            string phone = phone_txt.Text;

            string ip_address;
            string user;
            string password;
            string database = "marathon_contacts";

            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");

            string conn_string;
            SqlConnection conn;

            if (Directory.Exists(directory_path))
            {
                using (StreamReader sr = new StreamReader(file_path, Encoding.Default))
                {
                    string text = sr.ReadToEnd();
                    string[] sets = text.Split(';');
                    foreach (string s in sets)
                    {

                    }

                    ip_address = sets[0];
                    user = sets[1];
                    password = sets[2];
                }
                try
                {
                    conn_string = @"Data Source=" + ip_address + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + password + ";";
                    conn = new SqlConnection(conn_string);
                    conn.Open();
                    string sql_com = @"INSERT INTO Contacts(First_name, Last_name, Email, Phone) VALUES('"+first_name+"','"+last_name+"','"+mail+"','"+phone+"')";
                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void add_contact_form_Load(object sender, EventArgs e)
        {

        }
    }
}
