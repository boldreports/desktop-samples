
using BoldReports.UI.Xaml;
using System.IO;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace QueryParameter
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
            Stream reportStream = assembly.GetManifestResourceStream("QueryParameter.ReportTemplate.Query Parameter.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.ReportLoaded += ReportViewer_ReportLoaded;
            this.ReportViewer.ViewButtonClick += ReportViewer_Click;
            this.ReportViewer.RefreshReport();
        }

        private void ReportViewer_ReportLoaded(object sender, System.EventArgs e)
        {
            this.ReportViewer.SetParameters(ReportData.GetParameter());

            UpdateDatasource();
        }

        private void ReportViewer_Click(object sender, System.EventArgs e)
        {
            UpdateDatasource();
        }

        private void UpdateDatasource()
        {
            ReportParameterInfoCollection paramCollection = this.ReportViewer.GetParameters();
            string value = paramCollection.Where(p => p.Name.Equals("InvoiceID")).FirstOrDefault().Values.FirstOrDefault();

            if (!string.IsNullOrEmpty(value))
            {
                this.ReportViewer.DataSources.Clear();
                this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "ShipDetails", Value = ReportData.ShipDetails.GetData(value) });
                this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "OrderDetails", Value = ReportData.OrderDetails.GetData(value) });
                this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "InvoiceDetails", Value = ReportData.InvoiceDetails.GetData(value) });
            }
        }
    }
}
