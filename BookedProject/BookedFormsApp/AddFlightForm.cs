using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
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
    public partial class AddFlightForm : Form
    {
        private FlightManager flightManager;
        public AddFlightForm(FlightManager flightManager)
        {
            InitializeComponent();
            this.flightManager = flightManager;
            comboBoxSeats.SelectedIndex = 0;
        }

        private void btSaveFlight_Click(object sender, EventArgs e)
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
                    flightManager.AddFlight(flight);
					MessageBox.Show("FLight is added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FlightExistException i)
            {
                MessageBox.Show(i.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBoxes();
            }
        }


        //Reset Boxes
        public void ClearBoxes()
        {
            tBAirline.Clear();
            tbDepartureAir.Clear();
            tbDepartureCountry.Clear();
            tbArrivalAir.Clear();
            tbArrivalCountry.Clear();
            numPrice.Value = 0;
            comboBoxSeats.SelectedIndex = 0;
            numExtraPrice.Value = 0;
            numFlightSize.Value = numFlightSize.Minimum;
        }

        //Checker
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
