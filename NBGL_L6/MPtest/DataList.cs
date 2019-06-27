using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPtest
{
    public class DataList
    {
        private string _pmax;
        private string _vmp;
        private string _imp;
        private string _voc;
        private string _isc;
        private string _volmax;
        private string _fusemax;
        private string _moduleapp;
        private string _upperpower;
        private string _upperimp;

        // add by lei.xue on 2017-7-30
        private string _producttype; //产品族
        private string _lowerimp;
        private string _lowerpower;
        private String _DLBZ;
        private string _cj;
        private string _lhid;
        private string _keh;
        private string _lhlx;
        private string _lhdm;
        private string _cpmc;
        private string _guig;
        private string _cwlx;
        private string _miaos;
        private string _ytms;
        private string _paix;
        private string _flag;
        private string _khmc;
        private string _s_zongj;
        private string _s_user;
        private string _s_danj;
        private string _s_shul;
        private string _s_heth;
        private string _s_danw;
        private string _ghgs;
        private string _s_cgry;
        private string _s_xdri;
        private string _s_xqsj;
        private string _s_cplx;
        private string _s_cpmc;
        private string _s_ggxh;
        private string _s_suil;
        private string _s_cplh;
        private string _s_cwlx;
        private string _s_ddbh;
        private string _s_cpms;
        private string _s_beiz;
        private string _s_kpzt;
        private string _s_fpbh;
        private string _s_kprq;
        private string _s_skzt;
        private string _s_kddh;
        private string _s_sksj;
        private string _s_kdfy;
        private string _s_sjxx;

        //sale-sk
        public string s_kpzt
        {
            get { return _s_kpzt; }
            set { _s_kpzt = value; }
        }
        public string s_fpbh
        {
            get { return _s_fpbh; }
            set { _s_fpbh = value; }
        }
        public string s_kprq
        {
            get { return _s_kprq; }
            set { _s_kprq = value; }
        }
        public string s_skzt
        {
            get { return _s_skzt; }
            set { _s_skzt = value; }
        }
        public string s_kddh
        {
            get { return _s_kddh; }
            set { _s_kddh = value; }
        }
        public string s_sksj
        {
            get { return _s_sksj; }
            set { _s_sksj = value; }
        }
        public string s_kdfy
        {
            get { return _s_kdfy; }
            set { _s_kdfy = value; }
        }
        public string s_sjxx
        {
            get { return _s_sjxx; }
            set { _s_sjxx = value; }
        }





        //sale
        public string s_beiz
        {
            get { return _s_beiz; }
            set { _s_beiz = value; }
        }

        public string s_ddbh
        {
            get { return _s_ddbh; }
            set { _s_ddbh = value; }
        }

        public string s_khmc
        {
            get { return _khmc; }
            set { _khmc = value; }
        }
        public string s_ghgs
        {
            get { return _ghgs; }
            set { _ghgs = value; }
        }
        public string s_cgry
        {
            get { return _s_cgry; }
            set { _s_cgry = value; }
        }
        public string s_xdri
        {
            get { return _s_xdri; }
            set { _s_xdri = value; }
        }
        public string s_xqsj
        {
            get { return _s_xqsj; }
            set { _s_xqsj = value; }
        }
        public string s_cplx
        {
            get { return _s_cplx; }
            set { _s_cplx = value; }
        }
        public string s_cpmc
        {
            get { return _s_cpmc; }
            set { _s_cpmc = value; }
        }
        public string s_ggxh
        {
            get { return _s_ggxh; }
            set { _s_ggxh = value; }
        }
        public string s_suil
        {
            get { return _s_suil; }
            set { _s_suil = value; }
        }
        public string s_cplh
        {
            get { return _s_cplh; }
            set { _s_cplh = value; }
        }
        public string s_cwlx
        {
            get { return _s_cwlx; }
            set { _s_cwlx = value; }
        }
        public string s_danw
        {
            get { return _s_danw; }
            set { _s_danw = value; }
        }
        public string s_heth
        {
            get { return _s_heth; }
            set { _s_heth = value; }
        }
        public string s_shul
        {
            get { return _s_shul; }
            set { _s_shul = value; }
        }
        public string s_danj
        {
            get { return _s_danj; }
            set { _s_danj = value; }
        }
        public string s_zongj
        {
            get { return _s_zongj; }
            set { _s_zongj = value; }
        }

        public string s_user
        {
            get { return _s_user; }
            set { _s_user = value; }
        }
        public string s_cpms
        {
            get { return _s_cpms; }
            set { _s_cpms = value; }
        }

        //











        //
        public string lhid
        {
            get { return _lhid; }
            set { _lhid = value; }
        }
        public string keh
        {
            get { return _keh; }
            set { _keh = value; }
        }
        public string lhlx
        {
            get { return _lhlx; }
            set { _lhlx = value; }
        }

        public string lhdm
        {
            get { return _lhdm; }
            set { _lhdm = value; }
        }
        public string cpmc
        {
            get { return _cpmc; }
            set { _cpmc = value; }
        }
        public string guig
        {
            get { return _guig; }
            set { _guig = value; }
        }

        public string cwlx
        {
            get { return _cwlx; }
            set { _cwlx = value; }
        }
        public string miaos
        {
            get { return _miaos; }
            set { _miaos = value; }
        }
        public string ytms
        {
            get { return _ytms; }
            set { _ytms = value; }
        }
        public string paix
        {
            get { return _paix; }
            set { _paix = value; }
        }
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }









        public string ProductType
        {
            get { return _producttype; }
            set { _producttype = value; }
        }

        public string Pmax
        {
            get { return _pmax; }
            set { _pmax = value; }
        }

        public string Vmp
        {
            get { return _vmp; }
            set { _vmp = value; }
        }
        public string Imp
        {
            get { return _imp; }
            set { _imp = value; }
        }
        public string Voc
        {
            get { return _voc; }
            set { _voc = value; }
        }
        public string Isc
        {
            get { return _isc; }
            set { _isc = value; }
        }
        public string Volmax
        {
            get { return _volmax; }
            set { _volmax = value; }
        }
        public string Fusemax
        {
            get { return _fusemax; }
            set { _fusemax = value; }
        }
        public string ModuleApp
        {
            get { return _moduleapp; }
            set { _moduleapp = value; }
        }
        public string Upperrpower
        {
            get { return _upperpower; }
            set { _upperpower = value; }
        }
        public string Lowerpower
        {
            get { return _lowerpower; }
            set { _lowerpower = value; }
        }

        public string UpperImp
        {
            get { return _upperimp; }
            set { _upperimp = value; }
        }

        public string LowerImp
        {
            get { return _lowerimp; }
            set { _lowerimp = value; }
        }

        public string DLBZ
        {
            get { return _DLBZ; }
            set { _DLBZ = value; }
        }
        public string CJ
        {
            get { return _cj; }
            set { _cj = value; }
        }
    }
}
