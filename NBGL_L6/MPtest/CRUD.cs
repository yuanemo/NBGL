﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Reflection;

namespace MPtest
{
    class CRUD
    {
        public DBOperation MysqlHelp;
        DataList list;
        public CRUD()
        {
            MysqlHelp = new DBOperation();
            MysqlHelp.Result = "";
            MysqlHelp.ServerIP = ConfigurationManager.AppSettings["IP"].ToString();//172.16.2.19//192.168.10.43
            MysqlHelp.DBUserName = "mesadmin";//DES.string_Decrypt("09A6000CDFC0FC659A6A174D0938F7E1");// "mesadmin";
            MysqlHelp.DBPassWord = "1qAZ2wSX"; //DES.string_Decrypt("FC4BA246016DE7AFC02B1F2B36337228");// "1qAZ2wSX";
            MysqlHelp.DB = "hljd";
        }

        //查询pmax
        public DataTable QueryPmaxByModuleID(string ID)
        {
            //string sql = "select module_ID ,Pmax from js_mes.rt_mid_flash where module_id ='" + ID + "'";
            string sql = " select Module_ID,PMAX,IPM from  js_mes.rt_mid_flash where Module_ID ='" + ID + "' ";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //查询组件的装配件号 add by xue lei on 2017-12-2
        //取消查询装配件 modify by lei.xue on 2017-12-13
        public DataTable QueryAssembleByModuleID(string ID)
        {
            string sql = " select product_code from [mes_main].[dbo].[assembly_basis] where serial_nbr = '" + ID + "'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //查询组件的产品族
        public DataTable QueryFamilyCodeByModuleID(string ID)
        {
            string sql = " SELECT ProductType FROM js_mes.df_bom_basic WHERE BOMID=(SELECT BOMID FROM js_mes.df_wo_info WHERE workorder_id=(SELECT WorkOrder_ID FROM js_mes.lotbasis WHERE Module_ID='" + ID + "'))";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }


        //比较
        public DataTable QueryLabelInfo(string cj, string ipm,string Pmax, string ProductType)
        {
            string sql = "select Pmax,upperpower,lowerpower,Vmp,Imp,upperimp,lowerimp,Voc,Isc,Volmax,Fusemax,ModuleApp from js_mes.rt_mid_flash_label  where upperpower>" + Pmax + " and lowerpower<=" + Pmax + " and lowerimp<=" + ipm + " and upperimp>=" + ipm + " and producttype = '" + ProductType + "' and CJ = '" + cj + "' ";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public DataTable QueryLabelInfo1(string cj, string Pmax, string ProductType)
        {
            string sql = "select Pmax,upperpower,lowerpower,Vmp,Imp,upperimp,lowerimp,Voc,Isc,Volmax,Fusemax,ModuleApp from js_mes.rt_mid_flash_label  where upperpower>" + Pmax + " and lowerpower<=" + Pmax + " and producttype = '" + ProductType + " and CJ = '" + cj + "' ";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public string Add(DataList list)
        {
            string result = "";
            string sql = "INSERT INTO js_mes.rt_mid_flash_label "
            + "(Pmax, "
            + "ProductType, "
            + "UPPERPOWER, "
            + "LOWERPOWER, "
            + "Vmp, "
            + "Imp, "
            + "Voc, "
            + "Isc, "
            + "Volmax, "
            + "Fusemax, "
            + "Moduleapp, "
            + "ProductFamily, "
            + "createuser, "

            + "UPPERIMP, "
            +"LOWERIMP,"
            + "DLBZ,"
            + "CJ,"
            + "createtime) "
               
     
            + "VALUES "
            + "('" + list.Pmax + "', "
            + "'" + list.ProductType + "', "
            + "" + list.Upperrpower + ", "
            + "" + list.Lowerpower + ", "
            + "'" + list.Vmp + "', "
            + "'" + list.Imp + "', "
            + "'" + list.Voc + "', "
            + "'" + list.Isc + "', "
            + "'" + list.Volmax + "', "
            + "'" + list.Fusemax + "', "
            + "'" + list.ModuleApp + "', "
            + "'" + "ProductFamily" + "',"

            + "'" + "createuser" + "', "
            + "" + list.UpperImp + ","
            + "" + list.LowerImp + ", "
            + "" + list.DLBZ + ", "
            + "'" + list.CJ + "', "
            + " NOW()); ";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string Add1(DataList list)
        {
            string result = "";
            string sql = "INSERT INTO js_mes.rt_mid_flash_label "
            + "(Pmax, "
            + "ProductType, "
            + "UPPERPOWER, "
            + "LOWERPOWER, "
            + "Vmp, "
            + "Imp, "
            + "Voc, "
            + "Isc, "
            + "Volmax, "
            + "Fusemax, "
            + "Moduleapp, "
            + "ProductFamily, "
            + "createuser, "
             + "DLBZ,"
             +"CJ,"  
            + "createtime) "


            + "VALUES "
            + "('" + list.Pmax + "', "
            + "'" + list.ProductType + "', "
            + "" + list.Upperrpower + ", "
            + "" + list.Lowerpower + ", "
            + "'" + list.Vmp + "', "
            + "'" + list.Imp + "', "
            + "'" + list.Voc + "', "
            + "'" + list.Isc + "', "
            + "'" + list.Volmax + "', "
            + "'" + list.Fusemax + "', "
            + "'" + list.ModuleApp + "', "
            + "'" + "ProductFamily" + "',"
            + "'" + "createuser" + "', "
            + "" + list.DLBZ + ", "
            + "'" + list.CJ + "', "
            + " NOW()); ";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        //输入后做对比
        public string Exist(DataList list)
        {
            string result = "";
            string sql = "select Pmax,imp from js_mes.rt_mid_flash_label where  ProductType = '" + list.ProductType + "'  and DLBZ = '" + list.DLBZ + "'  and CJ = '" + list.CJ + "' and((" + list.Lowerpower + ">= lowerpower and " + list.Lowerpower + " >= upperpower and " + list.Upperrpower + ">=upperpower and " + list.Upperrpower + ">=lowerpower) "
                       + " or (" + list.LowerImp + "<= lowerimp and " + list.LowerImp + " <= upperimp and " + list.UpperImp + "<=upperimp and " + list.UpperImp + "<=lowerimp)"
                       + " or (" + list.LowerImp + ">= lowerimp and " + list.LowerImp + " >= upperimp and " + list.UpperImp + ">=upperimp and " + list.UpperImp + ">=lowerimp)"
                       + " or (" + list.Lowerpower + "<= lowerpower and " + list.Lowerpower + " <= upperpower and " + list.Upperrpower + "<=upperpower and " + list.Upperrpower + "<=lowerpower))";
            DataTable dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
            //设定值不在参数内的参数个数

            /********判断有几行？？************/
            int count = dt == null ? 0 : dt.Rows.Count;
            sql = "select count(*) from js_mes.rt_mid_flash_label where  ProductType = '" + list.ProductType + "' and dlbz ='"+list.DLBZ+"' and CJ ='" + list.CJ + "'";
            dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
            //所有参数的个数
            int countall = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (count == countall)
            {
                return "fail";
            }
            else
            {
                return "success";
            }
        }
        public string Exist1(DataList list)
        {
            string result = "";
            string sql = "select Pmax,imp from js_mes.rt_mid_flash_label where  ProductType = '" + list.ProductType + "'  and DLBZ = '" + list.DLBZ + "'  and CJ = '" + list.CJ + "'" +
                "and( (" + list.Lowerpower + ">= lowerpower and " + list.Lowerpower + " >= upperpower and " + list.Upperrpower + ">=upperpower and " + list.Upperrpower + ">=lowerpower) "
//                       + " or (" + list.LowerImp + "<= lowerimp and " + list.LowerImp + " <= upperimp and " + list.UpperImp + "<=upperimp and " + list.UpperImp + "<=lowerimp)"
//                       + " or (" + list.LowerImp + ">= lowerimp and " + list.LowerImp + " >= upperimp and " + list.UpperImp + ">=upperimp and " + list.UpperImp + ">=lowerimp)"
                       + " or (" + list.Lowerpower + "<= lowerpower and " + list.Lowerpower + " <= upperpower and " + list.Upperrpower + "<=upperpower and " + list.Upperrpower + "<=lowerpower))";
            DataTable dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
            //设定值不在参数内的参数个数

            /********判断有几行？？************/
            int count = dt == null ? 0 : dt.Rows.Count;
            sql = "select count(*) from js_mes.rt_mid_flash_label where  ProductType = '" + list.ProductType + "' and dlbz ='" + list.DLBZ + "'  and CJ ='" + list.CJ + "'";
            dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
            //所有参数的个数
            int countall = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (count == countall)
            {
                return "fail";
            }
            else
            {
                return "success";
            }
        }

        //修改
        public string Update(DataList list)
        {
            string result = "";
            string sql = "UPDATE mes_level2_iface.dbo.rt_mid_flash_label"
            + " SET"
            + " UPPERPOWER = " + list.Upperrpower + " ,"
            + " LOWERPOWER = " + list.Lowerpower + " ,"
            + " Vmp = " + list.Vmp + " ,"
            + " Imp = " + list.Imp + " ,"
            + " Voc = " + list.Voc + " ,"
            + " Isc = " + list.Isc + " ,"
            + " Volmax = " + list.Volmax + " ,"
            + " Fusemax = " + list.Fusemax + " ,"
            + " Moduleapp' = " + list.ModuleApp + " ,"
            + " WHERE"
            + " Pmax = '" + list.Pmax + "'";
            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        //
        //删除
        public string Delete(DataList list)
        {
            string sql = "";
            string result = "";
            if (list.DLBZ == "1")
            {

                sql = "DELETE FROM js_mes.rt_mid_flash_label " +
           " WHERE upperpower = " + list.Upperrpower + " and lowerpower = " + list.Lowerpower +
           //增加产品族和pmax条件
           " and Pmax ='" + list.Pmax + "' and ProductType = '" + list.ProductType + "' and CJ = '" + list.CJ +
           "' and Imp = '" + list.Imp + "' and UPPERIMP = " + list.UpperImp + " and  LOWERIMP  = " + list.LowerImp + "";
            }
            else
            {
                sql = "DELETE FROM js_mes.rt_mid_flash_label " +
                " WHERE upperpower = " + list.Upperrpower + " and lowerpower = " + list.Lowerpower +
                //增加产品族和pmax条件
                " and Pmax ='" + list.Pmax + "' and ProductType = '" + list.ProductType + "' and CJ = '" + list.CJ + "' and dlbz = '" + list.DLBZ + "'";
            }
            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success:1") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        //获取表格
        public DataTable QueryConfig()
        {
            string sql = "select * from js_mes.rt_mid_flash_label ";
            return MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);

        }


        //查询组件产品族信息和 尺寸重量
        public DataTable QueryProductTypeByModuleLot(string ModuleLot)
        {
            string sql = " select a.ProductType , " +
            " (SELECT PRIDISPLAYNAME from js_mes.df_config_condition_linkage a  " +
            " INNER JOIN js_mes.df_bom_basic b on b.ModuleModel = a.PRISOURCENAME " +
            "  where b.BOMID = a.bomid and a.LINKDESCRIPTION = 'module_model' ) SizeWeight " +
            " from df_bom_basic a  " +
            " INNER JOIN df_wo_info b on a.BOMID = b.BOMID  " +
            " INNER JOIN lotbasis c on c.WorkOrder_ID = b.workorder_id  where c.Module_ID='" + ModuleLot + "' ";
            return MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);

        }


        public DataTable QueryTemplatePath()
        {
            string sql = " select * from js_mes.df_config_condition_linkage where LINKDESCRIPTION='MP_Template' ";
            return MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }


        //获取组件所在车间
        public DataTable Queryarea(string ID)
        {
            string sql = "SELECT PRIDISPLAYNAME FROM js_mes.df_config_condition_linkage WHERE PRISOURCENAME=(SELECT workshop FROM js_mes.df_wo_info WHERE workorder_id =(SELECT WorkOrder_ID FROM js_mes.lotbasis WHERE Module_ID ='"+ID+ "')) and State = 'Y'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn,sql);
        }

        //获取车间编号
        public DataTable QueryareaBZ(string ID)
        {
            string sql = " SELECT workshop FROM js_mes.df_wo_info WHERE workorder_id =(SELECT WorkOrder_ID FROM js_mes.lotbasis WHERE Module_ID ='" + ID + "')";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //查找车间
        public DataTable QueryareaN()
        {
            string sql = "SELECT PRIDISPLAYNAME FROM `df_config_condition_linkage`WHERE LINKDESCRIPTION = 'workshop'AND State = 'Y'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
            
        }
        //根据编号,找车间名
        public DataTable QueryareaN1(string N)
        {
            string sql = "SELECT PRIDISPLAYNAME FROM `df_config_condition_linkage` WHERE  PRISOURCENAME='" + N+ "' AND State = 'Y'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);

        }
        //根据车间名,求编号
        public DataTable QueryareaN2(string N)
        {
            string sql = " SELECT PRISOURCENAME FROM `df_config_condition_linkage` WHERE PRIDISPLAYNAME='" + N + "' AND State = 'Y'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);

        }

        //账号,密码
        public DataTable ZHMMYZ(string Z)
        {
            string sql =
                         "   SELECT  UserID,NICKNAME,PassWord ,MainGroupName,State " +
                                        "   FROM   df_userbasic  " +
                                      "   WHERE   UserID = '" + Z + "'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }


        public DataTable CXCD(string Z)
        {
            string sql =
                                         "   SELECT DISTINCT                                " +
                 "       a.ID,                                      " +
                 "       a.FunctionName,                            " +
                 "       a.MenuName,                                " +
                 "       a.ParentID,                                " +
                 "       a.IsNeedClick,                             " +
                 "       a.Assembly ,                               " +
                 "       ifnull(a.MenuShowID ,99)  MenuShowID       " +
                 "   FROM                                           " +
                 "        df_FUNCTIONS a,                           " +
                 "        df_usergroup_n2m b,                       " +
                 "        df_usergroup_pn2m c,                      " +
                 "        df_userbasic d                            " +
                 "   WHERE                                          " +
                 "       A.ID = C.FunctionID                        " +
                 "           AND b.GroupID = C.GroupID              " +
                 "           and b.UserID=d.UserID                  " +
                 "           AND d.State in('Y', 'T')                      " +
                 "           AND a.Enabled = 'Y'                    " +
                 "           AND D.USERID = '" + Z + "'      " +
                 "   ORDER BY  a.ParentID ,ifnull(a.MenuShowID ,99)    ";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public DataTable CZFunctionName(string Z)
        {
            string sql =
                         "SELECT FunctionName FROM hljd.df_functions WHERE MenuName = '" + Z +"'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //查找物料编码
        public DataTable CZwlbm()
        {
            string sql =
                         "SELECT lhid as 料号ID,keh AS 客户,lhlx AS 料号类型,lhdm AS 料号代码,ytms AS 用途描述,cpmc as 产品名称,guig as 规格,cwlx AS 财务类型,miaos AS 描述,paix AS 排序,flag AS 是否启用 FROM hljd.df_material_basic ORDER BY lhid DESC";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public DataTable CZwlbmlhmax()
        {
            string sql =
                         "SELECT lhid FROM hljd.df_material_basic ORDER BY lhid DESC";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public string Addwlbm(DataList list)
        {
            string result = "";
            string sql = "INSERT INTO hljd.df_material_basic"
                        +"(lhid, keh, lhlx, lhdm, ytms, cpmc, guig, cwlx, miaos, paix, flag)"
                           + "VALUES"+
                          "('"+list.lhid+"', '"+list.keh+"', '"+list.lhlx+"', '"+list.lhdm+"', '"+list.ytms+"', '"+list.cpmc+"', '"+list.guig+"', '"+list.cwlx+"', '"+list.miaos+"', '"+list.paix+"', '"+list.flag+"')";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }

        }

        public DataTable czsale()
        {
            string sql =
                         "SELECT lotid AS 订单编号,kehu AS 客户,cgry AS 采购人员,cplx as 产品类型,cpmc as 产品名称," +
                         "ggxh AS 规格型号,cplh as 产品料号,cwlx AS 财务类型,danw AS 单位,shul as 数量,danj as 单价,"+
                         "zongj as 总价,xdrq as 下单日期,jhrq AS 交货日期,suil AS 税率,ghgs AS 供货公司,hth AS 合同号,htlj AS 合同路径,beiz AS 备注,"+
                         "cpms AS 产品描述,kpzt AS 开票状态,kprq as 开票日期,kpbh AS 开票编号,fpkddh AS 快递单号,sjxi AS 收件信息,kdfy as 快递费用,"+
                         "skzt AS 收款状态,sksj AS 收款时间 FROM hljd.flow_sale ORDER BY lotid DESC";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        public DataTable czddbh(string time)
        {
            string sql = " SELECT lotid FROM hljd.flow_sale WHERE lotid LIKE '%"+ time + "%' ORDER BY lotid DESC";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //sale界面,添加
        public string Addsale(DataList list)
        {
            string result = "";
            string sql = "INSERT INTO hljd.flow_sale" +
                        "(lotid, kehu, cgry, cplx, cpmc, ggxh, ytms, cplh, cwlx, danw," +
                " shul, danj, zongj, xdrq, jhrq, suil, ghgs, hth, htlj, beiz, cpms, user)" +
                "VALUES('" + list.s_ddbh + "', '" + list.s_khmc + "', '" + list.s_cgry + "', '" + list.s_cplx + "', '" + list.s_cpmc + "" +
                "', '" + list.s_ggxh + "', '" + list.ytms + "', '" + list.s_cplh + "'," +
                " '" + list.s_cwlx + "', '" + list.s_danw + "', '" + list.s_shul + "', '" + list.s_danj + "', '" + list.s_zongj + "', '" + list.s_xdri + "'," +
                "'" + list.s_xqsj + "', '"+list.s_suil+"', '" + list.s_ghgs + "', '"+list.s_heth+"', '', '"+list.s_beiz+"', '"+list.s_cpms+"', '" + list.s_user + "') ";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        //查找收款
        public DataTable czSK(string Z)
        {
            string sql =
                         "SELECT * FROM hljd.flow_sale where lotid ='"+Z+"'";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //sale界面,收款修改
        public string addkp(DataList list)
        {
            string result = "";
            string sql = "UPDATE hljd.flow_sale"+ 
                            " SET kpzt = '"+list.s_kpzt+"',"+
                            "kprq = '"+list.s_kprq+"',"+
                            "kpbh = '"+list.s_fpbh+"',"+
                            "fpkddh = '"+list.s_kddh+"',"+
                            "sjxi = '"+list.s_sjxx+"',"+
                            "kdfy = '"+list.s_kdfy+"',"+
                            "skzt = '"+list.s_skzt+"',"+
                            "sksj = '"+list.s_sksj+"',"+
                            "user = '"+list.s_user+"'"+
                            "WHERE lotid = '"+list.s_ddbh+"'";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        //下单修改
        public string xgxd(DataList list)
        {
            string result = "";
            string sql = "UPDATE hljd.flow_sale"+ 
                          " SET "+
                            "kehu='"+list.keh+"' ," +
                            "cgry='"+list.s_cgry+"'," +
                            "cplx='"+list.s_cplx+"'," +
                            "cpmc='"+list.s_cpmc+"'," +
                            "ggxh='"+list.s_ggxh+"'," +
                            //"ytms='"+list.s_y+"'," +
                            "cplh='"+list.s_cplh+"'," +
                            "cwlx='"+list.s_cwlx+"'," +
                            "danw='"+list.s_danw+"'," +
                            "shul='"+list.s_shul+"'," +
                             "danj='"+list.s_danj+"'," +
                             "zongj='"+list.s_zongj+"'," +
                             "xdrq='"+list.s_xdri+"'," +
                             "jhrq='"+list.s_xqsj+"'," +
                             "suil='"+list.s_suil+"'," +
                             "ghgs='"+list.s_ghgs+"'," +
                             "hth='"+list.s_heth+"'," +
                             //"htlj='"+list.htlj+"'," +
                             "beiz='"+list.s_beiz+"'," +
                             "cpms='"+list.s_cpms+"'," +
                             "user='"+list.s_user+"'" +
                            "WHERE lotid = '"+list.s_ddbh+"'";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        public string xgwlbm(DataList list)
        {
            string result = "";
            string sql = "UPDATE hljd.df_material_basic"+
                        " SET keh = '"+list.keh+"', lhlx = '"+list.lhlx+"', lhdm = '"+list.lhdm+"', ytms = '"+list.ytms+"', cpmc = '"+list.cpmc+"', guig = '"+list.guig+"', cwlx = '"+list.cwlx+"', paix = '"+list.paix+"', miaos = '"+list.miaos+"', flag = '"+list.flag+"'"+
                        " WHERE lhid = '"+list.lhid+"'";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        public DataTable xlk(string txt,string lx)
        {
            string sql =
                    "SELECT PRIDISPLAYNAME FROM hljd.df_config_condition_linkage"+
                        "WHERE PRIDISPLAYNAME LIKE '%"+txt+"%' AND family_remark = '"+lx+"' AND State = 'Y'"+
                        "ORDER BY PRISEQUENCE";
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //查找全部下拉框
        public DataTable qbxlk()
        {
            string sql =
                    "SELECT * FROM hljd.df_config_condition_linkage" +
                        " WHERE  State = 'Y'" ;
            DataTable dt;
            return dt = MysqlHelp.ExecuteReader(MysqlHelp.MySqlconn, sql);
        }

        //简单添加下拉框选项
        public string Addxlk(string txtadd,string lx)
        {
            string result = "";
            string sql = "INSERT INTO hljd.df_config_condition_linkage "+
                        "(PRIDISPLAYNAME, family_remark, state)"+
                        "VALUES('"+txtadd+"', '"+lx+"', 'Y')";

            MysqlHelp.ExecuteNonquery(MysqlHelp.MySqlconn, sql, ref result);
            if (result.StartsWith("Success") == true)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
    }
}
