/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/12/2015
 * Time: 10:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Class that will handle all button clicks
	/// note idType 1 for officer and 2 for event
	/// </summary>
	public static class CAD_Buttons
	{
		//variables that hold an id that is passed in, the type of id, and the button tag
		private static int id;
		private static int idType;
		private static string tag;
		private static CAD cad;
		
		//contains names and functions that match for efficient button click handling
		private static Dictionary<string, Func<bool>> functions = new Dictionary<string, Func<bool>>{
			{"Call_Entry", Open_Form},
			{"Call_Entry_Ofc", Open_Form},
			{"Call_Entry_Evt", Open_Form},
			{"eJustice", Open_Form},
			{"Run_Data", Open_Form},
			{"Run_Data_Evt", Open_Form},
			{"Event_Entry", Open_Form},
			{"Update_Assignments", Update_Assignments},
			{"Parks_Event", Open_Form},
			{"Contact_Info", Open_Form},
			{"Status", Status},
			{"Open_Event", Open_Form},
			{"Clear_Evt", Clear_Evt},
			{"Alarm", Open_Form},
			{"Hang_Up", quickCall},
			{"No_One", quickCall},
			{"No_Response", quickCall},
			{"Wrong_Number", quickCall},
			{"Cen_Erg", Open_Guide},
			{"Ti_Erg", Open_Guide},
			{"Fl_Erg", Open_Guide},
			{"Status_Sheet", Open_Excel},
			{"Schedule", Open_Excel},
			{"Add_Resc", Open_Form},
			{"Court_Lookup", Open_Form},
			{"Change_Password", Open_Form},
			{"Search_Calls", Open_Form},
			{"Search_Events", Open_Form},
			{"Closed_Events", Open_Form},
			{"Search_People", Open_Form},
			{"Search_Vehicles", Open_Form},
			{"Monthly_Reports", Open_Form},
			{"Approve_Users", Open_Form},
			{"Remove_Users", Open_Form},
			{"Edit_Officers", Open_Form},
			{"Open_Inbox", Open_Form},
			{"Registration", Open_Form},
			{"Settings", Open_Form}
		};
		
		//main method to check the button name and call the corresponding method
		public static void checkButton(string buttonTag, int id1, int idType1){
			//set the id, idType, and button tag variable from the parameters passed during the button click
			id = id1;
			idType = idType1;
			tag = buttonTag;
			cad = (CAD) Application.OpenForms["CAD"];
			
			//loop through each item in the dictionary
			foreach (KeyValuePair<string, Func<bool>> element in functions) {
				//when the item with the matching button tag is found
				if(element.Key.Equals(buttonTag))
				{
					//call the corresponding function
					functions[element.Key] ();
					//break out of the loop
					break;
				}
			}
		}
		
		#region CAD specific button methods
		//method to open a form
		private static bool Open_Form(){
			Browser b = null;
			Assignment a = null;
			
			switch (tag) {
				case "Call_Entry": //call entry button on main CAD form
				case "Call_Entry_Ofc": //call entry button from officer control
				case "Call_Entry_Evt": //call entry button from event control
					//create a new enter call form using the id and idtype from the button click and the user from the cad form
					EnterCall e = new EnterCall(id, idType, cad.getUser());
					//show the enter call form
					e.Show(cad);
					break;
				case "eJustice": //ejustice button from main CAD form
					//create a new assignment
					a = new Assignment();
					//create a new browser object
					b = new Browser("dispatch", 0, a, "e", null);
					b.Show(); //show the new browser object
					break;
				case "Open_Inbox": //inbox button from the main CAD form
					//create a new assignment
					a = new Assignment();
					//create a new browser object
					b = new Browser("inbox", 0, a, "e", null);
					b.Show(); //show the new browser object
					break;
				case "Run_Data": //run data button from main CAD form
					//create a new run data form
					RunData rd = new RunData();
					rd.Show(cad);
					break;
				case "Run_Data_Evt": //run data button from event entry form
					RunData rd2 = new RunData(id);
					rd2.Show(cad);
					break;
				case "Event_Entry": //event entry button from CAD form
					New_Event_Form ef = new New_Event_Form(cad.getUser());
					ef.Show(cad);
					break;
				case "Parks_Event": //event button on officer control
					a = new Assignment(id, true);
					b = new Browser("newEvent", 0, a, "p", null);
					b.Show(cad);
					break;
				case "Contact_Info": //contact info button from the officer control
					ContactForm cf = new ContactForm(id);
					cf.Show(cad);
					break;
				case "Open_Event": //open event button from the event control
					break;
				case "Alarm": //alarm button from the main CAD form
					break;
				case "Add_Resc": //additional resources button from the main CAD form
					Resources r = new Resources();
					r.Show(cad);
					break;
				case "Court_Lookup": //court lookup button from the main CAD form
					//if form is not already open
					if(!formOpen("CourtLookup"))
					{
						//create a new courtlookup form
						CourtLookup ct = new CourtLookup();
						//show the court lookup form
						ct.Show(cad);
					}
					break;
				case "Change_Password": //change password button from the main CAD form
					if(!formOpen("Change_Password"))
					{
						//create a new Registration form
						Change_Password cp = new Change_Password();
						//show the form
						cp.Show(cad);
					}
					break;
				case "Search_Calls": //search calls button from the main CAD form
					SearchLog sl = new SearchLog();
					sl.Show();
					break;
				case "Search_Events": //search events button from the main CAD form
					Search_Events se = new Search_Events();
					se.Show();
					break;
				case "Closed_Events": //search closed events button from the main CAD form
					Closed_Events ce = new Closed_Events();
					ce.Show();
					break;
				case "Search_People": //search people button from the main CAD form
					break;
				case "Search_Vehicles": //search vehicles button from the main CAD form
					break;
				case "Monthly_Reports": //monthly reports button from the main CAD form
					break;
				case "Approve_Users": //approve users button from the admin section of the main CAD form
					break;
				case "Remove_Users": //remove users button from the admin section of the main CAD form
					break;
				case "Edit_Officers": //edit officers button from the admin section of the main CAD form
					break;
				case "Settings":
					if(!formOpen("Settings"))
					{
						Login l = (Login) Application.OpenForms["Login"];
						//create a new enter call form using the id and idtype from the button click and the user from the cad form
						Settings s = new Settings(l.getUser());
						//show the enter call form
						s.Show(cad);
					}
					break;
				//case "Registration": //Registration form
				//	if(!formOpen("Registration"))
				//	{
				//		//create a new Registration form
				//		Registration_Form rg = new Registration_Form();
				//		//show the form
				//		rg.Show();
				//	}
				default:
					break;
			}
			return true;
		}
		
		//method that will call the update assignments
		private static bool Update_Assignments()
		{
			Tools.Impersonate("UpdateParksAssignments");
			return true;
		}
		
		//method that will add a status call to the selected event
		private static bool Status()
		{
			return true;
		}
		
		//method that will clear the selected event
		private static bool Clear_Evt()
		{
			return true;
		}
		
		//method that will enter a quick call
		private static bool quickCall()
		{
			//set the sql string to an empty string
			string sql = "";
			//set the narrative to be entered to an empty string			
			string narrative = "";
			
			//switch case on the button tag
			switch (tag) {
				case "Hang_Up": //hang up button clicked
					//set the narrative to hang up
					narrative = "Hang up";		
					break;
				case "No_One": //no one on the line button clicked
					//set the narrative to no one on the line
					narrative = "No one on the line";
					break;
				case "Wrong_Number": //wrong number button clicked
					//set the narrative to show that someone called the wrong number
					narrative = "Wrong number";
					break;
				case "No_Response": //no response button clicked
					//set the value string to an empty string
					string value = "";
					
					//show an input box to have the user input the information regarding the call that wasn't answered
					//if the button clicked on the input form is ok
					if (InputBox.Show("No Response", "Please enter the unit called, location, and method of contact.", ref value) == DialogResult.OK)
					{
						//set the narrative of the call to the value that the user entered on the input form
		  				narrative = value;
					}
					break;
				default:
					break;
			}			
			//get the user from the CAD form
			User cu = cad.getUser();
			//generate sql to insert the call
			sql = @"INSERT INTO commlog (Date1, Time1, UnitCalled, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"
				+ DateTime.Today.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToString("HH:mm") + "', '', 'PHONE', '"
				+ "OTHER', '" + narrative + "', " + cu.getDispatchId() + ")";
			//run the sql to insert the sql
			Tools.runSql(sql, "cad");
			//refresh the call screen
			Tools.requeryUserControls("c");
			
			return true;
		}
		
		//method that will open up the emergency guides
		private static bool Open_Guide()
		{
			int zoneId = 0;
			switch (tag) {
				case "Cen_Erg": //central zone button clicked
					//set the zone to 5
					zoneId = 5;					
					break;
				case "Fl_Erg": //finger lakes zone button clicked
					//set the zone to 6
					zoneId = 6;
					break;
				case "Ti_Erg": //thousand islands zone button clicked
					//set the zone to 1
					zoneId = 1;
					break;
				default:
					break;
			}
			
			//TODO
			//need to open the emergency guide forms
			//create a new emergency reference guide form for the selected zone
			ERG erg = new ERG(zoneId);
			erg.Show(); //show the new form
			return true;
		}
		
		//method that will open an excel file based on the tag name passed in to the cad_button class
		private static bool Open_Excel()
		{
			//if the status sheet button is clicked
			if(tag == "Status_Sheet")
			{
				//open the script that will open the status check sheet
				Process.Start("openExcel.vbs", "status");
			}
			//if the schedule button is clicked
			else if(tag == "Schedule")
			{
				//set the file name variable to an empty string
				string fileName = "";
				//create variables that will hold the start and end dates
				DateTime startDate;
				DateTime endDate;
				
				//set a variable containing todays date
				DateTime todayDate = DateTime.Today;
				
				//get a a dataset containing all of the records in the schedule dates table
				DataSet ds = Tools.GetDataSet("SELECT * FROM ScheduleDates", "cad");
				
				//clear the tools dataset
				Tools.clearDataset();
				
				//loop through each row in the dataset
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					//set the start date to the start date from the data row
					startDate = DateTime.Parse(row["BeginDate"].ToString());
					//set the end date to the end date from the data row
					endDate = DateTime.Parse(row["EndDate"].ToString());
					
					//check todays date compared to the start and end dates from the schedule
					if(DateTime.Compare(todayDate, startDate) >= 0 && DateTime.Compare(todayDate, endDate) <= 0)
					{
						//if today is later than the start of the schedule and earlier than the end of the schedule
						//set the filename of the schedule to be opened
						fileName = row["FileName"].ToString();
					}
				}
				
				//open the external script to open the schedule, passing in the filename as a parameter
				Process.Start("openExcel.vbs", "sched \"" + fileName + "\"");
			}

			return true;
		}
		#endregion
		
		//method that checks if form is open or not
		private static bool formOpen(string formName)
		{
			//loop through all open forms
			foreach (Form f in Application.OpenForms) {
				//if the form is found open return true
				if(f.Name.Equals(formName))
					return true;
			}
			
			//if form not found open return false
			return false;
		}
	}
}
