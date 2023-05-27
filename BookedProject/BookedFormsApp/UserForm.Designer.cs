namespace BookedFormsApp
{
	partial class UserForm
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
			btUserDetail = new Button();
			dataGridUser = new DataGridView();
			btRemoveUser = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
			SuspendLayout();
			// 
			// btUserDetail
			// 
			btUserDetail.Location = new Point(300, 482);
			btUserDetail.Name = "btUserDetail";
			btUserDetail.Size = new Size(205, 23);
			btUserDetail.TabIndex = 7;
			btUserDetail.Text = "Details";
			btUserDetail.UseVisualStyleBackColor = true;
			btUserDetail.Click += btUserDetail_Click;
			// 
			// dataGridUser
			// 
			dataGridUser.AllowUserToAddRows = false;
			dataGridUser.AllowUserToDeleteRows = false;
			dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridUser.Location = new Point(41, 27);
			dataGridUser.Margin = new Padding(3, 2, 3, 2);
			dataGridUser.Name = "dataGridUser";
			dataGridUser.ReadOnly = true;
			dataGridUser.RowHeadersWidth = 51;
			dataGridUser.RowTemplate.Height = 29;
			dataGridUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridUser.Size = new Size(938, 426);
			dataGridUser.TabIndex = 4;
			// 
			// btRemoveUser
			// 
			btRemoveUser.Location = new Point(41, 482);
			btRemoveUser.Name = "btRemoveUser";
			btRemoveUser.Size = new Size(205, 23);
			btRemoveUser.TabIndex = 6;
			btRemoveUser.Text = "Remove";
			btRemoveUser.UseVisualStyleBackColor = true;
			btRemoveUser.Click += btRemoveUser_Click;
			// 
			// UserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1020, 541);
			ControlBox = false;
			Controls.Add(dataGridUser);
			Controls.Add(btUserDetail);
			Controls.Add(btRemoveUser);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "UserForm";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btUserDetail;
		private DataGridView dataGridUser;
		private Button btRemoveUser;
	}
}