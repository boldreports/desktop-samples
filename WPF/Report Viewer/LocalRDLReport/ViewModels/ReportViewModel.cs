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

namespace BoldReports.Samples.ViewModel
{
    public class ReportViewModel 
    {
        public ReportModel Report { get; set; }
           
        #region Constructor

        public ReportViewModel()
        {
            this.Report = new ReportModel();
            this.Report.ReportPath = this.GetFullPath("GroupingAgg.rdl");
        }

        public void Loaded(object sender, RoutedEventArgs e)
        {
            Window mainWindow = sender as Window;
            
            ReportViewer viewer= mainWindow.FindName("viewer") as ReportViewer;
            viewer.RefreshReport();
        }

        private string GetFullPath(string report)
        {
            string templateDirectory = @"../../ReportTemplate";
            string dir = new DirectoryInfo(templateDirectory).FullName;
            return System.IO.Path.Combine(dir, report);  
        }

        #endregion
    }
}
