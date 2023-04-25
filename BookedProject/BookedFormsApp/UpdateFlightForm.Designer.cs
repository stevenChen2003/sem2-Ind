namespace BookedFormsApp
{
    partial class UpdateFlightForm
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
            this.btEnableBox = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.tbArrivalCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDepartureCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBAirline = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArrivalAir = new System.Windows.Forms.TextBox();
            this.tbDepartureAir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.numFlightSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSeats = new System.Windows.Forms.ComboBox();
            this.numExtraPrice = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btUpdateFlight = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFlightSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btEnableBox
            // 
            this.btEnableBox.Location = new System.Drawing.Point(15, 431);
            this.btEnableBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEnableBox.Name = "btEnableBox";
            this.btEnableBox.Size = new System.Drawing.Size(418, 31);
            this.btEnableBox.TabIndex = 35;
            this.btEnableBox.Text = "Makes Changes";
            this.btEnableBox.UseVisualStyleBackColor = true;
            this.btEnableBox.Click += new System.EventHandler(this.btEnableBox_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.tbArrivalCountry);
            this.groupBoxInfo.Controls.Add(this.label9);
            this.groupBoxInfo.Controls.Add(this.tbDepartureCountry);
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.tBAirline);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.tbArrivalAir);
            this.groupBoxInfo.Controls.Add(this.tbDepartureAir);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Location = new System.Drawing.Point(15, 15);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(605, 335);
            this.groupBoxInfo.TabIndex = 34;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Flight information:";
            // 
            // tbArrivalCountry
            // 
            this.tbArrivalCountry.Location = new System.Drawing.Point(147, 247);
            this.tbArrivalCountry.Name = "tbArrivalCountry";
            this.tbArrivalCountry.Size = new System.Drawing.Size(406, 27);
            this.tbArrivalCountry.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Arrival Country:";
            // 
            // tbDepartureCountry
            // 
            this.tbDepartureCountry.Location = new System.Drawing.Point(147, 141);
            this.tbDepartureCountry.Name = "tbDepartureCountry";
            this.tbDepartureCountry.Size = new System.Drawing.Size(406, 27);
            this.tbDepartureCountry.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Departure Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Name:";
            // 
            // tBAirline
            // 
            this.tBAirline.Location = new System.Drawing.Point(147, 41);
            this.tBAirline.Name = "tBAirline";
            this.tBAirline.Size = new System.Drawing.Size(406, 27);
            this.tBAirline.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Airport:";
            // 
            // tbArrivalAir
            // 
            this.tbArrivalAir.Location = new System.Drawing.Point(147, 195);
            this.tbArrivalAir.Name = "tbArrivalAir";
            this.tbArrivalAir.Size = new System.Drawing.Size(406, 27);
            this.tbArrivalAir.TabIndex = 9;
            // 
            // tbDepartureAir
            // 
            this.tbDepartureAir.Location = new System.Drawing.Point(147, 92);
            this.tbDepartureAir.Name = "tbDepartureAir";
            this.tbDepartureAir.Size = new System.Drawing.Size(406, 27);
            this.tbDepartureAir.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Airport:";
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.numFlightSize);
            this.groupBoxPrice.Controls.Add(this.comboBoxSeats);
            this.groupBoxPrice.Controls.Add(this.numExtraPrice);
            this.groupBoxPrice.Controls.Add(this.numPrice);
            this.groupBoxPrice.Controls.Add(this.label6);
            this.groupBoxPrice.Controls.Add(this.label7);
            this.groupBoxPrice.Controls.Add(this.label4);
            this.groupBoxPrice.Controls.Add(this.label5);
            this.groupBoxPrice.Location = new System.Drawing.Point(650, 15);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(571, 335);
            this.groupBoxPrice.TabIndex = 33;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Other information:";
            // 
            // numFlightSize
            // 
            this.numFlightSize.Location = new System.Drawing.Point(199, 183);
            this.numFlightSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFlightSize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numFlightSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFlightSize.Name = "numFlightSize";
            this.numFlightSize.Size = new System.Drawing.Size(138, 27);
            this.numFlightSize.TabIndex = 45;
            this.numFlightSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxSeats
            // 
            this.comboBoxSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeats.FormattingEnabled = true;
            this.comboBoxSeats.Items.AddRange(new object[] {
            "ECONOMY",
            "PREMIUM_ECONOMY",
            "BUSINESS",
            "FIRST_CLASS"});
            this.comboBoxSeats.Location = new System.Drawing.Point(199, 137);
            this.comboBoxSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSeats.Name = "comboBoxSeats";
            this.comboBoxSeats.Size = new System.Drawing.Size(138, 28);
            this.comboBoxSeats.TabIndex = 44;
            // 
            // numExtraPrice
            // 
            this.numExtraPrice.DecimalPlaces = 2;
            this.numExtraPrice.Location = new System.Drawing.Point(199, 87);
            this.numExtraPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numExtraPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numExtraPrice.Name = "numExtraPrice";
            this.numExtraPrice.Size = new System.Drawing.Size(337, 27);
            this.numExtraPrice.TabIndex = 43;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(199, 37);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(337, 27);
            this.numPrice.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Extra Baggage price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seat Type:";
            // 
            // btUpdateFlight
            // 
            this.btUpdateFlight.Location = new System.Drawing.Point(650, 431);
            this.btUpdateFlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdateFlight.Name = "btUpdateFlight";
            this.btUpdateFlight.Size = new System.Drawing.Size(418, 31);
            this.btUpdateFlight.TabIndex = 36;
            this.btUpdateFlight.Text = "Update";
            this.btUpdateFlight.UseVisualStyleBackColor = true;
            this.btUpdateFlight.Click += new System.EventHandler(this.btUpdateFlight_Click);
            // 
            // UpdateFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 603);
            this.Controls.Add(this.btUpdateFlight);
            this.Controls.Add(this.btEnableBox);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxPrice);
            this.Name = "UpdateFlightForm";
            this.Text = "UpdateFlightForm";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFlightSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btEnableBox;
        private GroupBox groupBoxInfo;
        private TextBox tbArrivalCountry;
        private Label label9;
        private TextBox tbDepartureCountry;
        private Label label8;
        private Label label1;
        private TextBox tBAirline;
        private Label label2;
        private TextBox tbArrivalAir;
        private TextBox tbDepartureAir;
        private Label label3;
        private GroupBox groupBoxPrice;
        private NumericUpDown numFlightSize;
        private ComboBox comboBoxSeats;
        private NumericUpDown numExtraPrice;
        private NumericUpDown numPrice;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Button btUpdateFlight;
    }
}