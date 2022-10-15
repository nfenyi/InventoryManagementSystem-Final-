using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class MyOrders : Form
    {
        DateTime dateTime = DateTime.Now;

        public MyOrders()
        {
            InitializeComponent();
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            label9.Text = user.getUName();
            
            FillOrders();
        }

        void FillOrders()
        {
            try
            {
                string dateTimeHolder = dateTime.ToString("D", DateTimeFormatInfo.InvariantInfo) + "%";
                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT id,details,price FROM `orders` where user ='"+label9.Text+"' and date like '"+ dateTimeHolder + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Attendant_Screen home = new Attendant_Screen();
            this.Close();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
    }

        private void New_Click(object sender, EventArgs e)
        {
            Attendant_Screen home = new Attendant_Screen();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
