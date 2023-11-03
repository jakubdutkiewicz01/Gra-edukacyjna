namespace projv1
{
    public partial class gameForm : Form
    {
        Image gameBackground;
        Image gamePlayer, puszkaPiwo, banan;

        bool moveLeft, moveRight, moveJump;
        bool takeItem;
        bool holdingItem = false;
        int speed = 7;
        int gravity = 25;
        int force;
        int positionX = 50;
        int positionY = 500;
        int puskaX = 1130;
        int height = 110;
        int width = 110;
        int bg_X = 0;
        int bg_Y = 0;
        string itemTag = "";


      



        public gameForm()
        {
            InitializeComponent();




            gameBackground = Image.FromFile("background_all_closed.png");
            puszkaPiwo = Image.FromFile("puszka.png");
            banan = Image.FromFile("banana_peel.png");
            gamePlayer = Image.FromFile("bigmalpa.png");



        }

        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private void TimerEvent(object sender, EventArgs e)
        {

            if (positionX < obstacleOne.Right && positionX >= obstacleOne.Left &&
            positionY + height > obstacleOne.Top)
            {
                moveLeft = false;

            }

            if (positionX + width >= obstacleOne.Left && positionX + width <= obstacleOne.Right &&
                positionY + height > obstacleOne.Top)
            {
                moveRight = false;

            }


            if (moveLeft && positionX > 0)
            {
                gamePlayer = Image.FromFile("bigmalpa.png");
                positionX -= speed;
                if (bg_X < 0)
                {
                    bg_X += speed - 1;
                    obstacleOne.Left += speed - 1;
                    yellowBox.Left += speed - 1;
                    blueBox.Left += speed - 1;
                    greenBox.Left += speed - 1;
                    brownBox.Left += speed - 1;
                }
            }
            if (moveRight && positionX + width < this.ClientSize.Width)
            {
                gamePlayer = Image.FromFile("bigmalpa_reversed.png");
                positionX += speed;

                if (bg_X + gameBackground.Width > this.ClientSize.Width)
                {
                    bg_X -= speed - 1;
                    obstacleOne.Left -= speed - 1;
                    yellowBox.Left -= speed - 1;
                    blueBox.Left -= speed - 1;
                    brownBox.Left -= speed - 1;
                    greenBox.Left -= speed - 1;
                }


            }

            if (moveJump)
            {
                positionY -= force;
                force -= 1;
            }
            if (positionY + height >= this.ClientSize.Height)
            {
                positionY = this.ClientSize.Height - height;
                moveJump = false;
            }
            else
            {
                positionY += 5;
            }

            if (positionX + width > obstacleOne.Left && positionX < obstacleOne.Right &&
                 positionY + height >= obstacleOne.Top && positionY < obstacleOne.Top)
            {

                force = 0;
                moveJump = false;
                positionY = obstacleOne.Top - height;

            }

            if (!holdingItem && ((positionX + width > piwoPanel.Left && positionX + width < piwoPanel.Right) || (positionX > piwoPanel.Left && positionX < piwoPanel.Right)))
            {
                pressButtonText.Text = "Naciœnij E aby wzi¹æ przedmiot";

                if (takeItem)
                {

                    puskaX = -500;
                    holdingItem = true;
                    itemTag = "plastic";

                }
            }
            else
            {
                pressButtonText.Text = "";
            }

            if (!holdingItem && ((positionX + width > bananaPanel.Left && positionX + width < bananaPanel.Right) || (positionX > bananaPanel.Left && positionX < bananaPanel.Right)))
            {
                pressButtonText.Text = "Naciœnij E aby wzi¹æ przedmiot";

                if (takeItem)
                {

                    bananaPanel.Left = -500;
                    holdingItem = true;
                    itemTag = "bio";

                }
            }
            else
            {
                pressButtonText.Text = "";
            }




            if (positionX < yellowBox.Right && positionX > yellowBox.Left && positionX + width < yellowBox.Right && positionX + width > yellowBox.Left)
            {

                gameBackground = Image.FromFile("background_yellow_open.png");


                pressButtonText.Text = "Naciœnij E aby wyrzuciæ przedmiot";

                if (takeItem && holdingItem)
                {
                    if (itemTag == "plastic" || itemTag == "")
                    {
                        holdingItem = false;
                    }
                    else
                    {
                        pressButtonText.Text = "PRZEGRANA, TO JEST POJEMNIK NA PLASTIK";

                    }
                }

            }
            if (positionX < blueBox.Right && positionX > blueBox.Left && positionX + width < blueBox.Right && positionX + width > blueBox.Left)
            {
                gameBackground = Image.FromFile("background_blue_open.png");
                pressButtonText.Text = "Naciœnij E aby wyrzuciæ przedmiot";


                if (takeItem && holdingItem)
                {
                    if (itemTag == "paper" || itemTag == "")
                    {
                        holdingItem = false;
                    }
                    else
                    {
                        pressButtonText.Text = "PRZEGRANA, TO JEST POJEMNIK NA PAPIER";

                    }
                }
            }
            if (positionX < greenBox.Right && positionX > greenBox.Left && positionX + width < greenBox.Right && positionX + width > greenBox.Left)
            {
                gameBackground = Image.FromFile("background_green_open.png");
                pressButtonText.Text = "Naciœnij E aby wyrzuciæ przedmiot";

            }
            if (positionX < brownBox.Right && positionX > brownBox.Left && positionX + width < brownBox.Right && positionX + width > brownBox.Left)
            {
                gameBackground = Image.FromFile("background_brown_open.png");
                pressButtonText.Text = "Naciœnij E aby wyrzuciæ przedmiot";

            }
            if (positionX > brownBox.Right || betweemBoxes())
            {
                gameBackground = Image.FromFile("background_all_closed.png");

            }










            this.Invalidate();

        }
        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (!moveJump)
            {
                if (e.KeyCode == Keys.Space)
                {
                    moveJump = true;
                    force = gravity;

                }
            }
            if (e.KeyCode == Keys.E)
            {
                takeItem = true;
            }

        }
        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.E)
            {
                takeItem = false;
            }

        }


        private void formPaintingEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            Canvas.DrawImage(gameBackground, bg_X, bg_Y);
            Canvas.DrawImage(puszkaPiwo, 1100, 397, 164, 144);
            Canvas.DrawImage(banan, bananaPanel.Left, bananaPanel.Top, bananaPanel.Width, bananaPanel.Height);
            Canvas.DrawImage(gamePlayer, positionX, positionY, width, height);

        }

        private void obstacleOne_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public bool betweemBoxes()
        {
            if ((positionX > yellowBox.Right && positionX < greenBox.Left) ||
               (positionX + width > yellowBox.Right && positionX + width < greenBox.Left) ||
                (positionX > greenBox.Right && positionX < blueBox.Left) ||
                (positionX + width > greenBox.Right && positionX + width < blueBox.Left) ||
                (positionX > blueBox.Right && positionX < brownBox.Left) ||
                (positionX + width > blueBox.Right && positionX + width < brownBox.Left))
            {

                return true;

            }
            else
            {
                return false;
            }

        }


    }
}