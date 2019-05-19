/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/4/2015
 * Time: 9:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Vehicle.
	/// </summary>
	public class Vehicle
	{
		#region Properties
		private int insuranceCode;
		private int plateType;
		private int vehYear;
		private int eventNum;
		private int vId;		
		private int make_id;
		private string plateNum;
		private string plateExp;
		private string vehMake;
		private string vehIdNum;
		private string plateStatus;
		private string plateIssued;
		private string plateStyle;
		private string vehStyle;
		private string vehModel;
		private string vehColor;
		private string plateState;
		#endregion
		
		#region Constructors
		public Vehicle()
		{	
		}
		public Vehicle(List<string> person)
		{
			plateNum = person[0];
			vehYear = Int32.Parse(person[1]);
			vehMake = person[2];
			vehModel = person[3];
			vehColor = person[4];
			vehIdNum = person[5];
			plateState = person[6];
			plateStatus = person[7];
			vehStyle = person[8];
			plateType = Int32.Parse(person[9]);
			plateExp = person[10];
			plateIssued = person[11];		
			make_id = Get_veh_id(person[2]);
		}
		public Vehicle(string plate, string year, string make, string mod, string color, string vin, string st)
		{
			plateNum = plate;
			vehYear = Int32.Parse(year);
			vehMake = make;
			vehModel = mod;
			vehColor = color;
			vehIdNum = vin;
			plateState = st;
			make_id = Get_veh_id(make);
		}
		#endregion
		
		#region Getters & Setters
		public string VehColor {
			get { return vehColor; }
			set { vehColor = value; }
		}
		
		public string VehModel {
			get { return vehModel; }
			set { vehModel = value; }
		}
		
		public string VehStyle {
			get { return vehStyle; }
			set { vehStyle = value; }
		}
		
		public int InsuranceCode {
			get { return insuranceCode; }
			set { insuranceCode = value; }
		}
		
		public string PlateStyle {
			get { return plateStyle; }
			set { plateStyle = value; }
		}
		
		public string PlateIssued {
			get { return plateIssued; }
			set { plateIssued = value; }
		}
		
		public string PlateStatus {
			get { return plateStatus; }
			set { plateStatus = value; }
		}
		
		public string VehIdNum {
			get { return vehIdNum; }
			set { vehIdNum = value; }
		}
		
		public string VehMake {
			get { return vehMake; }
			set { vehMake = value; }
		}
		
		public int VehYear {
			get { return vehYear; }
			set { vehYear = value; }
		}
		
		public string PlateExp {
			get { return plateExp; }
			set { plateExp = value; }
		}
		
		public string PlateNum {
			get { return plateNum; }
			set { plateNum = value; }
		}
		
		public string PlateState {
			get { return plateState; }
			set { plateState = value; }
		}
			
		public int PlateType {
			get { return plateType; }
			set { plateType = value; }
		}
		
		public int EventNum {
			get { return eventNum; }
			set { eventNum = value; }
		}
		
		public int VId {
			get { return vId; }
			set { vId = value; }
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Vehicle VehStatus={0}, PlateType={1}, VehYear={2}, PlateNum={3}, PlateExp={4}, VehMake={5}, VehIdNum={6}, PlateStatus={7}, PlateIssued={8}, PlateStyle={9}, VehStyle={10}, VehModel={11}, VehColor={12}]", "1384", plateType, vehYear, plateNum, plateExp, vehMake, vehIdNum, plateStatus, plateIssued,
plateStyle, vehStyle, vehModel, vehColor);
		}
		//
		public string FillParksToString()
		{
			string form = "";
			
			for(int x = 0; x < 12; x++)
				form += "{" + x + "},";
			
			return string.Format(form.Substring(0, form.Length-1), "1384", plateNum, "true", plateState, DateTime.Parse(plateExp).ToString("yyyy"), vehYear, plateType, vehIdNum, vehModel, vehStyle, vehColor, make_id);
		}
		//
