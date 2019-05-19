/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/2/2015
 * Time: 2:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// RunDataObject will represent the data that will be send to ejustice.  Sub classes will inherit this superclass
	/// </summary>
	public class RunDataObject
	{	
		#region properties		
		protected string officer;
		protected string location;
		protected int officerId;
		protected int eventId;
		#endregion
		
		#region constructors		
		public RunDataObject()
		{
			officer = "";
			location = "";
		}
		
		public RunDataObject(string runningOfficer, string dataLocation)
		{
			officer = runningOfficer;
			location = dataLocation;
		}
		#endregion
		
		#region getters and setters
		public string Officer {
			get { return officer; }
			set { officer = value; }
		}

		public string Location {
			get { return location; }
			set { location = value; }
		}
		
		public int OfficerId {
			get { return officerId; }
			set { officerId = value; }
		}
		
		public int EventId {
			get { return eventId; }
			set { eventId = value; }
		}
		#endregion
		
		public void DataToCall(string narr)
		{
			//get the current cad form
			CAD c = (CAD) Application.OpenForms["CAD"];
			//get the user id of the current user
			int userId = c.getUser().getDispatchId();
			
			//generate sql to insert call into call log
			string sql = @"INSERT INTO commlog (Date1, Time1, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"
				+ DateTime.Today.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToString("HH:mm") + "', '"
				+ officer + "', 'DATA', '" + narr + "', " + userId + ")";
			
			//run the sql to enter the call
			Tools.runSql(sql, "cad");
		}
	}
}
