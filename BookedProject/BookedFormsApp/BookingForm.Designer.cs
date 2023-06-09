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
            btRemoveBooking = new Button();
            comboBoxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridBooking).BeginInit();
            SuspendLayout();
            // 
            // dataGridBooking
            // 
            dataGridBooking.AllowUserToAddRows = false;
            dataGridBooking.AllowUserToDeleteRows = false;
            dataGridBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBooking.Location = new Point(21, 83);
            dataGridBooking.Name = "dataGridBooking";
            dataGridBooking.ReadOnly = true;
            dataGridBooking.RowHeadersWidth = 51;
            dataGridBooking.RowTemplate.Height = 29;
            dataGridBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBooking.Size = new Size(1085, 499);
            dataGridBooking.TabIndex = 8;
            // 
            // btRemoveBooking
            // 
            btRemoveBooking.Location = new Point(39, 624);
            btRemoveBooking.Margin = new Padding(3, 4, 3, 4);
            btRemoveBooking.Name = "btRemoveBooking";
            btRemoveBooking.Size = new Size(234, 31);
            btRemoveBooking.TabIndex = 9;
            btRemoveBooking.Text = "Remove";
            btRemoveBooking.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Flight booking", "Hotel booking" });
            comboBoxFilter.Location = new Point(21, 34);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(230, 28);
            comboBoxFilter.TabIndex = 11;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 672);
            ControlBox = false;
            Controls.Add(comboBoxFilter);
            Controls.Add(dataGridBooking);
            Controls.Add(btRemoveBooking);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBooking;
        private Button btRemoveBooking;
        private ComboBox comboBoxFilter;
    }
}