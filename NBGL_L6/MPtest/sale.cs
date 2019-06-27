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
        }
        private void databind()
        {
            grd.DataSource = crud.czsale();
        }

        //点击单元格时，将单元格属性显示
        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;
            s_khmc.Text = grd.Rows[e.RowIndex].Cells["客户"].Value.ToString();
            s_ghgs.Text = grd.Rows[e.RowIndex].Cells["供货公司"].Value.ToString();
            s_ddbh.Text = grd.Rows[e.RowIndex].Cells["订单编号"].Value.ToString();
            s_cgry.Text = grd.Rows[e.RowIndex].Cells["采购人员"].Value.ToString();
            s_xdri.Text = grd.Rows[e.RowIndex].Cells["下单日期"].Value.ToString();
            s_xqsj.Text = grd.Rows[e.RowIndex].Cells["交货日期"].Value.ToString();
            s_cplh.Text = grd.Rows[e.RowIndex].Cells["产品料号"].Value.ToString();
            s_cpmc.Text = grd.Rows[e.RowIndex].Cells["产品名称"].Value.ToString();
            s_suil.Text = grd.Rows[e.RowIndex].Cells["税率"].Value.ToString();
            s_ggxh.Text = grd.Rows[e.RowIndex].Cells["规格型号"].Value.ToString();
            //增加产品族 add by lei.xue on 2017-7-30
            s_cplx.Text = grd.Rows[e.RowIndex].Cells["产品类型"].Value.ToString();
            //2019.05.20
            s_cwlx.Text = grd.Rows[e.RowIndex].Cells["财务类型"].Value.ToString();
            s_danw.Text = grd.Rows[e.RowIndex].Cells["单位"].Value.ToString();

            s_heth.Text = grd.Rows[e.RowIndex].Cells["合同号"].Value.ToString();
            s_shul.Text = grd.Rows[e.RowIndex].Cells["数量"].Value.ToString();
            s_danj.Text = grd.Rows[e.RowIndex].Cells["单价"].Value.ToString();
            s_zongj.Text = grd.Rows[e.RowIndex].Cells["总价"].Value.ToString();

            s_bz.Text = grd.Rows[e.RowIndex].Cells["备注"].Value.ToString();
            s_cpms.Text = grd.Rows[e.RowIndex].Cells["产品描述"].Value.ToString();


            s_kpzt.Text = grd.Rows[e.RowIndex].Cells["开票状态"].Value.ToString();
            s_fpbh.Text = grd.Rows[e.RowIndex].Cells["开票编号"].Value.ToString();

            s_kprq.Text = grd.Rows[e.RowIndex].Cells["开票日期"].Value.ToString();
            s_skzt.Text = grd.Rows[e.RowIndex].Cells["收款状态"].Value.ToString();

            s_kddh.Text = grd.Rows[e.RowIndex].Cells["快递单号"].Value.ToString();
            s_sksj.Text = grd.Rows[e.RowIndex].Cells["收款时间"].Value.ToString();

            s_kdfy.Text = grd.Rows[e.RowIndex].Cells["快递费用"].Value.ToString();
            s_sjxx.Text = grd.Rows[e.RowIndex].Cells["收件信息"].Value.ToString();
        }

        //客户按回车
        private void s_khmc_KeyDown(object sender, KeyEventArgs e)

        {
            TextBox cb = (TextBox)sender;
            string TT;
            if (e.KeyCode == Keys.Enter)
            {
                switch (cb.TabIndex)
                        {
                            case 0 :
                                TT = "客户名称";
                                break;
                            case 1:
                                TT = label11.Text;
                                break;
                            case 2:
                                TT = "";
                                break;
                            case 3:
                                TT = label12.Text;
                                break;
                            case 4:
                                TT = label3.Text;
                                break;
                            case 5:
                                TT = label4.Text;
                                break;
                            case 6:
                                TT = s_5.Text;
                                break;
                            case 7:
                                TT = s_6.Text;
                                break;

                            case 8:
                                TT = s_7.Text;
                                break;
                            case 9:
                                TT = s_8.Text;
                                break;
                            case 10:
                                TT = s_9.Text;
                                break;
                            case 11:
                                TT = s_10.Text;
                                break;
                            case 12:
                                TT = s_11.Text;
                                break;
                            case 13:
                                TT = s_12.Text;
                                break;
                            case 14:
                                TT = s_13.Text;
                                break;
                            case 15:
                                TT = s_14.Text;
                                break;
                            case 16:
                                TT = s_15.Text;
                                s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString())* Convert.ToDouble(s_shul.Text.ToString())).ToString();
                                break;
                            case 17:
                                TT = s_16.Text;
                                break;
                            case 18:
                                TT = s_17.Text;
                                break;
                            case 19:
                                TT = s_19.Text;
                                break;
                            default:
                                TT="0";
                                break;
                        }

                if (cb.Text.Trim() == "")
                {
                    MessageBox.Show(""+TT+"不能为空");
                    return;
                }
                SendKeys.SendWait("{tab}");
            }
        }
        //添加下单
        private void addBT_Click(object sender, EventArgs e)
        {


            if (
                s_khmc.Text.Trim() == "" ||
                      s_ghgs.Text.Trim() == "" ||
                      //s_ddbh.Text == "" ||
                      s_cgry.Text.Trim() == "" ||
                      s_xdri.Text.Trim() == "" ||
                      s_xqsj.Text.Trim() == "" ||
                      s_xqsj.Text.Trim() == "" ||
                      s_cplx.Text.Trim() == "" ||
                       s_cpmc.Text.Trim() == "" ||
                       s_ggxh.Text.Trim() == "" ||
                       s_suil.Text.Trim() == "" ||

                       s_cplh.Text.Trim() == "" ||
                       s_cwlx.Text.Trim() == "" ||
                      s_danw.Text.Trim() == "" ||
                      s_heth.Text.Trim() == "" ||

                      s_shul.Text.Trim() == "" ||
                       s_danj.Text.Trim() == "" ||
                       s_zongj.Text.Trim() == "" 
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
                MessageBox.Show("订单"+list.s_ddbh +"下单成功！");
                databind();
            }
        }
        //订单编号回车
        private void s_ddbh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dt = crud.czSK(s_ddbh.Text);

                s_khmc.Text = dt.Rows[0]["kehu"].ToString();
                s_ghgs.Text = dt.Rows[0]["ghgs"].ToString();
                s_ddbh.Text = dt.Rows[0]["lotid"].ToString();
                s_cgry.Text = dt.Rows[0]["cgry"].ToString();
                s_xdri.Text = dt.Rows[0]["xdrq"].ToString();
                s_xqsj.Text = dt.Rows[0]["jhrq"].ToString();
                s_cplh.Text = dt.Rows[0]["cplh"].ToString();
                s_cpmc.Text = dt.Rows[0]["cpmc"].ToString();
                s_suil.Text = dt.Rows[0]["suil"].ToString();
                s_ggxh.Text = dt.Rows[0]["ggxh"].ToString();
                s_cplx.Text = dt.Rows[0]["cplx"].ToString();
                //2019.05.20
                s_cwlx.Text = dt.Rows[0]["cwlx"].ToString();
                s_danw.Text = dt.Rows[0]["danw"].ToString();

                s_heth.Text = dt.Rows[0]["hth"].ToString();
                s_shul.Text = dt.Rows[0]["shul"].ToString();
                s_danj.Text = dt.Rows[0]["danj"].ToString();
                s_zongj.Text = dt.Rows[0]["zongj"].ToString();

                s_bz.Text = dt.Rows[0]["beiz"].ToString();
                s_cpms.Text = dt.Rows[0]["cpms"].ToString();


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
        //修改收款
        private void x_add_Click(object sender, EventArgs e)
        {
            if (s_ddbh.Text == "")
            {
                MessageBox.Show("请填写订单编号");
                s_ddbh.Focus();
            }
            DataList list = new DataList();
            list.s_ddbh = s_ddbh.Text;
            list.s_kpzt = s_kpzt.Text;
            list.s_fpbh = s_fpbh.Text;
            list.s_kprq = s_kprq.Text;
            list.s_skzt = s_skzt.Text;
            list.s_kddh = s_kddh.Text;
            list.s_sksj = s_sksj.Text;
            list.s_kdfy = s_kdfy.Text;
            list.s_sjxx = s_sjxx.Text;
            list.s_user = MainFrom.USERID;
            if (crud.addkp(list) == "success")
            {
                MessageBox.Show("订单" + list.s_ddbh + ",收款修改成功！");


                DataTable dt = crud.czSK(s_ddbh.Text);
                s_kpzt.Text = dt.Rows[0]["kpzt"].ToString();
                s_fpbh.Text = dt.Rows[0]["kpbh"].ToString();

                s_kprq.Text = dt.Rows[0]["kprq"].ToString();
                s_skzt.Text = dt.Rows[0]["skzt"].ToString();

                s_kddh.Text = dt.Rows[0]["fpkddh"].ToString();
                s_sksj.Text = dt.Rows[0]["sksj"].ToString();

                s_kdfy.Text = dt.Rows[0]["kdfy"].ToString();
                s_sjxx.Text = dt.Rows[0]["sjxi"].ToString();


                databind();
            }

        }
        //修改下单
        private void alter_Click(object sender, EventArgs e)
        {
            if (s_ddbh.Text == "")
            {
                MessageBox.Show("请填写订单编号");
                s_ddbh.Focus();
            }

            DataList list = new DataList();
            list.s_ddbh = s_ddbh.Text;
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
            if (crud.xgxd(list) == "success")
            {
                MessageBox.Show("订单" + list.s_ddbh + ",修改下单成功！");
                databind();
            }
        }
        //供货公司按回车
        private void s_ghgs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (s_ghgs.Text == "")
                {
                    MessageBox.Show("供货公司不能为空");
                    return;
                }
                s_cgry.Focus();
            }
        }
        //采购
        private void s_cgry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (s_cgry.Text == "")
                {
                    MessageBox.Show("采购人员不能为空");
                    return;
                }
                s_ghgs.Focus();
            }
        }

        private void qkwbk_Click(object sender, EventArgs e)
        {
              s_khmc.Text= "";
              s_ghgs.Text= "";
              //s_ddbh.Text == "" ;
              s_cgry.Text= "";
              s_xdri.Text= "";
              s_xqsj.Text= "";
              s_xqsj.Text= "";
              s_cplx.Text= "";
              s_cpmc.Text= "";
              s_ggxh.Text= "";
              s_suil.Text= "";

              s_cplh.Text= "";
              s_cwlx.Text= "";
              s_danw.Text= "";
              s_heth.Text= "";

              s_shul.Text= "0";
              s_danj.Text= "0";
              s_zongj.Text= "";
            s_bz.Text = "";
            s_cpms.Text = "";
        }

        private void s_danj_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(s_danj.Text.ToString(), out double s) == false)
            {
                if (s_danj.Text != "")
                {
                    MessageBox.Show("单价格式不正确");
                    s_danj.Text = "0";
                    return;
                }
                else
                {
                    return;
                }                 
                s_danj.Text = "0";
            }
            s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString()) * Convert.ToDouble(s_shul.Text.ToString())).ToString();
        }

        private void s_shul_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(s_shul.Text.ToString(), out double s)==false)
                {
                if (s_shul.Text != "")
                {
                    MessageBox.Show("数量格式不正确");
                    s_shul.Text = "0";
                    return;
                }
                else
                {
                    return;
                }                   
                s_danj.Text = "0";
            }
            if(s_danj.Text != "")
            s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString()) * Convert.ToDouble(s_shul.Text.ToString())).ToString();
        }

    }
}
