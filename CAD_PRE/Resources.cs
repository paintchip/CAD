/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/25/2015
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Resources.
	/// </summary>
	public partial class Resources : baseform
	{
		private bool shiftKeyDown = false;
		
		public Resources()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
		}
		
		//handles the link clicking
		private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//cast the sender to a link label object
			LinkLabel l = (LinkLabel) sender;
			//get the tag of the object
			string tag = l.Tag.ToString();
			string address = "";
			
			//check which link was clicked
			if(tag.Equals("PARKSLbl"))
			{
				address = @"http://policeblotter/";
			}
			else if(tag.Equals("RefLbl"))
			{
				address = @"file:///P:\Dispatching disk\index.html";
			}
			
			//check if shift key is down
			if(shiftKeyDown)
			{
				//shift key is down, use chrome
				openBrowser(address, "chrome");
			}
			else
			{
				//shift key is up, use ie
				openBrowser(address, "ie");
			}
		}
		
		//opens external browser
		private void openBrowser(string address, string browser)
		{
			string filename = "";
			
			//choose browser based on browser string passed in
			if(browser.Equals("chrome")) //if chrome
			{
				filename = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
			}
			else //else ie
			{
				filename = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
			}
			
			Process p = new Process(); //create a new process
			p.StartInfo.FileName = filename; //set the file name to the file name of the browser
			p.StartInfo.Arguments = "\"" + address + "\""; //set the arguments to the address
			
			try
			{
				p.Start(); //start the process
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message); //show the caught error message if process fails to start
			}
			
			p.Close();
		}
		
		//handles the key down event of the form
		private void ResourcesKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.ShiftKey)
			{
				shiftKeyDown = true;
			}
		}
		
		//handles the key up event of the form
		private void ResourcesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.ShiftKey)
			{
				shiftKeyDown = false;
			}
		}
		
		void SSG_lblClick(object sender, EventArgs e)
		{
			Process.Start("openExcel.vbs", "SSG");
		}
		
		void Cen_Member_btnClick(object sender, EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Filing Cabinet\Communications\Telephone File\Current Telephone Number Listings\Regional Listing\CEN.pdf");
		}
		
		void TI_Member_btnClick(object sender, EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Filing Cabinet\Communications\Telephone File\Current Telephone Number Listings\Regional Listing\TI.pdf");
		}
		
		void FL_Member_btnClick(object sender, EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Filing Cabinet\Communications\Telephone File\Current Telephone Number Listings\Regional Listing\FL.pdf");
		}
		
		void Central_Guide_btnClick(object sender, System.EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Dispatch Reference\EMERGENCY REFERENCE GUIDES\GUIDE COVERS\CEN.pdf");
		}
		
		void TI_Guide_btnClick(object sender, System.EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Dispatch Reference\EMERGENCY REFERENCE GUIDES\GUIDE COVERS\TI.pdf");
		}
		
		void FL_Guide_btnClick(object sender, System.EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Dispatch Reference\EMERGENCY REFERENCE GUIDES\GUIDE COVERS\FL.pdf");
		}
		
		void Combined_Member_btnClick(object sender, System.EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Dispatch Reference\CONTACT INFO\00-CEN-TI-FL CONTACT LIST.pdf");
		}
		
		void Agency_Guide_btnClick(object sender, System.EventArgs e)
		{
			Process.Start(@"\\cenfile1\police$\CENTRAL REGION DRIVE\Filing Cabinet\Communications\Telephone File\Current Telephone Number Listings\Agency Listing\2015-09 NYS Park Police Phone Directory.doc");
		}
		
		void Hazmat_lblClick(object sender, EventArgs e)
		{
			Process.Start("openExcel.vbs", "hazmat");
		}
	}
}
