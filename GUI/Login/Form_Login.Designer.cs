namespace GUI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_WarningUsername = new System.Windows.Forms.Label();
            this.Label_WarningPassword = new System.Windows.Forms.Label();
            this.Label_WarningAccount = new System.Windows.Forms.Label();
            this.Btn_Login = new GUI.CustomUIComponent.RoundButton();
            this.Txt_Password = new CustomControls.RJControls.RoundTextBox();
            this.Txt_Username = new CustomControls.RJControls.RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Hotel_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(355, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(198, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(201, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // Label_WarningUsername
            // 
            this.Label_WarningUsername.AutoSize = true;
            this.Label_WarningUsername.ForeColor = System.Drawing.Color.Red;
            this.Label_WarningUsername.Location = new System.Drawing.Point(532, 199);
            this.Label_WarningUsername.Name = "Label_WarningUsername";
            this.Label_WarningUsername.Size = new System.Drawing.Size(0, 16);
            this.Label_WarningUsername.TabIndex = 4;
            // 
            // Label_WarningPassword
            // 
            this.Label_WarningPassword.AutoSize = true;
            this.Label_WarningPassword.ForeColor = System.Drawing.Color.Red;
            this.Label_WarningPassword.Location = new System.Drawing.Point(532, 242);
            this.Label_WarningPassword.Name = "Label_WarningPassword";
            this.Label_WarningPassword.Size = new System.Drawing.Size(0, 16);
            this.Label_WarningPassword.TabIndex = 5;
            // 
            // Label_WarningAccount
            // 
            this.Label_WarningAccount.AutoSize = true;
            this.Label_WarningAccount.ForeColor = System.Drawing.Color.Red;
            this.Label_WarningAccount.Location = new System.Drawing.Point(304, 317);
            this.Label_WarningAccount.Name = "Label_WarningAccount";
            this.Label_WarningAccount.Size = new System.Drawing.Size(0, 16);
            this.Label_WarningAccount.TabIndex = 6;
            this.Label_WarningAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_WarningAccount.Click += new System.EventHandler(this.TextBoxClick);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.White;
            this.Btn_Login.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Login.BorderColor = System.Drawing.Color.Black;
            this.Btn_Login.BorderRadius = 20;
            this.Btn_Login.BorderSize = 2;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.ForeColor = System.Drawing.Color.Black;
            this.Btn_Login.Location = new System.Drawing.Point(340, 274);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(120, 40);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.TextColor = System.Drawing.Color.Black;
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Password.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Password.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Password.BorderRadius = 15;
            this.Txt_Password.BorderSize = 2;
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.ForeColor = System.Drawing.Color.White;
            this.Txt_Password.Location = new System.Drawing.Point(275, 232);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.Multiline = false;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Password.PasswordChar = true;
            this.Txt_Password.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Password.PlaceholderText = "password";
            this.Txt_Password.Size = new System.Drawing.Size(250, 35);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.Texts = "";
            this.Txt_Password.UnderlinedStyle = false;
            this.Txt_Password.Click += new System.EventHandler(this.TextBoxClick);
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // Txt_Username
            // 
            this.Txt_Username.BackColor = System.Drawing.Color.DimGray;
            this.Txt_Username.BorderColor = System.Drawing.Color.Gray;
            this.Txt_Username.BorderFocusColor = System.Drawing.Color.LightGray;
            this.Txt_Username.BorderRadius = 15;
            this.Txt_Username.BorderSize = 2;
            this.Txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.ForeColor = System.Drawing.Color.White;
            this.Txt_Username.Location = new System.Drawing.Point(275, 189);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Username.Multiline = false;
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txt_Username.PasswordChar = false;
            this.Txt_Username.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txt_Username.PlaceholderText = "username";
            this.Txt_Username.Size = new System.Drawing.Size(250, 35);
            this.Txt_Username.TabIndex = 1;
            this.Txt_Username.Texts = "";
            this.Txt_Username.UnderlinedStyle = false;
            this.Txt_Username.Click += new System.EventHandler(this.TextBoxClick);
            this.Txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_WarningAccount);
            this.Controls.Add(this.Label_WarningPassword);
            this.Controls.Add(this.Label_WarningUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RoundTextBox Txt_Username;
        private CustomControls.RJControls.RoundTextBox Txt_Password;
        private CustomUIComponent.RoundButton Btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_WarningUsername;
        private System.Windows.Forms.Label Label_WarningPassword;
        private System.Windows.Forms.Label Label_WarningAccount;
    }
}