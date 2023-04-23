using Booked.Domain.Domain;
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
    public partial class UpdateHotelForm : Form
    {
        private HotelManager hotelManager;
        private Hotel hotel;

        public UpdateHotelForm(HotelManager manager)
        {
            InitializeComponent();
            hotelManager = manager;
            
        }


        public void LoadInfo()
        {
        }
    }
}
