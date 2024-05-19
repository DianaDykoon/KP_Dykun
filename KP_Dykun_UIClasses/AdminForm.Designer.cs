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
            listDrivers = new ListBox();
            listTrips = new ListBox();
            lblDrivers = new Label();
            lblTrips = new Label();
            btnDeleteDriver = new Button();
            btnDeleteTrip = new Button();
            btnDeleteCompanion = new Button();
            lblCompanions = new Label();
            listCompanions = new ListBox();
            SuspendLayout();
            // 
            // listDrivers
            // 
            listDrivers.FormattingEnabled = true;
            listDrivers.HorizontalScrollbar = true;
            listDrivers.Location = new Point(12, 94);
            listDrivers.Name = "listDrivers";
            listDrivers.Size = new Size(229, 264);
            listDrivers.TabIndex = 0;
            listDrivers.SelectedIndexChanged += listDrivers_SelectedIndexChanged;
            // 
            // listTrips
            // 
            listTrips.FormattingEnabled = true;
            listTrips.HorizontalScrollbar = true;
            listTrips.Location = new Point(624, 94);
            listTrips.Name = "listTrips";
            listTrips.Size = new Size(366, 264);
            listTrips.TabIndex = 1;
            listTrips.SelectedIndexChanged += listTrips_SelectedIndexChanged;
            // 
            // lblDrivers
            // 
            lblDrivers.AutoSize = true;
            lblDrivers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDrivers.Location = new Point(12, 55);
            lblDrivers.Name = "lblDrivers";
            lblDrivers.Size = new Size(63, 28);
            lblDrivers.TabIndex = 2;
            lblDrivers.Text = "Водії:";
            // 
            // lblTrips
            // 
            lblTrips.AutoSize = true;
            lblTrips.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTrips.Location = new Point(624, 55);
            lblTrips.Name = "lblTrips";
            lblTrips.Size = new Size(93, 28);
            lblTrips.TabIndex = 3;
            lblTrips.Text = "Поїздки:";
            // 
            // btnDeleteDriver
            // 
            btnDeleteDriver.BackColor = SystemColors.ControlDark;
            btnDeleteDriver.Cursor = Cursors.Hand;
            btnDeleteDriver.FlatStyle = FlatStyle.Popup;
            btnDeleteDriver.Font = new Font("Segoe UI", 10.8F);
            btnDeleteDriver.ForeColor = SystemColors.ButtonFace;
            btnDeleteDriver.Location = new Point(61, 364);
            btnDeleteDriver.Name = "btnDeleteDriver";
            btnDeleteDriver.Size = new Size(125, 54);
            btnDeleteDriver.TabIndex = 4;
            btnDeleteDriver.Text = "Заблокувати";
            btnDeleteDriver.UseVisualStyleBackColor = false;
            btnDeleteDriver.Click += btnDeleteDriver_Click;
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = SystemColors.ControlDark;
            btnDeleteTrip.Cursor = Cursors.Hand;
            btnDeleteTrip.FlatStyle = FlatStyle.Popup;
            btnDeleteTrip.Font = new Font("Segoe UI", 10.8F);
            btnDeleteTrip.ForeColor = SystemColors.ButtonFace;
            btnDeleteTrip.Location = new Point(739, 364);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(125, 54);
            btnDeleteTrip.TabIndex = 5;
            btnDeleteTrip.Text = "Видалити";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            btnDeleteTrip.Click += btnDeleteTrip_Click;
            // 
            // btnDeleteCompanion
            // 
            btnDeleteCompanion.BackColor = SystemColors.ControlDark;
            btnDeleteCompanion.Cursor = Cursors.Hand;
            btnDeleteCompanion.FlatStyle = FlatStyle.Popup;
            btnDeleteCompanion.Font = new Font("Segoe UI", 10.8F);
            btnDeleteCompanion.ForeColor = SystemColors.ButtonFace;
            btnDeleteCompanion.Location = new Point(369, 364);
            btnDeleteCompanion.Name = "btnDeleteCompanion";
            btnDeleteCompanion.Size = new Size(125, 54);
            btnDeleteCompanion.TabIndex = 8;
            btnDeleteCompanion.Text = "Заблокувати";
            btnDeleteCompanion.UseVisualStyleBackColor = false;
            btnDeleteCompanion.Click += btnDeleteCompanion_Click;
            // 
            // lblCompanions
            // 
            lblCompanions.AutoSize = true;
            lblCompanions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCompanions.Location = new Point(317, 55);
            lblCompanions.Name = "lblCompanions";
            lblCompanions.Size = new Size(122, 28);
            lblCompanions.TabIndex = 7;
            lblCompanions.Text = "Попутники:";
            // 
            // listCompanions
            // 
            listCompanions.FormattingEnabled = true;
            listCompanions.HorizontalScrollbar = true;
            listCompanions.Location = new Point(317, 94);
            listCompanions.Name = "listCompanions";
            listCompanions.Size = new Size(229, 264);
            listCompanions.TabIndex = 6;
            listCompanions.SelectedIndexChanged += listCompanions_SelectedIndexChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 471);
            Controls.Add(btnDeleteCompanion);
            Controls.Add(lblCompanions);
            Controls.Add(listCompanions);
            Controls.Add(btnDeleteTrip);
            Controls.Add(btnDeleteDriver);
            Controls.Add(lblTrips);
            Controls.Add(lblDrivers);
            Controls.Add(listTrips);
            Controls.Add(listDrivers);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listDrivers;
        private ListBox listTrips;
        private Label lblDrivers;
        private Label lblTrips;
        private Button btnDeleteDriver;
        private Button btnDeleteTrip;
        private Button btnDeleteCompanion;
        private Label lblCompanions;
        private ListBox listCompanions;
    }
}
