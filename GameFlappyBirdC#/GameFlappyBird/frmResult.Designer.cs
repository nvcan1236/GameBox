
namespace GameFlappyBird
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.picPlay2 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lbPlay2 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(99, 114);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(117, 25);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Your score: ";
            // 
            // picPlay2
            // 
            this.picPlay2.BackColor = System.Drawing.Color.Transparent;
            this.picPlay2.Image = ((System.Drawing.Image)(resources.GetObject("picPlay2.Image")));
            this.picPlay2.Location = new System.Drawing.Point(46, 174);
            this.picPlay2.Name = "picPlay2";
            this.picPlay2.Size = new System.Drawing.Size(56, 51);
            this.picPlay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay2.TabIndex = 7;
            this.picPlay2.TabStop = false;
            this.picPlay2.Click += new System.EventHandler(this.picPlay2_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(298, 174);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(81, 51);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lbPlay2
            // 
            this.lbPlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlay2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPlay2.Location = new System.Drawing.Point(91, 174);
            this.lbPlay2.Name = "lbPlay2";
            this.lbPlay2.Size = new System.Drawing.Size(91, 51);
            this.lbPlay2.TabIndex = 8;
            this.lbPlay2.Text = "PLAY";
            this.lbPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExit
            // 
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbExit.Location = new System.Drawing.Point(363, 174);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(91, 51);
            this.lbExit.TabIndex = 8;
            this.lbExit.Text = "EXIT";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(249, 114);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(116, 23);
            this.lblScore.TabIndex = 9;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbPlay2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picPlay2);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox picPlay2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lbPlay2;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lblScore;
    }
}