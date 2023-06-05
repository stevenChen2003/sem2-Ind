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
            buttonAddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            SuspendLayout();
            // 
            // btUserDetail
            // 
            btUserDetail.Location = new Point(687, 641);
            btUserDetail.Margin = new Padding(3, 4, 3, 4);
            btUserDetail.Name = "btUserDetail";
            btUserDetail.Size = new Size(234, 31);
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
            dataGridUser.Location = new Point(47, 36);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.RowTemplate.Height = 29;
            dataGridUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUser.Size = new Size(1072, 568);
            dataGridUser.TabIndex = 4;
            // 
            // btRemoveUser
            // 
            btRemoveUser.Location = new Point(391, 641);
            btRemoveUser.Margin = new Padding(3, 4, 3, 4);
            btRemoveUser.Name = "btRemoveUser";
            btRemoveUser.Size = new Size(234, 31);
            btRemoveUser.TabIndex = 6;
            btRemoveUser.Text = "Remove";
            btRemoveUser.UseVisualStyleBackColor = true;
            btRemoveUser.Click += btRemoveUser_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(100, 641);
            buttonAddUser.Margin = new Padding(3, 4, 3, 4);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(234, 31);
            buttonAddUser.TabIndex = 8;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 721);
            ControlBox = false;
            Controls.Add(buttonAddUser);
            Controls.Add(dataGridUser);
            Controls.Add(btUserDetail);
            Controls.Add(btRemoveUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btUserDetail;
        private DataGridView dataGridUser;
        private Button btRemoveUser;
        private Button buttonAddUser;
    }
}