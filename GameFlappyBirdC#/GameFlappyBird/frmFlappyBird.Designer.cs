
namespace GameFlappyBird
{
    partial class frmFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.picSun = new System.Windows.Forms.PictureBox();
            this.ongtren = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ongduoi = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.InitialImage = ((System.Drawing.Image)(resources.GetObject("ground.InitialImage")));
            this.ground.Location = new System.Drawing.Point(-1, 471);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(983, 82);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(20, 170);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(57, 53);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(848, 500);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(122, 44);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score: 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSun
            // 
            this.picSun.Image = ((System.Drawing.Image)(resources.GetObject("picSun.Image")));
            this.picSun.Location = new System.Drawing.Point(915, -1);
            this.picSun.Name = "picSun";
            this.picSun.Size = new System.Drawing.Size(67, 66);
            this.picSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSun.TabIndex = 3;
            this.picSun.TabStop = false;
            // 
            // ongtren
            // 
            this.ongtren.Image = global::GameFlappyBird.Properties.Resources.pipedown;
            this.ongtren.Location = new System.Drawing.Point(489, -1);
            this.ongtren.Name = "ongtren";
            this.ongtren.Size = new System.Drawing.Size(93, 192);
            this.ongtren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongtren.TabIndex = 4;
            this.ongtren.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ongduoi
            // 
            this.ongduoi.Image = global::GameFlappyBird.Properties.Resources.ongduoi1;
            this.ongduoi.Location = new System.Drawing.Point(652, 307);
            this.ongduoi.Name = "ongduoi";
            this.ongduoi.Size = new System.Drawing.Size(93, 166);
            this.ongduoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongduoi.TabIndex = 5;
            this.ongduoi.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(12, 492);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(50, 52);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay.TabIndex = 6;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.ongduoi);
            this.Controls.Add(this.ongtren);
            this.Controls.Add(this.picSun);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox picSun;
        private System.Windows.Forms.PictureBox ongtren;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ongduoi;
        private System.Windows.Forms.PictureBox picPlay;
    }
}

