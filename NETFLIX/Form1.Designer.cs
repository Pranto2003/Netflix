namespace NETFLIX
{
    partial class RegistrationForm
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
            RegistrationPanel = new Panel();
            Passwordlabel = new Label();
            passwordTextBox = new TextBox();
            confirmButton = new Button();
            DateofBirthLabel = new Label();
            GenderLabel = new Label();
            EmailLabel = new Label();
            SecondNameLabel = new Label();
            FirstNamelabel = new Label();
            dateofBirthDateTimePicker = new DateTimePicker();
            FemaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            RegistrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationPanel
            // 
            RegistrationPanel.BackColor = Color.Transparent;
            RegistrationPanel.Controls.Add(Passwordlabel);
            RegistrationPanel.Controls.Add(passwordTextBox);
            RegistrationPanel.Controls.Add(confirmButton);
            RegistrationPanel.Controls.Add(DateofBirthLabel);
            RegistrationPanel.Controls.Add(GenderLabel);
            RegistrationPanel.Controls.Add(EmailLabel);
            RegistrationPanel.Controls.Add(SecondNameLabel);
            RegistrationPanel.Controls.Add(FirstNamelabel);
            RegistrationPanel.Controls.Add(dateofBirthDateTimePicker);
            RegistrationPanel.Controls.Add(FemaleRadioButton);
            RegistrationPanel.Controls.Add(maleRadioButton);
            RegistrationPanel.Controls.Add(emailTextBox);
            RegistrationPanel.Controls.Add(lastNameTextBox);
            RegistrationPanel.Controls.Add(firstNameTextBox);
            RegistrationPanel.ForeColor = SystemColors.ControlLight;
            RegistrationPanel.Location = new Point(385, 115);
            RegistrationPanel.Name = "RegistrationPanel";
            RegistrationPanel.Size = new Size(697, 482);
            RegistrationPanel.TabIndex = 0;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwordlabel.ForeColor = Color.Transparent;
            Passwordlabel.Location = new Point(13, 191);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(95, 23);
            Passwordlabel.TabIndex = 13;
            Passwordlabel.Text = "Password :";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(212, 187);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(279, 27);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.UseWaitCursor = true;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.White;
            confirmButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.ForeColor = SystemColors.ActiveCaptionText;
            confirmButton.Location = new Point(305, 382);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(108, 42);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // DateofBirthLabel
            // 
            DateofBirthLabel.AutoSize = true;
            DateofBirthLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateofBirthLabel.ForeColor = Color.Transparent;
            DateofBirthLabel.Location = new Point(18, 298);
            DateofBirthLabel.Name = "DateofBirthLabel";
            DateofBirthLabel.Size = new Size(125, 23);
            DateofBirthLabel.TabIndex = 10;
            DateofBirthLabel.Text = "Date of Birth :";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLabel.ForeColor = Color.Transparent;
            GenderLabel.Location = new Point(18, 239);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(78, 23);
            GenderLabel.TabIndex = 9;
            GenderLabel.Text = "Gender :";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.Transparent;
            EmailLabel.Location = new Point(18, 135);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(64, 23);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Email :";
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecondNameLabel.ForeColor = Color.Transparent;
            SecondNameLabel.Location = new Point(13, 81);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(104, 23);
            SecondNameLabel.TabIndex = 7;
            SecondNameLabel.Text = "Last Name :";
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNamelabel.ForeColor = Color.Transparent;
            FirstNamelabel.Location = new Point(18, 25);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(107, 23);
            FirstNamelabel.TabIndex = 6;
            FirstNamelabel.Text = "First Name :";
            // 
            // dateofBirthDateTimePicker
            // 
            dateofBirthDateTimePicker.Location = new Point(212, 295);
            dateofBirthDateTimePicker.Name = "dateofBirthDateTimePicker";
            dateofBirthDateTimePicker.Size = new Size(279, 27);
            dateofBirthDateTimePicker.TabIndex = 5;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FemaleRadioButton.ForeColor = Color.Transparent;
            FemaleRadioButton.Location = new Point(333, 238);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(80, 24);
            FemaleRadioButton.TabIndex = 4;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maleRadioButton.ForeColor = Color.Transparent;
            maleRadioButton.Location = new Point(212, 238);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(64, 24);
            maleRadioButton.TabIndex = 3;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(212, 135);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(279, 27);
            emailTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(212, 77);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(279, 27);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(212, 21);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(279, 27);
            firstNameTextBox.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Netflix_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1345, 713);
            Controls.Add(RegistrationPanel);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            RegistrationPanel.ResumeLayout(false);
            RegistrationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RegistrationPanel;
        private TextBox firstNameTextBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private RadioButton maleRadioButton;
        private Label FirstNamelabel;
        private DateTimePicker dateofBirthDateTimePicker;
        private RadioButton FemaleRadioButton;
        private Button confirmButton;
        private Label DateofBirthLabel;
        private Label GenderLabel;
        private Label EmailLabel;
        private Label SecondNameLabel;
        private Label Passwordlabel;
        private TextBox passwordTextBox;
    }
}
