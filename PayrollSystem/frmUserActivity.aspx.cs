using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmUserActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
        {
        if (Session["SecurityLevel"] != "A")
            {
            Response.Redirect("frmLogin.aspx");
            }
        if (!Page.IsPostBack)
        {
            // we are setting ds as var
            dsUserActivity myDataSet = new dsUserActivity();
            // getting and puting returned values into the dataset
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.accdb"));
            
            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];
            // binding the grid
            grdUserActivity.DataBind();
        }
    }
}