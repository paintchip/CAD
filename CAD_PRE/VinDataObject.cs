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
	/// Description of VinDataObject.
	/// </summary>
	public class VinDataObject : RunDataObject
	{
		#region Properties
		private string vehState;
		private string vehIDNum;
		private int vehYear;
		private string vehMake;
		#endregion
		
		#region Constructors
		public VinDataObject()
		{
			vehState = "NY";
			vehIDNum = "";
			vehYear = DateTime.Now.Year;
			vehMake = "";
		}
		
		public VinDataObject(string VIN)
		{
			vehState = "NY";
			vehIDNum = VIN;
			vehYear = DateTime.Now.Year;
			vehMake = "";
		}
		#endregion

		#region Getters and Setters		
		public string VehIDNum {
			get { return vehIDNum; }
			set { vehIDNum = value; }
		}
		
		public string VehMake {
			get { return vehMake; }
			set { vehMake = value; }
		}
		
		public int VehYear {
			get { return vehYear; }
			set { vehYear = value; }
		}
		
		public string VehState {
			get { return vehState; }
			set { vehState = value; }
		}
		#endregion
	}
}
