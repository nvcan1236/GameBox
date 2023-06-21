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
    public partial class frmResult : Form
    {
        frmFlappyBird parent;

        public frmResult()
        {
            InitializeComponent();
        }

        public frmResult(frmFlappyBird parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            lblScore.Text = parent.Score.ToString();

        }

        private void picPlay2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.playGame();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            parent.Close();
            this.Close();
        }
    }
}
