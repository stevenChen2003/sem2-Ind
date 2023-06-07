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
            panel1 = new Panel();
            btBooking = new Button();
            btUser = new Button();
            btFlight = new Button();
            btHotel = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 39, 48);
            panel1.Controls.Add(btBooking);
            panel1.Controls.Add(btUser);
            panel1.Controls.Add(btFlight);
            panel1.Controls.Add(btHotel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 835);
            panel1.TabIndex = 0;
            // 
            // btBooking
            // 
            btBooking.FlatStyle = FlatStyle.Flat;
            btBooking.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btBooking.ForeColor = Color.FromArgb(246, 197, 28);
            btBooking.Location = new Point(3, 323);
            btBooking.Margin = new Padding(3, 4, 3, 4);
            btBooking.Name = "btBooking";
            btBooking.RightToLeft = RightToLeft.No;
            btBooking.Size = new Size(158, 52);
            btBooking.TabIndex = 3;
            btBooking.Text = "Booking";
            btBooking.UseVisualStyleBackColor = true;
            btBooking.Visible = false;
            btBooking.Click += btBooking_Click;
            // 
            // btUser
            // 
            btUser.FlatStyle = FlatStyle.Flat;
            btUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btUser.ForeColor = Color.FromArgb(246, 197, 28);
            btUser.Location = new Point(3, 263);
            btUser.Margin = new Padding(3, 4, 3, 4);
            btUser.Name = "btUser";
            btUser.RightToLeft = RightToLeft.No;
            btUser.Size = new Size(158, 52);
            btUser.TabIndex = 2;
            btUser.Text = "User";
            btUser.UseVisualStyleBackColor = true;
            btUser.Click += btUser_Click;
            // 
            // btFlight
            // 
            btFlight.FlatStyle = FlatStyle.Flat;
            btFlight.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btFlight.ForeColor = Color.FromArgb(246, 197, 28);
            btFlight.Location = new Point(3, 203);
            btFlight.Margin = new Padding(3, 4, 3, 4);
            btFlight.Name = "btFlight";
            btFlight.RightToLeft = RightToLeft.No;
            btFlight.Size = new Size(158, 52);
            btFlight.TabIndex = 1;
            btFlight.Text = "Flight";
            btFlight.UseVisualStyleBackColor = true;
            btFlight.Click += btFlight_Click;
            // 
            // btHotel
            // 
            btHotel.FlatStyle = FlatStyle.Flat;
            btHotel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btHotel.ForeColor = Color.FromArgb(246, 197, 28);
            btHotel.Location = new Point(3, 143);
            btHotel.Margin = new Padding(3, 4, 3, 4);
            btHotel.Name = "btHotel";
            btHotel.RightToLeft = RightToLeft.No;
            btHotel.Size = new Size(158, 52);
            btHotel.TabIndex = 0;
            btHotel.Text = "Hotel";
            btHotel.UseVisualStyleBackColor = true;
            btHotel.Click += btHotel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JustLogo3;
            pictureBox1.Location = new Point(14, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 197, 28);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(161, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1234, 28);
            panel2.TabIndex = 1;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(161, 28);
            pnContent.Margin = new Padding(3, 4, 3, 4);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1234, 807);
            pnContent.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 835);
            Controls.Add(pnContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeForm";
            Text = "HomeForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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