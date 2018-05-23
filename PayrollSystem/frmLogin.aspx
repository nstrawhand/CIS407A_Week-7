<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: relative;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" style="margin-left: 352px; margin-right: 692px" />
    
    
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/frmMain.aspx" OnAuthenticate="Login1_Authenticate" style="z-index: 1; left: 316px; top: 140px; position: absolute; height: 173px; width: 489px" TitleText="Please enter your UserName and Password in order to log in to the system.">
        </asp:Login>
    </div>
    </form>
</body>
</html>
