using GUI.CustomUIComponent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Dashboard
{
    public partial class MainDashboard : Form
    {
        private RoundButton currentButton;
        private Form activeForm;
        public MainDashboard()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (RoundButton)btnSender;
                    currentButton.BackColor = Color.Black;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (RoundButton previousBtn in Panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(RoundButton))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Panel_Content.Controls.Add(childForm);
            this.Panel_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HotelRoomManagement(), sender);
        }

        private void RoundButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerManagement(), sender);
        }

        private void RoundButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffManagement(), sender);
        }

        private void RoundButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomRental(), sender);
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
