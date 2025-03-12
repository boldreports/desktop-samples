using System.Windows;
using System.Windows.Input;
using System.Net;
using System.IO;
using BoldReports.UI.Xaml;
using BoldReports.Windows;

namespace BoldReports.Samples.ViewModel
{
    public class ReportViewModel 
    {
        public ReportModel Report { get; set; }
           
        #region Constructor

        public ReportViewModel()
        {
            this.Report = new ReportModel();
            this.Report.ReportPath = this.GetFullPath("Company Sales.rdlc");
        }

        public void Loaded(object sender, RoutedEventArgs e)
        {
            Window mainWindow = sender as Window;
            ReportViewer viewer= mainWindow.FindName("viewer") as ReportViewer;
            viewer.DataSources.Add(new ReportDataSource("Sales", new CompanySalesDemo.AdventureWorks().GetDataTable()));
            viewer.RefreshReport();
        }

        private string GetFullPath(string report)
        {
            string templateDirectory = @"../../../../../../Common/Data/ReportTemplate/RDLC";
            string dir = new DirectoryInfo(templateDirectory).FullName;
            return System.IO.Path.Combine(dir, report);  
        }

        #endregion
    }
}
