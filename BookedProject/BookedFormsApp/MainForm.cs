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
                string fileName = openFile.FileName;
                tBURL.Text = fileName;
                Image image = Image.FromFile(fileName);
                picBoxHotel.Image = image;
            }
        }

        private void buttonSaveHotel_Click(object sender, EventArgs e)
        {
            try
            {
				if (picBoxHotel.Image != null)
				{
					byte[] imageData;

					using (var stream = new MemoryStream())
					{
						picBoxHotel.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
						imageData = stream.ToArray();
					}
					string name = Convert.ToString(tBName.Text);
					string address = Convert.ToString(tbAddress.Text);
					string city = Convert.ToString(tBCity.Text);
					string country = Convert.ToString(tBCountry.Text);
					int starRating = Convert.ToInt32(numStarRating.Value);
					decimal price = Convert.ToDecimal(numPrice.Value);
					hotelManager.AddHotel(name, address, city, country, starRating, price, imageData);
					MessageBox.Show("Hotel added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
            catch (Exception)
			{
                MessageBox.Show("Hotel not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

        }

    }
}