<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs"
    Inherits="frmSalaryCalculator" %>

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
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/frmMain.aspx" runat="server" Style="text-align: center" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg">
    </asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours:"></asp:Label>
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblRate" runat="server" Text="Rate:" width="86px"></asp:Label>
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculateSalary_Click"
            Text="Calculate Salary" Height="29px" style="margin-top: 0px" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
