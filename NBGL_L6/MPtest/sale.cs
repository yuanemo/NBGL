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

            xlkxs();
            databind();
        }
        //x下拉框显示
        private void xlkxs()
        {
            //下拉框清空
            s_khmc.Items.Clear();
            s_ghgs.Items.Clear();
            s_danw.Items.Clear();
            s_cgry.Items.Clear();
            s_cplx.Items.Clear();

            s_suil.Items.Clear();
            s_ggxh.Items.Clear();
            s_cpmc.Items.Clear();
            s_cwlx.Items.Clear();

            s_kpzt.Items.Clear();
            s_skzt.Items.Clear();
            //s_cplx.Items.Clear();
            string xlk;
            DataTable dt = crud.qbxlk();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                xlk = dt.Rows[i]["family_remark"].ToString();
                switch (xlk)
                {
                    case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "生产公司": s_ghgs.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "单位": s_danw.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "采购人员": s_cgry.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "产品类型": s_cplx.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "税率": s_suil.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "产品名称": s_cpmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "规格型号": s_ggxh.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "财务类型": s_cwlx.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "开票状态": s_kpzt.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "收款状态": s_skzt.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;

                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                }
            }
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

        //
        //控件按回车
        private void s_khmc_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox cb = (TextBox)sender;
                string TT;
                if (e.KeyCode == Keys.Enter)
                {
                    switch (cb.TabIndex)
                    {
                        case 0:
                            TT = label1.Text;
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
                            s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString()) * Convert.ToDouble(s_shul.Text.ToString())).ToString();
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

                        case 31:
                            TT = sk_01.Text;
                            break;
                        case 32:
                            TT = sk_02.Text;
                            break;
                        case 33:
                            TT = sk_03.Text;
                            break;
                        case 34:
                            TT = sk_04.Text;
                            break;
                        case 35:
                            TT = sk_05.Text;
                            break;
                        case 36:
                            TT = sk_06.Text;
                            break;
                        case 37:
                            TT = sk_07.Text;
                            break;
                        case 38:
                            TT = sk_08.Text;
                            break;

                        default:
                            TT = "0";
                            break;
                    }

                    if (cb.Text.Trim() == "")
                    {
                        MessageBox.Show("" + TT + "不能为空");
                        return;
                    }

                    SendKeys.SendWait("{tab}");
                }
            }
            else if (sender is DateTimePicker)
            {
                DateTimePicker cb = (DateTimePicker)sender;
                string TT;
                if (e.KeyCode == Keys.Enter)
                {
                    switch (cb.TabIndex)
                    {
                        case 0:
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
                            s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString()) * Convert.ToDouble(s_shul.Text.ToString())).ToString();
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

                        case 31:
                            TT = sk_01.Text;
                            break;
                        case 32:
                            TT = sk_02.Text;
                            break;
                        case 33:
                            TT = sk_03.Text;
                            break;
                        case 34:
                            TT = sk_04.Text;
                            break;
                        case 35:
                            TT = sk_05.Text;
                            break;
                        case 36:
                            TT = sk_06.Text;
                            break;
                        case 37:
                            TT = sk_07.Text;
                            break;
                        case 38:
                            TT = sk_08.Text;
                            break;

                        default:
                            TT = "0";
                            break;
                    }

                    if (cb.Text.Trim() == "")
                    {
                        MessageBox.Show("" + TT + "不能为空");
                        return;
                    }
                    
                    TimeSpan ts1 = new TimeSpan(s_xqsj.Value.Ticks);
                    TimeSpan ts2 = new TimeSpan(s_xdri.Value.Ticks);
                    if (ts1.TotalDays <= ts2.TotalDays)
                    {
                        MessageBox.Show("收款时间不可以比"+"下单时间早");
                        return;
                    }
                    SendKeys.SendWait("{tab}");
                }
            }
            else if (sender is ComboBox)
            {
                ComboBox cb = (ComboBox)sender;
                string TT;
                if (e.KeyCode == Keys.Enter)
                {
                    switch (cb.TabIndex)
                    {
                        case 0:
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
                            {
                                TT = s_9.Text;
                                DataTable bt = crud.czcwlx(s_cplh.Text);
                                s_cwlx.Text = bt.Rows[0]["cwlx"].ToString();
                            }
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
                            s_zongj.Text = (Convert.ToDouble(s_danj.Text.ToString()) * Convert.ToDouble(s_shul.Text.ToString())).ToString();
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

                        case 31:
                            TT = sk_01.Text;
                            break;
                        case 32:
                            TT = sk_02.Text;
                            break;
                        case 33:
                            TT = sk_03.Text;
                            break;
                        case 34:
                            TT = sk_04.Text;
                            break;
                        case 35:
                            TT = sk_05.Text;
                            break;
                        case 36:
                            TT = sk_06.Text;
                            break;
                        case 37:
                            TT = sk_07.Text;
                            break;
                        case 38:
                            TT = sk_08.Text;
                            break;

                        default:
                            TT = "0";
                            break;
                    }

                    if (cb.Text.Trim() == "")
                    {
                        MessageBox.Show("" + TT + "不能为空");
                        return;
                    }
                    DataTable dt = crud.qbxlk();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        switch (TT)
                        {
                            case "客户名称":
                                if (dt.Rows[i]["family_remark"].ToString() == "客户" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_khmc.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_khmc.Text, "客户") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "供货公司":
                                if (dt.Rows[i]["family_remark"].ToString() == "生产公司" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_ghgs.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_ghgs.Text, "生产公司") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "采购人员":
                                if (dt.Rows[i]["family_remark"].ToString() == "采购人员" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_cgry.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_cgry.Text, "采购人员") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "单位":
                                if (dt.Rows[i]["family_remark"].ToString() == "单位" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_danw.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_danw.Text, "单位") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "产品类型":
                                if (dt.Rows[i]["family_remark"].ToString() == "产品类型" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_cplx.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_cplx.Text, "产品类型") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "税率":
                                if (dt.Rows[i]["family_remark"].ToString() == "税率" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_suil.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_suil.Text, "税率") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "产品名称":
                                if (dt.Rows[i]["family_remark"].ToString() == "产品名称" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_cpmc.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_cpmc.Text, "产品名称") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "规格型号":
                                if (dt.Rows[i]["family_remark"].ToString() == "规格型号" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_ggxh.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_ggxh.Text, "规格型号") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "财务类型":
                                if (dt.Rows[i]["family_remark"].ToString() == "财务类型" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_cwlx.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_cwlx.Text, "财务类型") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;


                            case "收款状态":
                                if (dt.Rows[i]["family_remark"].ToString() == "收款状态" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_skzt.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_skzt.Text, "收款状态") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "开票状态":
                                if (dt.Rows[i]["family_remark"].ToString() == "开票状态" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == s_kpzt.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(s_kpzt.Text, "开票状态") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                        }

                    }
                    SendKeys.SendWait("{tab}");
                }
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

            TimeSpan ts1 = new TimeSpan(s_xqsj.Value.Ticks);
            TimeSpan ts2 = new TimeSpan(s_xdri.Value.Ticks);
            if (ts1.TotalDays <= ts2.TotalDays)
            {
                MessageBox.Show("收款时间不可以比" + "下单时间早");
                return;
            }

            string time = DateTime.Now.ToString("yyMMdd");
            DataList list = new DataList();
            DataTable dt = crud.czddbh(time);
            if (dt == null)
            {
                list.s_ddbh = time + "0051";
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

                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    if (grd.Rows[i].Cells["订单编号"].Value.ToString() == list.s_ddbh)
                    {
                        grd.Rows[i].Selected = true;
                        //第一行显示为*****的
                        grd.FirstDisplayedScrollingRowIndex = i;
                    }
                }
            }
        }
        //订单编号回车
        private void s_ddbh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable dt = crud.czSK(s_ddbh.Text);
                if(dt!=null)
                { 
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

                //将光标显示在当前行
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    if (grd.Rows[i].Cells["订单编号"].Value.ToString() == list.s_ddbh)
                    {
                        grd.Rows[i].Selected = true;
                        grd.FirstDisplayedScrollingRowIndex=i;
                    }
                }

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
                //将光标显示在当前行
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    if (grd.Rows[i].Cells["订单编号"].Value.ToString() == list.s_ddbh)
                    {
                        grd.Rows[i].Selected = true;
                        grd.FirstDisplayedScrollingRowIndex = i;
                    }
                }

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
        //清空
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

        //单价数字改变
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
        //数量数字改变
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

        private void sale_Shown(object sender, EventArgs e)
        {

        }
        //产品料号下拉框
        private void s_cplh_Enter(object sender, EventArgs e)
        {
            DataList list = new DataList();
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
            s_cplh.Items.Clear();
            DataTable dt = crud.czlhid(list);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    s_cplh.Items.Add(dt.Rows[i]["lhid"]);
                }
            }
            else
            {
                MessageBox.Show("无对应物料编号,请添加");
                return;
            }
        }
    }
}
