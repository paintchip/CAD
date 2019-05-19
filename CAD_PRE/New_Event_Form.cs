/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/26/2015
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//TODO You need to send the dispatcher id when you send the comm log entry
namespace NYSPP_CAD
{
	/// <summary>
	/// Description of New_Event_Form.
	/// </summary>
	
	public partial class New_Event_Form : baseform
	{
		User u;
		public New_Event_Form(User us)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			u = us;
			this.defaultLocation = new Point(0, 0);
			this.defaultSize = new Size(891, 501);
			basecontrols();
			InitializeComponent();
		}
		
		void New_Event_FormLoad(object sender, EventArgs e)
		{
			System.Threading.Thread LoadingThread; //I am going to attempt to make the form open more quickly for the user. I would liek the form to load instantly and have the lists fill in before the user actuall gets to click anything
			LoadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(BackLoad));
			LoadingThread.Start();
			
			base.baseform_Load(sender, e);
			//set the call date to today in the MM/dd/yyyy format
			Nevent_date_fld.Text = DateTime.Today.ToString("MM/dd/yyyy");
			//set the call time to now in the military time format
			Nevent_time_fld.Text = DateTime.Now.ToString("HH:mm");

		}
		void Nevent_save_btnClick(object sender, EventArgs e)
		{
			string corrected_time = Nevent_time_fld.Text;
			if (System.Text.RegularExpressions.Regex.IsMatch(Nevent_time_fld.Text, "^\\d{4}$")) // Change the time to a format that can be recognized as in time/date format
			{
				corrected_time = Nevent_time_fld.Text.Substring(0,2) + ":" + Nevent_time_fld.Text.Substring(2,2);
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(corrected_time, "^\\d{2}:\\d{2}$")) // Make sure the time is in the correct format
			{
				string corrected_date = Nevent_date_fld.Text;
				if (Tools.Date_Fixer(ref corrected_date) == 0) //"^\\d{1,2}/\\d{1,2}/\\d{4}$" This will allows one or two numbers for the month, but we don't want that unti l the search log can find either
			   	{
					if (Nevent_officer_combo.Text != "" && Nevent_officer_combo.SelectedIndex != -1)
					{
						string incident_number = Tools.tableQuery("EvtTypes","Event_Type", Nevent_incident_combo.Text, "ParkNum", false);
						if((Nevent_incident_combo.Text != "") && (incident_number.Substring(0,2) != "-1"))
						{
							if ((Nevent_park_combo.Text !="") && (Nevent_park_combo.Text.Length < 500))
							{
								if ((Nevent_xst_fld.TextLength < 100) && (Nevent_addr_fld.TextLength < 100) && (Nevent_nar_fld.TextLength < 10000))
								{
									string map_location;
									string cross = "";
									if (Nevent_xst_fld.Text != "") // If there is a cross street I went it sent to google in "address and cross street" format. it seems to work well. if not I want the and left out
										cross = " and " + Nevent_xst_fld.Text + " ";
									//If we are dealing with a town/city/village tell google maps to search with street and cross street as well
									if (Nevent_park_combo.Text.Substring((Nevent_park_combo.Text.Length - 3), 1) == "-")
									    map_location = "http://maps.googleapis.com/maps/api/staticmap?center=" + Nevent_addr_fld.Text + cross + Nevent_park_combo.Text.Substring(0,(Nevent_park_combo.Text.Length - 4)) + "NY&zoom=14&size=400x200&sensor=false&visual_refresh=true&maptype=roadmap&markers=icon:http://goo.gl/6fmKFh%7Ccolor:red%7Clabel:X%7C" + Nevent_addr_fld.Text + cross + Nevent_park_combo.Text.Substring(0,(Nevent_park_combo.Text.Length - 3)) + "NY";
									else // otherwise just have it look up the park
										map_location = "http://maps.googleapis.com/maps/api/staticmap?center=" + Nevent_park_combo.Text + "NY&zoom=14&size=400x200&sensor=false&visual_refresh=true&maptype=roadmap&markers=icon:http://goo.gl/6fmKFh%7Ccolor:red%7Clabel:X%7C" + Nevent_park_combo.Text + "NY";
									
									string sql = @"INSERT INTO events (Off, OutTime, EvtDate, Location, Type, Narrative, Address, Cross_Street, Shield, MapLocation) VALUES ('" + Nevent_officer_combo.Text + "', '" + corrected_time + "', '" + corrected_date + "', '" +  Nevent_park_combo.Text + "', '" + Nevent_incident_combo.Text + "', '" + Nevent_nar_fld.Text + "', '" + Nevent_addr_fld.Text + "', '" + Nevent_xst_fld.Text + "', '" + ((Officer)Nevent_officer_combo.SelectedItem).returnshield() + "', '" + map_location + "')";
									int event_id =Tools.GetLastID(sql, "cad");
									sql = @"INSERT INTO commlog (SourceCall, Time1, Date1, Narrative, Reason, Event, Dispatcher) VALUES ('" + Nevent_officer_combo.Text + "', '" + corrected_time + "', '" + corrected_date + "', '" + Nevent_nar_fld.Text + "', 'EVENT', " + event_id.ToString() + ", " + u.getDispatchId() + ")";
									Console.WriteLine(sql);
									int com_id = Tools.GetLastID(sql, "cad");
									sql = @"INSERT INTO EventCallAssoc (EventID, CallID) VALUES ('" + event_id + "', '" + com_id + "')";
									Tools.runSql(sql,"cad");
									Tools.requeryUserControls("e");
									Tools.requeryUserControls("c");
									this.Close();
									TimedMessageBox.Show("Event Saved!", "EVENT SAVED", 1500);
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
			   		MessageBox.Show("The date must be in MM/DD/YYYY, (M)M/(D)D/(YY)YY format.");
			   	}
			}
			else
			{
				MessageBox.Show("The time must be in HHmm or HH:mm format");
			}
		}
		
		void Nevent_officer_comboDropDownClosed(object sender, EventArgs e)
		{
			string zone = "";
			string park_table = "";
			switch (((Officer)Nevent_officer_combo.SelectedItem).returnid()) //I'm hardcoding in the region names to the numbers to avoid another table lookup
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
			}
			Nevent_park_combo.Items.Clear(); // Clearing so that locations from other regions don't stay in the dropdown
			string sql = "SELECT * FROM " + park_table;
			Tools.clearDataset();
			DataSet ds = Tools.GetDataSet(sql, "cad"); 
			DataRow r = ds.Tables[0].Rows[0];
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				Nevent_park_combo.Items.Add(dr["Park"]);
			}
			Tools.clearDataset();
			sql = "SELECT * FROM locations WHERE [Zone] = '" + zone + "'"; // adding locations based on officer zone
			Tools.clearDataset();
			ds = Tools.GetDataSet(sql, "cad"); 
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				if (dr["Location"].ToString().Substring(0,2) == "T/" || dr["Location"].ToString().Substring(0,2) == "V/" ||dr["Location"].ToString().Substring(0,2) == "C/")
				{
					string identifier = dr["Location"].ToString().Substring(0,1);
					Nevent_park_combo.Items.Add(dr["Location"].ToString().Substring(2,(dr["Location"].ToString().Length) - 2) + " - " + identifier);
				}
			}
			Tools.clearDataset();
		}
		private void BackLoad()
		{			
			//create a dataset of all in-service officers
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC", "cad");
		
			//loop through all of the records in the in-service dataset
			foreach (DataRow dr in ds.Tables[0].Rows) 
			{
				//add the current item to the drop down for the caller
				string officer_name = dr["CarNo"].ToString() + " - " + dr["offLastName"].ToString();
				try {
					this.Invoke((MethodInvoker)(() => Nevent_officer_combo.Items.Add(new Officer(officer_name, Int32.Parse(dr["pZone"].ToString()), Int32.Parse(dr["offShield"].ToString())))));
				}
				catch (InvalidOperationException) 
				{}
			}
			Tools.clearDataset();
			ds = Tools.GetDataSet("SELECT * FROM EvtTypes", "cad");
			foreach (DataRow dr in ds.Tables[0].Rows) 
			{
				try {
					this.Invoke((MethodInvoker)(() => Nevent_incident_combo.Items.Add(dr["Event_Type"])));
				}
				catch (InvalidOperationException) 
				{}
			}
			Tools.clearDataset();
		}
	}
}
