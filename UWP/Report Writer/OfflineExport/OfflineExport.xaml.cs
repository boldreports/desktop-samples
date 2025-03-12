using System;
using System.Collections.Generic;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Popups;
using System.Reflection;
using Windows.Storage.Streams;
using Windows.Storage.Pickers;
using Windows.Storage;

using BoldReports.Writer;
using Windows.UI.Xaml.Controls;

namespace ReportWriterSamples
{
    public sealed partial class OfflineExport : Page
    {
        public OfflineExport()
        {
            this.InitializeComponent();
        }

        async void Button_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker fileSavePicker = new FileSavePicker();
            WriterFormat format = WriterFormat.PDF;

            if (pdf.IsChecked == true)
            {
                fileSavePicker.FileTypeChoices.Add("PDF", new List<string> { ".pdf" });
                fileSavePicker.DefaultFileExtension = ".pdf";
                format = WriterFormat.PDF;
            }
            else if (excel.IsChecked == true)
            {
                fileSavePicker.FileTypeChoices.Add("Excel", new List<string> { ".xlsx" });
                fileSavePicker.DefaultFileExtension = ".xlsx";
                format = WriterFormat.Excel;
            }
            else if (word.IsChecked == true)
            {
                fileSavePicker.FileTypeChoices.Add("Word", new List<string> { ".docx" });
                fileSavePicker.DefaultFileExtension = ".docx";
                format = WriterFormat.Word;
            }
            else if (html.IsChecked == true)
            {
                fileSavePicker.FileTypeChoices.Add("Html", new List<string> { ".html" });
                fileSavePicker.DefaultFileExtension = ".html";
                format = WriterFormat.HTML;
            }

            fileSavePicker.SuggestedFileName = "ExportReport";
            var savedItem = await fileSavePicker.PickSaveFileAsync();

            if (savedItem != null)
            {
                MemoryStream exportFileStream = new MemoryStream();
                Assembly assembly = typeof(OfflineExport).GetTypeInfo().Assembly;
                Stream reportStream = assembly.GetManifestResourceStream("OfflineExport.ReportTemplate.Table_Summaries.rdlc");

                BoldReports.UI.Xaml.ReportDataSourceCollection datas = new BoldReports.UI.Xaml.ReportDataSourceCollection();
                datas.Add(new BoldReports.UI.Xaml.ReportDataSource { Name = "Sales", Value = ReportData.GetData() });

                ReportWriter writer = new ReportWriter(reportStream, datas);
                writer.ExportMode = ExportMode.Local;
                writer.ExportCompleted += Writer_ExportCompleted;
                await writer.SaveASync(exportFileStream, format);

                try
                {
                    using (IRandomAccessStream stream = await savedItem.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        // Write compressed data from memory to file
                        using (Stream outstream = stream.AsStreamForWrite())
                        {
                            byte[] buffer = exportFileStream.ToArray();
                            outstream.Write(buffer, 0, buffer.Length);
                            outstream.Flush();
                        }
                    }
                    exportFileStream.Dispose();
                }
                catch { }
            }
        }

        private void Writer_ExportCompleted(object sender, ExportCompletedEventArgs e)
        {
            MessageDialog msgDialog = new MessageDialog("Report exporting completed successfully");
            msgDialog.ShowAsync();
        }
    }
}