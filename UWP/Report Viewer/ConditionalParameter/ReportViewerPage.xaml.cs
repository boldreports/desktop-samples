
using BoldReports.UI.Xaml;
using System.IO;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ConditionalParameter
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
            Stream reportStream = assembly.GetManifestResourceStream("ConditionalParameter.ReportTemplate.Conditional Parameter.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "OrderSummary", Value = ReportData.GetOrderSummary() });
            this.ReportViewer.RefreshReport();
        }
    }
}
