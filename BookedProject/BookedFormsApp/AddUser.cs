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
    public partial class AddUser : Form
    {
        private UserManager userManager;

        public AddUser(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        private void btAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBasicInfo())
                {
                    User user = new User(firstNametbx.Text, lastNametbx.Text, emailtbx.Text, dateOfBirthPicker.Value, phoneNumbertbx.Text, passwordTbx.Text);
                    user.UserType = UserType.Admin;
                    userManager.AddUser(user);
                }
                else
                {
                    MessageBox.Show("Field is empty or incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (EmailExistException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void ClearBoxes()
        {
            firstNametbx.Clear();
            lastNametbx.Clear();
            emailtbx.Clear();
            phoneNumbertbx.Clear();
            passwordTbx.Clear();
        }


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
