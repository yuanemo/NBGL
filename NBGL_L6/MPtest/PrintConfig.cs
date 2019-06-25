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
    public partial class PrintConfig : Form
    {
        public PrintConfig()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();
        private class template
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        private void PrintConfig_Load(object sender, EventArgs e)
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
            DataTable dt = crud.QueryareaN();
            cjxz.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cjxz.Items.Add(dt.Rows[i][0]);
            }
            cjxz.SelectedText = "";



        }

        //获取表格值
        private void databind()
        {
            grd.DataSource = crud.QueryConfig();
        }

        //点击单元格时，将单元格属性显示
        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex < 0) return;
                if (e.ColumnIndex < 0) return;
                txtPmax.Text = grd.Rows[e.RowIndex].Cells["Pmax"].Value.ToString();
                txtVmp.Text = grd.Rows[e.RowIndex].Cells["Vmp"].Value.ToString();
                txtImp.Text = grd.Rows[e.RowIndex].Cells["Imp"].Value.ToString();
                txtVoc.Text = grd.Rows[e.RowIndex].Cells["Voc"].Value.ToString();
                txtIsc.Text = grd.Rows[e.RowIndex].Cells["Isc"].Value.ToString();
                txtVolmax.Text = grd.Rows[e.RowIndex].Cells["Volmax"].Value.ToString();
                txtFusemax.Text = grd.Rows[e.RowIndex].Cells["Fusemax"].Value.ToString();
                txtModuleApp.Text = grd.Rows[e.RowIndex].Cells["ModuleApp"].Value.ToString();
                txtUpperPower.Text = grd.Rows[e.RowIndex].Cells["UpperPower"].Value.ToString();
                txtLowerPower.Text = grd.Rows[e.RowIndex].Cells["LowerPower"].Value.ToString();
                //增加产品族 add by lei.xue on 2017-7-30
                txtProductType.Text = grd.Rows[e.RowIndex].Cells["ProductType"].Value.ToString();
                //2019.05.20
                txtUpperE.Text = grd.Rows[e.RowIndex].Cells["UpperImp"].Value.ToString();
                txtLowerE.Text = grd.Rows[e.RowIndex].Cells["LowerImp"].Value.ToString();

            //车间
            DataTable dt = crud.QueryareaN1(grd.Rows[e.RowIndex].Cells["CJ"].Value.ToString());           
            cjxz.SelectedItem = dt.Rows[0]["PRIDISPLAYNAME"].ToString();


            if (grd.Rows[e.RowIndex].Cells["dlbz"].Value.ToString() == "1")
            {
                DLPD.Checked = true;
            }
            else
                DLPD.Checked = false;


        }


        //点击添加
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (DLPD.Checked)
            {
                if (txtFusemax.Text == "" ||
                      txtImp.Text == "" ||
                      txtIsc.Text == "" ||
                      txtLowerPower.Text == "" ||
                      txtModuleApp.Text == "" ||
                      txtPmax.Text == "" ||
                      txtUpperPower.Text == "" ||
                      txtVmp.Text == "" ||
                       txtVoc.Text == "" ||
                       txtVolmax.Text == "" ||
                       txtLowerE.Text == "" ||
                       txtUpperE.Text == "" ||
                       cjxz.SelectedItem.ToString() == ""

                       )

                {
                    MessageBox.Show("请先输入参数!");
                    return;
                }
            }
            else
            {
                if (txtFusemax.Text == "" ||
                      txtImp.Text == "" ||
                     txtIsc.Text == "" ||
                      txtLowerPower.Text == "" ||
                   txtModuleApp.Text == "" ||
                   txtPmax.Text == "" ||
                      txtUpperPower.Text == "" ||
                      txtVmp.Text == "" ||
                       txtVoc.Text == "" ||
                       txtVolmax.Text == "" ||
                       cjxz.SelectedItem.ToString() == ""
                      
                    )
                {
                    MessageBox.Show("请先输入参数!");
                    return;
                }
            }

            //表的字段等于输入值
            DataList list = new DataList();
            list.Upperrpower = txtUpperPower.Text;
            list.Lowerpower = txtLowerPower.Text;
            list.Imp = txtImp.Text;
            list.Isc = txtIsc.Text;
            list.ModuleApp = txtModuleApp.Text;
            list.Pmax = txtPmax.Text;
            list.Vmp = txtVmp.Text;
            list.Voc = txtVoc.Text;
            list.Volmax = txtVolmax.Text;
            list.Fusemax = txtFusemax.Text;
            list.ProductType = txtProductType.Text;


            list.LowerImp = txtLowerE.Text;
            list.UpperImp = txtUpperE.Text;

            DataTable dt = crud.QueryareaN2(cjxz.SelectedItem.ToString());
                list.CJ = dt.Rows[0]["PRISOURCENAME"].ToString();

            if (DLPD.Checked)
                list.DLBZ = "1";
            else
                list.DLBZ = "0";
       
            //crud.exist  对比表
            if (DLPD.Checked)
            {
                if (crud.Exist(list) == "success")
                {
                    MessageBox.Show("该范围已经存在，请重新输入！");
                    return;
                }
                if (crud.Add(list) == "success")
                {
                    MessageBox.Show("添加成功！");
                    databind();
                }
            }
            else
            {
                if (crud.Exist1(list) == "success")
                {
                    MessageBox.Show("该范围已经存在，请重新输入！");
                    return;

                }
                if (crud.Add1(list) == "success")
                {
                    MessageBox.Show("添加成功！");
                    databind();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFusemax.Text == "" ||
               txtImp.Text == "" ||
               txtIsc.Text == "" ||
               txtLowerPower.Text == "" ||
               txtModuleApp.Text == "" ||
               txtPmax.Text == "" ||
               txtUpperPower.Text == "" ||
               txtVmp.Text == "" ||
               txtVoc.Text == "" ||
               txtVolmax.Text == ""
               )
            {
                MessageBox.Show("请先输入参数!");
                return;
            }

            DataList list = new DataList();
            list.Upperrpower = txtUpperPower.Text;
            list.Lowerpower = txtLowerPower.Text;
            list.Imp = txtImp.Text;
            list.Isc = txtIsc.Text;
            list.ModuleApp = txtModuleApp.Text;
            list.Pmax = txtPmax.Text;
            list.Vmp = txtVmp.Text;
            list.Voc = txtVoc.Text;
            list.Volmax = txtVolmax.Text;
            list.Fusemax = txtFusemax.Text;

            if (crud.Exist(list) == "success")
            {
                MessageBox.Show("该范围已经存在，请重新输入！");
                return;
            }

            if (crud.Update(list) == "success")
            {
                MessageBox.Show("更新成功！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DLPD.Checked)
            {
                if (txtFusemax.Text == "" ||
                      txtImp.Text == "" ||
                      txtIsc.Text == "" ||
                      txtLowerPower.Text == "" ||
                      txtModuleApp.Text == "" ||
                      txtPmax.Text == "" ||
                      txtUpperPower.Text == "" ||
                      txtVmp.Text == "" ||
                       txtVoc.Text == "" ||
                       txtVolmax.Text == "" ||
                       txtLowerE.Text == "" ||
                       txtUpperE.Text == ""
                     )
                {
                    MessageBox.Show("请先输入参数!");
                    return;
                }
            }
            else
            {
                if (txtFusemax.Text == "" ||
                      txtImp.Text == "" ||
                     txtIsc.Text == "" ||
                      txtLowerPower.Text == "" ||
                   txtModuleApp.Text == "" ||
                   txtPmax.Text == "" ||
                      txtUpperPower.Text == "" ||
                      txtVmp.Text == "" ||
                       txtVoc.Text == "" ||
                       txtVolmax.Text == ""
                    )
                {
                    MessageBox.Show("请先输入参数!");
                    return;
                }
            }

            DataList list = new DataList();
            list.Upperrpower = txtUpperPower.Text;
            list.Lowerpower = txtLowerPower.Text;
            list.Imp = txtImp.Text;
            list.Isc = txtIsc.Text;
            list.ModuleApp = txtModuleApp.Text;
            list.Pmax = txtPmax.Text;
            list.Vmp = txtVmp.Text;
            list.Voc = txtVoc.Text;
            list.Volmax = txtVolmax.Text;
            list.Fusemax = txtFusemax.Text;
            list.ProductType = txtProductType.Text;
            list.LowerImp = txtLowerE.Text;
            list.UpperImp = txtUpperE.Text;


            DataTable dt = crud.QueryareaN2(cjxz.SelectedItem.ToString());
            list.CJ = dt.Rows[0]["PRISOURCENAME"].ToString();


            if (DLPD.Checked)
                list.DLBZ = "1";
            else
                list.DLBZ = "0";

            if (DLPD.Checked)
            {
            }
            if (crud.Delete(list) == "success")
            {
                MessageBox.Show("删除成功！");
                databind();
            }
           else
               MessageBox.Show("删除失败！\n" +
                   " 请确认要删除的数据");
        }

        private void DLPD_CheckedChanged(object sender, EventArgs e)
        {

            if (DLPD.Checked)
            {
                txtLowerE.ReadOnly = false;
                txtUpperE.ReadOnly = false;
            }
            else
            {
                txtLowerE.ReadOnly = true;
                txtUpperE.ReadOnly = true;
            }
        }


    }
}
