namespace KP_Dykun_UIClasses
{
    partial class UserProfileForm
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
            btnReturnToMainForm = new Button();
            btnViewTripHistory = new Button();
            panel1 = new Panel();
            txtRating = new TextBox();
            lblRating = new Label();
            pctPhoto = new PictureBox();
            lblName = new Label();
            lblInformation = new Label();
            panel2 = new Panel();
            txtInformation = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // btnViewTripHistory
            // 
            btnViewTripHistory.BackColor = SystemColors.ButtonShadow;
            btnViewTripHistory.Cursor = Cursors.Hand;
            btnViewTripHistory.FlatStyle = FlatStyle.Popup;
            btnViewTripHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnViewTripHistory.ForeColor = SystemColors.ButtonHighlight;
            btnViewTripHistory.Location = new Point(365, 12);
            btnViewTripHistory.Name = "btnViewTripHistory";
            btnViewTripHistory.Size = new Size(231, 44);
            btnViewTripHistory.TabIndex = 10;
            btnViewTripHistory.Text = "Історія поїздок";
            btnViewTripHistory.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtRating);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(pctPhoto);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(76, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 160);
            panel1.TabIndex = 11;
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Segoe UI", 10.8F);
            txtRating.Location = new Point(122, 94);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(40, 31);
            txtRating.TabIndex = 16;
            txtRating.Text = "4";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblRating.Location = new Point(17, 90);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(99, 32);
            lblRating.TabIndex = 14;
            lblRating.Text = "Оцінка:";
            // 
            // pctPhoto
            // 
            pctPhoto.BorderStyle = BorderStyle.FixedSingle;
            pctPhoto.Location = new Point(203, 22);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.Size = new Size(182, 112);
            pctPhoto.TabIndex = 13;
            pctPhoto.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblName.Location = new Point(17, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 37);
            lblName.TabIndex = 12;
            lblName.Text = "Ім'я";
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblInformation.Location = new Point(17, 30);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(122, 32);
            lblInformation.TabIndex = 14;
            lblInformation.Text = "Про Себе";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(txtInformation);
            panel2.Controls.Add(lblInformation);
            panel2.Location = new Point(76, 325);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 160);
            panel2.TabIndex = 15;
            // 
            // txtInformation
            // 
            txtInformation.Location = new Point(17, 85);
            txtInformation.Name = "txtInformation";
            txtInformation.Size = new Size(368, 27);
            txtInformation.TabIndex = 15;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 574);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnViewTripHistory);
            Controls.Add(btnReturnToMainForm);
            Name = "UserProfileForm";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturnToMainForm;
        private Button btnViewTripHistory;
        private Panel panel1;
        private Label lblName;
        private PictureBox pctPhoto;
        private Label lblInformation;
        private Panel panel2;
        private TextBox txtRating;
        private Label lblRating;
        private TextBox txtInformation;
    }
}