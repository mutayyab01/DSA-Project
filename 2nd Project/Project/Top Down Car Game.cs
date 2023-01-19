using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Top_Down_Car_Game : Form
    {
        int roadspeed;
        int trafficspeed;
        int playerspeed=12;
        int carimage;
        int score;

        Random rand = new Random();
        Random Carposition = new Random();

        bool goleft, goright;

        public Top_Down_Car_Game()
        {
            InitializeComponent();
            gamereset();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
           
            btnstart.Enabled = true;
            award.Visible = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            roadspeed = 12;
            trafficspeed = 15;
            award.Image = Properties.Resources.bronze;
            gameTimer.Start();


            gamereset();

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode==Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            lblscore.Text = "Score: " + score;
            score++;




            if (goleft==true && player.Left>5)
            {
                player.Left -= playerspeed;
            }
            if (goright==true && player.Left<442)
            {
               player.Left += playerspeed;
            }

            raodtrack1.Top += roadspeed;
            roadtrack2.Top += roadspeed;

            if (roadtrack2.Top>519)
            {
                roadtrack2.Top = -519;
            }
            if (raodtrack1.Top>519)
            {
                raodtrack1.Top = -519;
            }

            Car1.Top += trafficspeed;
            Car2.Top += trafficspeed;

            if (Car1.Top>530)
            {
                changeCars(Car1);

            }
            if (Car2.Top >530)
            {
                changeCars(Car2);

            }

            if (player.Bounds.IntersectsWith(Car1.Bounds)||player.Bounds.IntersectsWith(Car2.Bounds))
            {
                gameover();
            }
            if (score>40&&score<500)
            {
                award.Image = Properties.Resources.bronze;

            }

            if (score>500&&score<2000)
            {
                award.Image = Properties.Resources.silver;
                roadspeed = 20;
                trafficspeed = 22;

            }
            if (score>2000)
            {
                award.Image = Properties.Resources.gold;
                trafficspeed = 27;
                roadspeed = 25;
            }

        }

        private void changeCars(PictureBox tempcar)
        {
            carimage = rand.Next(1,8);
            switch (carimage)
            {
                case 1:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    tempcar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempcar.Image = Properties.Resources.carYellow;
                    break;
                case 6:
                    tempcar.Image = Properties.Resources.TruckWhite;
                    break;
                case 7:
                    tempcar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempcar.Image = Properties.Resources.CarRed;
                    break;
            }


            tempcar.Top = Carposition.Next(100,400) * -1;
            if ((string)tempcar.Tag=="leftcar")
            {
                tempcar.Left = Carposition.Next(5, 200);

            }

            if ((string)tempcar.Tag=="rightacar")
            {
                tempcar.Left = Carposition.Next(250, 445);
            }


        }
        private void gameover()
        {
            playsound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8,5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();
            btnexit.Enabled = true;
            btnstart.Enabled = true;

        }
        private void gamereset()
        {
            btnexit.Enabled = false;
            btnstart.Enabled = false;
            award.Visible = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            roadspeed = 12; 
            trafficspeed = 15;
            award.Image = Properties.Resources.bronze;

            Car1.Top = Carposition.Next(200,500) * -1;
            Car1.Left = Carposition.Next(5,200);

            Car2.Top = Carposition.Next(200,500) * -1;
            Car2.Left = Carposition.Next(250,445);

            gameTimer.Start();

        }

        private void restartgame(object sender, EventArgs e)
        {
            gamereset();
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void playsound()
        {
            System.Media.SoundPlayer crash = new System.Media.SoundPlayer(Properties.Resources.hit);
            crash.Play();

        }



    }
}
