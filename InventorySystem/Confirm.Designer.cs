namespace InventorySystem
{
    partial class Confirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.clearOrderBtn = new System.Windows.Forms.Button();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.customersCash = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(31, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(477, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 26);
            this.panel1.TabIndex = 32;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.button4;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 35;
            this.bunifuElipse3.TargetControl = this;
            // 
            // clearOrderBtn
            // 
            this.clearOrderBtn.BackColor = System.Drawing.Color.DarkRed;
            this.clearOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearOrderBtn.Location = new System.Drawing.Point(60, 345);
            this.clearOrderBtn.Name = "clearOrderBtn";
            this.clearOrderBtn.Size = new System.Drawing.Size(129, 33);
            this.clearOrderBtn.TabIndex = 33;
            this.clearOrderBtn.Text = "Clear Order";
            this.clearOrderBtn.UseVisualStyleBackColor = false;
            this.clearOrderBtn.Click += new System.EventHandler(this.clearOrderBtn_Click);
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmOrderBtn.Location = new System.Drawing.Point(359, 345);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(134, 33);
            this.confirmOrderBtn.TabIndex = 34;
            this.confirmOrderBtn.Text = "Confirm Order";
            this.confirmOrderBtn.UseVisualStyleBackColor = false;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // cashTextBox
            // 
            this.cashTextBox.BackColor = System.Drawing.Color.White;
            this.cashTextBox.Location = new System.Drawing.Point(138, 296);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(171, 20);
            this.cashTextBox.TabIndex = 37;
            this.cashTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customersCash
            // 
            this.customersCash.AutoSize = true;
            this.customersCash.Location = new System.Drawing.Point(28, 299);
            this.customersCash.Name = "customersCash";
            this.customersCash.Size = new System.Drawing.Size(88, 13);
            this.customersCash.TabIndex = 38;
            this.customersCash.Text = "Customer\'s Cash:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(508, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 405);
            this.Controls.Add(this.customersCash);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.confirmOrderBtn);
            this.Controls.Add(this.clearOrderBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Confirm_FormClosed);
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Button clearOrderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label customersCash;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Button button2;
    }
}