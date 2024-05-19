namespace KP_Dykun_UIClasses
{
    partial class AuthorizationForm
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
            lblLogin = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lblAuthorization = new Label();
            linkLblRegistration = new LinkLabel();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 13.8F);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(209, 148);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(72, 26);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логін:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 13.8F);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(207, 202);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 26);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlDarkDark;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(243, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(295, 61);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(298, 149);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(241, 27);
            txtLogin.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(298, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblAuthorization
            // 
            lblAuthorization.AutoSize = true;
            lblAuthorization.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Underline);
            lblAuthorization.ForeColor = SystemColors.ActiveCaptionText;
            lblAuthorization.Location = new Point(270, 37);
            lblAuthorization.Name = "lblAuthorization";
            lblAuthorization.Size = new Size(227, 39);
            lblAuthorization.TabIndex = 5;
            lblAuthorization.Text = "Вхід в аккаунт";
            // 
            // linkLblRegistration
            // 
            linkLblRegistration.AutoSize = true;
            linkLblRegistration.LinkColor = Color.DimGray;
            linkLblRegistration.Location = new Point(414, 240);
            linkLblRegistration.Name = "linkLblRegistration";
            linkLblRegistration.Size = new Size(124, 20);
            linkLblRegistration.TabIndex = 6;
            linkLblRegistration.TabStop = true;
            linkLblRegistration.Text = "Зареєструватися";
            linkLblRegistration.LinkClicked += linkLblRegistration_LinkClicked;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(741, 510);
            Controls.Add(linkLblRegistration);
            Controls.Add(lblAuthorization);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblAuthorization;
        private LinkLabel linkLblRegistration;
    }
}