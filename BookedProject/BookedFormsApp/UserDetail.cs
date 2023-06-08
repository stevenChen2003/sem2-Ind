using Booked.Domain.Domain;
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
	public partial class UserDetail : Form
	{
		private UserManager userManager;
		private User user;


		public UserDetail(UserManager userManager, string email)
		{
			InitializeComponent();
			this.userManager = userManager;
			try
			{
				user = userManager.GetUser(email);
				LoadInfo();
			}
			catch (GetException ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void buttonEnable_Click(object sender, EventArgs e)
		{
			EnableBox();
		}

		private void btEdit_Click(object sender, EventArgs e)
		{

		}


		//Load information
		public void LoadInfo()
		{
			firstNametbx.Text = user.FirstName;
			lastNametbx.Text = user.LastName;
			phoneNumbertbx.Text = user.PhoneNumber;
			dateOfBirthPicker.Value = user.DateOfBirth;
			emailtbx.Text = user.Email;
		}

		//Disable and enable boxes method
		public void DisableBox()
		{
			firstNametbx.Enabled = false;
			lastNametbx.Enabled = false;
			phoneNumbertbx.Enabled = false;
			dateOfBirthPicker.Enabled = false;
			btEdit.Enabled = false;
		}

		public void EnableBox()
		{
			firstNametbx.Enabled = true;
			lastNametbx.Enabled = true;
			phoneNumbertbx.Enabled = true;
			dateOfBirthPicker.Enabled = true;
			btEdit.Enabled = true;
		}





	}
}
