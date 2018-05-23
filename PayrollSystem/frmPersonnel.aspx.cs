using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {if (Session["SecurityLevel"] == null)
{
Response.Redirect("frmLogin.aspx");
}
    if (Session["SecurityLevel"] != "A")
        {
        Response.Redirect("frmLogin.aspx");
        }
        // checking to see user SL level
    if (Session["SecurityLevel"] == "A")
        {
        // if SL level is A then button visable
        btnSubmit.Visible = true;
        }
    else
        {
        // if SL level is A then button visable
        btnSubmit.Visible = false;
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
          
        //If all fields return true from the validation of fields below 
        if (ValidateFields()) 
        {

            //Need to set session variables for all text boxes
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;
            Response.Redirect("frmPersonnelVerified.aspx");
        }
        
    }

    //here we are validating fileds and returning a true or false bool method
    protected bool ValidateFields()
    {
        
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;
        lblError.Text = "";

        bool isValidated = true;
        

        //here is where we check the fields to see if they are vaild and if 
        //not valid we set an error message and highlight the box that is not vaild

        /*using if statement supplied in the week 3 ilab instructions
         */
       
        //Validate First Name
        if (txtFirstName.Text.Trim() == "")
        {
            lblError.Text += "First Name cannot be empty. ";
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            isValidated = false;

        }

        //Validate Last Name
        if (txtLastName.Text.Trim() == "")
        {
            lblError.Text += "Last Name cannot be empty. ";
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            isValidated = false;
        }

        //Validate Pay Rate
        if (txtPayRate.Text.Trim() == "")
        {
            lblError.Text += "Pay Rate cannot be empty. ";
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            isValidated = false;
        }

        //Validate Start Date
        if (txtStartDate.Text.Trim() == "")
        {
            
            lblError.Text += "Start Date cannot be empty. ";
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            isValidated = false;
        }
        
        //Validate End Date
        if (txtEndDate.Text.Trim() == "")
        {
            lblError.Text += "End Date cannot be empty. ";
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            isValidated = false;
        }
        


            
        //If all field return a value, then this IF statement wiil excute to vailidate start and end dates
        //if dates are not null then the code will verify if the end date is later than the start date
         if (isValidated)
            {
            try
                {
                string strStartDate = txtStartDate.Text;
                string strEndDate = txtEndDate.Text;
                string Msg = "";


                //converts start and end date to date time as shown in lab instructions
                DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
                DateTime endDate = DateTime.Parse(Request["txtEndDate"]);
                if (DateTime.Compare(startDate, endDate) > 0)
                    {
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    Msg = Msg + "The end date must be a later date than the start date.";
                    //The Msg text will be displayed in lblError.Text after all the error messages are concatenated
                    isValidated = false;
                    //Boolean value - test each textbox to see if the data entered is valid, if not set validState=false. 
                    //If after testing each validation rule, the validatedState value is true, then submit to frmPersonnelVerified.aspx, if not, then display error message
                    }
                else
                    {
                    txtStartDate.BackColor = System.Drawing.Color.White;
                    txtEndDate.BackColor = System.Drawing.Color.White;
                    }
                }
            catch
                {
                Exception ex;
                lblError.Text += "Please enter the date in MM/DD/YY format";
                isValidated = false;
                }
        }
        return isValidated;

    }
   
}
