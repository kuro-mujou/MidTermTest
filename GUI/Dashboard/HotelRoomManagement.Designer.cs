namespace GUI.Dashboard
{
    partial class HotelRoomManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Table_Room = new System.Windows.Forms.DataGridView();
            this.Panel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Reload = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Search = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Add = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Edit = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Delete = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Confirm = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Cancel = new GUI.CustomUIComponent.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboRox_RoomType = new GUI.CustomUIComponent.CustomCombobox();
            this.ComboBox_RoomStatus = new GUI.CustomUIComponent.CustomCombobox();
            this.Txt_RoomNumber = new CustomControls.RJControls.RoundTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Room)).BeginInit();
            this.Panel_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Room
            // 
            this.Table_Room.BackgroundColor = System.Drawing.Color.White;
            this.Table_Room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_Room.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Room.Location = new System.Drawing.Point(0, 0);
            this.Table_Room.Margin = new System.Windows.Forms.Padding(0);
            this.Table_Room.Name = "Table_Room";
            this.Table_Room.RowHeadersWidth = 51;
            this.Table_Room.RowTemplate.Height = 24;
            this.Table_Room.Size = new System.Drawing.Size(1311, 510);
            this.Table_Room.TabIndex = 0;
            this.Table_Room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Room_CellClick);
            this.Table_Room.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Table_Room_CellFormatting);
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
            this.Panel_Menu.Location = new System.Drawing.Point(1311, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(180, 610);
            this.Panel_Menu.TabIndex = 1;
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
            this.Btn_Reload.TabIndex = 1;
            this.Btn_Reload.Text = "RELOAD";
            this.Btn_Reload.TextColor = System.Drawing.Color.Black;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.HotelRoomManagement_Load);
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
            this.Btn_Search.TabIndex = 0;
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
            this.Btn_Add.TabIndex = 2;
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
            this.Btn_Delete.TabIndex = 3;
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
            this.Btn_Confirm.TabIndex = 4;
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
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "CANCEL";
            this.Btn_Cancel.TextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(416, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboRox_RoomType);
            this.panel1.Controls.Add(this.ComboBox_RoomStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_RoomNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 100);
            this.panel1.TabIndex = 11;
            // 
            // ComboRox_RoomType
            // 
            this.ComboRox_RoomType.BackColor = System.Drawing.Color.DimGray;
            this.ComboRox_RoomType.BorderColor = System.Drawing.Color.Gray;
            this.ComboRox_RoomType.BorderSize = 2;
            this.ComboRox_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboRox_RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboRox_RoomType.ForeColor = System.Drawing.Color.White;
            this.ComboRox_RoomType.IconColor = System.Drawing.Color.White;
            this.ComboRox_RoomType.Items.AddRange(new object[] {
            "Standard_Room1",
            "Standard_Room2",
            "Deluxe_Room",
            "Executive_Room"});
            this.ComboRox_RoomType.ListBackColor = System.Drawing.Color.LightGray;
            this.ComboRox_RoomType.ListTextColor = System.Drawing.Color.Black;
            this.ComboRox_RoomType.Location = new System.Drawing.Point(121, 55);
            this.ComboRox_RoomType.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboRox_RoomType.Name = "ComboRox_RoomType";
            this.ComboRox_RoomType.Padding = new System.Windows.Forms.Padding(2);
            this.ComboRox_RoomType.Size = new System.Drawing.Size(250, 36);
            this.ComboRox_RoomType.TabIndex = 11;
            this.ComboRox_RoomType.Texts = "";
            this.ComboRox_RoomType.OnSelectedIndexChanged += new System.EventHandler(this.ComboRox_RoomType_OnSelectedIndexChanged);
            // 
            // ComboBox_RoomStatus
            // 
            this.ComboBox_RoomStatus.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_RoomStatus.BorderColor = System.Drawing.Color.Gray;
            this.ComboBox_RoomStatus.BorderSize = 2;
            this.ComboBox_RoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboBox_RoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBox_RoomStatus.ForeColor = System.Drawing.Color.White;
            this.ComboBox_RoomStatus.IconColor = System.Drawing.Color.White;
            this.ComboBox_RoomStatus.Items.AddRange(new object[] {
            "EMPTY",
            "OCCUPIED",
            "CLEANING"});
            this.ComboBox_RoomStatus.ListBackColor = System.Drawing.Color.LightGray;
            this.ComboBox_RoomStatus.ListTextColor = System.Drawing.Color.Black;
            this.ComboBox_RoomStatus.Location = new System.Drawing.Point(506, 13);
            this.ComboBox_RoomStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBox_RoomStatus.Name = "ComboBox_RoomStatus";
            this.ComboBox_RoomStatus.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBox_RoomStatus.Size = new System.Drawing.Size(222, 36);
            this.ComboBox_RoomStatus.TabIndex = 10;
            this.ComboBox_RoomStatus.Texts = "";
            this.ComboBox_RoomStatus.OnSelectedIndexChanged += new System.EventHandler(this.ComboBox_RoomStatus_OnSelectedIndexChanged);
            // 
            // Txt_RoomNumber
            // 
            this.Txt_RoomNumber.BackColor = System.Drawing.Color.DimGray;
            this.Txt_RoomNumber.BorderColor = System.Drawing.Color.Gray;
            this.Txt_RoomNumber.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_RoomNumber.BorderRadius = 0;
            this.Txt_RoomNumber.BorderSize = 2;
            this.Txt_RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RoomNumber.ForeColor = System.Drawing.Color.White;
            this.Txt_RoomNumber.Location = new System.Drawing.Point(121, 13);
            this.Txt_RoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_RoomNumber.Multiline = false;
            this.Txt_RoomNumber.Name = "Txt_RoomNumber";
            this.Txt_RoomNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_RoomNumber.PasswordChar = false;
            this.Txt_RoomNumber.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_RoomNumber.PlaceholderText = "";
            this.Txt_RoomNumber.ReadOnly = false;
            this.Txt_RoomNumber.Size = new System.Drawing.Size(250, 35);
            this.Txt_RoomNumber.TabIndex = 5;
            this.Txt_RoomNumber.Texts = "";
            this.Txt_RoomNumber.UnderlinedStyle = false;
            this.Txt_RoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_RoomNumber_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Table_Room);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 510);
            this.panel2.TabIndex = 12;
            // 
            // HotelRoomManagement
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1491, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "HotelRoomManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HotelRoomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Room)).EndInit();
            this.Panel_Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Room;
        private System.Windows.Forms.FlowLayoutPanel Panel_Menu;
        private CustomUIComponent.RoundButton Btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RoundTextBox Txt_RoomNumber;
        private CustomUIComponent.CustomCombobox ComboBox_RoomStatus;
        private System.Windows.Forms.Panel panel1;
        private CustomUIComponent.RoundButton Btn_Reload;
        private CustomUIComponent.RoundButton Btn_Add;
        private CustomUIComponent.RoundButton Btn_Delete;
        private CustomUIComponent.RoundButton Btn_Confirm;
        private System.Windows.Forms.Panel panel2;
        private CustomUIComponent.RoundButton Btn_Edit;
        private CustomUIComponent.CustomCombobox ComboRox_RoomType;
        private CustomUIComponent.RoundButton Btn_Cancel;
    }
}