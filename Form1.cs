using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebViewSys
{
    public partial class Form1 : Form
    {
        private WebView2 webView;

        public Form1(string url, bool hideTitlebar, bool kioskMode, string iconPath, string windowTitle, Size? customSize)
        {
            this.Text = windowTitle;

            if (hideTitlebar)
                this.FormBorderStyle = FormBorderStyle.None;

            if (kioskMode)
                this.WindowState = FormWindowState.Maximized;
            else
                this.Size = customSize ?? new Size(1280, 720);

            if (!string.IsNullOrEmpty(iconPath) && System.IO.File.Exists(iconPath))
                this.Icon = new Icon(iconPath);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            webView = new WebView2 { Dock = DockStyle.Fill };
            webView.KeyDown += WebView_KeyDown;
            webView.Source = new Uri(url);
            Controls.Add(webView);
        }

        private void WebView_KeyDown(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
