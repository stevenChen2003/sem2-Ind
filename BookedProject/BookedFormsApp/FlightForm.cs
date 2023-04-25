using Booked.Domain.Domain.Enum;
using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
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
            try
            {
                LoadGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Database is not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddFlight_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlight = new AddFlightForm(flightManager);
            addFlight.ShowDialog();
            LoadGrid();
        }

        private void btRemoveFlight_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridFlights.CurrentRow;
            if (selectedRow != null)
            {
                int id = (int)selectedRow.Cells["Flight ID"].Value;
                flightManager.RemoveFlight(id);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select a flight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btUpdateFlight_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridFlights.CurrentRow;
            if (selectedRow != null)
            {
                int id = (int)selectedRow.Cells["Flight ID"].Value;
                Flight flight = flightManager.GetFlight(id);
                UpdateFlightForm updateFlightForm = new UpdateFlightForm(flightManager, flight);
                updateFlightForm.ShowDialog();
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select a flight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadGrid()
        {
            dataGridFlights.DataSource = null;
            dataGridFlights.Rows.Clear();
            dataGridFlights.Refresh();
            dataGridFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Flight ID", typeof(int));
            dataTable.Columns.Add("AirlineName", typeof(string));
            dataTable.Columns.Add("DepartureAirport", typeof(string));
            dataTable.Columns.Add("DepartureCountry", typeof(string));
            dataTable.Columns.Add("ArrivalAirport", typeof(string));
            dataTable.Columns.Add("ArrivalCountry", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("SeatType", typeof(Seats));
            dataTable.Columns.Add("Nr. Seats", typeof(int));
            dataTable.Columns.Add("Extra Bag Price", typeof(decimal));
            foreach (Flight flight in flightManager.GetAllFlight())
            {
                dataTable.Rows.Add(flight.FlightId, flight.AirlineName, flight.DepartureAirport, flight.DepartureCountry, flight.ArrivalAirport, flight.ArrivalCountry, flight.Price, flight.Seat, flight.NumberOfSeats, flight.ExtraBaggagePrice);
            }
            dataGridFlights.DataSource = dataTable;
        }

    }
}
