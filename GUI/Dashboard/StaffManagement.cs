using BLL.BasicInfo;
using DTO.BasicInfo.Staff;
using DTO.BasicInfo;
using GUI.CustomUIComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dashboard
{
    public partial class StaffManagement : Form
    {
        private Logic_Staff Logic_Staff = new Logic_Staff();
        private RoundButton currentButton;
        private bool isSearching = false;

        public StaffManagement()
        {
            InitializeComponent();
        }
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            LoadStaff();
            if (!isSearching)
                DefaultUIState();
        }
        private void DefaultUIState()
        {
            Btn_Confirm.Visible = false;
            Btn_Cancel.Visible = false;

            Txt_City.Visible = false;
            Txt_Country.Visible = false;
            Txt_Address.Visible = true;

            Lbl_City.Visible = false;
            Lbl_Country.Visible = false;
            Lbl_Address.Visible = true;

            Btn_Search.Enabled = true;
            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Delete.Enabled = true;

            Txt_ID.ReadOnly = true;
            Txt_Name.ReadOnly = true;
            Txt_Email.ReadOnly = true;
            Txt_Phone.ReadOnly = true;
            Txt_Address.ReadOnly = true;
            Txt_Position.ReadOnly = true;
            Txt_Salary.ReadOnly = true;
            ComboBox_Gender.Enabled = false;

            Txt_ID.Texts = string.Empty;
            Txt_Name.Texts = string.Empty;
            Txt_Email.Texts = string.Empty;
            Txt_Phone.Texts = string.Empty;
            Txt_Address.Texts = string.Empty;
            Txt_Position.Texts = string.Empty;
            Txt_Salary.Texts = string.Empty;
            ComboBox_Gender.SelectedItem = null;
        }
        private void LoadStaff()
        {
            try
            {
                Table_Staff.DataSource = Logic_Staff.CheckLogicGetStaffs();
                Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception)
            {
                MessageBox.Show("some thing was wrong");
            }
        }
        private void Table_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!isSearching)
                {
                    DataGridViewRow selectedRow = Table_Staff.Rows[e.RowIndex];

                    Txt_ID.Texts = selectedRow.Cells["Staff_ID"].Value.ToString();
                    Txt_Name.Texts = selectedRow.Cells["Staff_Name"].Value.ToString();
                    Txt_Email.Texts = selectedRow.Cells["Staff_Email"].Value.ToString();
                    Txt_Phone.Texts = selectedRow.Cells["Staff_Phone"].Value.ToString();
                    Txt_Address.Texts = selectedRow.Cells["Staff_Address"].Value.ToString();
                    Txt_Position.Texts = selectedRow.Cells["Staff_Position"].Value.ToString();
                    Txt_Salary.Texts = selectedRow.Cells["Staff_Salary"].Value.ToString();
                    ComboBox_Gender.SelectedItem = selectedRow.Cells["Staff_Gender"].Value.ToString();
                }
                else
                {
                    DataGridViewRow selectedRow = Table_Staff.Rows[e.RowIndex];
                    switch (Table_Staff.Columns[e.ColumnIndex].Name)
                    {
                        case "Staff_ID":
                            SearchByStaff_ID(int.Parse(selectedRow.Cells["Staff_ID"].Value.ToString()));
                            break;

                        case "Staff_Name":
                            SearchByStaff_Name(selectedRow.Cells["Staff_Name"].Value.ToString());
                            break;

                        case "Staff_Email":
                            SearchByStaff_Email(selectedRow.Cells["Staff_Email"].Value.ToString());
                            break;

                        case "Staff_Phone":
                            SearchByStaff_Phone(selectedRow.Cells["Staff_Phone"].Value.ToString());
                            break;

                        case "Staff_Address":
                            SearchByStaff_Address(selectedRow.Cells["Staff_Address"].Value.ToString());
                            break;

                        case "Staff_Position":
                            SearchByStaff_Position(selectedRow.Cells["Staff_Position"].Value.ToString());
                            break;

                        case "Staff_Salary":
                            SearchByStaff_Salary(selectedRow.Cells["Staff_Salary"].Value.ToString());
                            break;

                        case "Staff_Gender":
                            SearchByStaff_Gender(selectedRow.Cells["Staff_Gender"].Value.ToString());
                            break;
                    }
                }
            }
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
                    currentButton.Font = new Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private Staff_Information GetUIDataWithID()
        {
            try
            {
                int ID = int.Parse(Txt_ID.Texts);
                string Name = Txt_Name.Texts;
                string Email = Txt_Email.Texts;
                string Phone = Txt_Phone.Texts;
                Address address = Address.StringToAddress(Txt_Address.Texts);
                string Position = Txt_Name.Texts;
                string Salary = Txt_Name.Texts;
                string gender = ComboBox_Gender.SelectedItem.ToString();
                return new Staff_Information(ID,Name,gender,Email,Phone,address,Position,Salary);
            }
            catch (Exception)
            {
                MessageBox.Show("Data shound't be empty(ID)");
                return null;
            }
        }
        private Staff_Information GetUIDataWithNoID()
        {
            try
            {
                string Name = Txt_Name.Texts;
                string Email = Txt_Email.Texts;
                string Phone = Txt_Phone.Texts;
                Address address = Address.StringToAddress(Txt_Address.Texts);
                string Position = Txt_Name.Texts;
                string Salary = Txt_Name.Texts;
                string gender = ComboBox_Gender.SelectedItem.ToString();
                return new Staff_Information(Name, gender, Email, Phone, address, Position, Salary);
            }
            catch (Exception)
            {
                MessageBox.Show("Data shound't be empty(noID)");
                return null;
            }
        }
        private void FunctionalButton(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Staff_Information Staff_Information;
                switch (currentButton.Name)
                {
                    case "Btn_Add":
                        Staff_Information = GetUIDataWithNoID();
                        if (Staff_Information != null)
                        {
                            MessageBox.Show(Logic_Staff.CheckLogicAddRow(Staff_Information));
                            LoadStaff();
                        }
                        break;

                    case "Btn_Edit":
                        Staff_Information = GetUIDataWithID();
                        if (Staff_Information != null)
                        {
                            MessageBox.Show(Logic_Staff.CheckLogicEditRow(Staff_Information));
                            LoadStaff();
                        }
                        break;

                    case "Btn_Delete":
                        Staff_Information = GetUIDataWithID();
                        if (Staff_Information != null)
                        {
                            MessageBox.Show(Logic_Staff.CheckLogicDeleteRow(Staff_Information));
                            LoadStaff();
                        }
                        break;
                }
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            Txt_City.Visible = true;
            Txt_City.ReadOnly = false;
            Txt_Country.Visible = true;
            Txt_Country.ReadOnly = false;

            Lbl_City.Visible = true;
            Lbl_Country.Visible = true;

            Lbl_Address.Visible = false;
            Txt_Address.Visible = false;

            Txt_ID.ReadOnly = true;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            Txt_Position.ReadOnly = false;
            Txt_Salary.ReadOnly = false;
            ComboBox_Gender.Enabled = true;

            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            Txt_City.Visible = true;
            Txt_City.ReadOnly = false;
            Txt_Country.Visible = true;
            Txt_Country.ReadOnly = false;

            Lbl_City.Visible = true;
            Lbl_Country.Visible = true;

            Lbl_Address.Visible = false;
            Txt_Address.Visible = false;

            Txt_ID.ReadOnly = true;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            Txt_Position.ReadOnly = false;
            Txt_Salary.ReadOnly = false;
            ComboBox_Gender.Enabled = true;

            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            Txt_City.Visible = false;
            Txt_Country.Visible = false;

            Lbl_City.Visible = false;
            Lbl_Country.Visible = false;

            Lbl_Address.Visible = true;
            Txt_Address.Visible = true;

            Txt_ID.ReadOnly = true;
            Txt_Name.ReadOnly = true;
            Txt_Email.ReadOnly = true;
            Txt_Phone.ReadOnly = true;
            Txt_Address.ReadOnly = true;
            Txt_Position.ReadOnly = false;
            Txt_Salary.ReadOnly = false;
            ComboBox_Gender.Enabled = true;

            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            Txt_City.Visible = false;
            Txt_Country.Visible = false;

            Lbl_City.Visible = false;
            Lbl_Country.Visible = false;

            Lbl_Address.Visible = true;
            Txt_Address.Visible = true;

            Txt_ID.ReadOnly = false;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            Txt_Address.ReadOnly = false;
            Txt_Position.ReadOnly = false;
            Txt_Salary.ReadOnly = false;
            ComboBox_Gender.Enabled = true;

            ActivateButton(sender);
            isSearching = true;
            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Confirm.Visible = false;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            isSearching = false;
            FunctionalButton(sender, e);
            DefaultUIState();
            ActivateButton(sender);
        }
        private void UpdateUIState()
        {
            Btn_Confirm.Visible = true;
            Btn_Cancel.Visible = true;

            Txt_ID.Texts = string.Empty;
            Txt_Name.Texts = string.Empty;
            Txt_Email.Texts = string.Empty;
            Txt_Phone.Texts = string.Empty;
            Txt_Address.Texts = string.Empty;
            ComboBox_Gender.SelectedItem = null;
            Txt_City.Texts = string.Empty;
            Txt_Country.Texts = string.Empty;
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isSearching = false;
            DefaultUIState();
            ActivateButton(sender);
        }
        private void SearchByStaff_ID(int ID)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_ID(ID);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Name(string Name)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Name(Name);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Phone(string Phone)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Phone(Phone);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Email(string Email)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Email(Email);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Address(string Address)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Address(Address);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Position(string Position)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Position(Position);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Salary(string Salary)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Salary(Salary);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByStaff_Gender(string Gender)
        {
            Table_Staff.DataSource = Logic_Staff.CheckLogicSearchByStaff_Gender(Gender);
            Table_Staff.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void ComboBox_Gender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSearching && sender.GetType().Equals(typeof(ComboBox)))
            {
                string gender = ComboBox_Gender.SelectedItem.ToString();
                SearchByStaff_Gender(gender);
            }
        }
        private void Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int ID = int.Parse(Txt_ID.Texts);
                    SearchByStaff_ID(ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }

        private void Txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Name.Texts;
                    SearchByStaff_Name(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }

        private void Txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Email.Texts;
                    SearchByStaff_Email(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }

        private void Txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Phone.Texts;
                    SearchByStaff_Phone(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }

        private void Txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Address.Texts;
                    SearchByStaff_Address(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }
        private void Txt_Position_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Position.Texts;
                    SearchByStaff_Position(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }
        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string input = Txt_Salary.Texts;
                    SearchByStaff_Salary(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Staff Found");
                }
            }
        }
    }
}
