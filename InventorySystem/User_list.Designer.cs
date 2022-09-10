namespace InventorySystem
{
    partial class User_list
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.users_list = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectedUserId = new System.Windows.Forms.TextBox();
            this.changePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 26);
            this.panel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(605, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(26, 20);
            this.close_btn.TabIndex = 68;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // users_list
            // 
            this.users_list.BackgroundColor = System.Drawing.Color.White;
            this.users_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_list.Location = new System.Drawing.Point(52, 96);
            this.users_list.Margin = new System.Windows.Forms.Padding(2);
            this.users_list.Name = "users_list";
            this.users_list.RowHeadersWidth = 43;
            this.users_list.RowTemplate.Height = 24;
            this.users_list.Size = new System.Drawing.Size(553, 254);
            this.users_list.TabIndex = 2;
            this.users_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_list_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(260, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 67;
            this.label1.Text = "Users List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(519, 401);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 31);
            this.deleteBtn.TabIndex = 68;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // selectedUserId
            // 
            this.selectedUserId.Location = new System.Drawing.Point(52, 374);
            this.selectedUserId.Name = "selectedUserId";
            this.selectedUserId.Size = new System.Drawing.Size(173, 20);
            this.selectedUserId.TabIndex = 69;
            this.selectedUserId.Text = "Selected User Id:";
            this.selectedUserId.TextChanged += new System.EventHandler(this.selectedId_TextChanged);
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(373, 405);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(128, 23);
            this.changePassword.TabIndex = 72;
            this.changePassword.Text = "Change Password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // User_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 444);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.selectedUserId);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.users_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_list";
            this.Load += new System.EventHandler(this.User_list_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView users_list;
        private System.Windows.Forms.Button close_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox selectedUserId;
        private System.Windows.Forms.Button changePassword;
    }
}