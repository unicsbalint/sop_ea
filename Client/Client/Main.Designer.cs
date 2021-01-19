namespace Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_users = new System.Windows.Forms.TabPage();
            this.bt_List = new System.Windows.Forms.Button();
            this.lb_users = new System.Windows.Forms.ListBox();
            this.tab_cars = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cars_cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cars_platenumber = new System.Windows.Forms.TextBox();
            this.tb_cars_type = new System.Windows.Forms.TextBox();
            this.bt_cars_modify = new System.Windows.Forms.Button();
            this.bt_cars_Add = new System.Windows.Forms.Button();
            this.bt_list_Cars = new System.Windows.Forms.Button();
            this.lb_cars = new System.Windows.Forms.ListBox();
            this.tab_borrowed = new System.Windows.Forms.TabPage();
            this.bt_listBorrowed = new System.Windows.Forms.Button();
            this.lb_borrowed = new System.Windows.Forms.ListBox();
            this.tab_userpanel = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_usercars = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_yourUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_tartozas = new System.Windows.Forms.Label();
            this.bt_cars_delete = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_cars_borrow = new System.Windows.Forms.Button();
            this.bt_userpanel_idontneedthat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab_users.SuspendLayout();
            this.tab_cars.SuspendLayout();
            this.tab_borrowed.SuspendLayout();
            this.tab_userpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_userpanel);
            this.tabControl1.Controls.Add(this.tab_users);
            this.tabControl1.Controls.Add(this.tab_cars);
            this.tabControl1.Controls.Add(this.tab_borrowed);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_users
            // 
            this.tab_users.Controls.Add(this.pictureBox2);
            this.tab_users.Controls.Add(this.bt_List);
            this.tab_users.Controls.Add(this.lb_users);
            this.tab_users.Location = new System.Drawing.Point(4, 29);
            this.tab_users.Name = "tab_users";
            this.tab_users.Padding = new System.Windows.Forms.Padding(3);
            this.tab_users.Size = new System.Drawing.Size(792, 417);
            this.tab_users.TabIndex = 0;
            this.tab_users.Text = "Users";
            this.tab_users.UseVisualStyleBackColor = true;
            // 
            // bt_List
            // 
            this.bt_List.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_List.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_List.Location = new System.Drawing.Point(667, 362);
            this.bt_List.Name = "bt_List";
            this.bt_List.Size = new System.Drawing.Size(99, 36);
            this.bt_List.TabIndex = 1;
            this.bt_List.Text = "Refresh";
            this.bt_List.UseVisualStyleBackColor = false;
            this.bt_List.Click += new System.EventHandler(this.bt_List_Click);
            // 
            // lb_users
            // 
            this.lb_users.FormattingEnabled = true;
            this.lb_users.ItemHeight = 20;
            this.lb_users.Location = new System.Drawing.Point(306, 19);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(460, 324);
            this.lb_users.TabIndex = 0;
            // 
            // tab_cars
            // 
            this.tab_cars.Controls.Add(this.bt_cars_borrow);
            this.tab_cars.Controls.Add(this.label6);
            this.tab_cars.Controls.Add(this.tb_cars_cost);
            this.tab_cars.Controls.Add(this.label2);
            this.tab_cars.Controls.Add(this.label1);
            this.tab_cars.Controls.Add(this.tb_cars_platenumber);
            this.tab_cars.Controls.Add(this.tb_cars_type);
            this.tab_cars.Controls.Add(this.bt_cars_modify);
            this.tab_cars.Controls.Add(this.bt_cars_Add);
            this.tab_cars.Controls.Add(this.bt_cars_delete);
            this.tab_cars.Controls.Add(this.bt_list_Cars);
            this.tab_cars.Controls.Add(this.lb_cars);
            this.tab_cars.Location = new System.Drawing.Point(4, 29);
            this.tab_cars.Name = "tab_cars";
            this.tab_cars.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cars.Size = new System.Drawing.Size(792, 417);
            this.tab_cars.TabIndex = 1;
            this.tab_cars.Text = "Cars";
            this.tab_cars.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cost";
            // 
            // tb_cars_cost
            // 
            this.tb_cars_cost.Location = new System.Drawing.Point(128, 103);
            this.tb_cars_cost.Name = "tb_cars_cost";
            this.tb_cars_cost.Size = new System.Drawing.Size(100, 26);
            this.tb_cars_cost.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Plate number:";
            // 
            // tb_cars_platenumber
            // 
            this.tb_cars_platenumber.Location = new System.Drawing.Point(128, 39);
            this.tb_cars_platenumber.Name = "tb_cars_platenumber";
            this.tb_cars_platenumber.Size = new System.Drawing.Size(100, 26);
            this.tb_cars_platenumber.TabIndex = 14;
            // 
            // tb_cars_type
            // 
            this.tb_cars_type.Location = new System.Drawing.Point(128, 71);
            this.tb_cars_type.Name = "tb_cars_type";
            this.tb_cars_type.Size = new System.Drawing.Size(100, 26);
            this.tb_cars_type.TabIndex = 11;
            // 
            // bt_cars_modify
            // 
            this.bt_cars_modify.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_cars_modify.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_cars_modify.Location = new System.Drawing.Point(185, 140);
            this.bt_cars_modify.Name = "bt_cars_modify";
            this.bt_cars_modify.Size = new System.Drawing.Size(85, 41);
            this.bt_cars_modify.TabIndex = 8;
            this.bt_cars_modify.Text = "Modify";
            this.bt_cars_modify.UseVisualStyleBackColor = false;
            this.bt_cars_modify.Click += new System.EventHandler(this.bt_cars_modify_Click);
            // 
            // bt_cars_Add
            // 
            this.bt_cars_Add.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_cars_Add.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_cars_Add.Location = new System.Drawing.Point(103, 140);
            this.bt_cars_Add.Name = "bt_cars_Add";
            this.bt_cars_Add.Size = new System.Drawing.Size(76, 41);
            this.bt_cars_Add.TabIndex = 9;
            this.bt_cars_Add.Text = "Add";
            this.bt_cars_Add.UseVisualStyleBackColor = false;
            this.bt_cars_Add.Click += new System.EventHandler(this.bt_cars_Add_Click);
            // 
            // bt_list_Cars
            // 
            this.bt_list_Cars.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_list_Cars.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_list_Cars.Location = new System.Drawing.Point(698, 380);
            this.bt_list_Cars.Name = "bt_list_Cars";
            this.bt_list_Cars.Size = new System.Drawing.Size(86, 29);
            this.bt_list_Cars.TabIndex = 3;
            this.bt_list_Cars.Text = "Refresh";
            this.bt_list_Cars.UseVisualStyleBackColor = false;
            this.bt_list_Cars.Click += new System.EventHandler(this.bt_list_Cars_Click);
            // 
            // lb_cars
            // 
            this.lb_cars.FormattingEnabled = true;
            this.lb_cars.ItemHeight = 20;
            this.lb_cars.Location = new System.Drawing.Point(324, 6);
            this.lb_cars.Name = "lb_cars";
            this.lb_cars.Size = new System.Drawing.Size(460, 364);
            this.lb_cars.TabIndex = 2;
            // 
            // tab_borrowed
            // 
            this.tab_borrowed.Controls.Add(this.bt_listBorrowed);
            this.tab_borrowed.Controls.Add(this.lb_borrowed);
            this.tab_borrowed.Location = new System.Drawing.Point(4, 29);
            this.tab_borrowed.Name = "tab_borrowed";
            this.tab_borrowed.Size = new System.Drawing.Size(792, 417);
            this.tab_borrowed.TabIndex = 2;
            this.tab_borrowed.Text = "Borrowed";
            this.tab_borrowed.UseVisualStyleBackColor = true;
            // 
            // bt_listBorrowed
            // 
            this.bt_listBorrowed.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_listBorrowed.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_listBorrowed.Location = new System.Drawing.Point(674, 385);
            this.bt_listBorrowed.Name = "bt_listBorrowed";
            this.bt_listBorrowed.Size = new System.Drawing.Size(100, 29);
            this.bt_listBorrowed.TabIndex = 5;
            this.bt_listBorrowed.Text = "Refresh";
            this.bt_listBorrowed.UseVisualStyleBackColor = false;
            this.bt_listBorrowed.Click += new System.EventHandler(this.bt_listBorrowed_Click);
            // 
            // lb_borrowed
            // 
            this.lb_borrowed.FormattingEnabled = true;
            this.lb_borrowed.ItemHeight = 20;
            this.lb_borrowed.Location = new System.Drawing.Point(314, 15);
            this.lb_borrowed.Name = "lb_borrowed";
            this.lb_borrowed.Size = new System.Drawing.Size(460, 364);
            this.lb_borrowed.TabIndex = 4;
            // 
            // tab_userpanel
            // 
            this.tab_userpanel.Controls.Add(this.pictureBox1);
            this.tab_userpanel.Controls.Add(this.bt_userpanel_idontneedthat);
            this.tab_userpanel.Controls.Add(this.bt_logout);
            this.tab_userpanel.Controls.Add(this.label_tartozas);
            this.tab_userpanel.Controls.Add(this.label7);
            this.tab_userpanel.Controls.Add(this.label_yourUsername);
            this.tab_userpanel.Controls.Add(this.label5);
            this.tab_userpanel.Controls.Add(this.label4);
            this.tab_userpanel.Controls.Add(this.lb_usercars);
            this.tab_userpanel.Controls.Add(this.label3);
            this.tab_userpanel.Location = new System.Drawing.Point(4, 29);
            this.tab_userpanel.Name = "tab_userpanel";
            this.tab_userpanel.Size = new System.Drawing.Size(792, 417);
            this.tab_userpanel.TabIndex = 3;
            this.tab_userpanel.Text = "User panel";
            this.tab_userpanel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "The car\'s you borrowed:";
            // 
            // lb_usercars
            // 
            this.lb_usercars.FormattingEnabled = true;
            this.lb_usercars.ItemHeight = 20;
            this.lb_usercars.Location = new System.Drawing.Point(18, 43);
            this.lb_usercars.Name = "lb_usercars";
            this.lb_usercars.Size = new System.Drawing.Size(352, 164);
            this.lb_usercars.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Your details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            // 
            // label_yourUsername
            // 
            this.label_yourUsername.AutoSize = true;
            this.label_yourUsername.Location = new System.Drawing.Point(114, 292);
            this.label_yourUsername.Name = "label_yourUsername";
            this.label_yourUsername.Size = new System.Drawing.Size(173, 20);
            this.label_yourUsername.TabIndex = 4;
            this.label_yourUsername.Text = "label_yourUsername";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "You have to pay:";
            // 
            // label_tartozas
            // 
            this.label_tartozas.AutoSize = true;
            this.label_tartozas.Location = new System.Drawing.Point(162, 320);
            this.label_tartozas.Name = "label_tartozas";
            this.label_tartozas.Size = new System.Drawing.Size(123, 20);
            this.label_tartozas.TabIndex = 6;
            this.label_tartozas.Text = "label_tartozas";
            // 
            // bt_cars_delete
            // 
            this.bt_cars_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_cars_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_cars_delete.Location = new System.Drawing.Point(617, 380);
            this.bt_cars_delete.Name = "bt_cars_delete";
            this.bt_cars_delete.Size = new System.Drawing.Size(75, 29);
            this.bt_cars_delete.TabIndex = 3;
            this.bt_cars_delete.Text = "Delete";
            this.bt_cars_delete.UseVisualStyleBackColor = false;
            this.bt_cars_delete.Click += new System.EventHandler(this.bt_cars_delete_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_logout.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_logout.Location = new System.Drawing.Point(637, 369);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(138, 40);
            this.bt_logout.TabIndex = 7;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_cars_borrow
            // 
            this.bt_cars_borrow.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_cars_borrow.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_cars_borrow.Location = new System.Drawing.Point(536, 380);
            this.bt_cars_borrow.Name = "bt_cars_borrow";
            this.bt_cars_borrow.Size = new System.Drawing.Size(75, 29);
            this.bt_cars_borrow.TabIndex = 22;
            this.bt_cars_borrow.Text = "Borrow";
            this.bt_cars_borrow.UseVisualStyleBackColor = false;
            this.bt_cars_borrow.Click += new System.EventHandler(this.bt_cars_borrow_Click);
            // 
            // bt_userpanel_idontneedthat
            // 
            this.bt_userpanel_idontneedthat.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_userpanel_idontneedthat.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_userpanel_idontneedthat.Location = new System.Drawing.Point(37, 213);
            this.bt_userpanel_idontneedthat.Name = "bt_userpanel_idontneedthat";
            this.bt_userpanel_idontneedthat.Size = new System.Drawing.Size(189, 43);
            this.bt_userpanel_idontneedthat.TabIndex = 8;
            this.bt_userpanel_idontneedthat.Text = "I don\'t need that";
            this.bt_userpanel_idontneedthat.UseVisualStyleBackColor = false;
            this.bt_userpanel_idontneedthat.Click += new System.EventHandler(this.bt_userpanel_idontneedthat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 211);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 276);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_users.ResumeLayout(false);
            this.tab_cars.ResumeLayout(false);
            this.tab_cars.PerformLayout();
            this.tab_borrowed.ResumeLayout(false);
            this.tab_userpanel.ResumeLayout(false);
            this.tab_userpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_users;
        private System.Windows.Forms.Button bt_List;
        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.TabPage tab_cars;
        private System.Windows.Forms.TabPage tab_borrowed;
        private System.Windows.Forms.Button bt_list_Cars;
        private System.Windows.Forms.ListBox lb_cars;
        private System.Windows.Forms.Button bt_listBorrowed;
        private System.Windows.Forms.ListBox lb_borrowed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cars_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cars_platenumber;
        private System.Windows.Forms.TextBox tb_cars_type;
        private System.Windows.Forms.Button bt_cars_modify;
        private System.Windows.Forms.Button bt_cars_Add;
        private System.Windows.Forms.TabPage tab_userpanel;
        private System.Windows.Forms.Label label_tartozas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_yourUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_usercars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cars_delete;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_cars_borrow;
        private System.Windows.Forms.Button bt_userpanel_idontneedthat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

