
using BoldReports.UI.Xaml;
using System.IO;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PivotTable
{
    public sealed partial class ReportViewerPage : Page
    {
        public ReportViewerPage()
        {
            this.InitializeComponent();
            this.Loaded += ReportViewerPage_Loaded;
        }

        private void ReportViewerPage_Loaded(object sender, RoutedEventArgs e)
        {
            Assembly assembly = typeof(ReportViewerPage).GetTypeInfo().Assembly;
            Stream reportStream = assembly.GetManifestResourceStream("PivotTable.ReportTemplate.Pivot Table.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.ReportLoaded += ReportViewer_ReportLoaded;
            this.ReportViewer.RefreshReport();
        }

        private void ReportViewer_ReportLoaded(object sender, System.EventArgs e)
        {
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "Sales", Value = ReportData.GetData() });
        }
    }
}