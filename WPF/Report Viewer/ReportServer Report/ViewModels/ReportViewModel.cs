#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using BoldReports.UI.Xaml;
using System.Text;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using ReportServer;

namespace BoldReports.Samples.ViewModel
{
    public class ReportViewModel
    {
        public ReportModel Report { get; set; }

        #region Constructor

        public ReportViewModel()
        {
            this.Report = new ReportModel();
            //this.Report.ReportPath = this.GetFullPath("GroupingAgg.rdl");
        }

        public void Loaded(object sender, RoutedEventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Window mainWindow = sender as Window;

                ReportViewer viewer = mainWindow.FindName("viewer") as ReportViewer;
                viewer.ProcessingMode = ProcessingMode.Remote;
                viewer.ReportServerUrl = @"https://on-premise-demo.boldreports.com/reporting/api/site/site1/";
                viewer.ReportServer = new ReportingServerExt();
                viewer.ReportServerCredential = new System.Net.NetworkCredential("guest@boldreports.com", "Guest123@BoldReports!");
                viewer.ReportPath = @"/Tutorial Sample/Hyperlink";
                viewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Internet connection is required to run this sample", "Report Server", MessageBoxButton.OK);
            }

        }
        #endregion
    }
}
