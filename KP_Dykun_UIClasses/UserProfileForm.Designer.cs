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
            btnChangePhoto = new Button();
            txtBoxPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            lblLogin = new Label();
            txtBoxName = new TextBox();
            pctPhoto = new PictureBox();
            lblName = new Label();
            btnChangeProfile = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
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
            btnReturnToMainForm.Click += btnReturnToMainForm_Click;
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
            btnViewTripHistory.Click += btnViewTripHistory_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnChangeProfile);
            panel1.Controls.Add(btnChangePhoto);
            panel1.Controls.Add(txtBoxPhoneNumber);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(pctPhoto);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(76, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 393);
            panel1.TabIndex = 11;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.BackColor = SystemColors.ButtonShadow;
            btnChangePhoto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnChangePhoto.ForeColor = SystemColors.ButtonHighlight;
            btnChangePhoto.Location = new Point(245, 234);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(182, 41);
            btnChangePhoto.TabIndex = 20;
            btnChangePhoto.Text = "Змінити фото";
            btnChangePhoto.UseVisualStyleBackColor = false;
            btnChangePhoto.Click += btnChangePhoto_Click;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Location = new Point(17, 295);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(176, 27);
            txtBoxPhoneNumber.TabIndex = 19;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(17, 255);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(124, 37);
            lblPhoneNumber.TabIndex = 18;
            lblPhoneNumber.Text = "Телефон";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(17, 210);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(176, 27);
            txtBoxPassword.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblPassword.Location = new Point(17, 170);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(112, 37);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblLogin.Location = new Point(179, 13);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(86, 37);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "Логін";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(17, 122);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(113, 27);
            txtBoxName.TabIndex = 14;
            // 
            // pctPhoto
            // 
            pctPhoto.BorderStyle = BorderStyle.FixedSingle;
            pctPhoto.Location = new Point(245, 82);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.Size = new Size(182, 146);
            pctPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            pctPhoto.TabIndex = 13;
            pctPhoto.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblName.Location = new Point(17, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 37);
            lblName.TabIndex = 12;
            lblName.Text = "Ім'я";
            // 
            // btnChangeProfile
            // 
            btnChangeProfile.BackColor = SystemColors.ButtonShadow;
            btnChangeProfile.Cursor = Cursors.Hand;
            btnChangeProfile.FlatStyle = FlatStyle.Popup;
            btnChangeProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangeProfile.ForeColor = SystemColors.ButtonHighlight;
            btnChangeProfile.Location = new Point(116, 337);
            btnChangeProfile.Name = "btnChangeProfile";
            btnChangeProfile.Size = new Size(207, 44);
            btnChangeProfile.TabIndex = 21;
            btnChangeProfile.Text = "Змінити";
            btnChangeProfile.UseVisualStyleBackColor = false;
            btnChangeProfile.Click += btnChangeProfile_Click;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 547);
            Controls.Add(panel1);
            Controls.Add(btnViewTripHistory);
            Controls.Add(btnReturnToMainForm);
            Name = "UserProfileForm";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturnToMainForm;
        private Button btnViewTripHistory;
        private Panel panel1;
        private Label lblName;
        private Label lblPhoneNumber;
        private Label lblPassword;
        private Button btnChangePhoto;
        public PictureBox pctPhoto;
        public TextBox txtBoxPhoneNumber;
        public TextBox txtBoxPassword;
        public Label lblLogin;
        public TextBox txtBoxName;
        private Button btnChangeProfile;
    }
}