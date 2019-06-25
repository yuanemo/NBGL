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
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        CRUD crud = new CRUD();

        public string UserID1 { get; private set; }
        public string UserName1 { get; private set; }
        public string UserName { get; private set; }

        private void sale_Load(object sender, EventArgs e)
        {
            #region "设置表格格式"
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grd.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行
            grd.Font = new Font("宋体", 12, FontStyle.Regular);
            grd.RowHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//设置列标题居中
            grd.AllowUserToAddRows = false;
            grd.ReadOnly = true;
            //           grd.AutoSize =true;
            //           groupBox2.AutoSize = true;
            //          groupBox2.MaximumSize= new Size(Screen.PrimaryScreen.WorkingArea.Width * 1200 / 1260, Screen.PrimaryScreen.WorkingArea.Height)
            //           this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width * 1200 / 1260, Screen.PrimaryScreen.WorkingArea.Height);
            //grd.Columns.Add("Pmax", "功率");
            //grd.Columns.Add("linkdescription", "项目ID");


            #endregion
            databind();
            s_danj.Text = MainFrom.USERID;
        }
        private void databind()
        {
            grd.DataSource = crud.czsale();
        }

        //点击单元格时，将单元格属性显示
        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;
            s_khmc.Text = grd.Rows[e.RowIndex].Cells["kehu"].Value.ToString();
            s_ghgs.Text = grd.Rows[e.RowIndex].Cells["ghgs"].Value.ToString();
            s_ddbh.Text = grd.Rows[e.RowIndex].Cells["lotid"].Value.ToString();
            s_cgry.Text = grd.Rows[e.RowIndex].Cells["cgry"].Value.ToString();
            s_xdri.Text = grd.Rows[e.RowIndex].Cells["xdrq"].Value.ToString();
            s_xqsj.Text = grd.Rows[e.RowIndex].Cells["jhrq"].Value.ToString();
            s_cplh.Text = grd.Rows[e.RowIndex].Cells["cplh"].Value.ToString();
            s_cpmc.Text = grd.Rows[e.RowIndex].Cells["cpmc"].Value.ToString();
            s_suil.Text = grd.Rows[e.RowIndex].Cells["suil"].Value.ToString();
            s_ggxh.Text = grd.Rows[e.RowIndex].Cells["ggxh"].Value.ToString();
            //增加产品族 add by lei.xue on 2017-7-30
            s_cplx.Text = grd.Rows[e.RowIndex].Cells["cplx"].Value.ToString();
            //2019.05.20
            s_cwlx.Text = grd.Rows[e.RowIndex].Cells["cwlx"].Value.ToString();
            s_danw.Text = grd.Rows[e.RowIndex].Cells["danw"].Value.ToString();

            s_heth.Text = grd.Rows[e.RowIndex].Cells["hth"].Value.ToString();
            s_shul.Text = grd.Rows[e.RowIndex].Cells["shul"].Value.ToString();
            s_danj.Text = grd.Rows[e.RowIndex].Cells["danj"].Value.ToString();
            s_zongj.Text = grd.Rows[e.RowIndex].Cells["zongj"].Value.ToString();

            s_bz.Text = grd.Rows[e.RowIndex].Cells["beiz"].Value.ToString();
            s_cpms.Text = grd.Rows[e.RowIndex].Cells["cpms"].Value.ToString();


            s_kpzt.Text = grd.Rows[e.RowIndex].Cells["kpzt"].Value.ToString();
            s_fpbh.Text = grd.Rows[e.RowIndex].Cells["kpbh"].Value.ToString();

            s_kprq.Text = grd.Rows[e.RowIndex].Cells["kprq"].Value.ToString();
            s_skzt.Text = grd.Rows[e.RowIndex].Cells["skzt"].Value.ToString();

            s_kddh.Text = grd.Rows[e.RowIndex].Cells["fpkddh"].Value.ToString();
            s_sksj.Text = grd.Rows[e.RowIndex].Cells["sksj"].Value.ToString();

            s_kdfy.Text = grd.Rows[e.RowIndex].Cells["kdfy"].Value.ToString();
            s_sjxx.Text = grd.Rows[e.RowIndex].Cells["sjxi"].Value.ToString();
        }

        private void s_khmc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            if (s_khmc.Text == "")
            {
                MessageBox.Show("客户名称不能为空");
                return;
            }
            s_ghgs.Focus();
        }

        private void addBT_Click(object sender, EventArgs e)
        {


            if (
                s_khmc.Text == "" ||
                      s_ghgs.Text == "" ||
                      //s_ddbh.Text == "" ||
                      s_cgry.Text == "" ||
                      s_xdri.Text == "" ||
                      s_xqsj.Text == "" ||
                      s_xqsj.Text == "" ||
                      s_cplx.Text == "" ||
                       s_cpmc.Text == "" ||
                       s_ggxh.Text == "" ||
                       s_suil.Text == "" ||

                       s_cplh.Text == "" ||
                       s_cwlx.Text == "" ||
                      s_danw.Text == "" ||
                      s_heth.Text == "" ||

                      s_shul.Text == "" ||
                       s_danj.Text == "" ||
                       s_zongj.Text == "" 
                )
                    {
                        MessageBox.Show("请先输入参数!");
                        return;
                    }
            string time = DateTime.Now.ToString("yyMMdd");
            DataList list = new DataList();
            DataTable dt = crud.czddbh(time);
            if (dt == null)
            {
                list.s_ddbh = time + "0001";
            }
            else
                list.s_ddbh = (Convert.ToInt32(dt.Rows[0]["lotid"].ToString())+1).ToString();

            list.s_cpmc = s_cpmc.Text;
            list.s_khmc = s_khmc.Text;
            list.s_ghgs = s_ghgs.Text;
            list.s_cgry = s_cgry.Text;
            list.s_xdri = s_xdri.Text;
            list.s_xqsj = s_xqsj.Text;
            list.s_cplx = s_cplx.Text;
            list.s_ggxh = s_ggxh.Text;


            list.s_cwlx = s_cwlx.Text;
            list.s_suil = s_suil.Text;
            list.s_cplh = s_cplh.Text;
            list.s_cwlx = s_cwlx.Text;
            list.s_danw = s_danw.Text;
            list.s_heth = s_heth.Text;

            list.s_shul = s_shul.Text;
            list.s_danj = s_danj.Text;
            list.s_zongj = s_zongj.Text;
            list.s_cpmc = s_cpmc.Text;
            list.s_cpms = s_cpms.Text;
            list.s_beiz = s_bz.Text;
            list.s_user = MainFrom.USERID;

            if (crud.Addsale(list) == "success")
            {
                MessageBox.Show("下单成功！");
                databind();
            }
        }

        private void s_ddbh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dt = crud.czSK(s_ddbh.Text);
                s_kpzt.Text = dt.Rows[0]["kpzt"].ToString();
                s_fpbh.Text = dt.Rows[0]["kpbh"].ToString();

                s_kprq.Text = dt.Rows[0]["kprq"].ToString();
                s_skzt.Text = dt.Rows[0]["skzt"].ToString();

                s_kddh.Text = dt.Rows[0]["fpkddh"].ToString();
                s_sksj.Text = dt.Rows[0]["sksj"].ToString();

                s_kdfy.Text = dt.Rows[0]["kdfy"].ToString();
                s_sjxx.Text = dt.Rows[0]["sjxi"].ToString();
            }
        }
    }
}
