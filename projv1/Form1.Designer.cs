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
            gameTimer = new System.Windows.Forms.Timer(components);
            yellowBox = new Panel();
            obstacleOne = new PictureBox();
            piwoPanel = new Panel();
            blueBox = new Panel();
            brownBox = new Panel();
            bananaPanel = new Panel();
            pressButtonText = new Label();
            greenBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 5;
            gameTimer.Tick += TimerEvent;
            // 
            // yellowBox
            // 
            yellowBox.BackColor = Color.Transparent;
            yellowBox.Location = new Point(12, 309);
            yellowBox.Name = "yellowBox";
            yellowBox.Size = new Size(140, 246);
            yellowBox.TabIndex = 0;
            yellowBox.Visible = false;
            // 
            // obstacleOne
            // 
            obstacleOne.BackColor = Color.Red;
            obstacleOne.Location = new Point(946, 384);
            obstacleOne.Name = "obstacleOne";
            obstacleOne.Size = new Size(155, 160);
            obstacleOne.TabIndex = 1;
            obstacleOne.TabStop = false;
            obstacleOne.Click += obstacleOne_Click;
            // 
            // piwoPanel
            // 
            piwoPanel.BackColor = Color.Transparent;
            piwoPanel.Location = new Point(1196, 396);
            piwoPanel.Name = "piwoPanel";
            piwoPanel.Size = new Size(161, 159);
            piwoPanel.TabIndex = 3;
            piwoPanel.Visible = false;
            // 
            // blueBox
            // 
            blueBox.BackColor = Color.Transparent;
            blueBox.Location = new Point(317, 309);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(165, 246);
            blueBox.TabIndex = 7;
            blueBox.Visible = false;
            // 
            // brownBox
            // 
            brownBox.BackColor = Color.Transparent;
            brownBox.Location = new Point(488, 309);
            brownBox.Name = "brownBox";
            brownBox.Size = new Size(142, 248);
            brownBox.TabIndex = 8;
            brownBox.Visible = false;
            // 
            // bananaPanel
            // 
            bananaPanel.BackColor = Color.Transparent;
            bananaPanel.Location = new Point(1434, 425);
            bananaPanel.Name = "bananaPanel";
            bananaPanel.Size = new Size(134, 132);
            bananaPanel.TabIndex = 9;
            bananaPanel.Visible = false;
            // 
            // pressButtonText
            // 
            pressButtonText.AutoSize = true;
            pressButtonText.Location = new Point(444, 216);
            pressButtonText.Name = "pressButtonText";
            pressButtonText.Size = new Size(38, 15);
            pressButtonText.TabIndex = 10;
            pressButtonText.Text = "label1";
            // 
            // greenBox
            // 
            greenBox.BackColor = Color.Transparent;
            greenBox.Location = new Point(170, 309);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(141, 256);
            greenBox.TabIndex = 6;
            greenBox.Visible = false;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_all_closed;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1127, 488);
            Controls.Add(obstacleOne);
            Controls.Add(pressButtonText);
            Controls.Add(bananaPanel);
            Controls.Add(brownBox);
            Controls.Add(blueBox);
            Controls.Add(greenBox);
            Controls.Add(piwoPanel);
            Controls.Add(yellowBox);
            DoubleBuffered = true;
            Name = "gameForm";
            Text = "Form1";
            Load += gameForm_Load;
            Paint += formPaintingEvent;
            KeyDown += keyDownEvent;
            KeyUp += keyUpEvent;
            ((System.ComponentModel.ISupportInitialize)obstacleOne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Panel yellowBox;
        private PictureBox obstacleOne;
        private Panel piwoPanel;
        private Panel blueBox;
        private Panel brownBox;
        private Panel bananaPanel;
        private Label pressButtonText;
        private Panel greenBox;
    }
}