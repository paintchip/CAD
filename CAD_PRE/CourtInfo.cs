/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/23/2015
 * Time: 1:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of CourtInfo.
	/// </summary>
	public partial class CourtInfo : baseform
	{
		private string courtSql;
		private string justiceSql;
		private string clerkSql;
		
		public CourtInfo(int courtId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
				
			//if the court id is not 0
			if(courtId != 0)
			{
				//set the court sql and justice sql
				courtSql = "SELECT * FROM Courts WHERE ID = " + courtId;
				justiceSql = "SELECT * FROM Justices WHERE CourtID = " + courtId;// + "'";
				clerkSql = "SELECT * FROM Clerks WHERE CourtID = " + courtId;// + "'";
				
				//set up the fields
				initializeFields();						
				//create an array for the names of the columns for the justice datagrid, used to bind data to the data grid
				string[] jTitles = new string[9] {"LastName", "FirstName", "HomePhone", "Cell/Pager/Work", "OtherOffice", "Day", "Time", "Notes", "EMAIL"};
				//create an array for the names of the columns for the clerks datagrid, used to bind data to the data grid
				string[] cTitles = new string[3] {"Clerk", "ClerkEmail", "Notes"};
				
				//initialize justice and clerk tables
				initializeTable(dataGridView1, jTitles, justiceSql);
				initializeTable(dataGridView2, cTitles, clerkSql);
			}
		}
		
		//handle the form load
		private void CourtInfoLoad(object sender, EventArgs e)
		{
			//make the label background transparent
			courtLbl.Parent = pictureBox1;
			courtLbl.BackColor = Color.Transparent;
		}
		
		//initialize the fields
		private void initializeFields()
		{
			//create a dataset from the court sql
			DataSet ds = Tools.GetDataSet(courtSql, "court");
			//get the first row of data to populate the fields
			DataRow row = ds.Tables[0].Rows[0];
			
			//set the fields values from the data row
			county.Text = row["County"].ToString();
			mail_addy.Text = row["Mailing_Address"].ToString();
			phy_addy.Text = row["Court_Address"].ToString();
			CTV1.Text = row["City_State_Zip"].ToString();
			court_phone.Text = Tools.formatPhone(row["Court_Phone"].ToString());
			court_fax.Text = Tools.formatPhone(row["Court_Fax"].ToString());
			loc_code.Text = row["Loc_Code"].ToString();
			court_ori.Text = row["Court_ORI"].ToString();
			court_notes.Text = row["Notes"].ToString();
		}
		
		//initialize the datagridview
		private void initializeTable(DataGridView dg, string[] titles, string sql)
		{
			//do not auto generate columns based on bound data
			dg.AutoGenerateColumns = false;

			//loop through all items in the titles, names and width arrays
			for(int x = 0; x < titles.Length; x++)
			{
				//create a new text box column, add it to the data grid, change attributes
				DataGridViewColumn col = new DataGridViewTextBoxColumn();
				//change the column name to the string in the index of the titles array
				col.Name = titles[x];
				//change the data property name of the column to the string in the index, data property should be name of column in SQL
				col.DataPropertyName = titles[x];
				//add the new column to the data grid
				dg.Columns.Add(col);
				

			}
			
			//get the dataset
			DataSet ds = Tools.GetDataSet(sql, "court");
			try {
				//create a binding source for the data grid
				BindingSource bs = new BindingSource();
				//set the table from the dataset to the binding source
				bs.DataSource = ds.Tables[0];
				//set the datasource to the binding source, binding the data from the dataset to the datagrid
				dg.DataSource = bs;
				Tools.clearDataset();
			} catch (Exception) {
			}
		}
		
		//method that handles the clicks in the calls datagrid
		private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//cast the sender object to a data grid
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header and from the narrative column
			if(e.RowIndex >= 0 && e.ColumnIndex == 8)
			{
				OpenEmail(sg[e.ColumnIndex, e.RowIndex].Value.ToString());
			}
		}
		
		//method that handles the clicks in the calls datagrid
		private void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//cast the sender object to a data grid
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header and from the narrative column
			if(e.RowIndex >= 0 && e.ColumnIndex == 1)
			{
				OpenEmail(sg[e.ColumnIndex, e.RowIndex].Value.ToString());
			}
		}
		
		//method that opens the email dialog
		private void OpenEmail(string email)
		{
			//if there is no email
			if(email == null || email == "")
			{
				//exit the method
				return;
			}
			
			try
			{
				//create the outlook application
				Outlook.Application oApp = new Outlook.Application();
				//create a new mail item
				Outlook._MailItem oMail = (Outlook._MailItem) oApp.CreateItem(Outlook.OlItemType.olMailItem);
				Outlook.Inspector oInsp = oMail.GetInspector;
				//display the new mail item
				oMail.Display();
				//set the to field of the email to the text in the email field
				oMail.To = email;
				//resolve the email address
				oMail.Recipients.ResolveAll();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		//handles the formatting event of the justice info datagridview
		private void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//cast the sender to a datagridview object
			DataGridView dg = (DataGridView) sender;
			
			//if the column contains a phone number
			if(e.ColumnIndex >= 2 && e.ColumnIndex <= 4)
			{
				//format the string for a phone number
				dg[e.ColumnIndex, e.RowIndex].Value = Tools.formatPhone(dg[e.ColumnIndex, e.RowIndex].Value.ToString());
			}
		}
	}
}
