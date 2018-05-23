<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Form</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1" >
       <asp:HyperLink ID="HyperLink1" NavigateUrl="~/frmMain.aspx" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg">
        </asp:HyperLink>
            <br />
            <br />
            
        <asp:Panel ID="Panel1" runat="server" Height="404px" HorizontalAlign="Left" Width="691px">
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: " Width="75px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtFirstName" ErrorMessage="First name cannot be empty"></asp:RequiredFieldValidator>
            <br />

            <asp:Label ID="lblLastName" runat="server" Text="Last Name: " Width="75px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtLastName" ErrorMessage="Last name cannot be empty"></asp:RequiredFieldValidator>
            <br />

            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate: " Width="75px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtPayrate" ErrorMessage="Pay rate cannot be empty"></asp:RequiredFieldValidator>
            <br />

            <asp:Label ID="lblStartDate" runat="server" Text="Start Date: " Width="75px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtStartDate" ErrorMessage="Date must be in mm/dd/yyyy format" 
                ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />

            <asp:Label ID="lblEndDate" runat="server" Text="End Date: " Width="75px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtEndDate" ErrorMessage="Date must be in mm/dd/yyyy format" 
                ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </asp:Panel>
       
    </div>
    </form>
</body>
</html>
