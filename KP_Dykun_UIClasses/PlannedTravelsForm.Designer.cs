namespace KP_Dykun_UIClasses
{
    partial class PlannedTravelsForm
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
            btnShowCompanions = new Button();
            listCompanions = new ListBox();
            btnReturnToMainForm = new Button();
            lblTripPlanned = new Label();
            listTripsPlanned = new ListBox();
            lstBoxHeaders = new ListBox();
            listCompanionsInfo = new ListBox();
            SuspendLayout();
            // 
            // btnShowCompanions
            // 
            btnShowCompanions.BackColor = SystemColors.ControlDark;
            btnShowCompanions.Cursor = Cursors.Hand;
            btnShowCompanions.FlatStyle = FlatStyle.Popup;
            btnShowCompanions.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowCompanions.ForeColor = SystemColors.ButtonHighlight;
            btnShowCompanions.Location = new Point(529, 226);
            btnShowCompanions.Name = "btnShowCompanions";
            btnShowCompanions.Size = new Size(149, 81);
            btnShowCompanions.TabIndex = 16;
            btnShowCompanions.Text = "Показати\r\nПопутників";
            btnShowCompanions.UseVisualStyleBackColor = false;
            btnShowCompanions.Click += btnShowCompanions_Click;
            // 
            // listCompanions
            // 
            listCompanions.FormattingEnabled = true;
            listCompanions.HorizontalScrollbar = true;
            listCompanions.Location = new Point(705, 226);
            listCompanions.Name = "listCompanions";
            listCompanions.Size = new Size(301, 224);
            listCompanions.TabIndex = 15;
            listCompanions.Visible = false;
            // 
            // btnReturnToMainForm
            // 
            btnReturnToMainForm.BackColor = SystemColors.GradientActiveCaption;
            btnReturnToMainForm.Cursor = Cursors.Hand;
            btnReturnToMainForm.FlatStyle = FlatStyle.Popup;
            btnReturnToMainForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReturnToMainForm.ForeColor = SystemColors.ButtonHighlight;
            btnReturnToMainForm.Location = new Point(26, 25);
            btnReturnToMainForm.Name = "btnReturnToMainForm";
            btnReturnToMainForm.Size = new Size(160, 44);
            btnReturnToMainForm.TabIndex = 14;
            btnReturnToMainForm.Text = "На головну";
            btnReturnToMainForm.UseVisualStyleBackColor = false;
            btnReturnToMainForm.Click += btnReturnToMainForm_Click;
            // 
            // lblTripPlanned
            // 
            lblTripPlanned.AutoSize = true;
            lblTripPlanned.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Underline);
            lblTripPlanned.Location = new Point(26, 123);
            lblTripPlanned.Name = "lblTripPlanned";
            lblTripPlanned.Size = new Size(361, 38);
            lblTripPlanned.TabIndex = 13;
            lblTripPlanned.Text = "Ваші заплановані поїздки";
            // 
            // listTripsPlanned
            // 
            listTripsPlanned.FormattingEnabled = true;
            listTripsPlanned.HorizontalScrollbar = true;
            listTripsPlanned.Location = new Point(26, 226);
            listTripsPlanned.Name = "listTripsPlanned";
            listTripsPlanned.Size = new Size(496, 224);
            listTripsPlanned.TabIndex = 12;
            // 
            // lstBoxHeaders
            // 
            lstBoxHeaders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lstBoxHeaders.FormattingEnabled = true;
            lstBoxHeaders.Items.AddRange(new object[] { "№ | Водій |  Дата | Відправка |  Призначення |  Залишилось місць" });
            lstBoxHeaders.Location = new Point(26, 196);
            lstBoxHeaders.Name = "lstBoxHeaders";
            lstBoxHeaders.SelectionMode = SelectionMode.None;
            lstBoxHeaders.Size = new Size(496, 24);
            lstBoxHeaders.TabIndex = 17;
            // 
            // listCompanionsInfo
            // 
            listCompanionsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listCompanionsInfo.FormattingEnabled = true;
            listCompanionsInfo.Items.AddRange(new object[] { "Логін  |  Ім'я   |    Телефон" });
            listCompanionsInfo.Location = new Point(705, 196);
            listCompanionsInfo.Name = "listCompanionsInfo";
            listCompanionsInfo.SelectionMode = SelectionMode.None;
            listCompanionsInfo.Size = new Size(301, 24);
            listCompanionsInfo.TabIndex = 18;
            listCompanionsInfo.Visible = false;
            // 
            // PlannedTravelsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 487);
            Controls.Add(listCompanionsInfo);
            Controls.Add(lstBoxHeaders);
            Controls.Add(btnShowCompanions);
            Controls.Add(listCompanions);
            Controls.Add(btnReturnToMainForm);
            Controls.Add(lblTripPlanned);
            Controls.Add(listTripsPlanned);
            Name = "PlannedTravelsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlannedTravelsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowCompanions;
        public ListBox listCompanions;
        private Button btnReturnToMainForm;
        private Label lblTripPlanned;
        public ListBox listTripsPlanned;
        private ListBox lstBoxHeaders;
        private ListBox listCompanionsInfo;
    }
}