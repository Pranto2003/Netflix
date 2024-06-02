namespace NETFLIX
{
    partial class LogIn
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
            panel1 = new Panel();
            forgetPasswordButton = new Button();
            showCheckBox = new CheckBox();
            premiumSignUpButton = new Button();
            emailTextBox = new TextBox();
            signUpButton = new Button();
            userSignInButton = new Button();
            adminLoginButton = new Button();
            label4 = new Label();
            passwordTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exitButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(forgetPasswordButton);
            panel1.Controls.Add(showCheckBox);
            panel1.Controls.Add(premiumSignUpButton);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(signUpButton);
            panel1.Controls.Add(userSignInButton);
            panel1.Controls.Add(adminLoginButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(544, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 377);
            panel1.TabIndex = 0;
            // 
            // forgetPasswordButton
            // 
            forgetPasswordButton.BackColor = Color.Red;
            forgetPasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgetPasswordButton.ForeColor = Color.White;
            forgetPasswordButton.Location = new Point(103, 322);
            forgetPasswordButton.Name = "forgetPasswordButton";
            forgetPasswordButton.Size = new Size(134, 41);
            forgetPasswordButton.TabIndex = 14;
            forgetPasswordButton.Text = "Forget Password";
            forgetPasswordButton.UseVisualStyleBackColor = false;
            forgetPasswordButton.Click += forgetPasswordButton_Click;
            // 
            // showCheckBox
            // 
            showCheckBox.AutoSize = true;
            showCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showCheckBox.ForeColor = Color.White;
            showCheckBox.Location = new Point(144, 127);
            showCheckBox.Name = "showCheckBox";
            showCheckBox.Size = new Size(69, 24);
            showCheckBox.TabIndex = 13;
            showCheckBox.Text = "Show";
            showCheckBox.UseVisualStyleBackColor = true;
            showCheckBox.CheckedChanged += showCheckBox_CheckedChanged;
            // 
            // premiumSignUpButton
            // 
            premiumSignUpButton.BackColor = Color.Gold;
            premiumSignUpButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            premiumSignUpButton.ForeColor = Color.Black;
            premiumSignUpButton.Location = new Point(173, 275);
            premiumSignUpButton.Name = "premiumSignUpButton";
            premiumSignUpButton.Size = new Size(134, 41);
            premiumSignUpButton.TabIndex = 12;
            premiumSignUpButton.Text = "Premium SignUp";
            premiumSignUpButton.UseVisualStyleBackColor = false;
            premiumSignUpButton.Click += premiumSignUpButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(21, 77);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(286, 27);
            emailTextBox.TabIndex = 10;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(0, 192, 0);
            signUpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(21, 275);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(134, 41);
            signUpButton.TabIndex = 8;
            signUpButton.Text = "SignUp";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // userSignInButton
            // 
            userSignInButton.BackColor = Color.Red;
            userSignInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userSignInButton.ForeColor = Color.White;
            userSignInButton.Location = new Point(173, 198);
            userSignInButton.Name = "userSignInButton";
            userSignInButton.Size = new Size(134, 41);
            userSignInButton.TabIndex = 7;
            userSignInButton.Text = "User SignIn";
            userSignInButton.UseVisualStyleBackColor = false;
            userSignInButton.Click += userSignInButton_Click;
            // 
            // adminLoginButton
            // 
            adminLoginButton.BackColor = Color.Red;
            adminLoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminLoginButton.ForeColor = Color.White;
            adminLoginButton.Location = new Point(21, 198);
            adminLoginButton.Name = "adminLoginButton";
            adminLoginButton.Size = new Size(134, 41);
            adminLoginButton.TabIndex = 6;
            adminLoginButton.Text = "Admin SignIn";
            adminLoginButton.UseVisualStyleBackColor = false;
            adminLoginButton.Click += adminLoginButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 242);
            label4.Name = "label4";
            label4.Size = new Size(273, 20);
            label4.TabIndex = 5;
            label4.Text = "Not have an Account?     Sign Up Now";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(21, 152);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(286, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "SignIn";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(1215, 651);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(97, 36);
            exitButton.TabIndex = 1;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Netflix_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1345, 713);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox passwordTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button signUpButton;
        private Button userSignInButton;
        private Button adminLoginButton;
        private Button exitButton;
        private TextBox emailTextBox;
        private Button premiumSignUpButton;
        private CheckBox showCheckBox;
        private Button forgetPasswordButton;
    }
}