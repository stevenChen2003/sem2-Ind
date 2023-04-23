using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookedFormsApp
{
	public partial class HotelForm : Form
	{
        private HotelManager hotelManager;

		public HotelForm()
		{
			InitializeComponent();
            hotelManager = new HotelManager(new HotelRepository());
			try
			{
                LoadGrid();
            }
			catch(Exception)
			{
				MessageBox.Show("Database is not connected","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btAddHotel_Click(object sender, EventArgs e)
        {
            AddHotelForm addHotelForm = new AddHotelForm();
            addHotelForm.ShowDialog();
            LoadGrid();
        }

        private void btRemoveHotel_Click(object sender, EventArgs e)
        {
			LoadGrid();
        }

        private void btUpdateHotel_Click(object sender, EventArgs e)
        {
            int id = 0;
            var selectedRow = dataGridHotels.CurrentRow;
            if (selectedRow != null)
            {
                id = (int)selectedRow.Cells["Hotel ID"].Value;
                UpdateHotelForm updateHotelForm = new UpdateHotelForm(hotelManager);
                updateHotelForm.ShowDialog();
                LoadGrid();
            }
            else
			{
				MessageBox.Show("Please select a hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        public void LoadGrid()
        {
            dataGridHotels.DataSource = null;
            dataGridHotels.Rows.Clear();
            dataGridHotels.Refresh();
            dataGridHotels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Hotel ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("Country", typeof(string));
            dataTable.Columns.Add("Star rating", typeof(string));
            dataTable.Columns.Add("Price per night", typeof(decimal));
            dataTable.Columns.Add("RoomType", typeof(Rooms));
            dataTable.Columns.Add("Maximumbooking", typeof(int));
            foreach (Hotel hotel in hotelManager.GetAllHotel())
            {
                dataTable.Rows.Add(hotel.HotelId, hotel.Name, hotel.Address, hotel.City, hotel.Country, hotel.StarRating, hotel.PricePerNight, hotel.Room, hotel.MaximumBooking);
            }
            dataGridHotels.DataSource = dataTable;
        }



    }

}