using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;//add JPG
namespace BaiTapLon_GameBox
{
    public partial class frmSnakeGame : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private frmMain parent;

        private Circle food= new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand= new Random();

        bool goUp, goDown, goLeft, goRight;

        public frmSnakeGame()
        {
            InitializeComponent();
            new Setting();
        }

        public frmSnakeGame(frmMain parent)
        {
            InitializeComponent();
            new Setting();
            this.parent = parent;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Setting.directions != "right")
            {
                goLeft= true;
            }

            if(e.KeyCode==Keys.Right && Setting.directions != "left")
            {
                goRight= true;
            }

            if(e.KeyCode==Keys.Up&& Setting.directions != "down"){
                goUp= true;
            }

            if(e.KeyCode==Keys.Down && Setting.directions != "up")
            {
                goDown= true;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left )
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right )
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            //thêm label vào hình ảnh lưu
            Label caption = new Label();
            caption.Text = "Điểm của bạn là: " + score + "và điểm cao nhất là: " + highScore;
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor= Color.Black;
            caption.AutoSize = false;
            caption.Width=picCanvas.Width;
            caption.Height=30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);
            //Lưu hình ảnh
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake score";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames= true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height=Convert.ToInt32(picCanvas.Height);
                Bitmap bmp=new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp,new Rectangle(0,0,width,height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }


        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Setting.directions = "left";
            }
            if (goRight)
            {
                Setting.directions = "right";
            }
            if (goUp)
            {
                Setting.directions = "up";
            }
            if (goDown)
            {
                Setting.directions = "down";
            }
            //kết thúc điều hướng
            for(int i= Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Setting.directions)//vị trí của duôi rắn khi di chuyển
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].X==food.X && Snake[i].Y == food.Y)//nếu vị trí của rắn trung với vị trí của thức ăn thì gọi hàm eatfood

                    {
                        EatFood();
                    }
                       
                    for(int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i-1].X;
                    Snake[i].Y = Snake[i-1].Y;
                }


                picCanvas.Invalidate();//vẽ nội dung
            }
        }
        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            Brush snakeColor; // tô màu cho rắn
            Graphics canvas = e.Graphics; //vẽ đồ họa trên C#       
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Red;
                }
                else
                {
                    snakeColor=Brushes.Green;
                }
                    canvas.FillEllipse(snakeColor, new Rectangle // đối tượng của graphics để vẽ hình eclip 
                        (
                        Snake[i].X * Setting.Width,
                        Snake[i].Y * Setting.Height,
                        Setting.Width, Setting.Height
                        ));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle // đối tượng của graphics để vẽ hình eclip 
            (
            food.X * Setting.Width,
            food.Y * Setting.Height,
            Setting.Width, Setting.Height
            ));

        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Setting.Width - 1;
            maxHeight = picCanvas.Height / Setting.Height - 1;

            Snake.Clear();

            btnStart.Enabled = false;
            btnSnap.Enabled = false;


            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head= new Circle { X=10, Y=5};//đầu của con rắn 
            Snake.Add(head);
            for(int i=0;i< 10; i++)
            {
                Circle body= new Circle(); //Phần thân của rắn
                Snake.Add(body);
            }

            food = new Circle { X=rand.Next(2,maxWidth),Y=rand.Next(2,maxHeight)};//Phần thức ăn được random trong phạm vi của pictureBox

            gameTimer.Start();  // tinh thoi gian

        }


        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);

            food = new Circle { X=rand.Next(2,maxWidth),Y=rand.Next(2,maxHeight)};//Phần thức ăn được random trong phạm vi của pictureBox


        }

        private void GameOver()
        {
            gameTimer.Stop();
            btnSnap.Enabled = true;//   được bấm vào
            btnStart.Enabled = true;//được bấm vào
            if (score > highScore)
            {
                highScore= score;
                txtHighSroce.Text = "High score: " + Environment.NewLine/*lây chuỗi kết thúc dòng */ + highScore;
                txtHighSroce.ForeColor= Color.Maroon;//màu của chữ
                txtHighSroce.TextAlign = ContentAlignment.MiddleCenter;//vị trí của chữ 
            }
            parent.setHistory("Rắn săn mồi", score);
        }


    }
}
