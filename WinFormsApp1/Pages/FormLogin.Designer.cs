namespace WinFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblForgotPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCreateAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSingUp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.BorderColor = Color.Black;
            tbEmail.BorderThickness = 0;
            tbEmail.CustomizableEdges = customizableEdges1;
            tbEmail.DefaultText = "";
            tbEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEmail.FillColor = Color.FromArgb(224, 224, 224);
            tbEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.Black;
            tbEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEmail.IconLeft = Estoque.Forms.Properties.Resources.image01_MailIcon;
            tbEmail.Location = new Point(365, 98);
            tbEmail.Margin = new Padding(5, 6, 5, 6);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderForeColor = Color.Silver;
            tbEmail.PlaceholderText = "@mail.com";
            tbEmail.SelectedText = "";
            tbEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbEmail.Size = new Size(211, 39);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BorderColor = Color.Black;
            tbPassword.BorderThickness = 0;
            tbPassword.CustomizableEdges = customizableEdges3;
            tbPassword.DefaultText = "";
            tbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.FillColor = Color.FromArgb(224, 224, 224);
            tbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Black;
            tbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.IconLeft = Estoque.Forms.Properties.Resources.image02_PasswordIcon;
            tbPassword.Location = new Point(365, 163);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderForeColor = Color.Silver;
            tbPassword.PlaceholderText = "password";
            tbPassword.SelectedText = "";
            tbPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbPassword.Size = new Size(211, 39);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 5;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(365, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(211, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(365, 79);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 17);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(365, 143);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(55, 17);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(378, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(172, 42);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "USER LOGIN";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.Gray;
            lblForgotPassword.Location = new Point(365, 206);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(120, 17);
            lblForgotPassword.TabIndex = 6;
            lblForgotPassword.Text = "Forgot your password?";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.BackColor = Color.Transparent;
            lblCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(365, 271);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(133, 17);
            lblCreateAccount.TabIndex = 7;
            lblCreateAccount.Text = "Don't have an account?";
            // 
            // lblSingUp
            // 
            lblSingUp.BackColor = Color.Transparent;
            lblSingUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSingUp.ForeColor = Color.DodgerBlue;
            lblSingUp.Location = new Point(502, 271);
            lblSingUp.Name = "lblSingUp";
            lblSingUp.Size = new Size(48, 17);
            lblSingUp.TabIndex = 8;
            lblSingUp.Text = "Sing-Up";
            lblSingUp.Click += lblSingUp_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(12, 33);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(345, 257);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 9;
            guna2PictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(672, 365);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblSingUp);
            Controls.Add(lblCreateAccount);
            Controls.Add(lblForgotPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgotPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreateAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSingUp;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
