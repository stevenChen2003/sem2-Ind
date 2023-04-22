using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
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
            hotelManager = new HotelManager();
			LoadGrid();
			comboBoxRoom.SelectedIndex= 0;
		}

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //Get only images files
            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the filename of the selected image file.
                string fileName = openFile.FileName;
                tBURL.Text = fileName;
                Image image = Image.FromFile(fileName);
                picBoxHotel.Image = image;
            }
        }

        private void buttonSaveHotel_Click(object sender, EventArgs e)
        {
            try
            {
				string name = Convert.ToString(tBName.Text);
				string address = Convert.ToString(tbAddress.Text);
				string city = Convert.ToString(tBCity.Text);
				string country = Convert.ToString(tBCountry.Text);
				int starRating = Convert.ToInt32(numStarRating.Value);
				decimal price = Convert.ToDecimal(numPrice.Value);
				Rooms rooms = (Rooms)comboBoxRoom.SelectedIndex;
				int size = Convert.ToInt32(numHotelSize.Value);

				if (picBoxHotel.Image == null || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(country) || price == 0)
				{
					MessageBox.Show("Input is not valid or missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					byte[] imageData;

					using (var stream = new MemoryStream())
					{
						picBoxHotel.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
						imageData = stream.ToArray();
					}
					hotelManager.AddHotel(name, address, city, country, starRating, price, rooms, size, imageData);
                    MessageBox.Show("Hotel is added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearBoxes();
                }

			}
            catch (Exception)
			{
                MessageBox.Show("Hotel not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

        }

		public void ClearBoxes()
		{
			tBName.Clear();
			tbAddress.Clear();
			tBCity.Clear();
			tBCountry.Clear();
			numStarRating.Value = numStarRating.Minimum;
			numPrice.Value = numPrice.Minimum;
			comboBoxRoom.SelectedIndex = 0;
			numHotelSize.Value = numHotelSize.Minimum;
			tBURL.Clear();
			picBoxHotel.Image = null;
		}

		public void LoadGrid()
		{
			dataGridHotels.DataSource = null;
			dataGridHotels.Rows.Clear();
			dataGridHotels.Refresh();
			dataGridHotels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			DataTable dataTable= new DataTable();
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

        private void btAddhotel_Click(object sender, EventArgs e)
        {
			AddHotelForm addHotelForm = new AddHotelForm();
			addHotelForm.ShowDialog();
			LoadGrid();
        }
    }

}