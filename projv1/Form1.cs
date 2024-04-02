using Microsoft.VisualBasic;
using System.Media;
using System.Reflection.PortableExecutable;
using System.Xml.Schema;

namespace projv1
{


    public partial class gameForm : Form
    {
        Image gameBackground;
        Image gamePlayer, bananImage, bottleImage, sokImage, appleImage, glassBottleImage,
            rottenImage, kartonPudloImage, puszkaImage, sloikImage, torbaImage, batonImage,
            papierImage, gruszkaImage;

        bool moveLeft, moveRight, moveJump;
        bool takeItem;
        bool holdingItem = false;
        bool openMenu = false;
        int speed = 7;
        int gravity = 25;
        int force;
        int positionX = 50;
        int positionY = 500;
        int height = 110;
        int width = 110;
        int bg_X = 0;
        int bg_Y = 0;
        string itemTag = "";

        public int level = 1;
        int itemsToCollect;
        int levelTime = 60;




        Bio banan = new Bio(1600, 156, 100, 100, "banana_peel.png", "Skróka od banana");
        Bio apple = new Bio(1400, 421, 100, 100, "apple_core.png", "Ogryzek jabłka");
        Bio rotten_apple = new Bio(1400, 421, 100, 100, "apple_rotten.png", "Zgniłe jabłko");
        Bio gruszka = new Bio(1550, 421, 100, 100, "gruszka.png", "Zgiła gruszka");

        Plastic bottle = new Plastic(1100, 421, 110, 110, "bottledwater.png", "Plastikowa butelka");
        Plastic puszka = new Plastic(1100, 421, 110, 110, "puszka.png", "Puszka");
        Plastic torba = new Plastic(1750, 156, 100, 100, "plastic_bag.png", "Torba plastikowa");
        Plastic baton = new Plastic(100, 150, 100, 100, "batonik.png", "Papierek po batoniku");

        Paper sok = new Paper(1250, 421, 110, 110, "karton.png", "Karton po soku");
        Paper kartonPudlo = new Paper(1250, 421, 110, 110, "karton_pudlo.png", "Kartonowe pudło");
        Paper papier = new Paper(1400, 421, 110, 110, "papier.png", "Kartka papieru");

        Glass glassBottle = new Glass(1550, 421, 100, 100, "glass_bottle.png", "Szklana butelka");
        Glass sloik = new Glass(1550, 421, 100, 100, "szklany_sloik.png", "Szklany słoik");




        public gameForm()
        {
            InitializeComponent();


            gameBackground = Image.FromFile("background_all_closed_test.png");
            bananImage = Image.FromFile(banan.imagePath);
            gamePlayer = Image.FromFile("malpa.png");
            bottleImage = Image.FromFile(bottle.imagePath);
            sokImage = Image.FromFile(sok.imagePath);
            appleImage = Image.FromFile(apple.imagePath);
            glassBottleImage = Image.FromFile(glassBottle.imagePath);
            rottenImage = Image.FromFile(rotten_apple.imagePath);
            kartonPudloImage = Image.FromFile(kartonPudlo.imagePath);
            puszkaImage = Image.FromFile(puszka.imagePath);
            sloikImage = Image.FromFile(sloik.imagePath);
            torbaImage = Image.FromFile(torba.imagePath);
            batonImage = Image.FromFile(baton.imagePath);
            papierImage = Image.FromFile(papier.imagePath);
            gruszkaImage = Image.FromFile(gruszka.imagePath);


            setLvlValues();





        }

        System.Timers.Timer Timer;
        public int m, s;



