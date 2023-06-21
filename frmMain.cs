using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace BaiTapLon_GameBox
{
    public partial class frmMain : Form
    {
        private string username;
        public bool isLogedIn=false;
        frmLogin login;
        string dataPath = Application.StartupPath + @"/data.json";
        public UserData[] totalData;
        public UserData currentData;
        public frmMain()
        {
            InitializeComponent();
        }

        public string UserName
        {
            set { username = value; }
            get { return username; }
        }

        void loadData()
        {
            var totalDataJson = File.ReadAllText(dataPath);
            if(totalDataJson!="")
            {
                totalData = JsonConvert.DeserializeObject<UserData[]>(totalDataJson);
            }
            else
            {
            }
        }

        public void loadUI()
        {
            changeHeader();

            if(isLogedIn == true)
            {
                for(int i=0; i<currentData.history.GetLength(0); i++)
                {
                    ListViewItem item = new ListViewItem(currentData.history[i][ 0]);
                    item.SubItems.Add(currentData.history[i][ 1]);
                    item.SubItems.Add(currentData.history[i][ 2]);
                    lvHistory.Items.Add(item);
                }

            }
            else
            {
                lvHistory.Items.Clear();
            }
        }

        public void saveData()
        {
            string jsonResult = JsonConvert.SerializeObject(totalData);
            File.WriteAllText(dataPath, jsonResult);
        }

        public void setHistory(string name, int score)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"));
            item.SubItems.Add(name);
            item.SubItems.Add(score.ToString());
            lvHistory.Items.Add(item);

            int newIndex = currentData.history.GetLength(0);
            string[][] newArray = new string[currentData.history.Length+1][];
            Array.Copy(currentData.history, newArray, currentData.history.Length);
            newArray[newIndex] = new string[] { DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"), name, score.ToString() };
            currentData.history = newArray;
            saveData();

        }

        public void changeHeader()
        {
            if(isLogedIn == true)
            {
                btnLogout.Show();
                lblUserName.Show();
                btnLogin.Hide();
                btnRegister.Hide();
                lblUserName.Text = currentData.userName;
                lblGreeting.Text = "Xin chào " + currentData.userName + "!";
            }
            else
            {
                btnLogout.Hide();
                lblUserName.Hide();
                btnLogin.Show();
                btnRegister.Show();
                lblGreeting.Text = "Welcome to GameBOX";

            }
        }
            

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        

        private void openGames(object sender, EventArgs e)
        {
            if (isLogedIn)
            {
                PictureBox pic = (PictureBox)sender;
                switch (pic.Name) {
                    case"picSnake":
                        frmSnakeGame snakeGame = new frmSnakeGame(this);
                        snakeGame.Show();
                        break;
                    case "picFlappyBird":
                        frmFlappyBird flappyBird = new frmFlappyBird(this);
                        flappyBird.Show();
                        break;
                    case "picGameAnXu":
                        frmGameAnXu gameAnXu = new frmGameAnXu(this);
                        gameAnXu.Show();
                        break;
                    case "picGameDuaXe":
                        frmDuaXe gameDuaXe = new frmDuaXe(this);
                        gameDuaXe.Show();
                        break;
                    default:
                        return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Đăng nhập trước khi chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    login = new frmLogin(this);
                    login.Show();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Hide();
            loadData();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = new frmLogin(this);
            login.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            login = new frmLogin(this, true);
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLogedIn = false;
            loadUI();
        }

        private void tabGames_Click(object sender, EventArgs e)
        {

        }
    }
}
