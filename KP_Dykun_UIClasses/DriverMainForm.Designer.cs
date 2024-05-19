namespace KP_Dykun_UIClasses
{
    partial class DriverMainForm
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
            lblSeats = new Label();
            nmrcUpDownSeats = new NumericUpDown();
            btnCreateTrip = new Button();
            dtTimePickerTripDate = new DateTimePicker();
            txtDestination = new TextBox();
            txtDeparture = new TextBox();
            lblMotivation = new Label();
            btnViewTripHistory = new Button();
            btnViewProfile = new Button();
            btnExit = new Button();
            btnPlannedTrips = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownSeats).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(lblSeats);
            panel1.Controls.Add(nmrcUpDownSeats);
            panel1.Controls.Add(btnCreateTrip);
            panel1.Controls.Add(dtTimePickerTripDate);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(txtDeparture);
            panel1.Location = new Point(94, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 348);
            panel1.TabIndex = 0;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSeats.Location = new Point(19, 179);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(140, 25);
            lblSeats.TabIndex = 8;
            lblSeats.Text = "Кількість місць";
            // 
            // nmrcUpDownSeats
            // 
            nmrcUpDownSeats.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nmrcUpDownSeats.Location = new Point(19, 210);
            nmrcUpDownSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrcUpDownSeats.Name = "nmrcUpDownSeats";
            nmrcUpDownSeats.Size = new Size(150, 31);
            nmrcUpDownSeats.TabIndex = 9;
            nmrcUpDownSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCreateTrip
            // 
            btnCreateTrip.BackColor = SystemColors.GradientActiveCaption;
            btnCreateTrip.Cursor = Cursors.Hand;
            btnCreateTrip.FlatStyle = FlatStyle.Popup;
            btnCreateTrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateTrip.ForeColor = SystemColors.ButtonHighlight;
            btnCreateTrip.Location = new Point(19, 274);
            btnCreateTrip.Name = "btnCreateTrip";
            btnCreateTrip.Size = new Size(224, 52);
            btnCreateTrip.TabIndex = 6;
            btnCreateTrip.Text = "Опубліковати";
            btnCreateTrip.UseVisualStyleBackColor = false;
            btnCreateTrip.Click += btnCreateTrip_Click;
            // 
            // dtTimePickerTripDate
            // 
            dtTimePickerTripDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtTimePickerTripDate.Location = new Point(19, 122);
            dtTimePickerTripDate.Name = "dtTimePickerTripDate";
            dtTimePickerTripDate.Size = new Size(224, 27);
            dtTimePickerTripDate.TabIndex = 4;
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDestination.Location = new Point(19, 73);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(224, 31);
            txtDestination.TabIndex = 3;
            txtDestination.Text = "Куди?";
            txtDestination.Enter += txtDestination_Enter;
            txtDestination.Leave += txtDestination_Leave;
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDeparture.Location = new Point(19, 24);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(224, 31);
            txtDeparture.TabIndex = 2;
            txtDeparture.Text = "Звідки?";
            txtDeparture.Enter += txtDeparture_Enter;
            txtDeparture.Leave += txtDeparture_Leave;
            // 
            // lblMotivation
            // 
            lblMotivation.AutoSize = true;
            lblMotivation.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblMotivation.Location = new Point(81, 96);
            lblMotivation.Name = "lblMotivation";
            lblMotivation.Size = new Size(522, 76);
            lblMotivation.TabIndex = 1;
            lblMotivation.Text = "Ставайте водієм і заощаджуйте\r\nна пальному, запрошуючи пасажирів";
            lblMotivation.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnViewTripHistory
            // 
            btnViewTripHistory.BackColor = SystemColors.ButtonShadow;
            btnViewTripHistory.Cursor = Cursors.Hand;
            btnViewTripHistory.FlatStyle = FlatStyle.Popup;
            btnViewTripHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewTripHistory.ForeColor = SystemColors.ButtonHighlight;
            btnViewTripHistory.Location = new Point(688, 12);
            btnViewTripHistory.Name = "btnViewTripHistory";
            btnViewTripHistory.Size = new Size(231, 44);
            btnViewTripHistory.TabIndex = 2;
            btnViewTripHistory.Text = "Історія поїздок";
            btnViewTripHistory.UseVisualStyleBackColor = false;
            btnViewTripHistory.Click += btnViewTripHistory_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = SystemColors.ButtonShadow;
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatStyle = FlatStyle.Popup;
            btnViewProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewProfile.ForeColor = SystemColors.ButtonHighlight;
            btnViewProfile.Location = new Point(688, 68);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(231, 44);
            btnViewProfile.TabIndex = 6;
            btnViewProfile.Text = "Профіль";
            btnViewProfile.UseVisualStyleBackColor = false;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MistyRose;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 52);
            btnExit.TabIndex = 7;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlannedTrips
            // 
            btnPlannedTrips.BackColor = SystemColors.ButtonShadow;
            btnPlannedTrips.Cursor = Cursors.Hand;
            btnPlannedTrips.FlatStyle = FlatStyle.Popup;
            btnPlannedTrips.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlannedTrips.ForeColor = SystemColors.ButtonHighlight;
            btnPlannedTrips.Location = new Point(319, 13);
            btnPlannedTrips.Name = "btnPlannedTrips";
            btnPlannedTrips.Size = new Size(237, 49);
            btnPlannedTrips.TabIndex = 8;
            btnPlannedTrips.Text = "Заплановані поїздки";
            btnPlannedTrips.UseVisualStyleBackColor = false;
            btnPlannedTrips.Click += btnPlannedTrips_Click;
            // 
            // DriverMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 556);
            Controls.Add(btnPlannedTrips);
            Controls.Add(btnExit);
            Controls.Add(btnViewProfile);
            Controls.Add(btnViewTripHistory);
            Controls.Add(lblMotivation);
            Controls.Add(panel1);
            Name = "DriverMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driver";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownSeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblMotivation;
        private TextBox txtDeparture;
        private TextBox txtDestination;
        private DateTimePicker dtTimePickerTripDate;
        private Button btnCreateTrip;
        private Button btnViewTripHistory;
        private Button btnViewProfile;
        private Button btnExit;
        private NumericUpDown nmrcUpDownSeats;
        private Label lblSeats;
        private Button btnPlannedTrips;
    }
}