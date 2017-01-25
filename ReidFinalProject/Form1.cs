//Program created by Reid Ball 
//1/25/2017 
//Keep'Em Away is a game where you try to kepp the ninjas away from you as long as possible
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Threading; 
using System.Linq;
using System.Media; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ReidFinalProject
{
    public partial class Form1 : Form
    {   
        //declaring all variables and creating all other components
        int spriteNeutral, spriteUp, spriteRight, spriteDown, spriteLeft, score;
        Boolean aDown, sDown, dDown, wDown, enemySpawn;

        Image currentImage = Properties.Resources.start_image;

        Random randGen= new Random();

        int ninjaValue;

        Stopwatch time  = new Stopwatch();
        SoundPlayer hitSound = new SoundPlayer(Properties.Resources.ROBLOX_Death_Sound);

        int newNinja = 4;
        int x1Ninja, x2Ninja, x3Ninja, x4Ninja;
        int y1Ninja, y2Ninja, y3Ninja, y4Ninja; 

        WindowsMediaPlayer backMusicMP;

        public Form1()
        {
            InitializeComponent();

            //background music plays
            backMusicMP = new WindowsMediaPlayer();
            backMusicMP.URL = "back.mp3";
            backMusicMP.controls.play();

            x1Ninja = x2Ninja = x3Ninja = x4Ninja = y1Ninja = y2Ninja = y3Ninja = y4Ninja = -1000;
           
        }

        private void warriorPictureBox_Click(object sender, EventArgs e)
        {
            //getting rid of unnecessary labels
            characterLabel.Visible = false;
            healerPictureBox.Visible = false;
            warriorPictureBox.Visible = false;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false;

            //setting sprite values
            spriteNeutral = 1;
            spriteUp = 1;
            spriteRight = 1;
            spriteDown = 1;
            spriteLeft = 1;

            //start the timer
            gameTimer.Enabled = true;
            gameTimer.Start();
            time.Start();

            //settin the charactrer
            currentImage = Properties.Resources.warrior_neutral;

            //starting to spawn ninjas
            enemySpawn = true; 
        }

        private void healerPictureBox_Click(object sender, EventArgs e)
        {
            //getting rid of unnecessary labels
            characterLabel.Visible = false;
            healerPictureBox.Visible = false;
            warriorPictureBox.Visible = false;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false;

            //setting sprite values
            spriteNeutral = 2;
            spriteUp = 2;
            spriteRight = 2;
            spriteDown = 2;
            spriteLeft = 2;

            //start the timer
            gameTimer.Enabled = true;
            gameTimer.Start();
            time.Start();

            //settin the charactrer
            currentImage = Properties.Resources.healer_neutral;

            //starting to spawn ninjas
            enemySpawn = true;
        }

        private void replayButton_Click(object sender, EventArgs e)
        { 
            //button that becomes visible when player dies; allows player to play again
            characterLabel.Visible = true;
            healerPictureBox.Visible = true;
            warriorPictureBox.Visible = true;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false; 
            currentImage = Properties.Resources.start_image;
            x1Ninja = x2Ninja = x3Ninja = x4Ninja = y1Ninja = y2Ninja = y3Ninja = y4Ninja = -1000;
            score = 0;
            this.Focus(); 
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //button that becomes visible when player loses; can close program
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                default:
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been let go of and set is KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region move character based on key presses

            if (aDown == true && spriteLeft == 1)
            {
                currentImage = Properties.Resources.warrior_left;
                sDown = false;
                dDown = false;  
                wDown = false; 
            }
            else if (aDown == true && spriteLeft == 2)
            {
                currentImage = Properties.Resources.healer_left;
                sDown = false;
                dDown = false;
                wDown = false;
            }

            if (sDown == true && spriteDown == 1)
            {
                currentImage = Properties.Resources.warrior_down;
                aDown = false;
                dDown = false;
                wDown = false;
            }
            else if (sDown == true && spriteDown == 2)
            {
                currentImage = Properties.Resources.healer_down;
                aDown = false;
                dDown = false;
                wDown = false;
            }

            if (dDown == true && spriteRight == 1)
            {
                currentImage = Properties.Resources.warrior_right;
                aDown = false;
                sDown = false;
                wDown = false;
            }
            else if (dDown == true && spriteRight == 2)
            {
                currentImage = Properties.Resources.healer_right;
                aDown = false;
                sDown = false;
                wDown = false;
            }

            if (wDown == true && spriteUp == 1)
            {
                currentImage = Properties.Resources.warrior_up;
                aDown = false;
                sDown = false;
                dDown = false;
            }
            else if (wDown == true && spriteRight == 2)
            {
                currentImage = Properties.Resources.healer_up;
                aDown = false;
                sDown = false;
                dDown = false;
            }

            if (wDown == false && sDown == false && dDown == false && aDown == false && spriteNeutral == 1)
            {
                currentImage = Properties.Resources.warrior_neutral;
            }
            else if (wDown == false && sDown == false && dDown == false && aDown == false && spriteNeutral == 2)
            {
                currentImage = Properties.Resources.healer_neutral;
            }

            #endregion


            #region spawn ninja if time

            if (newNinja == 40)
            {
                //setting the ninja value
                ninjaValue = randGen.Next(0, 4);

                //if statements that check ninja value and set starting x and y for ninja
                newNinja = 0;

                if (ninjaValue == 0)
                {
                    x1Ninja = -67;
                    y1Ninja = 190;
                }
                else if (ninjaValue == 1)
                {
                    x2Ninja = 216;
                    y2Ninja = -67;
                }
                else if (ninjaValue == 2)
                {
                    x3Ninja = 500;
                    y3Ninja = 190;
                }
                else
                {
                    x4Ninja = 216;
                    y4Ninja = 500;
                }
            }



            #endregion


            #region move ninja
            if (ninjaValue == 0 && newNinja %10 == 0)
            { 
                x1Ninja = x1Ninja + 70;

            } 
            else if (ninjaValue == 1 && newNinja %10 == 0) 
            {
                y2Ninja = y2Ninja + 70;
            }
            else if (ninjaValue == 2 && newNinja % 10 == 0)
            {
                x3Ninja = x3Ninja - 70;
            }
            else if (ninjaValue == 3 && newNinja % 10 == 0)
            {
                y4Ninja = y4Ninja - 70;
            }


            #endregion

            #region collision

            Rectangle heroRec = new Rectangle(217, 190, 70, 70);
            Rectangle ninjaRec1 = new Rectangle(x1Ninja, y1Ninja, 70, 70);
            Rectangle ninjaRec2 = new Rectangle(x2Ninja, y2Ninja, 70, 70);
            Rectangle ninjaRec3 = new Rectangle(x3Ninja, y3Ninja, 70, 70);
            Rectangle ninjaRec4 = new Rectangle(x4Ninja, y4Ninja, 70, 70);

            if (ninjaValue == 0)
            {
                if (ninjaRec1.IntersectsWith(heroRec) && aDown == true)
                {
                    score++;
                    x1Ninja = -1000;
                    y1Ninja = -1000;
                    hitSound.Play();
                } 
                else if (ninjaRec1.IntersectsWith(heroRec) && aDown == false)
                {
                    gameTimer.Enabled = false; 
                    gameOverLabel.Visible = true;
                    replayButton.Visible = true;
                    exitButton.Visible = true;
                    hitSound.Play();
                }
            }
            else if (ninjaValue == 1)
            {
                if (ninjaRec2.IntersectsWith(heroRec) && wDown == true)
                {
                    score++;
                    x2Ninja = -1000;
                    y2Ninja = -1000;
                    hitSound.Play();
                }
                else if (ninjaRec2.IntersectsWith(heroRec) && wDown == false)
                {
                    gameTimer.Enabled = false;
                    gameOverLabel.Visible = true;
                    replayButton.Visible = true;
                    exitButton.Visible = true;
                    hitSound.Play();
                }
            }
            else if (ninjaValue == 2)
            {
                if (ninjaRec3.IntersectsWith(heroRec) && dDown == true)
                {
                    score++;
                    x3Ninja = -1000;
                    y3Ninja = -1000;
                    hitSound.Play();
                }
                else if (ninjaRec3.IntersectsWith(heroRec) && dDown == false)
                {
                    gameTimer.Enabled = false;
                    gameOverLabel.Visible = true;
                    replayButton.Visible = true;
                    exitButton.Visible = true;
                    hitSound.Play();
                }
            }
            else if (ninjaValue == 3)
            {
                if (ninjaRec4.IntersectsWith(heroRec) && sDown == true)
                {
                    score++;
                    x4Ninja = -1000;
                    y4Ninja = -1000;
                    hitSound.Play();
                }
                else if (ninjaRec4.IntersectsWith(heroRec) && sDown == false)
                {
                    gameTimer.Enabled = false;
                    gameOverLabel.Visible = true;
                    replayButton.Visible = true;
                    exitButton.Visible = true;
                    hitSound.Play();
                }
            }
            #endregion

            //changing the score
            scoreOutputLabel.Text = "" + score;

            newNinja++;
            Refresh();

        }

        //animations
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //animates character sprite
            e.Graphics.DrawImage(currentImage, 217, 190, 70, 70); 

            //animates ninja according random value
            if (enemySpawn == true && ninjaValue == 0)
            {
                e.Graphics.DrawImage(Properties.Resources.ninja_left_1, x1Ninja, y1Ninja, 70, 70);
            }
            else if (enemySpawn == true && ninjaValue == 1)
            {
                e.Graphics.DrawImage(Properties.Resources.ninja_up_1, x2Ninja, y2Ninja, 70, 70);
            }
            else if (enemySpawn == true && ninjaValue == 2)
            {
                e.Graphics.DrawImage(Properties.Resources.ninja_right_1, x3Ninja, y3Ninja, 70, 70);
            }
            else if (enemySpawn == true && ninjaValue == 3)
            {
                e.Graphics.DrawImage(Properties.Resources.ninja_down_1, x4Ninja, y4Ninja, 70, 70);
            }

        }

    }
}
