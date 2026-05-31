using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewerDemo_NetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.reportViewer.ReportPath = this.GetFullPath("GroupingAgg.rdl");
            this.reportViewer.RefreshReport();
        }

        private string GetFullPath(string report)
        {
            string templateDirectory = @"../../../../../../Common/Data/ReportTemplate/";
            string dir = new DirectoryInfo(templateDirectory).FullName;
            return System.IO.Path.Combine(dir, report);
        }
    }
}
