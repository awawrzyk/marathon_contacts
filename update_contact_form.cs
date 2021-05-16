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
    public partial class update_contact_form : Form
    {
        public update_contact_form()
        {
            InitializeComponent();
        }

        private void update_contact_form_Load(object sender, EventArgs e)
        {
            download_to_text();
        }

        void delete_data()
        {
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
                    string sql_com = "DELETE FROM Temp";
                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        void download_to_text()
        {
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
                    string sql_com = "SELECT * FROM Temp";
                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        first_name_txt.Text = dr["First_name"].ToString();
                        last_name_txt.Text = dr["Last_name"].ToString();
                        mail_txt.Text = dr["Mail"].ToString();
                        phone_txt.Text = dr["Phone"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            delete_data();
            this.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string first_name = first_name_txt.Text;
            string last_name = last_name_txt.Text;
            string mail = mail_txt.Text;
            string phone = phone_txt.Text;

            string first_name_download;
            string last_name_download;
            string mail_download;
            string phone_download;

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

                    string sql_download = @"SELECT * FROM Temp";
                    SqlCommand cmd_download = new SqlCommand(sql_download, conn);
                    SqlDataReader dr = cmd_download.ExecuteReader();
                    while (dr.Read())
                    {
                        first_name_download = dr["First_name"].ToString();
                        last_name_download = dr["Last_name"].ToString();
                        mail_download = dr["Mail"].ToString();
                        phone_download = dr["Phone"].ToString();
                        conn.Close();
                        string sql_com = @"UPDATE Contacts SET First_name='" + first_name + "', Last_name='" + last_name + "',Email='" + mail + "',Phone='" + phone + "' WHERE First_name='" + first_name_download + "'AND Last_name='" + last_name_download + "'AND Email='" + mail_download + "'AND Phone='" + phone_download+"'";
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql_com, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        delete_data();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
