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
    public partial class wlbm : Form
    {
        public wlbm()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();

        private void wlbm_Load(object sender, EventArgs e)
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
        }

        private void databind()
        {
            grd.DataSource = crud.CZwlbm();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            txtlhid.Text = grd.Rows[e.RowIndex].Cells["料号ID"].Value.ToString();
            txtkh.Text = grd.Rows[e.RowIndex].Cells["客户"].Value.ToString();
            txtlhlx.Text = grd.Rows[e.RowIndex].Cells["料号类型"].Value.ToString();
            txtlhdm.Text = grd.Rows[e.RowIndex].Cells["料号代码"].Value.ToString();
            txtcpmc.Text = grd.Rows[e.RowIndex].Cells["产品名称"].Value.ToString();
            txtgg.Text = grd.Rows[e.RowIndex].Cells["规格"].Value.ToString();
            txtcwlx.Text = grd.Rows[e.RowIndex].Cells["财务类型"].Value.ToString();
            txtms.Text = grd.Rows[e.RowIndex].Cells["描述"].Value.ToString();
            txtytms.Text = grd.Rows[e.RowIndex].Cells["用途描述"].Value.ToString();
            txtpx.Text = grd.Rows[e.RowIndex].Cells["排序"].Value.ToString();
            if (grd.Rows[e.RowIndex].Cells["是否启用"].Value.ToString() == "Y")
            {
                checkBox1.Checked = true;
            }
            else
                checkBox1.Checked = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataList list = new DataList();
            DataTable dt = crud.CZwlbmlhmax();
            int a3 = Convert.ToInt32(dt.Rows[0]["lhid"].ToString().Substring(2,10))+1;
            list.lhid ="HL"+a3.ToString().PadLeft(10, '0');
            if (txtcpmc.Text == ""||
                txtcwlx.Text == ""||
                txtgg.Text==""||
                txtkh.Text==""||
                txtlhdm.Text == "" ||
                //txtlhid.Text==""||
                txtlhlx.Text==""||
                txtms.Text==""||
                txtpx.Text==""||
                txtytms.Text==""
                )
            {
                MessageBox.Show("请先输入参数!");
                return;
            }
            list.cpmc = txtcpmc.Text;
            list.cwlx = txtcwlx.Text;
            list.guig = txtgg.Text;
            list.keh = txtkh.Text;
            //list.lhid = txtlhid.Text;
            list.lhdm = txtlhdm.Text;
            list.lhlx = txtlhlx.Text;
            list.miaos = txtms.Text;
            list.paix = txtpx.Text;
            list.ytms = txtytms.Text;

            if (checkBox1.Checked)
            {
                list.flag = "Y";
            }
            else
                list.flag = "N";


            if (crud.Addwlbm(list) == "success")
            {
                MessageBox.Show(list.lhid+"添加成功！");
                databind();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtlhid.Text == "")
            {
                MessageBox.Show("请填写料号ID");
                txtlhid.Focus();
            }
            DataList list = new DataList();
            list.lhid = txtlhid.Text;
            list.keh = txtkh.Text;
            list.lhlx = txtlhlx.Text;
            list.lhdm = txtlhdm.Text;
            list.cpmc = txtcpmc.Text;
            list.guig = txtgg.Text;
            list.cwlx = txtcwlx.Text;
            list.miaos = txtms.Text;
            list.ytms = txtytms.Text;
            list.paix = txtpx.Text;
            if (checkBox1.Checked)
            {
                list.flag = "Y";
            }
            else
                list.flag = "N";
            if (crud.xgwlbm(list) == "success")
            {
                MessageBox.Show(txtlhid.Text+"修改成功！");
                databind();
            }

        }
    }
}
