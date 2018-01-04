<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewerWebForm.aspx.cs" Inherits="SureSafetyMVC.SSRS.ReportViewerWebForm" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 343px;
            width: 1119px;
            margin-bottom: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Remote" Width="1116px">
            </rsweb:ReportViewer>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
