<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .auto-style1 {
            width: 425px;
            height: 125px;
        }
        .auto-style2 {
            float: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
        <font color="black" size="2">
       
        <br />
        <img alt="" class="auto-style1" src="images/CIS407A_iLab_ACITLogo.jpg" align="middle" height="250" width="300" /><br />
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" style="position: relative; top: 0px; left: 0px; height: 1162px; width: 920px">
            <br />
            <asp:LinkButton ID="linkbtnCalculator"  runat="server" PostBackUrl="~/frmSalaryCalculator.aspx"> Salary Calculator</asp:LinkButton>
            <asp:ImageButton ID="imgbtnCalculator" runat="server" ImageUrl="~/images/calculator.png" PostBackUrl="~/frmSalaryCalculator.aspx" />
            <br />
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" ImageUrl="~/images/AddNewEmployee.png" PostBackUrl="~/frmPersonnel.aspx"/>
            <br />
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="136px" ImageUrl="~/images/Managing-users.jpg" PostBackUrl="~/frmUserActivity.aspx" Width="127px" style="margin-bottom: 27px; margin-left: 43px; margin-right: 0px; margin-top: 46px;" />
            <br />                        
            <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx">Veiw Personnel</asp:LinkButton>
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="104px" ImageUrl="~/images/stock-photo-file-folder-labeled-as-personnel-in-multicolor-archive-closeup-view-blurred-image-d-render-441849196.jpg" PostBackUrl="~/frmViewPersonnel.aspx" style="margin-left: 35px; margin-right: 0px; margin-top: 52px; margin-bottom: 3px;" Width="150px" />
            <br />
            <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <asp:ImageButton ID="imgbtnSearch" runat="server" Height="99px" ImageUrl="~/images/Interstate-Personnel-Services-Skill-Assessment.jpg" PostBackUrl="~/frmSearchPersonnel.aspx" Width="125px" style="margin-left: 44px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Personnel</asp:LinkButton>
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="87px" ImageUrl="~/images/edit-interface-symbol_318-61460.jpg" Width="120px" style="margin-left: 37px" />
            <br />
            <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
            <asp:ImageButton ID="imgManageUsers" runat="server" Height="112px" ImageUrl="~/images/Puzzle-Pieces-Manage.png" PostBackUrl="~/frmManageUsers.aspx" />
            <br />
        </asp:Panel>
        
        
        
      
            
            </div>
    </form>
</body>
</html>
