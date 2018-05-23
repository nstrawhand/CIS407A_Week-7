using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// letting the program know system properties to load
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        //Opens DB
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // selects the user activity table from DB
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
        //sets dataset for new user activity
        DS = new dsUserActivity();
        // adds user dats activity to DB
        sqlDA.Fill(DS.tblUserActivity);
        //returns dataset with user activity
        return DS;
    }
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        //Sets and opens the Database to save user data
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
        GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }
    
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
                                     string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;
//create transaction object
         OleDbTransaction myTransaction = null;

        try
        {

            //Begin the transaction
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Begin the transaction
 myTransaction = conn.BeginTransaction();
  command.Transaction = myTransaction;
            //commit the transaction 
            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";

            // set the command text of the object
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Execute the the statement
            command.ExecuteNonQuery();

            // update tables
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";

            // set the command text of the object
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Execute the statement
            command.ExecuteNonQuery();

            // ** NEW ** Add your comments here
 myTransaction.Commit();

            // close the database 
            conn.Close();

        recordSaved = true;

        }
        catch (Exception ex)
        {

            // roll back transaction if there is a failure
            myTransaction.Rollback();
           
            recordSaved = false;

        }

        return recordSaved;

    }

    public static dsPersonnel  GetPersonnel(string Database, string strSearch)
    {

        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        //Opens DB
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // selects the user activity table from DB
        if (strSearch == null || strSearch.Trim() == "")
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        }

        //sets dataset for new user activity
        DS = new dsPersonnel();
        // adds user dats activity to DB
        sqlDA.Fill(DS.tblPersonnel);
        //returns dataset with user activity
        return DS;
    }

    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
        {
        //setting vars
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // setting var to open the db
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        // setting var to input the info into the db
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);
        //setting dataset to user
        DS = new dsUser();
        // add user info to table 
        sqlDA.Fill(DS.tblUserLogin);
        // return if valid or not
        return DS;
        }

    public static bool SaveUser(string Database, string UserName, string Password, string SecurityLevel)
        {

        bool recordSaved;

               
            // Create a New Connection Object to the Access Database
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;


            // Create the sql query and set the values from the parameters of first and last names only
            strSQL = "Insert into tblUserLogin " +
            "(UserName, UserPassword, SecurityLevel) values ('" +
            UserName + "', '" + Password + "', '" + SecurityLevel + "')";
            // set the command text of the command object
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Execute the insert statement
            command.ExecuteNonQuery();

            // Close the Database connection
            conn.Close();
            recordSaved = true;
            


            

        return recordSaved;
        }

    public clsDataLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}