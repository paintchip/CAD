/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 10/1/2015
 * Time: 5:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
namespace NYSPP_CAD
{
	/// <summary>
	/// Description of View_Event_Form.
	/// </summary>
	public partial class View_Event_Form : baseform
	{

		private int id;
		private string Map_location;
		private int shld_for_ass;
		private int pid;
		private	string old_nar;
		private string original_officer;
		public View_Event_Form(int eventid)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			id = eventid;
			basecontrols();
			InitializeComponent();
			this.plp_datagrid.ForeColor = System.Drawing.Color.Yellow; // These are refusing to set properly from the IDE and are erased by the IDE if i put them in the design file
			this.veh_datagrid.ForeColor = System.Drawing.Color.Yellow;
		}

		void View_Event_FormLoad(object sender, EventArgs e)
		{
			System.Threading.Thread LoadingThread; //I am going to attempt to make the form open more quickly for the user. I would liek the form to load instantly and have the lists fill in before the user actuall gets to click anything
			LoadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(BackLoad));
			LoadingThread.Start();
			
			string sqlStr = "SELECT * FROM events WHERE ID = " + id;
			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
			DataRow r = mDS.Tables[0].Rows[0];
			View_Event_Officer_combo.Text = r["Off"].ToString();
			View_Event_Date_fld.Text =  ((DateTime) r["EvtDate"]).ToString("MM/dd/yyyy");
			View_Event_time_fld.Text =  ((DateTime) r["OutTime"]).ToString("HH:mm");
			View_Event_addr_fld.Text =  r["Address"].ToString();
			View_Event_incident_fld.Text =  r["Type"].ToString(); // This and location need to be adjusted to show this value and then fill in the list like normal
			View_Event_park_combo.Text = r["Location"].ToString();
			View_Event_xst_fld.Text = r["Cross_Street"].ToString();
			View_Event_nar_fld.Text = r["Narrative"].ToString();
			old_nar = r["Narrative"].ToString();
			original_officer = r["Off"].ToString(); // This is so I can allow the user to save the event even if the officer is no longer on the list. Without this I cannot check to see if the officer entered is equal to the original. if it is not and the officer is not on the list, then I do not want to let them save the officer.
			//View_Event_com_list.Items.Add(r["Narrative"].ToString()); This will be a duplicate if you end up leaving the event category in the commlog. ou add the event number and then the call below takes in all calls with the current event number
			shld_for_ass = Int32.Parse(r["Shield"].ToString());
			pid = Int32.Parse(r["pid"].ToString());
			Map_location = r["MapLocation"].ToString(); //Saving this for the open map button
			
//			//create a dataset of all in-service officers
//			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC", "cad");
//			
//			//loop through all of the records in the in-service dataset
//			foreach (DataRow dr in ds.Tables[0].Rows) 
//			{
//				//add the current item to the drop down for the caller
//				string officer_name = dr["CarNo"].ToString() + " - " + dr["offLastName"].ToString();
//				View_Event_Officer_combo.Items.Add(new Officer(officer_name, Int32.Parse(dr["pZone"].ToString()),Int32.Parse(dr["OffShield"].ToString())));
//			}
//			
//			//adding associated people to the datagrid
//			List<string> person_values = new List<string>{"FirstName","LastName", "DOB", "Sex", "CID","State", "Middle", "Class", "Expiration", "StreetAddress", "County", "Municipality", "ZipCode"};
//			person_values = Tools.tableQuery("people", "Event", id.ToString(), person_values, true);
//			if (person_values[0].Substring(0,2) != "-1") //Don't bother with the rest if there are no people
//			{
//				List<Person> person_lst = new List<Person>();
//				person_lst = Tools.People_parser(person_values);
//				plp_datagrid.AutoGenerateColumns = false;
//				plp_datagrid.DataSource = person_lst;
//				string[] plp_flds = new string[4]{"LastName", "FirstName", "DateOfBirth", "LicenseNumber"};
//				int[] plp_col_width = new int[4]{95, 95, 70, 80};
//				Fill_grid(plp_datagrid, plp_flds, plp_col_width);
//			}
//			
//			//Doing the same with associated vehicles
//			List<string> vehicle_values = new List<string>{"PlateNumber", "VehYear", "VehMake", "VehModel", "VehColor", "VIN", "State","Status", "VehStyle", "Type", "Expiration", "PlateIssued"};
//			vehicle_values = Tools.tableQuery("vehicles", "Event", id.ToString(), vehicle_values, true);
//			if (vehicle_values[0].Substring(0,2) != "-1") //Don't bother with the rest if there are no vehicles
//			{
//				List<Vehicle> veh_lst = new List<Vehicle>();
//				veh_lst = Tools.Vehicle_parser(vehicle_values);
//				veh_datagrid.AutoGenerateColumns = false;
//				veh_datagrid.DataSource = veh_lst;
//				string[] veh_flds = new string[5]{"PlateNum", "VehYear", "VehColor", "VehMake", "VehModel"};
//				int[] veh_col_width = new int[5]{60, 45, 65, 95, 95};
//				Fill_grid(veh_datagrid, veh_flds, veh_col_width);
//			}
//			
//			//Adding incidents to list
//			List<string> incident_values = new List<string>();
//			incident_values.Add("Event_Type");
//			incident_values = Tools.tableQuery("EvtTypes", "", "" , incident_values , false);
//			for(int i = 0; i < incident_values.Count ; i++) 
//			{
//				View_Event_incident_fld.Items.Add(incident_values[i]);
//			}
//			
//			// getting all of the commlog enteries that have the same event id as the event clicked
//			sqlStr = "SELECT * FROM commlog WHERE Event = '" + id + "'"; 
//			mDS = Tools.GetDataSet(sqlStr, "cad");
//			foreach(DataRow row in mDS.Tables[0].Rows)
//			{
//				string call = row["Time1"].ToString() + " - " + row["Reason"].ToString() + " - " + row["Narrative"].ToString();
//				View_Event_com_list.Items.Add(call);
//			}
			
//			//Filling in the initial locations list based on the officer's shield
//			string off_zone = Tools.tableQuery("parksIDs", "offShield", shld_for_ass.ToString(), "pZone", true); // get the officer's zone to sort the initial locations list
//			Officer_drop_filler(Int32.Parse(off_zone));

