namespace Winformdle
{
    partial class game1EnglishEasy
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
            lblInstructions = new Label();
            btnMainMenu = new Button();
            pnlGame = new Panel();
            btnShowLastElement = new Button();
            btnShowIndex = new Button();
            btnOptions = new Button();
            panel1 = new Panel();
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
            txtAddWord = new TextBox();
            btnAddWordBack = new Button();
            btnAddWordConfirm = new Button();
            lblAddWord = new Label();
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
            pnlConfirmation.Controls.Add(lblInstructions);
            pnlConfirmation.Controls.Add(btnMainMenu);
            pnlConfirmation.Dock = DockStyle.Fill;
            pnlConfirmation.Location = new Point(0, 0);
            pnlConfirmation.Name = "pnlConfirmation";
            pnlConfirmation.Size = new Size(507, 562);
            pnlConfirmation.TabIndex = 97;
            pnlConfirmation.Visible = false;
            pnlConfirmation.Paint += pnlConfirmation_Paint;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Black;
            btnBack.FlatAppearance.BorderSize = 34;
            btnBack.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = Properties.Resources.Back_word_button;
            btnBack.Location = new Point(81, 247);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 71);
            btnBack.TabIndex = 100;
            btnBack.Tag = "";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.Transparent;
            lblInstructions.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = SystemColors.Control;
            lblInstructions.Location = new Point(61, 141);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(385, 40);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "ARE YOU SURE YOU WANTED TO GO BACK TO THE MAIN MENU?\r\nTHE GAME PROGRESS WOULD BE LOST\r\n";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMainMenu
            // 
            btnMainMenu.FlatAppearance.BorderColor = Color.Black;
            btnMainMenu.FlatAppearance.BorderSize = 34;
            btnMainMenu.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Image = Properties.Resources.confirm_button;
            btnMainMenu.Location = new Point(278, 247);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(154, 71);
            btnMainMenu.TabIndex = 99;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // pnlGame
            // 
            pnlGame.BackgroundImage = Properties.Resources.BG;
            pnlGame.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGame.Controls.Add(btnShowLastElement);
            pnlGame.Controls.Add(btnShowIndex);
            pnlGame.Controls.Add(btnOptions);
            pnlGame.Controls.Add(panel1);
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
            pnlGame.Size = new Size(507, 562);
            pnlGame.TabIndex = 98;
            // 
            // btnShowLastElement
            // 
            btnShowLastElement.Location = new Point(402, 51);
            btnShowLastElement.Name = "btnShowLastElement";
            btnShowLastElement.Size = new Size(75, 38);
            btnShowLastElement.TabIndex = 158;
            btnShowLastElement.Text = "Last Element";
            btnShowLastElement.UseVisualStyleBackColor = true;
            btnShowLastElement.Visible = false;
            btnShowLastElement.Click += btnShowLastElement_Click;
            // 
            // btnShowIndex
            // 
            btnShowIndex.Location = new Point(403, 22);
            btnShowIndex.Name = "btnShowIndex";
            btnShowIndex.Size = new Size(75, 23);
            btnShowIndex.TabIndex = 0;
            btnShowIndex.Text = "index";
            btnShowIndex.UseVisualStyleBackColor = true;
            btnShowIndex.Visible = false;
            btnShowIndex.Click += btnShowIndex_Click;
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
            btnOptions.Size = new Size(49, 45);
            btnOptions.TabIndex = 157;
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_fixed;
            panel1.Location = new Point(145, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 48);
            panel1.TabIndex = 156;
            panel1.Click += panel1_Click;
            panel1.DoubleClick += panel1_DoubleClick;
            // 
            // attempt6Char5
            // 
            attempt6Char5.Enabled = false;
            attempt6Char5.Location = new Point(332, 337);
            attempt6Char5.Multiline = true;
            attempt6Char5.Name = "attempt6Char5";
            attempt6Char5.Size = new Size(43, 40);
            attempt6Char5.TabIndex = 155;
            // 
            // attempt6Char4
            // 
            attempt6Char4.Enabled = false;
            attempt6Char4.Location = new Point(283, 337);
            attempt6Char4.Multiline = true;
            attempt6Char4.Name = "attempt6Char4";
            attempt6Char4.Size = new Size(43, 40);
            attempt6Char4.TabIndex = 154;
            // 
            // attempt6Char3
            // 
            attempt6Char3.Enabled = false;
            attempt6Char3.Location = new Point(234, 337);
            attempt6Char3.Multiline = true;
            attempt6Char3.Name = "attempt6Char3";
            attempt6Char3.Size = new Size(43, 40);
            attempt6Char3.TabIndex = 153;
            // 
            // attempt6Char2
            // 
            attempt6Char2.Enabled = false;
            attempt6Char2.Location = new Point(185, 337);
            attempt6Char2.Multiline = true;
            attempt6Char2.Name = "attempt6Char2";
            attempt6Char2.Size = new Size(43, 40);
            attempt6Char2.TabIndex = 152;
            // 
            // attempt6Char1
            // 
            attempt6Char1.Enabled = false;
            attempt6Char1.Location = new Point(135, 337);
            attempt6Char1.Multiline = true;
            attempt6Char1.Name = "attempt6Char1";
            attempt6Char1.Size = new Size(43, 40);
            attempt6Char1.TabIndex = 151;
            // 
            // attempt5Char5
            // 
            attempt5Char5.Enabled = false;
            attempt5Char5.Location = new Point(332, 291);
            attempt5Char5.Multiline = true;
            attempt5Char5.Name = "attempt5Char5";
            attempt5Char5.Size = new Size(43, 40);
            attempt5Char5.TabIndex = 150;
            // 
            // attempt5Char4
            // 
            attempt5Char4.Enabled = false;
            attempt5Char4.Location = new Point(283, 291);
            attempt5Char4.Multiline = true;
            attempt5Char4.Name = "attempt5Char4";
            attempt5Char4.Size = new Size(43, 40);
            attempt5Char4.TabIndex = 149;
            // 
            // attempt5Char3
            // 
            attempt5Char3.Enabled = false;
            attempt5Char3.Location = new Point(234, 291);
            attempt5Char3.Multiline = true;
            attempt5Char3.Name = "attempt5Char3";
            attempt5Char3.Size = new Size(43, 40);
            attempt5Char3.TabIndex = 148;
            // 
            // attempt5Char2
            // 
            attempt5Char2.Enabled = false;
            attempt5Char2.Location = new Point(185, 291);
            attempt5Char2.Multiline = true;
            attempt5Char2.Name = "attempt5Char2";
            attempt5Char2.Size = new Size(43, 40);
            attempt5Char2.TabIndex = 147;
            // 
            // attempt5Char1
            // 
            attempt5Char1.Enabled = false;
            attempt5Char1.Location = new Point(136, 291);
            attempt5Char1.Multiline = true;
            attempt5Char1.Name = "attempt5Char1";
            attempt5Char1.Size = new Size(43, 40);
            attempt5Char1.TabIndex = 146;
            // 
            // attempt4Char5
            // 
            attempt4Char5.Enabled = false;
            attempt4Char5.Location = new Point(332, 245);
            attempt4Char5.Multiline = true;
            attempt4Char5.Name = "attempt4Char5";
            attempt4Char5.Size = new Size(43, 40);
            attempt4Char5.TabIndex = 145;
            // 
            // attempt4Char4
            // 
            attempt4Char4.Enabled = false;
            attempt4Char4.Location = new Point(283, 245);
            attempt4Char4.Multiline = true;
            attempt4Char4.Name = "attempt4Char4";
            attempt4Char4.Size = new Size(43, 40);
            attempt4Char4.TabIndex = 144;
            // 
            // attempt4Char3
            // 
            attempt4Char3.Enabled = false;
            attempt4Char3.Location = new Point(234, 245);
            attempt4Char3.Multiline = true;
            attempt4Char3.Name = "attempt4Char3";
            attempt4Char3.Size = new Size(43, 40);
            attempt4Char3.TabIndex = 143;
            // 
            // attempt4Char2
            // 
            attempt4Char2.Enabled = false;
            attempt4Char2.Location = new Point(185, 245);
            attempt4Char2.Multiline = true;
            attempt4Char2.Name = "attempt4Char2";
            attempt4Char2.Size = new Size(43, 40);
            attempt4Char2.TabIndex = 142;
            // 
            // attempt4Char1
            // 
            attempt4Char1.Enabled = false;
            attempt4Char1.Location = new Point(136, 245);
            attempt4Char1.Multiline = true;
            attempt4Char1.Name = "attempt4Char1";
            attempt4Char1.Size = new Size(43, 40);
            attempt4Char1.TabIndex = 141;
            // 
            // attempt3Char5
            // 
            attempt3Char5.Enabled = false;
            attempt3Char5.Location = new Point(332, 199);
            attempt3Char5.Multiline = true;
            attempt3Char5.Name = "attempt3Char5";
            attempt3Char5.Size = new Size(43, 40);
            attempt3Char5.TabIndex = 140;
            // 
            // attempt3Char4
            // 
            attempt3Char4.Enabled = false;
            attempt3Char4.Location = new Point(283, 199);
            attempt3Char4.Multiline = true;
            attempt3Char4.Name = "attempt3Char4";
            attempt3Char4.Size = new Size(43, 40);
            attempt3Char4.TabIndex = 139;
            // 
            // attempt3Char3
            // 
            attempt3Char3.Enabled = false;
            attempt3Char3.Location = new Point(234, 199);
            attempt3Char3.Multiline = true;
            attempt3Char3.Name = "attempt3Char3";
            attempt3Char3.Size = new Size(43, 40);
            attempt3Char3.TabIndex = 138;
            // 
            // attempt3Char2
            // 
            attempt3Char2.Enabled = false;
            attempt3Char2.Location = new Point(185, 199);
            attempt3Char2.Multiline = true;
            attempt3Char2.Name = "attempt3Char2";
            attempt3Char2.Size = new Size(43, 40);
            attempt3Char2.TabIndex = 137;
            // 
            // attempt3Char1
            // 
            attempt3Char1.Enabled = false;
            attempt3Char1.Location = new Point(136, 199);
            attempt3Char1.Multiline = true;
            attempt3Char1.Name = "attempt3Char1";
            attempt3Char1.Size = new Size(43, 40);
            attempt3Char1.TabIndex = 136;
            // 
            // attempt2Char5
            // 
            attempt2Char5.Enabled = false;
            attempt2Char5.Location = new Point(332, 153);
            attempt2Char5.Multiline = true;
            attempt2Char5.Name = "attempt2Char5";
            attempt2Char5.Size = new Size(43, 40);
            attempt2Char5.TabIndex = 135;
            // 
            // attempt2Char4
            // 
            attempt2Char4.Enabled = false;
            attempt2Char4.Location = new Point(283, 153);
            attempt2Char4.Multiline = true;
            attempt2Char4.Name = "attempt2Char4";
            attempt2Char4.Size = new Size(43, 40);
            attempt2Char4.TabIndex = 134;
            // 
            // attempt2Char3
            // 
            attempt2Char3.Enabled = false;
            attempt2Char3.Location = new Point(234, 153);
            attempt2Char3.Multiline = true;
            attempt2Char3.Name = "attempt2Char3";
            attempt2Char3.Size = new Size(43, 40);
            attempt2Char3.TabIndex = 133;
            // 
            // attempt2Char2
            // 
            attempt2Char2.Enabled = false;
            attempt2Char2.Location = new Point(185, 153);
            attempt2Char2.Multiline = true;
            attempt2Char2.Name = "attempt2Char2";
            attempt2Char2.Size = new Size(43, 40);
            attempt2Char2.TabIndex = 132;
            // 
            // attempt2Char1
            // 
            attempt2Char1.Enabled = false;
            attempt2Char1.Location = new Point(136, 153);
            attempt2Char1.Multiline = true;
            attempt2Char1.Name = "attempt2Char1";
            attempt2Char1.Size = new Size(43, 40);
            attempt2Char1.TabIndex = 131;
            // 
            // attempt1Char5
            // 
            attempt1Char5.Enabled = false;
            attempt1Char5.Location = new Point(332, 107);
            attempt1Char5.Multiline = true;
            attempt1Char5.Name = "attempt1Char5";
            attempt1Char5.Size = new Size(43, 40);
            attempt1Char5.TabIndex = 130;
            // 
            // attempt1Char4
            // 
            attempt1Char4.Enabled = false;
            attempt1Char4.Location = new Point(283, 107);
            attempt1Char4.Multiline = true;
            attempt1Char4.Name = "attempt1Char4";
            attempt1Char4.Size = new Size(43, 40);
            attempt1Char4.TabIndex = 129;
            // 
            // attempt1Char3
            // 
            attempt1Char3.Enabled = false;
            attempt1Char3.Location = new Point(234, 107);
            attempt1Char3.Multiline = true;
            attempt1Char3.Name = "attempt1Char3";
            attempt1Char3.Size = new Size(43, 40);
            attempt1Char3.TabIndex = 128;
            // 
            // attempt1Char2
            // 
            attempt1Char2.Enabled = false;
            attempt1Char2.Location = new Point(185, 107);
            attempt1Char2.Multiline = true;
            attempt1Char2.Name = "attempt1Char2";
            attempt1Char2.Size = new Size(43, 40);
            attempt1Char2.TabIndex = 127;
            // 
            // attempt1Char1
            // 
            attempt1Char1.Enabled = false;
            attempt1Char1.Location = new Point(136, 107);
            attempt1Char1.Multiline = true;
            attempt1Char1.Name = "attempt1Char1";
            attempt1Char1.Size = new Size(43, 40);
            attempt1Char1.TabIndex = 126;
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(438, 485);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(57, 40);
            enterBtn.TabIndex = 125;
            enterBtn.Text = "enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // mBtn
            // 
            mBtn.Location = new Point(387, 485);
            mBtn.Name = "mBtn";
            mBtn.Size = new Size(46, 40);
            mBtn.TabIndex = 124;
            mBtn.Text = "M";
            mBtn.UseVisualStyleBackColor = true;
            mBtn.Click += mBtn_Click;
            // 
            // nBtn
            // 
            nBtn.Location = new Point(336, 485);
            nBtn.Name = "nBtn";
            nBtn.Size = new Size(46, 40);
            nBtn.TabIndex = 123;
            nBtn.Text = "N";
            nBtn.UseVisualStyleBackColor = true;
            nBtn.Click += nBtn_Click;
            // 
            // bBtn
            // 
            bBtn.Location = new Point(285, 485);
            bBtn.Name = "bBtn";
            bBtn.Size = new Size(46, 40);
            bBtn.TabIndex = 122;
            bBtn.Text = "B";
            bBtn.UseVisualStyleBackColor = true;
            bBtn.Click += bBtn_Click;
            // 
            // vBtn
            // 
            vBtn.Location = new Point(234, 485);
            vBtn.Name = "vBtn";
            vBtn.Size = new Size(46, 40);
            vBtn.TabIndex = 121;
            vBtn.Text = "V";
            vBtn.UseVisualStyleBackColor = true;
            vBtn.Click += vBtn_Click;
            // 
            // cBtn
            // 
            cBtn.Location = new Point(183, 485);
            cBtn.Name = "cBtn";
            cBtn.Size = new Size(46, 40);
            cBtn.TabIndex = 120;
            cBtn.Text = "C";
            cBtn.UseVisualStyleBackColor = true;
            cBtn.Click += cBtn_Click;
            // 
            // xBtn
            // 
            xBtn.Location = new Point(132, 485);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(46, 40);
            xBtn.TabIndex = 119;
            xBtn.Text = "X";
            xBtn.UseVisualStyleBackColor = true;
            xBtn.Click += xBtn_Click;
            // 
            // zBtn
            // 
            zBtn.Location = new Point(81, 485);
            zBtn.Name = "zBtn";
            zBtn.Size = new Size(46, 40);
            zBtn.TabIndex = 118;
            zBtn.Text = "Z";
            zBtn.UseVisualStyleBackColor = true;
            zBtn.Click += zBtn_Click;
            // 
            // backspaceBtn
            // 
            backspaceBtn.Location = new Point(11, 485);
            backspaceBtn.Name = "backspaceBtn";
            backspaceBtn.Size = new Size(65, 40);
            backspaceBtn.TabIndex = 117;
            backspaceBtn.Text = "back";
            backspaceBtn.UseVisualStyleBackColor = true;
            backspaceBtn.Click += backspaceBtn_Click;
            // 
            // button20
            // 
            button20.Enabled = false;
            button20.Location = new Point(222, 345);
            button20.Name = "button20";
            button20.Size = new Size(0, 0);
            button20.TabIndex = 116;
            button20.UseVisualStyleBackColor = true;
            // 
            // lBtn
            // 
            lBtn.Location = new Point(431, 439);
            lBtn.Name = "lBtn";
            lBtn.Size = new Size(46, 40);
            lBtn.TabIndex = 115;
            lBtn.Text = "L";
            lBtn.UseVisualStyleBackColor = true;
            lBtn.Click += lBtn_Click;
            // 
            // kBtn
            // 
            kBtn.Location = new Point(380, 439);
            kBtn.Name = "kBtn";
            kBtn.Size = new Size(46, 40);
            kBtn.TabIndex = 114;
            kBtn.Text = "K";
            kBtn.UseVisualStyleBackColor = true;
            kBtn.Click += kBtn_Click;
            // 
            // jBtn
            // 
            jBtn.Location = new Point(329, 439);
            jBtn.Name = "jBtn";
            jBtn.Size = new Size(46, 40);
            jBtn.TabIndex = 113;
            jBtn.Text = "J";
            jBtn.UseVisualStyleBackColor = true;
            jBtn.Click += jBtn_Click;
            // 
            // hBtn
            // 
            hBtn.Location = new Point(278, 439);
            hBtn.Name = "hBtn";
            hBtn.Size = new Size(46, 40);
            hBtn.TabIndex = 112;
            hBtn.Text = "H";
            hBtn.UseVisualStyleBackColor = true;
            hBtn.Click += hBtn_Click;
            // 
            // gBtn
            // 
            gBtn.Location = new Point(227, 439);
            gBtn.Name = "gBtn";
            gBtn.Size = new Size(46, 40);
            gBtn.TabIndex = 111;
            gBtn.Text = "G";
            gBtn.UseVisualStyleBackColor = true;
            gBtn.Click += gBtn_Click;
            // 
            // fBtn
            // 
            fBtn.Location = new Point(176, 439);
            fBtn.Name = "fBtn";
            fBtn.Size = new Size(46, 40);
            fBtn.TabIndex = 110;
            fBtn.Text = "F";
            fBtn.UseVisualStyleBackColor = true;
            fBtn.Click += fBtn_Click;
            // 
            // dBtn
            // 
            dBtn.Location = new Point(125, 439);
            dBtn.Name = "dBtn";
            dBtn.Size = new Size(46, 40);
            dBtn.TabIndex = 109;
            dBtn.Text = "D";
            dBtn.UseVisualStyleBackColor = true;
            dBtn.Click += dBtn_Click;
            // 
            // sBtn
            // 
            sBtn.Location = new Point(74, 439);
            sBtn.Name = "sBtn";
            sBtn.Size = new Size(46, 40);
            sBtn.TabIndex = 108;
            sBtn.Text = "S";
            sBtn.UseVisualStyleBackColor = true;
            sBtn.Click += sBtn_Click;
            // 
            // aBtn
            // 
            aBtn.Location = new Point(23, 439);
            aBtn.Name = "aBtn";
            aBtn.Size = new Size(46, 40);
            aBtn.TabIndex = 107;
            aBtn.Text = "A";
            aBtn.UseVisualStyleBackColor = true;
            aBtn.Click += aBtn_Click;
            // 
            // pBtn
            // 
            pBtn.Location = new Point(452, 393);
            pBtn.Name = "pBtn";
            pBtn.Size = new Size(43, 40);
            pBtn.TabIndex = 106;
            pBtn.Text = "P";
            pBtn.UseVisualStyleBackColor = true;
            pBtn.Click += pBtn_Click;
            // 
            // oBtn
            // 
            oBtn.Location = new Point(403, 393);
            oBtn.Name = "oBtn";
            oBtn.Size = new Size(43, 40);
            oBtn.TabIndex = 105;
            oBtn.Text = "O";
            oBtn.UseVisualStyleBackColor = true;
            oBtn.Click += oBtn_Click;
            // 
            // iBtn
            // 
            iBtn.Location = new Point(354, 393);
            iBtn.Name = "iBtn";
            iBtn.Size = new Size(43, 40);
            iBtn.TabIndex = 104;
            iBtn.Text = "I";
            iBtn.UseVisualStyleBackColor = true;
            iBtn.Click += iBtn_Click;
            // 
            // uBtn
            // 
            uBtn.Location = new Point(305, 393);
            uBtn.Name = "uBtn";
            uBtn.Size = new Size(43, 40);
            uBtn.TabIndex = 103;
            uBtn.Text = "U";
            uBtn.UseVisualStyleBackColor = true;
            uBtn.Click += uBtn_Click;
            // 
            // yBtn
            // 
            yBtn.Location = new Point(256, 393);
            yBtn.Name = "yBtn";
            yBtn.Size = new Size(43, 40);
            yBtn.TabIndex = 102;
            yBtn.Text = "Y";
            yBtn.UseVisualStyleBackColor = true;
            yBtn.Click += yBtn_Click;
            // 
            // tBtn
            // 
            tBtn.Location = new Point(207, 393);
            tBtn.Name = "tBtn";
            tBtn.Size = new Size(43, 40);
            tBtn.TabIndex = 101;
            tBtn.Text = "T";
            tBtn.UseVisualStyleBackColor = true;
            tBtn.Click += tBtn_Click;
            // 
            // rBtn
            // 
            rBtn.Location = new Point(158, 393);
            rBtn.Name = "rBtn";
            rBtn.Size = new Size(43, 40);
            rBtn.TabIndex = 100;
            rBtn.Text = "R";
            rBtn.UseVisualStyleBackColor = true;
            rBtn.Click += rBtn_Click;
            // 
            // eBtn
            // 
            eBtn.Location = new Point(109, 393);
            eBtn.Name = "eBtn";
            eBtn.Size = new Size(43, 40);
            eBtn.TabIndex = 99;
            eBtn.Text = "E";
            eBtn.UseVisualStyleBackColor = true;
            eBtn.Click += eBtn_Click;
            // 
            // wBtn
            // 
            wBtn.Location = new Point(60, 393);
            wBtn.Name = "wBtn";
            wBtn.Size = new Size(43, 40);
            wBtn.TabIndex = 98;
            wBtn.Text = "W";
            wBtn.UseVisualStyleBackColor = true;
            wBtn.Click += wBtn_Click;
            // 
            // qBtn
            // 
            qBtn.Location = new Point(11, 393);
            qBtn.Name = "qBtn";
            qBtn.Size = new Size(43, 40);
            qBtn.TabIndex = 97;
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
            pnlOptions.Size = new Size(507, 562);
            pnlOptions.TabIndex = 236;
            pnlOptions.Visible = false;
            // 
            // btnBackOptions
            // 
            btnBackOptions.FlatAppearance.BorderColor = Color.Black;
            btnBackOptions.FlatAppearance.BorderSize = 34;
            btnBackOptions.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackOptions.Image = Properties.Resources.Back_word_button;
            btnBackOptions.Location = new Point(185, 345);
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
            btnBacktoMain.Location = new Point(183, 157);
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
            btnAddWord.Location = new Point(183, 245);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(154, 78);
            btnAddWord.TabIndex = 10;
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.BackColor = Color.Transparent;
            lblOptions.Font = new Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOptions.ForeColor = SystemColors.ButtonFace;
            lblOptions.Location = new Point(203, 92);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(121, 36);
            lblOptions.TabIndex = 9;
            lblOptions.Text = "OPTIONS";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAddWord
            // 
            pnlAddWord.BackgroundImage = Properties.Resources.BG;
            pnlAddWord.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAddWord.Controls.Add(label2);
            pnlAddWord.Controls.Add(txtAddWord);
            pnlAddWord.Controls.Add(btnAddWordBack);
            pnlAddWord.Controls.Add(btnAddWordConfirm);
            pnlAddWord.Controls.Add(lblAddWord);
            pnlAddWord.Dock = DockStyle.Fill;
            pnlAddWord.Location = new Point(0, 0);
            pnlAddWord.Name = "pnlAddWord";
            pnlAddWord.Size = new Size(507, 562);
            pnlAddWord.TabIndex = 237;
            pnlAddWord.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(91, 170);
            label2.Name = "label2";
            label2.Size = new Size(342, 92);
            label2.TabIndex = 20;
            label2.Text = "Note: the word you have added might\r\n have a small chance to appear in the\r\n next few games, and the word you are\r\ncurrently guessing will get changed";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddWord
            // 
            txtAddWord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddWord.Location = new Point(181, 295);
            txtAddWord.MaxLength = 5;
            txtAddWord.Multiline = true;
            txtAddWord.Name = "txtAddWord";
            txtAddWord.Size = new Size(164, 40);
            txtAddWord.TabIndex = 17;
            txtAddWord.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddWordBack
            // 
            btnAddWordBack.FlatAppearance.BorderColor = Color.Black;
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
            btnAddWordConfirm.Location = new Point(292, 364);
            btnAddWordConfirm.Name = "btnAddWordConfirm";
            btnAddWordConfirm.Size = new Size(154, 75);
            btnAddWordConfirm.TabIndex = 14;
            btnAddWordConfirm.UseVisualStyleBackColor = true;
            btnAddWordConfirm.Click += btnAddWordConfirm_Click;
            // 
            // lblAddWord
            // 
            lblAddWord.AutoSize = true;
            lblAddWord.BackColor = Color.Transparent;
            lblAddWord.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWord.ForeColor = Color.WhiteSmoke;
            lblAddWord.Location = new Point(75, 83);
            lblAddWord.Name = "lblAddWord";
            lblAddWord.Size = new Size(406, 58);
            lblAddWord.TabIndex = 19;
            lblAddWord.Text = "Please type the word that you wanted\r\nto add in the Word Inventory\r\n";
            lblAddWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // game1EnglishEasy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 250, 250);
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(507, 562);
            Controls.Add(pnlGame);
            Controls.Add(pnlConfirmation);
            Controls.Add(pnlAddWord);
            Controls.Add(pnlOptions);
            DoubleBuffered = true;
            Name = "game1EnglishEasy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdle - English, Easy";
            FormClosed += game1EnglishEasy_FormClosed;
            Load += game1EnglishEasy_Load;
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
        private Panel pnlMainMenu;
        private Panel pnlConfirmation;
        private Panel pnlGame;
        private Panel panel1;
        private Label lblInstructions;
        private Button btnOptions;
        private Button btnBack;
        private Button btnMainMenu;
        private Panel pnlOptions;
        private Button btnBackOptions;
        private Button btnBacktoMain;
        private Button btnAddWord;
        private Label lblOptions;
        private Panel pnlAddWord;
        private Label label2;
        private Label lblAddWord;
        private Button btnAddWordBack;
        private Button btnAddWordConfirm;
        private Button btnShowLastElement;
        private Button btnShowIndex;
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