using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
using Booked.Logic.Exceptions.HotelException;
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
				DisableBox();
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
			try
			{
				if (CheckBasicInfo())
				{
					User userUpdate = new User();
					userUpdate.UserId = user.UserId;
					userUpdate.Email = user.Email;
					userUpdate.FirstName = firstNametbx.Text;
					userUpdate.LastName = lastNametbx.Text;
					userUpdate.DateOfBirth = dateOfBirthPicker.Value;
					userUpdate.PhoneNumber = phoneNumbertbx.Text;
					userUpdate.UserType = user.UserType;

					userManager.UpdateUser(userUpdate);
					MessageBox.Show("Hotel is Updated", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DisableBox();
				}
				else
				{
					MessageBox.Show("Field is empty or incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (UpdateException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		//Load information
		public void LoadInfo()
		{
			firstNametbx.Text = user.FirstName;
			lastNametbx.Text = user.LastName;
			phoneNumbertbx.Text = user.PhoneNumber;
			dateOfBirthPicker.Value = user.DateOfBirth;
			emailtbx.Text = user.Email;
			userTypeTB.Text = user.UserType.ToString();
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

		//Check the textboxes
		private bool CheckBasicInfo()
		{
			bool allControlsNonEmpty = true;

			foreach (var textBox in tabControl1.Controls.OfType<TextBox>())
			{
				if (string.IsNullOrWhiteSpace(textBox.Text))
				{
					allControlsNonEmpty = false;
				}
			}
			return allControlsNonEmpty;
		}





	}
}