			if (pid == 0)
			{
				Parks_created_lbl.Text = "A PARKS event has NOT been created for this event.";
			}
			else
			{
				Parks_created_lbl.Text = "A PARKS event has been created for this event.";
			}
		}
		
		void View_Event_Officer_comboDropDownClosed(object sender, EventArgs e)
		{
			shld_for_ass = ((Officer)View_Event_Officer_combo.SelectedItem).returnshield(); // This is so that the correct shield is saved when changing officers and saving the event
			Officer_drop_filler(((Officer)View_Event_Officer_combo.SelectedItem).returnid());
		}
		private void Officer_drop_filler(int off_zone)
		{
			string zone = "";
			string park_table = "";
			switch (off_zone) //I'm hardcoding in the region names to the numbers to avoid another table lookup
			{
				case 1:
					zone = "THOUSAND ISLANDS";
					park_table = "ParksTI_new";
					break;
				case 5:
					zone = "CENTRAL";
					park_table = "ParksCen_new";
					break;
				case 6:
					zone = "FINGER LAKES";
					park_table = "ParksFL_new";
					break;
				default:
					MessageBox.Show("The officer's zone is set outside of Mid-State");
					break;
			}
			View_Event_park_combo.Items.Clear(); // Clearing so that locations from other regions don't stay in the dropdown
			string sql = "SELECT * FROM " + park_table;
			DataSet ds = Tools.GetDataSet(sql, "cad"); 
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				View_Event_park_combo.Items.Add(dr["Park"]);
			}
			sql = "SELECT * FROM locations WHERE [Zone] = '" + zone + "'"; // adding locations based on officer zone
			ds = Tools.GetDataSet(sql, "cad"); 
			foreach (DataRow dr in ds.Tables[0].Rows)
			{	
				//You are checking to see if there is a / in the second character of the word indicating a T V or C. You are then taking the TVC from the from and pasting it to the end of a string that starts at the third character and goes until the length of the word - 2 (because you are starting two over)
				//This gives you the city/village/town name and then the -T allowing the autofill to work better
				if (dr["Location"].ToString().Substring(0,2) == "T/" || dr["Location"].ToString().Substring(0,2) == "V/" ||dr["Location"].ToString().Substring(0,2) == "C/")
				{
					string identifier = dr["Location"].ToString().Substring(0,1);
					View_Event_park_combo.Items.Add(dr["Location"].ToString().Substring(2,((dr["Location"].ToString().Length) - 2)) + " - " + identifier);
				}
			}
		}
		private void UpdateDataTable(DataGridView dg, string sql)
		{
			
			//use the tools class to get the dataset to bind to the data grid
			DataSet ds = Tools.GetDataSet(sql, "cad");
			//create a binding source for the data grid
			BindingSource bs = new BindingSource();
			//set the table from the dataset to the binding source
			bs.DataSource = ds.Tables[0];
			//set the datasource to the binding source, binding the data from the dataset to the datagrid
			dg.DataSource = bs;
		}
		void Create_PARKS_EventClick(object sender, EventArgs e)
		{
			if  (pid == 0)
			{
				//Creating the object to send to the method. Only for new events
				//This is for creating a PARKS object. It should be moved below later so that an object is not created every time the form is opened
				string incident_number = Tools.tableQuery("EvtTypes","Event_Type", View_Event_incident_fld.Text, "ParkNum", false);
				string corrected_time = View_Event_time_fld.Text;
				if (incident_number.Substring(0,2) != "-1")
				{
					if (System.Text.RegularExpressions.Regex.IsMatch(View_Event_time_fld.Text, "^\\d{2}:\\d{2}$"))//This converts the time to HHmm if it is already not in that format 
					{
						corrected_time = Convert.ToDateTime(View_Event_time_fld.Text).ToString("HHmm");
					}
					if (System.Text.RegularExpressions.Regex.IsMatch(corrected_time, "^\\d{4}$"))//Making sure the time is in HHmm format to send it to PARKS
					{
						if ((View_Event_addr_fld.TextLength < 100) && (View_Event_xst_fld.TextLength < 100) && (View_Event_Date_fld.TextLength < 15) && (View_Event_nar_fld.TextLength < 10000))
						{
							List<string> evt_lst = new List<string>();
							if (View_Event_park_combo.Text.Substring((View_Event_park_combo.Text.Length - 3), 1) == "-") //changing the park back to normal...again
							{
								string prefix = View_Event_park_combo.Text.Substring((View_Event_park_combo.Text.Length - 1), 1);
								string town = prefix + "/" + View_Event_park_combo.Text.Substring(0,(View_Event_park_combo.Text.Length - 4));
								List<string>Location_info = new List<string>{"ParksID", "CountyPID", "StationPID", "ZonePID"};
								Location_info = Tools.tableQuery("locations", "Location", town, Location_info, false);
								bool location_check = true;
								if (Location_info[0].Substring(0,1) == "-1") //THis check will almost never be used, but I want to catch cases where the person adds their own - whilE entering an incorrect location
								{
									Location_info[0] = "0"; //This will allow you to still create the event without the location info
									Location_info.Add("0");
									Location_info.Add("0");
									Location_info.Add("0");
									location_check = false;
								}
								// I'm just warning them that the location wasn't found and then I'm allowing the event to be created with 0s for values.
								// I would rather give them a partially created event with a warning than not allowing them to create an event
								if (!location_check)
									MessageBox.Show("A match for this location was not found in PARKS. Please select a location from the list or report this to the CAD administrator if your location is on the list.");
										
									List<string> tmp_lst = new List<string>{View_Event_Date_fld.Text, View_Event_Date_fld.Text, corrected_time, corrected_time, corrected_time, corrected_time, corrected_time, incident_number, "3687", Location_info[3], Location_info[1], Location_info[2], "1471", Location_info[0], View_Event_addr_fld.Text + " & " + View_Event_xst_fld.Text, View_Event_nar_fld.Text, "", id.ToString(), View_Event_Date_fld.Text};
										evt_lst = tmp_lst;	
							}
							else{
								List<string>Location_info = new List<string>{"ParksID", "CountyPID", "StationPID", "ZonePID"};
								Location_info = Tools.tableQuery("AllParks", "Park", View_Event_park_combo.Text, Location_info, false);
								//HACK Same check as above. This could be separated into it's own method, but I don't remember if C# passes in a pointer to the list allowing me to change it or just a coppied list
								//Also should be new task list item MESSY
								bool location_check = true;
								if (Location_info[0].Substring(0,1) == "-") //you can't do -1 because a few of the fields will only return one number and will have a substring out of range error
								{
									Location_info[0] = "0"; //This will allow you to still create the event without the location info
									Location_info.Add("0");
									Location_info.Add("0");
									Location_info.Add("0");
									location_check = false;							
								}
								if (!location_check)
									MessageBox.Show("Error looking up the location info for PARKS. Please select a location from the list or report this to the CAD administrator if your location is on the list.");
								
								List<string> tmp_lst = new List<string>{View_Event_Date_fld.Text, View_Event_Date_fld.Text, corrected_time, corrected_time, corrected_time, corrected_time, corrected_time, incident_number, "3687", Location_info[3], Location_info[1], Location_info[2], Location_info[0], "1", View_Event_addr_fld.Text + " & " + View_Event_xst_fld.Text, View_Event_nar_fld.Text, "", id.ToString(), View_Event_Date_fld.Text};
								evt_lst = tmp_lst;
							}
								Event evt = new Event(evt_lst);
								Assignment a = new Assignment(shld_for_ass);
								Browser b = new Browser("newEvent", id, a, null, null, evt, null); //can pass in null instead of creating an empty object
								b.Show();
						}
						else
						{
							MessageBox.Show("You have too many characters in one of these fields: Narrative, Date, Address, Cross Street.");
						}
					}
					else
					{
						MessageBox.Show("Event time must be in HHmm or HH:mm format");
					}
				}
				else
				{
					MessageBox.Show("The event type could not be found. Please choose an event type from the list.");
				}
			}
			else if(pid > 0)
			{
				Assignment a = new Assignment(shld_for_ass);
				Browser b = new Browser("exEvent", pid, a, "p", null);
				b.Show();
			}
		}
		
		
		void Close_btnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Fill_grid(DataGridView datagrid, string[] fields, int[] width)
		{
			    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
				datagrid.Columns.Add(btn);
				btn.Name = "Save";
				btn.UseColumnTextForButtonValue = true;
				btn.Width = 20;
				btn.HeaderText = "";
				int counter = 0;
				foreach (string field in fields) {
					DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
	      			column1.Name = field;
	      			column1.HeaderText = field;
	      			column1.DataPropertyName = field;
	      			if (width[counter] != 0)
	      				column1.Width = width[counter];
	      			else
	      				column1.Width = width[95];
	         		datagrid.Columns.Add(column1);
	         		counter++;
				}

		}
		private void datagridCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
			if(e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 0)
				{
					//create variables for the icon and the x and y coordinates to draw the icon on the button
					Icon i;
					int x, y;
					
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
					i = new Icon(@"img\filesave.ico", 10, 10);
					x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
					y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
					e.Graphics.DrawIcon(i, x, y);
					e.Handled = true;
				}
			}
		}
		private void Veh_datagridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		    var senderGrid = (DataGridView)sender;
		
		    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
		        e.RowIndex >= 0)
		    {
		    	Vehicle veh = (Vehicle)veh_datagrid.CurrentRow.DataBoundItem;
		    	Assignment a = new Assignment(shld_for_ass);
				Browser b = new Browser("vehicle", pid, a, veh, null, null, null);
				b.Show();
		    }
		}
		
		void Plp_datagridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			 var senderGrid = (DataGridView)sender;
		
		    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
		        e.RowIndex >= 0)
		    {
		    	Person per = (Person)plp_datagrid.CurrentRow.DataBoundItem;
		    	Assignment a = new Assignment(shld_for_ass);
				Browser b = new Browser("person", pid, a, null, per, null, null);
				b.Show();
		    }
		}
		
		void Map_browser_btnClick(object sender, EventArgs e)
		{
			string Map_address = "";
			if (Map_location.ToString().Substring((Map_location.ToString().Length - 3), 1) == "-") //Settings map address based on whether or not loacation is AutoCompleteStringCollection park
			{
				string cross = "";
				if (View_Event_xst_fld.Text.ToString() != "")
				{
					cross = " and " + View_Event_xst_fld.Text.ToString() + " ";
				}
				Map_address = Map_location.ToString() + cross + Map_location.ToString().Substring(0, (Map_location.ToString().Length - 4)) + " NY";
			}
			else
			{
				Map_address = Map_location.ToString() + "NY";
			}
			Assignment a = new Assignment(shld_for_ass);
			Browser b = new Browser(Map_address, pid, a, "g", null);
			b.Show();
		}
		
		void Add_calls_btnClick(object sender, EventArgs e)
		{
			//Your new browser constructor is poorly desinged and passing in  null for both the person and vehicle objects causes it to be the same as the other constructor
			//to solve this I am going to pass in an empty object untill i can
			string pid = Tools.tableQuery("events", "ID", id.ToString(), "pid", true);
			string narrative = "";			
			if (Int32.Parse(pid) > 0)
			{
				List<string> log = new List<string>{"Time1", "SourceCall", "Reason", "Narrative"};
				log = Tools.tableQuery("commlog", "Event", id.ToString(), log, false);
				for(int i = 0; i < (log.Count / 4); i++)
				{
					string call = log[i * 4] + " -- " + log[(i * 4) + 1] + " -- " + log[(i * 4) + 2] + " -- " + log[(i * 4) + 3];
					narrative = narrative + call + "\n";
				}
				Assignment a = new Assignment(shld_for_ass);
				Browser b = new Browser("add_calls", Int32.Parse(pid), a, null, null, null, narrative);
				b.Show();
			}
			else
			{
				MessageBox.Show("You need to create a PARKS event before you can add additional calls to it.");
			}
		}
		
		void Save_Event_btnClick(object sender, EventArgs e)
		{
			//The checks in this method wre copied from the new event form. You may need to adjust them some more.
			string corrected_time = View_Event_time_fld.Text;
			if (System.Text.RegularExpressions.Regex.IsMatch(View_Event_time_fld.Text, "^\\d{4}$")) // Change the time to a format that can be recognized as in time/date format
			{
				corrected_time = View_Event_time_fld.Text.Substring(0,2) + ":" + View_Event_time_fld.Text.Substring(2,2);
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(corrected_time, "^\\d{2}:\\d{2}$")) // Make sure the time is in the correct format
			{
				string corrected_date = View_Event_Date_fld.Text;
				if (Tools.Date_Fixer(ref corrected_date) == 0)
			   	{
					if ((View_Event_Officer_combo.Text != "" && View_Event_Officer_combo.SelectedIndex != -1) || (View_Event_Officer_combo.Text == original_officer))
					{
						string incident_number = Tools.tableQuery("EvtTypes","Event_Type", View_Event_incident_fld.Text, "ParkNum", false);
						if((View_Event_incident_fld.Text != "") && (incident_number.Substring(0,2) != "-1"))
						{
							if ((View_Event_park_combo.Text !="") && (View_Event_park_combo.Text.Length < 500))
							{
								if ((View_Event_xst_fld.TextLength < 100) && (View_Event_addr_fld.TextLength < 100) && (View_Event_nar_fld.TextLength < 10000))
								{
			
									//creating a new map location for the save
									string map_location;
											string cross = "";
											if (View_Event_xst_fld.Text != "") // If there is a cross street I went it sent to google in "address and cross street" format. it seems to work well. if not I want the and left out
												cross = " and " + View_Event_xst_fld.Text + " ";
											//If we are dealing with a town/city/village tell google maps to search with street and cross street as well
											if (View_Event_park_combo.Text.Substring((View_Event_park_combo.Text.Length - 3), 1) == "-")
											    map_location = "http://maps.googleapis.com/maps/api/staticmap?center=" + View_Event_addr_fld.Text + cross + View_Event_park_combo.Text.Substring(0,(View_Event_park_combo.Text.Length - 4)) + "NY&zoom=14&size=400x200&sensor=false&visual_refresh=true&maptype=roadmap&markers=icon:http://goo.gl/6fmKFh%7Ccolor:red%7Clabel:X%7C" + View_Event_addr_fld.Text + cross + View_Event_park_combo.Text.Substring(0,(View_Event_park_combo.Text.Length - 3)) + "NY";
											else // otherwise just have it look up the park
												map_location = "http://maps.googleapis.com/maps/api/staticmap?center=" + View_Event_park_combo.Text + "NY&zoom=14&size=400x200&sensor=false&visual_refresh=true&maptype=roadmap&markers=icon:http://goo.gl/6fmKFh%7Ccolor:red%7Clabel:X%7C" + View_Event_park_combo.Text + "NY";
									//The update call for sql is being a pain and is really limiting my string size. I am going to construct a list with everything in it and just loop throught it to update so that I don't have to fill the page with separate sql calls
									List<string> update_list = new List<string>{"Off", View_Event_Officer_combo.Text, "OutTime",  corrected_time, "EvtDate", corrected_date, "Location", View_Event_park_combo.Text, "Type", View_Event_incident_fld.Text, "Narrative", View_Event_nar_fld.Text, "Address", View_Event_addr_fld.Text, "Cross_Street", View_Event_xst_fld.Text, "Shield", shld_for_ass.ToString(), "MapLocation", map_location};
									List<string> sql_list = new List<string>();
									for(int i = 0; i < update_list.Count; i = i + 2)
									{
										string sql = @"UPDATE events SET " + update_list[i] + "= '" + update_list[i +1] + "' WHERE ID = " + id;
										sql_list.Add(sql);
									}
									Tools.runSqlList(sql_list,"cad");
									
									if (old_nar != View_Event_nar_fld.Text) //If the narrative has changed it should also be updated in the comm log
									{
										string sql = @"UPDATE commlog SET Narrative= '" + View_Event_nar_fld.Text + "' WHERE Narrative= '" + old_nar + "' and Event= '" + id + "'";
										Tools.runSql(sql,"cad");
										old_nar = View_Event_nar_fld.Text;
									}
									TimedMessageBox.Show("The new event information has been saved.", "Saved", 300);
									
								}
								else
								{
									MessageBox.Show("You have too many characters in one of these fields: Narrative, Address, Cross Street.");
								}
							}
							else
							{
								MessageBox.Show("Please choose a Park/Municipality from the list.");
							}
						}
						else
						{
							MessageBox.Show("Make sure you have selected an Incident Type from the list.");
						}
					}
					else 
					{
						MessageBox.Show("You must select an officer from the list.");
					}
			   	}
			   	else
			   	{
			   		MessageBox.Show("The date must be in MM/DD/YYYY format");// or M/D/YYYY format.");
			   	}
			}
			else
			{
				MessageBox.Show("The time must be in HHmm or HH:mm format");
			}
		}
		private void BackLoad()
		{
			//You need to keep on of the actions from threading to give the form enough time to load before they all start giving stuff back.
			
			//create a dataset of all in-service officers
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC", "cad");
			
			//loop through all of the records in the in-service dataset
			foreach (DataRow dr in ds.Tables[0].Rows) 
			{
				//add the current item to the drop down for the caller
				string officer_name = dr["CarNo"].ToString() + " - " + dr["offLastName"].ToString();
				try{
					this.Invoke((MethodInvoker)(() => View_Event_Officer_combo.Items.Add(new Officer(officer_name, Int32.Parse(dr["pZone"].ToString()),Int32.Parse(dr["OffShield"].ToString())))));
				}
				catch (InvalidOperationException)
				{
				}
			}
						
			System.Threading.Thread PlpLoadThread; 
			PlpLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(PlpLoad));
			PlpLoadThread.Start();
			
			System.Threading.Thread VehLoadThread; 
			VehLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(VehLoad));
			VehLoadThread.Start();
			
			System.Threading.Thread LocLoadThread; //I am going to attempt to make the form open more quickly for the user. I would liek the form to load instantly and have the lists fill in before the user actuall gets to click anything
			LocLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(LocLoad));
			LocLoadThread.Start();
			
			System.Threading.Thread MapLoadThread; 
			MapLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(MapLoad));
			MapLoadThread.Start();
			
			System.Threading.Thread ComLoadThread; 
			ComLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(ComLoad));
			ComLoadThread.Start();
			
			System.Threading.Thread IncLoadThread; 
			IncLoadThread = new System.Threading.Thread(new System.Threading.ThreadStart(IncLoad));
			IncLoadThread.Start();
		}
		private void MapLoad()
		{
			//I moved this up because the map is something the usuer actually sees instead of it fillinf in behind the scenes
			//navigate to the webpage	
			try{
				this.Invoke((MethodInvoker)(() =>Map_browser.Navigate(Map_location))); //View_Event_incident_fld.Items.Add(incident_values[i]);
			}
			catch (InvalidOperationException) 				
			{}
		}
		private void PlpLoad()
		{
			//adding associated people to the datagrid
			List<string> person_values = new List<string>{"FirstName","LastName", "DOB", "Sex", "CID","State", "Middle", "Class", "Expiration", "StreetAddress", "County", "Municipality", "ZipCode"};
			person_values = Tools.tableQuery("people", "Event", id.ToString(), person_values, true);
			if (person_values[0].Substring(0,2) != "-1") //Don't bother with the rest if there are no people
			{
				List<Person> person_lst = new List<Person>();
				person_lst = Tools.People_parser(person_values);
				if (person_lst == null)
					return;
				plp_datagrid.AutoGenerateColumns = false;
				try{
					this.Invoke((MethodInvoker)(() => plp_datagrid.DataSource = person_lst));
				}
				catch (InvalidOperationException) 
				{
				}
				string[] plp_flds = new string[4]{"LastName", "FirstName", "DateOfBirth", "LicenseNumber"};
				int[] plp_col_width = new int[4]{95, 95, 70, 80};
				try{
					this.Invoke((MethodInvoker)(() =>Fill_grid(plp_datagrid, plp_flds, plp_col_width)));
				}
				catch (InvalidOperationException) 
				{
				}
			}
		}
		private void VehLoad()
		{
			//Doing the same with associated vehicles
			List<string> vehicle_values = new List<string>{"PlateNumber", "VehYear", "VehMake", "VehModel", "VehColor", "VIN", "State","Status", "VehStyle", "Type", "Expiration", "PlateIssued"};
			vehicle_values = Tools.tableQuery("vehicles", "Event", id.ToString(), vehicle_values, true);
			if (vehicle_values[0].Substring(0,2) != "-1") //Don't bother with the rest if there are no vehicles
			{
				List<Vehicle> veh_lst = new List<Vehicle>();
				veh_lst = Tools.Vehicle_parser(vehicle_values);
				veh_datagrid.AutoGenerateColumns = false;
				try{
					this.Invoke((MethodInvoker)(() => veh_datagrid.DataSource = veh_lst));
				}
				catch (InvalidOperationException) 
				{
				}
				string[] veh_flds = new string[5]{"PlateNum", "VehYear", "VehColor", "VehMake", "VehModel"};
				int[] veh_col_width = new int[5]{60, 45, 65, 95, 95};
				try{
					this.Invoke((MethodInvoker)(() => Fill_grid(veh_datagrid, veh_flds, veh_col_width)));
				}
				catch (InvalidOperationException) 
				{
				}
			}
		}
