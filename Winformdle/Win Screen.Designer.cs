namespace Winformdle
{
    partial class WinScreen
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
            label1 = new Label();
            guessWordLbl = new Label();
            exitBtn = new Button();
            playAgainBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 65);
            label1.Name = "label1";
            label1.Size = new Size(504, 43);
            label1.TabIndex = 0;
            label1.Text = "Congrats! You guessed the word";
            // 
            // guessWordLbl
            // 
            guessWordLbl.AutoSize = true;
            guessWordLbl.BackColor = Color.Transparent;
            guessWordLbl.Font = new Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessWordLbl.Location = new Point(313, 145);
            guessWordLbl.Name = "guessWordLbl";
            guessWordLbl.Size = new Size(27, 36);
            guessWordLbl.TabIndex = 1;
            guessWordLbl.Text = "1";
            guessWordLbl.Click += label2_Click;
            // 
            // exitBtn
            // 
            exitBtn.Image = Properties.Resources.exit_button;
            exitBtn.Location = new Point(161, 249);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(144, 59);
            exitBtn.TabIndex = 2;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += button1_Click;
            // 
            // playAgainBtn
            // 
            playAgainBtn.Image = Properties.Resources.play_again_button;
            playAgainBtn.Location = new Point(425, 249);
            playAgainBtn.Name = "playAgainBtn";
            playAgainBtn.Size = new Size(146, 59);
            playAgainBtn.TabIndex = 3;
            playAgainBtn.UseVisualStyleBackColor = true;
            playAgainBtn.Click += button2_Click;
            // 
            // WinScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(743, 450);
            Controls.Add(playAgainBtn);
            Controls.Add(exitBtn);
            Controls.Add(guessWordLbl);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "WinScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Congrats!";
            FormClosed += WinScreen_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label guessWordLbl;
        private Button exitBtn;
        private Button playAgainBtn;
    }
}