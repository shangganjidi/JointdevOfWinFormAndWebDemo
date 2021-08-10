# JointdevOfWinFormAndWebDemo
WinForm与Web网页联合开发控件Demo

一，各浏览器内核：
（1）Trident：IE 6、7、8，傲游（双核心）、 QQ浏览器（双核心）、360浏览器（双核心）；

（2）EdgeHTML：Chakra，Edge和其他UWP浏览器使用；

（3）webkit：Mac-Safari；谷歌浏览器（Blink基于webkit）、傲游浏览器3.0、搜狗浏览器V2.0Beta、360极速浏览器（双核心）、 QQ浏览器（双核心）、Opera、Andriod内置引擎。

（4）Gecko：Mozilla Firefox（火狐浏览器） 等使用；

二，Demo(WinForm+各内核库)
（1）WebBrowserPage：控件为WebBrowser(Trident)

　　demo里的明显缺点：对H5等新技术的支持性差。

（2）WebKitPage：控件为webKitBrowser（webkit）

　　(a)下载实例项目https://github.com/Erls-Corporation/open-webkit-sharp，复制Core与References文件下的内容到bin中，控件dll在Binary里,详细见官方说明文档。

　　demo里的明显缺陷：默认基本不支持页面的javascript语句，如弹窗。

（3）CEFPage：控件为webKitBrowser（Chromium Embedded Framework，基于webkit内核）

　　(a)下载“CefSharp.WinForms”Net包

　　demo接近谷歌原生浏览器。

（4）Gecko：

　　(a)下载"WebDriver.GeckoDriver"Net包（“Selenium.WebDrive.GeckoDriver”Net包不太会用）

　　demo里的已知问题：学习资料有点少，某些javascript语句不支持（并不多）。
