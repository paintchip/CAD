/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/7/2015
 * Time: 8:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of CAD.
	/// </summary>
	public partial class CAD : baseform
	{
		private User cu;
		
		public CAD(User u)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.defaultLocation = new Point(0,0);
			this.defaultSize = new Size(1061, 674);
			basecontrols();
			InitializeComponent();
			groupBox1.ForeColor = return_fore();
			groupBox2.ForeColor = return_fore();
			groupBox3.ForeColor = return_fore();
			groupBox4.ForeColor = return_fore();
			groupBox5.ForeColor = return_fore();
			groupBox6.ForeColor = return_fore();
			cu = u;
		}
		
		//handles the cad form closed event
		private void CADFormClosed(object sender, FormClosedEventArgs e)
		{
			//update the user to be logged out of ejustice
			cu.setLoggedIn(0);
			
			//create a form collection from all the open forms of the application
			FormCollection fc = Application.OpenForms;
			//loop through each form in the collection
			foreach (Form f in fc) {
				//check for the login form
				if(f.Name == "Login")
				{
					Login l = (Login) f;
					User u = l.getUser();
					Tools.SaveFormSettings(u.getFormSettings(), u.getDispatchId());
					//close the login form, in turn closing the application
					f.Close();
				}
			}
		}
		
		//method that handles button clicks
		private void CAD_ButtonClick(object sender, EventArgs e)
		{
			CAD_ButtonClick(sender, e, 0, 0);
		}
		
		//method that handles button clicks
		private void CAD_ButtonClick(object sender, EventArgs e, int id, int idType)
		{	
			//set the tag variable to an empty string
			string tag = "";
				
			//check the type of object that was clicked
			if(sender.GetType().Name.ToString().Equals("Button"))
			{
				//if the type was button, cast the sender object to a button
				Button b = (Button) sender;
				//set the tag to the button tag
				tag = b.Tag.ToString();
			}
			else
			{
				//else cast the sender object to a data grid view button
				DataGridViewButtonCell dg = (DataGridViewButtonCell) sender;
				//set the tag to the data grid view button tag
				tag = dg.Tag.ToString();
			}
			
			//send the button tag, id, and the idtype to a the static button click handling class
			CAD_Buttons.checkButton(tag, id, idType);
		}
		
		#region CAD painting / formatting event handling		

		//on change for the inbox messages textboxes
		private void textBox_onChange(object sender, EventArgs e)
		{
			//cast the sender object to a text box object
			TextBox tb = (TextBox) sender;
			//if the number of messages is 10 or more, change the text to red, else yellow
			if(Int16.Parse(tb.Text.ToString()) >= 10)
			{
				tb.ForeColor = Color.Red;
			}
			else
			{
				tb.ForeColor = Color.Yellow;
			}
		}
		#endregion
	
		//handles the onload event of the CAD form
		private void CADLoad(object sender, EventArgs e)
		{
			//create an empty group box control
			GroupBox g = null;
			
			//loop through all control in the CAD form
			foreach (Control ctl in this.Controls) {
				//if the control is a groupbox and it's tag is Admin
				if(ctl is GroupBox && ctl.Tag.Equals("Admin"))
				{
					g = (GroupBox) ctl;
				}
			}
			
			//check if the user is admin or not, show or hide admin panel based on admin status
			if(cu.getAdmin() == 1)
			{
				g.Visible = true;
			}
			else
			{
				g.Visible = false;
			}
		}
		
		//returns the user
		public User getUser(){
			return this.cu;
		}
		
		//handles when the background color of the cad screen changes
		private void CADBackColorChanged(object sender, EventArgs e)
		{
			//these 2 textboxes need to be changed manually
			textBox1.BackColor = this.BackColor;
			textBox2.BackColor = this.BackColor;
		}
	}
}
