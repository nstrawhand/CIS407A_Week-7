using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
    {
    protected void Page_Load(object sender, EventArgs e)
        {
        if (Session["SecurityLevel"] != "A")
            {
            Response.Redirect("frmLogin.aspx");
            }
        }
   
    protected void btnAddUser_Click(object sender, EventArgs e)
        {
        //Checks if the new user is successfully saved
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"), txtUserName.Text, txtPassword.Text, SecurityLevel.SelectedValue))
            {
            //Bing datagrid again to show the newly added user
            grdViewUsers.DataBind();
            lblPersonnelSavedStatus.Text = "The user was successfully added!";

            }
        else
            lblPersonnelSavedStatus.Text = "The user could not be added";
        }
    protected void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    protected void grdViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
}