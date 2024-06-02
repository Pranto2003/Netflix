namespace NETFLIX
{
    partial class PlayMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMovies));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            returnButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(2, 83);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1400, 570);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(0, 192, 0);
            returnButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButton.Location = new Point(354, 669);
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
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(1187, 669);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 42);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // PlayMovies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Netflix_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1401, 710);
            Controls.Add(exitButton);
            Controls.Add(returnButton);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "PlayMovies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayMovies";
            Load += PlayMovies_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button returnButton;
        private Button exitButton;
    }
}