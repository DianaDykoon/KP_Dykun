namespace KP_Dykun_UIClasses
{
    partial class RegistrationForm
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
            lblRegistration = new Label();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            btnRegistration = new Button();
            lblPassword = new Label();
            lblLogin = new Label();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            lblPhoneNumber = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Underline);
            lblRegistration.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistration.Location = new Point(303, 53);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(171, 39);
            lblRegistration.TabIndex = 12;
            lblRegistration.Text = "Реєстрація";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(320, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(320, 164);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(241, 27);
            txtLogin.TabIndex = 10;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = SystemColors.ControlDarkDark;
            btnRegistration.Cursor = Cursors.Hand;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRegistration.ForeColor = SystemColors.Control;
            btnRegistration.Location = new Point(277, 413);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(295, 61);
            btnRegistration.TabIndex = 9;
            btnRegistration.Text = "Зареєструватися";
            btnRegistration.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 13.8F);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(229, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 26);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Пароль:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 13.8F);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(245, 164);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(72, 26);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Логін:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Попутник", "Водій" });
            cmbRole.Location = new Point(320, 351);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(140, 28);
            cmbRole.TabIndex = 15;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Times New Roman", 13.8F);
            lblRole.ForeColor = SystemColors.ActiveCaptionText;
            lblRole.Location = new Point(254, 351);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(63, 26);
            lblRole.TabIndex = 16;
            lblRole.Text = "Роль:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(320, 303);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(241, 27);
            txtPhoneNumber.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(320, 255);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 19;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Times New Roman", 13.8F);
            lblPhoneNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblPhoneNumber.Location = new Point(217, 302);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(101, 26);
            lblPhoneNumber.TabIndex = 18;
            lblPhoneNumber.Text = "Телефон:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 13.8F);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(262, 255);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 26);
            lblName.TabIndex = 17;
            lblName.Text = "Ім'я:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 538);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblName);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblRegistration);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnRegistration);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRegistration;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Button btnRegistration;
        private Label lblPassword;
        private Label lblLogin;
        private ComboBox cmbRole;
        private Label lblRole;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Label lblPhoneNumber;
        private Label lblName;
    }
}