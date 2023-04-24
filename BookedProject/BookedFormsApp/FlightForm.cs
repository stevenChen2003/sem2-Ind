﻿using Booked.Infrastructure.Repositories;
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
    public partial class FlightForm : Form
    {
        private FlightManager flightManager;

        public FlightForm()
        {
            InitializeComponent();
            flightManager = new FlightManager(new FlightRepository());
        }

        private void btAddFlight_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlight = new AddFlightForm(flightManager);
            addFlight.ShowDialog();
        }

        private void btRemoveFlight_Click(object sender, EventArgs e)
        {

        }

        private void btUpdateFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
