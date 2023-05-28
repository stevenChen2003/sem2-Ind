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
	public partial class UserForm : Form
	{
		private UserManager userManager;

		public UserForm()
		{
			InitializeComponent();
			userManager = new UserManager(new UserRepository());
			try
			{
				LoadGrid();
			}
			catch (Exception)
			{
				MessageBox.Show("Database is not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btRemoveUser_Click(object sender, EventArgs e)
		{

		}

		private void btUserDetail_Click(object sender, EventArgs e)
		{

		}

		public void LoadGrid()
		{
			try
			{
				dataGridUser.DataSource = null;
				dataGridUser.Rows.Clear();
				dataGridUser.Refresh();
				dataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID", typeof(int));
				dataTable.Columns.Add("Email", typeof(string));
				dataTable.Columns.Add("Name", typeof(string));
				dataTable.Columns.Add("Date of birth", typeof(DateTime));
				dataTable.Columns.Add("Phone number", typeof(string));
				foreach (User user in userManager.GetAllUsers())
				{
					dataTable.Rows.Add(user.UserId, user.Email, $"{user.FirstName} {user.LastName}", user.DateOfBirth, user.PhoneNumber);
				}
				dataGridUser.DataSource = dataTable;
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}
	}
}
