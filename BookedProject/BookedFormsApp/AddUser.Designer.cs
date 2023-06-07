namespace BookedFormsApp
{
    partial class AddUser
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
            tabPage1 = new TabPage();
            label19 = new Label();
            passwordTbx = new TextBox();
            groupBox1 = new GroupBox();
            phoneNumbertbx = new TextBox();
            label9 = new Label();
            label10 = new Label();
            emailtbx = new TextBox();
            label2 = new Label();
            firstNametbx = new TextBox();
            lastNametbx = new TextBox();
            label1 = new Label();
            label16 = new Label();
            DOBdtp = new DateTimePicker();
            tabControl1 = new TabControl();
            btAddAdmin = new Button();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btAddAdmin);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(passwordTbx);
            tabPage1.Controls.Add(label19);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(714, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Admin information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 317);
            label19.Name = "label19";
            label19.Size = new Size(73, 20);
            label19.TabIndex = 38;
            label19.Text = "Password:";
            // 
            // passwordTbx
            // 
            passwordTbx.Location = new Point(145, 311);
            passwordTbx.Name = "passwordTbx";
            passwordTbx.Size = new Size(125, 27);
            passwordTbx.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DOBdtp);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lastNametbx);
            groupBox1.Controls.Add(firstNametbx);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(emailtbx);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(phoneNumbertbx);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 288);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employees's Basic Information";
            // 
            // phoneNumbertbx
            // 
            phoneNumbertbx.Location = new Point(137, 190);
            phoneNumbertbx.Name = "phoneNumbertbx";
            phoneNumbertbx.Size = new Size(190, 27);
            phoneNumbertbx.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(353, 48);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 17;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 193);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 19;
            label10.Text = "Phone number:";
            // 
            // emailtbx
            // 
            emailtbx.Location = new Point(429, 48);
            emailtbx.Name = "emailtbx";
            emailtbx.Size = new Size(262, 27);
            emailtbx.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Last name:";
            // 
            // firstNametbx
            // 
            firstNametbx.Location = new Point(136, 47);
            firstNametbx.Name = "firstNametbx";
            firstNametbx.Size = new Size(125, 27);
            firstNametbx.TabIndex = 1;
            // 
            // lastNametbx
            // 
            lastNametbx.Location = new Point(136, 95);
            lastNametbx.Name = "lastNametbx";
            lastNametbx.Size = new Size(125, 27);
            lastNametbx.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 51);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "First name:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 144);
            label16.Name = "label16";
            label16.Size = new Size(97, 20);
            label16.TabIndex = 32;
            label16.Text = "Date of Birth:";
            // 
            // DOBdtp
            // 
            DOBdtp.Location = new Point(136, 144);
            DOBdtp.Name = "DOBdtp";
            DOBdtp.Size = new Size(250, 27);
            DOBdtp.TabIndex = 33;
            DOBdtp.Value = new DateTime(2023, 6, 7, 10, 40, 5, 0);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(22, 13);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(722, 483);
            tabControl1.TabIndex = 40;
            // 
            // btAddAdmin
            // 
            btAddAdmin.Location = new Point(300, 391);
            btAddAdmin.Name = "btAddAdmin";
            btAddAdmin.Size = new Size(94, 29);
            btAddAdmin.TabIndex = 39;
            btAddAdmin.Text = "Add Admin";
            btAddAdmin.UseVisualStyleBackColor = true;
            btAddAdmin.Click += btAddAdmin_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 535);
            Controls.Add(tabControl1);
            Name = "AddUser";
            Text = "AddUser";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Button btAddAdmin;
        private GroupBox groupBox1;
        private DateTimePicker DOBdtp;
        private Label label16;
        private Label label1;
        private TextBox lastNametbx;
        private TextBox firstNametbx;
        private Label label2;
        private TextBox emailtbx;
        private Label label10;
        private Label label9;
        private TextBox phoneNumbertbx;
        private TextBox passwordTbx;
        private Label label19;
        private TabControl tabControl1;
    }
}