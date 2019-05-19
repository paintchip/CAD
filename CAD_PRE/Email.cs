/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 10/15/2015
 * Time: 1:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MsOutlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Email.
	/// </summary>
	public class Email
	{
		public Email()
		{
		}

		// took out , string[] filePaths for atachments
		public static bool SendMailWithOutlook(string subject, string htmlBody, string recipients, bool autoSend)
		{
	        // create the outlook application.
	        MsOutlook.Application outlookApp = new MsOutlook.Application();
	        if (outlookApp == null)
	            return false;
	 
	        // create a new mail item.
	        MsOutlook.MailItem mail = (MsOutlook.MailItem)outlookApp.CreateItem(MsOutlook.OlItemType.olMailItem);
	        mail.HTMLBody = htmlBody;
	        mail.Subject = subject;
	        mail.To = recipients;
	        
	        //added autoSend parameter to make more useable throughout rest of program
	        if(autoSend) //if autoSend is true, send the email
	        	((Microsoft.Office.Interop.Outlook._MailItem) mail).Send();
	        else //else show the outlook mail window
	        	mail.Display();
	        
	         //Add attachments.
	       //if (filePaths != null)
	       // {
	        //    foreach (string file in filePaths)
	        //    {
	        //        //attach the file
	       //         MsOutlook.Attachment oAttach = mail.Attachments.Add(file);
	        //    }
	       // } 

	        mail = null;
	        outlookApp = null;
	        return true;
		}
	}
}