using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX
{
    public partial class PlayMoviesForPremium : Form
    {
        public PlayMoviesForPremium()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        public void PlayMovie(string filePath)
        {
           
            axWindowsMediaPlayer1.URL = filePath;


        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            
         
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void PlayMoviesForPremium_Load(object sender, EventArgs e)
        {

        }
    }
}
