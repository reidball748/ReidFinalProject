﻿using System;
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

namespace ReidFinalProject
{
    public partial class Form1 : Form
    {
        int spriteNeutral, spriteUp, spriteRight, spriteDown, spriteLeft, score;
        Boolean aDown, sDown, dDown, wDown, ninjaLeft, ninjaRight, ninjaUp, ninjaDown, enemySpawn;
        int ninjaSpeed;

        Image currentImage = Properties.Resources.start_image;

        Random randGen= new Random();

        int ninjaValue;

        Stopwatch time  = new Stopwatch();
        SoundPlayer bgMusic = new SoundPlayer(Properties.Resources.Steven_Universe___The_Crystal_Gems_Chiptune_);
        SoundPlayer hitSound = new SoundPlayer(Properties.Resources.ROBLOX_Death_Sound);

        int newNinja = 4;
        int x1Ninja, x2Ninja, x3Ninja, x4Ninja;
        int y1Ninja, y2Ninja, y3Ninja, y4Ninja; 

        Graphics formGraphics; 
        public Form1()
        {
            InitializeComponent();
            formGraphics = this.CreateGraphics();
            ninjaSpeed = 100;

            Thread bgm = new Thread(backMusic);
            bgm.Start();
            //Music.Play();

            x1Ninja = x2Ninja = x3Ninja = x4Ninja = y1Ninja = y2Ninja = y3Ninja = y4Ninja = -1000;
           
        }

        public void backMusic()
        {
            bgMusic.Play();

        }

        private void warriorPictureBox_Click(object sender, EventArgs e)
        {
            characterLabel.Visible = false;
            healerPictureBox.Visible = false;
            warriorPictureBox.Visible = false;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false;

            spriteNeutral = 1;
            spriteUp = 1;
            spriteRight = 1;
            spriteDown = 1;
            spriteLeft = 1;

            gameTimer.Enabled = true;
            gameTimer.Start();
            time.Start();

            currentImage = Properties.Resources.warrior_neutral;

            enemySpawn = true; 
        }

        private void healerPictureBox_Click(object sender, EventArgs e)
        {
            characterLabel.Visible = false;
            healerPictureBox.Visible = false;
            warriorPictureBox.Visible = false;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false;

            spriteNeutral = 2;
            spriteUp = 2;
            spriteRight = 2;
            spriteDown = 2;
            spriteLeft = 2;

            gameTimer.Enabled = true;
            gameTimer.Start();
            time.Start();

            currentImage = Properties.Resources.healer_neutral;

            enemySpawn = true;
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            characterLabel.Visible = true;
            healerPictureBox.Visible = true;
            warriorPictureBox.Visible = true;
            gameOverLabel.Visible = false;
            replayButton.Visible = false;
            exitButton.Visible = false; 
            currentImage = Properties.Resources.start_image;
            x1Ninja = x2Ninja = x3Ninja = x4Ninja = y1Ninja = y2Ninja = y3Ninja = y4Ninja = -1000;
            score = 0;
            bgMusic.Play();
            this.Focus(); 
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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
                ninjaValue = randGen.Next(0, 4);
                //ninjaValue = 0;
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

            scoreOutputLabel.Text = "" + score;

            newNinja++;
            Refresh();

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(currentImage, 217, 190, 70, 70); 

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
