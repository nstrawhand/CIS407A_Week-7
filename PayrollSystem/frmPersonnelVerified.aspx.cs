using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    if (Session["SecurityLevel"] == null)
        {
        Response.Redirect("frmLogin.aspx");
        }
        //loads user saved data to verifiy
        txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
        "\n" + Session["txtLastName"].ToString() +
        "\n" + Session["txtPayRate"].ToString() +
        "\n" + Session["txtStartDate"].ToString() +
        "\n" + Session["txtEndDate"].ToString();

        //verfies if the personnel info was saved in the table 
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
        Session["txtFirstName"].ToString(),
        Session["txtLastName"].ToString(),
        Session["txtPayRate"].ToString(),
        Session["txtStartDate"].ToString(),
        Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was successfully saved!";
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
            "\nThe information was NOT saved.";
        }

    }

}
