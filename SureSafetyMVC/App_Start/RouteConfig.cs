using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Web.Compilation;
using System.Web.UI;
using SureSafetyMVC.SSRS;

namespace SureSafetyMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add("ReportRoute", new Route(
                                        "reports/{reportname}", new ReportRouteHandler()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    public class ReportRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            String ReportName = requestContext.RouteData.Values["reportname"] as string;

            ReportViewerWebForm rvwf = BuildManager.CreateInstanceFromVirtualPath("~/SSRS/ReportViewerWebForm.aspx",
                typeof(Page)) as ReportViewerWebForm;

            rvwf.ReportServerURL = "http://142.55.32.96/reportserver";

            Dictionary<string, string> ReportList = new Dictionary<string, string>();

            ReportList.Add("lab6", "/Fall 2017/Irshaad Nizrudin/Lab6");
            //ReportList.Add("order", "/Fall 2017/Kanu Mohindra/Order Amount");

            rvwf.ReportPath = ReportList[ReportName.ToLower()];

            return rvwf;
        }
    }
}
