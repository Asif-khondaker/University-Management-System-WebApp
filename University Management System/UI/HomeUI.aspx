<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="University_Management_System.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="studentEntryHyperLink" runat="server" NavigateUrl="~/UI/StudentEntryUI.aspx">Student Entry</asp:HyperLink>
        
            <br />
        
            <asp:HyperLink ID="viewAllHyperLink" runat="server" NavigateUrl="~/UI/ViewAllStudentsUI.aspx">View All</asp:HyperLink>
            
            <br />
            
            <asp:HyperLink ID="StudentUpdateHyperLink" runat="server" NavigateUrl="~/UI/StudentUpdateUI.aspx">Student Update</asp:HyperLink>
        </div>
    </form>
</body>
</html>
