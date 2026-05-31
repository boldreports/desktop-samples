using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Windows;

namespace BoldReportsWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string htmlPath = currentDir+ @"\wwwroot\index.html";
            await webView.EnsureCoreWebView2Async(null);
            webView.Source = new Uri(htmlPath);
        }
    }
}