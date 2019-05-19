/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/12/2015
 * Time: 3:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of formSettings.
	/// </summary>
	public class formSettings
	{
		#region Properties
		private string formName;
		private Point formLocation;
		private Size formSize;
		#endregion
		
		#region Constructors
		public formSettings() {
			
		}
		
		public formSettings(string form_name, Point form_location, Size form_size)
		{
			formName = form_name;
			formLocation = form_location;
			formSize = form_size;
		}
		
		public formSettings(string form_name, int loc_x, int loc_y, int size_w, int size_h)
		{
			formName = form_name;
			formLocation = new Point(loc_x, loc_y);
			formSize = new Size(size_w, size_h);
		}
		#endregion
		
		#region Getters & Setters
		public Size FormSize {
			get { return formSize; }
			set { formSize = value; }
		}

		public string FormName {
			get { return formName; }
			set { formName = value; }
		}

		public Point FormLocation {
			get { return formLocation; }
			set { formLocation = value; }
		}
		#endregion
	}
}
