namespace Winformdle
{
    partial class loseScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guessWordLbl = new Label();
            playAgainBtn = new Button();
            exitBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // guessWordLbl
            // 
            guessWordLbl.AutoSize = true;
            guessWordLbl.BackColor = Color.Transparent;
            guessWordLbl.Font = new Font("Impact", 21.75F, FontStyle.Bold);
            guessWordLbl.Location = new Point(308, 157);
            guessWordLbl.Name = "guessWordLbl";
            guessWordLbl.Size = new Size(31, 36);
            guessWordLbl.TabIndex = 1;
            guessWordLbl.Text = "2";
            guessWordLbl.Click += label2_Click;
            // 
            // playAgainBtn
            // 
            playAgainBtn.Image = Properties.Resources.play_again_button1;
            playAgainBtn.Location = new Point(410, 244);
            playAgainBtn.Name = "playAgainBtn";
            playAgainBtn.Size = new Size(143, 62);
            playAgainBtn.TabIndex = 2;
            playAgainBtn.UseVisualStyleBackColor = true;
            playAgainBtn.Click += button1_Click;
            // 
            // exitBtn
            // 
            exitBtn.Image = Properties.Resources.exit_button;
            exitBtn.Location = new Point(177, 244);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(147, 62);
            exitBtn.TabIndex = 3;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 51);
            label2.Name = "label2";
            label2.Size = new Size(362, 43);
            label2.TabIndex = 4;
            label2.Text = "You Lost! The word was";
            // 
            // loseScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 450);
            Controls.Add(label2);
            Controls.Add(exitBtn);
            Controls.Add(playAgainBtn);
            Controls.Add(guessWordLbl);
            DoubleBuffered = true;
            Name = "loseScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Better Luck Next Time!";
            FormClosed += LoseScreen_FormClosed;
            Load += LoseScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label guessWordLbl;
        private Button playAgainBtn;
        private Button exitBtn;
        private Label label2;
    }
}