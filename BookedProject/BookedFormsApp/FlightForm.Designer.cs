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
            this.dataGridHotels = new System.Windows.Forms.DataGridView();
            this.tabPageHotel = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageListHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListHotels);
            this.tabControl1.Controls.Add(this.tabPageHotel);
            this.tabControl1.Location = new System.Drawing.Point(58, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 572);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageListHotels
            // 
            this.tabPageListHotels.Controls.Add(this.dataGridHotels);
            this.tabPageListHotels.Location = new System.Drawing.Point(4, 29);
            this.tabPageListHotels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageListHotels.Name = "tabPageListHotels";
            this.tabPageListHotels.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageListHotels.Size = new System.Drawing.Size(1059, 539);
            this.tabPageListHotels.TabIndex = 1;
            this.tabPageListHotels.Text = "List of hotels";
            this.tabPageListHotels.UseVisualStyleBackColor = true;
            // 
            // dataGridHotels
            // 
            this.dataGridHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotels.Location = new System.Drawing.Point(26, 20);
            this.dataGridHotels.Name = "dataGridHotels";
            this.dataGridHotels.RowHeadersWidth = 51;
            this.dataGridHotels.RowTemplate.Height = 29;
            this.dataGridHotels.Size = new System.Drawing.Size(1072, 568);
            this.dataGridHotels.TabIndex = 0;
            // 
            // tabPageHotel
            // 
            this.tabPageHotel.Location = new System.Drawing.Point(4, 29);
            this.tabPageHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageHotel.Name = "tabPageHotel";
            this.tabPageHotel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageHotel.Size = new System.Drawing.Size(1059, 539);
            this.tabPageHotel.TabIndex = 0;
            this.tabPageHotel.Text = "Hotels";
            this.tabPageHotel.UseVisualStyleBackColor = true;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageListHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageListHotels;
        private DataGridView dataGridHotels;
        private TabPage tabPageHotel;
    }
}