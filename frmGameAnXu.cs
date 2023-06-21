using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_GameBox
{
    public partial class frmGameAnXu : Form
    {
        bool goup, godown, goleft, goright, Lose;
        int MaVangspeed, MaDospeed, MaHongspeed, xu = 0, playerSpeed;
        frmMain parent;

        private void MaDo_Click(object sender, EventArgs e)
        {

        }

        private void MaVang_Click(object sender, EventArgs e)
        {

        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public frmGameAnXu()
        {
            InitializeComponent();
            resetGame();
        }

        public frmGameAnXu(frmMain parent)
        {
            this.parent = parent;
            InitializeComponent();
            resetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if(e.KeyCode == Keys.Enter && Lose == true)
            {
                resetGame();
            }

        }

        private void MainPlaytimer(object sender, EventArgs e)
        {
            txtXu.Text = "Coin :" + xu;
            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 500;
            }
            if (pacman.Left > 500)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -10)
            {
                pacman.Top = 480;
            }
            if (pacman.Top > 480)
            {
                pacman.Top = -10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "Coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            xu += 1;
                            x.Visible = false;
                        }

                    }

                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameoOver("Thất bại!");
                        }
                    }

                    if ((string)x.Tag == "Ma")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameoOver("Thất bại!");
                        }
                    }

                }

            }
            //gameover
            //Ma di chuyen


            MaDo.Left += MaDospeed;
            if (MaDo.Bounds.IntersectsWith(pictureBox1.Bounds) || MaDo.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MaDospeed = -MaDospeed;
            }

            MaVang.Left -= MaVangspeed;
            if (MaVang.Bounds.IntersectsWith(pictureBox3.Bounds) || MaVang.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                MaVangspeed = -MaVangspeed;
            }


            MaHong.Left -= MaHongspeed;
            if (MaHong.Bounds.IntersectsWith(pictureBox21.Bounds) || MaHong.Bounds.IntersectsWith(pictureBox24.Bounds))
            {
                MaHongspeed = -MaHongspeed;
            }

            if (xu == 41)
            {
                gameoOver("Bạn chiến thắng!");
            }


        }
        private void resetGame()
        {
            xu = 0;
            txtXu.Text = "Coin: " + xu;
            MaDospeed = 4;
            MaVangspeed = 4;
            MaHongspeed = 7;
            Lose = false;
            pacman.Left = 24;
            pacman.Top = 51;

            playerSpeed = 8;

            //MaDo.Left = 222;
            //MaDo.Top = 64;

            //MaVang.Left = 435;
            //MaVang.Top = 450;

            //MaHong.Left = 350;
            //MaHong.Top = 225;

            Playtimer.Start();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }
        private void gameoOver(String messeage)
        {
            Lose= true;
            Playtimer.Stop();
            txtXu.Text += /*"Xu :" + xu +*/ Environment.NewLine + messeage;
            parent.setHistory("Game Ăn Xu", xu);
        }
    }
}
