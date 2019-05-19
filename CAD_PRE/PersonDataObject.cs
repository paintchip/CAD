/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/2/2015
 * Time: 4:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of PersonDataObject.
	/// </summary>
	public class PersonDataObject : RunDataObject
	{
		#region Properties
		private string states;
		private string lastName;
		private string firstName;
		private string middleName;
		private string birthDate;
		private string gender;
		#endregion
		
		#region Constructors
		public PersonDataObject()
		{
			Officer = "";
			Location = "";
			states = "NY";
			lastName = "";
			firstName = "";
			middleName = "";
			birthDate = "";
			gender = "";
		}
		#endregion
		
		#region Getters and Setters				
		public string Gender {
			get { return gender; }
			set { gender = value; }
		}
		
		public string BirthDate {
			get { return birthDate; }
			set { birthDate = value; }
		}
		
		public string MiddleName {
			get { return middleName; }
			set { middleName = value; }
		}
		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}
		
		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}
		
		public string States {
			get { return states; }
			set { states = value; }
		}
		#endregion
				
		//get the first initial and capitalize it for ejustice
		public string GenderFirstInit()
		{
			return gender.Substring(0,1).ToUpper();
		}
	}
}
