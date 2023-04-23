using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Services;
using System;
using System.Collections;
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
    public partial class UpdateHotelForm : Form
    {
        private HotelManager hotelManager;
        private Hotel hotel;

        public UpdateHotelForm(HotelManager manager, Hotel h)
        {
            InitializeComponent();
            hotelManager = manager;
            hotel = h;
            LoadInfo();
            DisableBox();
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

        private void btEnableBox_Click(object sender, EventArgs e)
        {
            EnableBox();
        }

        private void btUpdateHotel_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Hotel is Updated", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hotel is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Load hotel information methods
        public void LoadInfo()
        {
            tBName.Text = hotel.Name;
            tbAddress.Text = hotel.Address;
            tBCity.Text = hotel.City;
            tBCountry.Text = hotel.Country;
            numStarRating.Value = hotel.StarRating;
            numPrice.Value = hotel.PricePerNight;
            comboBoxRoom.SelectedIndex = (int)hotel.Room;
            numHotelSize.Value = hotel.MaximumBooking;
            LoadImage();
        }

        public void LoadImage()
        {
            Image image;
            using (var ms = new MemoryStream(hotel.Image))
            {
                image = Image.FromStream(ms);
            }
            picBoxHotel.Image = image;
        }

        //Disable and enable boxes method
        public void DisableBox()
        {
            tBName.Enabled = false;
            tbAddress.Enabled = false;
            tBCity.Enabled = false;
            tBCountry.Enabled = false;
            numStarRating.Enabled = false;
            numPrice.Enabled = false;
            comboBoxRoom.Enabled = false;
            numHotelSize.Enabled = false;
            btBrowse.Enabled = false;
        }

        public void EnableBox()
        {
            tBName.Enabled = true;
            tbAddress.Enabled = true;
            tBCity.Enabled = true;
            tBCountry.Enabled = true;
            numStarRating.Enabled = true;
            numPrice.Enabled = true;
            comboBoxRoom.Enabled = true;
            numHotelSize.Enabled = true;
            btBrowse.Enabled = true;
        }
    }
}
