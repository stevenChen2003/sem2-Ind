namespace BookedFormsApp
{
    partial class FlightForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListHotels = new System.Windows.Forms.TabPage();
            this.dataGridFlights = new System.Windows.Forms.DataGridView();
            this.tabPageHotel = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageListHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListHotels);
            this.tabControl1.Controls.Add(this.tabPageHotel);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 508);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageListHotels
            // 
            this.tabPageListHotels.Controls.Add(this.dataGridFlights);
            this.tabPageListHotels.Location = new System.Drawing.Point(4, 24);
            this.tabPageListHotels.Name = "tabPageListHotels";
            this.tabPageListHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListHotels.Size = new System.Drawing.Size(1012, 480);
            this.tabPageListHotels.TabIndex = 1;
            this.tabPageListHotels.Text = "All flights";
            this.tabPageListHotels.UseVisualStyleBackColor = true;
            // 
            // dataGridFlights
            // 
            this.dataGridFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFlights.Location = new System.Drawing.Point(23, 15);
            this.dataGridFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridFlights.Name = "dataGridFlights";
            this.dataGridFlights.RowHeadersWidth = 51;
            this.dataGridFlights.RowTemplate.Height = 29;
            this.dataGridFlights.Size = new System.Drawing.Size(938, 426);
            this.dataGridFlights.TabIndex = 0;
            // 
            // tabPageHotel
            // 
            this.tabPageHotel.Location = new System.Drawing.Point(4, 24);
            this.tabPageHotel.Name = "tabPageHotel";
            this.tabPageHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotel.Size = new System.Drawing.Size(1012, 480);
            this.tabPageHotel.TabIndex = 0;
            this.tabPageHotel.Text = "Hotels";
            this.tabPageHotel.UseVisualStyleBackColor = true;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 568);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageListHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageListHotels;
        private DataGridView dataGridFlights;
        private TabPage tabPageHotel;
    }
}