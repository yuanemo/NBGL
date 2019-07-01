using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MPtest;
using System.Reflection;

namespace MPtest
{
    public partial class MainFrom : Form
    {
        //public delegate void AfterLogin(string M_UserID, string M_UserName);
        //public event AfterLogin cusM;


        //private string _UserID = string.Empty;
        //public string M_UserID
        //{
        //    get { return _UserID; }
        //    set { _UserID = value; }
        //}

        public static string USERID;

        public string UserID1;
        public string UserName1;
        public MainFrom()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width * 1200 / 1260, Screen.PrimaryScreen.WorkingArea.Height);
            base.StartPosition = FormStartPosition.CenterScreen;
            base.ResumeLayout(false);
        }

        private void MainFrom_Show(object sender, EventArgs e)
        {

            //            login.cusEvtLogin += new frmLogin.AfterLogin(login_cusEvtLogin);
            // login.ShowDialog();
            // LimitDate = login.LimitDate;
            //GroupName = login.GroupName;
            //VersionMsg.Text = Properties.Settings.Default.Version;
            frmlogin login = new frmlogin();
            login.cusEvtLogin += new frmlogin.AfterLogin(login_cusEvtLogin);
            login.Activate();
            login.ShowDialog();
            login.WindowState = FormWindowState.Maximized;

            //cusM(UserID1, UserName1);
            USERID = UserID1;

            CRUD crud = new CRUD();
            DataTable dt = crud.CXCD(UserID1);
            // 创建MenuStrip对象
            MenuStrip MS = new MenuStrip();

            //创建一个ToolStripMenuItem菜单，可以文本和图片一并添加
            //ToolStripMenuItem tsmi = new ToolStripMenuItem("测试按钮");
            //绑定菜单的点击事件
            //tsmi.Click += DemoClick;
            //创建子菜单 可以文本和图片一并添加

            //绑定子菜单点击事件
            //tsmi2.Click += DemoClick;
            //添加子菜单
            // tsmi.DropDownItems.Add(tsmi2);
            //添加主菜单

            //界面显示

            for (int i = 0;i < dt.Rows.Count; i++)
            {
                string ID = dt.Rows[i]["ID"].ToString();
                string FunctionName = dt.Rows[i]["FunctionName"].ToString();
                string MenuName = dt.Rows[i]["MenuName"].ToString();
                string ParentID = dt.Rows[i]["ParentID"].ToString();
                string IsNeedClick = dt.Rows[i]["IsNeedClick"].ToString();
                string AssemblyName = dt.Rows[i]["Assembly"].ToString();
                if (ParentID == "0" )
                {
                    ToolStripMenuItem tsmi = new ToolStripMenuItem(MenuName);
                   
                    if (IsNeedClick == "Y" || IsNeedClick == "y")
                    {
                        tsmi.Tag = dt.Rows[i]["FunctionName"].ToString();
                        tsmi.Click += Tsmi_Click;
                    }

                    MS.Items.Add(tsmi);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                       if (dt.Rows[j]["ParentID"].ToString() == dt.Rows[i]["ID"].ToString())
                        {
                            ToolStripMenuItem tsmi2 = new ToolStripMenuItem(dt.Rows[j]["MenuName"].ToString());

                            if (dt.Rows[j]["IsNeedClick"].ToString() == "Y" || dt.Rows[j]["IsNeedClick"].ToString() == "y")
                            {
                                tsmi2.Tag = dt.Rows[j]["FunctionName"].ToString();
                                tsmi2.Click += Tsmi2_Click;
                            }

                            tsmi.DropDownItems.Add(tsmi2);
                            for (int z = 0; z < dt.Rows.Count; z++)
                            {
                                if (dt.Rows[z]["ParentID"].ToString() == dt.Rows[j]["ID"].ToString())
                                {
                                    ToolStripMenuItem tsmi3 = new ToolStripMenuItem(dt.Rows[z]["MenuName"].ToString());

                                    if (dt.Rows[z]["IsNeedClick"].ToString() == "Y" || dt.Rows[z]["IsNeedClick"].ToString() == "y")
                                    {
                                        tsmi3.Tag = dt.Rows[z]["FunctionName"].ToString();
                                        tsmi3.Click += Tsmi3_Click;
                                    }

                                    tsmi2.DropDownItems.Add(tsmi3);
                                }

                            }
                            
                        }

                    }
                    
                }

                this.Controls.Add(MS);

            }


            void login_cusEvtLogin(string UserID, string UserName)
            {
                UserID1 = UserID;
                UserName = UserName1;
            }
        }

        private void Tsmi3_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            DataTable dt = crud.CZFunctionName(sender.ToString());
            string functionName = dt.Rows[0]["FunctionName"].ToString();
            CreateFormInstance(functionName);
        }

        /*********************************************
         * 调用
         * 
         * ******************************************/
        private void CreateFormInstance(string functionName)
        {

            Assembly asm = Assembly.Load("MPtest");//程序集名

            object frmObj = asm.CreateInstance("MPtest." + functionName);//程序集+form的类名。
            Form frms = (Form)frmObj;
            //    frms.Tag = functionName.ToString();
            frms.MdiParent = this;
            frms.Activate();
            frms.WindowState = FormWindowState.Maximized;
            frms.Show();
        }

        private void Tsmi2_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            DataTable dt = crud.CZFunctionName(sender.ToString());
            string functionName = dt.Rows[0]["FunctionName"].ToString();
            CreateFormInstance(functionName);
        }

        private void Tsmi_Click(object sender, EventArgs e)
        {
            
            CRUD crud = new CRUD();
            DataTable dt = crud.CZFunctionName(sender.ToString());
            string functionName = dt.Rows[0]["FunctionName"].ToString();
            CreateFormInstance(functionName);
            //try
            //{
            //    //tag属性在这里有用到。
            //    string acName = ((ToolStripMenuItem)sender).Tag.ToString();
            //    if (acName != "")
            //    {
            //        string[] strArray = acName.Split(new char[] { ',' });
            //        if (strArray.Length > 2)
            //        {
            //        }
            //        else
            //        {
            //            String str = "void " + acName;
            //            foreach (MethodInfo info in base.GetType().GetMethods())
            //            {
            //                if (str.Trim().ToLower().CompareTo(info.ToString().Trim().ToLower()) == 0)
            //                {
            //                    info.Invoke(this, null);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception exception)
            //{
            //}
        }
    }
}
