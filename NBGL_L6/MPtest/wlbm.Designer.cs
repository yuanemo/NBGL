namespace MPtest
{
    partial class wlbm
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtlhid = new System.Windows.Forms.TextBox();
            this.txtcpmc = new System.Windows.Forms.TextBox();
            this.txtlhdm = new System.Windows.Forms.TextBox();
            this.txtlhlx = new System.Windows.Forms.TextBox();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.txtpx = new System.Windows.Forms.TextBox();
            this.txtytms = new System.Windows.Forms.TextBox();
            this.txtms = new System.Windows.Forms.TextBox();
            this.txtcwlx = new System.Windows.Forms.TextBox();
            this.txtgg = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 168);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 27;
            this.grd.Size = new System.Drawing.Size(1409, 387);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "料号ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "料号类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "料号代码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "产品名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "规格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "财务类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(837, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "描述";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "用途描述";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1158, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "排序";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1306, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "是否启用";
            // 
            // txtlhid
            // 
            this.txtlhid.Location = new System.Drawing.Point(154, 26);
            this.txtlhid.Name = "txtlhid";
            this.txtlhid.ReadOnly = true;
            this.txtlhid.Size = new System.Drawing.Size(171, 25);
            this.txtlhid.TabIndex = 12;
            // 
            // txtcpmc
            // 
            this.txtcpmc.Location = new System.Drawing.Point(576, 73);
            this.txtcpmc.Name = "txtcpmc";
            this.txtcpmc.Size = new System.Drawing.Size(177, 25);
            this.txtcpmc.TabIndex = 13;
            // 
            // txtlhdm
            // 
            this.txtlhdm.Location = new System.Drawing.Point(576, 26);
            this.txtlhdm.Name = "txtlhdm";
            this.txtlhdm.Size = new System.Drawing.Size(177, 25);
            this.txtlhdm.TabIndex = 14;
            // 
            // txtlhlx
            // 
            this.txtlhlx.Location = new System.Drawing.Point(154, 119);
            this.txtlhlx.Name = "txtlhlx";
            this.txtlhlx.Size = new System.Drawing.Size(171, 25);
            this.txtlhlx.TabIndex = 15;
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(154, 70);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(171, 25);
            this.txtkh.TabIndex = 16;
            // 
            // txtpx
            // 
            this.txtpx.Location = new System.Drawing.Point(1241, 26);
            this.txtpx.Name = "txtpx";
            this.txtpx.Size = new System.Drawing.Size(156, 25);
            this.txtpx.TabIndex = 17;
            // 
            // txtytms
            // 
            this.txtytms.Location = new System.Drawing.Point(938, 119);
            this.txtytms.Name = "txtytms";
            this.txtytms.Size = new System.Drawing.Size(169, 25);
            this.txtytms.TabIndex = 18;
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(938, 70);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(169, 25);
            this.txtms.TabIndex = 19;
            // 
            // txtcwlx
            // 
            this.txtcwlx.Location = new System.Drawing.Point(938, 26);
            this.txtcwlx.Name = "txtcwlx";
            this.txtcwlx.Size = new System.Drawing.Size(169, 25);
            this.txtcwlx.TabIndex = 20;
            // 
            // txtgg
            // 
            this.txtgg.Location = new System.Drawing.Point(576, 119);
            this.txtgg.Name = "txtgg";
            this.txtgg.Size = new System.Drawing.Size(177, 25);
            this.txtgg.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1379, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1322, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wlbm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtgg);
            this.Controls.Add(this.txtcwlx);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.txtytms);
            this.Controls.Add(this.txtpx);
            this.Controls.Add(this.txtkh);
            this.Controls.Add(this.txtlhlx);
            this.Controls.Add(this.txtlhdm);
            this.Controls.Add(this.txtcpmc);
            this.Controls.Add(this.txtlhid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd);
            this.Name = "wlbm";
            this.Text = "wlbm";
            this.Load += new System.EventHandler(this.wlbm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtlhid;
        private System.Windows.Forms.TextBox txtcpmc;
        private System.Windows.Forms.TextBox txtlhdm;
        private System.Windows.Forms.TextBox txtlhlx;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.TextBox txtpx;
        private System.Windows.Forms.TextBox txtytms;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.TextBox txtcwlx;
        private System.Windows.Forms.TextBox txtgg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}