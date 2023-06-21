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
    public partial class frmLogin : Form
    {
        frmMain parent;
        bool isRegister = false;
        

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(frmMain parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        public frmLogin(frmMain parent, bool isRegister)
        {
            this.parent = parent;
            this.isRegister = true;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if(txtPassword.Text == "" || txtUsername.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Mật khấu dài tối thiểu 8 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isRegister)
                {
                    bool isSuccessRegister = true;
                    foreach (UserData u in parent.totalData)
                    {
                        if (txtUsername.Text == u.userName)
                        {
                            isSuccessRegister = false;
                            MessageBox.Show("Username đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }

                    if(isSuccessRegister)
                    {
                        UserData[] newTotalData = new UserData[parent.totalData.Length + 1];
                        Array.Copy(parent.totalData, newTotalData, parent.totalData.Length);
                        newTotalData[newTotalData.Length - 1] = new UserData(txtUsername.Text, txtPassword.Text);
                        parent.totalData = newTotalData;
                        parent.saveData();
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    foreach (UserData u in parent.totalData)
                    {
                        if (txtUsername.Text == u.userName && txtPassword.Text == u.passWord)
                        {
                            parent.currentData = u;
                            parent.isLogedIn = true;
                            parent.loadUI();
                            this.Close();
                            return;
                        }
                    }

                    MessageBox.Show("Username/Password không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(isRegister)
            {
                btnLogin.Text = "Đăng kí";
            }
        }

        private void ckSeePasswoed_CheckedChanged(object sender, EventArgs e)
        {
            if(ckSeePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = 'x';
            }
        }
    }
}
