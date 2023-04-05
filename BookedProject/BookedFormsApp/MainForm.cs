using Booked.Logic.Services;
using System.Windows.Forms;

namespace BookedFormsApp
{
	public partial class MainForm : Form
	{
        private HotelManager hotelManager;

		public MainForm()
		{
			InitializeComponent();
            hotelManager = new HotelManager();
		}

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //Get only images files
            openFile.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the filename of the selected image file.
                string fileName = Path.GetFileName(openFile.FileName);

                tBURL.Text = fileName;
            }
        }

        private void buttonSaveHotel_Click(object sender, EventArgs e)
        {

        }
    }
}