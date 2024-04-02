namespace projv1
{
    partial class gameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            gameTimer = new System.Windows.Forms.Timer(components);
            yellowBox = new Panel();
            pictureBox1 = new PictureBox();
            obstacleOne = new PictureBox();
            blueBox = new Panel();
            brownBox = new Panel();
            pressButtonText = new Label();
            greenBox = new Panel();
            obstacle5 = new PictureBox();
            mainTimer = new Label();
            winNextLevel = new Button();
            winRestartLevel = new Button();
            winLeaveGame = new Button();
            label4 = new Label();
            levelWinPanel = new Panel();
            losePanel = new Panel();
            loseLeaveButton = new Button();
            loseGameRestart = new Button();
            label1 = new Label();
            levelInfo = new Label();
            itemInfo = new Label();
            obstacle2 = new PictureBox();
            obstacle3 = new PictureBox();
            obstacle4 = new PictureBox();
            imageList1 = new ImageList(components);
            label2 = new Label();
            menuPanel = new Panel();
            menuMovingButton = new Button();
            menuLeaveButton = new Button();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox11 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            panel3 = new Panel();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            panel2 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            movingPanel = new Panel();
            movingBackButton = new Button();
            pictureBox19 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            finalPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            loseText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle5).BeginInit();
            levelWinPanel.SuspendLayout();
            losePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)obstacle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle4).BeginInit();
            menuPanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            movingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            finalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 15;
            gameTimer.Tick += TimerEvent;
            // 
            // yellowBox
            // 
            yellowBox.BackColor = Color.Transparent;
            yellowBox.Location = new Point(12, 272);
            yellowBox.Name = "yellowBox";
            yellowBox.Size = new Size(199, 256);
            yellowBox.TabIndex = 0;
            yellowBox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(-3, 521);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1124, 44);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // obstacleOne
            // 
            obstacleOne.BackColor = Color.Transparent;
            obstacleOne.BackgroundImage = Properties.Resources.przeszkoda;
            obstacleOne.BackgroundImageLayout = ImageLayout.Stretch;
            obstacleOne.Location = new Point(920, 347);
            obstacleOne.Name = "obstacleOne";
            obstacleOne.Size = new Size(155, 204);
            obstacleOne.TabIndex = 1;
            obstacleOne.TabStop = false;
            obstacleOne.Click += obstacleOne_Click;
            // 
            // blueBox
            // 
            blueBox.BackColor = Color.Transparent;
            blueBox.Location = new Point(232, 272);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(211, 243);
            blueBox.TabIndex = 7;
            blueBox.Visible = false;
            // 
            // brownBox
            // 
            brownBox.BackColor = Color.Transparent;
            brownBox.Location = new Point(701, 272);
            brownBox.Name = "brownBox";
            brownBox.Size = new Size(192, 256);
            brownBox.TabIndex = 8;
            brownBox.Visible = false;
            // 
            // pressButtonText
            // 
            pressButtonText.AutoSize = true;
            pressButtonText.Location = new Point(24, 534);
            pressButtonText.Name = "pressButtonText";
            pressButtonText.Size = new Size(38, 15);
            pressButtonText.TabIndex = 10;
            pressButtonText.Text = "label1";
            pressButtonText.Visible = false;
            // 
            // greenBox
            // 
            greenBox.BackColor = Color.Transparent;
            greenBox.Location = new Point(462, 272);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(209, 243);
            greenBox.TabIndex = 6;
            greenBox.Visible = false;
            // 
            // obstacle5
            // 
            obstacle5.BackColor = Color.Transparent;
            obstacle5.BackgroundImage = (Image)resources.GetObject("obstacle5.BackgroundImage");
            obstacle5.BackgroundImageLayout = ImageLayout.Stretch;
            obstacle5.Location = new Point(615, 420);
            obstacle5.Name = "obstacle5";
            obstacle5.Size = new Size(104, 100);
            obstacle5.TabIndex = 22;
            obstacle5.TabStop = false;
            obstacle5.Visible = false;
            obstacle5.Click += obstacle5_Click;
            // 
            // mainTimer
            // 
            mainTimer.AutoSize = true;
            mainTimer.BackColor = Color.Transparent;
            mainTimer.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mainTimer.Location = new Point(526, 10);
            mainTimer.Name = "mainTimer";
            mainTimer.Size = new Size(0, 33);
            mainTimer.TabIndex = 13;
            // 
            // winNextLevel
            // 
            winNextLevel.Location = new Point(332, 186);
            winNextLevel.Name = "winNextLevel";
            winNextLevel.Size = new Size(116, 40);
            winNextLevel.TabIndex = 3;
            winNextLevel.Text = "Następny poziom";
            winNextLevel.UseVisualStyleBackColor = true;
            winNextLevel.UseWaitCursor = true;
            winNextLevel.Click += winNextLevel_Click;
            // 
            // winRestartLevel
            // 
            winRestartLevel.Location = new Point(243, -73);
            winRestartLevel.Name = "winRestartLevel";
            winRestartLevel.Size = new Size(114, 38);
            winRestartLevel.TabIndex = 2;
            winRestartLevel.Text = "Restart";
            winRestartLevel.UseVisualStyleBackColor = true;
            winRestartLevel.UseWaitCursor = true;
            winRestartLevel.Click += winRestartLevel_Click;
            // 
            // winLeaveGame
            // 
            winLeaveGame.Location = new Point(35, 189);
            winLeaveGame.Name = "winLeaveGame";
            winLeaveGame.Size = new Size(109, 32);
            winLeaveGame.TabIndex = 1;
            winLeaveGame.Text = "Wyjdź z gry";
            winLeaveGame.UseVisualStyleBackColor = true;
            winLeaveGame.UseWaitCursor = true;
            winLeaveGame.Click += winLeaveGame_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(182, 30);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 0;
            label4.Text = "Gratulacje\r\n";
            label4.UseWaitCursor = true;
            // 
            // levelWinPanel
            // 
            levelWinPanel.BackColor = Color.WhiteSmoke;
            levelWinPanel.CausesValidation = false;
            levelWinPanel.Controls.Add(winNextLevel);
            levelWinPanel.Controls.Add(winLeaveGame);
            levelWinPanel.Controls.Add(label4);
            levelWinPanel.ImeMode = ImeMode.On;
            levelWinPanel.Location = new Point(328, 50);
            levelWinPanel.Name = "levelWinPanel";
            levelWinPanel.Size = new Size(488, 285);
            levelWinPanel.TabIndex = 4;
            levelWinPanel.TabStop = true;
            levelWinPanel.UseWaitCursor = true;
            levelWinPanel.Visible = false;
            // 
            // losePanel
            // 
            losePanel.Controls.Add(loseText);
            losePanel.Controls.Add(loseLeaveButton);
            losePanel.Controls.Add(winRestartLevel);
            losePanel.Controls.Add(loseGameRestart);
            losePanel.Controls.Add(label1);
            losePanel.Location = new Point(328, 50);
            losePanel.Name = "losePanel";
            losePanel.Size = new Size(482, 293);
            losePanel.TabIndex = 16;
            losePanel.UseWaitCursor = true;
            losePanel.Visible = false;
            // 
            // loseLeaveButton
            // 
            loseLeaveButton.Location = new Point(52, 174);
            loseLeaveButton.Name = "loseLeaveButton";
            loseLeaveButton.Size = new Size(116, 39);
            loseLeaveButton.TabIndex = 2;
            loseLeaveButton.Text = "Wyjdź z gry";
            loseLeaveButton.UseVisualStyleBackColor = true;
            loseLeaveButton.UseWaitCursor = true;
            loseLeaveButton.Click += loseLeaveButton_Click;
            // 
            // loseGameRestart
            // 
            loseGameRestart.Location = new Point(282, 174);
            loseGameRestart.Name = "loseGameRestart";
            loseGameRestart.Size = new Size(116, 39);
            loseGameRestart.TabIndex = 1;
            loseGameRestart.Text = "Restart";
            loseGameRestart.UseVisualStyleBackColor = true;
            loseGameRestart.UseWaitCursor = true;
            loseGameRestart.Click += loseGameRestart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 40);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "PRZEGRANA";
            label1.UseWaitCursor = true;
            // 
            // levelInfo
            // 
            levelInfo.AutoSize = true;
            levelInfo.BackColor = Color.Transparent;
            levelInfo.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            levelInfo.Location = new Point(29, 21);
            levelInfo.Name = "levelInfo";
            levelInfo.Size = new Size(0, 20);
            levelInfo.TabIndex = 17;
            // 
            // itemInfo
            // 
            itemInfo.AutoSize = true;
            itemInfo.BackColor = Color.Transparent;
            itemInfo.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemInfo.Location = new Point(803, 16);
            itemInfo.Name = "itemInfo";
            itemInfo.Size = new Size(0, 20);
            itemInfo.TabIndex = 18;
            // 
            // obstacle2
            // 
            obstacle2.BackColor = Color.Transparent;
            obstacle2.BackgroundImage = (Image)resources.GetObject("obstacle2.BackgroundImage");
            obstacle2.Location = new Point(920, -101);
            obstacle2.Name = "obstacle2";
            obstacle2.Size = new Size(155, 207);
            obstacle2.TabIndex = 19;
            obstacle2.TabStop = false;
            obstacle2.Visible = false;
            // 
            // obstacle3
            // 
            obstacle3.BackColor = Color.Transparent;
            obstacle3.BackgroundImage = (Image)resources.GetObject("obstacle3.BackgroundImage");
            obstacle3.BackgroundImageLayout = ImageLayout.Stretch;
            obstacle3.Location = new Point(1543, 256);
            obstacle3.Name = "obstacle3";
            obstacle3.Size = new Size(311, 88);
            obstacle3.TabIndex = 20;
            obstacle3.TabStop = false;
            obstacle3.Visible = false;
            // 
            // obstacle4
            // 
            obstacle4.BackColor = Color.Transparent;
            obstacle4.BackgroundImage = (Image)resources.GetObject("obstacle4.BackgroundImage");
            obstacle4.BackgroundImageLayout = ImageLayout.Stretch;
            obstacle4.Location = new Point(-118, 250);
            obstacle4.Name = "obstacle4";
            obstacle4.Size = new Size(389, 115);
            obstacle4.TabIndex = 21;
            obstacle4.TabStop = false;
            obstacle4.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(819, 534);
            label2.Name = "label2";
            label2.Size = new Size(287, 20);
            label2.TabIndex = 23;
            label2.Text = "Nacisnij 'M' aby otworzyc Menu";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.IndianRed;
            menuPanel.Controls.Add(menuMovingButton);
            menuPanel.Controls.Add(menuLeaveButton);
            menuPanel.Controls.Add(label3);
            menuPanel.Controls.Add(panel4);
            menuPanel.Controls.Add(panel3);
            menuPanel.Controls.Add(panel2);
            menuPanel.Controls.Add(panel1);
            menuPanel.Location = new Point(75, 12);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(969, 514);
            menuPanel.TabIndex = 24;
            menuPanel.Visible = false;
            // 
            // menuMovingButton
            // 
            menuMovingButton.Location = new Point(419, 403);
            menuMovingButton.Name = "menuMovingButton";
            menuMovingButton.Size = new Size(116, 40);
            menuMovingButton.TabIndex = 6;
            menuMovingButton.Text = "Poruszanie";
            menuMovingButton.UseVisualStyleBackColor = true;
            menuMovingButton.Click += menuMovingButton_Click;
            // 
            // menuLeaveButton
            // 
            menuLeaveButton.Location = new Point(419, 452);
            menuLeaveButton.Name = "menuLeaveButton";
            menuLeaveButton.Size = new Size(116, 40);
            menuLeaveButton.TabIndex = 5;
            menuLeaveButton.Text = "Powrót";
            menuLeaveButton.UseVisualStyleBackColor = true;
            menuLeaveButton.Click += menuLeaveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(354, 19);
            label3.Name = "label3";
            label3.Size = new Size(257, 31);
            label3.TabIndex = 4;
            label3.Text = "Czysty świat - nauka";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(pictureBox11);
            panel4.Controls.Add(pictureBox15);
            panel4.Controls.Add(pictureBox16);
            panel4.Controls.Add(pictureBox17);
            panel4.Controls.Add(pictureBox18);
            panel4.Location = new Point(567, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 187);
            panel4.TabIndex = 3;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = Properties.Resources.apple_rotten;
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Location = new Point(243, 100);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 84);
            pictureBox11.TabIndex = 4;
            pictureBox11.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImage = Properties.Resources.gruszka;
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Location = new Point(114, 100);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(90, 84);
            pictureBox15.TabIndex = 3;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = Properties.Resources.banana_peel;
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.Location = new Point(248, 0);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(95, 79);
            pictureBox16.TabIndex = 2;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = Properties.Resources.apple_core;
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox17.Location = new Point(114, 0);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(90, 79);
            pictureBox17.TabIndex = 1;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackgroundImage = Properties.Resources.brownclosed;
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox18.Location = new Point(3, 20);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(105, 164);
            pictureBox18.TabIndex = 0;
            pictureBox18.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(pictureBox14);
            panel3.Location = new Point(31, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 187);
            panel3.TabIndex = 2;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources.szklany_sloik;
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Location = new Point(240, 48);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(90, 84);
            pictureBox12.TabIndex = 5;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.glass_bottle;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Location = new Point(115, 48);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(90, 84);
            pictureBox13.TabIndex = 4;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.greenclosed;
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.Location = new Point(0, 9);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(105, 164);
            pictureBox14.TabIndex = 1;
            pictureBox14.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(570, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 187);
            panel2.TabIndex = 1;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources.papier;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Location = new Point(184, 100);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(90, 84);
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.karton_pudlo;
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(253, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(90, 84);
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.karton;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(111, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(90, 84);
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.blueclosed;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(0, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(105, 164);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(31, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 187);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.plastic_bag;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(243, 100);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 84);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bottledwater;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(114, 100);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 84);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.batonik;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(248, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(95, 79);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.puszka;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(114, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 79);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 164);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // movingPanel
            // 
            movingPanel.BackColor = Color.IndianRed;
            movingPanel.Controls.Add(movingBackButton);
            movingPanel.Controls.Add(pictureBox19);
            movingPanel.Controls.Add(label6);
            movingPanel.Controls.Add(label5);
            movingPanel.Location = new Point(217, 46);
            movingPanel.Name = "movingPanel";
            movingPanel.Size = new Size(628, 379);
            movingPanel.TabIndex = 25;
            movingPanel.Visible = false;
            // 
            // movingBackButton
            // 
            movingBackButton.Location = new Point(64, 303);
            movingBackButton.Name = "movingBackButton";
            movingBackButton.Size = new Size(150, 49);
            movingBackButton.TabIndex = 7;
            movingBackButton.Text = "Powrót";
            movingBackButton.UseVisualStyleBackColor = true;
            movingBackButton.Click += movingBackButton_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.BackgroundImage = Properties.Resources.bigmalpa;
            pictureBox19.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox19.Location = new Point(429, 210);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(170, 158);
            pictureBox19.TabIndex = 6;
            pictureBox19.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(150, 29);
            label6.Name = "label6";
            label6.Size = new Size(313, 31);
            label6.TabIndex = 5;
            label6.Text = "Czysty świat - poruszanie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(18, 127);
            label5.Name = "label5";
            label5.Size = new Size(338, 120);
            label5.TabIndex = 0;
            label5.Text = "A - LEWO\r\nD - PRAWO\r\nSPACJA - SKOK\r\nE - WEŹ / WYRZUĆ PRZEDMIOT\r\n";
            // 
            // finalPanel
            // 
            finalPanel.Controls.Add(button2);
            finalPanel.Controls.Add(button1);
            finalPanel.Controls.Add(label7);
            finalPanel.Location = new Point(413, 85);
            finalPanel.Name = "finalPanel";
            finalPanel.Size = new Size(306, 294);
            finalPanel.TabIndex = 26;
            finalPanel.Visible = false;
            finalPanel.Paint += finalPanel_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(178, 210);
            button2.Name = "button2";
            button2.Size = new Size(93, 59);
            button2.TabIndex = 2;
            button2.Text = "Wyjdź z gry";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 210);
            button1.Name = "button1";
            button1.Size = new Size(90, 58);
            button1.TabIndex = 1;
            button1.Text = "Rozpocznij grę od nowa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 21);
            label7.Name = "label7";
            label7.Size = new Size(287, 40);
            label7.TabIndex = 0;
            label7.Text = "Gratulacje\r\nUnkonczyłes gre czysty swiat!";
            // 
            // loseText
            // 
            loseText.AutoSize = true;
            loseText.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loseText.Location = new Point(166, 75);
            loseText.Name = "loseText";
            loseText.Size = new Size(131, 20);
            loseText.TabIndex = 3;
            loseText.Text = "Czas upłynał!";
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1113, 563);
            Controls.Add(losePanel);
            Controls.Add(levelWinPanel);
            Controls.Add(obstacle4);
            Controls.Add(finalPanel);
            Controls.Add(label2);
            Controls.Add(obstacle5);
            Controls.Add(itemInfo);
            Controls.Add(levelInfo);
            Controls.Add(pressButtonText);
            Controls.Add(mainTimer);
            Controls.Add(pictureBox1);
            Controls.Add(obstacleOne);
            Controls.Add(yellowBox);
            Controls.Add(obstacle2);
            Controls.Add(obstacle3);
            Controls.Add(blueBox);
            Controls.Add(greenBox);
            Controls.Add(brownBox);
            Controls.Add(movingPanel);
            Controls.Add(menuPanel);
            DoubleBuffered = true;
            Name = "gameForm";
            Text = "Czysty Świat - Jakub Dutkiewicz 188833";
            Load += gameForm_Load;
            Paint += formPaintingEvent;
            KeyDown += keyDownEvent;
            KeyUp += keyUpEvent;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle5).EndInit();
            levelWinPanel.ResumeLayout(false);
            levelWinPanel.PerformLayout();
            losePanel.ResumeLayout(false);
            losePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)obstacle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle3).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle4).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            movingPanel.ResumeLayout(false);
            movingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            finalPanel.ResumeLayout(false);
            finalPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Panel yellowBox;
        private PictureBox obstacleOne;
        private Panel blueBox;
        private Panel brownBox;
        private Label pressButtonText;
        private Panel greenBox;
        private PictureBox pictureBox1;
        private Label mainTimer;
        private Label label4;
        private Button winNextLevel;
        private Button winRestartLevel;
        private Button winLeaveGame;
        private Panel levelWinPanel;
        private Panel losePanel;
        private Button loseGameRestart;
        private Label label1;
        private Button loseLeaveButton;
        private Label levelInfo;
        private Label itemInfo;
        private PictureBox obstacle2;
        private PictureBox obstacle3;
        private PictureBox obstacle4;
        private PictureBox obstacle5;
        private ImageList imageList1;
        private Label label2;
        private Panel menuPanel;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Panel panel4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private Button menuLeaveButton;
        private Label label3;
        private Button menuMovingButton;
        private Panel movingPanel;
        private Label label5;
        private Button movingBackButton;
        private PictureBox pictureBox19;
        private Label label6;
        private Panel finalPanel;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label loseText;
    }
}