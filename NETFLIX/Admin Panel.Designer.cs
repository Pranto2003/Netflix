namespace NETFLIX
{
    partial class Admin_Panel
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
            FirstNameLabel = new Label();
            firstNameTextbox = new TextBox();
            button1 = new Button();
            dateOfBirthTextbox = new DateTimePicker();
            panel1 = new Panel();
            premiumUsers = new Button();
            clearButton = new Button();
            exitButton = new Button();
            returnButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            GenderLabel = new Label();
            maleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            DateOfBirthLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            LastNameLabel = new Label();
            passwordTextbox = new TextBox();
            emailTextbox = new TextBox();
            secondNameTextbox = new TextBox();
            dataGridView = new DataGridView();
            searchByEmailTextBox = new TextBox();
            label1 = new Label();
            searchButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLabel.ForeColor = Color.White;
            FirstNameLabel.Location = new Point(12, 39);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(94, 20);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name :";
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(127, 36);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(206, 27);
            firstNameTextbox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(98, 72);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthTextbox
            // 
            dateOfBirthTextbox.Location = new Point(98, 316);
            dateOfBirthTextbox.Name = "dateOfBirthTextbox";
            dateOfBirthTextbox.Size = new Size(250, 27);
            dateOfBirthTextbox.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(searchByEmailTextBox);
            panel1.Controls.Add(premiumUsers);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(returnButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(GenderLabel);
            panel1.Controls.Add(maleRadioButton);
            panel1.Controls.Add(FemaleRadioButton);
            panel1.Controls.Add(DateOfBirthLabel);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(LastNameLabel);
            panel1.Controls.Add(passwordTextbox);
            panel1.Controls.Add(emailTextbox);
            panel1.Controls.Add(secondNameTextbox);
            panel1.Controls.Add(FirstNameLabel);
            panel1.Controls.Add(dateOfBirthTextbox);
            panel1.Controls.Add(firstNameTextbox);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 655);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // premiumUsers
            // 
            premiumUsers.BackColor = Color.Gold;
            premiumUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            premiumUsers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            premiumUsers.Location = new Point(114, 613);
            premiumUsers.Name = "premiumUsers";
            premiumUsers.Size = new Size(94, 29);
            premiumUsers.TabIndex = 22;
            premiumUsers.Text = "Premium";
            premiumUsers.UseVisualStyleBackColor = false;
            premiumUsers.Click += premiumUsers_Click;
            // 
            // clearButton
            // 
            clearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(12, 569);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 21;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(241, 569);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 20;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // returnButton
            // 
            returnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            returnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.Location = new Point(127, 569);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(94, 29);
            returnButton.TabIndex = 19;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(241, 519);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(127, 519);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // insertButton
            // 
            insertButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            insertButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertButton.Location = new Point(12, 519);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(94, 29);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLabel.ForeColor = Color.White;
            GenderLabel.Location = new Point(12, 390);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(60, 20);
            GenderLabel.TabIndex = 15;
            GenderLabel.Text = "Gender";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maleRadioButton.ForeColor = Color.White;
            maleRadioButton.Location = new Point(144, 386);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(64, 24);
            maleRadioButton.TabIndex = 14;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += MaleRadioButton_CheckedChanged;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FemaleRadioButton.ForeColor = Color.White;
            FemaleRadioButton.Location = new Point(253, 386);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(80, 24);
            FemaleRadioButton.TabIndex = 13;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfBirthLabel.ForeColor = Color.White;
            DateOfBirthLabel.Location = new Point(3, 323);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(88, 17);
            DateOfBirthLabel.TabIndex = 12;
            DateOfBirthLabel.Text = "Date of Birth";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(7, 246);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(84, 20);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Password :";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.White;
            EmailLabel.Location = new Point(17, 179);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(55, 20);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email :";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLabel.ForeColor = Color.White;
            LastNameLabel.Location = new Point(12, 109);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(92, 20);
            LastNameLabel.TabIndex = 9;
            LastNameLabel.Text = "Last Name :";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(127, 239);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(206, 27);
            passwordTextbox.TabIndex = 8;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(127, 172);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(206, 27);
            emailTextbox.TabIndex = 7;
            // 
            // secondNameTextbox
            // 
            secondNameTextbox.Location = new Point(127, 106);
            secondNameTextbox.Name = "secondNameTextbox";
            secondNameTextbox.Size = new Size(206, 27);
            secondNameTextbox.TabIndex = 6;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(354, 1);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(921, 655);
            dataGridView.TabIndex = 7;
            // 
            // searchByEmailTextBox
            // 
            searchByEmailTextBox.Location = new Point(142, 432);
            searchByEmailTextBox.Name = "searchByEmailTextBox";
            searchByEmailTextBox.Size = new Size(206, 27);
            searchByEmailTextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 435);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 24;
            label1.Text = "Search by Email";
            // 
            // searchButton
            // 
            searchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            searchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(127, 475);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 25;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Admin_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 655);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Admin_Panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label FirstNameLabel;
        private TextBox firstNameTextbox;
        private Button button1;
        private DateTimePicker dateOfBirthTextbox;
        private Panel panel1;
        private TextBox emailTextbox;
        private TextBox secondNameTextbox;
        private RadioButton FemaleRadioButton;
        private Label DateOfBirthLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Label LastNameLabel;
        private TextBox passwordTextbox;
        private RadioButton maleRadioButton;
        private Label GenderLabel;
        private Button exitButton;
        private Button returnButton;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
        private Button clearButton;
        private Button premiumUsers;
        private DataGridView dataGridView;
        private Button searchButton;
        private Label label1;
        private TextBox searchByEmailTextBox;
    }
}