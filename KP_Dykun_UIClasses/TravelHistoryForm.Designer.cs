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
            SuspendLayout();
            // 
            // listTripHistory
            // 
            listTripHistory.FormattingEnabled = true;
            listTripHistory.Location = new Point(12, 202);
            listTripHistory.Name = "listTripHistory";
            listTripHistory.Size = new Size(983, 224);
            listTripHistory.TabIndex = 0;
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
            // 
            // TravelHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 450);
            Controls.Add(btnReturnToMainForm);
            Controls.Add(lblTripHistory);
            Controls.Add(listTripHistory);
            Name = "TravelHistoryForm";
            Text = "HistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTripHistory;
        private Label lblTripHistory;
        private Button btnReturnToMainForm;
    }
}