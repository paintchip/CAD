/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/13/2015
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Call entry form
	/// </summary>
	//DispatchID was not autofilled when I tested this on the real DB
	public partial class EnterCall : baseform
	{
		private int id;
		private int idType;
		private User curU;
		private Assignment assign = null;
		
		public EnterCall(int id1, int idType1, User cu)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//set the passed in parameters
			id = id1;
			idType = idType1;
			curU = cu;
		}
		
		//cancel button click
		private void Button3Click(object sender, EventArgs e)
		{
			//close the enter call form without saving anything
			this.Close();
		}
		
		//on the form load
		private void EnterCallLoad(object sender, EventArgs e)
		{
			//call the initialize fields method
			basecontrols();
			initializeFields();
		}
		
		//initialize fields, used to populate dropdowns, date, and time fields
		private void initializeFields()
		{
			System.Threading.Thread LoadingThread; //I am going to attempt to make the form open more quickly for the user. I would liek the form to load instantly and have the lists fill in before the user actuall gets to click anything
			LoadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(BackLoad));
			LoadingThread.Start();
			
			//set the call date to today in the MM/dd/yyyy format
			CallDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
			//set the call time to now in the military time format
			CallTime.Text = DateTime.Now.ToString("HH:mm");
		}
		
		//handles the enter button click
		private void Button1Click(object sender, EventArgs e)
		{
			string caller;
			string source;
			int callId;
			
			//if form validation is passed
			if(ValidateForm())
			{
				//if call is not outgoing
				if(Outgoing.Text.Equals("") || Outgoing.Text == null)
				{
					//set the caller to the string from the caller text field, with special characters removed
					caller = Tools.sanitize(Caller.Text.ToString());
					//set the source call to an empty string
					source = "";
				}
				else //else if the call is outgoing
				{
					//set the caller to MS
					caller = "MS";
					//set the source call to the string from the caller text field, with special characters removed
					source = Tools.sanitize(Caller.Text.ToString());
				}
				
				//generate the sql statement to insert the call into the communications log
				string sql = @"INSERT INTO commlog (Date1, Time1, UnitCalled, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"
					+ CallDate.Text.ToString() + "', '" + CallTime.Text.ToString() + "', '" + source + "', '" + caller
					+ "', '" + Reason.Text.ToString() + "', '" + Tools.sanitize(Narrative.Text.ToString()) + "', " + Int16.Parse(DispatchID.Text.ToString()) + ")";
				//get the id of the last call entered
				callId = Tools.GetLastID(sql, "cad");
				
				// if the id passed in was an event id				
				if(idType == 2)
				{
					//generate the sql to insert the call for association with the event
					//sql = @"INSERT INTO EventCallAssoc (EventID, CallID) VALUES (" + id + ", " + callId + ")"; // change this to add the event id directly to the commlog
					sql = @"UPDATE commlog SET Event =" + id + " WHERE id =" + callId;
					//MessageBox.Show(sql);
					//run the sql
					Tools.runSql(sql, "cad");
					//generate the sql to update the last time of the event
					sql = @"UPDATE events SET LastTime=#" + DateTime.Parse(CallTime.Text.ToString()) + "#, LastDate=#"
						+ DateTime.Parse(CallDate.Text.ToString()) + "#, ColorCode=1 WHERE ID = " + id;
					//run the sql
					Tools.runSql(sql, "cad");
					
					//if the reason for the call was to clear the event
					if(Reason.Text.Equals("CLR"))
					{
						//generate the sql to update the event to be inactive "cleared"
						sql = @"UPDATE events SET Active=0 WHERE ID = " + id;
						//run the sql
						Tools.runSql(sql, "cad");
					}
					
					//call the method that refreshes the cad components
					Tools.requeryUserControls("ce");
				}
				
				//if the reason for the call was a unit calling in service
				if(Reason.Text.Equals("ISV"))
				{
					//create an empty assignment
					Assignment a = null;
					
					//if an officer id was passed in
					if(idType == 1)
					{
						//create a new browser form to take the user to the PARKS assignment page
						Browser b = new Browser("assign", 0, assign, "p", null);
						//show the new browser form
						b.Show();
					}
					else
					{
						//generate the sql to get the parks ID using the shield
						sql = @"SELECT pId, pDistrict, pZone FROM parksIDs WHERE offShield = " + Int32.Parse(Caller.Text.ToString());
						//create a dataset from the sql
						DataSet ds = Tools.GetDataSet(sql, "cad");
						//if there is at least 1 row of data
						if(ds.Tables[0].Rows.Count > 0)
						{
							//create a new assignment object using the shield
							a = new Assignment(Int32.Parse(Caller.Text.ToString()));
							//create a new browser form to take the user to the PARKS assignment page
							Browser b = new Browser("assign", 0, a, "p", null);
							//show the browser form
							b.Show();
						}
					}
				}
				//close the call entry form
				this.Close();
			}
		}
		
		//method to validate the form
		private bool ValidateForm()
		{	
			//TODO Add checks for date and time field. Use tools.datefixer. If they are not corrected, then the search may miss them
			//if the caller field was not entered
			if(Caller.Text.Equals(""))
			{
				//advise the user that a caller must be entered
				MessageBox.Show("Please enter a unit called or caller.");
				//set focus to the caller field
				Caller.Select();
				//validation failed
				return false;
			}
			
			//if the reason was not selected
			if(Reason.SelectedIndex <= -1)
			{
				//advise the user that a reason must be selected
				MessageBox.Show("Please select a reason for the call.");
				//set focus to the reason drop down box
				Reason.Select();
				//validation failed
				return false;
			}
			
			//validation succeeded
			return true;
		}
		
		//handle the outgoing field click
		private void OutgoingClick(object sender, EventArgs e)
		{
			//if the outgoing field is blank
			if(Outgoing.Text == null || Outgoing.Text.Equals(""))
			{
				//set the outgoing field to x
				Outgoing.Text = "X";
			}
			else
			{
				//set the outgoing field to an empty string
				Outgoing.Text = "";
			}
		}
		private void BackLoad()
		{
			//create a dataset of all in-service officers
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC", "cad");
			//clear the dataset
			Tools.clearDataset();
			
			//select the id of the current dispatcher. THis needs to be done in the backload otherwise there are no items to be selected.
			DispatchID.SelectedText = curU.getDispatchId().ToString();
			
			//loop through all of the records in the in-service dataset
			foreach (DataRow dr in ds.Tables[0].Rows) {
				//add the current item to the drop down for the caller
				try {
					this.Invoke((MethodInvoker)(() => Caller.Items.Add(dr["CarNo"])));
				}catch (InvalidOperationException)
				{
				}
			}
			//add the final 3 items
			try {
				this.Invoke((MethodInvoker)(() => Caller.Items.Add("PHONE")));
				this.Invoke((MethodInvoker)(() => Caller.Items.Add("EMER")));
				this.Invoke((MethodInvoker)(() => Caller.Items.Add("STANLEY SEC")));
			}catch (InvalidOperationException)
			{
			}
			
			//create a dataset of all reason codes
			ds = Tools.GetDataSet("SELECT * FROM ReasonCodes", "cad");
			//clear the dataset
			Tools.clearDataset();
			
			//loop through the reason codes
			foreach (DataRow dr in ds.Tables[0].Rows) {
				//add the reason code to the Reason drop down box
				try {
						this.Invoke((MethodInvoker)(() => Reason.Items.Add(dr["Reason Code"])));
					}catch (InvalidOperationException)
					{
					}
			}

			//create a dataset from all the CAD users ids
			ds = Tools.GetDataSet("SELECT DispatchID FROM users WHERE Active = 1 ORDER BY DispatchID ASC", "cad");
			//clear the dataset
			Tools.clearDataset();
			
			//loop through the dispatcher ids
			foreach (DataRow dr in ds.Tables[0].Rows) {
				//add the dispatcher id to the dispatchID drop down box
				try {
						this.Invoke((MethodInvoker)(() => DispatchID.Items.Add(dr["DispatchID"])));
					}catch (InvalidOperationException)
					{
					}
			}
			
						//if an officer id is passed in to the entercall form
			if(idType == 1)
			{
				//create a dataset from user information from the id that was passed in
				ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE pId = " + id, "cad");
				//clear the dataset
				Tools.clearDataset();
				//create a datarow object from the first data row in the data set
				DataRow r = ds.Tables[0].Rows[0];

				//set the assign to a new assignment based on the information in the data row
				assign = new Assignment(id, Int32.Parse(r["AssId"].ToString()), Int32.Parse(r["SecondaryId"].ToString()), Int32.Parse(r["pDistrict"].ToString()), Int32.Parse(r["pZone"].ToString()), Int32.Parse(r["offShield"].ToString()), r["CarNo"].ToString());
	
				//if there is an assignment id
				if(assign.AssignmentId > 0)
				{
					//set the caller to the car from the assignment
					try {
						this.Invoke((MethodInvoker)(() => Caller.SelectedItem = assign.CarNo));
					}
					catch (InvalidOperationException)
					{
					}
				}
				else //there is not an assignment created
				{
					//set the caller to the shield of the officer id passed in
					try {
							this.Invoke((MethodInvoker)(() => Caller.Text = assign.Shield.ToString()));
						}catch (InvalidOperationException)
					{
					}
				}
			}
		}
	}
}

