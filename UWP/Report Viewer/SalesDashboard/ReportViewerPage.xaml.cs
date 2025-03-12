
using BoldReports.UI.Xaml;
using System.IO;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SalesDashboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
            Stream reportStream = assembly.GetManifestResourceStream("SalesDashboard.ReportTemplate.Sales Dashboard.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.ReportLoaded += ReportViewer_ReportLoaded;
            this.ReportViewer.ViewButtonClick += ReportViewer_Click;
            this.ReportViewer.RefreshReport();
        }

        private void ReportViewer_ReportLoaded(object sender, System.EventArgs e)
        {
            //Set report parameters
            this.ReportViewer.SetParameters(ReportData.GetParameters());

            //Set report datasources
            UpdateDatasource();
        }

        private void ReportViewer_Click(object sender, System.EventArgs e)
        {
            UpdateDatasource();
        }

        private void UpdateDatasource()
        {
            ReportParameterInfoCollection paramCollection = this.ReportViewer.GetParameters();
            string Year = paramCollection.Where(p => p.Name.Equals("SalesYearParameter")).FirstOrDefault().Values.FirstOrDefault();
            this.ReportViewer.DataSources.Clear();
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "TopSalesPerson", Value = ReportData.SalesPersons.GetTopSalesPerson(int.Parse(Year)) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "TopStores", Value = ReportData.Stores.GetTopStores(int.Parse(Year)) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "TopProduct", Value = ReportData.Products.GetTopProducts(int.Parse(Year)) });
        }
    }
}
