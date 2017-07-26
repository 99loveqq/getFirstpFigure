namespace 导首图
{
    partial class Form1
    {
            /// <summary>
            /// 必需的设计器变量。
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// 清理所有正在使用的资源。
            /// </summary>
            /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows 窗体设计器生成的代码

            /// <summary>
            /// 设计器支持所需的方法 - 不要
            /// 使用代码编辑器修改此方法的内容。
            /// </summary>
            private void InitializeComponent()
            {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuoQu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.liv = new System.Windows.Forms.ListView();
            this.标题 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.网址 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtLuJing = new System.Windows.Forms.TextBox();
            this.txtWjm = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.btnLiuL = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnQingKong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(131, 12);
            this.txtUrl.MaxLength = 1000000;
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(598, 76);
            this.txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入获取图片信息";
            // 
            // btnHuoQu
            // 
            this.btnHuoQu.Location = new System.Drawing.Point(755, 29);
            this.btnHuoQu.Name = "btnHuoQu";
            this.btnHuoQu.Size = new System.Drawing.Size(75, 23);
            this.btnHuoQu.TabIndex = 2;
            this.btnHuoQu.Text = "获  取";
            this.btnHuoQu.UseVisualStyleBackColor = true;
            this.btnHuoQu.Click += new System.EventHandler(this.btnHuoQu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "111";
            // 
            // liv
            // 
            this.liv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.标题,
            this.网址});
            this.liv.GridLines = true;
            this.liv.Location = new System.Drawing.Point(14, 100);
            this.liv.Name = "liv";
            this.liv.Size = new System.Drawing.Size(858, 268);
            this.liv.TabIndex = 4;
            this.liv.UseCompatibleStateImageBehavior = false;
            this.liv.View = System.Windows.Forms.View.Details;
            // 
            // 标题
            // 
            this.标题.Tag = "";
            this.标题.Text = "标题";
            this.标题.Width = 412;
            // 
            // 网址
            // 
            this.网址.Text = "网址";
            this.网址.Width = 436;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "文件夹名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "进度条";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(836, 438);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(11, 12);
            this.lblMax.TabIndex = 9;
            this.lblMax.Text = "0";
            // 
            // txtLuJing
            // 
            this.txtLuJing.Location = new System.Drawing.Point(47, 391);
            this.txtLuJing.Name = "txtLuJing";
            this.txtLuJing.ReadOnly = true;
            this.txtLuJing.Size = new System.Drawing.Size(251, 21);
            this.txtLuJing.TabIndex = 10;
            // 
            // txtWjm
            // 
            this.txtWjm.Location = new System.Drawing.Point(363, 391);
            this.txtWjm.Name = "txtWjm";
            this.txtWjm.Size = new System.Drawing.Size(245, 21);
            this.txtWjm.TabIndex = 11;
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(74, 431);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(756, 23);
            this.pbr.TabIndex = 12;
            // 
            // btnLiuL
            // 
            this.btnLiuL.Location = new System.Drawing.Point(614, 389);
            this.btnLiuL.Name = "btnLiuL";
            this.btnLiuL.Size = new System.Drawing.Size(75, 23);
            this.btnLiuL.TabIndex = 13;
            this.btnLiuL.Text = "浏览";
            this.btnLiuL.UseVisualStyleBackColor = true;
            this.btnLiuL.Click += new System.EventHandler(this.btnLiuL_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(699, 389);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDownLoad.TabIndex = 14;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnQingKong
            // 
            this.btnQingKong.Location = new System.Drawing.Point(787, 389);
            this.btnQingKong.Name = "btnQingKong";
            this.btnQingKong.Size = new System.Drawing.Size(75, 23);
            this.btnQingKong.TabIndex = 15;
            this.btnQingKong.Text = "清空";
            this.btnQingKong.UseVisualStyleBackColor = true;
            this.btnQingKong.Click += new System.EventHandler(this.btnQingKong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 477);
            this.Controls.Add(this.btnQingKong);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnLiuL);
            this.Controls.Add(this.pbr);
            this.Controls.Add(this.txtWjm);
            this.Controls.Add(this.txtLuJing);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuoQu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导首图2.05.24";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox txtUrl;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button btnHuoQu;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.ListView liv;
            private System.Windows.Forms.ColumnHeader 标题;
            private System.Windows.Forms.ColumnHeader 网址;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label lblMax;
            private System.Windows.Forms.TextBox txtLuJing;
            private System.Windows.Forms.TextBox txtWjm;
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
            private System.Windows.Forms.ProgressBar pbr;
            private System.Windows.Forms.Button btnLiuL;
            private System.Windows.Forms.Button btnDownLoad;
            private System.Windows.Forms.Button btnQingKong;
    }
}

