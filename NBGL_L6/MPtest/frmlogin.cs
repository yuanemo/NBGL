using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPtest
{


    public partial class frmlogin : Form
    {

        public delegate void AfterLogin(string UserID, string UserName);
        public event AfterLogin cusEvtLogin;


        private string _UserID = string.Empty;
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }


        public frmlogin()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();

        public string  username = "";


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || pwdPassword.Text == "")
            {
                return;
            }


            string[] arrParameter = new string[2];

            arrParameter[0] = txtUserName.Text.ToLower().ToString();
            arrParameter[1] = pwdPassword.Text.ToString();

            DataTable dt = crud.ZHMMYZ(arrParameter[0]);
            if (dt == null)
            {
                MessageBox.Show("此账户不存在");
            }
            else if (DES.string_Decrypt(dt.Rows[0]["PassWord"].ToString()) != arrParameter[1])
            {
                MessageBox.Show("密码不正确");
            }
            else if (DES.string_Decrypt(dt.Rows[0]["PassWord"].ToString()) == arrParameter[1] && dt.Rows[0]["State"].ToString() != "Y")
            {
                MessageBox.Show("账户已禁用");
            }
            else
            {
                UserID = dt.Rows[0]["UserID"].ToString();
                string UserName = dt.Rows[0]["NickName"].ToString();
              
                cusEvtLogin(UserID, UserName);

                dt = null;
                Close();
            }

        }



        void pwdPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtUserName.Text.Equals(""))
            {
                BtnLogin_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Enter && txtUserName.Text.Equals(""))
            {
                txtUserName.Focus();
            }

        }

        void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pwdPassword.Focus();
                pwdPassword.SelectAll();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            pwdPassword.Text = "";

            txtUserName.Focus();
            txtUserName.Select();
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //label1.Top = this.Height  - 80;
            //label2.Top = this.Height - 55;
            //txtUserName.Top = this.Height - 85;
            //btnLogin.Top = this.Height - 85;
            //pwdPassword.Top = this.Height - 55;
            //btnReset.Top = this.Height - 55;
            //panel1.Top = (this.Height - panel1.Height) / 3;
            //panel1.Left = (this.Width - panel1.Width) / 2;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
