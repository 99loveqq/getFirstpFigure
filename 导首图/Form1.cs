using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace 导首图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //获取指定网页的HTML代码
        static string GetPageSource(string URL)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;

            Encoding enc = Encoding.GetEncoding("GBK");
            Byte[] pageData = wc.DownloadData(URL);
            string x = enc.GetString(pageData);
            return x;
        }
        //获取图片对应的字符串
        static ArrayList GetH(string htmlCode)
        {
            ArrayList al = new ArrayList();
            string strRegex = string.Format(@"target=""_blank""><img src=""https://[\w\W]*?<i title=""修改标题""");
            Regex r = new Regex(strRegex, RegexOptions.IgnoreCase);
            MatchCollection m = r.Matches(htmlCode);
            for (int i = 0; i < m.Count; i++)
            {
                bool rep = false;
                string strNew = m[i].ToString();
                // 过滤重复的URL
                foreach (string str in al)
                {
                    if (strNew == str)
                    {
                        rep = true;
                        break;
                    }
                }
                if (!rep) al.Add(strNew);
            }
            al.Sort();
            return al;
        }
        string path = "E:";//文件路径  

        //清空、初始
        private void btnQingKong_Click(object sender, EventArgs e)
        {
            liv.Items.Clear();
            label3.Text = string.Format("总共有{0}张图片可下载", this.liv.Items.Count.ToString());
            pbr.Value = 0;
            lblMax.Text = "0";
        }

        //下载图片
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            //pbr=new ProgressBar();
            pbr.Maximum = this.liv.Items.Count;
            if (txtLuJing.Text.Trim() == "")
            { MessageBox.Show("请选择路劲", "提示"); }
            else
            {
                if (txtWjm.Text.Trim() == "")
                {
                    MessageBox.Show("请输入文件夹名", "提示");
                    txtWjm.Text = "";
                    txtWjm.Focus();
                }
                else
                {
                    int downnum = 0;
                    string path = string.Format(this.path + "\\" + txtWjm.Text + "\\");
                    System.IO.Directory.CreateDirectory(path);
                    WebClient client = new WebClient();
                    string except_chars = ": \\ / * ? \" > < |";
                    int a = 0;
                    for (int i = 0; i < liv.Items.Count; i++)
                    {
                        string strName = this.liv.Items[i].Text.ToString();
                        strName = Regex.Replace(strName, "[" + Regex.Escape(except_chars) + "]", " ");
                        string strUrl = this.liv.Items[i].SubItems[1].Text.ToString();
                        strUrl = strUrl.Replace(".100x100xz.", ".");
                        try
                        {
                            client.DownloadFile(strUrl, path + System.IO.Path.GetFileName(strName + ".jpg"));
                            downnum++;
                            a = 0;
                        }
                        catch (Exception)
                        {
                            i--;
                            a++;
                            if (a == 3)
                            {
                                i++;
                            }
                        }
                        pbr.Value = i + 1;
                    }
                    string num = string.Format("成功下载了{0}张首图", downnum);
                    MessageBox.Show(num, "提示");
                }
            }
        }

        //获取用户选中路径
        private void btnLiuL_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = this.folderBrowserDialog.SelectedPath;
                txtLuJing.Text = path;
            }
        }

        //获取代码链接
        private void btnHuoQu_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Trim() == "")
            {
                MessageBox.Show("请输入代码", "提示");
                txtUrl.Focus();
            }
            else
            {
                string x = txtUrl.Text;
                ArrayList url = GetH(x);

                for (int i = 0; i < url.Count; i++)
                {
                    string str = url[i].ToString();
                    int a = str.IndexOf("img src=\"")+9;
                    int b = str.IndexOf("\" alt=\"\">");
                    string strUrl = str.Substring(a, b - a);
                    int d = str.IndexOf("\" target=\"_blank\">")+18;
                    string f = str.Substring(d , str.Length - d-19);
                    string strName = string.Format(f);
                    ListViewItem liv = new ListViewItem(strName);
                    liv.SubItems.Add(strUrl);
                    this.liv.Items.Add(liv);
                    //过滤相同图片链接
                    for (int k = 1; k < this.liv.Items.Count - 1; k++)
                    {
                        for (int j = k + 1; j < this.liv.Items.Count; j++)
                        {
                            if (this.liv.Items[k].SubItems[1].Text.Trim() == this.liv.Items[j].SubItems[1].Text.Trim())
                            {
                                this.liv.Items.Remove(this.liv.Items[j]);
                            }
                        }
                    }
                    for (int k = 1; k < this.liv.Items.Count - 1; k++)
                    {
                        for (int j = k + 1; j < this.liv.Items.Count; j++)
                        {
                            if (this.liv.Items[k].SubItems[0].Text.Trim() == this.liv.Items[j].SubItems[0].Text.Trim())
                            {
                                this.liv.Items[j].SubItems[0].Text = this.liv.Items[j].SubItems[0].Text + "-1";
                            }
                        }
                    }
                }
            }
            label3.Text = string.Format("总共有{0}张图片可下载", this.liv.Items.Count.ToString());
            txtUrl.Text = "";
            txtUrl.Focus();
            lblMax.Text = this.liv.Items.Count.ToString();
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "总共有0张图片可下载";
            DateTime DT = System.DateTime.Now;
            string dt = System.DateTime.Now.ToShortDateString();
            dt = dt.Substring(5, dt.Length - 5);
            dt = dt.Replace("/", ".");
            txtWjm.Text = string.Format("{0}【整单首图】公司名-姓名", dt);
        }
    }
}