//		private void OffLoad()
//		{	
//			//create a dataset of all in-service officers
//			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC", "cad");
//			
//			//loop through all of the records in the in-service dataset
//			foreach (DataRow dr in ds.Tables[0].Rows) 
//			{
//				//add the current item to the drop down for the caller
//				string officer_name = dr["CarNo"].ToString() + " - " + dr["offLastName"].ToString();
//				try{
//					this.Invoke((MethodInvoker)(() => View_Event_Officer_combo.Items.Add(new Officer(officer_name, Int32.Parse(dr["pZone"].ToString()),Int32.Parse(dr["OffShield"].ToString())))));
//				}
//				catch (InvalidOperationException)
//				{
//				}
//			}
//		}
		private void LocLoad()
		{
			//Filling in the initial locations list based on the officer's shield
			string off_zone = Tools.tableQuery("parksIDs", "offShield", shld_for_ass.ToString(), "pZone", true); // get the officer's zone to sort the initial locations list
			try{
				this.Invoke((MethodInvoker)(() =>Officer_drop_filler(Int32.Parse(off_zone))));
			}
			catch (InvalidOperationException) 
			{
			}
		}
		private void IncLoad()
		{
			//Adding incidents to list
			List<string> incident_values = new List<string>{"Event_Type"};
			incident_values = Tools.tableQuery("EvtTypes", "", "" , incident_values , false);
			try{
				for(int i = 0; i < incident_values.Count ; i++) 
				{
					this.Invoke((MethodInvoker)(() => View_Event_incident_fld.Items.Add(incident_values[i])));
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		private void ComLoad()
		{
			// getting all of the commlog enteries that have the same event id as the event clicked
			string sqlStr = "SELECT * FROM commlog WHERE Event = '" + id + "'"; 
			DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
			foreach(DataRow row in mDS.Tables[0].Rows)
			{
				string call = row["Time1"].ToString() + " - " + row["Reason"].ToString() + " - " + row["Narrative"].ToString();
				try{
					this.Invoke((MethodInvoker)(() => View_Event_com_list.Items.Add(call)));
				}
				catch (InvalidOperationException) 
				{
				}
			}
		}
	}
}
	
