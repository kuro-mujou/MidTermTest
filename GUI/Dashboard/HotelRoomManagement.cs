using BLL.BasicInfo;
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
        Logic_Rooms Logic_Rooms = new Logic_Rooms();
        public HotelRoomManagement()
        {
            InitializeComponent();
        }

        private void HotelRoomManagement_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
        private void LoadRooms()
        {
            try
            {
                Table_Room.DataSource = Logic_Rooms.CheckLogicRooms(); ;
                Table_Room.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception)
            {
                MessageBox.Show("some thing was wrong");
            }
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

    }
}