        private void gameForm_Load(object sender, EventArgs e)
        {

            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;
            Timer.Start();



        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                s = s + 1;
                m = levelTime - s;
                mainTimer.Text = "" + m;

            }));
        }

        private void TimerEvent(object sender, EventArgs e)
        {

            if (positionX < yellowBox.Right && positionX > yellowBox.Left && positionX + width < yellowBox.Right && positionX + width > yellowBox.Left && positionY > obstacle4.Bottom)
            {

                gameBackground = Image.FromFile("bg_yellowOpen.png");


                pressButtonText.Text = "Naciśnij E aby wyrzucić przedmiot " + itemsToCollect;

                if (takeItem && holdingItem)
                {
                    if (itemTag == "plastic")
                    {
                        holdingItem = false;
                        itemInfo.Text = "";
                        itemsToCollect--;

                    }
                    else
                    {
                        loseText.Text = "Niewłasciwy kosz!";
                        losePanel.Visible = true;
                        losePanel.BringToFront();
                    }
                }

            }
            if (positionX < blueBox.Right && positionX > blueBox.Left && positionX + width < blueBox.Right && positionX + width > blueBox.Left && positionY > obstacle4.Bottom)
            {
                gameBackground = Image.FromFile("bg_blueOpen.png");
                pressButtonText.Text = "Naciśnij E aby wyrzucić przedmiot";


                if (takeItem && holdingItem)
                {
                    if (itemTag == "paper")
                    {
                        holdingItem = false;
                        itemInfo.Text = "";
                        itemsToCollect--;

                    }
                    else
                    {
                        loseText.Text = "Niewłasciwy kosz!";
                        losePanel.Visible = true;
                        losePanel.BringToFront();

                    }
                }
            }
            if (positionX < greenBox.Right && positionX > greenBox.Left && positionX + width < greenBox.Right && positionX + width > greenBox.Left && positionY > obstacle4.Bottom)
            {
                gameBackground = Image.FromFile("bg_greenOpen.png");
                pressButtonText.Text = "Naciśnij E aby wyrzucić przedmiot";

                if (takeItem && holdingItem)
                {
                    if (itemTag == "glass")
                    {
                        holdingItem = false;
                        itemInfo.Text = "";
                        itemsToCollect--;

                    }
                    else
                    {
                        loseText.Text = "Niewłasciwy kosz!";
                        losePanel.Visible = true;
                        losePanel.BringToFront();

                    }
                }
            }
            if (positionX < brownBox.Right && positionX > brownBox.Left && positionX + width < brownBox.Right && positionX + width > brownBox.Left && positionY > obstacle4.Bottom)
            {
                gameBackground = Image.FromFile("bg_brownOpen.png");
                pressButtonText.Text = "Naciśnij E aby wyrzucić przedmiot";
                if (takeItem && holdingItem)
                {
                    if (itemTag == "bio")
                    {
                        holdingItem = false;
                        itemInfo.Text = "";
                        itemsToCollect--;

                    }
                    else
                    {
                        loseText.Text = "Niewłasciwy kosz!";
                        losePanel.Visible = true;
                        losePanel.BringToFront();
                    }
                }

            }
            if (positionX > brownBox.Right || betweemBoxes())
            {
                gameBackground = Image.FromFile("background_all_closed_test.png");
                pressButtonText.Text = "";

            }




            if (level == 1)
            {

                obstacleOne.Visible = true;
                obstacle2.Visible = false;
                obstacle3.Visible = false;
                obstacle4.Visible = false;
                obstacle5.Visible = false;

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

                if (moveJump)
                {
                    positionY -= force;
                    force -= 1;
                }
                if (positionY + height >= this.ClientSize.Height - 45)
                {
                    positionY = this.ClientSize.Height - height - 45;
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

                else
                {
                    pressButtonText.Text = "";
                }

            }

            if (level == 2)
            {
                obstacleOne.Visible = true;
                obstacle2.Visible = true;
                obstacle3.Visible = true;
                obstacle4.Visible = false;
                obstacle5.Visible = false;



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

                if (positionX < obstacle2.Right && positionX >= obstacle2.Left &&
                    positionY <= obstacle2.Bottom)
                {
                    moveLeft = false;
                }
                if (positionX + width >= obstacle2.Left && positionX + width <= obstacle2.Right &&
                    positionY <= obstacle2.Bottom)
                {

                    moveRight = false;

                }

                if (positionX + width >= obstacle3.Left && positionX + width <= obstacle3.Right &&
                    positionY < obstacle3.Bottom && positionY > obstacle3.Top)
                {
                    moveRight = false;
                }


                if (moveJump)
                {
                    positionY -= force;
                    force -= 1;
                }
                if (positionY + height >= this.ClientSize.Height - 45)
                {
                    positionY = this.ClientSize.Height - height - 45;
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
                if (positionX + width > obstacle3.Left && positionX < obstacle3.Right &&
                     positionY + height >= obstacle3.Top && positionY < obstacle3.Top)
                {

                    force = 0;
                    moveJump = false;
                    positionY = obstacle3.Top - height;

                }
                if (positionY + 10 <= obstacle3.Bottom && positionY + 10 > obstacle3.Top && positionX >= obstacle3.Left + 25)
                {
                    force = 0;
                    positionY = this.ClientSize.Height - height - 45;
                    moveJump = false;
                }

                else
                {
                    pressButtonText.Text = "";
                }


            }
            if (level == 3)
            {
                obstacleOne.Visible = true;
                obstacle2.Visible = true;
                obstacle3.Visible = true;
                obstacle4.Visible = true;
                obstacle5.Visible = true;



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

                if (positionX < obstacle2.Right && positionX >= obstacle2.Left &&
                    positionY <= obstacle2.Bottom)
                {
                    moveLeft = false;
                }
                if (positionX + width >= obstacle2.Left && positionX + width <= obstacle2.Right &&
                    positionY <= obstacle2.Bottom)
                {

                    moveRight = false;

                }

                if (positionX + width >= obstacle3.Left && positionX + width <= obstacle3.Right &&
                    positionY < obstacle3.Bottom && positionY > obstacle3.Top)
                {
                    moveRight = false;
                }

                if (positionX < obstacle5.Right && positionX >= obstacle5.Left &&
                          positionY + height > obstacle5.Top)
                {

                    moveLeft = false;

                }

                if (positionX + width >= obstacle5.Left && positionX + width <= obstacle5.Right &&
                    positionY + height > obstacle5.Top)
                {

                    moveRight = false;

                }


                if (moveJump)
                {
                    positionY -= force;
                    force -= 1;
                }
                if (positionY + height >= this.ClientSize.Height - 45)
                {
                    positionY = this.ClientSize.Height - height - 45;
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
                if (positionX + width > obstacle3.Left && positionX < obstacle3.Right &&
                     positionY + height >= obstacle3.Top && positionY < obstacle3.Top)
                {

                    force = 0;
                    moveJump = false;
                    positionY = obstacle3.Top - height;

                }
                if (positionX + width > obstacle4.Left && positionX < obstacle4.Right &&
                     positionY + height >= obstacle4.Top && positionY < obstacle4.Top)
                {

                    force = 0;
                    moveJump = false;
                    positionY = obstacle4.Top - height;

                }
                if (positionX + width > obstacle5.Left && positionX < obstacle5.Right &&
                    positionY + height >= obstacle5.Top && positionY < obstacle5.Top)
                {

                    force = 0;
                    moveJump = false;
                    positionY = obstacle5.Top - height;

                }
                if (positionY + 10 <= obstacle3.Bottom && positionY + 10 > obstacle3.Top && positionX >= obstacle3.Left + 25)
                {
                    force = 0;
                    positionY = this.ClientSize.Height - height - 45;
                    moveJump = false;
                }
                if (positionY + 10 <= obstacle4.Bottom && positionY + 10 > obstacle4.Top && positionX <= obstacle4.Right)
                {
                    force = 0;
                    positionY = this.ClientSize.Height - height - 45;
                    moveJump = false;
                }



                else
                {
                    pressButtonText.Text = "";
                }
            }





            if (moveLeft && positionX > 0)
            {
                gamePlayer = Image.FromFile("malpa.png");
                positionX -= speed;
                if (bg_X < 0)
                {
                    bg_X += speed - 1;
                    obstacleOne.Left += speed - 1;
                    obstacle2.Left += speed - 1;
                    obstacle3.Left += speed - 1;
                    obstacle4.Left += speed - 1;
                    obstacle5.Left += speed - 1;
                    yellowBox.Left += speed - 1;
                    blueBox.Left += speed - 1;
                    greenBox.Left += speed - 1;
                    brownBox.Left += speed - 1;
                    bottle.x += speed - 1;
                    sok.x += speed - 1;
                    apple.x += speed - 1;
                    sloik.x += speed - 1;
                    glassBottle.x += speed - 1;
                    rotten_apple.x += speed - 1;
                    kartonPudlo.x += speed - 1;
                    puszka.x += speed - 1;
                    banan.x += speed - 1;
                    torba.x += speed - 1;
                    baton.x += speed - 1;
                    papier.x += speed - 1;
                    gruszka.x += speed - 1;
                }
            }
            if (moveRight && positionX + width < this.ClientSize.Width)
            {
                gamePlayer = Image.FromFile("malpa_reversed.png");
                positionX += speed;

                if (bg_X + gameBackground.Width > this.ClientSize.Width)
                {
                    bg_X -= speed - 1;
                    obstacleOne.Left -= speed - 1;
                    obstacle2.Left -= speed - 1;
                    obstacle3.Left -= speed - 1;
                    obstacle4.Left -= speed - 1;
                    obstacle5.Left -= speed - 1;
                    yellowBox.Left -= speed - 1;
                    blueBox.Left -= speed - 1;
                    brownBox.Left -= speed - 1;
                    greenBox.Left -= speed - 1;
                    bottle.x -= speed - 1;
                    sok.x -= speed - 1;
                    apple.x -= speed - 1;
                    sloik.x -= speed - 1;
                    glassBottle.x -= speed - 1;
                    rotten_apple.x -= speed - 1;
                    kartonPudlo.x -= speed - 1;
                    puszka.x -= speed - 1;
                    banan.x -= speed - 1;
                    torba.x -= speed - 1;
                    baton.x -= speed - 1;
                    papier.x -= speed - 1;
                    gruszka.x -= speed - 1;

                }


            }











            if (level == 1)
            {

                if (positionX >= bottle.x && positionX + width <= bottle.x + bottle.width + 20)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        bottle.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = bottle.objectName;
                    }
                }
                if (positionX >= sok.x && positionX + width <= sok.x + sok.width + 20)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        sok.x = -5000;
                        itemTag = "paper";
                        itemInfo.Text = sok.objectName;
                    }
                }
                if (positionX >= apple.x && positionX + width <= apple.x + apple.width + 25)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        apple.x = -5000;
                        itemTag = "bio";
                        itemInfo.Text = apple.objectName;
                    }
                }
                if (positionX >= glassBottle.x && positionX + width <= glassBottle.x + glassBottle.width + 25)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        glassBottle.x = -5000;
                        itemTag = "glass";
                        itemInfo.Text = glassBottle.objectName;
                    }
                }

            }
            if (level == 2)
            {

                if (positionX >= puszka.x && positionX + width <= puszka.x + puszka.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        puszka.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = puszka.objectName;
                    }

                }
                if (positionX >= kartonPudlo.x && positionX + width <= kartonPudlo.x + kartonPudlo.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        kartonPudlo.x = -5000;
                        itemTag = "paper";
                        itemInfo.Text = kartonPudlo.objectName;
                    }

                }
                if (positionX >= rotten_apple.x && positionX + width <= rotten_apple.x + rotten_apple.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        rotten_apple.x = -5000;
                        itemTag = "bio";
                        itemInfo.Text = rotten_apple.objectName;
                    }

                }
                if (positionX >= sloik.x && positionX + width <= sloik.x + sloik.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        sloik.x = -5000;
                        itemTag = "glass";
                        itemInfo.Text = sloik.objectName;
                    }

                }

                if (positionX >= banan.x && positionX + width <= banan.x + banan.width + 25 && positionY < obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        banan.x = -5000;
                        itemTag = "bio";
                        itemInfo.Text = banan.objectName;
                    }

                }
                if (positionX >= torba.x - 25 && positionX + width <= torba.x + torba.width && positionY < obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        torba.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = torba.objectName;
                    }

                }


            }

            if (level == 3)
            {
                if (positionX >= bottle.x && positionX + width <= bottle.x + bottle.width + 20)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        bottle.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = bottle.objectName;
                    }
                }
                if (positionX >= banan.x && positionX + width <= banan.x + banan.width + 25 && positionY < obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        banan.x = -5000;
                        itemTag = "bio";
                        itemInfo.Text = banan.objectName;
                    }

                }
                if (positionX >= torba.x - 25 && positionX + width <= torba.x + torba.width && positionY < obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        torba.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = torba.objectName;
                    }

                }
                if (positionX >= papier.x && positionX + width <= papier.x + papier.width + 20)
                {
                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        papier.x = -5000;
                        itemTag = "paper";
                        itemInfo.Text = papier.objectName;
                    }
                }
                if (positionX >= baton.x && positionX + width <= baton.x + baton.width + 25 && positionY < obstacle4.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        baton.x = -5000;
                        itemTag = "plastic";
                        itemInfo.Text = baton.objectName;
                    }

                }
                if (positionX >= kartonPudlo.x && positionX + width <= kartonPudlo.x + kartonPudlo.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        kartonPudlo.x = -5000;
                        itemTag = "paper";
                        itemInfo.Text = kartonPudlo.objectName;
                    }

                }
                if (positionX >= gruszka.x && positionX + width <= gruszka.x + gruszka.width + 25 && positionY > obstacle3.Bottom)
                {

                    pressButtonText.Text = "Naciśnij E aby podnieść przedmiot";

                    if (takeItem == true && holdingItem == false)
                    {
                        holdingItem = true;
                        gruszka.x = -5000;
                        itemTag = "bio";
                        itemInfo.Text = gruszka.objectName;
                    }

                }

            }



            if (itemsToCollect == 0)
            {
                if (level == 1 || level == 2)
                {
                    levelWinPanel.Visible = true;
                    levelWinPanel.BringToFront();
                    Timer.Stop();
                }
                if (level == 3)
                {
                    finalPanel.Visible = true;
                    finalPanel.BringToFront();
                    Timer.Stop();

                }
            }
            if (s == levelTime)
            {
                Timer.Stop();
                loseText.Text = "Czas upłynał";
                losePanel.Visible = true;
                losePanel.BringToFront();
            }
            if (openMenu == true)
            {
                Timer.Stop();
                menuPanel.Visible = true;
                menuPanel.BringToFront();
            }


            this.Invalidate();

        }
        private void keyDownEvent(object sender, KeyEventArgs e)
        {

            if (levelWinPanel.Visible == false && losePanel.Visible == false && menuPanel.Visible == false)
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
                if (e.KeyCode == Keys.M)
                {
                    openMenu = true;
                }
            }

        }
        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            if (levelWinPanel.Visible == false && losePanel.Visible == false)
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




        }


        private void formPaintingEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;


            Canvas.DrawImage(gameBackground, bg_X, bg_Y);


            if (level == 1)
            {

                Canvas.DrawImage(bottleImage, bottle.x, bottle.y, bottle.width, bottle.height);
                Canvas.DrawImage(sokImage, sok.x, sok.y, sok.width, sok.height);
                Canvas.DrawImage(appleImage, apple.x, apple.y, apple.width, apple.height);
                Canvas.DrawImage(glassBottleImage, glassBottle.x, glassBottle.y, glassBottle.width, glassBottle.height);

            }
            if (level == 2)
            {
                Canvas.DrawImage(rottenImage, rotten_apple.x, rotten_apple.y, rotten_apple.width, rotten_apple.height);
                Canvas.DrawImage(kartonPudloImage, kartonPudlo.x, kartonPudlo.y, kartonPudlo.width, kartonPudlo.height);
                Canvas.DrawImage(puszkaImage, puszka.x, puszka.y, puszka.width, puszka.height);
                Canvas.DrawImage(sloikImage, sloik.x, sloik.y, sloik.width, sloik.height);
                Canvas.DrawImage(bananImage, banan.x, banan.y, banan.width, banan.height);
                Canvas.DrawImage(torbaImage, torba.x, torba.y, torba.width, torba.height);
            }
            if (level == 3)
            {
                Canvas.DrawImage(bottleImage, bottle.x, bottle.y, bottle.width, bottle.height);
                Canvas.DrawImage(bananImage, banan.x, banan.y, banan.width, banan.height);
                Canvas.DrawImage(torbaImage, torba.x, torba.y, torba.width, torba.height);
                Canvas.DrawImage(batonImage, baton.x, baton.y, baton.width, baton.height);
                Canvas.DrawImage(papierImage, papier.x, papier.y, papier.width, papier.height);
                Canvas.DrawImage(kartonPudloImage, kartonPudlo.x, kartonPudlo.y, kartonPudlo.width, kartonPudlo.height);
                Canvas.DrawImage(gruszkaImage, gruszka.x, gruszka.y, gruszka.width, gruszka.height);

            }

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
            if ((positionX > yellowBox.Right && positionX < blueBox.Left) ||
               (positionX + width > yellowBox.Right && positionX + width < blueBox.Left) ||
                (positionX > blueBox.Right && positionX < greenBox.Left) ||
                (positionX + width > blueBox.Right && positionX + width < greenBox.Left) ||
                (positionX > greenBox.Right && positionX < brownBox.Left) ||
                (positionX + width > greenBox.Right && positionX + width < brownBox.Left))
            {

                return true;

            }
            else
            {
                return false;
            }

        }

        public void startValues()
        {
            levelWinPanel.Visible = false;
            losePanel.Visible = false;
            holdingItem = false;
            takeItem = false;
            positionX = 50;
            positionY = 500;
            bg_X = 0;
            bg_Y = 0;
            bottle.x = 1100;
            sok.x = 1250;
            apple.x = 1400;
            glassBottle.x = 1550;
            rotten_apple.x = 1400;
            kartonPudlo.x = 1250;
            puszka.x = 1100;
            sloik.x = 1550;
            banan.x = 1600;
            torba.x = 1750;
            baton.x = 100;
            papier.x = 1400;
            gruszka.x = 1550;
            obstacleOne.Left = 920;
            obstacleOne.Top = 336;
            obstacle2.Left = 920;
            obstacle2.Top = -101;
            obstacle3.Left = 1550;
            obstacle3.Top = 256;
            obstacle4.Left = -50;
            obstacle4.Top = 250;
            obstacle5.Left = 612;
            obstacle5.Top = 425;
            yellowBox.Left = 12;
            blueBox.Left = 232;
            greenBox.Left = 462;
            brownBox.Left = 701;
            s = 0;
            m = 0;

            itemInfo.Text = "";




            Timer.Start();
            setLvlValues();

        }
        public void setLvlValues()
        {

            if (level == 1)
            {

                itemsToCollect = 4;
                levelTime = 60;
                levelInfo.Text = "POZIOM 1";
            }
            if (level == 2)
            {
                itemsToCollect = 2;
                levelTime = 90;
                levelInfo.Text = "POZIOM 2";
            }
            if (level == 3)
            {
                itemsToCollect = 1;
                levelTime = 120;
                levelInfo.Text = "POZIOM 3";
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void winNextLevel_Click(object sender, EventArgs e)
        {
            levelWinPanel.Visible = false;
            level++;
            startValues();
            this.Focus();
        }

        private void winRestartLevel_Click(object sender, EventArgs e)
        {
            levelWinPanel.Visible = false;
            startValues();
            this.Focus();

        }

        private void winLeaveGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loseGameRestart_Click(object sender, EventArgs e)
        {
            losePanel.Visible = false;
            startValues();
            this.Focus();
        }

        private void loseLeaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void obstacle5_Click(object sender, EventArgs e)
        {

        }

        private void menuLeaveButton_Click(object sender, EventArgs e)
        {
            openMenu = false;
            menuPanel.Visible = false;
            this.Focus();
            Timer.Start();
        }

        private void movingBackButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            openMenu = false;
            movingPanel.Visible = false;
            menuPanel.BringToFront();
        }

        private void menuMovingButton_Click(object sender, EventArgs e)
        {

            movingPanel.Visible = true;
            openMenu = false;
            menuPanel.Visible = false;
            movingPanel.BringToFront();

        }

        private void finalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            finalPanel.Visible = false;
            level = 1;
            startValues();
            this.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    public class Paper
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string imagePath;
        public string objectName;

        public Paper(int x, int y, int width, int height, string imagePath, string objectName)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.imagePath = imagePath;
            this.objectName = objectName;
        }

    }

    public class Plastic
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string imagePath;
        public string objectName;

        public Plastic(int x, int y, int width, int height, string imagePath, string objectName)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.imagePath = imagePath;
            this.objectName = objectName;
        }

    }

    public class Glass
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string imagePath;
        public string objectName;

        public Glass(int x, int y, int width, int height, string imagePath, string objectName)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.imagePath = imagePath;
            this.objectName = objectName;
        }

    }
    public class Bio
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string imagePath;
        public string objectName;

        public Bio(int x, int y, int width, int height, string imagePath, string objectName)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.imagePath = imagePath;
            this.objectName = objectName;
        }

    }







}