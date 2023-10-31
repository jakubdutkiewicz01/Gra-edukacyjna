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
            panel1 = new Panel();
            obstacleOne = new PictureBox();
            piwoPanel = new Panel();
            holdingItemText = new Label();
            pressButtonText = new Label();
            ((System.ComponentModel.ISupportInitialize)obstacleOne).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 5;
            gameTimer.Tick += TimerEvent;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(27, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 219);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // obstacleOne
            // 
            obstacleOne.BackColor = Color.Red;
            obstacleOne.Location = new Point(816, 442);
            obstacleOne.Name = "obstacleOne";
            obstacleOne.Size = new Size(155, 92);
            obstacleOne.TabIndex = 1;
            obstacleOne.TabStop = false;
            obstacleOne.Click += obstacleOne_Click;
            // 
            // piwoPanel
            // 
            piwoPanel.BackColor = Color.Transparent;
            piwoPanel.Location = new Point(1113, 379);
            piwoPanel.Name = "piwoPanel";
            piwoPanel.Size = new Size(193, 178);
            piwoPanel.TabIndex = 3;
            piwoPanel.Visible = false;
            // 
            // holdingItemText
            // 
            holdingItemText.AutoSize = true;
            holdingItemText.Location = new Point(362, 192);
            holdingItemText.Name = "holdingItemText";
            holdingItemText.Size = new Size(0, 15);
            holdingItemText.TabIndex = 4;
            // 
            // pressButtonText
            // 
            pressButtonText.AutoSize = true;
            pressButtonText.Location = new Point(362, 266);
            pressButtonText.Name = "pressButtonText";
            pressButtonText.Size = new Size(0, 15);
            pressButtonText.TabIndex = 5;
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_all_closed;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1407, 556);
            Controls.Add(pressButtonText);
            Controls.Add(holdingItemText);
            Controls.Add(piwoPanel);
            Controls.Add(obstacleOne);
            Controls.Add(panel1);
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
        private Panel panel1;
        private PictureBox obstacleOne;
        private Panel piwoPanel;
        private Label holdingItemText;
        private Label pressButtonText;
    }
}