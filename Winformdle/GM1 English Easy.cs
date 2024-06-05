﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.DataFormats;

namespace Winformdle
{

    public partial class game1EnglishEasy : Form
    {
        //CHECKS WHAT ATTEMPT THE USER IS IN
        public static bool attempt1 = true;
        public static bool attempt2 = false;
        public static bool attempt3 = false;
        public static bool attempt4 = false;
        public static bool attempt5 = false;
        public static bool attempt6 = false;


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


        public static Dictionary<char, Button> letterButtons { get; private set; }


        public game1EnglishEasy()
        {
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

        //WHEN USER CLICKS Q BUTTON
        private void qBtn_Click(object sender, EventArgs e)
        {
            //attempt1 
            Inputkey("Q");

        }
        //WHEN USER CLICKS W BUTTON
        private void wBtn_Click(object sender, EventArgs e)
        {
            Inputkey("W");
        }
        //WHEN USER CLICKS E BUTTON
        private void eBtn_Click(object sender, EventArgs e)
        {
            Inputkey("E");
        }
        //WHEN USER CLICKS R BUTTON
        private void rBtn_Click(object sender, EventArgs e)
        {
            Inputkey("R");
        }
        //WHEN USER CLICKS T BUTTON
        private void tBtn_Click(object sender, EventArgs e)
        {
            Inputkey("T");
        }
        //WHEN USER CLICKS Y BUTTON
        private void yBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Y");
        }
        //WHEN USER CLICKS U BUTTON
        private void uBtn_Click(object sender, EventArgs e)
        {
            Inputkey("U");
        }
        //WHEN USER CLICKS I BUTTON
        private void iBtn_Click(object sender, EventArgs e)
        {
            Inputkey("I");
        }
        //WHEN USER CLICKS O BUTTON
        private void oBtn_Click(object sender, EventArgs e)
        {
            Inputkey("O");
        }
        //WHEN USER CLICKS P BUTTON
        private void pBtn_Click(object sender, EventArgs e)
        {
            Inputkey("P");
        }
        //WHEN USER CLICKS A BUTTON
        private void aBtn_Click(object sender, EventArgs e)
        {
            Inputkey("A");
        }
        //WHEN USER CLICKS S BUTTON
        private void sBtn_Click(object sender, EventArgs e)
        {
            Inputkey("S");
        }
        //WHEN USER CLICKS D BUTTON
        private void dBtn_Click(object sender, EventArgs e)
        {
            Inputkey("D");
        }
        //WHEN USER CLICKS F BUTTON
        private void fBtn_Click(object sender, EventArgs e)
        {
            Inputkey("F");
        }
        //WHEN USER CLICKS G BUTTON
        private void gBtn_Click(object sender, EventArgs e)
        {
            Inputkey("G");
        }
        //WHEN USER CLICKS H BUTTON
        private void hBtn_Click(object sender, EventArgs e)
        {
            Inputkey("H");
        }
        //WHEN USER CLICKS J BUTTON
        private void jBtn_Click(object sender, EventArgs e)
        {
            Inputkey("J");
        }
        //WHEN USER CLICKS K BUTTON
        private void kBtn_Click(object sender, EventArgs e)
        {
            Inputkey("K");
        }
        //WHEN USER CLICKS L BUTTON
        private void lBtn_Click(object sender, EventArgs e)
        {
            Inputkey("L");
        }
        //WHEN USER CLICKS Z BUTTON
        private void zBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Z");
        }
        //WHEN USER CLICKS X BUTTON
        private void xBtn_Click(object sender, EventArgs e)
        {
            Inputkey("X");
        }
        //WHEN USER CLICKS C BUTTON
        private void cBtn_Click(object sender, EventArgs e)
        {
            Inputkey("C");
        }
        //WHEN USER CLICKS V BUTTON
        private void vBtn_Click(object sender, EventArgs e)
        {
            Inputkey("V");
        }
        //WHEN USER CLICKS B BUTTON
        private void bBtn_Click(object sender, EventArgs e)
        {
            Inputkey("B");
        }
        //WHEN USER CLICKS N BUTTON
        private void nBtn_Click(object sender, EventArgs e)
        {
            Inputkey("N");
        }
        //WHEN USER CLICKS M BUTTON
        private void mBtn_Click(object sender, EventArgs e)
        {
            Inputkey("M");
        }
        //WHEN USER CLICKS BACKSPACE BUTTON
        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            Remove_Character.GM1EnglishRemoveCharEasy();
        }

        //WHEN USER CLICKS ENTER BUTTON
        public async void enterBtn_Click(object sender, EventArgs e)
        {
            //attempt1
            if (attempt1)
            {
                string attemptWord = attempt1Char1.Text + attempt1Char2.Text + attempt1Char3.Text + attempt1Char4.Text + attempt1Char5.Text;
                if (attemptWord.Length == 5)
                {
                    Colors.GM1EnglishEasyCheck1();
                    if (attemptWord == guessWord)
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
                string attemptWord = attempt2Char1.Text + attempt2Char2.Text + attempt2Char3.Text + attempt2Char4.Text + attempt2Char5.Text;
                if (attemptWord.Length == 5)
                {

                    Colors.GM1EnglishEasyCheck2();
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
                        attempt2 = false;
                        attempt3 = true;
                    }
                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
            //attempt3
            else if (attempt3)
            {
                string attemptWord = attempt3Char1.Text + attempt3Char2.Text + attempt3Char3.Text + attempt3Char4.Text + attempt3Char5.Text;
                if (attemptWord.Length == 5)
                {
                    Colors.GM1EnglishEasyCheck3();
                    if (attemptWord == guessWord)
                    {
                        await Task.Delay(2500);
                        var win = new WinScreen(guessWord);
                        this.Hide();
                        win.Show();
                        attempt1 = true;
                        attempt3 = false;
                    }
                    else
                    {
                        attempt3 = false;
                        attempt4 = true;
                    }
                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
            //attempt4
            else if (attempt4)
            {
                string attemptWord = attempt4Char1.Text + attempt4Char2.Text + attempt4Char3.Text + attempt4Char4.Text + attempt4Char5.Text;
                if (attemptWord.Length == 5)
                {
                    Colors.GM1EnglishEasyCheck4();
                    if (attemptWord == guessWord)
                    {
                        await Task.Delay(2500);
                        var win = new WinScreen(guessWord);
                        this.Hide();
                        win.Show();
                        attempt1 = true;
                        attempt4 = false;
                    }
                    else
                    {
                        attempt4 = false;
                        attempt5 = true;
                    }
                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
            //attempt5
            else if (attempt5)
            {
                string attemptWord = attempt5Char1.Text + attempt5Char2.Text + attempt5Char3.Text + attempt5Char4.Text + attempt5Char5.Text;
                if (attemptWord.Length == 5)
                {

                    Colors.GM1EnglishEasyCheck5();
                    if (attemptWord == guessWord)
                    {
                        await Task.Delay(2500);
                        var win = new WinScreen(guessWord);
                        this.Hide();
                        win.Show();
                        attempt1 = true;
                        attempt5 = false;
                    }
                    else
                    {
                        attempt5 = false;
                        attempt6 = true;
                    }
                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
            //attempt6
            else if (attempt6)
            {
                string attemptWord = attempt6Char1.Text + attempt6Char2.Text + attempt6Char3.Text + attempt6Char4.Text + attempt6Char5.Text;
                if (attemptWord.Length == 5)
                {

                    Colors.GM1EnglishEasyCheck6();
                    if (attemptWord == guessWord)
                    {
                        await Task.Delay(2500);
                        var win = new WinScreen(guessWord);
                        this.Hide();
                        win.Show();
                        attempt1 = true;
                        attempt6 = false;
                    }
                    else
                    {
                        await Task.Delay(2500);
                        loseScreen LoseScreen = new loseScreen(guessWord);
                        this.Hide();
                        LoseScreen.Show();
                        attempt1 = true;
                        attempt6 = false;
                    }
                }
                else
                {
                    MessageBox.Show("User input insufficient, the word must consist of five(5) characters!. ");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void attempt1Char1_TextChanged(object sender, EventArgs e)
        {

        }

        //INPUTKEY METHOD
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

            else if (attempt3)
            {
                //attempt3 
                if (attempt3Char1.Text == "")
                {
                    attempt3Char1.Text = a;
                }
                else if (attempt3Char2.Text == "" && attempt3Char1.Text != "")
                {
                    attempt3Char2.Text = a;
                }
                else if (attempt3Char3.Text == "" && attempt3Char2.Text != "")
                {
                    attempt3Char3.Text = a;
                }
                else if (attempt3Char4.Text == "" && attempt3Char3.Text != "")
                {
                    attempt3Char4.Text = a;
                }
                else if (attempt3Char5.Text == "" && attempt3Char4.Text != "")
                {
                    attempt3Char5.Text = a;
                }
            }//endif attempt 3

            else if (attempt4)
            {
                //attempt4 
                if (attempt4Char1.Text == "")
                {
                    attempt4Char1.Text = a;
                }
                else if (attempt4Char2.Text == "" && attempt4Char1.Text != "")
                {
                    attempt4Char2.Text = a;
                }
                else if (attempt4Char3.Text == "" && attempt4Char2.Text != "")
                {
                    attempt4Char3.Text = a;
                }
                else if (attempt4Char4.Text == "" && attempt4Char3.Text != "")
                {
                    attempt4Char4.Text = a;
                }
                else if (attempt4Char5.Text == "" && attempt4Char4.Text != "")
                {
                    attempt4Char5.Text = a;
                }
            }//endif attempt 4

            else if (attempt5)
            {
                //attempt5 
                if (attempt5Char1.Text == "")
                {
                    attempt5Char1.Text = a;
                }
                else if (attempt5Char2.Text == "" && attempt5Char1.Text != "")
                {
                    attempt5Char2.Text = a;
                }
                else if (attempt5Char3.Text == "" && attempt5Char2.Text != "")
                {
                    attempt5Char3.Text = a;
                }
                else if (attempt5Char4.Text == "" && attempt5Char3.Text != "")
                {
                    attempt5Char4.Text = a;
                }
                else if (attempt5Char5.Text == "" && attempt5Char4.Text != "")
                {
                    attempt5Char5.Text = a;
                }
            }//endif attempt 5

            else if (attempt6)
            {
                //attempt6 
                if (attempt6Char1.Text == "")
                {
                    attempt6Char1.Text = a;
                }
                else if (attempt6Char2.Text == "" && attempt6Char1.Text != "")
                {
                    attempt6Char2.Text = a;
                }
                else if (attempt6Char3.Text == "" && attempt6Char2.Text != "")
                {
                    attempt6Char3.Text = a;
                }
                else if (attempt6Char4.Text == "" && attempt6Char3.Text != "")
                {
                    attempt6Char4.Text = a;
                }
                else if (attempt6Char5.Text == "" && attempt6Char4.Text != "")
                {
                    attempt6Char5.Text = a;
                }
            }//endif attempt 6

        }//method end

        private void game1EnglishEasy_Load(object sender, EventArgs e)
        {
            //resets the guess word
            Random random = new Random();
            randomGuessWord = random.Next(wordInventory.Count);
            guessWord = wordInventory[randomGuessWord];

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "Undertale OST - Hotel.wav";
            player.PlayLooping();
        }

        private void game1EnglishEasy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlConfirmation.Visible = true;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlOptions.Visible = true;
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

        private void panel1_Click(object sender, EventArgs e)
        {
            btnShowIndex.Visible = true;
            btnShowLastElement.Visible = true;
        }

        private void btnShowIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wordInventory.Count().ToString());
        }

        private void btnShowLastElement_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wordInventory.Last().ToString());
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            btnShowIndex.Visible = false;
            btnShowLastElement.Visible = false;
        }

        private void pnlConfirmation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
