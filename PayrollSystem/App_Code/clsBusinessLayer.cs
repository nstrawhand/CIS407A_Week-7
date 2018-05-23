using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// **** Add the following at the top of the class file,
// adding the system commands for mailing in ASP
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
   
public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
string Subject, string Body)
{
try {
//setting var MyMailMessage 
MailMessage MyMailMessage = new MailMessage();
// var for the sender
MyMailMessage.From = new MailAddress(Sender);
// from to sender addree
MyMailMessage.To.Add(new MailAddress(Recipient));
// select statement to check if bc needed
if (bcc != null && bcc != string.Empty) {
// adding bc receipent address
MyMailMessage.Bcc.Add(new MailAddress(bcc));
}
// select statement to check if cc needed
if (cc != null && cc != string.Empty) {
// Add cc receipent
MyMailMessage.CC.Add(new MailAddress(cc));
}
// subect of message
MyMailMessage.Subject = Subject;
// message body 
MyMailMessage.Body = Body;
// setting value as html
MyMailMessage.IsBodyHtml = true;
// setting mail priority as normal
MyMailMessage.Priority = MailPriority.Normal;
// setting the mail server var
SmtpClient MySmtpClient = new SmtpClient("localhost");
//SMTP Port = 25;
//Generic IP host = "127.0.0.1";
// sending message via server
MySmtpClient.Send(MyMailMessage);
// checking if email sent
return true;
} catch (Exception ex) {
// return false if exception occurs
return false;
}
}      

	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}