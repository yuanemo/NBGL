namespace MPtest
{
    partial class PrintConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.cjxz = new System.Windows.Forms.ComboBox();
            this.DLPD = new System.Windows.Forms.CheckBox();
            this.txtLowerE = new System.Windows.Forms.TextBox();
            this.txtUpperE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtImp1 = new System.Windows.Forms.Label();
            this.txtModuleApp = new System.Windows.Forms.TextBox();
            this.txtIsc = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtLowerPower = new System.Windows.Forms.TextBox();
            this.txtUpperPower = new System.Windows.Forms.TextBox();
            this.txtFusemax = new System.Windows.Forms.TextBox();
            this.txtVolmax = new System.Windows.Forms.TextBox();
            this.txtVoc = new System.Windows.Forms.TextBox();
            this.txtVmp = new System.Windows.Forms.TextBox();
            this.txtPmax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cjxz);
            this.groupBox1.Controls.Add(this.DLPD);
            this.groupBox1.Controls.Add(this.txtLowerE);
            this.groupBox1.Controls.Add(this.txtUpperE);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtImp1);
            this.groupBox1.Controls.Add(this.txtModuleApp);
            this.groupBox1.Controls.Add(this.txtIsc);
            this.groupBox1.Controls.Add(this.txtImp);
            this.groupBox1.Controls.Add(this.txtProductType);
            this.groupBox1.Controls.Add(this.txtLowerPower);
            this.groupBox1.Controls.Add(this.txtUpperPower);
            this.groupBox1.Controls.Add(this.txtFusemax);
            this.groupBox1.Controls.Add(this.txtVolmax);
            this.groupBox1.Controls.Add(this.txtVoc);
            this.groupBox1.Controls.Add(this.txtVmp);
            this.groupBox1.Controls.Add(this.txtPmax);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1800, 1000);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.grd);
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1747, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明细";
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(-1, 22);
            this.grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 27;
            this.grd.Size = new System.Drawing.Size(1720, 321);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // cjxz
            // 
            this.cjxz.FormattingEnabled = true;
            this.cjxz.Location = new System.Drawing.Point(1401, 32);
            this.cjxz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cjxz.Name = "cjxz";
            this.cjxz.Size = new System.Drawing.Size(99, 23);
            this.cjxz.TabIndex = 57;
            this.cjxz.Text = "车间选择";
            // 
            // DLPD
            // 
            this.DLPD.AutoSize = true;
            this.DLPD.Location = new System.Drawing.Point(372, 144);
            this.DLPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DLPD.Name = "DLPD";
            this.DLPD.Size = new System.Drawing.Size(149, 19);
            this.DLPD.TabIndex = 56;
            this.DLPD.Text = "是否启用电流范围";
            this.DLPD.UseVisualStyleBackColor = true;
            this.DLPD.CheckedChanged += new System.EventHandler(this.DLPD_CheckedChanged);
            // 
            // txtLowerE
            // 
            this.txtLowerE.Location = new System.Drawing.Point(675, 145);
            this.txtLowerE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLowerE.Name = "txtLowerE";
            this.txtLowerE.Size = new System.Drawing.Size(132, 25);
            this.txtLowerE.TabIndex = 55;
            // 
            // txtUpperE
            // 
            this.txtUpperE.Location = new System.Drawing.Point(949, 145);
            this.txtUpperE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpperE.Name = "txtUpperE";
            this.txtUpperE.Size = new System.Drawing.Size(132, 25);
            this.txtUpperE.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(871, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "电流上限";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "电流下限";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(1401, 146);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 29);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1137, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "ModuleApp";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(1401, 91);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 29);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(1224, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1185, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "Isc";
            // 
            // txtImp1
            // 
            this.txtImp1.AutoSize = true;
            this.txtImp1.Location = new System.Drawing.Point(113, 144);
            this.txtImp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtImp1.Name = "txtImp1";
            this.txtImp1.Size = new System.Drawing.Size(31, 15);
            this.txtImp1.TabIndex = 49;
            this.txtImp1.Text = "Imp";
            // 
            // txtModuleApp
            // 
            this.txtModuleApp.Location = new System.Drawing.Point(1224, 88);
            this.txtModuleApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModuleApp.Name = "txtModuleApp";
            this.txtModuleApp.Size = new System.Drawing.Size(132, 25);
            this.txtModuleApp.TabIndex = 48;
            // 
            // txtIsc
            // 
            this.txtIsc.Location = new System.Drawing.Point(1224, 30);
            this.txtIsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsc.Name = "txtIsc";
            this.txtIsc.Size = new System.Drawing.Size(132, 25);
            this.txtIsc.TabIndex = 47;
            // 
            // txtImp
            // 
            this.txtImp.Location = new System.Drawing.Point(152, 142);
            this.txtImp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(132, 25);
            this.txtImp.TabIndex = 46;
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(152, 30);
            this.txtProductType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(132, 25);
            this.txtProductType.TabIndex = 45;
            // 
            // txtLowerPower
            // 
            this.txtLowerPower.Location = new System.Drawing.Point(675, 25);
            this.txtLowerPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLowerPower.Name = "txtLowerPower";
            this.txtLowerPower.Size = new System.Drawing.Size(132, 25);
            this.txtLowerPower.TabIndex = 44;
            // 
            // txtUpperPower
            // 
            this.txtUpperPower.Location = new System.Drawing.Point(949, 30);
            this.txtUpperPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpperPower.Name = "txtUpperPower";
            this.txtUpperPower.Size = new System.Drawing.Size(132, 25);
            this.txtUpperPower.TabIndex = 43;
            // 
            // txtFusemax
            // 
            this.txtFusemax.Location = new System.Drawing.Point(949, 88);
            this.txtFusemax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFusemax.Name = "txtFusemax";
            this.txtFusemax.Size = new System.Drawing.Size(132, 25);
            this.txtFusemax.TabIndex = 42;
            // 
            // txtVolmax
            // 
            this.txtVolmax.Location = new System.Drawing.Point(675, 88);
            this.txtVolmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolmax.Name = "txtVolmax";
            this.txtVolmax.Size = new System.Drawing.Size(132, 25);
            this.txtVolmax.TabIndex = 41;
            // 
            // txtVoc
            // 
            this.txtVoc.Location = new System.Drawing.Point(152, 88);
            this.txtVoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoc.Name = "txtVoc";
            this.txtVoc.Size = new System.Drawing.Size(132, 25);
            this.txtVoc.TabIndex = 40;
            // 
            // txtVmp
            // 
            this.txtVmp.Location = new System.Drawing.Point(399, 88);
            this.txtVmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVmp.Name = "txtVmp";
            this.txtVmp.Size = new System.Drawing.Size(132, 25);
            this.txtVmp.TabIndex = 39;
            // 
            // txtPmax
            // 
            this.txtPmax.Location = new System.Drawing.Point(399, 30);
            this.txtPmax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPmax.Name = "txtPmax";
            this.txtPmax.Size = new System.Drawing.Size(132, 25);
            this.txtPmax.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fusemax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "档位上限";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Volmax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "档位下限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vmp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pmax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Voc\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "ProductType";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // PrintConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 950);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrintConfig";
            this.Text = "PrintConfig";
            this.Load += new System.EventHandler(this.PrintConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtImp1;
        private System.Windows.Forms.TextBox txtModuleApp;
        private System.Windows.Forms.TextBox txtIsc;
        private System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtLowerPower;
        private System.Windows.Forms.TextBox txtUpperPower;
        private System.Windows.Forms.TextBox txtFusemax;
        private System.Windows.Forms.TextBox txtVolmax;
        private System.Windows.Forms.TextBox txtVoc;
        private System.Windows.Forms.TextBox txtVmp;
        private System.Windows.Forms.TextBox txtPmax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.TextBox txtLowerE;
        private System.Windows.Forms.TextBox txtUpperE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox DLPD;
        private System.Windows.Forms.ComboBox cjxz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}