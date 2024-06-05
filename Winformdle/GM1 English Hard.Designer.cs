namespace Winformdle
{
    partial class game1EnglishHard
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
            pnlConfirmation = new Panel();
            btnBack = new Button();
            btnMainMenu = new Button();
            lblInstructions = new Label();
            pnlGame = new Panel();
            btnOptions = new Button();
            panel1 = new Panel();
            attempt6Char7 = new TextBox();
            attempt5Char7 = new TextBox();
            attempt4Char7 = new TextBox();
            attempt3Char7 = new TextBox();
            attempt2Char7 = new TextBox();
            attempt1Char7 = new TextBox();
            attempt6Char6 = new TextBox();
            attempt5Char6 = new TextBox();
            attempt4Char6 = new TextBox();
            attempt3Char6 = new TextBox();
            attempt2Char6 = new TextBox();
            attempt1Char6 = new TextBox();
            attempt6Char5 = new TextBox();
            attempt6Char4 = new TextBox();
            attempt6Char3 = new TextBox();
            attempt6Char2 = new TextBox();
            attempt6Char1 = new TextBox();
            attempt5Char5 = new TextBox();
            attempt5Char4 = new TextBox();
            attempt5Char3 = new TextBox();
            attempt5Char2 = new TextBox();
            attempt5Char1 = new TextBox();
            attempt4Char5 = new TextBox();
            attempt4Char4 = new TextBox();
            attempt4Char3 = new TextBox();
            attempt4Char2 = new TextBox();
            attempt4Char1 = new TextBox();
            attempt3Char5 = new TextBox();
            attempt3Char4 = new TextBox();
            attempt3Char3 = new TextBox();
            attempt3Char2 = new TextBox();
            attempt3Char1 = new TextBox();
            attempt2Char5 = new TextBox();
            attempt2Char4 = new TextBox();
            attempt2Char3 = new TextBox();
            attempt2Char2 = new TextBox();
            attempt2Char1 = new TextBox();
            attempt1Char5 = new TextBox();
            attempt1Char4 = new TextBox();
            attempt1Char3 = new TextBox();
            attempt1Char2 = new TextBox();
            attempt1Char1 = new TextBox();
            enterBtn = new Button();
            mBtn = new Button();
            nBtn = new Button();
            bBtn = new Button();
            vBtn = new Button();
            cBtn = new Button();
            xBtn = new Button();
            zBtn = new Button();
            backspaceBtn = new Button();
            button20 = new Button();
            lBtn = new Button();
            kBtn = new Button();
            jBtn = new Button();
            hBtn = new Button();
            gBtn = new Button();
            fBtn = new Button();
            dBtn = new Button();
            sBtn = new Button();
            aBtn = new Button();
            pBtn = new Button();
            oBtn = new Button();
            iBtn = new Button();
            uBtn = new Button();
            yBtn = new Button();
            tBtn = new Button();
            rBtn = new Button();
            eBtn = new Button();
            wBtn = new Button();
            qBtn = new Button();
            pnlOptions = new Panel();
            btnBackOptions = new Button();
            btnBacktoMain = new Button();
            btnAddWord = new Button();
            lblOptions = new Label();
            pnlAddWord = new Panel();
            label2 = new Label();
            lblAddWord = new Label();
            txtAddWord = new TextBox();
            btnAddWordBack = new Button();
            btnAddWordConfirm = new Button();
            pnlConfirmation.SuspendLayout();
            pnlGame.SuspendLayout();
            pnlOptions.SuspendLayout();
            pnlAddWord.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConfirmation
            // 
            pnlConfirmation.BackgroundImage = Properties.Resources.BG;
            pnlConfirmation.BackgroundImageLayout = ImageLayout.Stretch;
            pnlConfirmation.Controls.Add(btnBack);
            pnlConfirmation.Controls.Add(btnMainMenu);
            pnlConfirmation.Controls.Add(lblInstructions);
            pnlConfirmation.Dock = DockStyle.Fill;
            pnlConfirmation.Location = new Point(0, 0);
            pnlConfirmation.Name = "pnlConfirmation";
            pnlConfirmation.Size = new Size(511, 579);
            pnlConfirmation.TabIndex = 233;
            pnlConfirmation.Visible = false;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Black;
            btnBack.FlatAppearance.BorderSize = 34;
            btnBack.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = Properties.Resources.Back_word_button;
            btnBack.Location = new Point(96, 268);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 71);
            btnBack.TabIndex = 8;
            btnBack.Tag = "";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.FlatAppearance.BorderColor = Color.Black;
            btnMainMenu.FlatAppearance.BorderSize = 34;
            btnMainMenu.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Image = Properties.Resources.confirm_button;
            btnMainMenu.Location = new Point(292, 268);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(154, 71);
            btnMainMenu.TabIndex = 7;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.Transparent;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(12, 155);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(495, 42);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "ARE YOU SURE YOU WANTED TO GO BACK TO THE MAIN MENU?\r\nTHE GAME PROGRESS WOULD BE LOST\r\n";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGame
            // 
            pnlGame.BackgroundImage = Properties.Resources.BG;
            pnlGame.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGame.Controls.Add(btnOptions);
            pnlGame.Controls.Add(panel1);
            pnlGame.Controls.Add(attempt6Char7);
            pnlGame.Controls.Add(attempt5Char7);
            pnlGame.Controls.Add(attempt4Char7);
            pnlGame.Controls.Add(attempt3Char7);
            pnlGame.Controls.Add(attempt2Char7);
            pnlGame.Controls.Add(attempt1Char7);
            pnlGame.Controls.Add(attempt6Char6);
            pnlGame.Controls.Add(attempt5Char6);
            pnlGame.Controls.Add(attempt4Char6);
            pnlGame.Controls.Add(attempt3Char6);
            pnlGame.Controls.Add(attempt2Char6);
            pnlGame.Controls.Add(attempt1Char6);
            pnlGame.Controls.Add(attempt6Char5);
            pnlGame.Controls.Add(attempt6Char4);
            pnlGame.Controls.Add(attempt6Char3);
            pnlGame.Controls.Add(attempt6Char2);
            pnlGame.Controls.Add(attempt6Char1);
            pnlGame.Controls.Add(attempt5Char5);
            pnlGame.Controls.Add(attempt5Char4);
            pnlGame.Controls.Add(attempt5Char3);
            pnlGame.Controls.Add(attempt5Char2);
            pnlGame.Controls.Add(attempt5Char1);
            pnlGame.Controls.Add(attempt4Char5);
            pnlGame.Controls.Add(attempt4Char4);
            pnlGame.Controls.Add(attempt4Char3);
            pnlGame.Controls.Add(attempt4Char2);
            pnlGame.Controls.Add(attempt4Char1);
            pnlGame.Controls.Add(attempt3Char5);
            pnlGame.Controls.Add(attempt3Char4);
            pnlGame.Controls.Add(attempt3Char3);
            pnlGame.Controls.Add(attempt3Char2);
            pnlGame.Controls.Add(attempt3Char1);
            pnlGame.Controls.Add(attempt2Char5);
            pnlGame.Controls.Add(attempt2Char4);
            pnlGame.Controls.Add(attempt2Char3);
            pnlGame.Controls.Add(attempt2Char2);
            pnlGame.Controls.Add(attempt2Char1);
            pnlGame.Controls.Add(attempt1Char5);
            pnlGame.Controls.Add(attempt1Char4);
            pnlGame.Controls.Add(attempt1Char3);
            pnlGame.Controls.Add(attempt1Char2);
            pnlGame.Controls.Add(attempt1Char1);
            pnlGame.Controls.Add(enterBtn);
            pnlGame.Controls.Add(mBtn);
            pnlGame.Controls.Add(nBtn);
            pnlGame.Controls.Add(bBtn);
            pnlGame.Controls.Add(vBtn);
            pnlGame.Controls.Add(cBtn);
            pnlGame.Controls.Add(xBtn);
            pnlGame.Controls.Add(zBtn);
            pnlGame.Controls.Add(backspaceBtn);
            pnlGame.Controls.Add(button20);
            pnlGame.Controls.Add(lBtn);
            pnlGame.Controls.Add(kBtn);
            pnlGame.Controls.Add(jBtn);
            pnlGame.Controls.Add(hBtn);
            pnlGame.Controls.Add(gBtn);
            pnlGame.Controls.Add(fBtn);
            pnlGame.Controls.Add(dBtn);
            pnlGame.Controls.Add(sBtn);
            pnlGame.Controls.Add(aBtn);
            pnlGame.Controls.Add(pBtn);
            pnlGame.Controls.Add(oBtn);
            pnlGame.Controls.Add(iBtn);
            pnlGame.Controls.Add(uBtn);
            pnlGame.Controls.Add(yBtn);
            pnlGame.Controls.Add(tBtn);
            pnlGame.Controls.Add(rBtn);
            pnlGame.Controls.Add(eBtn);
            pnlGame.Controls.Add(wBtn);
            pnlGame.Controls.Add(qBtn);
            pnlGame.Dock = DockStyle.Fill;
            pnlGame.Location = new Point(0, 0);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(511, 579);
            pnlGame.TabIndex = 234;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.White;
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOptions.Image = Properties.Resources.back_button;
            btnOptions.Location = new Point(0, 0);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(43, 43);
            btnOptions.TabIndex = 379;
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_fixed;
            panel1.Location = new Point(153, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 48);
            panel1.TabIndex = 378;
            // 
            // attempt6Char7
            // 
            attempt6Char7.Enabled = false;
            attempt6Char7.Location = new Point(380, 341);
            attempt6Char7.Multiline = true;
            attempt6Char7.Name = "attempt6Char7";
            attempt6Char7.Size = new Size(43, 40);
            attempt6Char7.TabIndex = 377;
            // 
            // attempt5Char7
            // 
            attempt5Char7.Enabled = false;
            attempt5Char7.Location = new Point(380, 295);
            attempt5Char7.Multiline = true;
            attempt5Char7.Name = "attempt5Char7";
            attempt5Char7.Size = new Size(43, 40);
            attempt5Char7.TabIndex = 376;
            // 
            // attempt4Char7
            // 
            attempt4Char7.Enabled = false;
            attempt4Char7.Location = new Point(380, 249);
            attempt4Char7.Multiline = true;
            attempt4Char7.Name = "attempt4Char7";
            attempt4Char7.Size = new Size(43, 40);
            attempt4Char7.TabIndex = 375;
            // 
            // attempt3Char7
            // 
            attempt3Char7.Enabled = false;
            attempt3Char7.Location = new Point(381, 203);
            attempt3Char7.Multiline = true;
            attempt3Char7.Name = "attempt3Char7";
            attempt3Char7.Size = new Size(43, 40);
            attempt3Char7.TabIndex = 374;
            // 
            // attempt2Char7
            // 
            attempt2Char7.Enabled = false;
            attempt2Char7.Location = new Point(381, 157);
            attempt2Char7.Multiline = true;
            attempt2Char7.Name = "attempt2Char7";
            attempt2Char7.Size = new Size(43, 40);
            attempt2Char7.TabIndex = 373;
            // 
            // attempt1Char7
            // 
            attempt1Char7.Enabled = false;
            attempt1Char7.Location = new Point(380, 111);
            attempt1Char7.Multiline = true;
            attempt1Char7.Name = "attempt1Char7";
            attempt1Char7.Size = new Size(43, 40);
            attempt1Char7.TabIndex = 372;
            // 
            // attempt6Char6
            // 
            attempt6Char6.Enabled = false;
            attempt6Char6.Location = new Point(331, 341);
            attempt6Char6.Multiline = true;
            attempt6Char6.Name = "attempt6Char6";
            attempt6Char6.Size = new Size(43, 40);
            attempt6Char6.TabIndex = 371;
            // 
            // attempt5Char6
            // 
            attempt5Char6.Enabled = false;
            attempt5Char6.Location = new Point(331, 295);
            attempt5Char6.Multiline = true;
            attempt5Char6.Name = "attempt5Char6";
            attempt5Char6.Size = new Size(43, 40);
            attempt5Char6.TabIndex = 370;
            // 
            // attempt4Char6
            // 
            attempt4Char6.Enabled = false;
            attempt4Char6.Location = new Point(331, 249);
            attempt4Char6.Multiline = true;
            attempt4Char6.Name = "attempt4Char6";
            attempt4Char6.Size = new Size(43, 40);
            attempt4Char6.TabIndex = 369;
            // 
            // attempt3Char6
            // 
            attempt3Char6.Enabled = false;
            attempt3Char6.Location = new Point(332, 203);
            attempt3Char6.Multiline = true;
            attempt3Char6.Name = "attempt3Char6";
            attempt3Char6.Size = new Size(43, 40);
            attempt3Char6.TabIndex = 368;
            // 
            // attempt2Char6
            // 
            attempt2Char6.Enabled = false;
            attempt2Char6.Location = new Point(332, 157);
            attempt2Char6.Multiline = true;
            attempt2Char6.Name = "attempt2Char6";
            attempt2Char6.Size = new Size(43, 40);
            attempt2Char6.TabIndex = 367;
            // 
            // attempt1Char6
            // 
            attempt1Char6.Enabled = false;
            attempt1Char6.Location = new Point(331, 111);
            attempt1Char6.Multiline = true;
            attempt1Char6.Name = "attempt1Char6";
            attempt1Char6.Size = new Size(43, 40);
            attempt1Char6.TabIndex = 366;
            // 
            // attempt6Char5
            // 
            attempt6Char5.Enabled = false;
            attempt6Char5.Location = new Point(282, 341);
            attempt6Char5.Multiline = true;
            attempt6Char5.Name = "attempt6Char5";
            attempt6Char5.Size = new Size(43, 40);
            attempt6Char5.TabIndex = 365;
            // 
            // attempt6Char4
            // 
            attempt6Char4.Enabled = false;
            attempt6Char4.Location = new Point(233, 341);
            attempt6Char4.Multiline = true;
            attempt6Char4.Name = "attempt6Char4";
            attempt6Char4.Size = new Size(43, 40);
            attempt6Char4.TabIndex = 364;
            // 
            // attempt6Char3
            // 
            attempt6Char3.Enabled = false;
            attempt6Char3.Location = new Point(184, 341);
            attempt6Char3.Multiline = true;
            attempt6Char3.Name = "attempt6Char3";
            attempt6Char3.Size = new Size(43, 40);
            attempt6Char3.TabIndex = 363;
            // 
            // attempt6Char2
            // 
            attempt6Char2.Enabled = false;
            attempt6Char2.Location = new Point(135, 341);
            attempt6Char2.Multiline = true;
            attempt6Char2.Name = "attempt6Char2";
            attempt6Char2.Size = new Size(43, 40);
            attempt6Char2.TabIndex = 362;
            // 
            // attempt6Char1
            // 
            attempt6Char1.Enabled = false;
            attempt6Char1.Location = new Point(85, 341);
            attempt6Char1.Multiline = true;
            attempt6Char1.Name = "attempt6Char1";
            attempt6Char1.Size = new Size(43, 40);
            attempt6Char1.TabIndex = 361;
            // 
            // attempt5Char5
            // 
            attempt5Char5.Enabled = false;
            attempt5Char5.Location = new Point(282, 295);
            attempt5Char5.Multiline = true;
            attempt5Char5.Name = "attempt5Char5";
            attempt5Char5.Size = new Size(43, 40);
            attempt5Char5.TabIndex = 360;
            // 
            // attempt5Char4
            // 
            attempt5Char4.Enabled = false;
            attempt5Char4.Location = new Point(233, 295);
            attempt5Char4.Multiline = true;
            attempt5Char4.Name = "attempt5Char4";
            attempt5Char4.Size = new Size(43, 40);
            attempt5Char4.TabIndex = 359;
            // 
            // attempt5Char3
            // 
            attempt5Char3.Enabled = false;
            attempt5Char3.Location = new Point(184, 295);
            attempt5Char3.Multiline = true;
            attempt5Char3.Name = "attempt5Char3";
            attempt5Char3.Size = new Size(43, 40);
            attempt5Char3.TabIndex = 358;
            // 
            // attempt5Char2
            // 
            attempt5Char2.Enabled = false;
            attempt5Char2.Location = new Point(135, 295);
            attempt5Char2.Multiline = true;
            attempt5Char2.Name = "attempt5Char2";
            attempt5Char2.Size = new Size(43, 40);
            attempt5Char2.TabIndex = 357;
            // 
            // attempt5Char1
            // 
            attempt5Char1.Enabled = false;
            attempt5Char1.Location = new Point(86, 295);
            attempt5Char1.Multiline = true;
            attempt5Char1.Name = "attempt5Char1";
            attempt5Char1.Size = new Size(43, 40);
            attempt5Char1.TabIndex = 356;
            // 
            // attempt4Char5
            // 
            attempt4Char5.Enabled = false;
            attempt4Char5.Location = new Point(282, 249);
            attempt4Char5.Multiline = true;
            attempt4Char5.Name = "attempt4Char5";
            attempt4Char5.Size = new Size(43, 40);
            attempt4Char5.TabIndex = 355;
            // 
            // attempt4Char4
            // 
            attempt4Char4.Enabled = false;
            attempt4Char4.Location = new Point(233, 249);
            attempt4Char4.Multiline = true;
            attempt4Char4.Name = "attempt4Char4";
            attempt4Char4.Size = new Size(43, 40);
            attempt4Char4.TabIndex = 354;
            // 
            // attempt4Char3
            // 
            attempt4Char3.Enabled = false;
            attempt4Char3.Location = new Point(184, 249);
            attempt4Char3.Multiline = true;
            attempt4Char3.Name = "attempt4Char3";
            attempt4Char3.Size = new Size(43, 40);
            attempt4Char3.TabIndex = 353;
            // 
            // attempt4Char2
            // 
            attempt4Char2.Enabled = false;
            attempt4Char2.Location = new Point(135, 249);
            attempt4Char2.Multiline = true;
            attempt4Char2.Name = "attempt4Char2";
            attempt4Char2.Size = new Size(43, 40);
            attempt4Char2.TabIndex = 352;
            // 
            // attempt4Char1
            // 
            attempt4Char1.Enabled = false;
            attempt4Char1.Location = new Point(86, 249);
            attempt4Char1.Multiline = true;
            attempt4Char1.Name = "attempt4Char1";
            attempt4Char1.Size = new Size(43, 40);
            attempt4Char1.TabIndex = 351;
            // 
            // attempt3Char5
            // 
            attempt3Char5.Enabled = false;
            attempt3Char5.Location = new Point(282, 203);
            attempt3Char5.Multiline = true;
            attempt3Char5.Name = "attempt3Char5";
            attempt3Char5.Size = new Size(43, 40);
            attempt3Char5.TabIndex = 350;
            // 
            // attempt3Char4
            // 
            attempt3Char4.Enabled = false;
            attempt3Char4.Location = new Point(233, 203);
            attempt3Char4.Multiline = true;
            attempt3Char4.Name = "attempt3Char4";
            attempt3Char4.Size = new Size(43, 40);
            attempt3Char4.TabIndex = 349;
            // 
            // attempt3Char3
            // 
            attempt3Char3.Enabled = false;
            attempt3Char3.Location = new Point(184, 203);
            attempt3Char3.Multiline = true;
            attempt3Char3.Name = "attempt3Char3";
            attempt3Char3.Size = new Size(43, 40);
            attempt3Char3.TabIndex = 348;
            // 
            // attempt3Char2
            // 
            attempt3Char2.Enabled = false;
            attempt3Char2.Location = new Point(135, 203);
            attempt3Char2.Multiline = true;
            attempt3Char2.Name = "attempt3Char2";
            attempt3Char2.Size = new Size(43, 40);
            attempt3Char2.TabIndex = 347;
            // 
            // attempt3Char1
            // 
            attempt3Char1.Enabled = false;
            attempt3Char1.Location = new Point(86, 203);
            attempt3Char1.Multiline = true;
            attempt3Char1.Name = "attempt3Char1";
            attempt3Char1.Size = new Size(43, 40);
            attempt3Char1.TabIndex = 346;
            // 
            // attempt2Char5
            // 
            attempt2Char5.Enabled = false;
            attempt2Char5.Location = new Point(283, 157);
            attempt2Char5.Multiline = true;
            attempt2Char5.Name = "attempt2Char5";
            attempt2Char5.Size = new Size(43, 40);
            attempt2Char5.TabIndex = 345;
            // 
            // attempt2Char4
            // 
            attempt2Char4.Enabled = false;
            attempt2Char4.Location = new Point(233, 157);
            attempt2Char4.Multiline = true;
            attempt2Char4.Name = "attempt2Char4";
            attempt2Char4.Size = new Size(43, 40);
            attempt2Char4.TabIndex = 344;
            // 
            // attempt2Char3
            // 
            attempt2Char3.Enabled = false;
            attempt2Char3.Location = new Point(184, 157);
            attempt2Char3.Multiline = true;
            attempt2Char3.Name = "attempt2Char3";
            attempt2Char3.Size = new Size(43, 40);
            attempt2Char3.TabIndex = 343;
            // 
            // attempt2Char2
            // 
            attempt2Char2.Enabled = false;
            attempt2Char2.Location = new Point(135, 157);
            attempt2Char2.Multiline = true;
            attempt2Char2.Name = "attempt2Char2";
            attempt2Char2.Size = new Size(43, 40);
            attempt2Char2.TabIndex = 342;
            // 
            // attempt2Char1
            // 
            attempt2Char1.Enabled = false;
            attempt2Char1.Location = new Point(86, 157);
            attempt2Char1.Multiline = true;
            attempt2Char1.Name = "attempt2Char1";
            attempt2Char1.Size = new Size(43, 40);
            attempt2Char1.TabIndex = 341;
            // 
            // attempt1Char5
            // 
            attempt1Char5.Enabled = false;
            attempt1Char5.Location = new Point(282, 111);
            attempt1Char5.Multiline = true;
            attempt1Char5.Name = "attempt1Char5";
            attempt1Char5.Size = new Size(43, 40);
            attempt1Char5.TabIndex = 340;
            // 
            // attempt1Char4
            // 
            attempt1Char4.Enabled = false;
            attempt1Char4.Location = new Point(233, 111);
            attempt1Char4.Multiline = true;
            attempt1Char4.Name = "attempt1Char4";
            attempt1Char4.Size = new Size(43, 40);
            attempt1Char4.TabIndex = 339;
            // 
            // attempt1Char3
            // 
            attempt1Char3.Enabled = false;
            attempt1Char3.Location = new Point(184, 111);
            attempt1Char3.Multiline = true;
            attempt1Char3.Name = "attempt1Char3";
            attempt1Char3.Size = new Size(43, 40);
            attempt1Char3.TabIndex = 338;
            // 
            // attempt1Char2
            // 
            attempt1Char2.Enabled = false;
            attempt1Char2.Location = new Point(135, 111);
            attempt1Char2.Multiline = true;
            attempt1Char2.Name = "attempt1Char2";
            attempt1Char2.Size = new Size(43, 40);
            attempt1Char2.TabIndex = 337;
            // 
            // attempt1Char1
            // 
            attempt1Char1.Enabled = false;
            attempt1Char1.Location = new Point(86, 111);
            attempt1Char1.Multiline = true;
            attempt1Char1.Name = "attempt1Char1";
            attempt1Char1.Size = new Size(43, 40);
            attempt1Char1.TabIndex = 336;
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(441, 502);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(57, 40);
            enterBtn.TabIndex = 335;
            enterBtn.Text = "enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // mBtn
            // 
            mBtn.Location = new Point(390, 502);
            mBtn.Name = "mBtn";
            mBtn.Size = new Size(46, 40);
            mBtn.TabIndex = 334;
            mBtn.Text = "M";
            mBtn.UseVisualStyleBackColor = true;
            mBtn.Click += mBtn_Click;
            // 
            // nBtn
            // 
            nBtn.Location = new Point(339, 502);
            nBtn.Name = "nBtn";
            nBtn.Size = new Size(46, 40);
            nBtn.TabIndex = 333;
            nBtn.Text = "N";
            nBtn.UseVisualStyleBackColor = true;
            nBtn.Click += nBtn_Click;
            // 
            // bBtn
            // 
            bBtn.Location = new Point(288, 502);
            bBtn.Name = "bBtn";
            bBtn.Size = new Size(46, 40);
            bBtn.TabIndex = 332;
            bBtn.Text = "B";
            bBtn.UseVisualStyleBackColor = true;
            bBtn.Click += bBtn_Click;
            // 
            // vBtn
            // 
            vBtn.Location = new Point(237, 502);
            vBtn.Name = "vBtn";
            vBtn.Size = new Size(46, 40);
            vBtn.TabIndex = 331;
            vBtn.Text = "V";
            vBtn.UseVisualStyleBackColor = true;
            vBtn.Click += vBtn_Click;
            // 
            // cBtn
            // 
            cBtn.Location = new Point(186, 502);
            cBtn.Name = "cBtn";
            cBtn.Size = new Size(46, 40);
            cBtn.TabIndex = 330;
            cBtn.Text = "C";
            cBtn.UseVisualStyleBackColor = true;
            cBtn.Click += cBtn_Click;
            // 
            // xBtn
            // 
            xBtn.Location = new Point(135, 502);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(46, 40);
            xBtn.TabIndex = 329;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = true;
            xBtn.Click += xBtn_Click;
            // 
            // zBtn
            // 
            zBtn.Location = new Point(84, 502);
            zBtn.Name = "zBtn";
            zBtn.Size = new Size(46, 40);
            zBtn.TabIndex = 328;
            zBtn.Text = "Z";
            zBtn.UseVisualStyleBackColor = true;
            zBtn.Click += zBtn_Click;
            // 
            // backspaceBtn
            // 
            backspaceBtn.Location = new Point(14, 502);
            backspaceBtn.Name = "backspaceBtn";
            backspaceBtn.Size = new Size(65, 40);
            backspaceBtn.TabIndex = 327;
            backspaceBtn.Text = "back";
            backspaceBtn.UseVisualStyleBackColor = true;
            backspaceBtn.Click += backspaceBtn_Click;
            // 
            // button20
            // 
            button20.Enabled = false;
            button20.Location = new Point(172, 349);
            button20.Name = "button20";
            button20.Size = new Size(0, 0);
            button20.TabIndex = 326;
            button20.UseVisualStyleBackColor = true;
            // 
            // lBtn
            // 
            lBtn.Location = new Point(434, 456);
            lBtn.Name = "lBtn";
            lBtn.Size = new Size(46, 40);
            lBtn.TabIndex = 325;
            lBtn.Text = "L";
            lBtn.UseVisualStyleBackColor = true;
            lBtn.Click += lBtn_Click;
            // 
            // kBtn
            // 
            kBtn.Location = new Point(383, 456);
            kBtn.Name = "kBtn";
            kBtn.Size = new Size(46, 40);
            kBtn.TabIndex = 324;
            kBtn.Text = "K";
            kBtn.UseVisualStyleBackColor = true;
            kBtn.Click += kBtn_Click;
            // 
            // jBtn
            // 
            jBtn.Location = new Point(332, 456);
            jBtn.Name = "jBtn";
            jBtn.Size = new Size(46, 40);
            jBtn.TabIndex = 323;
            jBtn.Text = "J";
            jBtn.UseVisualStyleBackColor = true;
            jBtn.Click += jBtn_Click;
            // 
            // hBtn
            // 
            hBtn.Location = new Point(281, 456);
            hBtn.Name = "hBtn";
            hBtn.Size = new Size(46, 40);
            hBtn.TabIndex = 322;
            hBtn.Text = "H";
            hBtn.UseVisualStyleBackColor = true;
            hBtn.Click += hBtn_Click;
            // 
            // gBtn
            // 
            gBtn.Location = new Point(230, 456);
            gBtn.Name = "gBtn";
            gBtn.Size = new Size(46, 40);
            gBtn.TabIndex = 321;
            gBtn.Text = "G";
            gBtn.UseVisualStyleBackColor = true;
            gBtn.Click += gBtn_Click;
            // 
            // fBtn
            // 
            fBtn.Location = new Point(179, 456);
            fBtn.Name = "fBtn";
            fBtn.Size = new Size(46, 40);
            fBtn.TabIndex = 320;
            fBtn.Text = "F";
            fBtn.UseVisualStyleBackColor = true;
            fBtn.Click += fBtn_Click;
            // 
            // dBtn
            // 
            dBtn.Location = new Point(128, 456);
            dBtn.Name = "dBtn";
            dBtn.Size = new Size(46, 40);
            dBtn.TabIndex = 319;
            dBtn.Text = "D";
            dBtn.UseVisualStyleBackColor = true;
            dBtn.Click += dBtn_Click;
            // 
            // sBtn
            // 
            sBtn.Location = new Point(77, 456);
            sBtn.Name = "sBtn";
            sBtn.Size = new Size(46, 40);
            sBtn.TabIndex = 318;
            sBtn.Text = "S";
            sBtn.UseVisualStyleBackColor = true;
            sBtn.Click += sBtn_Click;
            // 
            // aBtn
            // 
            aBtn.Location = new Point(26, 456);
            aBtn.Name = "aBtn";
            aBtn.Size = new Size(46, 40);
            aBtn.TabIndex = 317;
            aBtn.Text = "A";
            aBtn.UseVisualStyleBackColor = true;
            aBtn.Click += aBtn_Click;
            // 
            // pBtn
            // 
            pBtn.Location = new Point(455, 410);
            pBtn.Name = "pBtn";
            pBtn.Size = new Size(43, 40);
            pBtn.TabIndex = 316;
            pBtn.Text = "P";
            pBtn.UseVisualStyleBackColor = true;
            pBtn.Click += pBtn_Click;
            // 
            // oBtn
            // 
            oBtn.Location = new Point(406, 410);
            oBtn.Name = "oBtn";
            oBtn.Size = new Size(43, 40);
            oBtn.TabIndex = 315;
            oBtn.Text = "O";
            oBtn.UseVisualStyleBackColor = true;
            oBtn.Click += oBtn_Click;
            // 
            // iBtn
            // 
            iBtn.Location = new Point(357, 410);
            iBtn.Name = "iBtn";
            iBtn.Size = new Size(43, 40);
            iBtn.TabIndex = 314;
            iBtn.Text = "I";
            iBtn.UseVisualStyleBackColor = true;
            iBtn.Click += iBtn_Click;
            // 
            // uBtn
            // 
            uBtn.Location = new Point(308, 410);
            uBtn.Name = "uBtn";
            uBtn.Size = new Size(43, 40);
            uBtn.TabIndex = 313;
            uBtn.Text = "U";
            uBtn.UseVisualStyleBackColor = true;
            uBtn.Click += uBtn_Click;
            // 
            // yBtn
            // 
            yBtn.Location = new Point(259, 410);
            yBtn.Name = "yBtn";
            yBtn.Size = new Size(43, 40);
            yBtn.TabIndex = 312;
            yBtn.Text = "Y";
            yBtn.UseVisualStyleBackColor = true;
            yBtn.Click += yBtn_Click;
            // 
            // tBtn
            // 
            tBtn.Location = new Point(210, 410);
            tBtn.Name = "tBtn";
            tBtn.Size = new Size(43, 40);
            tBtn.TabIndex = 311;
            tBtn.Text = "T";
            tBtn.UseVisualStyleBackColor = true;
            tBtn.Click += tBtn_Click;
            // 
            // rBtn
            // 
            rBtn.Location = new Point(161, 410);
            rBtn.Name = "rBtn";
            rBtn.Size = new Size(43, 40);
            rBtn.TabIndex = 310;
            rBtn.Text = "R";
            rBtn.UseVisualStyleBackColor = true;
            rBtn.Click += rBtn_Click;
            // 
            // eBtn
            // 
            eBtn.Location = new Point(112, 410);
            eBtn.Name = "eBtn";
            eBtn.Size = new Size(43, 40);
            eBtn.TabIndex = 309;
            eBtn.Text = "E";
            eBtn.UseVisualStyleBackColor = true;
            eBtn.Click += eBtn_Click;
            // 
            // wBtn
            // 
            wBtn.Location = new Point(63, 410);
            wBtn.Name = "wBtn";
            wBtn.Size = new Size(43, 40);
            wBtn.TabIndex = 308;
            wBtn.Text = "W";
            wBtn.UseVisualStyleBackColor = true;
            wBtn.Click += wBtn_Click;
            // 
            // qBtn
            // 
            qBtn.Location = new Point(14, 410);
            qBtn.Name = "qBtn";
            qBtn.Size = new Size(43, 40);
            qBtn.TabIndex = 307;
            qBtn.Text = "Q";
            qBtn.UseVisualStyleBackColor = true;
            qBtn.Click += qBtn_Click;
            // 
            // pnlOptions
            // 
            pnlOptions.BackgroundImage = Properties.Resources.BG;
            pnlOptions.BackgroundImageLayout = ImageLayout.Stretch;
            pnlOptions.Controls.Add(btnBackOptions);
            pnlOptions.Controls.Add(btnBacktoMain);
            pnlOptions.Controls.Add(btnAddWord);
            pnlOptions.Controls.Add(lblOptions);
            pnlOptions.Dock = DockStyle.Fill;
            pnlOptions.Location = new Point(0, 0);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(511, 579);
            pnlOptions.TabIndex = 235;
            pnlOptions.Visible = false;
            // 
            // btnBackOptions
            // 
            btnBackOptions.FlatAppearance.BorderColor = Color.Black;
            btnBackOptions.FlatAppearance.BorderSize = 34;
            btnBackOptions.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackOptions.Image = Properties.Resources.Back_word_button;
            btnBackOptions.Location = new Point(188, 361);
            btnBackOptions.Name = "btnBackOptions";
            btnBackOptions.Size = new Size(154, 71);
            btnBackOptions.TabIndex = 12;
            btnBackOptions.UseVisualStyleBackColor = true;
            btnBackOptions.Click += btnBackOptions_Click;
            // 
            // btnBacktoMain
            // 
            btnBacktoMain.FlatAppearance.BorderColor = Color.Black;
            btnBacktoMain.FlatAppearance.BorderSize = 34;
            btnBacktoMain.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBacktoMain.Image = Properties.Resources.BACK_TO_MAIN_MENU;
            btnBacktoMain.Location = new Point(188, 159);
            btnBacktoMain.Name = "btnBacktoMain";
            btnBacktoMain.Size = new Size(154, 71);
            btnBacktoMain.TabIndex = 11;
            btnBacktoMain.Tag = "";
            btnBacktoMain.UseVisualStyleBackColor = true;
            btnBacktoMain.Click += btnBacktoMain_Click;
            // 
            // btnAddWord
            // 
            btnAddWord.FlatAppearance.BorderColor = Color.Black;
            btnAddWord.FlatAppearance.BorderSize = 34;
            btnAddWord.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddWord.Image = Properties.Resources.Add_A_New_Word;
            btnAddWord.Location = new Point(188, 261);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(154, 71);
            btnAddWord.TabIndex = 10;
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.BackColor = Color.Transparent;
            lblOptions.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOptions.ForeColor = SystemColors.ButtonFace;
            lblOptions.Location = new Point(210, 115);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(101, 29);
            lblOptions.TabIndex = 9;
            lblOptions.Text = "OPTIONS";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAddWord
            // 
            pnlAddWord.BackgroundImage = Properties.Resources.BG;
            pnlAddWord.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAddWord.Controls.Add(label2);
            pnlAddWord.Controls.Add(lblAddWord);
            pnlAddWord.Controls.Add(txtAddWord);
            pnlAddWord.Controls.Add(btnAddWordBack);
            pnlAddWord.Controls.Add(btnAddWordConfirm);
            pnlAddWord.Dock = DockStyle.Fill;
            pnlAddWord.Location = new Point(0, 0);
            pnlAddWord.Name = "pnlAddWord";
            pnlAddWord.Size = new Size(511, 579);
            pnlAddWord.TabIndex = 236;
            pnlAddWord.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(94, 159);
            label2.Name = "label2";
            label2.Size = new Size(342, 92);
            label2.TabIndex = 238;
            label2.Text = "Note: the word you have added might\r\n have a small chance to appear in the\r\n next few games, and the word you are\r\ncurrently guessing will get changed";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddWord
            // 
            lblAddWord.AutoSize = true;
            lblAddWord.BackColor = Color.Transparent;
            lblAddWord.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWord.ForeColor = Color.WhiteSmoke;
            lblAddWord.Location = new Point(63, 73);
            lblAddWord.Name = "lblAddWord";
            lblAddWord.Size = new Size(406, 58);
            lblAddWord.TabIndex = 237;
            lblAddWord.Text = "Please type the word that you wanted\r\nto add in the Word Inventory\r\n";
            lblAddWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddWord
            // 
            txtAddWord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddWord.Location = new Point(181, 295);
            txtAddWord.MaxLength = 7;
            txtAddWord.Multiline = true;
            txtAddWord.Name = "txtAddWord";
            txtAddWord.Size = new Size(164, 40);
            txtAddWord.TabIndex = 17;
            txtAddWord.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddWordBack
            // 
            btnAddWordBack.FlatAppearance.BorderColor = Color.Black;
            btnAddWordBack.FlatAppearance.BorderSize = 34;
            btnAddWordBack.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddWordBack.Image = Properties.Resources.Back_word_button;
            btnAddWordBack.Location = new Point(75, 366);
            btnAddWordBack.Name = "btnAddWordBack";
            btnAddWordBack.Size = new Size(154, 71);
            btnAddWordBack.TabIndex = 16;
            btnAddWordBack.UseVisualStyleBackColor = true;
            btnAddWordBack.Click += btnAddWordBack_Click;
            // 
            // btnAddWordConfirm
            // 
            btnAddWordConfirm.FlatAppearance.BorderColor = Color.Black;
            btnAddWordConfirm.FlatAppearance.BorderSize = 34;
            btnAddWordConfirm.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddWordConfirm.Image = Properties.Resources.Add_A_New_Word;
            btnAddWordConfirm.Location = new Point(297, 366);
            btnAddWordConfirm.Name = "btnAddWordConfirm";
            btnAddWordConfirm.Size = new Size(154, 71);
            btnAddWordConfirm.TabIndex = 14;
            btnAddWordConfirm.UseVisualStyleBackColor = true;
            btnAddWordConfirm.Click += btnAddWordConfirm_Click;
            // 
            // game1EnglishHard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(511, 579);
            Controls.Add(pnlGame);
            Controls.Add(pnlAddWord);
            Controls.Add(pnlOptions);
            Controls.Add(pnlConfirmation);
            DoubleBuffered = true;
            Name = "game1EnglishHard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdle - English, Hard";
            FormClosed += game1EnglishHard_FormClosed;
            Load += game1EnglishHard_Load;
            pnlConfirmation.ResumeLayout(false);
            pnlConfirmation.PerformLayout();
            pnlGame.ResumeLayout(false);
            pnlGame.PerformLayout();
            pnlOptions.ResumeLayout(false);
            pnlOptions.PerformLayout();
            pnlAddWord.ResumeLayout(false);
            pnlAddWord.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlConfirmation;
        private Button btnBack;
        private Button btnMainMenu;
        private Label lblInstructions;
        private Panel pnlGame;
        private Panel panel1;
        private Button btnOptions;
        private Panel pnlOptions;
        private Button btnBacktoMain;
        private Button btnAddWord;
        private Label lblOptions;
        private Panel pnlAddWord;
        private Button btnBackOptions;
        private Button btnAddWordBack;
        private Button btnAddWordConfirm;
        private Label label1;
        private Label label2;
        private Label lblAddWord;
        public static TextBox attempt6Char7;
        public static TextBox attempt5Char7;
        public static TextBox attempt4Char7;
        public static TextBox attempt3Char7;
        public static TextBox attempt2Char7;
        public static TextBox attempt1Char7;
        public static TextBox attempt6Char6;
        public static TextBox attempt5Char6;
        public static TextBox attempt4Char6;
        public static TextBox attempt3Char6;
        public static TextBox attempt2Char6;
        public static TextBox attempt1Char6;
        public static TextBox attempt6Char5;
        public static TextBox attempt6Char4;
        public static TextBox attempt6Char3;
        public static TextBox attempt6Char2;
        public static TextBox attempt6Char1;
        public static TextBox attempt5Char5;
        public static TextBox attempt5Char4;
        public static TextBox attempt5Char3;
        public static TextBox attempt5Char2;
        public static TextBox attempt5Char1;
        public static TextBox attempt4Char5;
        public static TextBox attempt4Char4;
        public static TextBox attempt4Char3;
        public static TextBox attempt4Char2;
        public static TextBox attempt4Char1;
        public static TextBox attempt3Char5;
        public static TextBox attempt3Char4;
        public static TextBox attempt3Char3;
        public static TextBox attempt3Char2;
        public static TextBox attempt3Char1;
        public static TextBox attempt2Char5;
        public static TextBox attempt2Char4;
        public static TextBox attempt2Char3;
        public static TextBox attempt2Char2;
        public static TextBox attempt2Char1;
        public static TextBox attempt1Char5;
        public static TextBox attempt1Char4;
        public static TextBox attempt1Char3;
        public static TextBox attempt1Char2;
        public static TextBox attempt1Char1;
        public static Button enterBtn;
        public static Button mBtn;
        public static Button nBtn;
        public static Button bBtn;
        public static Button vBtn;
        public static Button cBtn;
        public static Button xBtn;
        public static Button zBtn;
        public static Button backspaceBtn;
        public static Button button20;
        public static Button lBtn;
        public static Button kBtn;
        public static Button jBtn;
        public static Button hBtn;
        public static Button gBtn;
        public static Button fBtn;
        public static Button dBtn;
        public static Button sBtn;
        public static Button aBtn;
        public static Button pBtn;
        public static Button oBtn;
        public static Button iBtn;
        public static Button uBtn;
        public static Button yBtn;
        public static Button tBtn;
        public static Button rBtn;
        public static Button eBtn;
        public static Button wBtn;
        public static Button qBtn;
        public static TextBox txtAddWord;
    }
}