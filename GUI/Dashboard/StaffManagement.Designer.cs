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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Reload = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Search = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Add = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Edit = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Delete = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Confirm = new GUI.CustomUIComponent.RoundButton();
            this.Btn_Cancel = new GUI.CustomUIComponent.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 641);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Reload);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Search);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Confirm);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1271, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 741);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 100);
            this.panel2.TabIndex = 2;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 641);
            this.dataGridView1.TabIndex = 0;
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StaffManagement";
            this.Text = "ContentForm3";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomUIComponent.RoundButton Btn_Reload;
        private CustomUIComponent.RoundButton Btn_Search;
        private CustomUIComponent.RoundButton Btn_Add;
        private CustomUIComponent.RoundButton Btn_Edit;
        private CustomUIComponent.RoundButton Btn_Delete;
        private CustomUIComponent.RoundButton Btn_Confirm;
        private CustomUIComponent.RoundButton Btn_Cancel;
    }
}