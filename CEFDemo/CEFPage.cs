using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEFDemo
{
    /// <summary>
    /// Helper类见文章： https://www.cnblogs.com/tuyile006/p/13852630.html
    /// </summary>
    public partial class CEFPage : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public CEFPage()
        {
            InitializeComponent();
        }

        private void CEFPage_Load(object sender, EventArgs e)
        {
            // 避免页面加载不出来, 建议加上这句
            Cef.Initialize(new CefSettings());

            chromeBrowser = new ChromiumWebBrowser("https://www.baidu.com/")
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(chromeBrowser);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
