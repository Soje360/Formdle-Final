using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winformdle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Winformdle
{
    internal class Colors
    {
        //GAMEMODE 1 ENGLISH, EASY UNLI ATTEMPTS
        public static async void GMUnlimited()
        {
            string attemptWord = gameModeUnlimited.attempt1Char1.Text + gameModeUnlimited.attempt1Char2.Text + gameModeUnlimited.attempt1Char3.Text + gameModeUnlimited.attempt1Char4.Text + gameModeUnlimited.attempt1Char5.Text;
            string guessWord = gameModeUnlimited.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { gameModeUnlimited.attempt1Char1, gameModeUnlimited.attempt1Char2, gameModeUnlimited.attempt1Char3, gameModeUnlimited.attempt1Char4, gameModeUnlimited.attempt1Char5 };

            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
                if (result[i] == 'X')
                {
                    result[i] = 'D';  // Dark Gray
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (gameModeUnlimited.letterButtons.ContainsKey(keyboardLetter))
                {
                    gameModeUnlimited.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GMUnlimited2()
        {
            string attemptWord = gameModeUnlimited.attempt2Char1.Text + gameModeUnlimited.attempt2Char2.Text + gameModeUnlimited.attempt2Char3.Text + gameModeUnlimited.attempt2Char4.Text + gameModeUnlimited.attempt2Char5.Text;
            string guessWord = gameModeUnlimited.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { gameModeUnlimited.attempt2Char1, gameModeUnlimited.attempt2Char2, gameModeUnlimited.attempt2Char3, gameModeUnlimited.attempt2Char4, gameModeUnlimited.attempt2Char5 };

            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
                if (result[i] == 'X')
                {
                    result[i] = 'D';  // Dark Gray
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (gameModeUnlimited.letterButtons.ContainsKey(keyboardLetter))
                {
                    gameModeUnlimited.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }

        //GAMEMODE 1 ENGLISH, EASY
        public static async void GM1EnglishEasyCheck1()
        {
            string attemptWord = game1EnglishEasy.attempt1Char1.Text + game1EnglishEasy.attempt1Char2.Text + game1EnglishEasy.attempt1Char3.Text + game1EnglishEasy.attempt1Char4.Text + game1EnglishEasy.attempt1Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1EnglishEasy.attempt1Char1, game1EnglishEasy.attempt1Char2, game1EnglishEasy.attempt1Char3, game1EnglishEasy.attempt1Char4, game1EnglishEasy.attempt1Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishEasyCheck2()
        {
            string attemptWord = game1EnglishEasy.attempt2Char1.Text + game1EnglishEasy.attempt2Char2.Text + game1EnglishEasy.attempt2Char3.Text + game1EnglishEasy.attempt2Char4.Text + game1EnglishEasy.attempt2Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishEasy.attempt2Char1, game1EnglishEasy.attempt2Char2, game1EnglishEasy.attempt2Char3, game1EnglishEasy.attempt2Char4, game1EnglishEasy.attempt2Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishEasyCheck3()
        {
            string attemptWord = game1EnglishEasy.attempt3Char1.Text + game1EnglishEasy.attempt3Char2.Text + game1EnglishEasy.attempt3Char3.Text + game1EnglishEasy.attempt3Char4.Text + game1EnglishEasy.attempt3Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishEasy.attempt3Char1, game1EnglishEasy.attempt3Char2, game1EnglishEasy.attempt3Char3, game1EnglishEasy.attempt3Char4, game1EnglishEasy.attempt3Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishEasyCheck4()
        {
            string attemptWord = game1EnglishEasy.attempt4Char1.Text + game1EnglishEasy.attempt4Char2.Text + game1EnglishEasy.attempt4Char3.Text + game1EnglishEasy.attempt4Char4.Text + game1EnglishEasy.attempt4Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishEasy.attempt4Char1, game1EnglishEasy.attempt4Char2, game1EnglishEasy.attempt4Char3, game1EnglishEasy.attempt4Char4, game1EnglishEasy.attempt4Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishEasyCheck5()
        {
            string attemptWord = game1EnglishEasy.attempt5Char1.Text + game1EnglishEasy.attempt5Char2.Text + game1EnglishEasy.attempt5Char3.Text + game1EnglishEasy.attempt5Char4.Text + game1EnglishEasy.attempt5Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishEasy.attempt5Char1, game1EnglishEasy.attempt5Char2, game1EnglishEasy.attempt5Char3, game1EnglishEasy.attempt5Char4, game1EnglishEasy.attempt5Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishEasyCheck6()
        {
            string attemptWord = game1EnglishEasy.attempt6Char1.Text + game1EnglishEasy.attempt6Char2.Text + game1EnglishEasy.attempt6Char3.Text + game1EnglishEasy.attempt6Char4.Text + game1EnglishEasy.attempt6Char5.Text;
            string guessWord = game1EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishEasy.attempt6Char1, game1EnglishEasy.attempt6Char2, game1EnglishEasy.attempt6Char3, game1EnglishEasy.attempt6Char4, game1EnglishEasy.attempt6Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }










        //GAMEMODE 1 ENGLISH MEDIUM
        public static async void GM1EnglishMediumCheck1()
        {
            string attemptWord = game1EnglishMedium.attempt1Char1.Text + game1EnglishMedium.attempt1Char2.Text + game1EnglishMedium.attempt1Char3.Text + game1EnglishMedium.attempt1Char4.Text + game1EnglishMedium.attempt1Char5.Text + game1EnglishMedium.attempt1Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1EnglishMedium.attempt1Char1, game1EnglishMedium.attempt1Char2, game1EnglishMedium.attempt1Char3, game1EnglishMedium.attempt1Char4, game1EnglishMedium.attempt1Char5, game1EnglishMedium.attempt1Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishMediumCheck2()
        {
            string attemptWord = game1EnglishMedium.attempt2Char1.Text + game1EnglishMedium.attempt2Char2.Text + game1EnglishMedium.attempt2Char3.Text + game1EnglishMedium.attempt2Char4.Text + game1EnglishMedium.attempt2Char5.Text + game1EnglishMedium.attempt2Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishMedium.attempt2Char1, game1EnglishMedium.attempt2Char2, game1EnglishMedium.attempt2Char3, game1EnglishMedium.attempt2Char4, game1EnglishMedium.attempt2Char5, game1EnglishMedium.attempt2Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishMediumCheck3()
        {
            string attemptWord = game1EnglishMedium.attempt3Char1.Text + game1EnglishMedium.attempt3Char2.Text + game1EnglishMedium.attempt3Char3.Text + game1EnglishMedium.attempt3Char4.Text + game1EnglishMedium.attempt3Char5.Text + game1EnglishMedium.attempt3Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishMedium.attempt3Char1, game1EnglishMedium.attempt3Char2, game1EnglishMedium.attempt3Char3, game1EnglishMedium.attempt3Char4, game1EnglishMedium.attempt3Char5, game1EnglishMedium.attempt3Char6};
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishMediumCheck4()
        {
            string attemptWord = game1EnglishMedium.attempt4Char1.Text + game1EnglishMedium.attempt4Char2.Text + game1EnglishMedium.attempt4Char3.Text + game1EnglishMedium.attempt4Char4.Text + game1EnglishMedium.attempt4Char5.Text + game1EnglishMedium.attempt4Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishMedium.attempt4Char1, game1EnglishMedium.attempt4Char2, game1EnglishMedium.attempt4Char3, game1EnglishMedium.attempt4Char4, game1EnglishMedium.attempt4Char5, game1EnglishMedium.attempt4Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishMediumCheck5()
        {
            string attemptWord = game1EnglishMedium.attempt5Char1.Text + game1EnglishMedium.attempt5Char2.Text + game1EnglishMedium.attempt5Char3.Text + game1EnglishMedium.attempt5Char4.Text + game1EnglishMedium.attempt5Char5.Text + game1EnglishMedium.attempt5Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishMedium.attempt5Char1, game1EnglishMedium.attempt5Char2, game1EnglishMedium.attempt5Char3, game1EnglishMedium.attempt5Char4, game1EnglishMedium.attempt5Char5 , game1EnglishMedium.attempt5Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishMediumCheck6()
        {
            string attemptWord = game1EnglishMedium.attempt6Char1.Text + game1EnglishMedium.attempt6Char2.Text + game1EnglishMedium.attempt6Char3.Text + game1EnglishMedium.attempt6Char4.Text + game1EnglishMedium.attempt6Char5.Text + game1EnglishMedium.attempt6Char6.Text;
            string guessWord = game1EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishMedium.attempt6Char1, game1EnglishMedium.attempt6Char2, game1EnglishMedium.attempt6Char3, game1EnglishMedium.attempt6Char4, game1EnglishMedium.attempt6Char5 , game1EnglishMedium.attempt6Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }








        //GM1 ENGLISH HARD
        public static async void GM1EnglishHardCheck1()
        {
            string attemptWord = game1EnglishHard.attempt1Char1.Text + game1EnglishHard.attempt1Char2.Text + game1EnglishHard.attempt1Char3.Text + game1EnglishHard.attempt1Char4.Text + game1EnglishHard.attempt1Char5.Text + game1EnglishHard.attempt1Char6.Text + game1EnglishHard.attempt1Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1EnglishHard.attempt1Char1, game1EnglishHard.attempt1Char2, game1EnglishHard.attempt1Char3, game1EnglishHard.attempt1Char4, game1EnglishHard.attempt1Char5, game1EnglishHard.attempt1Char6, game1EnglishHard.attempt1Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishHardCheck2()
        {
            string attemptWord = game1EnglishHard.attempt2Char1.Text + game1EnglishHard.attempt2Char2.Text + game1EnglishHard.attempt2Char3.Text + game1EnglishHard.attempt2Char4.Text + game1EnglishHard.attempt2Char5.Text + game1EnglishHard.attempt2Char6.Text + game1EnglishHard.attempt2Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishHard.attempt2Char1, game1EnglishHard.attempt2Char2, game1EnglishHard.attempt2Char3, game1EnglishHard.attempt2Char4, game1EnglishHard.attempt2Char5, game1EnglishHard.attempt2Char6, game1EnglishHard.attempt2Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishHardCheck3()
        {
            string attemptWord = game1EnglishHard.attempt3Char1.Text + game1EnglishHard.attempt3Char2.Text + game1EnglishHard.attempt3Char3.Text + game1EnglishHard.attempt3Char4.Text + game1EnglishHard.attempt3Char5.Text + game1EnglishHard.attempt3Char6.Text + game1EnglishHard.attempt3Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishHard.attempt3Char1, game1EnglishHard.attempt3Char2, game1EnglishHard.attempt3Char3, game1EnglishHard.attempt3Char4, game1EnglishHard.attempt3Char5, game1EnglishHard.attempt3Char6, game1EnglishHard.attempt3Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishHardCheck4()
        {
            string attemptWord = game1EnglishHard.attempt4Char1.Text + game1EnglishHard.attempt4Char2.Text + game1EnglishHard.attempt4Char3.Text + game1EnglishHard.attempt4Char4.Text + game1EnglishHard.attempt4Char5.Text + game1EnglishHard.attempt4Char6.Text + game1EnglishHard.attempt4Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishHard.attempt4Char1, game1EnglishHard.attempt4Char2, game1EnglishHard.attempt4Char3, game1EnglishHard.attempt4Char4, game1EnglishHard.attempt4Char5, game1EnglishHard.attempt4Char6, game1EnglishHard.attempt4Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishHardCheck5()
        {
            string attemptWord = game1EnglishHard.attempt5Char1.Text + game1EnglishHard.attempt5Char2.Text + game1EnglishHard.attempt5Char3.Text + game1EnglishHard.attempt5Char4.Text + game1EnglishHard.attempt5Char5.Text + game1EnglishHard.attempt5Char6.Text + game1EnglishHard.attempt5Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishHard.attempt5Char1, game1EnglishHard.attempt5Char2, game1EnglishHard.attempt5Char3, game1EnglishHard.attempt5Char4, game1EnglishHard.attempt5Char5, game1EnglishHard.attempt5Char6, game1EnglishHard.attempt5Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1EnglishHardCheck6()
        {
            string attemptWord = game1EnglishHard.attempt6Char1.Text + game1EnglishHard.attempt6Char2.Text + game1EnglishHard.attempt6Char3.Text + game1EnglishHard.attempt6Char4.Text + game1EnglishHard.attempt6Char5.Text + game1EnglishHard.attempt6Char6.Text + game1EnglishHard.attempt6Char7.Text;
            string guessWord = game1EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1EnglishHard.attempt6Char1, game1EnglishHard.attempt6Char2, game1EnglishHard.attempt6Char3, game1EnglishHard.attempt6Char4, game1EnglishHard.attempt6Char5, game1EnglishHard.attempt6Char6, game1EnglishHard.attempt6Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }



        //GM1 FILIPINO EASY
        //GAMEMODE 1 ENGLISH, EASY
        public static async void GM1FilipinoEasyCheck1()
        {
            string attemptWord = game1FilipinoEasy.attempt1Char1.Text + game1FilipinoEasy.attempt1Char2.Text + game1FilipinoEasy.attempt1Char3.Text + game1FilipinoEasy.attempt1Char4.Text + game1FilipinoEasy.attempt1Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1FilipinoEasy.attempt1Char1, game1FilipinoEasy.attempt1Char2, game1FilipinoEasy.attempt1Char3, game1FilipinoEasy.attempt1Char4, game1FilipinoEasy.attempt1Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoEasyCheck2()
        {
            string attemptWord = game1FilipinoEasy.attempt2Char1.Text + game1FilipinoEasy.attempt2Char2.Text + game1FilipinoEasy.attempt2Char3.Text + game1FilipinoEasy.attempt2Char4.Text + game1FilipinoEasy.attempt2Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoEasy.attempt2Char1, game1FilipinoEasy.attempt2Char2, game1FilipinoEasy.attempt2Char3, game1FilipinoEasy.attempt2Char4, game1FilipinoEasy.attempt2Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoEasyCheck3()
        {
            string attemptWord = game1FilipinoEasy.attempt3Char1.Text + game1FilipinoEasy.attempt3Char2.Text + game1FilipinoEasy.attempt3Char3.Text + game1FilipinoEasy.attempt3Char4.Text + game1FilipinoEasy.attempt3Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoEasy.attempt3Char1, game1FilipinoEasy.attempt3Char2, game1FilipinoEasy.attempt3Char3, game1FilipinoEasy.attempt3Char4, game1FilipinoEasy.attempt3Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoEasyCheck4()
        {
            string attemptWord = game1FilipinoEasy.attempt4Char1.Text + game1FilipinoEasy.attempt4Char2.Text + game1FilipinoEasy.attempt4Char3.Text + game1FilipinoEasy.attempt4Char4.Text + game1FilipinoEasy.attempt4Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoEasy.attempt4Char1, game1FilipinoEasy.attempt4Char2, game1FilipinoEasy.attempt4Char3, game1FilipinoEasy.attempt4Char4, game1FilipinoEasy.attempt4Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoEasyCheck5()
        {
            string attemptWord = game1FilipinoEasy.attempt5Char1.Text + game1FilipinoEasy.attempt5Char2.Text + game1FilipinoEasy.attempt5Char3.Text + game1FilipinoEasy.attempt5Char4.Text + game1FilipinoEasy.attempt5Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoEasy.attempt5Char1, game1FilipinoEasy.attempt5Char2, game1FilipinoEasy.attempt5Char3, game1FilipinoEasy.attempt5Char4, game1FilipinoEasy.attempt5Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoEasyCheck6()
        {
            string attemptWord = game1FilipinoEasy.attempt6Char1.Text + game1FilipinoEasy.attempt6Char2.Text + game1FilipinoEasy.attempt6Char3.Text + game1FilipinoEasy.attempt6Char4.Text + game1FilipinoEasy.attempt6Char5.Text;
            string guessWord = game1FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoEasy.attempt6Char1, game1FilipinoEasy.attempt6Char2, game1FilipinoEasy.attempt6Char3, game1FilipinoEasy.attempt6Char4, game1FilipinoEasy.attempt6Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }




        //GM1 FILIPINO MEDIUM
        public static async void GM1FilipinoMediumCheck1()
        {
            string attemptWord = game1FilipinoMedium.attempt1Char1.Text + game1FilipinoMedium.attempt1Char2.Text + game1FilipinoMedium.attempt1Char3.Text + game1FilipinoMedium.attempt1Char4.Text + game1FilipinoMedium.attempt1Char5.Text + game1FilipinoMedium.attempt1Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1FilipinoMedium.attempt1Char1, game1FilipinoMedium.attempt1Char2, game1FilipinoMedium.attempt1Char3, game1FilipinoMedium.attempt1Char4, game1FilipinoMedium.attempt1Char5, game1FilipinoMedium.attempt1Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoMediumCheck2()
        {
            string attemptWord = game1FilipinoMedium.attempt2Char1.Text + game1FilipinoMedium.attempt2Char2.Text + game1FilipinoMedium.attempt2Char3.Text + game1FilipinoMedium.attempt2Char4.Text + game1FilipinoMedium.attempt2Char5.Text + game1FilipinoMedium.attempt2Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoMedium.attempt2Char1, game1FilipinoMedium.attempt2Char2, game1FilipinoMedium.attempt2Char3, game1FilipinoMedium.attempt2Char4, game1FilipinoMedium.attempt2Char5, game1FilipinoMedium.attempt2Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoMediumCheck3()
        {
            string attemptWord = game1FilipinoMedium.attempt3Char1.Text + game1FilipinoMedium.attempt3Char2.Text + game1FilipinoMedium.attempt3Char3.Text + game1FilipinoMedium.attempt3Char4.Text + game1FilipinoMedium.attempt3Char5.Text + game1FilipinoMedium.attempt3Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoMedium.attempt3Char1, game1FilipinoMedium.attempt3Char2, game1FilipinoMedium.attempt3Char3, game1FilipinoMedium.attempt3Char4, game1FilipinoMedium.attempt3Char5, game1FilipinoMedium.attempt3Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoMediumCheck4()
        {
            string attemptWord = game1FilipinoMedium.attempt4Char1.Text + game1FilipinoMedium.attempt4Char2.Text + game1FilipinoMedium.attempt4Char3.Text + game1FilipinoMedium.attempt4Char4.Text + game1FilipinoMedium.attempt4Char5.Text + game1FilipinoMedium.attempt4Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoMedium.attempt4Char1, game1FilipinoMedium.attempt4Char2, game1FilipinoMedium.attempt4Char3, game1FilipinoMedium.attempt4Char4, game1FilipinoMedium.attempt4Char5, game1FilipinoMedium.attempt4Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoMediumCheck5()
        {
            string attemptWord = game1FilipinoMedium.attempt5Char1.Text + game1FilipinoMedium.attempt5Char2.Text + game1FilipinoMedium.attempt5Char3.Text + game1FilipinoMedium.attempt5Char4.Text + game1FilipinoMedium.attempt5Char5.Text + game1FilipinoMedium.attempt5Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoMedium.attempt5Char1, game1FilipinoMedium.attempt5Char2, game1FilipinoMedium.attempt5Char3, game1FilipinoMedium.attempt5Char4, game1FilipinoMedium.attempt5Char5, game1FilipinoMedium.attempt5Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoMediumCheck6()
        {
            string attemptWord = game1FilipinoMedium.attempt6Char1.Text + game1FilipinoMedium.attempt6Char2.Text + game1FilipinoMedium.attempt6Char3.Text + game1FilipinoMedium.attempt6Char4.Text + game1FilipinoMedium.attempt6Char5.Text + game1FilipinoMedium.attempt6Char6.Text;
            string guessWord = game1FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoMedium.attempt6Char1, game1FilipinoMedium.attempt6Char2, game1FilipinoMedium.attempt6Char3, game1FilipinoMedium.attempt6Char4, game1FilipinoMedium.attempt6Char5, game1FilipinoMedium.attempt6Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }




        //GM1 FILIPINO HARD
        //GM1 ENGLISH HARD
        public static async void GM1FilipinoHardCheck1()
        {
            string attemptWord = game1FilipinoHard.attempt1Char1.Text + game1FilipinoHard.attempt1Char2.Text + game1FilipinoHard.attempt1Char3.Text + game1FilipinoHard.attempt1Char4.Text + game1FilipinoHard.attempt1Char5.Text + game1FilipinoHard.attempt1Char6.Text + game1FilipinoHard.attempt1Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game1FilipinoHard.attempt1Char1, game1FilipinoHard.attempt1Char2, game1FilipinoHard.attempt1Char3, game1FilipinoHard.attempt1Char4, game1FilipinoHard.attempt1Char5, game1FilipinoHard.attempt1Char6, game1FilipinoHard.attempt1Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoHardCheck2()
        {
            string attemptWord = game1FilipinoHard.attempt2Char1.Text + game1FilipinoHard.attempt2Char2.Text + game1FilipinoHard.attempt2Char3.Text + game1FilipinoHard.attempt2Char4.Text + game1FilipinoHard.attempt2Char5.Text + game1FilipinoHard.attempt2Char6.Text + game1FilipinoHard.attempt2Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoHard.attempt2Char1, game1FilipinoHard.attempt2Char2, game1FilipinoHard.attempt2Char3, game1FilipinoHard.attempt2Char4, game1FilipinoHard.attempt2Char5, game1FilipinoHard.attempt2Char6, game1FilipinoHard.attempt2Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoHardCheck3()
        {
            string attemptWord = game1FilipinoHard.attempt3Char1.Text + game1FilipinoHard.attempt3Char2.Text + game1FilipinoHard.attempt3Char3.Text + game1FilipinoHard.attempt3Char4.Text + game1FilipinoHard.attempt3Char5.Text + game1FilipinoHard.attempt3Char6.Text + game1FilipinoHard.attempt3Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoHard.attempt3Char1, game1FilipinoHard.attempt3Char2, game1FilipinoHard.attempt3Char3, game1FilipinoHard.attempt3Char4, game1FilipinoHard.attempt3Char5, game1FilipinoHard.attempt3Char6, game1FilipinoHard.attempt3Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoHardCheck4()
        {
            string attemptWord = game1FilipinoHard.attempt4Char1.Text + game1FilipinoHard.attempt4Char2.Text + game1FilipinoHard.attempt4Char3.Text + game1FilipinoHard.attempt4Char4.Text + game1FilipinoHard.attempt4Char5.Text + game1FilipinoHard.attempt4Char6.Text + game1FilipinoHard.attempt4Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoHard.attempt4Char1, game1FilipinoHard.attempt4Char2, game1FilipinoHard.attempt4Char3, game1FilipinoHard.attempt4Char4, game1FilipinoHard.attempt4Char5, game1FilipinoHard.attempt4Char6, game1FilipinoHard.attempt4Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoHardCheck5()
        {
            string attemptWord = game1FilipinoHard.attempt5Char1.Text + game1FilipinoHard.attempt5Char2.Text + game1FilipinoHard.attempt5Char3.Text + game1FilipinoHard.attempt5Char4.Text + game1FilipinoHard.attempt5Char5.Text + game1FilipinoHard.attempt5Char6.Text + game1FilipinoHard.attempt5Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoHard.attempt5Char1, game1FilipinoHard.attempt5Char2, game1FilipinoHard.attempt5Char3, game1FilipinoHard.attempt5Char4, game1FilipinoHard.attempt5Char5, game1FilipinoHard.attempt5Char6, game1FilipinoHard.attempt5Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM1FilipinoHardCheck6()
        {
            string attemptWord = game1FilipinoHard.attempt6Char1.Text + game1FilipinoHard.attempt6Char2.Text + game1FilipinoHard.attempt6Char3.Text + game1FilipinoHard.attempt6Char4.Text + game1FilipinoHard.attempt6Char5.Text + game1FilipinoHard.attempt6Char6.Text + game1FilipinoHard.attempt6Char7.Text;
            string guessWord = game1FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game1FilipinoHard.attempt6Char1, game1FilipinoHard.attempt6Char2, game1FilipinoHard.attempt6Char3, game1FilipinoHard.attempt6Char4, game1FilipinoHard.attempt6Char5, game1FilipinoHard.attempt6Char6, game1FilipinoHard.attempt6Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game1FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game1FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }









        //GM2 ENGLISH EASY
        public static async void GM2EnglishEasyCheck1()
        {
            string attemptWord = game2EnglishEasy.attempt1Char1.Text + game2EnglishEasy.attempt1Char2.Text + game2EnglishEasy.attempt1Char3.Text + game2EnglishEasy.attempt1Char4.Text + game2EnglishEasy.attempt1Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2EnglishEasy.attempt1Char1, game2EnglishEasy.attempt1Char2, game2EnglishEasy.attempt1Char3, game2EnglishEasy.attempt1Char4, game2EnglishEasy.attempt1Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishEasyCheck2()
        {
            string attemptWord = game2EnglishEasy.attempt2Char1.Text + game2EnglishEasy.attempt2Char2.Text + game2EnglishEasy.attempt2Char3.Text + game2EnglishEasy.attempt2Char4.Text + game2EnglishEasy.attempt2Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishEasy.attempt2Char1, game2EnglishEasy.attempt2Char2, game2EnglishEasy.attempt2Char3, game2EnglishEasy.attempt2Char4, game2EnglishEasy.attempt2Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishEasyCheck3()
        {
            string attemptWord = game2EnglishEasy.attempt3Char1.Text + game2EnglishEasy.attempt3Char2.Text + game2EnglishEasy.attempt3Char3.Text + game2EnglishEasy.attempt3Char4.Text + game2EnglishEasy.attempt3Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishEasy.attempt3Char1, game2EnglishEasy.attempt3Char2, game2EnglishEasy.attempt3Char3, game2EnglishEasy.attempt3Char4, game2EnglishEasy.attempt3Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishEasyCheck4()
        {
            string attemptWord = game2EnglishEasy.attempt4Char1.Text + game2EnglishEasy.attempt4Char2.Text + game2EnglishEasy.attempt4Char3.Text + game2EnglishEasy.attempt4Char4.Text + game2EnglishEasy.attempt4Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishEasy.attempt4Char1, game2EnglishEasy.attempt4Char2, game2EnglishEasy.attempt4Char3, game2EnglishEasy.attempt4Char4, game2EnglishEasy.attempt4Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishEasyCheck5()
        {
            string attemptWord = game2EnglishEasy.attempt5Char1.Text + game2EnglishEasy.attempt5Char2.Text + game2EnglishEasy.attempt5Char3.Text + game2EnglishEasy.attempt5Char4.Text + game2EnglishEasy.attempt5Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishEasy.attempt5Char1, game2EnglishEasy.attempt5Char2, game2EnglishEasy.attempt5Char3, game2EnglishEasy.attempt5Char4, game2EnglishEasy.attempt5Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishEasyCheck6()
        {
            string attemptWord = game2EnglishEasy.attempt6Char1.Text + game2EnglishEasy.attempt6Char2.Text + game2EnglishEasy.attempt6Char3.Text + game2EnglishEasy.attempt6Char4.Text + game2EnglishEasy.attempt6Char5.Text;
            string guessWord = game2EnglishEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishEasy.attempt6Char1, game2EnglishEasy.attempt6Char2, game2EnglishEasy.attempt6Char3, game2EnglishEasy.attempt6Char4, game2EnglishEasy.attempt6Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2EnglishEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }








        //GM2 ENGLISH MEDIUM
        //GAMEMODE 1 ENGLISH MEDIUM
        public static async void GM2EnglishMediumCheck1()
        {
            string attemptWord = game2EnglishMedium.attempt1Char1.Text + game2EnglishMedium.attempt1Char2.Text + game2EnglishMedium.attempt1Char3.Text + game2EnglishMedium.attempt1Char4.Text + game2EnglishMedium.attempt1Char5.Text + game2EnglishMedium.attempt1Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2EnglishMedium.attempt1Char1, game2EnglishMedium.attempt1Char2, game2EnglishMedium.attempt1Char3, game2EnglishMedium.attempt1Char4, game2EnglishMedium.attempt1Char5, game2EnglishMedium.attempt1Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishMediumCheck2()
        {
            string attemptWord = game2EnglishMedium.attempt2Char1.Text + game2EnglishMedium.attempt2Char2.Text + game2EnglishMedium.attempt2Char3.Text + game2EnglishMedium.attempt2Char4.Text + game2EnglishMedium.attempt2Char5.Text + game2EnglishMedium.attempt2Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishMedium.attempt2Char1, game2EnglishMedium.attempt2Char2, game2EnglishMedium.attempt2Char3, game2EnglishMedium.attempt2Char4, game2EnglishMedium.attempt2Char5, game2EnglishMedium.attempt2Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishMediumCheck3()
        {
            string attemptWord = game2EnglishMedium.attempt3Char1.Text + game2EnglishMedium.attempt3Char2.Text + game2EnglishMedium.attempt3Char3.Text + game2EnglishMedium.attempt3Char4.Text + game2EnglishMedium.attempt3Char5.Text + game2EnglishMedium.attempt3Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishMedium.attempt3Char1, game2EnglishMedium.attempt3Char2, game2EnglishMedium.attempt3Char3, game2EnglishMedium.attempt3Char4, game2EnglishMedium.attempt3Char5, game2EnglishMedium.attempt3Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishMediumCheck4()
        {
            string attemptWord = game2EnglishMedium.attempt4Char1.Text + game2EnglishMedium.attempt4Char2.Text + game2EnglishMedium.attempt4Char3.Text + game2EnglishMedium.attempt4Char4.Text + game2EnglishMedium.attempt4Char5.Text + game2EnglishMedium.attempt4Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishMedium.attempt4Char1, game2EnglishMedium.attempt4Char2, game2EnglishMedium.attempt4Char3, game2EnglishMedium.attempt4Char4, game2EnglishMedium.attempt4Char5, game2EnglishMedium.attempt4Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishMediumCheck5()
        {
            string attemptWord = game2EnglishMedium.attempt5Char1.Text + game2EnglishMedium.attempt5Char2.Text + game2EnglishMedium.attempt5Char3.Text + game2EnglishMedium.attempt5Char4.Text + game2EnglishMedium.attempt5Char5.Text + game2EnglishMedium.attempt5Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishMedium.attempt5Char1, game2EnglishMedium.attempt5Char2, game2EnglishMedium.attempt5Char3, game2EnglishMedium.attempt5Char4, game2EnglishMedium.attempt5Char5, game2EnglishMedium.attempt5Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishMediumCheck6()
        {
            string attemptWord = game2EnglishMedium.attempt6Char1.Text + game2EnglishMedium.attempt6Char2.Text + game2EnglishMedium.attempt6Char3.Text + game2EnglishMedium.attempt6Char4.Text + game2EnglishMedium.attempt6Char5.Text + game2EnglishMedium.attempt6Char6.Text;
            string guessWord = game2EnglishMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishMedium.attempt6Char1, game2EnglishMedium.attempt6Char2, game2EnglishMedium.attempt6Char3, game2EnglishMedium.attempt6Char4, game2EnglishMedium.attempt6Char5, game2EnglishMedium.attempt6Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2EnglishMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }










        //GM2 ENGLISH HARD
        public static async void GM2EnglishHardCheck1()
        {
            string attemptWord = game2EnglishHard.attempt1Char1.Text + game2EnglishHard.attempt1Char2.Text + game2EnglishHard.attempt1Char3.Text + game2EnglishHard.attempt1Char4.Text + game2EnglishHard.attempt1Char5.Text + game2EnglishHard.attempt1Char6.Text + game2EnglishHard.attempt1Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2EnglishHard.attempt1Char1, game2EnglishHard.attempt1Char2, game2EnglishHard.attempt1Char3, game2EnglishHard.attempt1Char4, game2EnglishHard.attempt1Char5, game2EnglishHard.attempt1Char6, game2EnglishHard.attempt1Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishHardCheck2()
        {
            string attemptWord = game2EnglishHard.attempt2Char1.Text + game2EnglishHard.attempt2Char2.Text + game2EnglishHard.attempt2Char3.Text + game2EnglishHard.attempt2Char4.Text + game2EnglishHard.attempt2Char5.Text + game2EnglishHard.attempt2Char6.Text + game2EnglishHard.attempt2Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishHard.attempt2Char1, game2EnglishHard.attempt2Char2, game2EnglishHard.attempt2Char3, game2EnglishHard.attempt2Char4, game2EnglishHard.attempt2Char5, game2EnglishHard.attempt2Char6, game2EnglishHard.attempt2Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishHardCheck3()
        {
            string attemptWord = game2EnglishHard.attempt3Char1.Text + game2EnglishHard.attempt3Char2.Text + game2EnglishHard.attempt3Char3.Text + game2EnglishHard.attempt3Char4.Text + game2EnglishHard.attempt3Char5.Text + game2EnglishHard.attempt3Char6.Text + game2EnglishHard.attempt3Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishHard.attempt3Char1, game2EnglishHard.attempt3Char2, game2EnglishHard.attempt3Char3, game2EnglishHard.attempt3Char4, game2EnglishHard.attempt3Char5, game2EnglishHard.attempt3Char6, game2EnglishHard.attempt3Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishHardCheck4()
        {
            string attemptWord = game2EnglishHard.attempt4Char1.Text + game2EnglishHard.attempt4Char2.Text + game2EnglishHard.attempt4Char3.Text + game2EnglishHard.attempt4Char4.Text + game2EnglishHard.attempt4Char5.Text + game2EnglishHard.attempt4Char6.Text + game2EnglishHard.attempt4Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishHard.attempt4Char1, game2EnglishHard.attempt4Char2, game2EnglishHard.attempt4Char3, game2EnglishHard.attempt4Char4, game2EnglishHard.attempt4Char5, game2EnglishHard.attempt4Char6, game2EnglishHard.attempt4Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishHardCheck5()
        {
            string attemptWord = game2EnglishHard.attempt5Char1.Text + game2EnglishHard.attempt5Char2.Text + game2EnglishHard.attempt5Char3.Text + game2EnglishHard.attempt5Char4.Text + game2EnglishHard.attempt5Char5.Text + game2EnglishHard.attempt5Char6.Text + game2EnglishHard.attempt5Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishHard.attempt5Char1, game2EnglishHard.attempt5Char2, game2EnglishHard.attempt5Char3, game2EnglishHard.attempt5Char4, game2EnglishHard.attempt5Char5, game2EnglishHard.attempt5Char6, game2EnglishHard.attempt5Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2EnglishHardCheck6()
        {
            string attemptWord = game2EnglishHard.attempt6Char1.Text + game2EnglishHard.attempt6Char2.Text + game2EnglishHard.attempt6Char3.Text + game2EnglishHard.attempt6Char4.Text + game2EnglishHard.attempt6Char5.Text + game2EnglishHard.attempt6Char6.Text + game2EnglishHard.attempt6Char7.Text;
            string guessWord = game2EnglishHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2EnglishHard.attempt6Char1, game2EnglishHard.attempt6Char2, game2EnglishHard.attempt6Char3, game2EnglishHard.attempt6Char4, game2EnglishHard.attempt6Char5, game2EnglishHard.attempt6Char6, game2EnglishHard.attempt6Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2EnglishHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2EnglishHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }







        //GM2 FILIPINO EASY
        public static async void GM2FilipinoEasyCheck1()
        {
            string attemptWord = game2FilipinoEasy.attempt1Char1.Text + game2FilipinoEasy.attempt1Char2.Text + game2FilipinoEasy.attempt1Char3.Text + game2FilipinoEasy.attempt1Char4.Text + game2FilipinoEasy.attempt1Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2FilipinoEasy.attempt1Char1, game2FilipinoEasy.attempt1Char2, game2FilipinoEasy.attempt1Char3, game2FilipinoEasy.attempt1Char4, game2FilipinoEasy.attempt1Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoEasyCheck2()
        {
            string attemptWord = game2FilipinoEasy.attempt2Char1.Text + game2FilipinoEasy.attempt2Char2.Text + game2FilipinoEasy.attempt2Char3.Text + game2FilipinoEasy.attempt2Char4.Text + game2FilipinoEasy.attempt2Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoEasy.attempt2Char1, game2FilipinoEasy.attempt2Char2, game2FilipinoEasy.attempt2Char3, game2FilipinoEasy.attempt2Char4, game2FilipinoEasy.attempt2Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoEasyCheck3()
        {
            string attemptWord = game2FilipinoEasy.attempt3Char1.Text + game2FilipinoEasy.attempt3Char2.Text + game2FilipinoEasy.attempt3Char3.Text + game2FilipinoEasy.attempt3Char4.Text + game2FilipinoEasy.attempt3Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoEasy.attempt3Char1, game2FilipinoEasy.attempt3Char2, game2FilipinoEasy.attempt3Char3, game2FilipinoEasy.attempt3Char4, game2FilipinoEasy.attempt3Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoEasyCheck4()
        {
            string attemptWord = game2FilipinoEasy.attempt4Char1.Text + game2FilipinoEasy.attempt4Char2.Text + game2FilipinoEasy.attempt4Char3.Text + game2FilipinoEasy.attempt4Char4.Text + game2FilipinoEasy.attempt4Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoEasy.attempt4Char1, game2FilipinoEasy.attempt4Char2, game2FilipinoEasy.attempt4Char3, game2FilipinoEasy.attempt4Char4, game2FilipinoEasy.attempt4Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoEasyCheck5()
        {
            string attemptWord = game2FilipinoEasy.attempt5Char1.Text + game2FilipinoEasy.attempt5Char2.Text + game2FilipinoEasy.attempt5Char3.Text + game2FilipinoEasy.attempt5Char4.Text + game2FilipinoEasy.attempt5Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoEasy.attempt5Char1, game2FilipinoEasy.attempt5Char2, game2FilipinoEasy.attempt5Char3, game2FilipinoEasy.attempt5Char4, game2FilipinoEasy.attempt5Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoEasyCheck6()
        {
            string attemptWord = game2FilipinoEasy.attempt6Char1.Text + game2FilipinoEasy.attempt6Char2.Text + game2FilipinoEasy.attempt6Char3.Text + game2FilipinoEasy.attempt6Char4.Text + game2FilipinoEasy.attempt6Char5.Text;
            string guessWord = game2FilipinoEasy.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoEasy.attempt6Char1, game2FilipinoEasy.attempt6Char2, game2FilipinoEasy.attempt6Char3, game2FilipinoEasy.attempt6Char4, game2FilipinoEasy.attempt6Char5 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2FilipinoEasy.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoEasy.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }







        //GM2 FILIPINO MEDIUM
        public static async void GM2FilipinoMediumCheck1()
        {
            string attemptWord = game2FilipinoMedium.attempt1Char1.Text + game2FilipinoMedium.attempt1Char2.Text + game2FilipinoMedium.attempt1Char3.Text + game2FilipinoMedium.attempt1Char4.Text + game2FilipinoMedium.attempt1Char5.Text + game2FilipinoMedium.attempt1Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2FilipinoMedium.attempt1Char1, game2FilipinoMedium.attempt1Char2, game2FilipinoMedium.attempt1Char3, game2FilipinoMedium.attempt1Char4, game2FilipinoMedium.attempt1Char5, game2FilipinoMedium.attempt1Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoMediumCheck2()
        {
            string attemptWord = game2FilipinoMedium.attempt2Char1.Text + game2FilipinoMedium.attempt2Char2.Text + game2FilipinoMedium.attempt2Char3.Text + game2FilipinoMedium.attempt2Char4.Text + game2FilipinoMedium.attempt2Char5.Text + game2FilipinoMedium.attempt2Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoMedium.attempt2Char1, game2FilipinoMedium.attempt2Char2, game2FilipinoMedium.attempt2Char3, game2FilipinoMedium.attempt2Char4, game2FilipinoMedium.attempt2Char5, game2FilipinoMedium.attempt2Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoMediumCheck3()
        {
            string attemptWord = game2FilipinoMedium.attempt3Char1.Text + game2FilipinoMedium.attempt3Char2.Text + game2FilipinoMedium.attempt3Char3.Text + game2FilipinoMedium.attempt3Char4.Text + game2FilipinoMedium.attempt3Char5.Text + game2FilipinoMedium.attempt3Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoMedium.attempt3Char1, game2FilipinoMedium.attempt3Char2, game2FilipinoMedium.attempt3Char3, game2FilipinoMedium.attempt3Char4, game2FilipinoMedium.attempt3Char5, game2FilipinoMedium.attempt3Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoMediumCheck4()
        {
            string attemptWord = game2FilipinoMedium.attempt4Char1.Text + game2FilipinoMedium.attempt4Char2.Text + game2FilipinoMedium.attempt4Char3.Text + game2FilipinoMedium.attempt4Char4.Text + game2FilipinoMedium.attempt4Char5.Text + game2FilipinoMedium.attempt4Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoMedium.attempt4Char1, game2FilipinoMedium.attempt4Char2, game2FilipinoMedium.attempt4Char3, game2FilipinoMedium.attempt4Char4, game2FilipinoMedium.attempt4Char5, game2FilipinoMedium.attempt4Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoMediumCheck5()
        {
            string attemptWord = game2FilipinoMedium.attempt5Char1.Text + game2FilipinoMedium.attempt5Char2.Text + game2FilipinoMedium.attempt5Char3.Text + game2FilipinoMedium.attempt5Char4.Text + game2FilipinoMedium.attempt5Char5.Text + game2FilipinoMedium.attempt5Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoMedium.attempt5Char1, game2FilipinoMedium.attempt5Char2, game2FilipinoMedium.attempt5Char3, game2FilipinoMedium.attempt5Char4, game2FilipinoMedium.attempt5Char5, game2FilipinoMedium.attempt5Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoMediumCheck6()
        {
            string attemptWord = game2FilipinoMedium.attempt6Char1.Text + game2FilipinoMedium.attempt6Char2.Text + game2FilipinoMedium.attempt6Char3.Text + game2FilipinoMedium.attempt6Char4.Text + game2FilipinoMedium.attempt6Char5.Text + game2FilipinoMedium.attempt6Char6.Text;
            string guessWord = game2FilipinoMedium.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoMedium.attempt6Char1, game2FilipinoMedium.attempt6Char2, game2FilipinoMedium.attempt6Char3, game2FilipinoMedium.attempt6Char4, game2FilipinoMedium.attempt6Char5, game2FilipinoMedium.attempt6Char6 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2FilipinoMedium.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoMedium.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }







        //GM2 FILIPINO HARD
        public static async void GM2FilipinoHardCheck1()
        {
            string attemptWord = game2FilipinoHard.attempt1Char1.Text + game2FilipinoHard.attempt1Char2.Text + game2FilipinoHard.attempt1Char3.Text + game2FilipinoHard.attempt1Char4.Text + game2FilipinoHard.attempt1Char5.Text + game2FilipinoHard.attempt1Char6.Text + game2FilipinoHard.attempt1Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = { game2FilipinoHard.attempt1Char1, game2FilipinoHard.attempt1Char2, game2FilipinoHard.attempt1Char3, game2FilipinoHard.attempt1Char4, game2FilipinoHard.attempt1Char5, game2FilipinoHard.attempt1Char6, game2FilipinoHard.attempt1Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoHardCheck2()
        {
            string attemptWord = game2FilipinoHard.attempt2Char1.Text + game2FilipinoHard.attempt2Char2.Text + game2FilipinoHard.attempt2Char3.Text + game2FilipinoHard.attempt2Char4.Text + game2FilipinoHard.attempt2Char5.Text + game2FilipinoHard.attempt2Char6.Text + game2FilipinoHard.attempt2Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoHard.attempt2Char1, game2FilipinoHard.attempt2Char2, game2FilipinoHard.attempt2Char3, game2FilipinoHard.attempt2Char4, game2FilipinoHard.attempt2Char5, game2FilipinoHard.attempt2Char6, game2FilipinoHard.attempt2Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoHardCheck3()
        {
            string attemptWord = game2FilipinoHard.attempt3Char1.Text + game2FilipinoHard.attempt3Char2.Text + game2FilipinoHard.attempt3Char3.Text + game2FilipinoHard.attempt3Char4.Text + game2FilipinoHard.attempt3Char5.Text + game2FilipinoHard.attempt3Char6.Text + game2FilipinoHard.attempt3Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoHard.attempt3Char1, game2FilipinoHard.attempt3Char2, game2FilipinoHard.attempt3Char3, game2FilipinoHard.attempt3Char4, game2FilipinoHard.attempt3Char5, game2FilipinoHard.attempt3Char6, game2FilipinoHard.attempt3Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoHardCheck4()
        {
            string attemptWord = game2FilipinoHard.attempt4Char1.Text + game2FilipinoHard.attempt4Char2.Text + game2FilipinoHard.attempt4Char3.Text + game2FilipinoHard.attempt4Char4.Text + game2FilipinoHard.attempt4Char5.Text + game2FilipinoHard.attempt4Char6.Text + game2FilipinoHard.attempt4Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoHard.attempt4Char1, game2FilipinoHard.attempt4Char2, game2FilipinoHard.attempt4Char3, game2FilipinoHard.attempt4Char4, game2FilipinoHard.attempt4Char5, game2FilipinoHard.attempt4Char6, game2FilipinoHard.attempt4Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoHardCheck5()
        {
            string attemptWord = game2FilipinoHard.attempt5Char1.Text + game2FilipinoHard.attempt5Char2.Text + game2FilipinoHard.attempt5Char3.Text + game2FilipinoHard.attempt5Char4.Text + game2FilipinoHard.attempt5Char5.Text + game2FilipinoHard.attempt5Char6.Text + game2FilipinoHard.attempt5Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoHard.attempt5Char1, game2FilipinoHard.attempt5Char2, game2FilipinoHard.attempt5Char3, game2FilipinoHard.attempt5Char4, game2FilipinoHard.attempt5Char5, game2FilipinoHard.attempt5Char6, game2FilipinoHard.attempt5Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;
                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
        public static async void GM2FilipinoHardCheck6()
        {
            string attemptWord = game2FilipinoHard.attempt6Char1.Text + game2FilipinoHard.attempt6Char2.Text + game2FilipinoHard.attempt6Char3.Text + game2FilipinoHard.attempt6Char4.Text + game2FilipinoHard.attempt6Char5.Text + game2FilipinoHard.attempt6Char6.Text + game2FilipinoHard.attempt6Char7.Text;
            string guessWord = game2FilipinoHard.guessWord;
            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];
            TextBox[] textBoxes = { game2FilipinoHard.attempt6Char1, game2FilipinoHard.attempt6Char2, game2FilipinoHard.attempt6Char3, game2FilipinoHard.attempt6Char4, game2FilipinoHard.attempt6Char5, game2FilipinoHard.attempt6Char6, game2FilipinoHard.attempt6Char7 };
            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }
            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }
                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                Color color = Color.DarkGray;
                switch (result[i])
                {
                    case 'G':
                        color = Color.LightGreen;
                        break;
                    case 'Y':
                        color = Color.Yellow;
                        break;
                }
                textBoxes[i].BackColor = color;

                char keyboardLetter = attemptWord[i];
                if (game2FilipinoHard.letterButtons.ContainsKey(keyboardLetter))
                {
                    game2FilipinoHard.letterButtons[keyboardLetter].BackColor = color;
                }
                await Task.Delay(500);
            }
        }
    }
}
