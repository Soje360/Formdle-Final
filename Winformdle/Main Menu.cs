using System.Security.Policy;

namespace Winformdle
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static int gameModePick = 0;
        public static int languagePick = 0;
        int score = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Undertale OST - Menu.wav";
            player.PlayLooping();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = true;

        }

        private void lblChooseDifficulty_Click(object sender, EventArgs e)
        {

        }

        //Difficulty
        //EASY
        private void btnEasy_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {

                pnlUnliAttemptConfirmation.Visible = true;
                pnlDifficulty.Visible = false;
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoEasy game1FilipinoEasy = new game1FilipinoEasy();
                game1FilipinoEasy.Show();
            }

            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishEasy game2EnglishEasy = new game2EnglishEasy();
                game2EnglishEasy.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoEasy game2FilipinoEasy = new game2FilipinoEasy();
                game2FilipinoEasy.Show();
            }

        }
        //MEDIUM
        private void btnMedium_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {
                this.Hide();
                game1EnglishMedium game1EnglishMedium = new game1EnglishMedium();
                game1EnglishMedium.Show();
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoMedium game1FilipinoMedium = new game1FilipinoMedium();
                game1FilipinoMedium.Show();
            }



            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishMedium game2EnglishMedium = new game2EnglishMedium();
                game2EnglishMedium.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoMedium game2FilipinoMedium = new game2FilipinoMedium();
                game2FilipinoMedium.Show();
            }

        }

        //HARD
        private void btnHard_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {
                this.Hide();
                game1EnglishHard game1EnglishHard = new game1EnglishHard();
                game1EnglishHard.Show();
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoHard game1FilipinoHard = new game1FilipinoHard();
                game1FilipinoHard.Show();
            }



            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishHard game2EnglishHard = new game2EnglishHard();
                game2EnglishHard.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoHard game2FilipinoHard = new game2FilipinoHard();
                game2FilipinoHard.Show();
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            languagePick = 1;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void btnTagalog_Click1(object sender, EventArgs e)
        {
            languagePick = 2;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void pnlLanguage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            gameModePick = 1;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible = false;
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            gameModePick = 2;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible = false;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackDifficulty_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = false;
        }

        private void btnBackGameMode_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = true;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = false;
        }

        private void btnBackLanguage_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = true;
        }

        private void btnBackAbout_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = true;
            pnlAbout.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlAbout.Visible = true;
        }

        private void btnUnliAttemptConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameModeUnlimited gameModeUnlimited = new gameModeUnlimited();
            gameModeUnlimited.Show();
        }

        private void btnUnliAttemptDecline_Click(object sender, EventArgs e)
        {
            this.Hide();
            game1EnglishEasy game1EnglishEasy = new game1EnglishEasy();
            game1EnglishEasy.Show();
        }

        private void btnUnliAttemptBack_Click(object sender, EventArgs e)
        {
            pnlDifficulty.Visible = true;
            pnlUnliAttemptConfirmation.Visible = false;
        }
    }
}
