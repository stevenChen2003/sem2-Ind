namespace BookedFormsApp
{
	partial class BookingForm
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
			dataGridBooking = new DataGridView();
			btBookingDetail = new Button();
			btRemoveBooking = new Button();
			comboBox1 = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridBooking).BeginInit();
			SuspendLayout();
			// 
			// dataGridBooking
			// 
			dataGridBooking.AllowUserToAddRows = false;
			dataGridBooking.AllowUserToDeleteRows = false;
			dataGridBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridBooking.Location = new Point(21, 83);
			dataGridBooking.Name = "dataGridBooking";
			dataGridBooking.ReadOnly = true;
			dataGridBooking.RowHeadersWidth = 51;
			dataGridBooking.RowTemplate.Height = 29;
			dataGridBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridBooking.Size = new Size(1085, 499);
			dataGridBooking.TabIndex = 8;
			// 
			// btBookingDetail
			// 
			btBookingDetail.Location = new Point(335, 624);
			btBookingDetail.Margin = new Padding(3, 4, 3, 4);
			btBookingDetail.Name = "btBookingDetail";
			btBookingDetail.Size = new Size(234, 31);
			btBookingDetail.TabIndex = 10;
			btBookingDetail.Text = "Details";
			btBookingDetail.UseVisualStyleBackColor = true;
			// 
			// btRemoveBooking
			// 
			btRemoveBooking.Location = new Point(39, 624);
			btRemoveBooking.Margin = new Padding(3, 4, 3, 4);
			btRemoveBooking.Name = "btRemoveBooking";
			btRemoveBooking.Size = new Size(234, 31);
			btRemoveBooking.TabIndex = 9;
			btRemoveBooking.Text = "Remove";
			btRemoveBooking.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "All booking", "Flight booking", "Hotel" });
			comboBox1.Location = new Point(21, 34);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(184, 28);
			comboBox1.TabIndex = 11;
			// 
			// BookingForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1150, 672);
			ControlBox = false;
			Controls.Add(comboBox1);
			Controls.Add(dataGridBooking);
			Controls.Add(btBookingDetail);
			Controls.Add(btRemoveBooking);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 4, 3, 4);
			Name = "BookingForm";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridBooking).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridBooking;
		private Button btBookingDetail;
		private Button btRemoveBooking;
		private ComboBox comboBox1;
	}
}