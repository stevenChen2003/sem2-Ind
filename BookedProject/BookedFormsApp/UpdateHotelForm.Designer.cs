﻿namespace BookedFormsApp
{
    partial class UpdateHotelForm
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
            this.tBCountry = new System.Windows.Forms.TextBox();
            this.tBCity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btUpdateHotel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnableBox = new System.Windows.Forms.Button();
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
            this.label9.Location = new System.Drawing.Point(26, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Amount of rooms:";
            // 
            // numHotelSize
            // 
            this.numHotelSize.Location = new System.Drawing.Point(161, 461);
            this.numHotelSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numHotelSize.Size = new System.Drawing.Size(138, 27);
            this.numHotelSize.TabIndex = 65;
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
            this.comboBoxRoom.Location = new System.Drawing.Point(161, 405);
            this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(138, 28);
            this.comboBoxRoom.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Name:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(161, 341);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(138, 27);
            this.numPrice.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.picBoxHotel);
            this.panel2.Location = new System.Drawing.Point(601, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 267);
            this.panel2.TabIndex = 61;
            // 
            // picBoxHotel
            // 
            this.picBoxHotel.BackColor = System.Drawing.Color.White;
            this.picBoxHotel.Location = new System.Drawing.Point(3, 4);
            this.picBoxHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxHotel.Name = "picBoxHotel";
            this.picBoxHotel.Size = new System.Drawing.Size(423, 259);
            this.picBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHotel.TabIndex = 18;
            this.picBoxHotel.TabStop = false;
            // 
            // numStarRating
            // 
            this.numStarRating.Location = new System.Drawing.Point(161, 267);
            this.numStarRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numStarRating.Size = new System.Drawing.Size(138, 27);
            this.numStarRating.TabIndex = 60;
            this.numStarRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBCountry
            // 
            this.tBCountry.Location = new System.Drawing.Point(150, 197);
            this.tBCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBCountry.Name = "tBCountry";
            this.tBCountry.Size = new System.Drawing.Size(375, 27);
            this.tBCountry.TabIndex = 58;
            // 
            // tBCity
            // 
            this.tBCity.Location = new System.Drawing.Point(150, 135);
            this.tBCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBCity.Name = "tBCity";
            this.tBCity.Size = new System.Drawing.Size(375, 27);
            this.tBCity.TabIndex = 57;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(150, 96);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(375, 27);
            this.tbAddress.TabIndex = 56;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(150, 48);
            this.tBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(375, 27);
            this.tBName.TabIndex = 55;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(601, 332);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(86, 31);
            this.btBrowse.TabIndex = 54;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btUpdateHotel
            // 
            this.btUpdateHotel.Location = new System.Drawing.Point(487, 555);
            this.btUpdateHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdateHotel.Name = "btUpdateHotel";
            this.btUpdateHotel.Size = new System.Drawing.Size(184, 31);
            this.btUpdateHotel.TabIndex = 52;
            this.btUpdateHotel.Text = "Update";
            this.btUpdateHotel.UseVisualStyleBackColor = true;
            this.btUpdateHotel.Click += new System.EventHandler(this.btUpdateHotel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Price per night:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "StarRating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Address:";
            // 
            // btEnableBox
            // 
            this.btEnableBox.Location = new System.Drawing.Point(176, 555);
            this.btEnableBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEnableBox.Name = "btEnableBox";
            this.btEnableBox.Size = new System.Drawing.Size(184, 31);
            this.btEnableBox.TabIndex = 68;
            this.btEnableBox.Text = "Make changes";
            this.btEnableBox.UseVisualStyleBackColor = true;
            this.btEnableBox.Click += new System.EventHandler(this.btEnableBox_Click);
            // 
            // UpdateHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 629);
            this.Controls.Add(this.btEnableBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numHotelSize);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numStarRating);
            this.Controls.Add(this.tBCountry);
            this.Controls.Add(this.tBCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.btUpdateHotel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateHotelForm";
            this.Text = "UpdateHotelForm";
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
        private TextBox tBCountry;
        private TextBox tBCity;
        private TextBox tbAddress;
        private TextBox tBName;
        private Button btBrowse;
        private Button btUpdateHotel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btEnableBox;
    }
}