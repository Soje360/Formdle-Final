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
    public partial class loseScreen : Form
    {
        public loseScreen(string guessWord)
        {
            InitializeComponent();
            guessWordLbl.Text = guessWord;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoseScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoseScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
