namespace BookedFormsApp
{
	partial class MainForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageHotel = new System.Windows.Forms.TabPage();
			this.numPrice = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.picBoxHotel = new System.Windows.Forms.PictureBox();
			this.numStarRating = new System.Windows.Forms.NumericUpDown();
			this.tBURL = new System.Windows.Forms.TextBox();
			this.tBCountry = new System.Windows.Forms.TextBox();
			this.tBCity = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tBName = new System.Windows.Forms.TextBox();
			this.btBrowse = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btSaveHotel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageFlight = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbTitleAdd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageHotel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxHotel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStarRating)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageHotel);
			this.tabControl1.Controls.Add(this.tabPageFlight);
			this.tabControl1.Location = new System.Drawing.Point(12, 72);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(985, 506);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageHotel
			// 
			this.tabPageHotel.Controls.Add(this.label1);
			this.tabPageHotel.Controls.Add(this.numPrice);
			this.tabPageHotel.Controls.Add(this.panel2);
			this.tabPageHotel.Controls.Add(this.numStarRating);
			this.tabPageHotel.Controls.Add(this.tBURL);
			this.tabPageHotel.Controls.Add(this.tBCountry);
			this.tabPageHotel.Controls.Add(this.tBCity);
			this.tabPageHotel.Controls.Add(this.tbAddress);
			this.tabPageHotel.Controls.Add(this.tBName);
			this.tabPageHotel.Controls.Add(this.btBrowse);
			this.tabPageHotel.Controls.Add(this.label7);
			this.tabPageHotel.Controls.Add(this.btSaveHotel);
			this.tabPageHotel.Controls.Add(this.label6);
			this.tabPageHotel.Controls.Add(this.label5);
			this.tabPageHotel.Controls.Add(this.label4);
			this.tabPageHotel.Controls.Add(this.label3);
			this.tabPageHotel.Controls.Add(this.label2);
			this.tabPageHotel.Location = new System.Drawing.Point(4, 24);
			this.tabPageHotel.Name = "tabPageHotel";
			this.tabPageHotel.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHotel.Size = new System.Drawing.Size(977, 478);
			this.tabPageHotel.TabIndex = 0;
			this.tabPageHotel.Text = "Hotels";
			this.tabPageHotel.UseVisualStyleBackColor = true;
			// 
			// numPrice
			// 
			this.numPrice.DecimalPlaces = 2;
			this.numPrice.Location = new System.Drawing.Point(162, 248);
			this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numPrice.Name = "numPrice";
			this.numPrice.Size = new System.Drawing.Size(100, 23);
			this.numPrice.TabIndex = 20;
			this.numPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Controls.Add(this.picBoxHotel);
			this.panel2.Location = new System.Drawing.Point(572, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(375, 200);
			this.panel2.TabIndex = 19;
			// 
			// picBoxHotel
			// 
			this.picBoxHotel.BackColor = System.Drawing.Color.White;
			this.picBoxHotel.Location = new System.Drawing.Point(3, 3);
			this.picBoxHotel.Name = "picBoxHotel";
			this.picBoxHotel.Size = new System.Drawing.Size(370, 194);
			this.picBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxHotel.TabIndex = 18;
			this.picBoxHotel.TabStop = false;
			// 
			// numStarRating
			// 
			this.numStarRating.Location = new System.Drawing.Point(162, 192);
			this.numStarRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numStarRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numStarRating.Name = "numStarRating";
			this.numStarRating.Size = new System.Drawing.Size(100, 23);
			this.numStarRating.TabIndex = 17;
			this.numStarRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tBURL
			// 
			this.tBURL.Enabled = false;
			this.tBURL.Location = new System.Drawing.Point(645, 29);
			this.tBURL.Name = "tBURL";
			this.tBURL.Size = new System.Drawing.Size(300, 23);
			this.tBURL.TabIndex = 16;
			// 
			// tBCountry
			// 
			this.tBCountry.Location = new System.Drawing.Point(162, 140);
			this.tBCountry.Name = "tBCountry";
			this.tBCountry.Size = new System.Drawing.Size(329, 23);
			this.tBCountry.TabIndex = 13;
			// 
			// tBCity
			// 
			this.tBCity.Location = new System.Drawing.Point(162, 95);
			this.tBCity.Name = "tBCity";
			this.tBCity.Size = new System.Drawing.Size(329, 23);
			this.tBCity.TabIndex = 12;
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(162, 65);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(329, 23);
			this.tbAddress.TabIndex = 11;
			// 
			// tBName
			// 
			this.tBName.Location = new System.Drawing.Point(162, 29);
			this.tBName.Name = "tBName";
			this.tBName.Size = new System.Drawing.Size(329, 23);
			this.tBName.TabIndex = 10;
			// 
			// btBrowse
			// 
			this.btBrowse.Location = new System.Drawing.Point(572, 271);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new System.Drawing.Size(75, 23);
			this.btBrowse.TabIndex = 9;
			this.btBrowse.Text = "Browse";
			this.btBrowse.UseVisualStyleBackColor = true;
			this.btBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(572, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Image URL:";
			// 
			// btSaveHotel
			// 
			this.btSaveHotel.Location = new System.Drawing.Point(245, 352);
			this.btSaveHotel.Name = "btSaveHotel";
			this.btSaveHotel.Size = new System.Drawing.Size(416, 23);
			this.btSaveHotel.TabIndex = 7;
			this.btSaveHotel.Text = "Save";
			this.btSaveHotel.UseVisualStyleBackColor = true;
			this.btSaveHotel.Click += new System.EventHandler(this.buttonSaveHotel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(69, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Price per night:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "StarRating:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Country:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "City:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Address:";
			// 
			// tabPageFlight
			// 
			this.tabPageFlight.Location = new System.Drawing.Point(4, 24);
			this.tabPageFlight.Name = "tabPageFlight";
			this.tabPageFlight.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFlight.Size = new System.Drawing.Size(977, 478);
			this.tabPageFlight.TabIndex = 1;
			this.tabPageFlight.Text = "Flights";
			this.tabPageFlight.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.lbTitleAdd);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 65);
			this.panel1.TabIndex = 1;
			// 
			// lbTitleAdd
			// 
			this.lbTitleAdd.AutoSize = true;
			this.lbTitleAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.lbTitleAdd.ForeColor = System.Drawing.Color.Gold;
			this.lbTitleAdd.Location = new System.Drawing.Point(15, 17);
			this.lbTitleAdd.Name = "lbTitleAdd";
			this.lbTitleAdd.Size = new System.Drawing.Size(107, 30);
			this.lbTitleAdd.TabIndex = 0;
			this.lbTitleAdd.Text = "Add Form";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 21;
			this.label1.Text = "Name:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1059, 590);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPageHotel.ResumeLayout(false);
			this.tabPageHotel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBoxHotel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStarRating)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageHotel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPageFlight;
        private Panel panel1;
        private Label lbTitleAdd;
        private Label label6;
        private Label label7;
        private Button btSaveHotel;
        private Button btBrowse;
        private TextBox tBURL;
        private TextBox tBCountry;
        private TextBox tBCity;
        private TextBox tbAddress;
        private TextBox tBName;
        private NumericUpDown numStarRating;
        private PictureBox picBoxHotel;
        private Panel panel2;
        private NumericUpDown numPrice;
		private Label label1;
	}
}