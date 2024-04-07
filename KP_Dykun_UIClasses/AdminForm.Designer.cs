namespace KP_Dykun_UIClasses
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listUsers = new ListBox();
            listTrips = new ListBox();
            lblUsers = new Label();
            lblTrips = new Label();
            btnDeleteUser = new Button();
            btnDeleteTrip = new Button();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.Location = new Point(12, 94);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(229, 344);
            listUsers.TabIndex = 0;
            // 
            // listTrips
            // 
            listTrips.FormattingEnabled = true;
            listTrips.Location = new Point(448, 94);
            listTrips.Name = "listTrips";
            listTrips.Size = new Size(366, 344);
            listTrips.TabIndex = 1;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsers.Location = new Point(12, 55);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(131, 28);
            lblUsers.TabIndex = 2;
            lblUsers.Text = "Користувачі:";
            // 
            // lblTrips
            // 
            lblTrips.AutoSize = true;
            lblTrips.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTrips.Location = new Point(448, 55);
            lblTrips.Name = "lblTrips";
            lblTrips.Size = new Size(93, 28);
            lblTrips.TabIndex = 3;
            lblTrips.Text = "Поїздки:";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = SystemColors.ControlDark;
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.FlatStyle = FlatStyle.Popup;
            btnDeleteUser.Font = new Font("Segoe UI", 10.8F);
            btnDeleteUser.ForeColor = SystemColors.ButtonFace;
            btnDeleteUser.Location = new Point(247, 169);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(125, 54);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Заблокувати";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = SystemColors.ControlDark;
            btnDeleteTrip.Cursor = Cursors.Hand;
            btnDeleteTrip.FlatStyle = FlatStyle.Popup;
            btnDeleteTrip.Font = new Font("Segoe UI", 10.8F);
            btnDeleteTrip.ForeColor = SystemColors.ButtonFace;
            btnDeleteTrip.Location = new Point(820, 169);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(125, 54);
            btnDeleteTrip.TabIndex = 5;
            btnDeleteTrip.Text = "Видалити";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 471);
            Controls.Add(btnDeleteTrip);
            Controls.Add(btnDeleteUser);
            Controls.Add(lblTrips);
            Controls.Add(lblUsers);
            Controls.Add(listTrips);
            Controls.Add(listUsers);
            Name = "AdminForm";
            Text = "Administrator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listUsers;
        private ListBox listTrips;
        private Label lblUsers;
        private Label lblTrips;
        private Button btnDeleteUser;
        private Button btnDeleteTrip;
    }
}
