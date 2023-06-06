using Booked.Domain.Domain.Enum;
using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookedFormsApp
{
	public partial class BookingForm : Form
	{
		private BookingManager bookingManager;

		public BookingForm()
		{
			InitializeComponent();
			bookingManager = new BookingManager(new BookingRepository());
			try
			{
				LoadGrid();
			}
			catch (Exception)
			{
				MessageBox.Show("Error loading bookings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		public void LoadGrid()
		{
			try
			{
				dataGridBooking.DataSource = null;
				dataGridBooking.Rows.Clear();
				dataGridBooking.Refresh();
				dataGridBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(int));
				dataTable.Columns.Add("Booking Type", typeof(string));
				dataTable.Columns.Add("Booking Date", typeof(DateTime));
				dataTable.Columns.Add("Price", typeof(string));

				string bookingType = "";
				foreach (Booking booking in bookingManager.GetAllBooking())
				{
					if (booking is HotelBooking)
					{
						bookingType = "Hotel booking";
					}
					else if (booking is FlightBooking)
					{
						bookingType = "Flight booking";
					}
					dataTable.Rows.Add(booking.BookingId, bookingType, booking.BookingDate, booking.GetPrice());
				}
				dataGridBooking.DataSource = dataTable;
			}
			catch (Exception)
			{
				throw new Exception();
			}

		}
		
	}
}
