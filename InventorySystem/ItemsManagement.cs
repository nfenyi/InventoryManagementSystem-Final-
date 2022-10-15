using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace InventorySystem
{
    public partial class ItemsManagement : Form
    {
        public ItemsManagement()
        {
            InitializeComponent();
            slide_panel.Height = add.Height;
            slide_panel.Top = add.Top;
            additem_panel.BringToFront();
        }

        //form load events
        private void Manager_home_Load(object sender, EventArgs e)
        {


            itemcode.Enabled = false;
            itemcode.Text = "Barcode Auto Number";
            FillGridView();

            u_itemcodeTxt.Enabled = false;
            u_itemcodeTxt.Text = "Barcode Auto Number";
            FillUpdateGridView();

            d_itemcodeTxt.Enabled = false;
            d_itemcodeTxt.Text = "Barcode Auto Number";
            FilldeleteGridView();

            p_order_idTxt.Enabled = false;
            p_order_idTxt.Text = "Barcode Auto Number";
            FillPaidGridView();

        }


        //logout button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        //------------------------------------navigation pane button events
        //add-item button
        private void add_Click(object sender, EventArgs e)
        {
            slide_panel.Height = add.Height;
            slide_panel.Top = add.Top;
            additem_panel.BringToFront();
            FillGridView();
            category.Clear();
            name.Clear();
            price.Clear();
            instock.Clear();
            itemcode.Enabled = false;
            itemcode.Text = "Barcode Auto Number";
        }
        //update item button
        private void update_Click(object sender, EventArgs e)
        {
            slide_panel.Height = update.Height;
            slide_panel.Top = update.Top;
            updateitems_panel.BringToFront();
            FillUpdateGridView();
            u_categoryTxt.Clear();
            u_nameTxt.Clear();
            u_priceTxt.Clear();
            u_stockTxt.Clear();
            u_itemcodeTxt.Enabled = false;
            u_itemcodeTxt.Text = "Barcode Auto Number";
        }
        //delete item button
        private void delete_Click(object sender, EventArgs e)
        {
            slide_panel.Height = delete.Height;
            slide_panel.Top = delete.Top;
            deleteitem_panel.BringToFront();
            FilldeleteGridView();
            d_categoryTxt.Clear();
            d_nameTxt.Clear();
            d_priceTxt.Clear();
            d_instockTxt.Clear();
            d_itemcodeTxt.Enabled = false;
            d_itemcodeTxt.Text = "Barcode Auto Number";
        }
        //paid orders button
        private void paid_orders_Click(object sender, EventArgs e)
        {
            slide_panel.Height = paid_orders.Height;
            slide_panel.Top = paid_orders.Top;
            paid_orders_panel.BringToFront();
            FillPaidGridView();
            p_order_detailsTxt.Clear();
            p_nameTxt.Clear();
            p_order_priceTxt.Clear();
            p_order_idTxt.Enabled = false;
            p_order_idTxt.Text = "Barcode Auto Number";
        }

        ////////////////////////////////////---------------INPUT ITEMS PANEL FUNCTIONS----------///////////////////////////////////////

        //The method executes when the add item button clicks
        private void additem_Click(object sender, EventArgs e)
        {
            if(category.Text!="" && name.Text!="" && price.Text!="" && instock.Text != "")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                    string query = "insert into `stock`(`category`,`name`,`price`,`instock`) values('" + category.Text.Trim() + "','" + name.Text.Trim() + "','" + price.Text.Trim() + "','" + instock.Text.Trim() + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been added successfully!");
                    category.Clear();
                    name.Clear();
                    price.Clear();
                    instock.Clear();
                    FillGridView();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should fill the all fields");
            }
        }//add item method end

        /*The function tht fills the datagridview*/
        void FillGridView()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from stock ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            itemlist.DataSource = dt;
        }

        /*The function that fills the text boxes when a gridview cell is clicked */
        private void itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.itemlist.Rows[e.RowIndex];
                itemcode.Text = row.Cells[0].Value.ToString();
                category.Text = row.Cells[1].Value.ToString();
                name.Text = row.Cells[2].Value.ToString();
                price.Text = row.Cells[3].Value.ToString();
                instock.Text = row.Cells[4].Value.ToString();
            }
        }

        ////////////////////////////////////---------------UPDATE ITEMS PANEL FUNCTIONS----------///////////////////////////////////////
        
        //The function executes when the update item button clicks
        private void u_itemBtn_Click(object sender, EventArgs e)
        {
            if (u_categoryTxt.Text != "" && u_nameTxt.Text != "" && u_priceTxt.Text != "" && u_stockTxt.Text != "")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                    string query = "update `stock` set `category`= '" + u_categoryTxt.Text + "',`name`= '" + u_nameTxt.Text + "',`price`='" + u_priceTxt.Text + "', `instock`= '" + u_stockTxt.Text + "'where `barcode`= '"+ u_itemcodeTxt.Text +"' ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item details are updated successfully!");
                    u_itemcodeTxt.Clear();
                    u_itemcodeTxt.Enabled = false;
                    u_itemcodeTxt.Text = "Barcode Auto Number";
                    u_categoryTxt.Clear();
                    u_nameTxt.Clear();
                    u_priceTxt.Clear();
                    u_stockTxt.Clear();
                    FillUpdateGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should select an item before updating !");
            }

        }//u_itemBtn method end

        /*The function that fills the datagridview*/
        void FillUpdateGridView()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
            MySqlDataAdapter u_sda = new MySqlDataAdapter("select * from stock ", conn);
            DataTable u_dt = new DataTable();
            u_sda.Fill(u_dt);
            u_dataGridView.DataSource = u_dt;
        }

        /*The function that fills the text boxes when a update gridview cell is clicked */
        private void u_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.u_dataGridView.Rows[e.RowIndex];
                u_itemcodeTxt.Text = row.Cells[0].Value.ToString();
                u_categoryTxt.Text = row.Cells[1].Value.ToString();
                u_nameTxt.Text = row.Cells[2].Value.ToString();
                u_priceTxt.Text = row.Cells[3].Value.ToString();
                u_stockTxt.Text = row.Cells[4].Value.ToString();
            }
        }

        ////////////////////////////////////---------------DELETE ITEMS PANEL FUNCTIONS----------///////////////////////////////////////

        //The function that executes when the delete items button clicks
        private void del_item_btn_Click(object sender, EventArgs e)
        {
            if (d_categoryTxt.Text != "" && d_nameTxt.Text != "" && d_priceTxt.Text != "" && d_instockTxt.Text != "")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                    string query = "delete from `stock` where `barcode`= '" + d_itemcodeTxt.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been successfully deleted!");
                    d_itemcodeTxt.Clear();
                    d_itemcodeTxt.Enabled = false;
                    d_itemcodeTxt.Text = "Id Auto Number";
                    d_categoryTxt.Clear();
                    d_nameTxt.Clear();
                    d_priceTxt.Clear();
                    d_instockTxt.Clear();
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

        /*The function that fills delete the datagridview*/
        void FilldeleteGridView()
        {
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
            MySqlDataAdapter d_sda = new MySqlDataAdapter("select * from stock ", conn);
            DataTable d_dt = new DataTable();
            d_sda.Fill(d_dt);
            d_item_dataGridView.DataSource = d_dt;
        }

        /*The function tht fills the text boxes when a delete gridview cell is clicked */
        private void d_item_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.d_item_dataGridView.Rows[e.RowIndex];
                d_itemcodeTxt.Text = row.Cells[0].Value.ToString();
                d_categoryTxt.Text = row.Cells[1].Value.ToString();
                d_nameTxt.Text = row.Cells[2].Value.ToString();
                d_priceTxt.Text = row.Cells[3].Value.ToString();
                d_instockTxt.Text = row.Cells[4].Value.ToString();
            }
        }


        ////////////////////////////////////---------------PAID ORDES PANEL FUNCTIONS----------///////////////////////////////////////

        

        /*The function tht fills paid orders datagridview*/
        void FillPaidGridView()
        {
           
            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
            MySqlDataAdapter p_sda = new MySqlDataAdapter("select id,user,details,price,date from orders ", conn);
            DataTable p_dt = new DataTable();
            p_sda.Fill(p_dt);
            paid_dataGridView1.DataSource = p_dt;
        }

        /*The function tht fills the text boxes when a delete gridview cell is clicked*/
        private void paid_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.paid_dataGridView1.Rows[e.RowIndex];
                p_order_idTxt.Text = row.Cells[0].Value.ToString();
                p_order_detailsTxt.Text = row.Cells[1].Value.ToString();
                p_nameTxt.Text = row.Cells[2].Value.ToString();
                p_order_priceTxt.Text = row.Cells[3].Value.ToString();
            }
        }

        //The function tht executes when the cancel order button is clicked
        private void cancel_order_btn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear purchases?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                        string query = "delete * from `orders`";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        p_order_idTxt.Clear();
                        p_order_idTxt.Enabled = false;
                        p_order_idTxt.Text = "Id Auto Number";
                        p_order_detailsTxt.Clear();
                        p_nameTxt.Clear();
                        p_order_priceTxt.Clear();
                        FillPaidGridView();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        ////////////////////////////////////---------------UNPAID ORDES PANEL FUNCTIONS----------///////////////////////////////////////

        




        //export pdf function
        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //add datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(itemlist, "item-List Report");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            exportgridtopdf(paid_dataGridView1, "Paid order-List Report");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (category.Text != "" && name.Text != "" && price.Text != "" && instock.Text != "")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                    string query = "insert into `stock`(`category`,`name`,`price`,`instock`) values('" + category.Text.Trim() + "','" + name.Text.Trim() + "','" + price.Text.Trim() + "','" + instock.Text.Trim() + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item has been added successfully!");
                    category.Clear();
                    name.Clear();
                    price.Clear();
                    instock.Clear();
                    FillGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You should fill the all fields");
            }
        }

        private void paid_orders_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
