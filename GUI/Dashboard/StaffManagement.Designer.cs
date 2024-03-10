namespace GUI.Dashboard
{
    partial class StaffManagement
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
            this.Table_Staff = new System.Windows.Forms.DataGridView();
            this.Panel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Country = new System.Windows.Forms.Label();
            this.Lbl_City = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Salary = new CustomControls.RJControls.RoundTextBox();
            this.ComboBox_Gender = new GUI.CustomUIComponent.CustomCombobox();
            this.Txt_Country = new CustomControls.RJControls.RoundTextBox();
            this.Txt_City = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Address = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Phone = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Email = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Name = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Position = new CustomControls.RJControls.RoundTextBox();
            this.Txt_ID = new CustomControls.RJControls.RoundTextBox();
            this.Btn_Reload = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Search = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Add = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Edit = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Delete = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Confirm = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Cancel = new GUI.CustomUIComponent.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Staff)).BeginInit();
            this.Panel_Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Table_Staff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 641);
            this.panel1.TabIndex = 0;
            // 
            // Table_Staff
            // 
            this.Table_Staff.BackgroundColor = System.Drawing.Color.White;
            this.Table_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Staff.Location = new System.Drawing.Point(0, 0);
            this.Table_Staff.Name = "Table_Staff";
            this.Table_Staff.RowHeadersWidth = 51;
            this.Table_Staff.RowTemplate.Height = 24;
            this.Table_Staff.Size = new System.Drawing.Size(1489, 641);
            this.Table_Staff.TabIndex = 0;
            this.Table_Staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Staff_CellClick);
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
            this.Panel_Menu.Location = new System.Drawing.Point(1489, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(180, 741);
            this.Panel_Menu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Txt_Salary);
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
            this.panel2.Controls.Add(this.Txt_Position);
            this.panel2.Controls.Add(this.Txt_ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1489, 100);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(872, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Gender";
            // 
            // Lbl_Country
            // 
            this.Lbl_Country.AutoSize = true;
            this.Lbl_Country.Location = new System.Drawing.Point(1201, 71);
            this.Lbl_Country.Name = "Lbl_Country";
            this.Lbl_Country.Size = new System.Drawing.Size(52, 16);
            this.Lbl_Country.TabIndex = 36;
            this.Lbl_Country.Text = "Country";
            // 
            // Lbl_City
            // 
            this.Lbl_City.AutoSize = true;
            this.Lbl_City.Location = new System.Drawing.Point(1224, 21);
            this.Lbl_City.Name = "Lbl_City";
            this.Lbl_City.Size = new System.Drawing.Size(29, 16);
            this.Lbl_City.TabIndex = 35;
            this.Lbl_City.Text = "City";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(533, 68);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.Lbl_Address.TabIndex = 32;
            this.Lbl_Address.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // Txt_Salary
            // 
            this.Txt_Salary.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Salary.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Salary.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Salary.BorderRadius = 0;
            this.Txt_Salary.BorderSize = 2;
            this.Txt_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Salary.ForeColor = System.Drawing.Color.White;
            this.Txt_Salary.Location = new System.Drawing.Point(925, 55);
            this.Txt_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Salary.Multiline = false;
            this.Txt_Salary.Name = "Txt_Salary";
            this.Txt_Salary.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Salary.PasswordChar = false;
            this.Txt_Salary.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Salary.PlaceholderText = "";
            this.Txt_Salary.ReadOnly = false;
            this.Txt_Salary.Size = new System.Drawing.Size(250, 35);
            this.Txt_Salary.TabIndex = 39;
            this.Txt_Salary.Texts = "";
            this.Txt_Salary.UnderlinedStyle = false;
            this.Txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Salary_KeyPress);
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
            this.ComboBox_Gender.Location = new System.Drawing.Point(70, 57);
            this.ComboBox_Gender.MinimumSize = new System.Drawing.Size(10, 30);
            this.ComboBox_Gender.Name = "ComboBox_Gender";
            this.ComboBox_Gender.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBox_Gender.Size = new System.Drawing.Size(119, 36);
            this.ComboBox_Gender.TabIndex = 38;
            this.ComboBox_Gender.Texts = "";
            this.ComboBox_Gender.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_Gender_OnSelectedIndexChanged);
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
            this.Txt_Country.Location = new System.Drawing.Point(1260, 55);
            this.Txt_Country.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Country.Multiline = false;
            this.Txt_Country.Name = "Txt_Country";
            this.Txt_Country.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Country.PasswordChar = false;
            this.Txt_Country.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Country.PlaceholderText = "";
            this.Txt_Country.ReadOnly = false;
            this.Txt_Country.Size = new System.Drawing.Size(195, 35);
            this.Txt_Country.TabIndex = 34;
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
            this.Txt_City.Location = new System.Drawing.Point(1260, 10);
            this.Txt_City.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_City.Multiline = false;
            this.Txt_City.Name = "Txt_City";
            this.Txt_City.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_City.PasswordChar = false;
            this.Txt_City.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_City.PlaceholderText = "";
            this.Txt_City.ReadOnly = false;
            this.Txt_City.Size = new System.Drawing.Size(195, 35);
            this.Txt_City.TabIndex = 33;
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
            this.Txt_Address.Location = new System.Drawing.Point(598, 55);
            this.Txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Address.Multiline = false;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Address.PasswordChar = false;
            this.Txt_Address.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Address.PlaceholderText = "";
            this.Txt_Address.ReadOnly = false;
            this.Txt_Address.Size = new System.Drawing.Size(250, 35);
            this.Txt_Address.TabIndex = 31;
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
            this.Txt_Phone.Location = new System.Drawing.Point(598, 10);
            this.Txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Phone.Multiline = false;
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Phone.PasswordChar = false;
            this.Txt_Phone.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Phone.PlaceholderText = "";
            this.Txt_Phone.ReadOnly = false;
            this.Txt_Phone.Size = new System.Drawing.Size(250, 35);
            this.Txt_Phone.TabIndex = 29;
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
            this.Txt_Email.Location = new System.Drawing.Point(261, 55);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email.Multiline = false;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Email.PasswordChar = false;
            this.Txt_Email.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Email.PlaceholderText = "";
            this.Txt_Email.ReadOnly = false;
            this.Txt_Email.Size = new System.Drawing.Size(250, 35);
            this.Txt_Email.TabIndex = 27;
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
            this.Txt_Name.Location = new System.Drawing.Point(261, 10);
            this.Txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Name.Multiline = false;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Name.PasswordChar = false;
            this.Txt_Name.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Name.PlaceholderText = "";
            this.Txt_Name.ReadOnly = false;
            this.Txt_Name.Size = new System.Drawing.Size(250, 35);
            this.Txt_Name.TabIndex = 25;
            this.Txt_Name.Texts = "";
            this.Txt_Name.UnderlinedStyle = false;
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Name_KeyPress);
            // 
            // Txt_Position
            // 
            this.Txt_Position.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Position.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Position.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Position.BorderRadius = 0;
            this.Txt_Position.BorderSize = 2;
            this.Txt_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Position.ForeColor = System.Drawing.Color.White;
            this.Txt_Position.Location = new System.Drawing.Point(925, 8);
            this.Txt_Position.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Position.Multiline = false;
            this.Txt_Position.Name = "Txt_Position";
            this.Txt_Position.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Position.PasswordChar = false;
            this.Txt_Position.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Position.PlaceholderText = "";
            this.Txt_Position.ReadOnly = false;
            this.Txt_Position.Size = new System.Drawing.Size(250, 35);
            this.Txt_Position.TabIndex = 23;
            this.Txt_Position.Texts = "";
            this.Txt_Position.UnderlinedStyle = false;
            this.Txt_Position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Position_KeyPress);
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
            this.Txt_ID.Location = new System.Drawing.Point(70, 13);
            this.Txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ID.Multiline = false;
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_ID.PasswordChar = false;
            this.Txt_ID.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_ID.PlaceholderText = "";
            this.Txt_ID.ReadOnly = false;
            this.Txt_ID.Size = new System.Drawing.Size(119, 35);
            this.Txt_ID.TabIndex = 21;
            this.Txt_ID.Texts = "";
            this.Txt_ID.UnderlinedStyle = false;
            this.Txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ID_KeyPress);
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
            this.Btn_Reload.TabIndex = 8;
            this.Btn_Reload.Text = "RELOAD";
            this.Btn_Reload.TextColor = System.Drawing.Color.Black;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.StaffManagement_Load);
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
            this.Btn_Search.TabIndex = 7;
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
            this.Btn_Add.TabIndex = 9;
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
            this.Btn_Edit.TabIndex = 12;
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
            this.Btn_Delete.TabIndex = 10;
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
            this.Btn_Confirm.TabIndex = 11;
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
            this.Btn_Cancel.TabIndex = 13;
            this.Btn_Cancel.Text = "CANCEL";
            this.Btn_Cancel.TextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1669, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "StaffManagement";
            this.Text = "ContentForm3";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Staff)).EndInit();
            this.Panel_Menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Panel_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Table_Staff;
        private CustomUIComponent.RoundButton Btn_Reload;
        private CustomUIComponent.RoundButton Btn_Search;
        private CustomUIComponent.RoundButton Btn_Add;
        private CustomUIComponent.RoundButton Btn_Edit;
        private CustomUIComponent.RoundButton Btn_Delete;
        private CustomUIComponent.RoundButton Btn_Confirm;
        private CustomUIComponent.RoundButton Btn_Cancel;
        private CustomUIComponent.CustomCombobox ComboBox_Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Country;
        private System.Windows.Forms.Label Lbl_City;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RoundTextBox Txt_Country;
        private CustomControls.RJControls.RoundTextBox Txt_City;
        private CustomControls.RJControls.RoundTextBox Txt_Address;
        private CustomControls.RJControls.RoundTextBox Txt_Phone;
        private CustomControls.RJControls.RoundTextBox Txt_Email;
        private CustomControls.RJControls.RoundTextBox Txt_Name;
        private CustomControls.RJControls.RoundTextBox Txt_Position;
        private CustomControls.RJControls.RoundTextBox Txt_ID;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RoundTextBox Txt_Salary;
    }
}