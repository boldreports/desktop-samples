using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace RDLReportSample
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            string license = System.IO.File.ReadAllText(Server.MapPath("BoldLicense.txt"), System.Text.Encoding.UTF8);
            Bold.Licensing.BoldLicenseProvider.RegisterLicense(license);
            System.Web.Http.GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional });

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
        }        
    }
}