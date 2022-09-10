using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class User_list : Form
    {
        public User_list()
        {
            InitializeComponent();
        }
        public string barcode;

        //fill grid view method
        void Filluserlist()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
            MySqlDataAdapter list = new MySqlDataAdapter("select id,first,last,username,phone,usertype from users ", conn);
            DataTable dtlist = new DataTable();
            list.Fill(dtlist);
            users_list.DataSource = dtlist;
        }

        private void User_list_Load(object sender, EventArgs e)
        {
            Filluserlist();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(selectedUserId.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            AdminScreen admin = new AdminScreen();
            admin.Show();
            this.Close();
        }

        private void users_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.users_list.Rows[e.RowIndex];
                selectedUserId.Text = row.Cells[0].Value.ToString();
                barcode = selectedUserId.Text;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId.Text != "Selected Item Id:")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
                    string query = "delete from `users` where `barcode`= '" + selectedUserId.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been successfully deleted!");
                    selectedUserId.Clear();
                    selectedUserId.Text = "Selected Item:";
                    FilldeleteGridView();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should select a row before deleting!");
            }
        }
        /*The function that fills the delete datagridview*/
        void FilldeleteGridView()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
            MySqlDataAdapter d_sda = new MySqlDataAdapter("select * from users ", conn);
            DataTable d_dt = new DataTable();
            d_sda.Fill(d_dt);
            users_list.DataSource = d_dt;
        }
        private System.Windows.Forms.DataGridView itemlist;

        private void button1_Click(object sender, EventArgs e)
        {
             
        
        }
        void FillUpdateGridView()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
            MySqlDataAdapter u_sda = new MySqlDataAdapter("select * from users ", conn);
            DataTable u_dt = new DataTable();
            u_sda.Fill(u_dt);
            users_list.DataSource = u_dt;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            Change_password chPassword = new Change_password();
            chPassword.id = selectedUserId.Text;
            chPassword.Show();
        }

        private void selectedId_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
