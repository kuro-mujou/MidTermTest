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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Table_Room = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboBox_RoomStatus = new GUI.CustomUIComponent.CustomCombobox();
            this.Txt_SearchBox = new CustomControls.RJControls.RoundTextBox();
            this.Txt_RoomNumber = new CustomControls.RJControls.RoundTextBox();
            this.Txt_RoomType = new CustomControls.RJControls.RoundTextBox();
            this.Btn_Search = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Reload = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Add = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Delete = new GUI.CustomUIComponent.RoundButton();
            this.Confirm = new GUI.CustomUIComponent.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Room)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Room
            // 
            this.Table_Room.BackgroundColor = System.Drawing.Color.White;
            this.Table_Room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Table_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_Room.DefaultCellStyle = dataGridViewCellStyle4;
            this.Table_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Room.Location = new System.Drawing.Point(0, 0);
            this.Table_Room.Margin = new System.Windows.Forms.Padding(0);
            this.Table_Room.Name = "Table_Room";
            this.Table_Room.RowHeadersWidth = 51;
            this.Table_Room.RowTemplate.Height = 24;
            this.Table_Room.Size = new System.Drawing.Size(1311, 513);
            this.Table_Room.TabIndex = 0;
            this.Table_Room.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Search);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Reload);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.Confirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1311, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 610);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(407, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Status";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBox_RoomStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_SearchBox);
            this.panel1.Controls.Add(this.Txt_RoomNumber);
            this.panel1.Controls.Add(this.Txt_RoomType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 97);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Table_Room);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 513);
            this.panel2.TabIndex = 12;
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
            this.ComboBox_RoomStatus.Location = new System.Drawing.Point(506, 7);
            this.ComboBox_RoomStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboBox_RoomStatus.Name = "ComboBox_RoomStatus";
            this.ComboBox_RoomStatus.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBox_RoomStatus.Size = new System.Drawing.Size(222, 36);
            this.ComboBox_RoomStatus.TabIndex = 10;
            this.ComboBox_RoomStatus.Texts = "";
            // 
            // Txt_SearchBox
            // 
            this.Txt_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_SearchBox.BackColor = System.Drawing.Color.DimGray;
            this.Txt_SearchBox.BorderColor = System.Drawing.Color.Gray;
            this.Txt_SearchBox.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_SearchBox.BorderRadius = 0;
            this.Txt_SearchBox.BorderSize = 2;
            this.Txt_SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SearchBox.ForeColor = System.Drawing.Color.White;
            this.Txt_SearchBox.Location = new System.Drawing.Point(948, 7);
            this.Txt_SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_SearchBox.Multiline = false;
            this.Txt_SearchBox.Name = "Txt_SearchBox";
            this.Txt_SearchBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_SearchBox.PasswordChar = false;
            this.Txt_SearchBox.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_SearchBox.PlaceholderText = "Search here";
            this.Txt_SearchBox.Size = new System.Drawing.Size(351, 35);
            this.Txt_SearchBox.TabIndex = 8;
            this.Txt_SearchBox.Texts = "";
            this.Txt_SearchBox.UnderlinedStyle = false;
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
            this.Txt_RoomNumber.Location = new System.Drawing.Point(121, 7);
            this.Txt_RoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_RoomNumber.Multiline = false;
            this.Txt_RoomNumber.Name = "Txt_RoomNumber";
            this.Txt_RoomNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_RoomNumber.PasswordChar = false;
            this.Txt_RoomNumber.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_RoomNumber.PlaceholderText = "";
            this.Txt_RoomNumber.Size = new System.Drawing.Size(250, 35);
            this.Txt_RoomNumber.TabIndex = 5;
            this.Txt_RoomNumber.Texts = "";
            this.Txt_RoomNumber.UnderlinedStyle = false;
            // 
            // Txt_RoomType
            // 
            this.Txt_RoomType.BackColor = System.Drawing.Color.DimGray;
            this.Txt_RoomType.BorderColor = System.Drawing.Color.Gray;
            this.Txt_RoomType.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_RoomType.BorderRadius = 0;
            this.Txt_RoomType.BorderSize = 2;
            this.Txt_RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RoomType.ForeColor = System.Drawing.Color.White;
            this.Txt_RoomType.Location = new System.Drawing.Point(121, 50);
            this.Txt_RoomType.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_RoomType.Multiline = false;
            this.Txt_RoomType.Name = "Txt_RoomType";
            this.Txt_RoomType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_RoomType.PasswordChar = false;
            this.Txt_RoomType.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_RoomType.PlaceholderText = "";
            this.Txt_RoomType.Size = new System.Drawing.Size(250, 35);
            this.Txt_RoomType.TabIndex = 6;
            this.Txt_RoomType.Texts = "";
            this.Txt_RoomType.UnderlinedStyle = false;
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
            this.Btn_Search.Location = new System.Drawing.Point(5, 5);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(170, 40);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.Text = "SEARCH";
            this.Btn_Search.TextColor = System.Drawing.Color.Black;
            this.Btn_Search.UseVisualStyleBackColor = false;
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
            this.Btn_Reload.Location = new System.Drawing.Point(5, 55);
            this.Btn_Reload.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(170, 40);
            this.Btn_Reload.TabIndex = 1;
            this.Btn_Reload.Text = "RELOAD";
            this.Btn_Reload.TextColor = System.Drawing.Color.Black;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.HotelRoomManagement_Load);
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
            this.Btn_Delete.Location = new System.Drawing.Point(5, 155);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(170, 40);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "DELETE";
            this.Btn_Delete.TextColor = System.Drawing.Color.Black;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.White;
            this.Confirm.BackgroundColor = System.Drawing.Color.White;
            this.Confirm.BorderColor = System.Drawing.Color.Black;
            this.Confirm.BorderRadius = 20;
            this.Confirm.BorderSize = 2;
            this.Confirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.Color.Black;
            this.Confirm.Location = new System.Drawing.Point(5, 205);
            this.Confirm.Margin = new System.Windows.Forms.Padding(5);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(170, 40);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "CONFIRM";
            this.Confirm.TextColor = System.Drawing.Color.Black;
            this.Confirm.UseVisualStyleBackColor = false;
            // 
            // HotelRoomManagement
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1491, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HotelRoomManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HotelRoomManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Room)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Room;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomUIComponent.RoundButton Btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RoundTextBox Txt_RoomNumber;
        private CustomControls.RJControls.RoundTextBox Txt_RoomType;
        private CustomControls.RJControls.RoundTextBox Txt_SearchBox;
        private System.Windows.Forms.Label label4;
        private CustomUIComponent.CustomCombobox ComboBox_RoomStatus;
        private System.Windows.Forms.Panel panel1;
        private CustomUIComponent.RoundButton Btn_Reload;
        private CustomUIComponent.RoundButton Btn_Add;
        private CustomUIComponent.RoundButton Btn_Delete;
        private CustomUIComponent.RoundButton Confirm;
        private System.Windows.Forms.Panel panel2;
    }
}