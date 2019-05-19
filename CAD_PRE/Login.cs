/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 7/31/2015
 * Time: 7:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace NYSPP_CAD
{
	/// <summary>
	/// Log in form for the CAD
	/// </summary>
	public partial class Login : Form
	{
		private User currentUser;
		
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			currentUser = new User();
		}
		
		//log in button click event
		private void LogIn_BtnClick(object sender, EventArgs e)
		{
			onLogIn(sender, e);
		}
		
		//function to check the login
		private void onLogIn(object sender, EventArgs e)
		{
			if ((Username_Fld.Text.Length < 30) && (Password_Fld.Text.Length < 30)) // Checking for super long strings to prevent buffer overflows and crashes
			{
				HashAlgorithm sha = new SHA512CryptoServiceProvider();
				String salt_value = "";
				//GOLIVE string get_salt = "SELECT * FROM users WHERE Username = '" + Username_Fld.Text + "'"; //Fetches the in from value the users table in order to get the salt value
				//For testing 
				string get_salt = "SELECT * FROM users WHERE Username = 'test'";
				string sqlStr;
				DataSet Salty = new DataSet();
				Salty = Tools.GetDataSet(get_salt,"cad"); // actually fetched the info specified fro mthe command above
	
				if (Salty.Tables[0].Rows.Count == 1) //Makes sure data was actually fetched from the table. This fails if the username does not exist
				{
					DataRow s = Salty.Tables[0].Rows[0];
					salt_value = s["Salt"].ToString();// grabbing thr salt value from the data
					//set the sql string to check the username and password in the database
					//GOLIVE sqlStr = "SELECT * FROM users WHERE Username = '" + Username_Fld.Text + "' AND Password = '" + Hash.HashPassword(Password_Fld.Text, salt_value, sha) + "'"; // Will grab data from the users table if the username and password match. The passwerd is sent as a hash
					//For Testing 
					sqlStr = "SELECT * FROM users WHERE Username = 'test' AND Password = '" + Hash.HashPassword("password", salt_value, sha) + "'";
					//create a dataset from the returned results
					Tools.clearDataset();
					DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
				
					//if 1 row is returned, username and password matched
					if(mDS.Tables[0].Rows.Count == 1)
					{
						//you need to load parks info and open the cad screen
						DataRow r = mDS.Tables[0].Rows[0];
						currentUser.updateUser(Int32.Parse(r["DispatchID"].ToString()), r["EJusticeUsername"].ToString(), Int32.Parse(r["Admin"].ToString()), r["EJusticeLinkId"].ToString(), r["ORI"].ToString(), Int32.Parse(r["LoggedInEJustice"].ToString()));
						Tools.clearDataset();
						//SET THE Settings.  This is now separate because we're pulling the srttings out of the users table
						sqlStr = "SELECT * FROM Settings WHERE Username = 'test'";
						mDS = Tools.GetDataSet(sqlStr, "cad");
						r = mDS.Tables[0].Rows[0];
						currentUser.set_settings(r["Background"].ToString(), r["Text_Color"].ToString(), r["Panel_Color"].ToString(),r["Custom_Colors"].ToString());
						baseform.colorset(currentUser.getBG_Color(), currentUser.getText_Color(), currentUser.getPanel_Color());
						Tools.clearDataset();
						//get form settings
						getFormSettings();
						//create the inbox manager and CAD forms
						CreateForms();
						//hide the login form
						this.Hide();
						//this.Dispose(true);
					}
					else
					{
						//if username and password do not match, advise user
						MessageBox.Show("You've entered a username or password that is incorrect.\nPlease try to log in again or reset your password.");
					}
				}
				else
				{
					//if username and password do not match, advise user
					MessageBox.Show("You've entered a username or password that is incorrect.\nPlease try to log in again or reset your password.");
				}
			}
			else
			{
				MessageBox.Show("You cannot enter more than 30 characters in a field.");
			}
		}
		
		//key down event for the password field
		private void Password_FldKeyDown(object sender, KeyEventArgs e)
		{
			//check if enter key was pressed
			if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
			{
				onLogIn(sender, e);
			}
		}
		
		//key down event for the username field
		private void Username_FldKeyDown(object sender, KeyEventArgs e)
		{
			//check if enter key was pressed
			if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
			{
				//set focus to the password field
				Password_Fld.Focus();
			}
		}
		
		//create the inbox manager and CAD forms
		private void CreateForms()
		{
			InboxManager m = new InboxManager(currentUser);
			//show the inbox manager, then hide it
			m.Show();
			m.Hide();
			
			//create a new CAD
			CAD c = new CAD(currentUser);
			//run the procedure to update the assignments // This is temporarily turned off for testing purposes
			//GOLIVE Tools.Impersonate("UpdateParksAssignments");
			//show the CAD
			c.Show();		
		}
		
		//handles click of registration link
		private void Open_Registration(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//create a new Registration form
			Registration_Form rg = new Registration_Form();
			//show the form
			rg.Show();
		}
		
		//handles click of change password link
		private void Change_Password_LnkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//create a new change password form
			Change_Password cp = new Change_Password(System.Drawing.Color.CornflowerBlue, System.Drawing.Color.Yellow);
			//show the form
			cp.Show();
		}
		
		//handles click of the reset passwork lick
		private void Reset_Password_LnkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Reset_Password rp = new Reset_Password(); //create a new reset password form
			rp.Show(); //show the reset password form
		}
		
		//gets the form settings from the settings table
		private void getFormSettings()
		{
			Point p;
			Size s;
			//generate sql to get settings from table
			string sql = "SELECT * FROM FormSettings WHERE dispatchID = " + currentUser.getDispatchId();
			DataSet ds = Tools.GetDataSet(sql, "cad"); //grab the dataset of settings
			Tools.clearDataset(); //clear the data set
			DataTable dt = ds.Tables[0]; //grab the data table with all the settings
			
			foreach (DataRow dr in dt.Rows) {
				p = new Point(Int32.Parse(dr["loc_x"].ToString()), Int32.Parse(dr["loc_y"].ToString()));
				s = new Size(Int32.Parse(dr["size_w"].ToString()), Int32.Parse(dr["size_h"].ToString()));
				currentUser.addFormSetting(new formSettings(dr["formName"].ToString(), p, s));
			}
		}
		
		#region Getters & Setters
		//get the current user
		public User getUser()
		{
			return currentUser;
		}
		
		//set the current user
		public void setUser(User u)
		{
			currentUser = u;
		}
		#endregion
	}
}
