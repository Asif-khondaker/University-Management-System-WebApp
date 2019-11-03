<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllStudentsUI.aspx.cs" Inherits="University_Management_System.UI.ViewAllStudentsUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="studentsGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                    <asp:TemplateField HeaderText="Registration Number">
                        <ItemTemplate>

                            <asp:HiddenField runat="server" ID="idHiddenField" Value='<%#Eval("StudentId") %>'/>

                            <asp:Label runat="server" Text='<%#Eval("RegistrationNo") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("StudentName") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Email") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Contact">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("ContactNumber") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Address") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DepartmentName">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("DepartmentName") %>'>"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="updateLinkButton" OnClick="updateLinkButton_Click" Text="Update"></asp:LinkButton>
                            <asp:LinkButton runat="server" ID="deleteLinkButton" OnClick="deleteLinkButton_Click" Text="Delete"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="~/UI/HomeUI.aspx">Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
