<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="frmManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/frmMain.aspx" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg">
        </asp:HyperLink>
        <br />      
        <asp:Panel ID="Panel1" runat="server" Width="723px">
        <a href="javascript:__doPostBack('LinkButton1','')">&nbsp;</a><p>
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtUserName" ErrorMessage="User name cannot be empty"></asp:RequiredFieldValidator>
    <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtPassword" ErrorMessage="Password cannot be empty"></asp:RequiredFieldValidator>
    <br />
            <asp:Label ID="Label2" runat="server" Text="Security Level"></asp:Label>
            <asp:DropDownList ID="SecurityLevel" runat="server">
                <asp:ListItem Value="A">A</asp:ListItem>
                <asp:ListItem Value="U">U</asp:ListItem>
            </asp:DropDownList>
    <br />
        </p>
            <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Add User" />
            <asp:Label ID="lblPersonnelSavedStatus" runat="server" ForeColor="#CC0000"></asp:Label>
        <br />
        <br />
        View Users<asp:GridView ID="grdViewUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="grdViewUsers_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
            
        </asp:Panel>
            
    </form>
</body>
</html>
