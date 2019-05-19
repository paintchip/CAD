/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/2/2015
 * Time: 2:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of PlateDataObject.
	/// </summary>
	public class PlateDataObject : RunDataObject
	{
		#region Properties
		private string state;
		private string plate;
		private int type;
		private int expires;
		#endregion

		#region Constructors
		public PlateDataObject()
		{	
			Officer = "";
			Location = "";
			state = "NY";
			plate = "";
			type = 16;
			expires = DateTime.Now.Year;
		}
		
		public PlateDataObject(string vehicleReg)
		{
			Officer = "";
			Location = "";
			state = "NY";
			plate = vehicleReg;
			type = 16;
			expires = DateTime.Now.Year;
		}
		#endregion
		
		#region getters and setters
		public string State {
			get { return state; }
			set { state = value; }
		}
				
		public string Plate {
			get { return plate; }
			set { plate = value; }
		}
	
		public int Type {
			get { return type; }
			set { type = value; }
		}
		
		public int Expires {
			get { return expires; }
			set { expires = value; }
		}
		#endregion
		
		
	}
}
