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
    public partial class AddFlightForm : Form
    {
        private FlightManager flightManager;
        public AddFlightForm(FlightManager flightManager)
        {
            InitializeComponent();
            this.flightManager = flightManager;
        }

        private void btSaveFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
