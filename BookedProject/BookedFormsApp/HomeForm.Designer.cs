namespace BookedFormsApp
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUser = new System.Windows.Forms.Button();
            this.btFlight = new System.Windows.Forms.Button();
            this.btHotel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.btBooking = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btBooking);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btFlight);
            this.panel1.Controls.Add(this.btHotel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 835);
            this.panel1.TabIndex = 0;
            // 
            // btUser
            // 
            this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(197)))), ((int)(((byte)(28)))));
            this.btUser.Location = new System.Drawing.Point(3, 263);
            this.btUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUser.Name = "btUser";
            this.btUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btUser.Size = new System.Drawing.Size(158, 52);
            this.btUser.TabIndex = 2;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // btFlight
            // 
            this.btFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFlight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(197)))), ((int)(((byte)(28)))));
            this.btFlight.Location = new System.Drawing.Point(3, 203);
            this.btFlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFlight.Name = "btFlight";
            this.btFlight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btFlight.Size = new System.Drawing.Size(158, 52);
            this.btFlight.TabIndex = 1;
            this.btFlight.Text = "Flight";
            this.btFlight.UseVisualStyleBackColor = true;
            this.btFlight.Click += new System.EventHandler(this.btFlight_Click);
            // 
            // btHotel
            // 
            this.btHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHotel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(197)))), ((int)(((byte)(28)))));
            this.btHotel.Location = new System.Drawing.Point(3, 143);
            this.btHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHotel.Name = "btHotel";
            this.btHotel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btHotel.Size = new System.Drawing.Size(158, 52);
            this.btHotel.TabIndex = 0;
            this.btHotel.Text = "Hotel";
            this.btHotel.UseVisualStyleBackColor = true;
            this.btHotel.Click += new System.EventHandler(this.btHotel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookedFormsApp.Properties.Resources.JustLogo3;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(197)))), ((int)(((byte)(28)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(161, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 28);
            this.panel2.TabIndex = 1;
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(161, 28);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1234, 807);
            this.pnContent.TabIndex = 2;
            // 
            // btBooking
            // 
            this.btBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBooking.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(197)))), ((int)(((byte)(28)))));
            this.btBooking.Location = new System.Drawing.Point(3, 323);
            this.btBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBooking.Name = "btBooking";
            this.btBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBooking.Size = new System.Drawing.Size(158, 52);
            this.btBooking.TabIndex = 3;
            this.btBooking.Text = "Booking";
            this.btBooking.UseVisualStyleBackColor = true;
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 835);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnContent;
        private PictureBox pictureBox1;
        private Button btUser;
        private Button btFlight;
        private Button btHotel;
        private Button btBooking;
    }
}