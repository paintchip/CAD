/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 7/31/2015
 * Time: 10:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// class that will hold user information for the current CAD session
	/// </summary>
	public class User
	{
		private int dispatchId; //the dispatch id of the current user
		private string eJusticeUsername; //the ejustice username of the current user
		private int admin; //admin status of the current user
		private string eJusticeLinkId; //the personallized ejustice link for the current user
		private string ori; //the ori of the current user
		private int eJusticeLoggedIn; //status of whether the user is logged into ejustice or not
		private string BG_Color;
		private string Text_Color;
		private string Panel_Color;
		private string Custom_colors;
		private List<formSettings> form_settings = new List<formSettings>();
	
		public User()
		{	
		}
		
		//method to update all of the values of the user properties
		public void updateUser(int dispId, string eJUName, int adm, string eJULink, string eJUOri, int eJULogged)
		{
			dispatchId = dispId;
			eJusticeUsername = eJUName;
			admin = adm;
			eJusticeLinkId = eJULink;
			ori = eJUOri;
			eJusticeLoggedIn = eJULogged;
		}
		public void set_settings(string background, string textc, string pn_color, string c_colors)
		{
			BG_Color = background;
			Text_Color = textc;
			Panel_Color = pn_color;
			Custom_colors = c_colors;
		}
		public int getAdmin()
		{
			return admin;
		}
		
		public int getDispatchId()
		{
			return dispatchId;
		}
		
		public string getEJUsername()
		{
			return eJusticeUsername;
		}
		
		public string getEJLink()
		{
			return eJusticeLinkId;
		}
		
		public string getOri()
		{
			return ori;
		}
		
		public int getLoggedIn()
		{
			return eJusticeLoggedIn;
		}
		
		public void setLoggedIn(int loggedIn)
		{
			eJusticeLoggedIn = loggedIn;
			UpdateUserTable();
		}
		
		public void setEJLink(string link)
		{
			eJusticeLinkId = link;
			UpdateUserTable();
		}
		
		public string getBG_Color()
		{
			return BG_Color;
		}
		
		public string getText_Color()
		{
			return Text_Color;
		}
		
		public string getPanel_Color()
		{
			return Panel_Color;
		}
		public string getCustom_Colors()
		{
			return Custom_colors;
		}
		private void UpdateUserTable()
		{
			string sql = @"UPDATE users SET EJusticeLinkId = '" + eJusticeLinkId + "', LoggedInEJustice = " + eJusticeLoggedIn + " WHERE DispatchID = " + dispatchId;
			Tools.runSql(sql, "cad");
			Tools.clearDataset();
		}
		
		public List<formSettings> getFormSettings()
		{
			return form_settings;
		}
		
		public void addFormSetting(formSettings fSettings)
		{
			bool settingFound = false;
			
			foreach(formSettings f in form_settings)
			{
				if(f.FormName.Equals(fSettings.FormName))
				{
					f.FormLocation = fSettings.FormLocation;
					f.FormSize = fSettings.FormSize;
					settingFound = true;
				}
			}
			
			if(!settingFound)
			{
				form_settings.Add(fSettings);
			}
		}
		
		public void removeFormSetting(string fSettings)
		{
			foreach(formSettings f in form_settings)
			{
				if(f.FormName.Equals(fSettings))
				{
					form_settings.Remove(f);
					return;
				}
			}
		}
	}
}
