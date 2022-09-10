using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{  
    public partial class Confirm : Form
    {
        public Home MyParent { get; set; }
        DateTime dateTime = DateTime.Now;
        public string barcode;
        private PrintDocument docToPrint;
        private string stringToPrint;
        public string receiptContent = "SHOPRITE SHOPPING MALL \nRECEIPT OF SALE\nAddress: Accra Mall, Spintex Road\nTel: +233509428913" +
            "\n\n\n---------------------------------\n";
        private int total;

        public Confirm()
        {
            InitializeComponent();
            this.docToPrint = new PrintDocument();
            
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = MyParent.ItemList;
            receiptContent += dateTime.ToString("f") + "\nITEMS\n\n\n---------------------------------\n" + richTextBox1.Text + "\n\n\nTOTAL:" ;
        }

        private void Confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.Enabled = true;
        }

       
        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserDetails user = new UserDetails();
                Home home = new Home();
                string dateTimeHolder = dateTime.ToString("f", DateTimeFormatInfo.InvariantInfo);
                
                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
                string query = "insert into `orders`(`user`,`date`,`details`,`price`) values('" + user.getUName() + "','"+ dateTimeHolder +"','" + MyParent.ItemList + "'," + MyParent.TotalPrice + ");" + MyParent.UpdateQuery + "";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                PrintDialog myPrintDialog = new PrintDialog();
                myPrintDialog.AllowCurrentPage = true;
                myPrintDialog.AllowSelection = true;
                myPrintDialog.AllowSomePages = true;
                myPrintDialog.Document = docToPrint;
                double change = Convert.ToDouble(cashTextBox.Text) - Convert.ToDouble(MyParent.TotalPrice);
                receiptContent += MyParent.TotalPrice + "\nCash:" +cashTextBox.Text+ "\n" + "Change:" + change +"\n---------------------------------\n\nTHANK YOU!";
                if (myPrintDialog.ShowDialog() == DialogResult.OK)
                {
                    StringReader reader = new StringReader(receiptContent);
                    stringToPrint = reader.ReadToEnd();
                    this.docToPrint.PrintPage += new PrintPageEventHandler(this.docToPrintCustom);
                    this.docToPrint.Print();
                    MessageBox.Show("Receipt Printed");
                }
                
                clearOrderBtn_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearOrderBtn_Click(object sender, EventArgs e)
        {
            MyParent.ItemList = "";
            MyParent.TotalPrice = 0;
            MyParent.UpdateQuery = "";
            this.Close();
        }
        private void docToPrintCustom(object sender, PrintPageEventArgs e)
        {
            Font PrintFont = this.richTextBox1.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            int LinesPerPage = 0;
            int charactersOnPage = 0;

            e.Graphics.MeasureString(stringToPrint, PrintFont, e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out LinesPerPage);

            e.Graphics.DrawString(stringToPrint, PrintFont, PrintBrush, e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);

            MessageBox.Show(stringToPrint.Length.ToString());
            e.HasMorePages = (stringToPrint.Length > 0);

            PrintBrush.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
