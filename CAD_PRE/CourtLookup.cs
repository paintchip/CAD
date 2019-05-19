/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/11/2015
 * Time: 1:50 PM
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
	/// Description of CourtLookup.  Court look up form
	/// </summary>
	public partial class CourtLookup : baseform
	{
		private string countyName = "";
		private string jurisdiction = "";
		private string sqlPre = "SELECT Jurisdiction, ID FROM Courts ";
		private string sqlPost = "";

		public CourtLookup()
		{
			// 
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			//generate sql string to get counties from court table
			String sql = "SELECT DISTINCT County FROM Courts ORDER BY County ASC";
			//get the dataset of counties for the dropdown box
			DataSet ds = Tools.GetDataSet(sql, "court");
			//clear the dataset
			Tools.clearDataset();
			
			//loop through the rows of the dataset
			foreach (DataRow r in ds.Tables[0].Rows) {
				//add each item to the county dropdown box
				county.Items.Add(r[0]);
			}
			
			//do not auto generate columns
			dataGridView1.AutoGenerateColumns = false;
			//create a new text box column, add it to the data grid, change attributes
			DataGridViewColumn col = new DataGridViewTextBoxColumn();
			//add the new column to the data grid
			dataGridView1.Columns.Add(col);
			//change the column name to jurisdiction
			col.Name = "jurisdiction";
			//change the data property name of the column to jurisdiction, data property should be name of column in SQL
			col.DataPropertyName = "jurisdiction";
			//set the width of the column
			col.Width = 165;
			
			//create a new text box column, add it to the data grid, change attributes
			col = new DataGridViewTextBoxColumn();
			//add the new column to the data grid
			dataGridView1.Columns.Add(col);
			//change the column name to ID
			col.Name = "ID";
			//change the data property name of the column to ID, data property should be the name of the column in SQL
			col.DataPropertyName = "ID";
			//set the visibility of the column
			col.Visible = false;
			
			setSql();
			populate();
		}
		
		//method sets the sql statement for the dataset to fill the datagrid
		private void setSql()
		{
			//set the jurisdiciton and countName
			jurisdiction = searchBox.Text;
			countyName = county.Text;
			
			//if the jurisdiction and county name are empty
			if(jurisdiction.Equals("") && countyName.Equals(""))
			{
				sqlPost = "ORDER BY Jurisdiction ASC";
			}
			else if(!jurisdiction.Equals("") && countyName.Equals("")) //if the jurisdiction is not empty and the county is
			{
				sqlPost = "WHERE Jurisdiction LIKE '%" + jurisdiction + "%' ORDER BY Jurisdiction ASC";
			}
			else if(jurisdiction.Equals("") && !countyName.Equals("")) //if the jurisdiction is empty and the county is not
			{
				sqlPost = "WHERE County = '" + countyName + "' ORDER BY Jurisdiction ASC";
			}
			else  //the county and jurisdiction are both not empty
			{
				sqlPost = "WHERE (Jurisdiction LIKE '%" + jurisdiction + "%' AND County = '" + countyName + "') ORDER BY Jurisdiction ASC";
			}
		}
		
		//method fills in the datagrid
		private void populate()
		{			
			//get the dataset
			DataSet ds = Tools.GetDataSet(sqlPre + sqlPost, "court");
			//create a binding source for the data grid
			BindingSource bs = new BindingSource();
			//set the table from the dataset to the binding source
			bs.DataSource = ds.Tables[0];
			//set the datasource to the binding source, binding the data from the dataset to the datagrid
			dataGridView1.DataSource = bs;
			//clear the dataset
			Tools.clearDataset();
		}
		
		//handles the done label click
		private void Label1Click(object sender, EventArgs e)
		{
			//close the form
			this.Close();
		}
		
		//handles the search box change
		private void SearchBoxTextChanged(object sender, EventArgs e)
		{
			//reset the sql and populate the datagrid
			setSql();
			populate();
		}
		
		//handles the county box changed
		private void CountySelectedIndexChanged(object sender, EventArgs e)
		{
			//reset the sql and populate the datagrid
			setSql();
			populate();
		}
		
		//method that handles the clicks of the court
		private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//cast the sender object to a data grid
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header
			if(e.RowIndex >= 0)
			{
				//create a new court info form using the id of the court selected
				CourtInfo cl = new CourtInfo(Int16.Parse(sg[e.ColumnIndex+1, e.RowIndex].Value.ToString()));
				cl.Show();
			}
		}
	}
}
