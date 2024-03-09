using System;
using System.Windows.Forms;
using DTO.Login;
using BLL.Login;
using GUI.Dashboard;

namespace GUI
{
    public partial class Form_Login : Form
    {
        Logic_Login Logic_Login = new Logic_Login();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            ResetUI(sender, e);
            Login_Account Account = new Login_Account();
            Account.UserName = Txt_Username.Texts;
            Account.Password = Txt_Password.Texts;
            string a = Logic_Login.CheckLogicLogin(Account);
            switch (a)
            {
                case "require username":
                    Label_WarningUsername.Text = "username cant not be empty";
                    return;
                case "require password":
                    Label_WarningPassword.Text = "password cant not be empty";
                    return;
                case "no account found":
                    Label_WarningAccount.Text = "username or password wrong";
                    return;
            }
            this.Hide();
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Closed += (s, args) => this.Close();
            mainDashboard.Show();
        }

        private void ResetUI(object sender, EventArgs e)
        {
            Label_WarningUsername.Text = string.Empty;
            Label_WarningPassword.Text = string.Empty;
            Label_WarningAccount.Text = string.Empty;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login_Account Account = new Login_Account();
                Account.UserName = Txt_Username.Texts;
                Account.Password = Txt_Password.Texts;
                string a = Logic_Login.CheckLogicLogin(Account);
                switch (a)
                {
                    case "require username":
                        Label_WarningUsername.Text = "username cant not be empty";
                        return;
                    case "require password":
                        Label_WarningPassword.Text = "password cant not be empty";
                        return;
                    case "no account found":
                        Label_WarningAccount.Text = "username or password wrong";
                        return;
                }
                this.Hide();
                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.Closed += (s, args) => this.Close();
                mainDashboard.Show();
            }
            
        }
    }
}
