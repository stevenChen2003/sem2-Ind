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
            MainForm s= new MainForm();
            s.TopLevel= false;
            pnContent.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }
    }
}
