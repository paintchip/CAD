/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 7/31/2015
 * Time: 8:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using System.Diagnostics;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// static class to perform database calls
	/// </summary>
	public static class Tools
	{	
		//static DataSet mDS = new DataSet();
		static string databaseLocation = "";
		static string conPre = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
		
		// obtains user token
	    [DllImport("advapi32.dll", SetLastError = true)]
	    private static extern bool LogonUser(string pszUsername, string pszDomain, string pszPassword,
	        int dwLogonType, int dwLogonProvider, ref IntPtr phToken);
	
	    // closes open handes returned by LogonUser
	    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	    private extern static bool CloseHandle(IntPtr handle);
		
		//this function checks the local cfg file to determine database names and locations
		public static void SetDatabaseLocation(string databasetype)
		{
			//set the search string that we are looking for in the text file
			string searchString = databasetype + "_location";
			//read all lines from the text file into an array of strings
			string[] lines = System.IO.File.ReadAllLines(@"cfg.txt");
			
			//loop through each line from the text file
			foreach (string line in lines)
			{
				int x = searchString.Length;
				if(line.Substring(0,x).Equals(searchString)) //if the search string is found at the beginning of the line, grab location
				{
					databaseLocation = line.Substring(line.IndexOf('=')+1);
					return;
				}
			}
		}
		
		//this function will return a dataset based on the sql query passed in
		public static DataSet GetDataSet(string sql, string databasetype){
			DataSet mDS = new DataSet();
			//set the database location
			SetDatabaseLocation(databasetype);
			
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;

			OleDbConnection mAC = null;
			
			//try to connect to the database
			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
				return mDS;
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{
				OleDbCommand mAccCom = new OleDbCommand(sql, mAC);
				OleDbDataAdapter mDA = new OleDbDataAdapter(mAccCom);
				
				mAC.Open();
				mDA.Fill(mDS);
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
				return mDS;
			}
			finally
			{
				mAC.Close();
			}
		
			//return the dataset
			return mDS;
		}
		
		//function to clear the dataset
		public static void clearDataset(){
			DataSet mDS = new DataSet();
			mDS = new DataSet();
		}
		
		//functin to run sql that doesn't return a dataset
		public static void runSql(string sql, string databasetype)
		{
			DataSet mDS = new DataSet();
			//set the database location
			SetDatabaseLocation(databasetype);
			
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;
			OleDbConnection mAC = null;
			
			//try to connect to the database
			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{
				OleDbCommand mAccCom = new OleDbCommand(sql, mAC);
				OleDbDataAdapter mDA = new OleDbDataAdapter(mAccCom);
				
				mAC.Open();
				mDA.Fill(mDS);
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show("Execution Error: " + ex.Message);
			}
			finally
			{
				mAC.Close();
			}
			
			clearDataset();
		}
		public static void runSqlList(List<string> sql_list, string databasetype)
		{
			DataSet mDS = new DataSet();
			//set the database location
			SetDatabaseLocation(databasetype);
			
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;
			OleDbConnection mAC = null;
			
			//try to connect to the database
			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{
				mAC.Open();
				for(int i = 0; i < sql_list.Count; i++)
				{
					OleDbCommand mAccCom = new OleDbCommand(sql_list[i], mAC);
					OleDbDataAdapter mDA = new OleDbDataAdapter(mAccCom);
					mDA.Fill(mDS);	
				}
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show("Execution Error: " + ex.Message);
			}
			finally
			{
				mAC.Close();
			}
			
			clearDataset();
		}
		
		//this function will return the id of the last entered record
		public static int GetLastID(string sql, string databasetype){
			int id;
			string sqlComm = sql;
			
			//set the database location
			SetDatabaseLocation(databasetype);
			
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;

			OleDbConnection mAC = null;

			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
				return 0;
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{
				OleDbCommand mAccCom = new OleDbCommand(sql, mAC);
				
				mAC.Open();
				mAccCom.ExecuteNonQuery();
				mAccCom.CommandText = "SELECT @@IDENTITY";
				
				id = (int) mAccCom.ExecuteScalar();
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
				return 0;
			}
			finally
			{
				mAC.Close();
			}
			
			//return the id
			return id;
		}
		
		//this method will requery the call, events, and officers user controls
		public static void requeryUserControls(string ctls){
			//if there is a c in the ctls string
			if(ctls.IndexOf('c') > -1)
			{
				//requery the call control
				requeryCallControl();
			}
			
			//if there is an e in the ctls string
			if(ctls.IndexOf('e') > -1)
			{
				//requery the event control
				requeryEventControl();
			}
			
			//if there is an o in the ctls string
			if(ctls.IndexOf('o') > -1)
			{
				//requery the officer control
				requeryOfficerControl();
			}
		}
		
		//this method will requery the call control
		private static void requeryCallControl()
		{
			//loop through all of the open forms
			foreach (Form f in Application.OpenForms) {
				//if the form name is CAD or ComponentForm
				if(f.Name.Equals("CAD") || f.Name.Equals("ComponentForm"))
			  	{
					//loop through all of the controls in the open form
					foreach (Control ctl in f.Controls) {
						//if the control is CAD_Calls control
						if(ctl is CAD_Calls)
						{
							//call the update method of the call control
							CAD_Calls c = (CAD_Calls) ctl;
							c.UpdateCalls();
						}
					}   	
				}
			}
		}
		
		//this method will requery the event control
		private static void requeryEventControl()
		{
			//loop through all of the open forms
			foreach (Form f in Application.OpenForms) {
				//if the form name is CAD or ComponentForm
				if(f.Name.Equals("CAD") || f.Name.Equals("ComponentForm"))
			  	{
					//loop through all of the controls on the form
					foreach (Control ctl in f.Controls) {
						//if the control is a CAD_Events control
						if(ctl is CAD_Events)
						{
							//call the update method of the event control
							CAD_Events c = (CAD_Events) ctl;
							c.UpdateEvents();
						}
					}   	
				}
			}
		}
		
		//this method will requery the officer control
		private static void requeryOfficerControl()
		{
			//loop through all of the open forms
			foreach (Form f in Application.OpenForms) {
				//if the form name is CAD or ComponentForm
				if(f.Name.Equals("CAD") || f.Name.Equals("ComponentForm"))
			  	{
					//loop through all of the controls on the form
					foreach (Control ctl in f.Controls) {
						//if the control is a CAD_Officers control
						if(ctl is CAD_Officers)
						{
							//call the update method of the call control
							CAD_Officers c = (CAD_Officers) ctl;
							c.UpdateOfficers();
						}
					}   	
				}
			}
		}
		
		//this method is used to remove illegal characters from a sql statement
		public static string sanitize(string str)
		{
			//create a string builder object the length of the string passed as a parameter
			StringBuilder sb = new StringBuilder(str.Length);
			
			//loop through each character in the passed in string
			foreach (char c in str) {
				//if the character is not the backslash
				if(!c.Equals('\''))
				{
					//add the character to the string builder object
					sb.Append(c);
				}
			}
			
			//convert the string builder object to a string and return the string
			return sb.ToString();
		}
		
		//this method will be used to format strings as a phone number
		public static string formatPhone(string str)
		{
			//declare a variable that will hold the formatted string
			string formattedString = "";
			//variable that will hold the char code of a character
			int charCode = 0;
			
			//check if the length is 10 for a phone number
			if(str.Length == 10)
			{
				//create an array of characters from the string
				char[] chars = str.ToCharArray();

				//loop through each character in the string to make sure it is a number
				for(int x = 0; x < 10; x++)
				{
					//cast the character to an integer to get the character code
					charCode = (int) chars[x];

					//check if the character is a number, if not return the original string
					if(charCode < 48 || charCode > 57)
					{
						return str;
					}
				}
				
				//format the string as a phone number
				formattedString = "(" + str.Substring(0,3) + ") " + str.Substring(3,3) + "-" + str.Substring(6);
				return formattedString; //return the formatted string
			}
			else //if not the right length, return the original string
			{
				return str;
			}
		}
		
		//impersonation function for connecting to PARKS database
		public static void Impersonate(String procedure) {
	        //elevate privileges before doing file copy to handle domain security
	        WindowsImpersonationContext impersonationContext = null;
	        IntPtr userHandle = IntPtr.Zero;
	        const int LOGON32_PROVIDER_DEFAULT = 0;
	        const int LOGON32_LOGON_INTERACTIVE = 2;
	        string domain = "OPRHP";
	        string user = "ParkPoliceWebUser";
	        string password = "ParkPoliceWebUser";
			List<Assignment> assignments = null;

	        
	        try {
	            //MessageBox.Show("windows identify before impersonation: " + WindowsIdentity.GetCurrent().Name);
	
	            // if domain name was blank, assume local machine
	            if (domain == "")
	                domain = System.Environment.MachineName;
	
	            // Call LogonUser to get a token for the user
	            bool loggedOn = LogonUser(user,
	                                        domain,
	                                        password,
	                                        LOGON32_LOGON_INTERACTIVE,
	                                        LOGON32_PROVIDER_DEFAULT,
	                                        ref userHandle);
	
	            if (!loggedOn) {
	                MessageBox.Show("Exception impersonating user, error code: " + Marshal.GetLastWin32Error());
	                return;
	            }
	
	            // Begin impersonating the user
	            impersonationContext = WindowsIdentity.Impersonate(userHandle);
	 			//MessageBox.Show("Main() windows identify after impersonation: " + WindowsIdentity.GetCurrent().Name);
	           
	            //run the program with elevated privileges (connecting to PARKS sql server and putting the assignments in a text file for use in the CAD)
	            if(procedure.Equals("UpdateParksAssignments"))
	            {
	            	assignments = getParksAssignments();
	            }
	
	        } catch (Exception ex) {
	            MessageBox.Show("Exception impersonating user: " + ex.Message);
	        } finally {
	        	//Console.ReadLine();
	            // Clean up
	            if (impersonationContext != null) {
	                impersonationContext.Undo();
	            }
	
	            if (userHandle != IntPtr.Zero) {
	                CloseHandle(userHandle);
	            }
	        }
			
			if(procedure.Equals("UpdateParksAssignments") && assignments != null)
			{
				saveAssignments(assignments);
			}
	    }
		
		public static List<Assignment> getParksAssignments() {
			//connection string
	        string cs = @"Data Source=albsqlpolice\albsqlpolice;Initial Catalog=PoliceBlotter;Integrated Security=SSPI;";
	        //sql to select only assignments with no end time
	        string sql = @"SELECT Assignment_Primary.Officer_Id, Assignment_Primary.Assignment_Id, Assignment_Secondary.Secondary_Id, Assignment_Primary.Start_Date, Assignment_Primary.Start_Time, Assignment_Primary.End_Time, Assignment_Secondary.RIN, Codes.Description
						FROM Codes INNER JOIN (Assignment_Primary INNER JOIN Assignment_Secondary ON Assignment_Primary.Assignment_Id = Assignment_Secondary.Assignment_Id) ON Codes.Code_Id = Assignment_Secondary.Assign_Id
						WHERE (((Assignment_Primary.End_Time) Is Null))
						ORDER BY Assignment_Primary.Officer_ID, Assignment_Secondary.Secondary_Id ASC";
	        
	        SqlCommand cmd;
	        SqlDataReader dataReader;
	        
	        //list that will contain all of the assignments returned from the database
	        List<Assignment> assign = new List<Assignment>();
	        
	        //set the sql connection to the connection string
	        SqlConnection cnn = new SqlConnection(cs);
	        
	        try
	        {
	        	//open the connection
	        	cnn.Open();
	        	//sets the datareader to the returned data
	        	cmd = new SqlCommand(sql, cnn);
	        	dataReader = cmd.ExecuteReader();
	        	cmd.CommandTimeout = 3600;
	        	
	        	//for each row returned, create an assignment object and add it to the list
	        	while (dataReader.Read() && dataReader.HasRows)
	        	{
	        		Assignment asst = new Assignment();
	        		
	        		asst.OfficerId = Int32.Parse(dataReader[0].ToString());
	        		asst.AssignmentId = Int32.Parse(dataReader[1].ToString());
	        		asst.SecondaryId = Int32.Parse(dataReader[2].ToString());
	        		asst.StartTime = dataReader[4].ToString();
	        		asst.CarNo = dataReader[6].ToString();
	        		asst.Description = dataReader[7].ToString();
	        		
	        		assign.Add(asst);
	        	}
	        	//close the datareader and the connection to the sql database
	        	dataReader.Close();
	        	cmd.Dispose();
	        	cnn.Close();
	        }
	        catch (Exception ex)
	        {
	        	//print out any error messages
	        	MessageBox.Show(ex.ToString());
	        	return null;
	        }
	       	        
	        return assign;
	    }
		
		public static void saveAssignments(List<Assignment> assign)
		{
			//set the database location
			SetDatabaseLocation("cad");
			
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;

			OleDbConnection mAC = null;
			
			//try to connect to the database
			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{					
				int avail; //designates whether the officer is available or not, 1 is available
				OleDbCommand sql;
				//keep connection open during looping process below
				mAC.Open();
				
				//clear the assignments table
				sql = new OleDbCommand("UPDATE parksIDs SET Isv = 0, Avail = 0, AssId = 0, SecondaryId = 0, CarNo = '', StartTime = ''", mAC);
				sql.ExecuteScalar();
		        
		        //loop through each assignment and update the tables with new assignment information
		        foreach (Assignment aObj in assign) {
					switch(aObj.Description) //determine availability
					{
						case "Sick Leave":
						case "Personal Leave":
						case "Annual Leave":
						case "Other Leave":
						case "Administration":
						case "Desk":
						case "Training":
						case "Academy":
							avail = 0;
							break;
						default:
							avail = 1;
							break;
					}
	
					sql = new OleDbCommand(@"UPDATE parksIDs SET Isv=1, Avail=" + avail + ", AssId=" + aObj.AssignmentId +
	               		", SecondaryId=" + aObj.SecondaryId + ", CarNo='" + aObj.CarNo + "', StartTime='" +
	               		aObj.StartTime + "' WHERE pId = " + aObj.OfficerId, mAC);
					sql.ExecuteScalar();
		        }
		        
		        requeryOfficerControl();
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show("Execution Error: " + ex.Message);
			}
			finally
			{
				mAC.Close();
			}
		}
		
		//Method for taking a list of people information from a table query and turning it into a list of peopl that can be used for datagrid binding
		public static List<Person> People_parser(List<string> people)
		{
			List<Person> plp_lst = new List<Person>();
			for(int i = 0; i < (people.Count / 13); i++)
			{
				List<string> tmp_lst = new List<string>();
				tmp_lst.Add(people[i * 13]);
				tmp_lst.Add(people[(i * 13) + 1]);
				tmp_lst.Add(people[(i * 13) + 2]);
				tmp_lst.Add(people[(i * 13) + 3]);
				tmp_lst.Add(people[(i * 13) + 4]);
				tmp_lst.Add(people[(i * 13) + 5]);
				tmp_lst.Add(people[(i * 13) + 6]);
				tmp_lst.Add(people[(i * 13) + 7]);
				tmp_lst.Add(people[(i * 13) + 8]);
				tmp_lst.Add(people[(i * 13) + 9]);
				tmp_lst.Add(people[(i * 13) + 10]);
				tmp_lst.Add(people[(i * 13) + 11]);
				tmp_lst.Add(people[(i * 13) + 12]);
				Person tmp_person = new Person(tmp_lst);
				plp_lst.Add(tmp_person);
			}
			return plp_lst;
		}
		public static List<Vehicle> Vehicle_parser(List<string> vehicles)
		{
			List<Vehicle> veh_lst = new List<Vehicle>();
			for(int i = 0; i < (vehicles.Count / 12); i++)
			{
				List<string> tmp_lst = new List<string>();
				tmp_lst.Add(vehicles[i * 12]);
				tmp_lst.Add(vehicles[(i * 12) + 1]);
				tmp_lst.Add(vehicles[(i * 12) + 2]);
				tmp_lst.Add(vehicles[(i * 12) + 3]);
				tmp_lst.Add(vehicles[(i * 12) + 4]);
				tmp_lst.Add(vehicles[(i * 12) + 5]);
				tmp_lst.Add(vehicles[(i * 12) + 6]);
				tmp_lst.Add(vehicles[(i * 12) + 7]);
				tmp_lst.Add(vehicles[(i * 12) + 8]);
				tmp_lst.Add(vehicles[(i * 12) + 9]);
				tmp_lst.Add(vehicles[(i * 12) + 10]);
				tmp_lst.Add(vehicles[(i * 12) + 11]);
				Vehicle tmp_veh = new Vehicle(tmp_lst); 
				veh_lst.Add(tmp_veh);
			}
			return veh_lst;
		}
		//This is an ofdd parser created specifically for the event searcher and closed event forms. These really only need an associated number, but I am setting it up right just in case we decide to add mroe in later
		public static List<Event> Short_Event_Parser(List<String> events)
		{
			//The event constructor is set up to take infor for creating PARKS events. I just stuffed the info where I could.
			List<Event> evt_lst = new List<Event>();
			for(int i = 0; i < (events.Count / 6); i++)
			{
				List<string> tmp_lst = new List<string>();
				tmp_lst.Add(Convert.ToDateTime(events[i * 6]).ToString("MM/dd/yyyy"));
				tmp_lst.Add(Convert.ToDateTime(events[i * 6]).ToString("MM/dd/yyyy"));
				tmp_lst.Add(Convert.ToDateTime(events[(i * 6) + 1]).ToString("HH:mm"));
				tmp_lst.Add(Convert.ToDateTime(events[(i * 6) + 1]).ToString("HH:mm"));
				tmp_lst.Add(Convert.ToDateTime(events[(i * 6) + 1]).ToString("HH:mm"));
				tmp_lst.Add(Convert.ToDateTime(events[(i * 6) + 1]).ToString("HH:mm"));
				tmp_lst.Add(Convert.ToDateTime(events[(i * 6) + 1]).ToString("HH:mm"));
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add("0");
				tmp_lst.Add(events[(i * 6) + 3]);
				tmp_lst.Add(events[(i * 6) + 2]);
				tmp_lst.Add(events[(i * 6) + 4]); //There is no Officer location in the event class (not really necessary). I a'm just going to use the unused bsiness slot to hold the name for the screen
				tmp_lst.Add(events[(i * 6) + 5]);
				tmp_lst.Add(events[i * 6]);
				Event tmp_evt = new Event(tmp_lst);
				evt_lst.Add(tmp_evt);
			}
			return evt_lst;
		}
		//Method for fetching a value from a table with an int search value
		public static string tableQuery(string table_name, string search_field, string search_value, string desired_field, bool search_value_type_int)
		{
			string sqlStr = "";
			switch (search_value_type_int)
			{
				//for int search values
				case true:
					sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = " + Int32.Parse(search_value);
					break;
				//for string
				case false:
					sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = '" + search_value + "'";
					break;
			}
			Tools.clearDataset();
			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
			if (mDS.Tables[0].Rows.Count > 0)
			{
				DataRow r = mDS.Tables[0].Rows[0];
				string return_value = r[desired_field].ToString();
				clearDataset();
				return return_value;
			}
			else 
			{
				clearDataset();
				return "-1 Your sql expression - " + sqlStr + " - returned no results.";
			}
		}
		//This will allows a single search term to return multiple values. need to figure out a way to allow multiple return types for a single method
//		public static List<string> tableQuery(string table_name, string search_field, string search_value, string desired_field, bool search_value_type_int)
//		{
//			string sqlStr = "";
//			switch (search_value_type_int)
//			{
//				//for int search values
//				case true:
//					sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = " + Int32.Parse(search_value);
//					break;
//				//for string
//				case false:
//					sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = '" + search_value + "'";
//					break;
//			}
//			Tools.clearDataset();
//			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
//			List<string> values = new List<string>();
//			if (mDS.Tables[0].Rows.Count >= 1)
//			{
//				
//				foreach (DataRow r in mDS.Tables[0].Rows())
//				{
//					values.Add(r[desired_field].ToString());
//				}
//				return values;
//			}
//			else 
//				{
//				values.Add("Your sql expression - " + sqlStr + " - returned no results.");
//				return values;
//				}
//		}
		//Method for fetching multiple values from a table with lists. This could possible replace the above one, but I would prefer not having to create an list every time I want to pass in a single value
		public static List<string> tableQuery(string table_name, string search_field, string search_value, List<string> desired_fields, bool search_value_type_int )
		{
			List<string> values = new List<string>();
			string sqlStr = "";
			switch (search_value_type_int)
			{
				//for int search values
				case true:	
					sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = " + Int32.Parse(search_value);
					break;
				//for string
				case false:
					if (search_value == "" && search_field == "")
					{
						sqlStr = "SELECT * FROM " + table_name;
					}
					else
					{
						sqlStr = "SELECT * FROM " + table_name + " WHERE " + search_field + " = '" + search_value + "'";
					}
					break;
			}
			Tools.clearDataset();
			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
			if (mDS.Tables[0].Rows.Count >= 1)
			{
				foreach (DataRow r in mDS.Tables[0].Rows) {
				//DataRow r = mDS.Tables[0].Rows[0];
					foreach (string element in desired_fields) {
						values.Add(r[element].ToString());	
					}
				}
			Tools.clearDataset();
			return values;
			}
			else 
			{
				values.Add("-1 Your sql expression - " + sqlStr + " - returned no results.");
				Tools.clearDataset();
				return values;
			}
		}
		
		//method to save settings in table
		public static void SaveFormSettings(List<formSettings> fSettings, int dispatcherID)
		{
			SetDatabaseLocation("cad");
			string sqlCommand;				
			//create the connection string from the connection prefix and database location
			string conStr = conPre + databaseLocation;

			OleDbConnection mAC = null;
			
			//try to connect to the database
			try
			{
				mAC = new OleDbConnection(conStr);
			}
			catch(Exception ex) //if cannot connect, advise user and return an empty dataset
			{
				MessageBox.Show(ex.Message);
			}
			
			//try to execute the sql command and save the results to the dataset
			try
			{
				OleDbCommand sql;
				//keep connection open during looping process below
				mAC.Open();
				
				//clear the settings table of all settings for current dispatcher
				sql = new OleDbCommand("DELETE FROM FormSettings WHERE dispatchID = " + dispatcherID, mAC);
				sql.ExecuteScalar();
		        
		        //loop through each assignment and update the tables with new assignment information
		        foreach (formSettings f in fSettings) {
					sqlCommand = @"INSERT INTO FormSettings (dispatchID, formName, loc_x, loc_y, size_h, size_w)
						VALUES (" + dispatcherID + ", '" + f.FormName + "', " + f.FormLocation.X + ", " + f.FormLocation.Y
						+ ", " + f.FormSize.Height + ", " + f.FormSize.Width + ")";
					
					sql = new OleDbCommand(sqlCommand, mAC);
					sql.ExecuteScalar();
		        }
			}
			catch(Exception ex) //if cannot execute sql, advise user and return an empty dataset
			{
				MessageBox.Show("Execution Error: " + ex.Message);
			}
			finally
			{
				mAC.Close();
			}
		}
		
		public static int Date_Fixer(ref string date)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(date, "^\\d{1,2}/\\d{1,2}/\\d{4}$") || System.Text.RegularExpressions.Regex.IsMatch(date, "^\\d{1,2}/\\d{1,2}/\\d{2}$"))
			{
				string[] date_array = date.Split('/');
				if (System.Text.RegularExpressions.Regex.IsMatch(date_array[0],"^\\d{1}$")) //If month is only one number make it two
			    {
				    	date_array[0] = "0" + date_array[0];
			    }
				if (System.Text.RegularExpressions.Regex.IsMatch(date_array[1],"^\\d{1}$")) //If day is only one number make it two
			    {
				    	date_array[1] = "0" + date_array[1];
			    }
				if (System.Text.RegularExpressions.Regex.IsMatch(date_array[2],"^\\d{2}$")) //If year is only two number make it four
			    {
				    	date_array[2] = "20" + date_array[2];
			    }
				//Clearing the date string and putting the new date in
				date = "";
				date = string.Join("/", date_array);
				return 0;
			}
			else
				return 1; //The string was not in the correct format so kick back a number for failure
		}
		public static void LocationTableFixer()
		{
			//This is just a method I'm going to use to set all of the pid values in the New locations table.
			//These were all run separately so there will be declaration conflicts
//			string sql = @"Update locations set ZonePID= 1 WHERE ZONE= 'THOUSAND ISLANDS'";
//		    Tools.runSql(sql, "cad");
//			sql = @"Update locations set ZonePID= 5 WHERE ZONE= 'CENTRAL'";
//			Tools.runSql(sql, "cad");
//		    sql = @"Update locations set ZonePID= 6 WHERE ZONE= 'FINGER LAKES'";
//			Tools.runSql(sql, "cad");
			
//			string sql = @"Update locations set StationPID= 3109 WHERE station= '1'";
//		    Tools.runSql(sql, "cad");
//			sql = @"Update locations set StationPID= 1274 WHERE station= '2'";
//			Tools.runSql(sql, "cad");
//		    sql = @"Update locations set StationPID= 436 WHERE station= '3'";
//			Tools.runSql(sql, "cad");
//			sql = @"Update locations set StationPID= 437 WHERE station= '4'";
//			Tools.runSql(sql, "cad");
//		    sql = @"Update locations set StationPID= 1949 WHERE station= '5'";
//			Tools.runSql(sql, "cad");
			
//			List<string> Counties = new List<string>();
//			string sqlStr = "SELECT * FROM AllCounties";
//			Tools.clearDataset();
//			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
//			if (mDS.Tables[0].Rows.Count >= 1)
//			{
//				foreach (DataRow r in mDS.Tables[0].Rows) {
//				//DataRow r = mDS.Tables[0].Rows[0];
//						Counties.Add(r["County"].ToString());
//						Counties.Add(r["pID"].ToString());
//				}
//			}
//			for(int i = 0; i < Counties.Count; i = i + 2)
//			{
//				string sql = @"Update locations set CountyPID= " + Counties[i + 1] + " WHERE county= '" + Counties[i] + "'";
//				Tools.runSql(sql, "cad");
//			}
			
//			string sql = @"Update ParksFL set StationPID= 3109 WHERE Station= 1";
//		    Tools.runSql(sql, "cad");
//			sql = @"Update ParksFL set StationPID= 1274 WHERE Station= 2";
//			Tools.runSql(sql, "cad");
//		    sql = @"Update ParksFL set StationPID= 436 WHERE Station= 3";
//			Tools.runSql(sql, "cad");
//			sql = @"Update ParksFL set StationPID= 437 WHERE Station= 4";
//			Tools.runSql(sql, "cad");
//		    sql = @"Update ParksFL set StationPID= 1949 WHERE Station= 5";
//			Tools.runSql(sql, "cad");
			
//			List<string> Counties = new List<string>();
//			string sqlStr = "SELECT * FROM AllCounties";
//			Tools.clearDataset();
//			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
//			if (mDS.Tables[0].Rows.Count >= 1)
//			{
//				foreach (DataRow r in mDS.Tables[0].Rows) {
//				//DataRow r = mDS.Tables[0].Rows[0];
//						Counties.Add(r["County"].ToString());
//						Counties.Add(r["pID"].ToString());
//				}
//			}
//			for(int i = 0; i < Counties.Count; i = i + 2)
//			{
//				string sql = @"Update ParksTI set CountyPID= " + Counties[i + 1] + " WHERE county= '" + Counties[i] + "'";
//				Tools.runSql(sql, "cad");
//			}
			
		}
	}
}

