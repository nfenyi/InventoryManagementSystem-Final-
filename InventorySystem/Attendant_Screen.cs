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
    public partial class Attendant_Screen : Form
    {
        public string ItemList="";
        public float TotalPrice=0;
        public string UpdateQuery="";
        DateTime dateTime = DateTime.Now;


        public Attendant_Screen()
        {
            InitializeComponent();
        }
        Confirm confirm = new Confirm();
       
        private void Home_Load(object sender, EventArgs e)
        {
            ItemList = "";
            TotalPrice = 0;
            UpdateQuery = "";

            UserDetails user = new UserDetails();
            label9.Text = user.getUName();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                confirm.barcode = textBox1.Text;
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                priceTxtFld.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox6.Text) >= int.Parse(qtyTxtFld.Text))
                {
                    ItemList += textBox2.Text + " " + textBox3.Text + " " + " " + priceTxtFld.Text + "*" + qtyTxtFld.Text + Environment.NewLine;
                    TotalPrice += float.Parse(priceTxtFld.Text) * float.Parse(qtyTxtFld.Text);
                    UpdateQuery += "update stock set instock='" + (int.Parse(textBox6.Text) - int.Parse(qtyTxtFld.Text)) + "' where barcode='" + textBox1.Text + "';";
                    String msg = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + "*" + qtyTxtFld.Text;
                    MessageBox.Show(msg + Environment.NewLine + "Added to Cart");
                }
                else
                {
                    MessageBox.Show("Not Enough Items in Stock");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter in Correct Format");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (this.ItemList == "")
            {
                MessageBox.Show("No Items Selected");
            }
            else
            {
                var childform = new Confirm();
                childform.barcode = confirm.barcode;
                childform.MyParent = this;
                childform.Show();
                this.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewMyOrdersBtn_Click(object sender, EventArgs e)
        {
            MyOrders orders = new MyOrders();
            orders.Show();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from stock where barcode='" + scanBarcodeTxtFld.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
