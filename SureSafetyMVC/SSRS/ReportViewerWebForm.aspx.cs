﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SureSafetyMVC.SSRS
{
    public partial class ReportViewerWebForm : System.Web.UI.Page
    {
        public string ReportServerURL { get; set; }
        public string ReportPath { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ServerReport.ReportServerUrl = new Uri(ReportServerURL);
            ReportViewer1.ServerReport.ReportPath = ReportPath;
        }
    }
}