using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            LoadInfo();
            DisableBoxes();
        }

        private void btEnableBox_Click(object sender, EventArgs e)
        {
            EnableBoxes();
        }

        private void btUpdateFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextBoxesEmpty() || numPrice.Value == 0 || numExtraPrice.Value == 0)
                {
                    MessageBox.Show("Input is not valid or missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Flight flight = new Flight(tBAirline.Text, tbDepartureAir.Text, tbDepartureCountry.Text, tbArrivalAir.Text, tbArrivalCountry.Text, numPrice.Value, (Seats)comboBoxSeats.SelectedIndex, (int)numFlightSize.Value, numExtraPrice.Value);
                    flightManager.UpdateFlight(flight);
                    MessageBox.Show("FLight is Updated", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableBoxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Flight not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void LoadInfo()
        {
            tBAirline.Text = flight.AirlineName;
            tbDepartureAir.Text = flight.DepartureAirport;
            tbDepartureCountry.Text = flight.DepartureCountry;
            tbArrivalAir.Text = flight.ArrivalAirport;
            tbArrivalCountry.Text = flight.ArrivalCountry;
            numPrice.Value = flight.Price;
            numExtraPrice.Value = flight.ExtraBaggagePrice;
            comboBoxSeats.SelectedValue = (int)flight.Seat;
            numFlightSize.Value = flight.NumberOfSeats;
        }

        public void DisableBoxes()
        {
            tBAirline.Enabled = false;
            tbDepartureAir.Enabled = false;
            tbDepartureCountry.Enabled = false;
            tbArrivalAir.Enabled = false;
            tbArrivalCountry.Enabled = false;
            numPrice.Enabled = false;
            numExtraPrice.Enabled = false;
            comboBoxSeats.Enabled = false;
            numFlightSize.Enabled = false;
            btUpdateFlight.Enabled = false;
        }

        public void EnableBoxes()
        {
            tBAirline.Enabled = true;
            tbDepartureAir.Enabled = true;
            tbDepartureCountry.Enabled = true;
            tbArrivalAir.Enabled = true;
            tbArrivalCountry.Enabled = true;
            numPrice.Enabled = true;
            numExtraPrice.Enabled = true;
            comboBoxSeats.Enabled = true;
            numFlightSize.Enabled = true;
            btUpdateFlight.Enabled = true;
        }

        private bool CheckTextBoxesEmpty()
        {
            List<TextBox> relevantTextBoxes = new List<TextBox> { tBAirline, tbDepartureAir, tbDepartureCountry, tbArrivalAir, tbArrivalCountry };

            foreach (TextBox textBox in relevantTextBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
