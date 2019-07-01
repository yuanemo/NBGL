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
            xlkxs();
            databind();
        }


        /// <summary>
        /// 下拉框显示
        /// </summary>
        private void xlkxs()
        {
            //下拉框清空
            txtkh.Items.Clear();
            txtlhlx.Items.Clear();
            txtlhdm.Items.Clear();
            txtcpmc.Items.Clear();
            txtgg.Items.Clear();

            txtcwlx.Items.Clear();
            //s_ggxh.Items.Clear();
            //s_cpmc.Items.Clear();
            //s_cwlx.Items.Clear();
            //s_cplx.Items.Clear();
            string xlk;
            DataTable dt = crud.qbxlk();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                xlk = dt.Rows[i]["family_remark"].ToString();
                switch (xlk)
                {
                    case "客户": txtkh.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "料号类型": txtlhlx.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "料号代码": txtlhdm.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "产品名称": txtcpmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                   
                    case "规格型号": txtgg.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    case "财务类型": txtcwlx.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    //case "规格型号": s_ggxh.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                    //case "财务类型": s_cwlx.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;

                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;

                        //case "客户": s_khmc.Items.Add(dt.Rows[i]["PRIDISPLAYNAME"]); break;
                }
            }
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
            int a3 = Convert.ToInt32(dt.Rows[0]["lhid"].ToString().Substring(2, 10)) + 1;
            list.lhid = "HL" + a3.ToString().PadLeft(10, '0');
            if (txtcpmc.Text == "" ||
                txtcwlx.Text == "" ||
                txtgg.Text == "" ||
                txtkh.Text == "" ||
                txtlhdm.Text == "" ||
                //txtlhid.Text==""||
                txtlhlx.Text == "" ||
                txtms.Text == "" ||
                txtpx.Text == "" ||
                txtytms.Text == ""
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
                MessageBox.Show(list.lhid + "添加成功！");
                databind();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtlhid.Text == "")
            {
                MessageBox.Show("请填写料号ID");
                txtlhid.Focus();
                return;
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
                MessageBox.Show(txtlhid.Text + "修改成功！");
                databind();
            }

        }

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
                            TT = "料号ID";
                            break;
                        case 1:
                            TT = label2.Text;
                            break;
                        case 2:
                            TT = label3.Text;
                            break;
                        case 3:
                            TT = label4.Text;
                            break;
                        case 4:
                            TT = label5.Text;
                            break;
                        case 5:
                            TT = label6.Text;
                            break;
                        case 6:
                            TT = label7.Text;
                            break;
                        case 7:
                            TT = label8.Text;
                            break;

                        case 8:
                            TT = label9.Text;
                            break;
                        case 9:
                            TT = label10.Text;
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
            else if (sender is ComboBox)
            {
                ComboBox cb = (ComboBox)sender;
                string TT;
                if (e.KeyCode == Keys.Enter)
                {
                    switch (cb.TabIndex)
                    {
                        case 0:
                            TT = "料号ID";
                            break;
                        case 1:
                            TT = label2.Text;
                            break;
                        case 2:
                            TT = label3.Text;
                            break;
                        case 3:
                            TT = label4.Text;
                            break;
                        case 4:
                            TT = label5.Text;
                            break;
                        case 5:
                            TT = label6.Text;
                            break;
                        case 6:
                            TT = label7.Text;
                            break;
                        case 7:
                            TT = label8.Text;
                            break;

                        case 8:
                            TT = label9.Text;
                            break;
                        case 9:
                            TT = label10.Text;
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
                            case "客户":
                                if (dt.Rows[i]["family_remark"].ToString() == "客户" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtkh.Text)
                                {

                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtkh.Text, "客户") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;

                            case "料号类型":
                                if (dt.Rows[i]["family_remark"].ToString() == "料号类型" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtlhlx.Text)
                                {

                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtlhlx.Text, "料号类型") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;

                            case "料号代码":
                                if (dt.Rows[i]["family_remark"].ToString() == "料号代码" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtlhdm.Text)
                                {

                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtlhdm.Text, "料号代码") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;

                            case "产品名称":
                                if (dt.Rows[i]["family_remark"].ToString() == "产品名称" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtcpmc.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtcpmc.Text, "产品名称") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "规格":
                                if (dt.Rows[i]["family_remark"].ToString() == "规格型号" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtgg.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtgg.Text, "规格型号") == "success")
                                    {
                                        MessageBox.Show(TT + "添加成功！");
                                        xlkxs();
                                        databind();
                                    }
                                }
                                break;
                            case "财务类型":
                                if (dt.Rows[i]["family_remark"].ToString() == "财务类型" && dt.Rows[i]["PRIDISPLAYNAME"].ToString() == txtcwlx.Text)
                                {
                                    SendKeys.SendWait("{tab}");
                                    return;
                                }
                                else if (i == dt.Rows.Count - 1)
                                {
                                    if (crud.Addxlk(txtcwlx.Text, "财务类型") == "success")
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
    }
}
