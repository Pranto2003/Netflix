namespace NETFLIX
{
    partial class PlayMoviesForPremium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMoviesForPremium));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            returnButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(1, 103);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1699, 682);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(0, 192, 0);
            returnButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.Location = new Point(431, 806);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(122, 42);
            returnButton.TabIndex = 1;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(1175, 806);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 42);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // PlayMoviesForPremium
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Netflix_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1681, 891);
            Controls.Add(exitButton);
            Controls.Add(returnButton);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "PlayMoviesForPremium";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayMoviesForPremium";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button returnButton;
        private Button exitButton;
    }
}