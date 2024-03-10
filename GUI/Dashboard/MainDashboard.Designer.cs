namespace GUI.Dashboard
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.roundButton1 = new GUI.CustomUIComponent.RoundButton();
            this.roundButton2 = new GUI.CustomUIComponent.RoundButton();
            this.roundButton3 = new GUI.CustomUIComponent.RoundButton();
            this.roundButton4 = new GUI.CustomUIComponent.RoundButton();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.White;
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Controls.Add(this.pictureBox1);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1493, 70);
            this.Panel_Header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "AZURE HAVEN HOTEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Hotel_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(772, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Content
            // 
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.Location = new System.Drawing.Point(250, 70);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(1243, 633);
            this.Panel_Content.TabIndex = 2;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.White;
            this.Panel_Menu.Controls.Add(this.roundButton1);
            this.Panel_Menu.Controls.Add(this.roundButton2);
            this.Panel_Menu.Controls.Add(this.roundButton3);
            this.Panel_Menu.Controls.Add(this.roundButton4);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 70);
            this.Panel_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(250, 633);
            this.Panel_Menu.TabIndex = 0;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(5, 5);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(5);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(240, 50);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Room Management";
            this.roundButton1.TextColor = System.Drawing.Color.Black;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundButton2.BorderColor = System.Drawing.Color.Black;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 2;
            this.roundButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.roundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(5, 65);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(5);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(240, 50);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "Customer Management";
            this.roundButton2.TextColor = System.Drawing.Color.Black;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.RoundButton2_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.White;
            this.roundButton3.BackgroundColor = System.Drawing.Color.White;
            this.roundButton3.BorderColor = System.Drawing.Color.Black;
            this.roundButton3.BorderRadius = 20;
            this.roundButton3.BorderSize = 2;
            this.roundButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.roundButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(5, 125);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(5);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(240, 50);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "Staff Management";
            this.roundButton3.TextColor = System.Drawing.Color.Black;
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.RoundButton3_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.White;
            this.roundButton4.BackgroundColor = System.Drawing.Color.White;
            this.roundButton4.BorderColor = System.Drawing.Color.Black;
            this.roundButton4.BorderRadius = 20;
            this.roundButton4.BorderSize = 2;
            this.roundButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.roundButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.Black;
            this.roundButton4.Location = new System.Drawing.Point(5, 185);
            this.roundButton4.Margin = new System.Windows.Forms.Padding(5);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(240, 50);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.Text = "Room Rental";
            this.roundButton4.TextColor = System.Drawing.Color.Black;
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.RoundButton4_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1493, 703);
            this.Controls.Add(this.Panel_Content);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.Panel_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.FlowLayoutPanel Panel_Menu;
        private CustomUIComponent.RoundButton roundButton1;
        private CustomUIComponent.RoundButton roundButton2;
        private CustomUIComponent.RoundButton roundButton3;
        private CustomUIComponent.RoundButton roundButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}