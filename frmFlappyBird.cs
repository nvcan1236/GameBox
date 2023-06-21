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
    public partial class frmFlappyBird : Form
    {
        
        int gravity = 20;
        int score = 0;
        int speed = 8;
        string path = Application.StartupPath + @"\Images\";
        Random rand = new Random();
        frmMain parent;
        public int Score { set { score = value; } get { return score; } }
        public frmFlappyBird()
        {
            InitializeComponent();
        }

        public frmFlappyBird(frmMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }   

        private void frmFlappyBird_Load(object sender, EventArgs e)
        {
            bird.BackColor = Color.Transparent;
            timer1.Enabled = false;
        }
        private void frmFlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                gravity = 15;
        }

        private void frmFlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                gravity = -15;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            bird.Top += gravity;
            ongtren.Left -= speed;
            ongduoi.Left -= speed;
            picSun.Left -= speed;
            lbScore.Text = $"Score: {Score}";
            if (ongtren.Right <= bird.Left)
            {
                ongtren.Left = rand.Next(600, 900);
                Score++;
            }
            if (ongduoi.Right <= bird.Left)
            {
                ongduoi.Left = rand.Next(600, 900);
                Score++;
            }
            if (picSun.Right <= 0)
            {
                picSun.Left = rand.Next(800, 900);
                int n = rand.Next(1, 8);
                picSun.Image = Image.FromFile(path + n.ToString() + ".png");
                
            }
                
            if (bird.Bounds.IntersectsWith(ongtren.Bounds) || bird.Bounds.IntersectsWith(ongduoi.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Stop();
                timer1.Enabled = false;
                parent.setHistory("Flappy Bird", Score);
                frmResult f2 = new frmResult(this);
                f2.Show();
            }
            if (Score > 5) speed += 1;
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            playGame();
            timer1.Enabled = true;
        }
        public void playGame()
        {
            picPlay.Visible = false;//ẩn pic
            bird.Location = new Point(20, 170);
            speed = 8;
            Score = 0;
            ongtren.Left = 489;
            ongduoi.Left = 652;
            timer1.Enabled = true;
        }
    }
}
