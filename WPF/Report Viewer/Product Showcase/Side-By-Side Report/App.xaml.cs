﻿#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
#endregion
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.IO;

namespace CircularGaugeDemo
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
