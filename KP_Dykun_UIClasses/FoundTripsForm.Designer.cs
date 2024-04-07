namespace KP_Dykun_UIClasses
{
    partial class FoundTrips
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
            txtDeparture = new TextBox();
            panel1 = new Panel();
            txtSeats = new TextBox();
            txtDestination = new TextBox();
            dtTimePickerTripDate = new DateTimePicker();
            btnViewTripHistory = new Button();
            listFoundTrips = new ListBox();
            btnReturnToMainForm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDeparture.Location = new Point(122, 135);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(224, 31);
            txtDeparture.TabIndex = 4;
            txtDeparture.Text = "Звідки?";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(txtSeats);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(dtTimePickerTripDate);
            panel1.Location = new Point(86, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 130);
            panel1.TabIndex = 5;
            // 
            // txtSeats
            // 
            txtSeats.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtSeats.Location = new Point(736, 47);
            txtSeats.Name = "txtSeats";
            txtSeats.Size = new Size(72, 31);
            txtSeats.TabIndex = 3;
            txtSeats.Text = "1";
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
            // dtTimePickerTripDate
            // 
            dtTimePickerTripDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtTimePickerTripDate.Location = new Point(524, 50);
            dtTimePickerTripDate.Name = "dtTimePickerTripDate";
            dtTimePickerTripDate.Size = new Size(193, 27);
            dtTimePickerTripDate.TabIndex = 0;
            // 
            // btnViewTripHistory
            // 
            btnViewTripHistory.BackColor = SystemColors.ButtonShadow;
            btnViewTripHistory.Cursor = Cursors.Hand;
            btnViewTripHistory.FlatStyle = FlatStyle.Popup;
            btnViewTripHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewTripHistory.ForeColor = SystemColors.ButtonHighlight;
            btnViewTripHistory.Location = new Point(787, 12);
            btnViewTripHistory.Name = "btnViewTripHistory";
            btnViewTripHistory.Size = new Size(231, 44);
            btnViewTripHistory.TabIndex = 6;
            btnViewTripHistory.Text = "Історія поїздок";
            btnViewTripHistory.UseVisualStyleBackColor = false;
            // 
            // listFoundTrips
            // 
            listFoundTrips.FormattingEnabled = true;
            listFoundTrips.Location = new Point(86, 320);
            listFoundTrips.Name = "listFoundTrips";
            listFoundTrips.Size = new Size(839, 224);
            listFoundTrips.TabIndex = 7;
            // 
            // btnReturnToMainForm
            // 
            btnReturnToMainForm.BackColor = SystemColors.GradientActiveCaption;
            btnReturnToMainForm.Cursor = Cursors.Hand;
            btnReturnToMainForm.FlatStyle = FlatStyle.Popup;
            btnReturnToMainForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReturnToMainForm.ForeColor = SystemColors.ButtonHighlight;
            btnReturnToMainForm.Location = new Point(12, 12);
            btnReturnToMainForm.Name = "btnReturnToMainForm";
            btnReturnToMainForm.Size = new Size(160, 44);
            btnReturnToMainForm.TabIndex = 8;
            btnReturnToMainForm.Text = "На головну";
            btnReturnToMainForm.UseVisualStyleBackColor = false;
            // 
            // FoundTrips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 567);
            Controls.Add(btnReturnToMainForm);
            Controls.Add(listFoundTrips);
            Controls.Add(btnViewTripHistory);
            Controls.Add(txtDeparture);
            Controls.Add(panel1);
            Name = "FoundTrips";
            Text = "FoundTrips";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeparture;
        private Panel panel1;
        private TextBox txtSeats;
        private TextBox txtDestination;
        private DateTimePicker dtTimePickerTripDate;
        private Button btnViewTripHistory;
        private ListBox listFoundTrips;
        private Button btnReturnToMainForm;
    }
}