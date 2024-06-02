namespace NETFLIX
{
    partial class WelcomePage
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
            label1 = new Label();
            getStartedButton = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            exitButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(330, 157);
            label1.Name = "label1";
            label1.Size = new Size(751, 54);
            label1.TabIndex = 0;
            label1.Text = "Unlimited movies, TV Shows and More";
            // 
            // getStartedButton
            // 
            getStartedButton.BackColor = Color.Red;
            getStartedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            getStartedButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getStartedButton.ForeColor = Color.White;
            getStartedButton.Location = new Point(551, 360);
            getStartedButton.Name = "getStartedButton";
            getStartedButton.Size = new Size(252, 56);
            getStartedButton.TabIndex = 1;
            getStartedButton.Text = "Get Started";
            getStartedButton.UseVisualStyleBackColor = false;
            getStartedButton.Click += getStartedButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(517, 229);
            label2.Name = "label2";
            label2.Size = new Size(366, 38);
            label2.TabIndex = 2;
            label2.Text = "Watch anywhere , anytime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(504, 283);
            label3.Name = "label3";
            label3.Size = new Size(379, 31);
            label3.TabIndex = 3;
            label3.Text = "Ready to watch? Then Get Started.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(getStartedButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1343, 631);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel2.Location = new Point(213, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 89);
            panel2.TabIndex = 5;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            exitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(1195, 538);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(107, 53);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Netflix_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1345, 713);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomePage";
            Load += WelcomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button getStartedButton;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button exitButton;
    }
}