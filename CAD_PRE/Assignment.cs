/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 8:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Assignment.  An object representing an assignment from PARKS
	/// </summary>
	public class Assignment
	{
		#region Properties
		private int officerId; //parks officer id of the assignment
		private int assignmentId; //assignment id
		private int secondaryId; //secondary assignment id
		private int districtId; //district id of the assignment
		private int zoneId; //zone id of the assignment
		private int shield; //shield of the officer the assignment is associated with
		private string carNo; //the car of the officer that the assignment is associated with
		private string startTime; //the start time of the assignment
		private string description; //description of the assignment
		#endregion
	
		#region Constructors		
		public Assignment(int offId, int assId, int secId, int distId, int zonId, int shld, string car)
		{
			officerId = offId;
			assignmentId = assId;
			secondaryId = secId;
			districtId = distId;
			zoneId = zonId;
			shield = shld;
			carNo = car;
		}
		
		public Assignment()
		{
			officerId = 0;
			assignmentId = 0;
			secondaryId = 0;
			districtId = 0;
			zoneId = 0;
			shield = 0;
			carNo = "";
			startTime = "";
		}
		
		public Assignment(int shld)
		{
			shield = shld;
			
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE offShield = " + shield, "cad");
			DataRow r = ds.Tables[0].Rows[0];
			
			officerId = Int32.Parse(r["pId"].ToString());
			assignmentId = Int32.Parse(r["AssId"].ToString());
			secondaryId = Int32.Parse(r["SecondaryId"].ToString());
			districtId = Int32.Parse(r["pDistrict"].ToString());
			zoneId = Int32.Parse(r["pZone"].ToString());
			carNo = r["CarNo"].ToString();
		}
		
		public Assignment(int offId, bool o)
		{
			officerId = offId;
			
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE pId = " + officerId, "cad");
			DataRow r = ds.Tables[0].Rows[0];
			
			shield = Int32.Parse(r["offShield"].ToString());
			assignmentId = Int32.Parse(r["AssId"].ToString());
			secondaryId = Int32.Parse(r["SecondaryId"].ToString());
			districtId = Int32.Parse(r["pDistrict"].ToString());
			zoneId = Int32.Parse(r["pZone"].ToString());
			carNo = r["CarNo"].ToString();
		}
		#endregion
	
		#region Getters and Setters
		public int OfficerId {
			get { return officerId; }
			set { officerId = value; }
		}
		
		public int AssignmentId	{
			get { return assignmentId; }
			set { assignmentId = value; }
		}
		
		public int SecondaryId {
			get { return secondaryId; }
			set { secondaryId = value; }
		}
		
		public int DistrictId {
			get { return districtId; }
			set { districtId = value; }
		}
		
		public int ZoneId {
			get { return zoneId; }
			set { zoneId = value; }
		}
		
		public int Shield {
			get { return shield; }
			set { shield = value; }
		}
		
		public string CarNo {
			get { return carNo; }
			set { carNo = value; }
		}
		
		public string StartTime {
			get { return startTime; }
			set { startTime = value; }
		}
		
		public string Description {
			get { return description; }
			set { description = value; }
		}
		#endregion
	}
}
