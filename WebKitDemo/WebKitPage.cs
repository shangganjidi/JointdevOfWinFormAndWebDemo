using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebKitDemo
{
    public partial class WebKitPage : Form
    {
        public WebKitPage()
        {
            InitializeComponent();
            webKitBrowser1.UseJavaScript = true;
        }

        private void WebKitPage_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("https://www.baidu.com/");
        }
    }
}
