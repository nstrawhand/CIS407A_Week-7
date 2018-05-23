using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
    {
    protected void Page_Load(object sender, EventArgs e)
        {
        if (Session["SecurityLevel"] == null)
            {
            Response.Redirect("frmLogin.aspx");
            }
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");

        if (Session["SecurityLevel"] != "A")
            {
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;
            linkbtnManageUsers.Visible = false;
            imgManageUsers.Visible = false;
            }
        }
    }
