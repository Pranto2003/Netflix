using System;
using System.CodeDom;
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
    public partial class PremiumUsersHome : Form
    {
        public PremiumUsersHome()
        {
            InitializeComponent();
        }

        private void PremiumUsersHome_Load(object sender, EventArgs e)
        {

        }

        private void returnButtonPremiumHome_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void vikramButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\VIKRAM - Official Trailer   Kamal Haasan   VijaySethupathi, FahadhFaasil   LokeshKanagaraj   Anirudh.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Master - Official Trailer  Thalapathy Vijay, Vijay Sethupathi  Lokesh Kanagaraj  Amazon Prime Video.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void theRajaSaabButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\The Rajasaab - Title Announcement Video   Prabhas   Maruthi   Thaman S   People Media Factory.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void indianaButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Indiana Jones and the Dial of Destiny   Official Trailer.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void article15Button_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Article 15 - Trailer   Ayushmann Khurrana   Anubhav Sinha   Releasing on 28June2019.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
           
        }

        private void runway34Button_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Runway 34 - Official Trailer   Rent Now On Prime Video Store   Amitabh Bachchan, Ajay Devgn, Rakul P.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void myNameIsKhanButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\My Name is KHAN - MNIK (Official International Trailer HD).mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void godfatherButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\THE GODFATHER   50th Anniversary Trailer   Paramount Pictures.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void socialNetworkButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\THE SOCIAL NETWORK - Official Trailer [2010] (HD).mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void topGunButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Top Gun Maverick   New Official Hindi Trailer (2022 Movie) - Tom Cruise.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void jumanjiNextButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\JUMANJI THE NEXT LEVEL - Official Trailer (HD).mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void jumanjiButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\JUMANJI WELCOME TO THE JUNGLE - Official Trailer (HD).mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void theLostCityButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\The Lost City   Official Trailer (2022 Movie) – Paramount Pictures.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void journey2Button_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Journey 2 The Mysterious Island Official Trailer #1 - Dwayne Johnson, Vanessa Hudgens (2012) HD.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void journeyButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Journey To The Center Of The Earth HD Trailer.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            this.Close();
        }

        private void kanguvaButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Kanguva - Glimpse   Suriya, Disha Patani   Devi Sri Prasad   Siva   Studio Green   UV Creations.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void kalkiButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();
            string movieFilePath = "D:\\Netflix Videos\\Kalki 2898 AD Glimpse   Prabhas   Amitabh Bachchan   Kamal Haasan   Deepika Padukone   Nag Ashwin.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void devaraButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Devara Part-1   Glimpse - Telugu - NTR   Koratala Siva   Anirudh   5 April 2024.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void blackAdamButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Black Adam – Official Trailer 1.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void missionImpossibleButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Mission Impossible – Dead Reckoning Part One   Official Trailer (2023 Movie) - Tom Cruise.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void avengersButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Marvel's The Avengers- Trailer (OFFICIAL).mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void monkeyManButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Monkey Man   Official Trailer 2.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void sketchButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Sketch - Official Teaser   Chiyaan Vikram, Tamannaah   Vijay Chandar   Thaman SS.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void baahubaliButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Baahubali 2 - The Conclusion   Official Trailer (Hindi)   S.S. Rajamouli   Prabhas   Rana Daggubati.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void captainMillerButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Captain Miller - Hindi Trailer   Dhanush   Shiva Rajkumar   Arun Matheswaran   GV Prakash Kumar.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void pushpa2Button_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\PUSHPA 2 THE RULE (TEASER)   ALLU ARJUN   SUKUMAR   RASHMIKA MANDANNA   FAHADH FAASIL   DSP.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void code8PartIIButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Code 8 Part II   Official Trailer   Netflix.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
            
        }

        private void dunePartTwoButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Dune Part Two   Official Trailer.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
           
        }

        private void kungFuPandaButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\KUNG FU PANDA 4   Official Trailer.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
           
        }

        private void godzillaxKongButton_Click(object sender, EventArgs e)
        {
            PlayMoviesForPremium playMovies = new PlayMoviesForPremium();

            string movieFilePath = "D:\\Netflix Videos\\Godzilla x Kong The New Empire   Official Trailer 2.mp4";
            playMovies.PlayMovie(movieFilePath);

            playMovies.Show();
           
        }

        private void searchButon_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToUpper();

            switch (searchText)
            {
                case "GODZILA X KONG":
                case "GODZILA X KONG : THE NEW EMPIRE ":
                    if (MessageBox.Show("Do you want to play GODZILA X KONG?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        godzillaxKongButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "KUNG FU PANDA 4":
                    if (MessageBox.Show("Do you want to play KUNG FU PANDA 4?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kungFuPandaButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "DUNE PART 2":
                case "DUNE PART TWO":
                    if (MessageBox.Show("Do you want to play DUNE PART 2?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dunePartTwoButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "CODE 8 PART 2":
                    if (MessageBox.Show("Do you want to play CODE 8 PART 2?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                          code8PartIIButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "PUSHPA 2":
                case "PUSHPA 2 THE RULE":
                    if (MessageBox.Show("Do you want to play PUSHPA 2?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        pushpa2Button_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "VIKRAM":
                    if (MessageBox.Show("Do you want to play Vikram?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        vikramButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "THE AVENGERS":
                    if (MessageBox.Show("Do you want to play THE AVENGERS?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        avengersButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "MONKEY MAN":
                    if (MessageBox.Show("Do you want to play MONKEY MAN?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       monkeyManButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "SKETCH":
                    if (MessageBox.Show("Do you want to play SKETCH", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sketchButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "BAAHUBALI":
                    if (MessageBox.Show("Do you want to play BAAHUBALI?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        baahubaliButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "CAPTAIN MILLER":
                    if (MessageBox.Show("Do you want to play CAPTAIN MILLER?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        captainMillerButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "MASTER":
                    if (MessageBox.Show("Do you want to play Master?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        masterButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "MISSION IMPOSSIBLE":
                    if (MessageBox.Show("Do you want to play MISSION IMPOSSIBLE?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        missionImpossibleButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "BLACK ADAM":
                    if (MessageBox.Show("Do you want to play BLACK ADAM?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        blackAdamButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "DEVARA PART 1":
                    if (MessageBox.Show("Do you want to play DEVARA PART 1?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        devaraButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "KALKI":
                case "KALKI 2898 AD":
                    if (MessageBox.Show("Do you want to play KALKI 2898 AD?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kalkiButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "KANGUVA":
                    if (MessageBox.Show("Do you want to play KANGUVA?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        kanguvaButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "THE RAJA SAAB":
                    if (MessageBox.Show("Do you want to play THE RAJA SAAB?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        theRajaSaabButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "JOURNEY TO THE CENTER OF THE EARTH":
                    if (MessageBox.Show("Do you want to play JOURNEY TO THE CENTER OF THE EARTH?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        journeyButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "JOURNEY 2":
                    if (MessageBox.Show("Do you want to play JOURNEY 2?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        journey2Button_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "THE LOST CITY":
                    if (MessageBox.Show("Do you want to play THE LOST CITY?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        theLostCityButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "JUMMANJI : WELCOME TO THE JUNGLE":
                    if (MessageBox.Show("Do you want to play JUMMANJI : WELCOME TO THE JUNGLE?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        jumanjiButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "JUMMANJI THE NEXT":
                    if (MessageBox.Show("Do you want to play JUMMANJI THE NEXT : WELCOME TO THE JUNGLE?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        jumanjiNextButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "INDIANA JONES":
                    if (MessageBox.Show("Do you want to play INDIANA JONES?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        indianaButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "TOP GUN : MAVERICK":
                    if (MessageBox.Show("Do you want to play TOP GUN : MAVERICK?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        topGunButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "THE SOCIAL NETWORK":
                    if (MessageBox.Show("Do you want to play THE SOCIAL NETWORK?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        socialNetworkButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "THE GODFATHER":
                    if (MessageBox.Show("Do you want to play THE GODFATHER?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        godfatherButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "MY NAME IS KHAN":
                    if (MessageBox.Show("Do you want to play MY NAME IS KHAN?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        myNameIsKhanButton_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "RUNWAY 34":
                    if (MessageBox.Show("Do you want to play RUNWAY 34?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        runway34Button_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                case "ARTICLE 15":
                    if (MessageBox.Show("Do you want to play ARTICLE 15?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        article15Button_Click(sender, e);
                    }
                    else
                    {
                        searchTextBox.Text = "";
                    }
                    break;
                default:
                    MessageBox.Show("Movie not found.");
                    break;
            }
        }
    }
}
