namespace Winformdle
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Button();
            pnlMainMenu = new Panel();
            btnAbout = new Button();
            panel1 = new Panel();
            btnExit = new Button();
            pnlLanguage = new Panel();
            label3 = new Label();
            btnBackLanguage = new Button();
            btnTagalog = new Button();
            btnEnglish = new Button();
            pnlDifficulty = new Panel();
            label1 = new Label();
            btnBackDifficulty = new Button();
            btnHard = new Button();
            btnMedium = new Button();
            btnEasy = new Button();
            pnlGameMode = new Panel();
            label2 = new Label();
            btnBackGameMode = new Button();
            btn2Player = new Button();
            btn1Player = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlAbout = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnBackAbout = new Button();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblInstructions = new Label();
            label6 = new Label();
            pnlUnliAttemptConfirmation = new Panel();
            label11 = new Label();
            btnUnliAttemptBack = new Button();
            btnUnliAttemptDecline = new Button();
            btnUnliAttemptConfirm = new Button();
            pnlMainMenu.SuspendLayout();
            pnlLanguage.SuspendLayout();
            pnlDifficulty.SuspendLayout();
            pnlGameMode.SuspendLayout();
            pnlAbout.SuspendLayout();
            pnlUnliAttemptConfirmation.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Image = Properties.Resources.play_button;
            btnPlay.Location = new Point(146, 213);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(154, 71);
            btnPlay.TabIndex = 0;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.BackgroundImage = Properties.Resources.BG;
            pnlMainMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMainMenu.Controls.Add(btnAbout);
            pnlMainMenu.Controls.Add(panel1);
            pnlMainMenu.Controls.Add(btnExit);
            pnlMainMenu.Controls.Add(btnPlay);
            pnlMainMenu.Dock = DockStyle.Fill;
            pnlMainMenu.Location = new Point(0, 0);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(449, 622);
            pnlMainMenu.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Image = Properties.Resources.how_to_play;
            btnAbout.Location = new Point(0, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(50, 45);
            btnAbout.TabIndex = 6;
            btnAbout.Tag = "";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_fixed;
            panel1.Location = new Point(113, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 48);
            panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.exit_button;
            btnExit.Location = new Point(147, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(154, 75);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlLanguage
            // 
            pnlLanguage.BackgroundImage = Properties.Resources.BG;
            pnlLanguage.Controls.Add(label3);
            pnlLanguage.Controls.Add(btnBackLanguage);
            pnlLanguage.Controls.Add(btnTagalog);
            pnlLanguage.Controls.Add(btnEnglish);
            pnlLanguage.Dock = DockStyle.Fill;
            pnlLanguage.Location = new Point(0, 0);
            pnlLanguage.Name = "pnlLanguage";
            pnlLanguage.Size = new Size(449, 622);
            pnlLanguage.TabIndex = 2;
            pnlLanguage.Visible = false;
            pnlLanguage.Paint += pnlLanguage_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 100);
            label3.Name = "label3";
            label3.Size = new Size(311, 43);
            label3.TabIndex = 6;
            label3.Text = "Choose A Language";
            // 
            // btnBackLanguage
            // 
            btnBackLanguage.BackColor = Color.White;
            btnBackLanguage.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackLanguage.Location = new Point(176, 349);
            btnBackLanguage.Name = "btnBackLanguage";
            btnBackLanguage.Size = new Size(108, 34);
            btnBackLanguage.TabIndex = 3;
            btnBackLanguage.Text = "BACK";
            btnBackLanguage.UseVisualStyleBackColor = false;
            btnBackLanguage.Click += btnBackLanguage_Click;
            // 
            // btnTagalog
            // 
            btnTagalog.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTagalog.Image = Properties.Resources.tagalog_button;
            btnTagalog.Location = new Point(148, 265);
            btnTagalog.Name = "btnTagalog";
            btnTagalog.Size = new Size(157, 69);
            btnTagalog.TabIndex = 2;
            btnTagalog.UseVisualStyleBackColor = true;
            btnTagalog.Click += btnTagalog_Click1;
            // 
            // btnEnglish
            // 
            btnEnglish.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnglish.Image = Properties.Resources.english_button;
            btnEnglish.Location = new Point(148, 174);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(155, 71);
            btnEnglish.TabIndex = 1;
            btnEnglish.UseVisualStyleBackColor = true;
            btnEnglish.Click += btnEnglish_Click;
            // 
            // pnlDifficulty
            // 
            pnlDifficulty.BackgroundImage = Properties.Resources.BG;
            pnlDifficulty.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDifficulty.Controls.Add(label1);
            pnlDifficulty.Controls.Add(btnBackDifficulty);
            pnlDifficulty.Controls.Add(btnHard);
            pnlDifficulty.Controls.Add(btnMedium);
            pnlDifficulty.Controls.Add(btnEasy);
            pnlDifficulty.Dock = DockStyle.Fill;
            pnlDifficulty.Location = new Point(0, 0);
            pnlDifficulty.Name = "pnlDifficulty";
            pnlDifficulty.Size = new Size(449, 622);
            pnlDifficulty.TabIndex = 3;
            pnlDifficulty.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 93);
            label1.Name = "label1";
            label1.Size = new Size(303, 43);
            label1.TabIndex = 5;
            label1.Text = "Choose A Difficulty";
            // 
            // btnBackDifficulty
            // 
            btnBackDifficulty.BackColor = Color.White;
            btnBackDifficulty.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackDifficulty.ForeColor = SystemColors.ControlText;
            btnBackDifficulty.Location = new Point(161, 444);
            btnBackDifficulty.Name = "btnBackDifficulty";
            btnBackDifficulty.Size = new Size(123, 34);
            btnBackDifficulty.TabIndex = 4;
            btnBackDifficulty.Text = "BACK";
            btnBackDifficulty.UseVisualStyleBackColor = false;
            btnBackDifficulty.Click += btnBackDifficulty_Click;
            // 
            // btnHard
            // 
            btnHard.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHard.Image = Properties.Resources.hard_button;
            btnHard.Location = new Point(146, 351);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(154, 75);
            btnHard.TabIndex = 3;
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // btnMedium
            // 
            btnMedium.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMedium.Image = Properties.Resources.medium_button__2_;
            btnMedium.Location = new Point(146, 265);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(154, 69);
            btnMedium.TabIndex = 2;
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnEasy
            // 
            btnEasy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEasy.Image = Properties.Resources.easy_button;
            btnEasy.Location = new Point(146, 175);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(155, 71);
            btnEasy.TabIndex = 1;
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // pnlGameMode
            // 
            pnlGameMode.BackgroundImage = Properties.Resources.BG;
            pnlGameMode.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGameMode.Controls.Add(label2);
            pnlGameMode.Controls.Add(btnBackGameMode);
            pnlGameMode.Controls.Add(btn2Player);
            pnlGameMode.Controls.Add(btn1Player);
            pnlGameMode.Dock = DockStyle.Fill;
            pnlGameMode.Location = new Point(0, 0);
            pnlGameMode.Name = "pnlGameMode";
            pnlGameMode.Size = new Size(449, 622);
            pnlGameMode.TabIndex = 3;
            pnlGameMode.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 100);
            label2.Name = "label2";
            label2.Size = new Size(333, 43);
            label2.TabIndex = 8;
            label2.Text = "Choose A GameMode";
            // 
            // btnBackGameMode
            // 
            btnBackGameMode.BackColor = Color.White;
            btnBackGameMode.FlatAppearance.BorderColor = Color.Black;
            btnBackGameMode.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackGameMode.Location = new Point(161, 361);
            btnBackGameMode.Name = "btnBackGameMode";
            btnBackGameMode.Size = new Size(123, 34);
            btnBackGameMode.TabIndex = 7;
            btnBackGameMode.Text = "BACK";
            btnBackGameMode.UseVisualStyleBackColor = false;
            btnBackGameMode.Click += btnBackGameMode_Click;
            // 
            // btn2Player
            // 
            btn2Player.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2Player.Image = Properties.Resources._2___player_button;
            btn2Player.Location = new Point(146, 271);
            btn2Player.Name = "btn2Player";
            btn2Player.Size = new Size(152, 72);
            btn2Player.TabIndex = 6;
            btn2Player.UseVisualStyleBackColor = true;
            btn2Player.Click += btn2Player_Click;
            // 
            // btn1Player
            // 
            btn1Player.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1Player.Image = Properties.Resources._1___player_button;
            btn1Player.Location = new Point(148, 173);
            btn1Player.Name = "btn1Player";
            btn1Player.Size = new Size(153, 73);
            btn1Player.TabIndex = 5;
            btn1Player.UseVisualStyleBackColor = true;
            btn1Player.Click += btn1Player_Click;
            // 
            // pnlAbout
            // 
            pnlAbout.BackgroundImage = Properties.Resources.BG;
            pnlAbout.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAbout.Controls.Add(label15);
            pnlAbout.Controls.Add(label14);
            pnlAbout.Controls.Add(label13);
            pnlAbout.Controls.Add(label12);
            pnlAbout.Controls.Add(btnBackAbout);
            pnlAbout.Controls.Add(label9);
            pnlAbout.Controls.Add(label10);
            pnlAbout.Controls.Add(label7);
            pnlAbout.Controls.Add(label8);
            pnlAbout.Controls.Add(label5);
            pnlAbout.Controls.Add(label4);
            pnlAbout.Controls.Add(lblInstructions);
            pnlAbout.Controls.Add(label6);
            pnlAbout.Dock = DockStyle.Fill;
            pnlAbout.Location = new Point(0, 0);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.Size = new Size(449, 622);
            pnlAbout.TabIndex = 4;
            pnlAbout.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(155, 517);
            label15.Name = "label15";
            label15.Size = new Size(160, 63);
            label15.TabIndex = 12;
            label15.Text = "Easy: 5-letter word\r\nMedium: 6-letter word\r\nHard: 7-letter word";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gainsboro;
            label14.Location = new Point(166, 487);
            label14.Name = "label14";
            label14.Size = new Size(123, 19);
            label14.TabIndex = 11;
            label14.Text = "DIFFICULTIES";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(132, 428);
            label13.Name = "label13";
            label13.Size = new Size(195, 42);
            label13.TabIndex = 10;
            label13.Text = "Game mode 1: One player\r\nGame mode 2: Two players";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(169, 401);
            label12.Name = "label12";
            label12.Size = new Size(120, 19);
            label12.TabIndex = 9;
            label12.Text = "GAME MODES";
            // 
            // btnBackAbout
            // 
            btnBackAbout.FlatAppearance.BorderSize = 0;
            btnBackAbout.FlatStyle = FlatStyle.Flat;
            btnBackAbout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackAbout.Image = Properties.Resources.back_button;
            btnBackAbout.Location = new Point(0, 0);
            btnBackAbout.Name = "btnBackAbout";
            btnBackAbout.Size = new Size(50, 48);
            btnBackAbout.TabIndex = 8;
            btnBackAbout.UseVisualStyleBackColor = true;
            btnBackAbout.Click += btnBackAbout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(93, 340);
            label9.Name = "label9";
            label9.Size = new Size(285, 42);
            label9.TabIndex = 7;
            label9.Text = "Indicates that the character input is NOT\r\nin the Guess Word\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(200, 311);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 6;
            label10.Text = "GRAY";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 253);
            label7.Name = "label7";
            label7.Size = new Size(296, 42);
            label7.TabIndex = 5;
            label7.Text = "Indicates that the character input is in the\r\nGuess Word but in the wrong order";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(191, 224);
            label8.Name = "label8";
            label8.Size = new Size(76, 19);
            label8.TabIndex = 4;
            label8.Text = "YELLOW";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGreen;
            label5.Location = new Point(191, 129);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 2;
            label5.Text = "GREEN";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 69);
            label4.Name = "label4";
            label4.Size = new Size(339, 40);
            label4.TabIndex = 1;
            label4.Text = "The Game 'CONSOLEDLE' is a guessing word game.\r\nWherein the user input could be indicated as:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.Transparent;
            lblInstructions.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(148, 24);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(179, 30);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "INSTRUCTIONS: \r\n";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 164);
            label6.Name = "label6";
            label6.Size = new Size(296, 42);
            label6.TabIndex = 3;
            label6.Text = "Indicates that the character input is in the\r\nGuess Word and in the right order\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUnliAttemptConfirmation
            // 
            pnlUnliAttemptConfirmation.BackgroundImage = Properties.Resources.BG;
            pnlUnliAttemptConfirmation.BackgroundImageLayout = ImageLayout.Stretch;
            pnlUnliAttemptConfirmation.Controls.Add(label11);
            pnlUnliAttemptConfirmation.Controls.Add(btnUnliAttemptBack);
            pnlUnliAttemptConfirmation.Controls.Add(btnUnliAttemptDecline);
            pnlUnliAttemptConfirmation.Controls.Add(btnUnliAttemptConfirm);
            pnlUnliAttemptConfirmation.Dock = DockStyle.Fill;
            pnlUnliAttemptConfirmation.Location = new Point(0, 0);
            pnlUnliAttemptConfirmation.Name = "pnlUnliAttemptConfirmation";
            pnlUnliAttemptConfirmation.Size = new Size(449, 622);
            pnlUnliAttemptConfirmation.TabIndex = 5;
            pnlUnliAttemptConfirmation.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 78);
            label11.Name = "label11";
            label11.Size = new Size(423, 72);
            label11.TabIndex = 8;
            label11.Text = "Do you want to play in unlimited\r\n attempts in this gamemode?";
            // 
            // btnUnliAttemptBack
            // 
            btnUnliAttemptBack.BackColor = Color.White;
            btnUnliAttemptBack.FlatAppearance.BorderColor = Color.Black;
            btnUnliAttemptBack.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnliAttemptBack.Location = new Point(161, 383);
            btnUnliAttemptBack.Name = "btnUnliAttemptBack";
            btnUnliAttemptBack.Size = new Size(123, 34);
            btnUnliAttemptBack.TabIndex = 7;
            btnUnliAttemptBack.Text = "BACK";
            btnUnliAttemptBack.UseVisualStyleBackColor = false;
            btnUnliAttemptBack.Click += btnUnliAttemptBack_Click;
            // 
            // btnUnliAttemptDecline
            // 
            btnUnliAttemptDecline.FlatAppearance.BorderColor = Color.Black;
            btnUnliAttemptDecline.FlatAppearance.BorderSize = 4;
            btnUnliAttemptDecline.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnliAttemptDecline.Image = Properties.Resources.no_button;
            btnUnliAttemptDecline.Location = new Point(147, 271);
            btnUnliAttemptDecline.Name = "btnUnliAttemptDecline";
            btnUnliAttemptDecline.Size = new Size(151, 72);
            btnUnliAttemptDecline.TabIndex = 6;
            btnUnliAttemptDecline.UseVisualStyleBackColor = true;
            btnUnliAttemptDecline.Click += btnUnliAttemptDecline_Click;
            // 
            // btnUnliAttemptConfirm
            // 
            btnUnliAttemptConfirm.FlatAppearance.BorderColor = Color.Black;
            btnUnliAttemptConfirm.FlatAppearance.BorderSize = 4;
            btnUnliAttemptConfirm.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUnliAttemptConfirm.Image = Properties.Resources.yes_button;
            btnUnliAttemptConfirm.Location = new Point(148, 173);
            btnUnliAttemptConfirm.Name = "btnUnliAttemptConfirm";
            btnUnliAttemptConfirm.Size = new Size(153, 73);
            btnUnliAttemptConfirm.TabIndex = 5;
            btnUnliAttemptConfirm.UseVisualStyleBackColor = true;
            btnUnliAttemptConfirm.Click += btnUnliAttemptConfirm_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(449, 622);
            Controls.Add(pnlMainMenu);
            Controls.Add(pnlGameMode);
            Controls.Add(pnlDifficulty);
            Controls.Add(pnlAbout);
            Controls.Add(pnlUnliAttemptConfirmation);
            Controls.Add(pnlLanguage);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdle";
            FormClosed += MainMenu_FormClosed;
            Load += Form1_Load;
            pnlMainMenu.ResumeLayout(false);
            pnlLanguage.ResumeLayout(false);
            pnlLanguage.PerformLayout();
            pnlDifficulty.ResumeLayout(false);
            pnlDifficulty.PerformLayout();
            pnlGameMode.ResumeLayout(false);
            pnlGameMode.PerformLayout();
            pnlAbout.ResumeLayout(false);
            pnlAbout.PerformLayout();
            pnlUnliAttemptConfirmation.ResumeLayout(false);
            pnlUnliAttemptConfirmation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Panel pnlMainMenu;
        private Panel pnlLanguage;
        private Button btnEnglish;
        private Button btnTagalog;
        private Panel pnlDifficulty;
        private Button btnHard;
        private Button btnMedium;
        private Button btnEasy;
        private Panel pnlGameMode;
        private Button btn2Player;
        private Button btn1Player;
        private Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnBackDifficulty;
        private Button btnBackGameMode;
        private Button btnBackLanguage;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAbout;
        private Panel pnlAbout;
        private Label lblInstructions;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnBackAbout;
        private Panel pnlUnliAttemptConfirmation;
        private Label label11;
        private Button btnUnliAttemptBack;
        private Button btnUnliAttemptDecline;
        private Button btnUnliAttemptConfirm;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}
