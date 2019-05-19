/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 7/31/2015
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using mshtml;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of InboxManager.
	/// </summary>
	public partial class InboxManager : Form
	{
		private User cu;
		private string webAddress;
		
		public InboxManager(User curU)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//grab the current user object
			cu = curU;
			
			//get the ori from the current user
			string ori = cu.getOri();
			//get the username of the current user
			string uname = cu.getEJUsername();
			//set the inbox alert address
			webAddress = @"https://www.ejusticeny.ny.gov/ijapp/AlertMonitor/?userOri=" + ori + "&userId=" + uname + "&subGrpName=";
			
			webBrowser1.ScriptErrorsSuppressed = true;
		}
		
		private void InboxManagerLoad(object sender, EventArgs e)
		{
			//set the webbrowser object to navigate to the web address on form load
			webBrowser1.AllowNavigation = true;
			webBrowser1.Navigate(webAddress);
			GetPortalMessages();
		}		
		
		//once the web browser document is done loading
		private void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			GetPortalMessages();
		}
		
		//on timer interval
		private void Timer1Tick(object sender, EventArgs e)
		{
			//webBrowser1.Refresh();
			GetPortalMessages();
		}
		
		//get the portal messages
		private void GetPortalMessages()
		{
			try
			{
				//set the htmlDoc to the html of the document loaded in the web browser object
				mshtml.HTMLDocument htmlDoc = (mshtml.HTMLDocument) webBrowser1.Document.DomDocument;
				//create a collection to hold the html elements in the document
				IHTMLElementCollection pageSource;
				//create a list to store only html tables
				List<IHTMLTable> tables = new List<IHTMLTable>();
				//create variable to use to get the info from the html table
				IHTMLTable cElem;
				IHTMLTableRow cElem2;
				IHTMLTableCell cElem3;
				//variable to create index of table list
				int x = 0;
				//variables that will hold the message counts
				int pMsg, uMsg;
	
				//get all html table elements
				pageSource = htmlDoc.getElementsByTagName("table");
				
				//loop through each html table
				foreach (mshtml.HTMLTableClass tab in pageSource) {
					//check the class of the table
					if(tab.className == "unreadMessageCounts")
					{
						//insert the table into the list of tables and increase the index
						IHTMLTable t = (IHTMLTable) tab;
						tables.Insert(x, t);
						x++;
					}
				}
				
				//priority messages
				//grab the 1st table, the 2nd row and 1st cell
				cElem = tables[0];
				cElem2 = (IHTMLTableRow) cElem.rows.item(1);
				cElem3 = (IHTMLTableCell) cElem2.cells.item(0);
				//cast to html element to get inner text
				IHTMLElement c = (IHTMLElement) cElem3;
				//set priority message variable to the amount of messages
				pMsg = Int16.Parse(c.innerText);
				
				//unread messages
				//grab the 2nd table, the 2nd row and 1st cell
				cElem = tables[1];
				cElem2 = (IHTMLTableRow) cElem.rows.item(1);
				cElem3 = (IHTMLTableCell) cElem2.cells.item(0);
				//cast to html element to get inner text
				c = (IHTMLElement) cElem3;
				//set unread message variable to the amount of messages
				uMsg = Int16.Parse(c.innerText);
				
				Form cad = null;
				
				foreach (Form f in Application.OpenForms) {
					if(f.Name == "CAD")
					{
						cad = f;
					}
				}
				
				if(cad != null)
				{
					foreach (Control ctl in cad.Controls) {
						if(ctl is GroupBox)
						{
							if(ctl.Tag != null && ctl.Tag.Equals("Portal_Messages"))
							{
								foreach (Control tb in ctl.Controls) {
									if(tb is TextBox)
									{
										if(tb.Tag.Equals("Priority_Message"))
										{
											tb.Text = pMsg.ToString();
										}
										else if(tb.Tag.Equals("Inbox_Message"))
										{
											tb.Text = uMsg.ToString();
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message + "\n" + e.StackTrace);
			}
		}
	}
}