//		private int LookupVehMakeId(string vehicleMake)
//		{
//			int id;
//			string sql = "SELECT ParksID FROM makes WHERE FullMakes = '" + vehicleMake.ToUpper() + "'";
//			
//			DataSet ds = Tools.GetDataSet(sql, "cad");
//			Tools.clearDataset();
//			
//			DataRow row = ds.Tables[0].Rows[0];
//			string vehId = row[0].ToString();
//			
//			if(vehId.Equals("") || vehId.Equals(null)) {
//				id = 3452;
//			}
//			else
//			{
//				id = Int16.Parse(vehId);
//			}
//			
//			return id;
//		}

		public void InsertVehicle()
		{
			//gen sql to look up to see if the vehicle is already in the table
			string sql = "SELECT ID FROM vehicles WHERE PlateNumber = '" + plateNum + "' AND State = '" + plateState + "'";
			DataSet ds = Tools.GetDataSet(sql, "cad"); //get the dataset
			Tools.clearDataset(); //clear the dataset
			DataRow dr = ds.Tables[0].Rows[0]; //get the first row of data
			int vehicleId = Int32.Parse(dr[0].ToString()); //parse the value in the first column
			
			if(vehicleId > 0) //if the id is greater than zero
			{
				//update person
				sql = "UPDATE vehicles SET State='" + plateState + "', PlateNumber='" + plateNum + "', Type=" + plateType
					+ ", Expiration='" + plateExp + "', VehYear=" + vehYear + ", VehMake='" + vehMake + "', VIN='" + vehIdNum
					+ "', Status='" + plateStatus + "', VehStyle='" + vehStyle + "', VehModel='" + vehModel
					+ "', VehColor='" + vehColor + "' WHERE ID=" + vehicleId;
				
				Tools.runSql(sql, "cad"); //run the sql to update the person
			}
			else
			{
				//insert person
				sql = @"INSERT INTO vehicles (State, PlateNumber, Type, Expiration, VehYear, VehMake, VIN, Status, 
					VehStyle, VehModel, VehColor) VALUES ('" + plateState + "', '" + plateNum + "', " + plateType
					+ ", '" + plateExp + "', " + vehYear + ", '" + vehMake + "', " + vehIdNum + "', " + plateStatus
					+ "', '" + vehStyle + "', '" + vehModel + "', '" + vehColor + "')";
				
				//capture the id of the person just entered into the table and set it to the id property
				vId = Tools.GetLastID(sql, "cad");
				
				//call the association method
				AssocVehicle();
			}
		}
		
		private void AssocVehicle()
		{
			//gen sql to count the number of times the vehicle and event are associated, no need to enter if already there
			string sql = "SELECT COUNT (*) FROM EventVehicleAssoc WHERE EventId = " + eventNum + " AND VehId = " + vId;
			DataSet ds = Tools.GetDataSet(sql, "cad"); //get the dataset
			Tools.clearDataset(); //clear the dataset
			DataRow dr = ds.Tables[0].Rows[0]; //get the first row of data
			int count = Int16.Parse(dr[0].ToString()); //parse the value in the first field of the row
			
			if(count >= 1) //if the count is 1 or more
				return; //return without inserting new association record
					
			//gen sql to insert new association record
			sql = "INSERT INTO EventVehicleAssoc (EventId, VehId) VALUES (" + eventNum + ", " + vId + ")";
			Tools.runSql(sql, "cad"); //run the sql command
		}
		private int Get_veh_id(string make)
		{
			string veh_make = Tools.tableQuery("makes", "makes", make, "ParksID", false);//Checking th makes column for the male
			int veh_make_pid;
			bool is_numeric = Int32.TryParse(veh_make, out veh_make_pid); //if it doesn't return a number then it couldn't find the make
			if (is_numeric)
				return veh_make_pid;
			else
			{
				veh_make = Tools.tableQuery("makes", "FullMakes", make, "ParksID", false); //If it couldn't find the make in the makes column, try the full makes column
				is_numeric = Int32.TryParse(veh_make, out veh_make_pid);
					if (is_numeric)
						return veh_make_pid;
					else
						return 3452; //If we couldn't find a value, just return the pid for other
			}
		}
	}
}
