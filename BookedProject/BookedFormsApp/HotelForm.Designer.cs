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
            dataGridHotels = new DataGridView();
            btAddhotel = new Button();
            btRemovehotel = new Button();
            btUpdateHotel = new Button();
            textBoxSearchHotel = new TextBox();
            buttonHotelSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHotels).BeginInit();
            SuspendLayout();
            // 
            // dataGridHotels
            // 
            dataGridHotels.AllowUserToAddRows = false;
            dataGridHotels.AllowUserToDeleteRows = false;
            dataGridHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHotels.Location = new Point(17, 58);
            dataGridHotels.Name = "dataGridHotels";
            dataGridHotels.ReadOnly = true;
            dataGridHotels.RowHeadersWidth = 51;
            dataGridHotels.RowTemplate.Height = 29;
            dataGridHotels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHotels.Size = new Size(1072, 457);
            dataGridHotels.TabIndex = 0;
            // 
            // btAddhotel
            // 
            btAddhotel.Location = new Point(17, 633);
            btAddhotel.Margin = new Padding(3, 4, 3, 4);
            btAddhotel.Name = "btAddhotel";
            btAddhotel.Size = new Size(234, 31);
            btAddhotel.TabIndex = 1;
            btAddhotel.Text = "Add";
            btAddhotel.UseVisualStyleBackColor = true;
            btAddhotel.Click += btAddHotel_Click;
            // 
            // btRemovehotel
            // 
            btRemovehotel.Location = new Point(328, 633);
            btRemovehotel.Margin = new Padding(3, 4, 3, 4);
            btRemovehotel.Name = "btRemovehotel";
            btRemovehotel.Size = new Size(234, 31);
            btRemovehotel.TabIndex = 2;
            btRemovehotel.Text = "Remove";
            btRemovehotel.UseVisualStyleBackColor = true;
            btRemovehotel.Click += btRemoveHotel_Click;
            // 
            // btUpdateHotel
            // 
            btUpdateHotel.Location = new Point(629, 633);
            btUpdateHotel.Margin = new Padding(3, 4, 3, 4);
            btUpdateHotel.Name = "btUpdateHotel";
            btUpdateHotel.Size = new Size(234, 31);
            btUpdateHotel.TabIndex = 3;
            btUpdateHotel.Text = "Update";
            btUpdateHotel.UseVisualStyleBackColor = true;
            btUpdateHotel.Click += btUpdateHotel_Click;
            // 
            // textBoxSearchHotel
            // 
            textBoxSearchHotel.Location = new Point(17, 12);
            textBoxSearchHotel.Name = "textBoxSearchHotel";
            textBoxSearchHotel.Size = new Size(432, 27);
            textBoxSearchHotel.TabIndex = 6;
            // 
            // buttonHotelSearch
            // 
            buttonHotelSearch.Location = new Point(477, 12);
            buttonHotelSearch.Name = "buttonHotelSearch";
            buttonHotelSearch.Size = new Size(94, 29);
            buttonHotelSearch.TabIndex = 7;
            buttonHotelSearch.Text = "Search";
            buttonHotelSearch.UseVisualStyleBackColor = true;
            buttonHotelSearch.Click += buttonHotelSearch_Click;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1166, 721);
            ControlBox = false;
            Controls.Add(buttonHotelSearch);
            Controls.Add(textBoxSearchHotel);
            Controls.Add(dataGridHotels);
            Controls.Add(btUpdateHotel);
            Controls.Add(btRemovehotel);
            Controls.Add(btAddhotel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridHotels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridHotels;
        private Button btAddhotel;
        private Button btRemovehotel;
        private Button btUpdateHotel;
        private TextBox textBoxSearchHotel;
        private Button buttonHotelSearch;
    }
}