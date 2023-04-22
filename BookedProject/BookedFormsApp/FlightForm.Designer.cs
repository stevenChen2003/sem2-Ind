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
            this.dataGridFlights = new System.Windows.Forms.DataGridView();
            this.btAddFlight = new System.Windows.Forms.Button();
            this.btRemoveFlight = new System.Windows.Forms.Button();
            this.btUpdateFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFlights
            // 
            this.dataGridFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFlights.Location = new System.Drawing.Point(12, 11);
            this.dataGridFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridFlights.Name = "dataGridFlights";
            this.dataGridFlights.RowHeadersWidth = 51;
            this.dataGridFlights.RowTemplate.Height = 29;
            this.dataGridFlights.Size = new System.Drawing.Size(938, 426);
            this.dataGridFlights.TabIndex = 0;
            // 
            // btAddFlight
            // 
            this.btAddFlight.Location = new System.Drawing.Point(12, 485);
            this.btAddFlight.Name = "btAddFlight";
            this.btAddFlight.Size = new System.Drawing.Size(205, 23);
            this.btAddFlight.TabIndex = 1;
            this.btAddFlight.Text = "Add";
            this.btAddFlight.UseVisualStyleBackColor = true;
            this.btAddFlight.Click += new System.EventHandler(this.btAddFlight_Click);
            // 
            // btRemoveFlight
            // 
            this.btRemoveFlight.Location = new System.Drawing.Point(307, 485);
            this.btRemoveFlight.Name = "btRemoveFlight";
            this.btRemoveFlight.Size = new System.Drawing.Size(205, 23);
            this.btRemoveFlight.TabIndex = 2;
            this.btRemoveFlight.Text = "Remove";
            this.btRemoveFlight.UseVisualStyleBackColor = true;
            this.btRemoveFlight.Click += new System.EventHandler(this.btRemoveFlight_Click);
            // 
            // btUpdateFlight
            // 
            this.btUpdateFlight.Location = new System.Drawing.Point(597, 485);
            this.btUpdateFlight.Name = "btUpdateFlight";
            this.btUpdateFlight.Size = new System.Drawing.Size(205, 23);
            this.btUpdateFlight.TabIndex = 3;
            this.btUpdateFlight.Text = "Update";
            this.btUpdateFlight.UseVisualStyleBackColor = true;
            this.btUpdateFlight.Click += new System.EventHandler(this.btUpdateFlight_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btUpdateFlight);
            this.Controls.Add(this.btRemoveFlight);
            this.Controls.Add(this.btAddFlight);
            this.Controls.Add(this.dataGridFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridFlights;
        private Button btAddFlight;
        private Button btRemoveFlight;
        private Button btUpdateFlight;
    }
}