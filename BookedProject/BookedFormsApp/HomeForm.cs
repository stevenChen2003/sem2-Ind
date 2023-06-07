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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btHotel_Click(object sender, EventArgs e)
        {
            HotelForm h = new HotelForm();
            h.TopLevel = false;
            pnContent.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void btFlight_Click(object sender, EventArgs e)
        {
            FlightForm f = new FlightForm();
            f.TopLevel = false;
            pnContent.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm();
            u.TopLevel = false;
            pnContent.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            BookingForm b = new BookingForm();
            b.TopLevel = false;
            pnContent.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }
    }
}
