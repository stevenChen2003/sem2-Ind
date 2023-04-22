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
        public FlightForm()
        {
            InitializeComponent();
        }

        private void btAddFlight_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlight = new AddFlightForm();
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
