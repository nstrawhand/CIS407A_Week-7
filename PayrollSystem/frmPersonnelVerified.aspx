<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerified.aspx.cs" Inherits="frmPersonnelVerified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/frmMain.aspx" runat="server" 
            style="text-align: center" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg">
      </asp:HyperLink>
        <br />
        <br />
      
       <asp:Label ID="lblInformationSubmit" runat="server" Text="Information to submit"></asp:Label>
        <asp:TextBox ID="txtVerifiedInfo" TextMode="MultiLine" Height="80px" Width="400px" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Text="View Personnel" />
    
    </div>
    </form>
</body>
</html>
