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
            btnCreateTrip = new Button();
            txtSeatsAvailable = new TextBox();
            dtTimePickerTripDate = new DateTimePicker();
            txtDestination = new TextBox();
            txtDeparture = new TextBox();
            lblMotivation = new Label();
            btnViewTripHistory = new Button();
            btnViewProfile = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnCreateTrip);
            panel1.Controls.Add(txtSeatsAvailable);
            panel1.Controls.Add(dtTimePickerTripDate);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(txtDeparture);
            panel1.Location = new Point(27, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 316);
            panel1.TabIndex = 0;
            // 
            // btnCreateTrip
            // 
            btnCreateTrip.BackColor = SystemColors.GradientActiveCaption;
            btnCreateTrip.Cursor = Cursors.Hand;
            btnCreateTrip.FlatStyle = FlatStyle.Popup;
            btnCreateTrip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCreateTrip.ForeColor = SystemColors.ButtonHighlight;
            btnCreateTrip.Location = new Point(19, 246);
            btnCreateTrip.Name = "btnCreateTrip";
            btnCreateTrip.Size = new Size(224, 52);
            btnCreateTrip.TabIndex = 6;
            btnCreateTrip.Text = "Опубліковати";
            btnCreateTrip.UseVisualStyleBackColor = false;
            // 
            // txtSeatsAvailable
            // 
            txtSeatsAvailable.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtSeatsAvailable.Location = new Point(19, 188);
            txtSeatsAvailable.Name = "txtSeatsAvailable";
            txtSeatsAvailable.Size = new Size(125, 31);
            txtSeatsAvailable.TabIndex = 5;
            txtSeatsAvailable.Text = "1 пасажир";
            // 
            // dtTimePickerTripDate
            // 
            dtTimePickerTripDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtTimePickerTripDate.Location = new Point(19, 143);
            dtTimePickerTripDate.Name = "dtTimePickerTripDate";
            dtTimePickerTripDate.Size = new Size(224, 27);
            dtTimePickerTripDate.TabIndex = 4;
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDestination.Location = new Point(19, 92);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(224, 31);
            txtDestination.TabIndex = 3;
            txtDestination.Text = "Куди?";
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDeparture.Location = new Point(19, 38);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(224, 31);
            txtDeparture.TabIndex = 2;
            txtDeparture.Text = "Звідки?";
            // 
            // lblMotivation
            // 
            lblMotivation.AutoSize = true;
            lblMotivation.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblMotivation.Location = new Point(84, 116);
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
            btnViewTripHistory.Location = new Point(589, 12);
            btnViewTripHistory.Name = "btnViewTripHistory";
            btnViewTripHistory.Size = new Size(231, 44);
            btnViewTripHistory.TabIndex = 2;
            btnViewTripHistory.Text = "Історія поїздок";
            btnViewTripHistory.UseVisualStyleBackColor = false;
            // 
            // btnViewProfile
            // 
            btnViewProfile.BackColor = SystemColors.ButtonShadow;
            btnViewProfile.Cursor = Cursors.Hand;
            btnViewProfile.FlatStyle = FlatStyle.Popup;
            btnViewProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewProfile.ForeColor = SystemColors.ButtonHighlight;
            btnViewProfile.Location = new Point(589, 68);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(231, 44);
            btnViewProfile.TabIndex = 6;
            btnViewProfile.Text = "Профіль";
            btnViewProfile.UseVisualStyleBackColor = false;
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
            // 
            // DriverMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 556);
            Controls.Add(btnExit);
            Controls.Add(btnViewProfile);
            Controls.Add(btnViewTripHistory);
            Controls.Add(lblMotivation);
            Controls.Add(panel1);
            Name = "DriverMainForm";
            Text = "Driver";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblMotivation;
        private TextBox txtDeparture;
        private TextBox txtDestination;
        private DateTimePicker dtTimePickerTripDate;
        private TextBox txtSeatsAvailable;
        private Button btnCreateTrip;
        private Button btnViewTripHistory;
        private Button btnViewProfile;
        private Button btnExit;
    }
}