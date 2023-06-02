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
            btAddFlight = new Button();
            btRemoveFlight = new Button();
            btUpdateFlight = new Button();
            dataGridFlights = new DataGridView();
            textBoxDep = new TextBox();
            buttonFlightSearch = new Button();
            textBoxArrive = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridFlights).BeginInit();
            SuspendLayout();
            // 
            // btAddFlight
            // 
            btAddFlight.Location = new Point(14, 633);
            btAddFlight.Margin = new Padding(3, 4, 3, 4);
            btAddFlight.Name = "btAddFlight";
            btAddFlight.Size = new Size(234, 31);
            btAddFlight.TabIndex = 1;
            btAddFlight.Text = "Add";
            btAddFlight.UseVisualStyleBackColor = true;
            btAddFlight.Click += btAddFlight_Click;
            // 
            // btRemoveFlight
            // 
            btRemoveFlight.Location = new Point(351, 633);
            btRemoveFlight.Margin = new Padding(3, 4, 3, 4);
            btRemoveFlight.Name = "btRemoveFlight";
            btRemoveFlight.Size = new Size(234, 31);
            btRemoveFlight.TabIndex = 2;
            btRemoveFlight.Text = "Remove";
            btRemoveFlight.UseVisualStyleBackColor = true;
            btRemoveFlight.Click += btRemoveFlight_Click;
            // 
            // btUpdateFlight
            // 
            btUpdateFlight.Location = new Point(682, 633);
            btUpdateFlight.Margin = new Padding(3, 4, 3, 4);
            btUpdateFlight.Name = "btUpdateFlight";
            btUpdateFlight.Size = new Size(234, 31);
            btUpdateFlight.TabIndex = 3;
            btUpdateFlight.Text = "Update";
            btUpdateFlight.UseVisualStyleBackColor = true;
            btUpdateFlight.Click += btUpdateFlight_Click;
            // 
            // dataGridFlights
            // 
            dataGridFlights.AllowUserToAddRows = false;
            dataGridFlights.AllowUserToDeleteRows = false;
            dataGridFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFlights.Location = new Point(14, 82);
            dataGridFlights.Name = "dataGridFlights";
            dataGridFlights.ReadOnly = true;
            dataGridFlights.RowHeadersWidth = 51;
            dataGridFlights.RowTemplate.Height = 29;
            dataGridFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFlights.Size = new Size(1072, 512);
            dataGridFlights.TabIndex = 4;
            // 
            // textBoxDep
            // 
            textBoxDep.Location = new Point(14, 35);
            textBoxDep.Name = "textBoxDep";
            textBoxDep.Size = new Size(254, 27);
            textBoxDep.TabIndex = 5;
            // 
            // buttonFlightSearch
            // 
            buttonFlightSearch.Location = new Point(601, 35);
            buttonFlightSearch.Name = "buttonFlightSearch";
            buttonFlightSearch.Size = new Size(94, 29);
            buttonFlightSearch.TabIndex = 8;
            buttonFlightSearch.Text = "Search";
            buttonFlightSearch.UseVisualStyleBackColor = true;
            buttonFlightSearch.Click += buttonFlightSearch_Click;
            // 
            // textBoxArrive
            // 
            textBoxArrive.Location = new Point(304, 35);
            textBoxArrive.Name = "textBoxArrive";
            textBoxArrive.Size = new Size(254, 27);
            textBoxArrive.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 12);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 11;
            label2.Text = "To:";
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1166, 721);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxArrive);
            Controls.Add(buttonFlightSearch);
            Controls.Add(textBoxDep);
            Controls.Add(dataGridFlights);
            Controls.Add(btUpdateFlight);
            Controls.Add(btRemoveFlight);
            Controls.Add(btAddFlight);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FlightForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAddFlight;
        private Button btRemoveFlight;
        private Button btUpdateFlight;
        private DataGridView dataGridFlights;
        private TextBox textBoxDep;
        private Button buttonFlightSearch;
        private TextBox textBoxArrive;
        private Label label1;
        private Label label2;
    }
}