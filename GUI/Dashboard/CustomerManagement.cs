using BLL.BasicInfo;
using DTO.BasicInfo.Customer;
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
    public partial class CustomerManagement : Form
    {
        private Logic_Customers Logic_Customers = new Logic_Customers();
        private RoundButton currentButton;
        private bool isSearching = false;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomers();
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
            Txt_Identity.ReadOnly = true;
            Txt_Name.ReadOnly = true;
            Txt_Email.ReadOnly = true;
            Txt_Phone.ReadOnly = true;
            Txt_Address.ReadOnly = true;

            Txt_ID.Texts = string.Empty;
            Txt_Identity.Texts = string.Empty;
            Txt_Name.Texts = string.Empty;
            Txt_Email.Texts = string.Empty;
            Txt_Phone.Texts = string.Empty;
            Txt_Address.Texts = string.Empty;
        }
        private void LoadCustomers()
        {
            try
            {
                Table_Customer.DataSource = Logic_Customers.CheckLogicGetCustomers();
                Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception)
            {
                MessageBox.Show("some thing was wrong");
            }
        }

        private void Table_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!isSearching)
                {
                    DataGridViewRow selectedRow = Table_Customer.Rows[e.RowIndex];

                    Txt_ID.Texts = selectedRow.Cells["Customer_ID"].Value.ToString(); ;
                    Txt_Identity.Texts = selectedRow.Cells["Customer_Identity"].Value.ToString(); ;
                    Txt_Name.Texts = selectedRow.Cells["Customer_Name"].Value.ToString(); ;
                    Txt_Email.Texts = selectedRow.Cells["Customer_Email"].Value.ToString(); ;
                    Txt_Phone.Texts = selectedRow.Cells["Customer_Phone"].Value.ToString(); ;
                    Txt_Address.Texts = selectedRow.Cells["Customer_Address"].Value.ToString(); ;

                }
                else
                {
                    DataGridViewRow selectedRow = Table_Customer.Rows[e.RowIndex];
                    switch (Table_Customer.Columns[e.ColumnIndex].Name)
                    {
                        case "Customer_ID":
                            SearchByCustomer_ID(int.Parse(selectedRow.Cells["Customer_ID"].Value.ToString()));
                            break;

                        case "Customer_Identity":
                            SearchByCustomer_Identity(int.Parse(selectedRow.Cells["Customer_Identity"].Value.ToString()));
                            break;

                        case "Customer_Name":
                            SearchByCustomer_Name(selectedRow.Cells["Customer_Name"].Value.ToString());
                            break;

                        case "Customer_Email":
                            SearchByCustomer_Email(selectedRow.Cells["Customer_Email"].Value.ToString());
                            break;

                        case "Customer_Phone":
                            SearchByCustomer_Phone(selectedRow.Cells["Customer_Phone"].Value.ToString());
                            break;

                        case "Customer_Address":
                            SearchByCustomer_Address(selectedRow.Cells["Customer_Address"].Value.ToString());
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
        private Customer_Information GetUIDataWithID()
        {
            try
            {
                int ID = int.Parse(Txt_ID.Texts);
                int Identity = int.Parse(Txt_Identity.Texts);
                string Name = Txt_Name.Texts;
                string Email = Txt_Email.Texts;
                string Phone = Txt_Phone.Texts;
                Address address = Address.StringToAddress(Txt_Address.Texts);
                return new Customer_Information(ID, Identity, Name, Email, Phone, address);
            }
            catch (Exception)
            {
                MessageBox.Show("Data shound't be empty(ID)");
                return null;
            }
        }
        private Customer_Information GetUIDataWithNoID()
        {
            try
            {
                int Identity = int.Parse(Txt_Identity.Texts);
                string Name = Txt_Name.Texts;
                string Email = Txt_Email.Texts;
                string Phone = Txt_Phone.Texts;
                Address address = Address.StringToAddress(Txt_City.Texts + "," + Txt_Country.Texts);
                return new Customer_Information(Identity, Name, Email, Phone, address);
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
                Customer_Information customer_Information;
                switch (currentButton.Name)
                {
                    case "Btn_Add":
                        customer_Information = GetUIDataWithNoID();
                        if (customer_Information != null)
                        {
                            MessageBox.Show(Logic_Customers.CheckLogicAddRow(customer_Information));
                            LoadCustomers();
                        }
                        break;

                    case "Btn_Edit":
                        customer_Information = GetUIDataWithID();
                        if (customer_Information != null)
                        {
                            MessageBox.Show(Logic_Customers.CheckLogicEditRow(customer_Information));
                            LoadCustomers();
                        }
                        break;

                    case "Btn_Delete":
                        customer_Information = GetUIDataWithID();
                        if (customer_Information != null)
                        {
                            MessageBox.Show(Logic_Customers.CheckLogicDeleteRow(customer_Information));
                            LoadCustomers();
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
            Txt_Identity.ReadOnly = false;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;

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
            Txt_Identity.ReadOnly = false;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;

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
            Txt_Identity.ReadOnly = true;
            Txt_Name.ReadOnly = true;
            Txt_Email.ReadOnly = true;
            Txt_Phone.ReadOnly = true;
            Txt_Address.ReadOnly = true;

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
            Txt_Identity.ReadOnly = false;
            Txt_Name.ReadOnly = false;
            Txt_Email.ReadOnly = false;
            Txt_Phone.ReadOnly = false;
            Txt_Address.ReadOnly = false;

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
            Txt_Identity.Texts = string.Empty;
            Txt_Name.Texts = string.Empty;
            Txt_Email.Texts = string.Empty;
            Txt_Phone.Texts = string.Empty;
            Txt_Address.Texts = string.Empty;
            Txt_City.Texts = string.Empty;
            Txt_Country.Texts = string.Empty;
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isSearching = false;
            DefaultUIState();
            ActivateButton(sender);
        }
        private void SearchByCustomer_ID(int ID)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_ID(ID);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomer_Identity(int ID)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_Identity(ID);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomer_Name(string Name)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_Name(Name);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomer_Phone(string Phone)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_Phone(Phone);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomer_Email(string Email)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_Email(Email);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomer_Address(string Address)
        {
            Table_Customer.DataSource = Logic_Customers.CheckLogicSearchByCustomer_Address(Address);
            Table_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int ID = int.Parse(Txt_ID.Texts);
                    SearchByCustomer_ID(ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
                }
            }
        }

        private void Txt_Identity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int ID = int.Parse(Txt_Identity.Texts);
                    SearchByCustomer_Identity(ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
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
                    SearchByCustomer_Name(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
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
                    SearchByCustomer_Email(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
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
                    SearchByCustomer_Phone(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
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
                    SearchByCustomer_Address(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
                }
            }
        }
    }
}
