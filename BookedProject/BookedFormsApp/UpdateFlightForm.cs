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
    public partial class UpdateFlightForm : Form
    {
        private FlightManager flightManager;
        private Flight flight;

        public UpdateFlightForm(FlightManager fm, Flight f)
        {
            InitializeComponent();
            flightManager = fm;
            flight = f;
        }
    }
}
