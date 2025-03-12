using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
using BoldReports.Web.ReportViewer;

namespace Mvc_Sample
{
    public class RDLReportController : ApiController, IReportController
    {
        public object PostReportAction(Dictionary<string, object> jsonResult)
        {
            return ReportHelper.ProcessReport(jsonResult, this);
        }

        //Get action for getting resources from the report
        [System.Web.Http.ActionName("GetResource")]

        [AcceptVerbs("GET")]
        public object GetResource(string key, string resourcetype, bool isPrint)
        {
            return ReportHelper.GetResource(key, resourcetype, isPrint);
        }

        //Method will be called when initialize the report options before start processing the report
        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            //You can update report options here
        }

        //Method will be called when reported is loaded
        public void OnReportLoaded(ReportViewerOptions reportOption)
        {

        }
    }
}