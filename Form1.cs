using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace marathon_contacts
{
    public partial class main_form : Form
    {

        
        public main_form()
        {
            InitializeComponent();
            //check_file();
            download_data();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            settings_form settings = new settings_form();
            settings.Show();
        }

        void check_file()
        {
            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contatacts\settings.txt");
            if(File.Exists(file_path))
            {
                
            }
            else
            {
                DialogResult DiagRes = MessageBox.Show("Settings file does not exist. Do you want to create it now?", "Settings file error!", MessageBoxButtons.YesNo);
                if (DiagRes == DialogResult.Yes)
                {
                    settings_form settings = new settings_form();
                    settings.TopLevel = true;
                    settings.Show();
                }
                else if (DiagRes == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        public void download_data()
        {
            string ip_address;
            string user;
            string password;
            string database="marathon_contacts";

            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");

            string conn_string;
            SqlConnection conn;

            if(Directory.Exists(directory_path))
            {
                using(StreamReader sr=new StreamReader(file_path, Encoding.Default))
                {
                    string text = sr.ReadToEnd();
                    string[] sets = text.Split(';');
                    foreach(string s in sets)
                    {

                    }

                    ip_address = sets[0];
                    user = sets[1];
                    password = sets[2];
                }
                try
                {
                    contacts_list.Items.Clear();
                    conn_string = @"Data Source=" + ip_address + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + password + ";";
                    conn = new SqlConnection(conn_string);
                    conn.Open();
                    string sql_com = "SELECT * FROM Contacts";
                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while(dr.Read())
                    {
                        ListViewItem list_item = new ListViewItem(dr.GetString(0));
                        list_item.SubItems.Add(dr.GetString(1));
                        list_item.SubItems.Add(dr.GetString(2));
                        list_item.SubItems.Add(dr.GetString(3));
                        contacts_list.Items.Add(list_item);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_contact_form add_con = new add_contact_form();
            add_con.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            download_data();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string mail;
            string phone;

            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");

            string ip_address;
            string user;
            string password;
            string database = "marathon_contacts";

            string conn_string;
            SqlConnection conn;

            if (contacts_list.SelectedItems.Count>0)
            {
                ListViewItem item = contacts_list.SelectedItems[0];

                first = item.SubItems[0].Text;
                last = item.SubItems[1].Text;
                mail = item.SubItems[2].Text;
                phone = item.SubItems[3].Text;

                if(Directory.Exists(directory_path))
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
                    contacts_list.Items.Clear();
                    conn_string = @"Data Source=" + ip_address + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + password + ";";
                    conn = new SqlConnection(conn_string);
                    conn.Open();
                    string sql_com = "DELETE FROM Contacts WHERE First_name='"+first+"'AND Last_name='"+last+"'AND Email='"+mail+"'AND Phone='"+phone+"'";

                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    download_data();
                }

                
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            download_from_list();
            update_contact_form update = new update_contact_form();
            update.Show();
        }

        public void download_from_list()
        {
            string first;
            string last;
            string mail;
            string phone;

            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_path = Path.Combine(app_data, @"Marathon Contacts\settings.txt");
            string directory_path = Path.Combine(app_data, @"Marathon Contacts");

            string ip_address;
            string user;
            string password;
            string database = "marathon_contacts";

            string conn_string;
            SqlConnection conn;

            if (contacts_list.SelectedItems.Count > 0)
            {
                ListViewItem item = contacts_list.SelectedItems[0];

                first = item.SubItems[0].Text;
                last = item.SubItems[1].Text;
                mail = item.SubItems[2].Text;
                phone = item.SubItems[3].Text;

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
                   // contacts_list.Items.Clear();
                    conn_string = @"Data Source=" + ip_address + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + password + ";";
                    conn = new SqlConnection(conn_string);
                    conn.Open();
                    string sql_com = @"INSERT INTO Temp(First_name, Last_name, Mail, Phone) VALUES('" + first + "','" + last + "','" + mail + "','" + phone + "')";

                    SqlCommand cmd = new SqlCommand(sql_com, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //download_data();
                }
            }

            }
        }
    }

