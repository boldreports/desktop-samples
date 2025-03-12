
using System.IO;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using System.Linq;
using BoldReports.UI.Xaml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductLineSales
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
            Stream reportStream = assembly.GetManifestResourceStream("ProductLineSales.ReportTemplate.ProductLineSales.rdlc");
            this.ReportViewer.ProcessingMode = BoldReports.UI.Xaml.ProcessingMode.Local;
            this.ReportViewer.LoadReport(reportStream);
            this.ReportViewer.ReportLoaded += ReportViewer_ReportLoaded;
            this.ReportViewer.ViewButtonClick += ReportViewer_Click;
            this.ReportViewer.RefreshReport();
        }

        private void ReportViewer_ReportLoaded(object sender, System.EventArgs e)
        {
            //Set report parameters
            this.ReportViewer.SetParameters(ProductLineSales.GetParameters());

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
            string productCategory = "1";
            string subCategory = paramCollection.Where(p => p.Name.Equals("ProductSubcategory")).FirstOrDefault().Values.FirstOrDefault();
            string startDate = paramCollection.Where(p => p.Name.Equals("StartDate")).FirstOrDefault().Values.FirstOrDefault();
            string endDate = paramCollection.Where(p => p.Name.Equals("EndDate")).FirstOrDefault().Values.FirstOrDefault();
            this.ReportViewer.DataSources.Clear();
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "TopEmployees", Value = ProductLineSales.Employee.GetTopEmployees(productCategory, subCategory, DateTime.Parse(startDate), DateTime.Parse(endDate)) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "ProductCategories", Value = ProductLineSales.ProductCategory.GetProductCategories() });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "TopCustomers", Value = ProductLineSales.Customer.GetTopCustomers(productCategory, subCategory, DateTime.Parse(startDate), DateTime.Parse(endDate)) });
            this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "ProductSubcategories", Value = ProductLineSales.SubCategory.GetProductSubCategories() });
        }
    }
}
