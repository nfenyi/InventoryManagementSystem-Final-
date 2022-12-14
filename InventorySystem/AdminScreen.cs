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
using System.Security.Cryptography;

namespace InventorySystem
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            slide_panel.Height = dashboard_btn.Height;
            dashboard_panel.BringToFront();
        }

        //logout button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //------------------------------------navigation pane button events
        //dashboard button
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = dashboard_btn.Height;
            slide_panel.Top = dashboard_btn.Top;
            dashboard_panel.BringToFront();
        }
        //add admin button
        private void add_admin_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = add_admin_btn.Height;
            slide_panel.Top = add_admin_btn.Top;
            add_admin_panel.BringToFront();
            User_list user = new User_list();
            user.Close();
        }
        private void user_list_btn_Click(object sender, EventArgs e)
        {
            slide_panel.Height = user_list_btn.Height;
            slide_panel.Top = user_list_btn.Top;
            User_list users_list = new User_list();
            users_list.Show();
        }


        ////////////////////////////////////---------------DASHBOARD PANEL FUNCTIONS----------///////////////////////////////////////

        //The method executes when the user home button clicks
        private void user_home_btn_Click(object sender, EventArgs e)
        {
            Attendant_Screen user_home = new Attendant_Screen();
            user_home.Show();

        }

        private void itemManagement_home_btn_Click(object sender, EventArgs e)
        {
            ItemsManagement itemManagement = new ItemsManagement();
            itemManagement.Show();
        }

        private void item_check_btn_Click(object sender, EventArgs e)
        {
            ItemsManagement itemManagement = new ItemsManagement();
            itemManagement.Show();
        }

        private void check_orders_btn_Click(object sender, EventArgs e)
        {
            ItemsManagement itemManagement = new ItemsManagement();
            itemManagement.Show();
        }


        ////////////////////////////////////---------------Add itemManagement PANEL FUNCTIONS----------///////////////////////////////////////

        //The method executes when the create itemManagement acc button clicks
        private void Mregister_btn_Click(object sender, EventArgs e)
        {
            if (MfnameTxt.Text != "" && MlnameTxt.Text != "" && MusernameTxt.Text != "" && MphonenumTxt.Text != "" && MpassTxt.Text != "" && MrepassTxt.Text != "" && typecomboTxt.Text != "")
            {
                if (MpassTxt.Text == MrepassTxt.Text)
                {
                    try
                    {
                        
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventory;");
                        string query = "insert into `users`(`first`,`last`,`username`,`phone`,`password`,`usertype`) values('" + MfnameTxt.Text.Trim() + "','" + MlnameTxt.Text.Trim() + "','" + MusernameTxt.Text.Trim() + "','" + MphonenumTxt.Text.Trim() + "','" + MD5Hash(MpassTxt.Text.Trim()) + "','" + typecomboTxt.Text.Trim() + "')";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("New Attendant account has been created successfully!");
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("This Username is already taken!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Given password doesn't match!!");
                }
            }
            else
                MessageBox.Show("Fill all fields");
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_manager_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            UserDetails user = new UserDetails();
            label1.Text = user.getUName();
        }

        private void typecomboTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
