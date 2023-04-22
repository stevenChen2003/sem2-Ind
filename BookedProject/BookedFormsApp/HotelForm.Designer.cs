namespace BookedFormsApp
{
	partial class HotelForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dataGridHotels = new System.Windows.Forms.DataGridView();
            this.btAddhotel = new System.Windows.Forms.Button();
            this.btRemovehotel = new System.Windows.Forms.Button();
            this.btUpdateHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHotels
            // 
            this.dataGridHotels.AllowUserToAddRows = false;
            this.dataGridHotels.AllowUserToDeleteRows = false;
            this.dataGridHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotels.Location = new System.Drawing.Point(16, 11);
            this.dataGridHotels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHotels.Name = "dataGridHotels";
            this.dataGridHotels.ReadOnly = true;
            this.dataGridHotels.RowHeadersWidth = 51;
            this.dataGridHotels.RowTemplate.Height = 29;
            this.dataGridHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHotels.Size = new System.Drawing.Size(938, 426);
            this.dataGridHotels.TabIndex = 0;
            // 
            // btAddhotel
            // 
            this.btAddhotel.Location = new System.Drawing.Point(16, 474);
            this.btAddhotel.Name = "btAddhotel";
            this.btAddhotel.Size = new System.Drawing.Size(205, 23);
            this.btAddhotel.TabIndex = 1;
            this.btAddhotel.Text = "Add";
            this.btAddhotel.UseVisualStyleBackColor = true;
            this.btAddhotel.Click += new System.EventHandler(this.btAddHotel_Click);
            // 
            // btRemovehotel
            // 
            this.btRemovehotel.Location = new System.Drawing.Point(287, 474);
            this.btRemovehotel.Name = "btRemovehotel";
            this.btRemovehotel.Size = new System.Drawing.Size(205, 23);
            this.btRemovehotel.TabIndex = 2;
            this.btRemovehotel.Text = "Remove";
            this.btRemovehotel.UseVisualStyleBackColor = true;
            this.btRemovehotel.Click += new System.EventHandler(this.btRemoveHotel_Click);
            // 
            // btUpdateHotel
            // 
            this.btUpdateHotel.Location = new System.Drawing.Point(550, 474);
            this.btUpdateHotel.Name = "btUpdateHotel";
            this.btUpdateHotel.Size = new System.Drawing.Size(205, 23);
            this.btUpdateHotel.TabIndex = 3;
            this.btUpdateHotel.Text = "Update";
            this.btUpdateHotel.UseVisualStyleBackColor = true;
            this.btUpdateHotel.Click += new System.EventHandler(this.btUpdateHotel_Click);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridHotels);
            this.Controls.Add(this.btUpdateHotel);
            this.Controls.Add(this.btRemovehotel);
            this.Controls.Add(this.btAddhotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HotelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotels)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private DataGridView dataGridHotels;
        private Button btAddhotel;
        private Button btRemovehotel;
        private Button btUpdateHotel;
    }
}