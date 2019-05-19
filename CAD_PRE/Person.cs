/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/4/2015
 * Time: 10:14 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person
	{
		#region Properties
		private string lastName;
		private string firstName;
		private string middleName;
		private string dateOfBirth;
		private string gender;
		private string state;
		private string licenseNumber;
		private string licenseClass;
		private string licenseExp;
		private string height;
		private string eyeColor;
		private string streetAddress;
		private string county;
		private string town;
		private int zipCode;
		private int eventNum;
		private int pId;
		private int gender_number = 2;
		#endregion
		
		#region Constructors
		public Person()
		{
		}
		public Person(List<string> person)
		{
			firstName = person[0];
			lastName = person[1];
			dateOfBirth = person[2];
			gender = person[3];
			licenseNumber = person[4];
			state = person[5];
			middleName = person[6];
			licenseClass = person[7];
			licenseExp = person[8];
			streetAddress = person[9];
			county = person[10];
			town = person[11];
			zipCode = Int32.Parse(person[12]);
			switch (person[3].ToString())
			{
				case "Male":
					gender_number = 0;
					break;
				case "Female":
					gender_number = 1;					
					break;
				default:
					gender_number = 2;
					break;
			}
		}
		//Figured out the other problem, but I actually really like this constructor in loops.
		public Person(string first, string last, string dob, string gndr, string dlic, string st)
		{
			firstName = first;
			lastName = last;
			dateOfBirth = dob;
			gender = gndr;
			licenseNumber = dlic;
			state = st;
			switch (gender)
			{
				case "Male":
					gender_number = 0;
					break;
				case "Female":
					gender_number = 1;					
					break;
				default:
					gender_number = 2;
					break;
			}
		}
		#endregion
		
		#region Getters & Setters
		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}

		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}

		public string MiddleName {
			get { return middleName; }
			set { middleName = value; }
		}

		public string Gender {
			get { return gender; }
			set { gender = value; }
		}

		public string State {
			get { return state; }
			set { state = value; }
		}

		public string LicenseNumber {
			get { return licenseNumber; }
			set { licenseNumber = value; }
		}

		public string DateOfBirth {
			get { return dateOfBirth; }
			set { dateOfBirth = value; }
		}

		public string LicenseClass {
			get { return licenseClass; }
			set { licenseClass = value; }
		}

		public string LicenseExp {
			get { return licenseExp; }
			set { licenseExp = value; }
		}

		public string Height {
			get { return height; }
			set { height = value; }
		}

		public string EyeColor {
			get { return eyeColor; }
			set { eyeColor = value; }
		}

		public string StreetAddress {
			get { return streetAddress; }
			set { streetAddress = value; }
		}

		public string County {
			get { return county; }
			set { county = value; }
		}

		public string Town {
			get { return town; }
			set { town = value; }
		}

		public int ZipCode {
			get { return zipCode; }
			set { zipCode = value; }
		}
		
		public int EventNum {
			get { return eventNum; }
			set { eventNum = value; }
		}
		
		public int PId {
			get { return pId; }
			set { pId = value; }
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Person LastName={0}, FirstName={1}, MiddleName={2}, DateOfBirth={3}, Gender={4}, State={5}, LicenseNumber={6}, LicenseClass={7}, LicenseExp={8}, Height={9}, EyeColor={10}, StreetAddress={11}, County={12}, Town={13}, ZipCode={14}, EventNum={15}]", lastName, firstName, middleName, dateOfBirth, gender, state, licenseNumber, licenseClass, licenseExp,
height, eyeColor, streetAddress, county, town, zipCode, eventNum);
		}
		
		public string FillParksToString()
		{
			return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", lastName, firstName, middleName, streetAddress, town, state, zipCode, gender_number, eyeColor, dateOfBirth);
			//"Lic Num: " + licenseNumber + "/nExp: " + licenseExp, this was cut in the browser because it was causing errors
		}
		
		public void InsertPerson()
		{
			//gen sql to look up to see if the person is already in the table
			string sql = "SELECT ID FROM people WHERE LastName = '" + lastName + "' AND FirstName = '" + firstName + "' AND DOB = '" + dateOfBirth + "'";
			DataSet ds = Tools.GetDataSet(sql, "cad"); //get the dataset
			Tools.clearDataset(); //clear the dataset
			DataRow dr = ds.Tables[0].Rows[0]; //get the first row of data
			int personId = Int32.Parse(dr[0].ToString()); //parse the value in the first column
			
			if(personId > 0) //if the id is greater than zero
			{
				//update person
				sql = "UPDATE people SET LastName='" + lastName + "', FirstName='" + firstName + "', Middle='" + middleName + "', "
					+ "DOB='" + dateOfBirth + "', Sex='" + gender + "', State='" + state + "', CID='" + licenseNumber + "', "
					+ "Class='" + licenseClass + "', Expiration='" + licenseExp + "', EyeColor='" + eyeColor + "', "
					+ "StreetAddress='" + streetAddress + "', County='" + county + "', Municipality='" + town + "', ZipCode=" + zipCode
					+ " WHERE ID=" + personId;
				
				Tools.runSql(sql, "cad"); //run the sql to update the person
			}
			else
			{
				//insert person
				sql = @"INSERT INTO people (LastName, FirstName, Middle, DOB, Sex, State, CID, Class, Expiration, EyeColor,
					StreetAddress, County, Municipality, ZipCode) VALUES ('" + lastName + "', '" + firstName + "', '" + middleName
					+ "', '" + dateOfBirth + "', '" + gender + "', '" + state + "', '" + licenseNumber + "', '" + licenseClass
					+ "', '" + licenseExp + "', '" + eyeColor + "', '" + streetAddress + "', '" + county + "', '" + town
					+ "', " + zipCode;
				
				//capture the id of the person just entered into the table and set it to the id property
				pId = Tools.GetLastID(sql, "cad");
				
				//call the association method
				AssocPerson();
			}
		}
		
		private void AssocPerson()
		{
			//gen sql to count the number of times the person and event are associated, no need to enter if already there
			string sql = "SELECT COUNT (*) FROM EventPersonAssoc WHERE EventId = " + eventNum + " AND PersonId = " + pId;
			DataSet ds = Tools.GetDataSet(sql, "cad"); //get the dataset
			Tools.clearDataset(); //clear the dataset
			DataRow dr = ds.Tables[0].Rows[0]; //get the first row of data
			int count = Int16.Parse(dr[0].ToString()); //parse the value in the first field of the row
			
			if(count >= 1) //if the count is 1 or more
				return; //return without inserting new association record
					
			//gen sql to insert new association record
			sql = "INSERT INTO EventPersonAssoc (EventId, PersonId) VALUES (" + eventNum + ", " + pId + ")";
			Tools.runSql(sql, "cad"); //run the sql command
		}
	}
}
