namespace projv1
{
    public partial class gameForm : Form
    {

        Image gamePlayer, puszkaPiwo;

        bool moveLeft, moveRight, moveJump;
        bool takeItem;
        bool holdingItem;
        bool czyWzialPuszke = false;
        int speed = 15;
        int gravity = 25;
        int force;
        int positionX = 50;
        int positionY = 500;
        int puskaX = 1130;
        int height = 110;
        int width = 110;

        public gameForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("background_all_closed.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            puszkaPiwo = Image.FromFile("puszka.png");
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
                positionX -= speed;
            }
            if (moveRight && positionX + width < this.ClientSize.Width)
            {
                positionX += speed;
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

            if (((positionX + width > piwoPanel.Left && positionX + width < piwoPanel.Right) || (positionX > piwoPanel.Left && positionX < piwoPanel.Right)) && !czyWzialPuszke)
            {
                pressButtonText.Text = "Naciœnij E aby wzi¹æ przedmiot";

                if (takeItem)
                {
                    czyWzialPuszke = true;
                    puskaX = -500;
                    holdingItem = true;
                }

            }
            else
            {
                pressButtonText.Text = "";
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

            Canvas.DrawImage(puszkaPiwo, puskaX, 397, 164, 144);
            Canvas.DrawImage(gamePlayer, positionX, positionY, width, height);

        }

        private void obstacleOne_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}