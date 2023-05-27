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
			((System.ComponentModel.ISupportInitialize)dataGridBooking).BeginInit();
			SuspendLayout();
			// 
			// dataGridBooking
			// 
			dataGridBooking.AllowUserToAddRows = false;
			dataGridBooking.AllowUserToDeleteRows = false;
			dataGridBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridBooking.Location = new Point(34, 13);
			dataGridBooking.Margin = new Padding(3, 2, 3, 2);
			dataGridBooking.Name = "dataGridBooking";
			dataGridBooking.ReadOnly = true;
			dataGridBooking.RowHeadersWidth = 51;
			dataGridBooking.RowTemplate.Height = 29;
			dataGridBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridBooking.Size = new Size(938, 426);
			dataGridBooking.TabIndex = 8;
			// 
			// btBookingDetail
			// 
			btBookingDetail.Location = new Point(293, 468);
			btBookingDetail.Name = "btBookingDetail";
			btBookingDetail.Size = new Size(205, 23);
			btBookingDetail.TabIndex = 10;
			btBookingDetail.Text = "Details";
			btBookingDetail.UseVisualStyleBackColor = true;
			// 
			// btRemoveBooking
			// 
			btRemoveBooking.Location = new Point(34, 468);
			btRemoveBooking.Name = "btRemoveBooking";
			btRemoveBooking.Size = new Size(205, 23);
			btRemoveBooking.TabIndex = 9;
			btRemoveBooking.Text = "Remove";
			btRemoveBooking.UseVisualStyleBackColor = true;
			// 
			// BookingForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1006, 504);
			ControlBox = false;
			Controls.Add(dataGridBooking);
			Controls.Add(btBookingDetail);
			Controls.Add(btRemoveBooking);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "BookingForm";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridBooking).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridBooking;
		private Button btBookingDetail;
		private Button btRemoveBooking;
	}
}