using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JointdevOfWinFormAndWebDemo
{
    public partial class WebBrowserPage : Form
    {
        public WebBrowserPage()
        {
            InitializeComponent();
        }

        private void WebBrowserPage_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.baidu.com/");
        }
    }
}
