using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
        Session["SecurityLevel"] = null;
        }
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
        //setting the dataset to thr inputed info
        dsUser dsUserLogin;
        //security var sets the level of the user
        string SecurityLevel;
        //verfing user name and password in the DB
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        // if statement if the db returns invailid 
        if (dsUserLogin.tblUserLogin.Count < 1)
            {
            e.Authenticated = false;
            // sending email to designated user
            if (clsBusinessLayer.SendEmail("Nathan.Strawhand@cox.net",
            "nstrawhand@hotmail.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
                {
                Login1.FailureText = Login1.FailureText +
                " Your incorrect login information was sent to receiver@receiverdomain.com";
                }

            return;
            }
        // set security level of user
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        // switch for SL value based on user
        switch (SecurityLevel)
            {
            case "A":
                // for users authorized with SL A setting session values
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // for users authorized with SL U setting session values
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
            }

        }
}