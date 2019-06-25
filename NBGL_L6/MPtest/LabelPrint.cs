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
    public partial class LabelPrint : Form
    {
        public LabelPrint()
        {
            InitializeComponent();
        }
        CRUD objCRUD = new CRUD();
        private void txtModuleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strProductType;
            string strSizeWeight;
            string[] arySizeWeight;
            if (e.KeyChar == 13)
            {
                if (txtModuleID.Text == "")
                {
                    MessageBox.Show(this, "请扫描组件序列号！");
                    return;
                }
                //与数据库比对

                DataTable dt = objCRUD.QueryPmaxByModuleID(txtModuleID.Text);
                if (dt == null)
                {
                    MessageBox.Show(this, "没有查询到该组件序列号！");
                    txtModuleID.Text = "";
                    return;
                }

                string strPmax = dt.Rows[0]["Pmax"].ToString();
                string strimp = dt.Rows[0]["IPM"].ToString();
                  dt = null;
                //车间
                dt = objCRUD.Queryarea(txtModuleID.Text);
                string strcej = dt.Rows[0]["PRIDISPLAYNAME"].ToString();
                dt = null;
                DYCJ.SelectedItem = strcej;

                dt = objCRUD.QueryareaBZ(txtModuleID.Text);
                string strcejBZ = dt.Rows[0]["workshop"].ToString();
                dt = null;

                

                //dt = objCRUD.QueryAssembleByModuleID(txtModuleID.Text);
               dt = objCRUD.QueryFamilyCodeByModuleID(txtModuleID.Text);
                //查询装配件号改为查询组件的装配件号 add by xue lei on 2017-12-2
            
                if (dt != null && dt.Rows.Count > 0)
                {
                    //txtProductType.Text = dt.Rows[0]["product_code"].ToString();
                    txtProductType.Text = dt.Rows[0]["ProductType"].ToString();
                }
                else
                {
                    //MessageBox.Show("未查询到组件的装配件号");
                    MessageBox.Show("未查询到组件的产品族");
                    return;
                }
 /**************************************************************
                string strcj = "";
                if (DYCJ.SelectedItem.ToString() == "一车间")
                    strcj = "M01";
                else if (DYCJ.SelectedItem.ToString() == "二车间")
                    strcj = "M02";
                else if (DYCJ.SelectedItem.ToString() == "三车间")
                    strcj = "M03";
 ****88888888888888888888888888888888888888888/
                /**************************************************************/
                #region 查询组件序列号的产品族&组件尺寸和重量
                //查询组件序列号的产品族&组件尺寸和重量 add by lei.xue on 2017-3-19==========================================
                //dt = null;
                //dt = objCRUD.QueryProductTypeByModuleLot(txtModuleID.Text);
                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    txtProductType.Text = dt.Rows[0]["producttype"].ToString();
                //    strSizeWeight = dt.Rows[0]["sizeweight"].ToString();
                //    arySizeWeight = strSizeWeight.Split(',');
                //    if (arySizeWeight.Length >= 5)
                //    {
                //        txtSize.Text = arySizeWeight[3];
                //        txtWeight.Text = arySizeWeight[4];
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("未查询到产品族、尺寸和重量信息");
                //    return;
                //}
                //查询组件序列号的产品族&组件尺寸和重量 add by lei.xue on 2017-3-19==========================================
                #endregion
                string strAssembly = "";
                string strAeesmblyMatchPmax = "";
               
                if (strimp == "")
                {
                 dt = objCRUD.QueryLabelInfo1(strcejBZ, strPmax, txtProductType.Text);
                }
                else
                dt = objCRUD.QueryLabelInfo(strcejBZ,strimp, strPmax, txtProductType.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtPmax.Text = dt.Rows[0]["Pmax"].ToString();
                    txtVmp.Text = dt.Rows[0]["Vmp"].ToString();
                    txtVoc.Text = dt.Rows[0]["Voc"].ToString();
                    txtVolmax.Text = dt.Rows[0]["Volmax"].ToString();
                    txtModuleapp.Text = dt.Rows[0]["ModuleApp"].ToString();
                    txtFusemax.Text = dt.Rows[0]["Fusemax"].ToString();
                    txtIsc.Text = dt.Rows[0]["Isc"].ToString();
                    txtImp.Text = dt.Rows[0]["Imp"].ToString();
                    DYCJ.SelectedText = strcej;
                    //装配件号的第3、4、5位用配置表里的pmax替换
                    //txtProductType.Text = strAeesmblyMatchPmax;
                    if (txtProductType.Text.Substring(2, 3).ToString() == "***")
                    {
                        //配置信息中的装配件号第3、4、5位用*号替换

                        txtProductType.Text = txtProductType.Text.Replace("***", txtPmax.Text);
                    }
                }
                else
                {
                    MessageBox.Show("未查询到配置信息");
                    return;
                }

                btnPrint_Click(null, null);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //strWriteFileStream = wipDataReceived.Result;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\BarcodePrint\ModuleLabel.txt", false, Encoding.GetEncoding("gb2312")))
            {
                file.WriteLine(txtPmax.Text + "," +
                               //Convert.ToDouble(txtVmp.Text).ToString("0.0") + ","+ 
                               //Convert.ToDouble(txtImp.Text).ToString("0.00") +","+
                               //Convert.ToDouble(txtVoc.Text).ToString("0.0") +","+
                               //Convert.ToDouble(txtIsc.Text).ToString("0.00") +","+
                               txtVmp.Text + "," +
                               txtImp.Text + "," +
                               txtVoc.Text + "," +
                               txtIsc.Text + "," +
                               txtVolmax.Text + "," +
                               txtFusemax.Text + "," +
                               txtModuleapp.Text + "," +
                               txtProductType.Text + "," +
                               txtWeight.Text + "," +
                               txtSize.Text + "," +
                               txtModuleID.Text);
                file.Close();
            }

            string templateName = DDLTemplate.SelectedValue.ToString();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\BarcodePrint\usb.bat", false, Encoding.GetEncoding("gb2312")))
            {
                file.WriteLine("@echo off");

                file.WriteLine("bartend.exe /F=\"C:\\BarcodePrint\\" + templateName + ".btw\" /D=\"C:\\BarcodePrint\\ModuleLabel.txt\" /P /x");
                //add by lei.xue on 2017-8-31 增加组件序列号标签
                if (checkBox1.Checked)
                {
                    file.WriteLine("bartend.exe /F=\"C:\\BarcodePrint\\" + "MouldLot" + ".btw\" /D=\"C:\\BarcodePrint\\ModuleLabel.txt\" /P /x");
                }
                //else
                //    MessageBox.Show("请勾选");
            }

            txtLog.Text = txtModuleID.Text + "\r\n" + txtLog.Text;
            Clear();

            try
            {
                System.Diagnostics.Process.Start(@"c:\BarcodePrint\usb.bat");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtModuleID_TextChanged(object sender, EventArgs e)
        {

        }

        private class template
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        //加载时触发
        private void LabelPrint_Load(object sender, EventArgs e)
        {
            //DataTable dt = objCRUD.QueryTemplatePath();
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    DDLTemplate.DataSource = dt;
            //    DDLTemplate.DisplayMember = "PRIDISPLAYNAME";
            //    DDLTemplate.ValueMember = "PRISOURCENAME";
            //}
            IList<template> list = new List<template>();
            list.Add(new template() { name = "自产", value = "ModuleLabel" });
            list.Add(new template() { name = "特殊", value = "ModuleLabelTest" });
            DDLTemplate.DataSource = list;
            DDLTemplate.DisplayMember = "name";
            DDLTemplate.ValueMember = "value";



        }

        private void Clear()
        {
            //txtPmax.Text = "";
            //txtVmp.Text = "";
            //txtVoc.Text = "";
            //txtVolmax.Text = "";
            //txtModuleapp.Text = "";
            //txtFusemax.Text = "";
            //txtIsc.Text = "";
            //txtImp.Text = "";
            txtModuleID.Text = "";
            //txtProductType.Text = "";
            //txtSize.Text = "";
            //txtWeight.Text = "";
        }

    }
}
