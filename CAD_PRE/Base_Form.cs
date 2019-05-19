/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/27/2015
 * Time: 6:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class baseform: Form
	{
		
		private static string background_color;
		private static string text_color;
		private static string panel_color;
		protected Size defaultSize;
		protected Point defaultLocation = new Point(0, 0);
		private static Size screenSize = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
		
		//using constructor to implement some default features of the base form
		public baseform()
		{
			//create a new icon from the logo icon in the img folder
			//GOLIVE Icon ico = new Icon(@"img\logo.ico");
			//set this icon to be the icon of the form
			//GOLIVE this.Icon = ico; //uncomment this at release, seems to cause some errors when switching to design view
			this.StartPosition = FormStartPosition.Manual; //allows form to be relocated
			this.KeyPreview = true; //allows key presses to be handled
			this.FormClosing += new FormClosingEventHandler(baseform_FormClosing); //adding handler for when the form closes
			this.Load += new EventHandler(baseform_Load); //adding handler for when the form loads
			this.KeyDown += new KeyEventHandler(baseform_KeyDown); //adding handler for when a key is pressed
			this.KeyUp += new KeyEventHandler(baseform_KeyUp); //adding handler for when a key is let up
		}

		//on base form load, load settings, inherited by all child classes
		protected void baseform_Load(object sender, EventArgs e)
		{
			LoadSettings(sender);
		}

		//on base form close, save settings, inherited by all child classes
		protected void baseform_FormClosing(object sender, FormClosingEventArgs e)
		{
			saveSettings(sender);
		}

		//method that saves the settings in the formSettings object
		protected void saveSettings(object sender)
		{
			Form f = (Form) sender;
			//when the size is changed save the settings in the settings table for the current form
			try
			{
				//MessageBox.Show(f.Name + "\n" + f.Location.ToString() + "\n" + f.Size.ToString());
				Login login = (Login) Application.OpenForms["Login"];
				User u = login.getUser();
				u.addFormSetting(new formSettings(f.Name, f.Location, f.Size));
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}	

		public static void colorset(string background, string textc, string pn_color)
		{
			background_color = background;
			text_color = textc;
			panel_color = pn_color;
		}
		
		public Color return_pn()
		{
			return System.Drawing.ColorTranslator.FromHtml(panel_color);
		}
		public Color return_fore()
		{
			return System.Drawing.ColorTranslator.FromHtml(text_color);
		}
		public Color return_bg()
		{
			return System.Drawing.ColorTranslator.FromHtml(background_color);
		}
		public void basecontrols()
		{
			this.BackColor = System.Drawing.ColorTranslator.FromHtml(background_color);
			this.ForeColor = System.Drawing.ColorTranslator.FromHtml(text_color);
		}

		//method that loads the settings from the formSettings object
		public void LoadSettings(object sender)
		{		
			baseform b = (baseform) sender; //cast the sender to a baseform object
			
			//lookup location and size settings, use default if no settings available
			try
			{
				Login login = (Login) Application.OpenForms["Login"]; //get the login form
				User u = login.getUser(); //get the user from the login form
				List<formSettings> fSettings = u.getFormSettings(); //get the list of form settings from the user
				
				//loop through each form setting in the list
				foreach(formSettings f in fSettings)
				{
					if(f.FormName.Equals(b.Name)) //get only the settings that pertain to the calling form
					{
						//make sure form is not outside of viewable area
						if((f.FormLocation.X <= screenSize.Width - f.FormSize.Width) && (f.FormLocation.Y <= screenSize.Height - f.FormSize.Height) && (f.FormLocation.X >= 0) && ( f.FormLocation.Y >= 0))
							b.Location = f.FormLocation; //relocate the form to the location from the settings
						
						//make sure form size is reasonably viewable
						if(f.FormSize.Width > 38 && f.FormSize.Height > 160)
							b.Size = f.FormSize; //resize form to size loaded from the settings
					}
				}
				
				if(!this.Name.Equals("Settings")) //if the sender is not the settings form
				{
					foreach(Control c in this.Controls) //loop through all of the controls on the form
					{
						if(c is PictureBox || c is Panel) //if the control is a picture box or a panel
							c.BackColor = System.Drawing.ColorTranslator.FromHtml(panel_color); //change back color based on settings
						
						if(c is DataForm) //if the control is a DataForm
						{
							DataForm d = (DataForm) c; //cast the control to a DataForm object
							d.changeColors(panel_color); //set the color of the panels on the data form with the change colors method
						}
					}
				}
			}
			catch(Exception ex) //catch any exceptions
			{
				Console.WriteLine(ex.Message + "\n" + ex.StackTrace); //print the message to the console with the location it occurred
			}
		}
		
		//handles keyboard shortcuts
		protected void baseform_KeyDown(object sender, KeyEventArgs e)
		{
			Login l = (Login) Application.OpenForms["Login"]; //get the login form
			User u = l.getUser(); //get the current user of the CAD
			
			//Close current form, as long as not CAD, Esc
			if(e.KeyCode == Keys.Escape && !this.Name.Equals("CAD"))
				this.Close();
			if(e.Alt || e.KeyCode == Keys.Menu) 					//alt key is down
			{
				switch (e.KeyCode) {								//switch on what key is down with the alt key
					case Keys.C: 									//c key is down
						EnterCall ec = new EnterCall(0, 0, u); 		//create new enter call form
						ec.Show(); 									//show enter call form
						break;
					case Keys.R:									//r key is down
						RunData rd = new RunData();					//create new run data form
						rd.Show();									//show run data form
						break;
					case Keys.E:									//e key is down
						New_Event_Form nef = new New_Event_Form(u);	//create new event form
						nef.Show();									//show new event form
						break;
					case Keys.X:									//x key is down
						Settings s = new Settings(u);				//create new settings form
						s.Show();									//show settings form
						break;
					case Keys.P:									//p key is down
						Change_Password cp = new Change_Password();	//create new change password form
						cp.Show();									//show change password form
						break;
					case Keys.I:									//i key is down
						Browser b = new Browser("inbox", 0, null, "e", null); //create new browser form, set to inbox
						b.Show();									//show the inbox
						break;
					case Keys.NumPad4:								//numpad 4 key is down
					case Keys.D4:									//4 key is down
						CAD_Buttons.checkButton("Hang_Up", 0, 0); 	//call hang up method using cad_buttons object
						break;
					case Keys.NumPad5:								//numpad 5 key is down
					case Keys.D5:									//5 key is down
						CAD_Buttons.checkButton("No_One", 0, 0); 	//call no one on line method using cad_buttons object
						break;
					case Keys.NumPad6:								//numpad 6 key is down
					case Keys.D6:									//6 key is down
						CAD_Buttons.checkButton("Wrong_Number", 0, 0); 	//call wrong number method using cad_buttons object
						break;
					case Keys.NumPad1:								//numpad 1 key is down
					case Keys.D1:									//1 key is down
						//TODO add call to open alarm form
						break;
					case Keys.NumPad2:								//numpad 2 key is down
					case Keys.D2:									//2 key is down
						CAD_Buttons.checkButton("No_Response", 0, 0); 	//call no reponse method
						break;
					default:										//default for showing shortcut keys
						CAD c = (CAD) Application.OpenForms["CAD"];	//get the open cad form
							
						foreach (Control ctl in c.Controls) {		//loop through all controls on the cad form
							if(ctl.Name.StartsWith("ShortCut"))		//if the control name starts with 'ShortCut'
								ctl.Visible = true;					//show the control
						}

						break;
				}
			}
		}
		
		//used to hide keyboard hints
		protected void baseform_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Menu || e.KeyCode == Keys.Alt)		//alt key is up
			{
				CAD c = (CAD) Application.OpenForms["CAD"];			//get the open cad form
				
				foreach (Control ctl in c.Controls) {				//loop through all controls on the cad form
					if(ctl.Name.StartsWith("ShortCut"))				//if the control name starts with 'ShortCut'
						ctl.Visible = false;						//hide the control
				}
	}
			}
		}
}
