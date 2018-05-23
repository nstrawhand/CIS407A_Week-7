using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
        {
        if (Session["SecurityLevel"] == null)
            {
            Response.Redirect("frmLogin.aspx");
            }
        if (!Page.IsPostBack)
        {
            //Declare the ds
            dsPersonnel myDataSet = new dsPersonnel();
            string strSearch = Request["txtSearch"];
            //Checks if the request string is null
            
            //fill dataset with what is returned from the method.
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.accdb"), strSearch);
            //Set the grd to the ds based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];
            //Bind the DataGrid
            grdViewPersonnel.DataBind();
        }
        
    }
    protected void grdViewPersonnel_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}