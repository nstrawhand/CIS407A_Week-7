using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    if (Session["SecurityLevel"] == null)
        {
        Response.Redirect("frmLogin.aspx");
        }
    }
    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        string strAnnualHours = txtAnnualHours.Text; 
        double AnnualHours = Convert.ToDouble(strAnnualHours); 


        string strRate = txtRate.Text;
        double Rate = Convert.ToDouble(strRate); 

        double AnnualSalary = AnnualHours * Rate; 

        lblSalary.Text = "$" + AnnualSalary.ToString(); 
        
    }
}
