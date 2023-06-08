namespace BookedFormsApp
{
	partial class UserDetail
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			buttonEnable = new Button();
			btEdit = new Button();
			groupBox1 = new GroupBox();
			userTypeTB = new TextBox();
			labelUser = new Label();
			dateOfBirthPicker = new DateTimePicker();
			label16 = new Label();
			label1 = new Label();
			lastNametbx = new TextBox();
			firstNametbx = new TextBox();
			label2 = new Label();
			emailtbx = new TextBox();
			label10 = new Label();
			label9 = new Label();
			phoneNumbertbx = new TextBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Location = new Point(12, 13);
			tabControl1.Margin = new Padding(3, 4, 3, 4);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(722, 483);
			tabControl1.TabIndex = 41;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(buttonEnable);
			tabPage1.Controls.Add(btEdit);
			tabPage1.Controls.Add(groupBox1);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Margin = new Padding(3, 4, 3, 4);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 4, 3, 4);
			tabPage1.Size = new Size(714, 450);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Admin information";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonEnable
			// 
			buttonEnable.Location = new Point(144, 391);
			buttonEnable.Name = "buttonEnable";
			buttonEnable.Size = new Size(134, 29);
			buttonEnable.TabIndex = 40;
			buttonEnable.Text = "Make changes";
			buttonEnable.UseVisualStyleBackColor = true;
			buttonEnable.Click += buttonEnable_Click;
			// 
			// btEdit
			// 
			btEdit.Enabled = false;
			btEdit.Location = new Point(305, 391);
			btEdit.Name = "btEdit";
			btEdit.Size = new Size(133, 29);
			btEdit.TabIndex = 39;
			btEdit.Text = "Update";
			btEdit.UseVisualStyleBackColor = true;
			btEdit.Click += btEdit_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(userTypeTB);
			groupBox1.Controls.Add(labelUser);
			groupBox1.Controls.Add(dateOfBirthPicker);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(lastNametbx);
			groupBox1.Controls.Add(firstNametbx);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(emailtbx);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(phoneNumbertbx);
			groupBox1.Location = new Point(8, 7);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(697, 288);
			groupBox1.TabIndex = 33;
			groupBox1.TabStop = false;
			groupBox1.Text = "Employees's Basic Information";
			// 
			// userTypeTB
			// 
			userTypeTB.Enabled = false;
			userTypeTB.Location = new Point(429, 88);
			userTypeTB.Name = "userTypeTB";
			userTypeTB.Size = new Size(155, 27);
			userTypeTB.TabIndex = 37;
			// 
			// labelUser
			// 
			labelUser.AutoSize = true;
			labelUser.Location = new Point(347, 91);
			labelUser.Name = "labelUser";
			labelUser.Size = new Size(76, 20);
			labelUser.TabIndex = 36;
			labelUser.Text = "User Type:";
			// 
			// dateOfBirthPicker
			// 
			dateOfBirthPicker.Location = new Point(136, 144);
			dateOfBirthPicker.Name = "dateOfBirthPicker";
			dateOfBirthPicker.Size = new Size(250, 27);
			dateOfBirthPicker.TabIndex = 33;
			dateOfBirthPicker.Value = new DateTime(2023, 6, 7, 10, 40, 5, 0);
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(22, 144);
			label16.Name = "label16";
			label16.Size = new Size(97, 20);
			label16.TabIndex = 32;
			label16.Text = "Date of Birth:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 51);
			label1.Name = "label1";
			label1.Size = new Size(80, 20);
			label1.TabIndex = 2;
			label1.Text = "First name:";
			// 
			// lastNametbx
			// 
			lastNametbx.Location = new Point(136, 95);
			lastNametbx.Name = "lastNametbx";
			lastNametbx.Size = new Size(125, 27);
			lastNametbx.TabIndex = 0;
			// 
			// firstNametbx
			// 
			firstNametbx.Location = new Point(136, 47);
			firstNametbx.Name = "firstNametbx";
			firstNametbx.Size = new Size(125, 27);
			firstNametbx.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 95);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 3;
			label2.Text = "Last name:";
			// 
			// emailtbx
			// 
			emailtbx.Enabled = false;
			emailtbx.Location = new Point(429, 48);
			emailtbx.Name = "emailtbx";
			emailtbx.Size = new Size(262, 27);
			emailtbx.TabIndex = 16;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(23, 193);
			label10.Name = "label10";
			label10.Size = new Size(108, 20);
			label10.TabIndex = 19;
			label10.Text = "Phone number:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(353, 48);
			label9.Name = "label9";
			label9.Size = new Size(49, 20);
			label9.TabIndex = 17;
			label9.Text = "Email:";
			// 
			// phoneNumbertbx
			// 
			phoneNumbertbx.Location = new Point(137, 190);
			phoneNumbertbx.Name = "phoneNumbertbx";
			phoneNumbertbx.Size = new Size(190, 27);
			phoneNumbertbx.TabIndex = 18;
			// 
			// UserDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 548);
			Controls.Add(tabControl1);
			Name = "UserDetail";
			Text = "UserDetail";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private Button btEdit;
		private GroupBox groupBox1;
		private DateTimePicker dateOfBirthPicker;
		private Label label16;
		private Label label1;
		private TextBox lastNametbx;
		private TextBox firstNametbx;
		private Label label2;
		private TextBox emailtbx;
		private Label label10;
		private Label label9;
		private TextBox phoneNumbertbx;
		private Button buttonEnable;
		private TextBox userTypeTB;
		private Label labelUser;
	}
}