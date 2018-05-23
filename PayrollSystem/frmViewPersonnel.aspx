<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>

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
            <asp:Label ID="Label1" runat="server" Text="View Personnel"></asp:Label>
            <asp:GridView ID="grdViewPersonnel" runat="server" OnSelectedIndexChanged="grdViewPersonnel_SelectedIndexChanged">
            </asp:GridView>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
