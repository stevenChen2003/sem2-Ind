using Booked.Domain.Domain;
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

        private void btUpdateHotel_Click(object sender, EventArgs e)
        {

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


    }
}
