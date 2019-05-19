/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/4/2015
 * Time: 11:28 AM
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
	/// Description of ContactForm.
	/// </summary>
	public partial class ContactForm : baseform
	{
		public ContactForm(int pId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//declare a variable that will hold the officers shield number
			int offShield;
			//generate the sql that will get the officers shield using the parks id that is passed in
			string sql = "SELECT offShield FROM parksIDs WHERE pId = " + pId;
			//create a dataset to hold the results of the sql transaction
			DataSet ds = Tools.GetDataSet(sql, "cad");
			//clear the dataset
			Tools.clearDataset();
			//create a datarow from the first row of the results
			DataRow r = ds.Tables[0].Rows[0];
			//set the offShield to shield from the first row
			offShield = Int32.Parse(r["offShield"].ToString());
			
			//generate the sql that will look up the contact information
			sql = "SELECT * FROM contacts WHERE SHIELD = " + offShield;
			//set the dataset to hold the new sql results
			ds = Tools.GetDataSet(sql, "contacts");
			//clear the dataset
			Tools.clearDataset();			
			//store the first row of results in the datarow
			r = ds.Tables[0].Rows[0];
			
			//fill in the fields of the form based on the information returned
			this.NameFld.Text = r["NAME"].ToString();
			this.Shield.Text = r["SHIELD"].ToString();
			this.Rank.Text = r["RANK"].ToString();
			this.Station.Text = r["LOCATION"].ToString();
			this.Addy_1.Text = r["ADDRESS LINE 1"].ToString();
			this.Addy_2.Text = r["ADDRESS LINE 2"].ToString();
			this.Phone_1.Text = r["PHONE 1"].ToString();
			this.Phone_2.Text = r["PHONE 2"].ToString();
			this.Phone_3.Text = r["PHONE 3"].ToString();
			this.EmailAddress.Text = r["EMAIL"].ToString();
		}
		
		//handles when user clicks on email field
		private void EmailClick(object sender, EventArgs e)
		{
			//if there is no email
			if(EmailAddress.Text == null || EmailAddress.Text == "")
			{
				//exit the method
				return;
			}
			
			try
			{
				Email.SendMailWithOutlook("","",EmailAddress.Text, false);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
	}
}
