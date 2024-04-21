namespace KP_Dykun_UIClasses
{
    partial class TravelHistoryForm
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
            listTripHistory = new ListBox();
            lblTripHistory = new Label();
            btnReturnToMainForm = new Button();
            listCompanions = new ListBox();
            btnShowCompanions = new Button();
            SuspendLayout();
            // 
            // listTripHistory
            // 
            listTripHistory.FormattingEnabled = true;
            listTripHistory.Location = new Point(12, 202);
            listTripHistory.Name = "listTripHistory";
            listTripHistory.Size = new Size(452, 224);
            listTripHistory.TabIndex = 0;
            listTripHistory.SelectedIndexChanged += listTripHistory_SelectedIndexChanged;
            // 
            // lblTripHistory
            // 
            lblTripHistory.AutoSize = true;
            lblTripHistory.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Underline);
            lblTripHistory.Location = new Point(12, 140);
            lblTripHistory.Name = "lblTripHistory";
            lblTripHistory.Size = new Size(308, 38);
            lblTripHistory.TabIndex = 1;
            lblTripHistory.Text = "Історія ваших поїздок";
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
            btnReturnToMainForm.TabIndex = 9;
            btnReturnToMainForm.Text = "На головну";
            btnReturnToMainForm.UseVisualStyleBackColor = false;
            btnReturnToMainForm.Click += btnReturnToMainForm_Click;
            // 
            // listCompanions
            // 
            listCompanions.FormattingEnabled = true;
            listCompanions.Location = new Point(642, 202);
            listCompanions.Name = "listCompanions";
            listCompanions.Size = new Size(288, 224);
            listCompanions.TabIndex = 10;
            listCompanions.Visible = false;
            // 
            // btnShowCompanions
            // 
            btnShowCompanions.BackColor = SystemColors.ControlDark;
            btnShowCompanions.Cursor = Cursors.Hand;
            btnShowCompanions.FlatStyle = FlatStyle.Popup;
            btnShowCompanions.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowCompanions.ForeColor = SystemColors.ButtonHighlight;
            btnShowCompanions.Location = new Point(470, 202);
            btnShowCompanions.Name = "btnShowCompanions";
            btnShowCompanions.Size = new Size(149, 81);
            btnShowCompanions.TabIndex = 11;
            btnShowCompanions.Text = "Показати\r\nПопутників";
            btnShowCompanions.UseVisualStyleBackColor = false;
            btnShowCompanions.Click += btnShowCompanions_Click;
            // 
            // TravelHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 481);
            Controls.Add(btnShowCompanions);
            Controls.Add(listCompanions);
            Controls.Add(btnReturnToMainForm);
            Controls.Add(lblTripHistory);
            Controls.Add(listTripHistory);
            Name = "TravelHistoryForm";
            Text = "TravelHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTripHistory;
        private Button btnReturnToMainForm;
        public ListBox listTripHistory;
        public ListBox listCompanions;
        private Button btnShowCompanions;
    }
}