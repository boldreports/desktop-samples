using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ReportServer_Report
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.ReportViewer.ReportServiceURL = @"https://on-premise-demo.boldreports.com/reporting/reportservice/api/Viewer/";
            this.ReportViewer.ReportServerUrl = @"https://on-premise-demo.boldreports.com/reporting/api/site/site1";
            this.ReportViewer.ServiceAuthorizationToken = GenerateToken("guest@boldreports.com", "Guest123@BoldReports!");

            this.ReportViewer.ReportServiceRequestBegin += (sen, arg) =>
            {
                arg.HttpClient.DefaultRequestHeaders.Add("serverurl", "https://on-premise-demo.boldreports.com/reporting/api/site/site1");
            };

            this.ReportViewer.ReportPath = @"/Tutorial Sample/Hyperlink";
            this.ReportViewer.RefreshReport();
        }

        public string GenerateToken(string userName, string password)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();

                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password)
                  });

                var result = client.PostAsync("https://on-premise-demo.boldreports.com/reporting/api/site/site1/token", content).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                var token = JsonConvert.DeserializeObject<Token>(resultContent);
                return token.token_type + " " + token.access_token;
            }
        }
    }

    public class Token
    {
        public string access_token { get; set; }

        public string token_type { get; set; }

        public string expires_in { get; set; }

        public string userName { get; set; }

        public string serverUrl { get; set; }

        public string password { get; set; }

    }
}
