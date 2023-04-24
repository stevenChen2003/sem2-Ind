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
            this.btAddFlight = new System.Windows.Forms.Button();
            this.btRemoveFlight = new System.Windows.Forms.Button();
            this.btUpdateFlight = new System.Windows.Forms.Button();
            this.dataFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddFlight
            // 
            this.btAddFlight.Location = new System.Drawing.Point(12, 475);
            this.btAddFlight.Name = "btAddFlight";
            this.btAddFlight.Size = new System.Drawing.Size(205, 23);
            this.btAddFlight.TabIndex = 1;
            this.btAddFlight.Text = "Add";
            this.btAddFlight.UseVisualStyleBackColor = true;
            this.btAddFlight.Click += new System.EventHandler(this.btAddFlight_Click);
            // 
            // btRemoveFlight
            // 
            this.btRemoveFlight.Location = new System.Drawing.Point(307, 475);
            this.btRemoveFlight.Name = "btRemoveFlight";
            this.btRemoveFlight.Size = new System.Drawing.Size(205, 23);
            this.btRemoveFlight.TabIndex = 2;
            this.btRemoveFlight.Text = "Remove";
            this.btRemoveFlight.UseVisualStyleBackColor = true;
            this.btRemoveFlight.Click += new System.EventHandler(this.btRemoveFlight_Click);
            // 
            // btUpdateFlight
            // 
            this.btUpdateFlight.Location = new System.Drawing.Point(597, 475);
            this.btUpdateFlight.Name = "btUpdateFlight";
            this.btUpdateFlight.Size = new System.Drawing.Size(205, 23);
            this.btUpdateFlight.TabIndex = 3;
            this.btUpdateFlight.Text = "Update";
            this.btUpdateFlight.UseVisualStyleBackColor = true;
            this.btUpdateFlight.Click += new System.EventHandler(this.btUpdateFlight_Click);
            // 
            // dataFlights
            // 
            this.dataFlights.AllowUserToAddRows = false;
            this.dataFlights.AllowUserToDeleteRows = false;
            this.dataFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFlights.Location = new System.Drawing.Point(15, 11);
            this.dataFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataFlights.Name = "dataFlights";
            this.dataFlights.ReadOnly = true;
            this.dataFlights.RowHeadersWidth = 51;
            this.dataFlights.RowTemplate.Height = 29;
            this.dataFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFlights.Size = new System.Drawing.Size(938, 426);
            this.dataFlights.TabIndex = 4;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dataFlights);
            this.Controls.Add(this.btUpdateFlight);
            this.Controls.Add(this.btRemoveFlight);
            this.Controls.Add(this.btAddFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btAddFlight;
        private Button btRemoveFlight;
        private Button btUpdateFlight;
        private DataGridView dataFlights;
    }
}