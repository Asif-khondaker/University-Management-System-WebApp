<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUpdateUI.aspx.cs" Inherits="University_Management_System.UI.UpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
            <table>
                <tr>
                    <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
                    </td>
                    <td class="auto-style1">
                    <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                </tr>
           
                <tr>
                    <td>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:HiddenField ID="idHiddenField" runat="server" />
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
          
                <tr>
                    <td>
                        Contact No

                    </td>
                    <td>
                    <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
            
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
            
                <tr>
                    <td>
                    <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
           
                <tr>
                    <td>
                    <asp:Label ID="Label6" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="departmentsDropDownList" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="messageLabel" runat="server"></asp:Label> 

                    </td>
                </tr>
            </table>
                
        </div>
        <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="~/UI/HomeUI.aspx">Home</asp:HyperLink>
    </form>
</body>
</html>
