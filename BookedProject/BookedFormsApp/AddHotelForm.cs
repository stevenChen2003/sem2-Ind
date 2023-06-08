using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Exceptions;
using Booked.Logic.Exceptions.HotelException;
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
    public partial class AddHotelForm : Form
    {
        private HotelManager hotelManager;
        public AddHotelForm()
        {
            InitializeComponent();
            hotelManager = new HotelManager(new HotelRepository());
            comboBoxRoom.SelectedIndex = 0;
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //Get only images files
            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the filename of the selected image file.
                string fileName = openFile.FileName;
                Image image = Image.FromFile(fileName);
                picBoxHotel.Image = image;
            }
        }

        private void btSaveHotel_Click(object sender, EventArgs e)
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

                    Hotel hotel = new Hotel(name, address, city, country, starRating, price, rooms, size, imageData);
                    hotelManager.AddHotel(hotel);
					MessageBox.Show("Hotel is added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearBoxes();

                }

            }
            catch (HotelExistException i)
			{
				MessageBox.Show(i.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBoxes();
            }
            catch (AddHotelException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBoxes();
            }
        }


        //Reset
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
            picBoxHotel.Image = null;
        }
    }
}
