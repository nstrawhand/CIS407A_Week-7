<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmUserActivity.aspx.cs" Inherits="frmUserActivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">
        </asp:HyperLink>
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="260px">
            <asp:Label ID="Label1" runat="server" Text="User Activity"></asp:Label>
            <asp:GridView ID="grdUserActivity" runat="server">
            </asp:GridView>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
