namespace ReidFinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreBGLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreOutputLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.warriorPictureBox = new System.Windows.Forms.PictureBox();
            this.healerPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warriorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBGLabel
            // 
            this.scoreBGLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.scoreBGLabel.ForeColor = System.Drawing.Color.White;
            this.scoreBGLabel.Location = new System.Drawing.Point(0, 499);
            this.scoreBGLabel.Name = "scoreBGLabel";
            this.scoreBGLabel.Size = new System.Drawing.Size(503, 40);
            this.scoreBGLabel.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.White;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(4, 503);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(92, 30);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score : ";
            // 
            // scoreOutputLabel
            // 
            this.scoreOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutputLabel.Location = new System.Drawing.Point(102, 503);
            this.scoreOutputLabel.Name = "scoreOutputLabel";
            this.scoreOutputLabel.Size = new System.Drawing.Size(60, 30);
            this.scoreOutputLabel.TabIndex = 2;
            this.scoreOutputLabel.Text = "0";
            // 
            // controlsLabel
            // 
            this.controlsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.Location = new System.Drawing.Point(237, 503);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(261, 30);
            this.controlsLabel.TabIndex = 3;
            this.controlsLabel.Text = "w = up, d = right, s = down, a = left";
            // 
            // characterLabel
            // 
            this.characterLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(153, 103);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(198, 32);
            this.characterLabel.TabIndex = 4;
            this.characterLabel.Text = "Select a Character";
            // 
            // warriorPictureBox
            // 
            this.warriorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.warriorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.warriorPictureBox.Image = global::ReidFinalProject.Properties.Resources.warrior_neutral;
            this.warriorPictureBox.Location = new System.Drawing.Point(145, 190);
            this.warriorPictureBox.Name = "warriorPictureBox";
            this.warriorPictureBox.Size = new System.Drawing.Size(70, 70);
            this.warriorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warriorPictureBox.TabIndex = 6;
            this.warriorPictureBox.TabStop = false;
            this.warriorPictureBox.Click += new System.EventHandler(this.warriorPictureBox_Click);
            // 
            // healerPictureBox
            // 
            this.healerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.healerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.healerPictureBox.Image = global::ReidFinalProject.Properties.Resources.healer_neutral;
            this.healerPictureBox.Location = new System.Drawing.Point(290, 190);
            this.healerPictureBox.Name = "healerPictureBox";
            this.healerPictureBox.Size = new System.Drawing.Size(70, 70);
            this.healerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.healerPictureBox.TabIndex = 5;
            this.healerPictureBox.TabStop = false;
            this.healerPictureBox.Click += new System.EventHandler(this.healerPictureBox_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(190, 73);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(119, 29);
            this.gameOverLabel.TabIndex = 7;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.White;
            this.replayButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.Location = new System.Drawing.Point(199, 286);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(103, 32);
            this.replayButton.TabIndex = 8;
            this.replayButton.Text = "Play Again";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(200, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReidFinalProject.Properties.Resources.map;
            this.ClientSize = new System.Drawing.Size(502, 537);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.warriorPictureBox);
            this.Controls.Add(this.healerPictureBox);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.scoreOutputLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreBGLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.warriorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreBGLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreOutputLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.PictureBox warriorPictureBox;
        private System.Windows.Forms.PictureBox healerPictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

