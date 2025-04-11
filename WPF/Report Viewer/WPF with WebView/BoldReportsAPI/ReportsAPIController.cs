using BoldReports.Web.ReportViewer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BoldReports.Web;
using Microsoft.AspNetCore.Cors;

namespace BoldReportsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [EnableCors]
    public class ReportController : ControllerBase, IReportController, IReportHelperSettings
    {
        private Microsoft.Extensions.Caching.Memory.IMemoryCache _cache;
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _hostingEnvironment;


        public ReportController(Microsoft.Extensions.Caching.Memory.IMemoryCache memoryCache, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment)
        {
            _cache = memoryCache;
            _hostingEnvironment = hostingEnvironment;
        }

        public void InitializeSettings(ReportHelperSettings helperSettings)
        {

        }

        [HttpPost, HttpGet]
        public object PostReportAction([FromBody] Dictionary<string, object> jsonResult)
        {
            bool isClearCache = false;

            if (jsonResult != null && jsonResult.ContainsKey("reportAction") && jsonResult["reportAction"].ToString() == "ClearCache")
            {
                isClearCache = true;
            }

            var result = ReportHelper.ProcessReport(jsonResult, this, this._cache);

            if (isClearCache)
            {
                GC.Collect();
                GC.Collect(1, GCCollectionMode.Forced, true);
                GC.Collect(2, GCCollectionMode.Forced, true);
                // Define the log file path
                string logFilePath = "log.txt";

                // Log message
                string logMessage = $"Cache cleared[{DateTime.Now}]";

                // Write log to the file
                WriteLog(logFilePath, logMessage);
                isClearCache = false;
            }

            return result;
        }

        static void WriteLog(string filePath, string message)
        {
            try
            {
                // Append the log message to the file
                System.IO.File.AppendAllText(filePath, message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log: {ex.Message}");
            }
        }

        [ActionName("GetResource")]
        [AcceptVerbs("GET")]
        [AllowAnonymous]
        public object GetResource(ReportResource resource)
        {
            return ReportHelper.GetResource(resource, this, _cache);
        }

        [HttpPost]
        [AllowAnonymous]
        public object PostFormReportAction()
        {
            return ReportHelper.ProcessReport(null, this, this._cache);
        }

        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            // Here, we have loaded the sales-order-detail.rdl report from application the folder wwwroot\Resources. sales-order-detail.rdl should be there in wwwroot\Resources application folder.
            FileStream inputStream = new FileStream(basePath + reportOption.ReportModel.ReportPath, FileMode.Open, FileAccess.Read);
            MemoryStream reportStream = new MemoryStream();
            inputStream.CopyTo(reportStream);
            reportStream.Position = 0;
            inputStream.Close();
            reportOption.ReportModel.Stream = reportStream;

        }

        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
        }
    }
}