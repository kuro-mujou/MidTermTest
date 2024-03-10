﻿namespace GUI.Dashboard
{
    partial class CustomerManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Table_Customer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboBox_Gender = new GUI.CustomUIComponent.CustomCombobox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Country = new System.Windows.Forms.Label();
            this.Lbl_City = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Country = new CustomControls.RJControls.RoundTextBox();
            this.Txt_City = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Address = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Phone = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Email = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Name = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Identity = new CustomControls.RJControls.RoundTextBox();
            this.Txt_ID = new CustomControls.RJControls.RoundTextBox();
            this.Panel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Reload = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Search = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Add = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Edit = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Delete = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Confirm = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Cancel = new GUI.CustomUIComponent.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Customer)).BeginInit();
            this.panel2.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Table_Customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 583);
            this.panel1.TabIndex = 0;
            // 
            // Table_Customer
            // 
            this.Table_Customer.BackgroundColor = System.Drawing.Color.White;
            this.Table_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Customer.Location = new System.Drawing.Point(0, 0);
            this.Table_Customer.Name = "Table_Customer";
            this.Table_Customer.RowHeadersWidth = 51;
            this.Table_Customer.RowTemplate.Height = 24;
            this.Table_Customer.Size = new System.Drawing.Size(1509, 583);
            this.Table_Customer.TabIndex = 0;
            this.Table_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Customer_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ComboBox_Gender);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Lbl_Country);
            this.panel2.Controls.Add(this.Lbl_City);
            this.panel2.Controls.Add(this.Lbl_Address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Txt_Country);
            this.panel2.Controls.Add(this.Txt_City);
            this.panel2.Controls.Add(this.Txt_Address);
            this.panel2.Controls.Add(this.Txt_Phone);
            this.panel2.Controls.Add(this.Txt_Email);
            this.panel2.Controls.Add(this.Txt_Name);
            this.panel2.Controls.Add(this.Txt_Identity);
            this.panel2.Controls.Add(this.Txt_ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1509, 100);
            this.panel2.TabIndex = 1;
            // 
            // ComboBox_Gender
            // 
            this.ComboBox_Gender.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_Gender.BorderColor = System.Drawing.Color.Gray;
            this.ComboBox_Gender.BorderSize = 2;
            this.ComboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBox_Gender.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Gender.IconColor = System.Drawing.Color.White;
            this.ComboBox_Gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.ComboBox_Gender.ListBackColor = System.Drawing.Color.LightGray;
            this.ComboBox_Gender.ListTextColor = System.Drawing.Color.Black;
            this.ComboBox_Gender.Location = new System.Drawing.Point(1099, 10);
            this.ComboBox_Gender.MinimumSize = new System.Drawing.Size(10, 30);
            this.ComboBox_Gender.Name = "ComboBox_Gender";
            this.ComboBox_Gender.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBox_Gender.Size = new System.Drawing.Size(119, 36);
            this.ComboBox_Gender.TabIndex = 20;
            this.ComboBox_Gender.Texts = "";
            this.ComboBox_Gender.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_Gender_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1041, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Gender";
            // 
            // Lbl_Country
            // 
            this.Lbl_Country.AutoSize = true;
            this.Lbl_Country.Location = new System.Drawing.Point(1210, 71);
            this.Lbl_Country.Name = "Lbl_Country";
            this.Lbl_Country.Size = new System.Drawing.Size(52, 16);
            this.Lbl_Country.TabIndex = 17;
            this.Lbl_Country.Text = "Country";
            // 
            // Lbl_City
            // 
            this.Lbl_City.AutoSize = true;
            this.Lbl_City.Location = new System.Drawing.Point(1233, 21);
            this.Lbl_City.Name = "Lbl_City";
            this.Lbl_City.Size = new System.Drawing.Size(29, 16);
            this.Lbl_City.TabIndex = 16;
            this.Lbl_City.Text = "City";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(715, 68);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.Lbl_Address.TabIndex = 11;
            this.Lbl_Address.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identity Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // Txt_Country
            // 
            this.Txt_Country.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Country.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Country.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Country.BorderRadius = 0;
            this.Txt_Country.BorderSize = 2;
            this.Txt_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Country.ForeColor = System.Drawing.Color.White;
            this.Txt_Country.Location = new System.Drawing.Point(1269, 55);
            this.Txt_Country.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Country.Multiline = false;
            this.Txt_Country.Name = "Txt_Country";
            this.Txt_Country.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Country.PasswordChar = false;
            this.Txt_Country.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Country.PlaceholderText = "";
            this.Txt_Country.ReadOnly = false;
            this.Txt_Country.Size = new System.Drawing.Size(195, 35);
            this.Txt_Country.TabIndex = 14;
            this.Txt_Country.Texts = "";
            this.Txt_Country.UnderlinedStyle = false;
            // 
            // Txt_City
            // 
            this.Txt_City.BackColor = System.Drawing.Color.DimGray;
            this.Txt_City.BorderColor = System.Drawing.Color.Gray;
            this.Txt_City.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_City.BorderRadius = 0;
            this.Txt_City.BorderSize = 2;
            this.Txt_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_City.ForeColor = System.Drawing.Color.White;
            this.Txt_City.Location = new System.Drawing.Point(1269, 10);
            this.Txt_City.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_City.Multiline = false;
            this.Txt_City.Name = "Txt_City";
            this.Txt_City.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_City.PasswordChar = false;
            this.Txt_City.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_City.PlaceholderText = "";
            this.Txt_City.ReadOnly = false;
            this.Txt_City.Size = new System.Drawing.Size(195, 35);
            this.Txt_City.TabIndex = 13;
            this.Txt_City.Texts = "";
            this.Txt_City.UnderlinedStyle = false;
            // 
            // Txt_Address
            // 
            this.Txt_Address.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Address.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Address.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Address.BorderRadius = 0;
            this.Txt_Address.BorderSize = 2;
            this.Txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.ForeColor = System.Drawing.Color.White;
            this.Txt_Address.Location = new System.Drawing.Point(780, 55);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Address.Multiline = false;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Address.PasswordChar = false;
            this.Txt_Address.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Address.PlaceholderText = "";
            this.Txt_Address.ReadOnly = false;
            this.Txt_Address.Size = new System.Drawing.Size(250, 35);
            this.Txt_Address.TabIndex = 10;
            this.Txt_Address.Texts = "";
            this.Txt_Address.UnderlinedStyle = false;
            this.Txt_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Address_KeyPress);
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Phone.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Phone.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Phone.BorderRadius = 0;
            this.Txt_Phone.BorderSize = 2;
            this.Txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Phone.ForeColor = System.Drawing.Color.White;
            this.Txt_Phone.Location = new System.Drawing.Point(780, 10);
            this.Txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Phone.Multiline = false;
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Phone.PasswordChar = false;
            this.Txt_Phone.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Phone.PlaceholderText = "";
            this.Txt_Phone.ReadOnly = false;
            this.Txt_Phone.Size = new System.Drawing.Size(250, 35);
            this.Txt_Phone.TabIndex = 8;
            this.Txt_Phone.Texts = "";
            this.Txt_Phone.UnderlinedStyle = false;
            this.Txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Phone_KeyPress);
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Email.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Email.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Email.BorderRadius = 0;
            this.Txt_Email.BorderSize = 2;
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.ForeColor = System.Drawing.Color.White;
            this.Txt_Email.Location = new System.Drawing.Point(447, 55);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email.Multiline = false;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Email.PasswordChar = false;
            this.Txt_Email.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Email.PlaceholderText = "";
            this.Txt_Email.ReadOnly = false;
            this.Txt_Email.Size = new System.Drawing.Size(250, 35);
            this.Txt_Email.TabIndex = 6;
            this.Txt_Email.Texts = "";
            this.Txt_Email.UnderlinedStyle = false;
            this.Txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Email_KeyPress);
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Name.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Name.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Name.BorderRadius = 0;
            this.Txt_Name.BorderSize = 2;
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.Color.White;
            this.Txt_Name.Location = new System.Drawing.Point(447, 10);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Name.Multiline = false;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Name.PasswordChar = false;
            this.Txt_Name.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Name.PlaceholderText = "";
            this.Txt_Name.ReadOnly = false;
            this.Txt_Name.Size = new System.Drawing.Size(250, 35);
            this.Txt_Name.TabIndex = 4;
            this.Txt_Name.Texts = "";
            this.Txt_Name.UnderlinedStyle = false;
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // Txt_Identity
            // 
            this.Txt_Identity.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Identity.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Identity.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Identity.BorderRadius = 0;
            this.Txt_Identity.BorderSize = 2;
            this.Txt_Identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Identity.ForeColor = System.Drawing.Color.White;
            this.Txt_Identity.Location = new System.Drawing.Point(119, 55);
            this.Txt_Identity.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Identity.Multiline = false;
            this.Txt_Identity.Name = "Txt_Identity";
            this.Txt_Identity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Identity.PasswordChar = false;
            this.Txt_Identity.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Identity.PlaceholderText = "";
            this.Txt_Identity.ReadOnly = false;
            this.Txt_Identity.Size = new System.Drawing.Size(250, 35);
            this.Txt_Identity.TabIndex = 2;
            this.Txt_Identity.Texts = "";
            this.Txt_Identity.UnderlinedStyle = false;
            this.Txt_Identity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Identity_KeyPress);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.Color.DimGray;
            this.Txt_ID.BorderColor = System.Drawing.Color.Gray;
            this.Txt_ID.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_ID.BorderRadius = 0;
            this.Txt_ID.BorderSize = 2;
            this.Txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.ForeColor = System.Drawing.Color.White;
            this.Txt_ID.Location = new System.Drawing.Point(119, 10);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ID.Multiline = false;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_ID.PasswordChar = false;
            this.Txt_ID.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_ID.PlaceholderText = "";
            this.Txt_ID.ReadOnly = false;
            this.Txt_ID.Size = new System.Drawing.Size(250, 35);
            this.Txt_ID.TabIndex = 0;
            this.Txt_ID.Texts = "";
            this.Txt_ID.UnderlinedStyle = false;
            this.Txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ID_KeyPress);
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Controls.Add(this.Btn_Reload);
            this.Panel_Menu.Controls.Add(this.Btn_Search);
            this.Panel_Menu.Controls.Add(this.Btn_Add);
            this.Panel_Menu.Controls.Add(this.Btn_Edit);
            this.Panel_Menu.Controls.Add(this.Btn_Delete);
            this.Panel_Menu.Controls.Add(this.Btn_Confirm);
            this.Panel_Menu.Controls.Add(this.Btn_Cancel);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Menu.Location = new System.Drawing.Point(1509, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(180, 683);
            this.Panel_Menu.TabIndex = 2;
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.BackColor = System.Drawing.Color.White;
            this.Btn_Reload.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Reload.BorderColor = System.Drawing.Color.Black;
            this.Btn_Reload.BorderRadius = 20;
            this.Btn_Reload.BorderSize = 2;
            this.Btn_Reload.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Reload.FlatAppearance.BorderSize = 0;
            this.Btn_Reload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Reload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reload.ForeColor = System.Drawing.Color.Black;
            this.Btn_Reload.Location = new System.Drawing.Point(5, 5);
            this.Btn_Reload.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(170, 40);
            this.Btn_Reload.TabIndex = 2;
            this.Btn_Reload.Text = "RELOAD";
            this.Btn_Reload.TextColor = System.Drawing.Color.Black;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.CustomerManagement_Load);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.White;
            this.Btn_Search.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Search.BorderColor = System.Drawing.Color.Black;
            this.Btn_Search.BorderRadius = 20;
            this.Btn_Search.BorderSize = 2;
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.Black;
            this.Btn_Search.Location = new System.Drawing.Point(5, 55);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(170, 40);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Text = "SEARCH";
            this.Btn_Search.TextColor = System.Drawing.Color.Black;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.White;
            this.Btn_Add.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Add.BorderColor = System.Drawing.Color.Black;
            this.Btn_Add.BorderRadius = 20;
            this.Btn_Add.BorderSize = 2;
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.Black;
            this.Btn_Add.Location = new System.Drawing.Point(5, 105);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(170, 40);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.TextColor = System.Drawing.Color.Black;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.White;
            this.Btn_Edit.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Edit.BorderColor = System.Drawing.Color.Black;
            this.Btn_Edit.BorderRadius = 20;
            this.Btn_Edit.BorderSize = 2;
            this.Btn_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Edit.Location = new System.Drawing.Point(5, 155);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(170, 40);
            this.Btn_Edit.TabIndex = 5;
            this.Btn_Edit.Text = "EDIT";
            this.Btn_Edit.TextColor = System.Drawing.Color.Black;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Delete.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.BorderRadius = 20;
            this.Btn_Delete.BorderSize = 2;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.Btn_Delete.Location = new System.Drawing.Point(5, 205);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(170, 40);
            this.Btn_Delete.TabIndex = 6;
            this.Btn_Delete.Text = "DELETE";
            this.Btn_Delete.TextColor = System.Drawing.Color.Black;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.Color.White;
            this.Btn_Confirm.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Confirm.BorderColor = System.Drawing.Color.Black;
            this.Btn_Confirm.BorderRadius = 20;
            this.Btn_Confirm.BorderSize = 2;
            this.Btn_Confirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Confirm.FlatAppearance.BorderSize = 0;
            this.Btn_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirm.ForeColor = System.Drawing.Color.Black;
            this.Btn_Confirm.Location = new System.Drawing.Point(5, 255);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(170, 40);
            this.Btn_Confirm.TabIndex = 7;
            this.Btn_Confirm.Text = "CONFIRM";
            this.Btn_Confirm.TextColor = System.Drawing.Color.Black;
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.White;
            this.Btn_Cancel.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Cancel.BorderColor = System.Drawing.Color.Black;
            this.Btn_Cancel.BorderRadius = 20;
            this.Btn_Cancel.BorderSize = 2;
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancel.Location = new System.Drawing.Point(5, 305);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(170, 40);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "CANCEL";
            this.Btn_Cancel.TextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1689, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "CustomerManagement";
            this.Text = "ContentForm2";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Customer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel Panel_Menu;
        private CustomUIComponent.RoundButton Btn_Reload;
        private CustomUIComponent.RoundButton Btn_Search;
        private CustomUIComponent.RoundButton Btn_Add;
        private CustomUIComponent.RoundButton Btn_Edit;
        private CustomUIComponent.RoundButton Btn_Delete;
        private CustomUIComponent.RoundButton Btn_Confirm;
        private CustomUIComponent.RoundButton Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RoundTextBox Txt_ID;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RoundTextBox Txt_Phone;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RoundTextBox Txt_Email;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RoundTextBox Txt_Name;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RoundTextBox Txt_Identity;
        private System.Windows.Forms.DataGridView Table_Customer;
        private System.Windows.Forms.Label Lbl_Address;
        private CustomControls.RJControls.RoundTextBox Txt_Address;
        private System.Windows.Forms.Label Lbl_Country;
        private System.Windows.Forms.Label Lbl_City;
        private CustomControls.RJControls.RoundTextBox Txt_Country;
        private CustomControls.RJControls.RoundTextBox Txt_City;
        private System.Windows.Forms.Label label6;
        private CustomUIComponent.CustomCombobox ComboBox_Gender;
    }
}