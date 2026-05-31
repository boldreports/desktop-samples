
using System.IO;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Linq;
using BoldReports.UI.Xaml;

namespace SalesOrderDetails
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
            Stream reportStream = assembly.GetManifestResourceStream("SalesOrderDetails.ReportTemplate.SalesOrderDetails.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.ReportLoaded += ReportViewer_ReportLoaded;
            this.ReportViewer.ViewButtonClick += ReportViewer_Click;
            this.ReportViewer.RefreshReport();
        }

        private void ReportViewer_ReportLoaded(object sender, System.EventArgs e)
        {
            this.ReportViewer.SetParameters(ReportData.GetParameters());
            UpdateDatasource();
        }

        private void ReportViewer_Click(object sender, System.EventArgs e)
        {
            UpdateDatasource();
        }

        private void UpdateDatasource()
        {
            ReportParameterInfoCollection paramCollection = this.ReportViewer.GetParameters();
            string salesOrderNumber = paramCollection.Where(param => param.Name.Equals("SalesOrderNumber")).FirstOrDefault().Values.FirstOrDefault();
            this.ReportViewer.DataSources.Clear();
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "SalesOrder", Value = ReportData.SalesOrder.GetsalesOrderDetail(salesOrderNumber) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "SalesOrderDetail", Value = ReportData.SalesOrderDetail.GetsalesOrderDetail(salesOrderNumber.TrimStart("SO".ToCharArray())) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "SalesOrderNumber", Value = ReportData.SalesOrderNumbers.GetSalesOrderNumbers() });
        }
    }
}