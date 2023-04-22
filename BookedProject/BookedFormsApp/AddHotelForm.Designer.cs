﻿namespace BookedFormsApp
{
    partial class AddHotelForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numHotelSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numHotelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStarRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Amount of rooms:";
            // 
            // numHotelSize
            // 
            this.numHotelSize.Location = new System.Drawing.Point(161, 341);
            this.numHotelSize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numHotelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHotelSize.Name = "numHotelSize";
            this.numHotelSize.Size = new System.Drawing.Size(121, 23);
            this.numHotelSize.TabIndex = 44;
            this.numHotelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "SINGLE",
            "NORMAL",
            "FAMILY"});
            this.comboBoxRoom.Location = new System.Drawing.Point(161, 299);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRoom.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(161, 251);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(121, 23);
            this.numPrice.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.picBoxHotel);
            this.panel2.Location = new System.Drawing.Point(546, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 200);
            this.panel2.TabIndex = 40;
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
            this.numStarRating.Location = new System.Drawing.Point(161, 195);
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
            this.numStarRating.Size = new System.Drawing.Size(121, 23);
            this.numStarRating.TabIndex = 39;
            this.numStarRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBURL
            // 
            this.tBURL.Enabled = false;
            this.tBURL.Location = new System.Drawing.Point(619, 31);
            this.tBURL.Name = "tBURL";
            this.tBURL.Size = new System.Drawing.Size(300, 23);
            this.tBURL.TabIndex = 38;
            // 
            // tBCountry
            // 
            this.tBCountry.Location = new System.Drawing.Point(151, 143);
            this.tBCountry.Name = "tBCountry";
            this.tBCountry.Size = new System.Drawing.Size(329, 23);
            this.tBCountry.TabIndex = 37;
            // 
            // tBCity
            // 
            this.tBCity.Location = new System.Drawing.Point(151, 96);
            this.tBCity.Name = "tBCity";
            this.tBCity.Size = new System.Drawing.Size(329, 23);
            this.tBCity.TabIndex = 36;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(151, 67);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(329, 23);
            this.tbAddress.TabIndex = 35;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(151, 31);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(329, 23);
            this.tBName.TabIndex = 34;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(546, 273);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 33;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Image URL:";
            // 
            // btSaveHotel
            // 
            this.btSaveHotel.Location = new System.Drawing.Point(218, 409);
            this.btSaveHotel.Name = "btSaveHotel";
            this.btSaveHotel.Size = new System.Drawing.Size(416, 23);
            this.btSaveHotel.TabIndex = 31;
            this.btSaveHotel.Text = "Save";
            this.btSaveHotel.UseVisualStyleBackColor = true;
            this.btSaveHotel.Click += new System.EventHandler(this.btSaveHotel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price per night:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "StarRating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address:";
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(943, 491);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numHotelSize);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numStarRating);
            this.Controls.Add(this.tBURL);
            this.Controls.Add(this.tBCountry);
            this.Controls.Add(this.tBCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSaveHotel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddHotelForm";
            this.Text = "AddHotelForm";
            ((System.ComponentModel.ISupportInitialize)(this.numHotelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStarRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label8;
        private NumericUpDown numHotelSize;
        private ComboBox comboBoxRoom;
        private Label label1;
        private NumericUpDown numPrice;
        private Panel panel2;
        private PictureBox picBoxHotel;
        private NumericUpDown numStarRating;
        private TextBox tBURL;
        private TextBox tBCountry;
        private TextBox tBCity;
        private TextBox tbAddress;
        private TextBox tBName;
        private Button btBrowse;
        private Label label7;
        private Button btSaveHotel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}