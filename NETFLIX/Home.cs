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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void hanumanMovieButton_Click(object sender, EventArgs e)
        {

            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\Hanuman Hindi Trailer   In Cinemas 12th Jan, 2024   Prasanth Varma   Teja Sajja   RKD Studios.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            
        }


        private void salaarMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\Salaar Release Trailer - Hindi   Prabhas   Prashanth Neel   Prithviraj   Shruthi   Hombale Films.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            

        }

        private void maharshiMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\#MaharshiTrailer   Mahesh Babu, Pooja Hegde, Allari Naresh   Vamshi Paidipally   DSP   4K.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            
        }

        private void inceptionMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\Inception (2010) Official Trailer #1 - Christopher Nolan Movie HD.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
           
        }

        private void interstellarMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\Interstellar Movie - Official Trailer.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            

        }


        private void searchButon_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.ToUpper();

            switch (searchText)
            {
                case "SALAAR":
                    if (MessageBox.Show("Do you want to play Salaar?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        salaarMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "HANUMAN":
                    if (MessageBox.Show("Do you want to play Hanuman?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        hanumanMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "MAHARSHI":
                    if (MessageBox.Show("Do you want to play Maharshi?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        maharshiMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "INCEPTION":
                    if (MessageBox.Show("Do you want to play Inception?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        inceptionMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "INTERSTELLAR":
                    if (MessageBox.Show("Do you want to play Interstellar?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        interstellarMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "KGF CHAPTER 1":
                case "KGF CHAPTER ONE":
                    if (MessageBox.Show("Do you want to play KGF Chapter 1?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kgfChapterOneMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "KGF CHAPTER 2":
                case "KGF CHAPTER TWO":
                    if (MessageBox.Show("Do you want to play KGF Chapter 2?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kgfChapterTwoMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "KANTARA":
                    if (MessageBox.Show("Do you want to play Kantara?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kantaraMovieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "777 CHARLIE":
                    if (MessageBox.Show("Do you want to play 777 Charlie?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        charlieButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "MAJOR":
                    if (MessageBox.Show("Do you want to play Major?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        majorButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "RED":
                    if (MessageBox.Show("Do you want to play Red?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        redButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "PUSHPA THE RISE":
                    if (MessageBox.Show("Do you want to play Pushpa The Rise?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        pushpaButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "MASTER":
                    if (MessageBox.Show("Do you want to play Master?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        masterButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "RRR":
                    if (MessageBox.Show("Do you want to play RRR?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rrrButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;
                case "VIKRAM":
                    if (MessageBox.Show("Do you want to play Vikram?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        vikramButton_Click(sender, e);
                    }
                    else
                    {
                        SearchTextBox.Text = "";
                    }
                    break;

                default:
                    MessageBox.Show("Movie not found.");
                    break;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Close();
            logIn.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void kantaraMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\Kantara (Hindi)   Official Trailer   Rishab Shetty, Sapthami Gowda, Kishore   Netflix India.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            
        }

        private void kgfChapterOneMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\KGF Trailer Hindi   Yash   Srinidhi   21st Dec 2018.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            
        }

        private void kgfChapterTwoMovieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();


            string movieFilePath = "D:\\Netflix Videos\\KGF Chapter 2 Trailer Hindi Yash Sanjay Dutt Raveena Tandon Srinidhi Prashanth Neel Vijay Kiragandur.mp4";
            playMovies.playMovie(movieFilePath);


            playMovies.Show();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pushpaButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\#Pushpa - The Rise (Hindi) Official Trailer   Allu Arjun, Rashmika, Sunil, Fahadh   DSP   Sukumar.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void charlieButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\777 Charlie - Official Trailer   Rent Now On Prime Video Store   Rakshit Shetty   Kiranraj K.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void majorButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\MAJOR Trailer - Hindi   Adivi Sesh   Saiee M   Sobhita D   Mahesh Babu - In Cinemas June 3rd.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
           
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\RED Official Teaser   Ram Pothineni   Nivetha Pethuraj   Malvika Sharma   Amrita   Kishore Tirumala.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\Master - Official Trailer  Thalapathy Vijay, Vijay Sethupathi  Lokesh Kanagaraj  Amazon Prime Video.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void rrrButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\RRR Official Trailer (Hindi) India’s Biggest Action Drama   NTR,RamCharan,AjayD,AliaB   SS Rajamouli.mp4";
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void vikramButton_Click(object sender, EventArgs e)
        {
            PlayMovies playMovies = new PlayMovies();

            string movieFilePath = "D:\\Netflix Videos\\VIKRAM - Official Trailer   Kamal Haasan   VijaySethupathi, FahadhFaasil   LokeshKanagaraj   Anirudh.mp4"; 
            playMovies.playMovie(movieFilePath);

            playMovies.Show();
            
        }

    }
}
