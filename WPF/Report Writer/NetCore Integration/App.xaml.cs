using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WriterDemo_NETCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            string licenseFilePath = new FileInfo(@"../../../../../../Common/BoldLicense/BoldLicense.txt").FullName;

            if (File.Exists(licenseFilePath))
            {
                string licenseKey = File.ReadAllText(licenseFilePath, System.Text.Encoding.UTF8);
                Bold.Licensing.BoldLicenseProvider.RegisterLicense(licenseKey, isOfflineValidation: false);
            }
        }
    }
}
