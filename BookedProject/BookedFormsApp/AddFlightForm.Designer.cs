namespace BookedFormsApp
{
    partial class AddFlightForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBAirline = new System.Windows.Forms.TextBox();
            this.tbDepartureAir = new System.Windows.Forms.TextBox();
            this.tbArrivalAir = new System.Windows.Forms.TextBox();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.numFlightSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSeats = new System.Windows.Forms.ComboBox();
            this.numExtraPrice = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.tbArrivalCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDepartureCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btSaveFlight = new System.Windows.Forms.Button();
            this.groupBoxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFlightSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Airport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Airport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seat Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Extra Baggage price:";
            // 
            // tBAirline
            // 
            this.tBAirline.Location = new System.Drawing.Point(129, 31);
            this.tBAirline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBAirline.Name = "tBAirline";
            this.tBAirline.Size = new System.Drawing.Size(356, 23);
            this.tBAirline.TabIndex = 7;
            // 
            // tbDepartureAir
            // 
            this.tbDepartureAir.Location = new System.Drawing.Point(129, 69);
            this.tbDepartureAir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartureAir.Name = "tbDepartureAir";
            this.tbDepartureAir.Size = new System.Drawing.Size(356, 23);
            this.tbDepartureAir.TabIndex = 8;
            // 
            // tbArrivalAir
            // 
            this.tbArrivalAir.Location = new System.Drawing.Point(129, 146);
            this.tbArrivalAir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArrivalAir.Name = "tbArrivalAir";
            this.tbArrivalAir.Size = new System.Drawing.Size(356, 23);
            this.tbArrivalAir.TabIndex = 9;
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
            this.groupBoxPrice.Location = new System.Drawing.Point(568, 11);
            this.groupBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPrice.Size = new System.Drawing.Size(500, 251);
            this.groupBoxPrice.TabIndex = 11;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Other information:";
            // 
            // numFlightSize
            // 
            this.numFlightSize.Location = new System.Drawing.Point(174, 137);
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
            this.numFlightSize.Size = new System.Drawing.Size(121, 23);
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
            "SINGLE",
            "NORMAL",
            "FAMILY"});
            this.comboBoxSeats.Location = new System.Drawing.Point(174, 103);
            this.comboBoxSeats.Name = "comboBoxSeats";
            this.comboBoxSeats.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSeats.TabIndex = 44;
            // 
            // numExtraPrice
            // 
            this.numExtraPrice.DecimalPlaces = 2;
            this.numExtraPrice.Location = new System.Drawing.Point(174, 65);
            this.numExtraPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numExtraPrice.Name = "numExtraPrice";
            this.numExtraPrice.Size = new System.Drawing.Size(295, 23);
            this.numExtraPrice.TabIndex = 43;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(174, 28);
            this.numPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(295, 23);
            this.numPrice.TabIndex = 42;
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
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 11);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Size = new System.Drawing.Size(530, 251);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Flight information:";
            // 
            // tbArrivalCountry
            // 
            this.tbArrivalCountry.Location = new System.Drawing.Point(129, 185);
            this.tbArrivalCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArrivalCountry.Name = "tbArrivalCountry";
            this.tbArrivalCountry.Size = new System.Drawing.Size(356, 23);
            this.tbArrivalCountry.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Arrival Country:";
            // 
            // tbDepartureCountry
            // 
            this.tbDepartureCountry.Location = new System.Drawing.Point(129, 106);
            this.tbDepartureCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDepartureCountry.Name = "tbDepartureCountry";
            this.tbDepartureCountry.Size = new System.Drawing.Size(356, 23);
            this.tbDepartureCountry.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Departure Country:";
            // 
            // btSaveFlight
            // 
            this.btSaveFlight.Location = new System.Drawing.Point(351, 353);
            this.btSaveFlight.Name = "btSaveFlight";
            this.btSaveFlight.Size = new System.Drawing.Size(416, 23);
            this.btSaveFlight.TabIndex = 32;
            this.btSaveFlight.Text = "Save";
            this.btSaveFlight.UseVisualStyleBackColor = true;
            this.btSaveFlight.Click += new System.EventHandler(this.btSaveFlight_Click);
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 452);
            this.Controls.Add(this.btSaveFlight);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxPrice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFlightSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tBAirline;
        private TextBox tbDepartureAir;
        private TextBox tbArrivalAir;
        private GroupBox groupBoxPrice;
        private GroupBox groupBoxInfo;
        private TextBox tbArrivalCountry;
        private Label label9;
        private TextBox tbDepartureCountry;
        private Label label8;
        private NumericUpDown numExtraPrice;
        private NumericUpDown numPrice;
        private ComboBox comboBoxSeats;
        private NumericUpDown numFlightSize;
        private Button btSaveFlight;
    }
}