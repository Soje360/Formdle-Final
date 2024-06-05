using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Winformdle
{
    public partial class gameModeUnlimited : Form
    {
        //CHECKS WHAT ATTEMPT THE USER IS IN
        public static bool attempt1 = true;
        public static bool attempt2 = false;
        public static List<string> wordInventory = new List<string>() { "AMBER", "ALERT", "ACNES", "AVERT", "AVIAN", "AVOID", "AMAZE", "AVAST", "AGILE",
        "BLAZE", "BLISS", "BRAID", "BRISK", "BERRY", "BRAVE", "BARGE", "BEACH", "BEARS", "BEGAN",
        "CRISP", "CRANE", "CLOAK", "CIDER", "CHAIN", "CABAL", "CABIN", "CACHE", "CADET", "CADRE",
        "DWELL", "DELUX", "DRAKE", "DIVER", "DWELL", "DWINE", "DOWER", "DRINK", "DROWN", "DRIFT",
        "ELBOW", "EMAIL", "ENJOY", "EMPTY", "EAGLE", "EVOKE", "ENDED", "ELITE", "ENEMY", "EAGER",
        "FROWN", "FLUTE", "FLAME", "FLOCK", "FROST", "FAINT", "FABLE", "FLARE", "FLUSH",
        "GRASP", "GRACE", "GREET", "GRAND", "GAMMA", "GLIDE", "GLARE", "GLAZE",
        "HORSE", "HASTE", "HEART", "HEXED", "HEART", "HORSE", "HEXED", "HINGE", "HEART",
        "INERT", "IVORY", "ISSUE", "ICYTH", "INKED", "ISSUE", "ICING", "ICONS", "INDEX", "IMAGE",
        "JOLLY", "JUMBO", "JAPAN", "JOKER", "JOINT", "JEANS", "JUDGE", "JOWAR", "JOCKY", "JUICY",
        "KNEAD", "KITES", "KAYAK", "KNIFE", "KNOCK", "KILOS", "KNIFE", "KILLS", "KOALA",
        "LADLE", "LABOR", "LURCH", "LAPSE", "LATCH", "LEMON", "LABLE", "LAPSE", "LATCH", "LIONS",
        "MAPLE", "MOOSE", "MIGHT", "MACHO", "MAGIC", "MAPLE", "MIGHT", "MADLY", "MADAM",
        "NAKED", "NANNY", "NASTY", "NASAL", "NIFTY", "NAIVE", "NIXON", "NACHO", "NERVE",
        "OLIVE", "OBESE", "OASIS", "ONION", "OCEAN", "OMEGA", "OUGHT", "OUTDO", "OXIDE", "OWNER",
        "PLAID", "PABLO", "PARTY", "PATCH", "PIXEL", "PEARL", "PEACE", "PEACH", "PITCH", "PHOTO",
        "QUART", "QUEEN", "QUERY", "QUACK", "QUASI", "QUAIL", "QUICK", "QUIRK",
        "RELAY", "RADAR", "RIDER", "RUGBY", "RABID", "RAILS", "RACER", "RIDGE", "ROUTE", "ROYAL",
        "SWEEP", "SWIFT", "SABER", "SHOES", "SALAD", "SALES", "SACKS", "SADLY", "SAFER",
        "TWIST", "TRACE", "TRUTH", "TREAT", "THANK", "TROOP", "TOUGH", "THUMB", "TRAIT", "THICK",
        "USUAL", "UNCLE", "UPTON", "ULCER", "UNFIT", "UNIFY", "UNDER", "ULTRA", "UNIFY", "UNCUT",
        "VOWEL", "VAGUE", "VAPOR", "VASES", "VALID", "VIDEO", "VOICE", "VIVID", "VOMIT",
        "WACKY", "WOVEN", "WORTH", "WHISK", "WAFER", "WORTH", "WEIGH", "WHOOP", "WIPED", "WOMEN",
        "XENON", "XEROX", "YACHT", "YAHOO", "ZEBRA", "ZEALS", "ZONED", "ZOOTY", "ZESTY" };

        //Guessword Randomizer
        public static Random random = new Random();
        public static int randomGuessWord;
        public static string guessWord;
        public static string attemptWord;
        public static Dictionary<char, Button> letterButtons { get; private set; }


        public gameModeUnlimited()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            letterButtons = new Dictionary<char, Button>
            {
                {'A', aBtn},
                {'B', bBtn},
                {'C', cBtn},
                {'D', dBtn},
                {'E', eBtn},
                {'F', fBtn},
                {'G', gBtn},
                {'H', hBtn},
                {'I', iBtn},
                {'J', jBtn},
                {'K', kBtn},
                {'L', lBtn},
                {'M', mBtn},
                {'N', nBtn},
                {'O', oBtn},
                {'P', pBtn},
                {'Q', qBtn},
                {'R', rBtn},
                {'S', sBtn},
                {'T', tBtn},
                {'U', uBtn},
                {'V', vBtn},
                {'W', wBtn},
                {'X', xBtn},
                {'Y', yBtn},
                {'Z', zBtn}
            };
        }
        private void Inputkey(string a)
        {
            if (attempt1)
            {
                //attempt1 
                if (attempt1Char1.Text == "")
                {
                    attempt1Char1.Text = a;
                }
                else if (attempt1Char2.Text == "" && attempt1Char1.Text != "")
                {
                    attempt1Char2.Text = a;
                }
                else if (attempt1Char3.Text == "" && attempt1Char2.Text != "")
                {
                    attempt1Char3.Text = a;
                }
                else if (attempt1Char4.Text == "" && attempt1Char3.Text != "")
                {
                    attempt1Char4.Text = a;
                }
                else if (attempt1Char5.Text == "" && attempt1Char4.Text != "")
                {
                    attempt1Char5.Text = a;
                }
            }//endif attempt 1

            else if (attempt2)
            {
                //attempt2 
                if (attempt2Char1.Text == "")
                {
                    attempt2Char1.Text = a;
                }
                else if (attempt2Char2.Text == "" && attempt2Char1.Text != "")
                {
                    attempt2Char2.Text = a;
                }
                else if (attempt2Char3.Text == "" && attempt2Char2.Text != "")
                {
                    attempt2Char3.Text = a;
                }
                else if (attempt2Char4.Text == "" && attempt2Char3.Text != "")
                {
                    attempt2Char4.Text = a;
                }
                else if (attempt2Char5.Text == "" && attempt2Char4.Text != "")
                {
                    attempt2Char5.Text = a;
                }
            }//endif attempt 2
        }
        private void gameModeUnlimited_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gameModeUnlimited_Load(object sender, EventArgs e)
        {
            //resets the guess word
            Random random = new Random();
            randomGuessWord = random.Next(wordInventory.Count);
            //guessWord = wordInventory[randomGuessWord];
            guessWord = "NIGGA";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Undertale OST - Hotel.wav";
            player.PlayLooping();
        }

        private void qBtn_Click_1(object sender, EventArgs e)
        {
            Inputkey("Q");
        }

        private void wBtn_Click(object sender, EventArgs e)
        {
            Inputkey("W");
        }

        private void eBtn_Click(object sender, EventArgs e)
        {
            Inputkey("E");
        }

        private void rBtn_Click(object sender, EventArgs e)
        {
            Inputkey("R");
        }

        private void tBtn_Click(object sender, EventArgs e)
        {
            Inputkey("T");
        }

        private void yBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Y");
        }

        private void uBtn_Click(object sender, EventArgs e)
        {
            Inputkey("U");
        }

        private void iBtn_Click(object sender, EventArgs e)
        {
            Inputkey("I");
        }

        private void oBtn_Click(object sender, EventArgs e)
        {
            Inputkey("O");
        }

        private void pBtn_Click(object sender, EventArgs e)
        {
            Inputkey("P");
        }

        private void aBtn_Click(object sender, EventArgs e)
        {
            Inputkey("A");
        }

        private void sBtn_Click(object sender, EventArgs e)
        {
            Inputkey("S");
        }

        private void dBtn_Click(object sender, EventArgs e)
        {
            Inputkey("D");
        }

        private void fBtn_Click(object sender, EventArgs e)
        {
            Inputkey("F");
        }

        private void gBtn_Click(object sender, EventArgs e)
        {
            Inputkey("G");
        }

        private void hBtn_Click(object sender, EventArgs e)
        {
            Inputkey("H");
        }

        private void jBtn_Click(object sender, EventArgs e)
        {
            Inputkey("J");
        }

        private void kBtn_Click(object sender, EventArgs e)
        {
            Inputkey("K");
        }

        private void lBtn_Click(object sender, EventArgs e)
        {
            Inputkey("L");
        }

        private void zBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Z");
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Inputkey("X");
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            Inputkey("C");
        }

        private void vBtn_Click(object sender, EventArgs e)
        {
            Inputkey("V");
        }

        private void bBtn_Click(object sender, EventArgs e)
        {
            Inputkey("B");
        }

        private void nBtn_Click(object sender, EventArgs e)
        {
            Inputkey("N");
        }

        private void mBtn_Click(object sender, EventArgs e)
        {
            Inputkey("M");
        }
        public async void enterBtn_Click_1(object sender, EventArgs e)
        {
            string attemptWord1 = attempt1Char1.Text + attempt1Char2.Text + attempt1Char3.Text + attempt1Char4.Text + attempt1Char5.Text;
            //attempt1
            if (attempt1)
            {
                if (attemptWord1.Length == 5)
                {
                    Colors.GMUnlimited();
                    if (attemptWord1 == guessWord)
                    {
                        await Task.Delay(2500);
                        var winScreen = new WinScreen(guessWord);
                        this.Hide();
                        winScreen.Show();
                        attempt1 = true;
                    }
                    else
                    {
                        attempt1 = false;
                        attempt2 = true;
                    }

                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
            //attempt2
            else if (attempt2)
            {
                do
                {
                    attemptWord = attempt2Char1.Text + attempt2Char2.Text + attempt2Char3.Text + attempt2Char4.Text + attempt2Char5.Text;
                    if (attemptWord.Length == 5)
                    {
                        Colors.GMUnlimited2();
                        if (attemptWord == guessWord)
                        {
                            await Task.Delay(2500);
                            var win = new WinScreen(guessWord);
                            this.Hide();
                            win.Show();
                            attempt1 = true;
                            attempt2 = false;
                        }
                        else
                        {
                            await Task.Delay(2500);
                            attempt1Char1.Text = attempt2Char1.Text;
                            attempt1Char2.Text = attempt2Char2.Text;
                            attempt1Char3.Text = attempt2Char3.Text;
                            attempt1Char4.Text = attempt2Char4.Text;
                            attempt1Char5.Text = attempt2Char5.Text;
                            attempt1Char1.BackColor = attempt2Char1.BackColor;
                            attempt1Char2.BackColor = attempt2Char2.BackColor;
                            attempt1Char3.BackColor = attempt2Char3.BackColor;
                            attempt1Char4.BackColor = attempt2Char4.BackColor;
                            attempt1Char5.BackColor = attempt2Char5.BackColor;
                            attempt2Char1.ResetText();
                            attempt2Char1.ResetText();
                            attempt2Char2.ResetText();
                            attempt2Char3.ResetText();
                            attempt2Char4.ResetText();
                            attempt2Char5.ResetText();
                            attempt2Char1.BackColor = Color.White;
                            attempt2Char2.BackColor = Color.White;
                            attempt2Char3.BackColor = Color.White;
                            attempt2Char4.BackColor = Color.White;
                            attempt2Char5.BackColor = Color.White;
                            break;
                        }
                    }
                    else if (attemptWord.Length < 5)
                    {
                        continue;
                        MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");

                    }
                }
                while (attemptWord.Length > 0);
            }
        }



        private void backspaceBtn_Click_1(object sender, EventArgs e)
        {
            Remove_Character.GMUnlimited();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlOptions.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = true;
            pnlConfirmation.Visible = false;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            pnlConfirmation.Visible = true;
            pnlOptions.Visible = false;
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            pnlAddWord.Visible = true;
            pnlOptions.Visible = false;
        }

        private void btnBackOptions_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = true;
            pnlOptions.Visible = false;
        }

        private void btnAddWordBack_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = true;
            pnlAddWord.Visible = false;
        }

        private void btnAddWordConfirm_Click(object sender, EventArgs e)
        {
            string invalidInput = " 1234567890`~-=_+!@#$%^&*()[]{} \\| \' \" ;:,<.> ";

            bool invalid = false;
            foreach (char c in invalidInput)
            {
                if (txtAddWord.Text.Contains(c))
                {
                    invalid = true;
                    break;
                }
            }
            if (invalid)
            {
                MessageBox.Show("Invalid input, the word must only contain letters!");
            }
            else
            {
                if (txtAddWord.Text.Length == 5)
                {
                    guessWord = txtAddWord.Text.ToUpper();
                    wordInventory.Add(guessWord);
                    MessageBox.Show("A new word has been added into the word inventory!");
                    pnlOptions.Visible = true;
                    pnlAddWord.Visible = false;
                    Random random = new Random();
                    randomGuessWord = random.Next(wordInventory.Count);
                    guessWord = wordInventory[randomGuessWord];
                }
                else
                {
                    MessageBox.Show("Insufficient characters, the word must contain five(5) characters.");
                }
            }
        }
    }
}