namespace KP_Dykun_UIClasses
{
    partial class CompanionMainForm
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
            btnViewTripHistory = new Button();
            txtDeparture = new TextBox();
            txtDestination = new TextBox();
            panel1 = new Panel();
            btnSearchTrips = new Button();
            txtNumberOfSeats = new TextBox();
            dtTimePickerDate = new DateTimePicker();
            btnExit = new Button();
            btnViewProfile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewTripHistory
            // 
            btnViewTripHistory.BackColor = SystemColors.ButtonShadow;
            btnViewTripHistory.Cursor = Cursors.Hand;
            btnViewTripHistory.FlatStyle = FlatStyle.Popup;
            btnViewTripHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewTripHistory.ForeColor = SystemColors.ButtonHighlight;
            btnViewTripHistory.Location = new Point(781, 12);
            btnViewTripHistory.Name = "btnViewTripHistory";
            btnViewTripHistory.Size = new Size(231, 44);
            btnViewTripHistory.TabIndex = 0;
            btnViewTripHistory.Text = "Історія поїздок";
            btnViewTripHistory.UseVisualStyleBackColor = false;
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDeparture.Location = new Point(62, 292);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(224, 31);
            txtDeparture.TabIndex = 1;
            txtDeparture.Text = "Звідки?";
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDestination.Location = new Point(284, 49);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(217, 31);
            txtDestination.TabIndex = 2;
            txtDestination.Text = "Куди?";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnSearchTrips);
            panel1.Controls.Add(txtNumberOfSeats);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(dtTimePickerDate);
            panel1.Location = new Point(30, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 130);
            panel1.TabIndex = 3;
            // 
            // btnSearchTrips
            // 
            btnSearchTrips.BackColor = SystemColors.GradientActiveCaption;
            btnSearchTrips.Cursor = Cursors.Hand;
            btnSearchTrips.FlatStyle = FlatStyle.Popup;
            btnSearchTrips.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSearchTrips.ForeColor = SystemColors.ButtonHighlight;
            btnSearchTrips.Location = new Point(851, 38);
            btnSearchTrips.Name = "btnSearchTrips";
            btnSearchTrips.Size = new Size(107, 52);
            btnSearchTrips.TabIndex = 4;
            btnSearchTrips.Text = "Шукати";
            btnSearchTrips.UseVisualStyleBackColor = false;
            // 
            // txtNumberOfSeats
            // 
            txtNumberOfSeats.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtNumberOfSeats.Location = new Point(736, 47);
            txtNumberOfSeats.Name = "txtNumberOfSeats";
            txtNumberOfSeats.Size = new Size(72, 31);
            txtNumberOfSeats.TabIndex = 3;
            txtNumberOfSeats.Text = "1";
            // 
            // dtTimePickerDate
            // 
            dtTimePickerDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtTimePickerDate.Location = new Point(524, 51);
            dtTimePickerDate.Name = "dtTimePickerDate";
            dtTimePickerDate.Size = new Size(193, 27);
            dtTimePickerDate.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MistyRose;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnExit.Location = new Point(30, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = SystemColors.ButtonShadow;
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatStyle = FlatStyle.Popup;
            btnViewProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewProfile.ForeColor = SystemColors.ButtonHighlight;
            btnViewProfile.Location = new Point(781, 91);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(231, 44);
            btnViewProfile.TabIndex = 5;
            btnViewProfile.Text = "Профіль";
            btnViewProfile.UseVisualStyleBackColor = false;
            // 
            // CompanionMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1042, 524);
            Controls.Add(btnViewProfile);
            Controls.Add(btnExit);
            Controls.Add(txtDeparture);
            Controls.Add(btnViewTripHistory);
            Controls.Add(panel1);
            Name = "CompanionMainForm";
            Text = "Companion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewTripHistory;
        private TextBox txtDeparture;
        private TextBox txtDestination;
        private Panel panel1;
        private DateTimePicker dtTimePickerDate;
        private Button btnSearchTrips;
        private TextBox txtNumberOfSeats;
        private Button btnExit;
        private Button btnViewProfile;
    }
}