using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace InventorySystem
{
    
    public partial class Change_password : Form
    {
        public Change_password()
        {
            InitializeComponent();
        }

        public string id;

        private void Change_password_Load(object sender, EventArgs e)
        {
           
        }

        
        
        private void close_btn_Click(object sender, EventArgs e)
        {
            User_list userList = new User_list();
            userList.Show();
            this.Close();
        }
      

     
      
      
      

        private void changePassword_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == confirmNewPassword.Text && id != "Selected User Id:") 
            {
                 try
                 {
                     MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                    Login login = new Login();
                    string query = "update `users` set `password`= '" + Login.MD5Hash(confirmNewPassword.Text.Trim()) + "'where `id` = '" + id +"' ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                     conn.Open();
                     cmd.ExecuteNonQuery();
                     conn.Close();
                     MessageBox.Show("Password changed successfully!");
                     this.Close();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.ToString());
                 }
             }
             else
             {
                 MessageBox.Show("Make sure you've typed the password twice correctly.");
                newPassword.Clear();
                confirmNewPassword.Clear();
             }
            
            }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(id);
        }
    }
    }
