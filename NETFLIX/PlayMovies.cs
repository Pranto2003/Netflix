using AxWMPLib;
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
    public partial class PlayMovies : Form
    {
        public PlayMovies()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        public void playMovie(string filePath)
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

        private void PlayMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
