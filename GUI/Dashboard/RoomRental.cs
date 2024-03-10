using BLL.BasicInfo;
using DTO.BasicInfo;
using DTO.BasicInfo.Customer;
using DTO.BasicInfo.HotelRoom;
using DTO.BasicInfo.Staff;
using GUI.CustomUIComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DTO.BasicInfo.HotelRoom.RoomManagement;

namespace GUI.Dashboard
{
    public partial class RoomRental : Form
    {
        Logic_Rental Logic_Rental = new Logic_Rental();
        private RoundButton currentButton;
        private bool isSearching = false;
        public RoomRental()
        {
            InitializeComponent();
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
        private void DefaultUIState()
        {
            Btn_Confirm.Visible = false;
            Btn_Cancel.Visible = false;

            lbl_Status.Visible = false;
            ComboBox_RentalStatus.Visible = false;

            Txt_Customer_Identity.ReadOnly = true;
            Txt_Customer_Address.ReadOnly = true;
            Txt_Customer_Name.ReadOnly = true;
            Txt_Customer_Phone.ReadOnly = true;
            Txt_Room_Number.ReadOnly = true;
            Txt_Room_Price.ReadOnly = true;
            Txt_Room_Status.ReadOnly = true;
            Txt_Room_Type.ReadOnly = true;

            Txt_IdentitySearch.ReadOnly = true;
            Txt_RoomNumberSearch.ReadOnly = true;


            Txt_Customer_Identity.Texts = string.Empty;
            Txt_Customer_Address.Texts = string.Empty;
            Txt_Customer_Name.Texts = string.Empty;
            Txt_Customer_Phone.Texts = string.Empty;
            Txt_Room_Number.Texts = string.Empty;
            Txt_Room_Price.Texts = string.Empty;
            Txt_Room_Status.Texts = string.Empty;
            Txt_Room_Type.Texts = string.Empty;
            Txt_IdentitySearch.Texts = string.Empty;
            Txt_RoomNumberSearch.Texts = string.Empty;

            Btn_Search.Enabled = true;
            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Delete.Enabled = true;
            Time_CheckIn.Enabled = false;
            Time_CheckOut.Enabled = false;

            Time_CheckIn.Value = DateTime.Now;
            Time_CheckOut.Value = DateTime.Now;
        }
        private void LoadRental()
        {
            try
            {
                Table_Rental.DataSource = Logic_Rental.CheckLogicGetRentals();
                Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception)
            {
                MessageBox.Show("some thing was wrong");
            }
        }
        private void Table_Rental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!isSearching)
                {
                    DataGridViewRow selectedRow = Table_Rental.Rows[e.RowIndex];

                    Txt_Customer_Identity.Texts = selectedRow.Cells["CustomerID"].Value.ToString();

                    Txt_Room_Number.Texts = selectedRow.Cells["Number"].Value.ToString();

                    Time_CheckIn.Value = DateTime.Parse(selectedRow.Cells["StartDay"].Value.ToString());
                    Time_CheckOut.Value = DateTime.Parse(selectedRow.Cells["EndDay"].Value.ToString());

                    ComboBox_RentalStatus.SelectedItem = selectedRow.Cells["RentalStatus"].Value.ToString();

                    Customer_Information customer_Information = Logic_Rental.GetCustomer_Information(int.Parse(selectedRow.Cells["CustomerID"].Value.ToString()));
                    Room_Information room_Information = Logic_Rental.GetRoom_Information(int.Parse(selectedRow.Cells["Number"].Value.ToString()));

                    Txt_Customer_Name.Texts = customer_Information.Customer_Name;
                    Txt_Customer_Phone.Texts = customer_Information.Customer_Phone;
                    Txt_Customer_Address.Texts = customer_Information.Customer_Address.ToString();

                    Txt_Room_Type.Texts = room_Information.RoomType.ToString();
                    Txt_Room_Status.Texts = room_Information.Status.ToString();

                    Txt_Room_Price.Texts = ""+(int)room_Information.Status;

                }
                else
                {
                    DataGridViewRow selectedRow = Table_Rental.Rows[e.RowIndex];
                    switch (Table_Rental.Columns[e.ColumnIndex].Name)
                    {
                        case "Id":
                            SearchByID(int.Parse(selectedRow.Cells["Id"].Value.ToString()));
                            break;

                        case "StartDay":
                            SearchByStartDay(selectedRow.Cells["StartDay"].Value.ToString());
                            break;

                        case "EndDay":
                            SearchByEndDay(selectedRow.Cells["EndDay"].Value.ToString());
                            break;

                        case "CustomerID":
                            SearchByCustomer_Identity(int.Parse(selectedRow.Cells["CustomerID"].Value.ToString()));
                            break;

                        case "Number":
                            SearchByRoom_Number(int.Parse(selectedRow.Cells["Number"].Value.ToString()));
                            break;

                        case "RentalStatus":
                            SearchByRentalStatus(selectedRow.Cells["RentalStatus"].Value.ToString());
                            break;
                    }
                }
            }
        }

        private RoomManagement GetUIData()
        {
            try
            {
                string startday = Time_CheckIn.ToString();
                string endday = Time_CheckOut.ToString();
                int customerID = int.Parse(Txt_Customer_Identity.Texts);
                int roomNumber = int.Parse(Txt_Room_Number.Texts);
                string status = string.Empty;
                RoomManagement.RentalStatus rentalStatus = RoomManagement.RentalStatus.Occupied;
                if (ComboBox_RentalStatus.SelectedItem != null)
                {
                    status = ComboBox_RentalStatus.SelectedItem.ToString();
                    rentalStatus = (RoomManagement.RentalStatus)Enum.Parse(typeof(RoomManagement.RentalStatus), status);
                }
                return new RoomManagement(startday,endday,customerID,roomNumber, rentalStatus);
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
                RoomManagement RoomManagement;
                switch (currentButton.Name)
                {
                    case "Btn_Add":
                        RoomManagement = GetUIData();
                        if (RoomManagement != null)
                        {
                            MessageBox.Show(Logic_Rental.CheckLogicAddRow(RoomManagement));
                            LoadRental();
                        }
                        break;

                    case "Btn_Edit":
                        RoomManagement = GetUIData();
                        if (RoomManagement != null)
                        {
                            MessageBox.Show(Logic_Rental.CheckLogicEditRow(RoomManagement));
                            LoadRental();
                        }
                        break;

                    case "Btn_Delete":
                        RoomManagement = GetUIData();
                        if (RoomManagement != null)
                        {
                            MessageBox.Show(Logic_Rental.CheckLogicDeleteRow(RoomManagement));
                            LoadRental();
                        }
                        break;
                }
            }
        }
        private void UpdateUIState()
        {
            Btn_Confirm.Visible = true;
            Btn_Cancel.Visible = true;
            lbl_Status.Visible = false;
            ComboBox_RentalStatus.Visible = false;

            Txt_Customer_Identity.Texts = string.Empty;
            Txt_Customer_Address.Texts = string.Empty;
            Txt_Customer_Name.Texts = string.Empty;
            Txt_Customer_Phone.Texts = string.Empty;
            Txt_Room_Number.Texts = string.Empty;
            Txt_Room_Price.Texts = string.Empty;
            Txt_Room_Status.Texts = string.Empty;
            Txt_Room_Type.Texts = string.Empty;
        }
        private void SearchByCustomer_Identity(int identity)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByCustomer_Identity(identity);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByRoom_Number(int number)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByRoom_Number(number);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByCustomerIdentity(int identity)
        {
            //Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByCustomer_Identity(identity);
            //Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Customer_Information customer_Information = Logic_Rental.GetCustomer_Information(identity);
            Txt_Customer_Identity.Texts = customer_Information.Customer_Identity.ToString();
            Txt_Customer_Name.Texts = customer_Information.Customer_Name;
            Txt_Customer_Phone.Texts = customer_Information.Customer_Phone;
            Txt_Customer_Address.Texts = customer_Information.Customer_Address.ToString();
        }
        private void SearchByRoomNumber(int number)
        {
            //Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByRoom_Number(number);
            //Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Room_Information room_Information = Logic_Rental.GetRoom_Information(number);
            Txt_Room_Number.Texts = room_Information.Number.ToString();
            Txt_Room_Type.Texts = room_Information.RoomType.ToString();
            Txt_Room_Status.Texts = room_Information.Status.ToString();
            Txt_Room_Price.Texts = "" + (int)room_Information.Status;
        }
        private void SearchByID(int id)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByID(id);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void SearchByStartDay(string startDay)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByStartDay(startDay);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void SearchByEndDay(string endday)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByEndDay(endday);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void SearchByRentalStatus(string Status)
        {
            Table_Rental.DataSource = Logic_Rental.CheckLogicSearchByRentalStatus(Status);
            Table_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            UpdateUIState();
            ActivateButton(sender);
            isSearching = true;

            Txt_RoomNumberSearch.ReadOnly = false;
            Txt_IdentitySearch.ReadOnly = false;

            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Confirm.Visible = false;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            Txt_RoomNumberSearch.ReadOnly = false;
            Txt_IdentitySearch.ReadOnly = false;
            Time_CheckIn.Enabled = true;
            Time_CheckOut.Enabled = true;

            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            UpdateUIState();

            lbl_Status.Visible = true;
            ComboBox_RentalStatus.Visible = true;
            Time_CheckIn.Enabled = true;
            Time_CheckOut.Enabled = true;

            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            UpdateUIState();
            ActivateButton(sender);
            Txt_RoomNumberSearch.ReadOnly = false;
            Txt_IdentitySearch.ReadOnly = false;
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isSearching = false;
            DefaultUIState();
            DisableButton();
        }
        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            isSearching = false;
            FunctionalButton(sender, e);
            DefaultUIState();
            DisableButton();
        }

        private void RoomRental_Load(object sender, EventArgs e)
        {
            LoadRental();
            if (!isSearching)
                DefaultUIState();
        }

        private void Txt_IdentitySearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int input = int.Parse(Txt_IdentitySearch.Texts);
                    SearchByCustomerIdentity(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
                }
            }
        }

        private void Txt_RoomNumberSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int input = int.Parse(Txt_IdentitySearch.Texts);
                    SearchByRoomNumber(input);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
                }
            }
        }
    }
}
