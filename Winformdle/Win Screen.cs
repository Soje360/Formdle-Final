using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformdle
{
    public partial class WinScreen : Form
    {
        public WinScreen(string guessWord)
        {
            InitializeComponent();
            this.guessWordLbl.Text = guessWord;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MainMenu mainMenu = new MainMenu();
            this.Hide();
            this.ResetText();
            mainMenu.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
