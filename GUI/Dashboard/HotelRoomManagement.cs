﻿using BLL.BasicInfo;
using DTO.BasicInfo.HotelRoom;
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
    public partial class HotelRoomManagement : Form
    {
        private Logic_Rooms Logic_Rooms = new Logic_Rooms();
        private RoundButton currentButton;
        private bool isSearching = false;
        private bool isClickRoomStatus = false;
        private bool isClickRoomType = false; 

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
            ComboRox_RoomType.Enabled = false;
            ComboBox_RoomStatus.Enabled = false;
            Btn_Confirm.Visible = false;
            Btn_Search.Enabled = true;
            Btn_Reload.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Delete.Enabled = true;
        }
        private void UpdateUIState(bool isEditing)
        {
            Txt_RoomNumber.ReadOnly = isEditing;
            ComboRox_RoomType.Enabled = true;
            ComboBox_RoomStatus.Enabled = true;
            Btn_Confirm.Visible = true;
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

                // Example: Set background color based on RoomStatus
                if (columnName == "Status")
                {
                    object cellValue = dgv.Rows[e.RowIndex].Cells["Status"].Value;
                    if(cellValue != null)
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
                DataGridViewRow selectedRow = Table_Room.Rows[e.RowIndex];
                Txt_RoomNumber.Texts = selectedRow.Cells["Number"].Value.ToString();
                ComboRox_RoomType.SelectedItem = selectedRow.Cells["RoomType"].Value.ToString();
                ComboBox_RoomStatus.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                switch (Table_Room.Columns[e.ColumnIndex].Name)
                {
                    case "RoomType":
                        isClickRoomType = true;
                        ComboRox_RoomType_OnSelectedIndexChanged(sender, EventArgs.Empty);
                        isClickRoomType = false;
                        break;

                    case "Status":
                        isClickRoomStatus = true;
                        ComboBox_RoomStatus_OnSelectedIndexChanged(sender, EventArgs.Empty);
                        isClickRoomStatus = false;
                        break;
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
        private Room_Information GetUIData()
        {
            int roomNumber = int.Parse(Txt_RoomNumber.Texts);
            Enum.TryParse(ComboRox_RoomType.SelectedItem.ToString(), out Room_Information.Room_Type room_Type);
            Enum.TryParse(ComboBox_RoomStatus.SelectedItem.ToString(), out Room_Information.Room_Status room_Status);
            return new Room_Information(roomNumber, room_Type, room_Status);
        }
        private void FunctionalButton(object sender,EventArgs e)
        {
            if(sender != null)
            {
                switch (currentButton.Name)
                {
                    case "Btn_Add":
                        MessageBox.Show(Logic_Rooms.CheckLogicAddRow(GetUIData()));
                        LoadRooms();
                        break;

                    case "Btn_Edit":
                        MessageBox.Show(Logic_Rooms.CheckLogicEditRow(GetUIData()));
                        LoadRooms();
                        break;

                    case "Btn_Delete":
                        MessageBox.Show(Logic_Rooms.CheckLogicDeleteRow(GetUIData()));
                        LoadRooms();
                        break;

                    case "Btn_Search":

                        break;
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
            isSearching = true;
            UpdateUIState(false);
            ActivateButton(sender);
            Btn_Reload.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            isSearching = false;
            DefaultUIState();
            FunctionalButton(sender,e);
            ActivateButton(sender);
        }
        private void ComboBox_RoomStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSearching&&isClickRoomStatus)
            {
                string status = ComboBox_RoomStatus.SelectedItem.ToString();
                Table_Room.DataSource = Logic_Rooms.CheckLogicSeachByStatus(status);
                Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void ComboRox_RoomType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSearching&&isClickRoomType)
            {
                string roomType = ComboRox_RoomType.SelectedItem.ToString();
                Table_Room.DataSource = Logic_Rooms.CheckLogicSeachByRoomType(roomType);
                Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }
    }
}
