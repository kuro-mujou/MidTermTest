using BLL.BasicInfo;
using DTO.BasicInfo.HotelRoom;
using GUI.CustomUIComponent;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Dashboard
{
    public partial class HotelRoomManagement : Form
    {
        private Logic_Rooms Logic_Rooms = new Logic_Rooms();
        private RoundButton currentButton;
        private bool isSearching = false;

        public HotelRoomManagement()
        {
            InitializeComponent();
        }

        private void HotelRoomManagement_Load(object sender, EventArgs e)
        {
            LoadRooms();
            DefaultUIState();
        }
        private void DefaultUIState()
        {
            Txt_RoomNumber.ReadOnly = true;
            ComboBox_RoomType.Enabled = false;
            ComboBox_RoomStatus.Enabled = false;

            Btn_Confirm.Visible = false;
            Btn_Cancel.Visible = false;
            Btn_Search.Enabled = true;
            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Delete.Enabled = true;

            Txt_RoomNumber.Texts = string.Empty;
            ComboBox_RoomType.SelectedItem = null;
            ComboBox_RoomStatus.SelectedItem = null;
        }
        private void UpdateUIState(bool isEditing)
        {
            Txt_RoomNumber.ReadOnly = isEditing;
            ComboBox_RoomType.Enabled = true;
            ComboBox_RoomStatus.Enabled = true;
            Btn_Confirm.Visible = true;
            Btn_Cancel.Visible = true;

            Txt_RoomNumber.Texts = string.Empty;
            ComboBox_RoomType.SelectedItem = null;
            ComboBox_RoomStatus.SelectedItem = null;
        }
        private void LoadRooms()
        {
            try
            {
                Table_Room.DataSource = Logic_Rooms.CheckLogicGetRooms();
                Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception)
            {
                MessageBox.Show("some thing was wrong");
            }
        }
        private void Table_Room_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                string columnName = dgv.Columns[e.ColumnIndex].Name;
                if (columnName == "Status")
                {
                    object cellValue = dgv.Rows[e.RowIndex].Cells["Status"].Value;
                    if (cellValue != null)
                    {
                        string roomStatus = cellValue.ToString();
                        switch (roomStatus)
                        {
                            case "OCCUPIED":
                                e.CellStyle.BackColor = Color.FromArgb(252, 100, 100);
                                e.CellStyle.ForeColor = Color.Black;
                                break;

                            case "EMPTY":
                                e.CellStyle.BackColor = Color.FromArgb(193, 225, 193);
                                e.CellStyle.ForeColor = Color.Black;
                                break;

                            case "CLEANING":
                                e.CellStyle.BackColor = Color.FromArgb(253, 253, 150);
                                e.CellStyle.ForeColor = Color.Black;
                                break;
                        }
                    }
                }
            }
        }

        private void Table_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!isSearching)
                {
                    DataGridViewRow selectedRow = Table_Room.Rows[e.RowIndex];

                    Txt_RoomNumber.Texts = selectedRow.Cells["Number"].Value.ToString();
                    ComboBox_RoomType.SelectedItem = selectedRow.Cells["RoomType"].Value.ToString();
                    ComboBox_RoomStatus.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                }
                else
                {
                    DataGridViewRow selectedRow = Table_Room.Rows[e.RowIndex];
                    switch (Table_Room.Columns[e.ColumnIndex].Name)
                    {
                        case "RoomType":
                            SearchByType(selectedRow.Cells["RoomType"].Value.ToString());
                            break;

                        case "Status":
                            SearchByStatus(selectedRow.Cells["Status"].Value.ToString());
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
                    currentButton.Font = new Font("Calibri", 12.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private Room_Information GetUIData()
        {
            try
            {
                string num = Txt_RoomNumber.Texts;
                string type = (string)ComboBox_RoomType.SelectedItem;
                string status = (string)ComboBox_RoomStatus.SelectedItem;
                int.TryParse(num, out int roomNumber);
                Room_Information.Room_Type room_Type = (Room_Information.Room_Type)Enum.Parse(typeof(Room_Information.Room_Type), type);
                Room_Information.Room_Status room_Status = (Room_Information.Room_Status)Enum.Parse(typeof(Room_Information.Room_Status), status);
                return new Room_Information(roomNumber, room_Type, room_Status);
            }
            catch(Exception)
            {
                MessageBox.Show("Data shound't be empty");
                return null;
            }
        }
        private void FunctionalButton(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Room_Information room_Information = GetUIData();
                if (room_Information != null)
                {
                    switch (currentButton.Name)
                    {
                        case "Btn_Add":
                            MessageBox.Show(Logic_Rooms.CheckLogicAddRow(room_Information));
                            LoadRooms();
                            break;

                        case "Btn_Edit":
                            MessageBox.Show(Logic_Rooms.CheckLogicEditRow(room_Information));
                            LoadRooms();
                            break;

                        case "Btn_Delete":
                            MessageBox.Show(Logic_Rooms.CheckLogicDeleteRow(room_Information));
                            LoadRooms();
                            break;
                    }
                }
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            UpdateUIState(false);
            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            UpdateUIState(true);
            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            UpdateUIState(true);
            ActivateButton(sender);
            Btn_Search.Enabled = false;
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            UpdateUIState(false);
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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isSearching = false;
            DefaultUIState();
            ActivateButton(sender);
        }

        private void SearchByStatus(string status)
        {
            Table_Room.DataSource = Logic_Rooms.CheckLogicSeachByStatus(status);
            Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByType(string roomType)
        {
            Table_Room.DataSource = Logic_Rooms.CheckLogicSeachByRoomType(roomType);
            Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void SearchByNumber(int roomNumber)
        {
            Table_Room.DataSource = Logic_Rooms.CheckLogicSeachByRoomNumber(roomNumber);
            Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void ComboBox_RoomStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSearching && sender.GetType().Equals(typeof(ComboBox)))
            {
                string roomStatus = ComboBox_RoomStatus.SelectedItem.ToString();
                SearchByStatus(roomStatus);
            }
        }

        private void ComboRox_RoomType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSearching && sender.GetType().Equals(typeof(ComboBox)))
            {
                string roomType = ComboBox_RoomType.SelectedItem.ToString();
                SearchByType(roomType);
            }
        }

        private void Txt_RoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isSearching && e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int roomNumber = int.Parse(Txt_RoomNumber.Texts);
                    SearchByNumber(roomNumber);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Input Format/No Customer Found");
                }
            }
        }
    }
}
