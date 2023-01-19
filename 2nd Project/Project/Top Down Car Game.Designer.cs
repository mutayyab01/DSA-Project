namespace Project
{
    partial class Top_Down_Car_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top_Down_Car_Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.raodtrack1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raodtrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.Car2);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.raodtrack1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 570);
            this.panel1.TabIndex = 0;
            // 
            // explosion
            // 
            this.explosion.Image = global::Project.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(78, 419);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 3;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Project.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(117, 242);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 2;
            this.award.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Project.Properties.Resources.CarRed;
            this.player.Location = new System.Drawing.Point(4, 456);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::Project.Properties.Resources.carGrey;
            this.Car2.Location = new System.Drawing.Point(435, 33);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(50, 100);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            this.Car2.Tag = "rightcar";
            // 
            // Car1
            // 
            this.Car1.Image = global::Project.Properties.Resources.carGreen;
            this.Car1.Location = new System.Drawing.Point(49, 32);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 101);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 2;
            this.Car1.TabStop = false;
            this.Car1.Tag = "leftcar";
            this.Car1.Click += new System.EventHandler(this.restartgame);
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::Project.Properties.Resources.roadTrack;
            this.roadtrack2.Location = new System.Drawing.Point(0, -3);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(496, 570);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack2.TabIndex = 1;
            this.roadtrack2.TabStop = false;
            // 
            // raodtrack1
            // 
            this.raodtrack1.Image = global::Project.Properties.Resources.roadTrack;
            this.raodtrack1.Location = new System.Drawing.Point(0, -519);
            this.raodtrack1.Name = "raodtrack1";
            this.raodtrack1.Size = new System.Drawing.Size(496, 570);
            this.raodtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raodtrack1.TabIndex = 0;
            this.raodtrack1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(186, 578);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(149, 35);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "RESTART\r\n";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 134);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press Left and Right to Move the Car\r\nSurvive as long as you can";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblscore
            // 
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(22, 578);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(158, 35);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkGray;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(399, 578);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 32);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Top_Down_Car_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Top_Down_Car_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top_Down_Car_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raodtrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.PictureBox raodtrack1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnexit;
    }
}