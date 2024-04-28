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
            lblSeats = new Label();
            nmrcUpDownSeats = new NumericUpDown();
            btnSearchTrips = new Button();
            dtTimePickerDate = new DateTimePicker();
            btnExit = new Button();
            btnViewProfile = new Button();
            listFoundTrips = new ListBox();
            lstBoxHeaders = new ListBox();
            btnBookPlace = new Button();
            btnPlannedTrips = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownSeats).BeginInit();
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
            btnViewTripHistory.Click += btnViewTripHistory_Click;
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDeparture.Location = new Point(20, 49);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(204, 31);
            txtDeparture.TabIndex = 1;
            txtDeparture.Text = "Звідки?";
            txtDeparture.Enter += txtDeparture_Enter;
            txtDeparture.Leave += txtDeparture_Leave;
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtDestination.Location = new Point(249, 49);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(190, 31);
            txtDestination.TabIndex = 2;
            txtDestination.Text = "Куди?";
            txtDestination.Enter += txtDestination_Enter;
            txtDestination.Leave += txtDestination_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(lblSeats);
            panel1.Controls.Add(nmrcUpDownSeats);
            panel1.Controls.Add(btnSearchTrips);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(txtDeparture);
            panel1.Controls.Add(dtTimePickerDate);
            panel1.Location = new Point(30, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 130);
            panel1.TabIndex = 3;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSeats.Location = new Point(676, 22);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(140, 25);
            lblSeats.TabIndex = 11;
            lblSeats.Text = "Кількість місць";
            // 
            // nmrcUpDownSeats
            // 
            nmrcUpDownSeats.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nmrcUpDownSeats.Location = new Point(676, 50);
            nmrcUpDownSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrcUpDownSeats.Name = "nmrcUpDownSeats";
            nmrcUpDownSeats.Size = new Size(157, 31);
            nmrcUpDownSeats.TabIndex = 10;
            nmrcUpDownSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            btnSearchTrips.Click += btnSearchTrips_Click;
            // 
            // dtTimePickerDate
            // 
            dtTimePickerDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            dtTimePickerDate.Location = new Point(463, 51);
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
            btnExit.Click += btnExit_Click;
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
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // listFoundTrips
            // 
            listFoundTrips.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listFoundTrips.FormattingEnabled = true;
            listFoundTrips.ItemHeight = 23;
            listFoundTrips.Location = new Point(30, 351);
            listFoundTrips.Name = "listFoundTrips";
            listFoundTrips.Size = new Size(506, 188);
            listFoundTrips.TabIndex = 8;
            listFoundTrips.Visible = false;
            // 
            // lstBoxHeaders
            // 
            lstBoxHeaders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lstBoxHeaders.FormattingEnabled = true;
            lstBoxHeaders.Items.AddRange(new object[] { "№ | Водій |  Дата | Відправка |  Призначення |  Місця" });
            lstBoxHeaders.Location = new Point(30, 321);
            lstBoxHeaders.Name = "lstBoxHeaders";
            lstBoxHeaders.SelectionMode = SelectionMode.None;
            lstBoxHeaders.Size = new Size(506, 24);
            lstBoxHeaders.TabIndex = 9;
            lstBoxHeaders.Visible = false;
            // 
            // btnBookPlace
            // 
            btnBookPlace.BackColor = SystemColors.GradientActiveCaption;
            btnBookPlace.Cursor = Cursors.Hand;
            btnBookPlace.FlatStyle = FlatStyle.Popup;
            btnBookPlace.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBookPlace.ForeColor = SystemColors.ButtonHighlight;
            btnBookPlace.Location = new Point(565, 351);
            btnBookPlace.Name = "btnBookPlace";
            btnBookPlace.Size = new Size(180, 77);
            btnBookPlace.TabIndex = 10;
            btnBookPlace.Text = "Забронювати місце";
            btnBookPlace.UseVisualStyleBackColor = false;
            btnBookPlace.Visible = false;
            btnBookPlace.Click += btnBookPlace_Click;
            // 
            // btnPlannedTrips
            // 
            btnPlannedTrips.BackColor = SystemColors.ButtonShadow;
            btnPlannedTrips.Cursor = Cursors.Hand;
            btnPlannedTrips.FlatStyle = FlatStyle.Popup;
            btnPlannedTrips.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlannedTrips.ForeColor = SystemColors.ButtonHighlight;
            btnPlannedTrips.Location = new Point(370, 12);
            btnPlannedTrips.Name = "btnPlannedTrips";
            btnPlannedTrips.Size = new Size(237, 49);
            btnPlannedTrips.TabIndex = 11;
            btnPlannedTrips.Text = "Заплановані поїздки";
            btnPlannedTrips.UseVisualStyleBackColor = false;
            btnPlannedTrips.Click += btnPlannedTrips_Click;
            // 
            // CompanionMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1042, 576);
            Controls.Add(btnPlannedTrips);
            Controls.Add(btnBookPlace);
            Controls.Add(lstBoxHeaders);
            Controls.Add(listFoundTrips);
            Controls.Add(btnViewProfile);
            Controls.Add(btnExit);
            Controls.Add(btnViewTripHistory);
            Controls.Add(panel1);
            Name = "CompanionMainForm";
            Text = "Companion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownSeats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewTripHistory;
        private TextBox txtDeparture;
        private TextBox txtDestination;
        private Panel panel1;
        private DateTimePicker dtTimePickerDate;
        private Button btnSearchTrips;
        private Button btnExit;
        private Button btnViewProfile;
        private ListBox listFoundTrips;
        private NumericUpDown nmrcUpDownSeats;
        private Label lblSeats;
        private ListBox lstBoxHeaders;
        private Button btnBookPlace;
        private Button btnPlannedTrips;
    }
}