/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/12/2015
 * Time: 10:05 AM
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
	/// Description of MultState.
	/// </summary>
	public partial class MultState : baseform
	{
		private int numStates = 0; //the number of states selected, initially 0
		private const int MAX_STATES = 5; //the maximum number of states that can be selected
		private string sqlPre = "SELECT State, StateFull FROM states "; //initial sql to be called
		private string sqlPost = ""; //for filtering the states
		private string state = ""; //holds the text entered into the state search box
		private DataForm CallingForm; //ref to the form that called the multstate form
		
		public MultState()
		{
			this.defaultSize = new Size(341, 367);
			this.defaultLocation = System.Windows.Forms.Cursor.Position;
			
			basecontrols();
			InitializeComponent();
			
			Selected.BackColor = this.BackColor;
			InitDataGrid();
			SetSql();
			populateData();
		}
		
		//method that initiates the data grid
		private void InitDataGrid()
		{	
			dataGridView1.BackgroundColor = this.BackColor; //set the back color of the data grid to the same as the form	
			dataGridView1.AutoGenerateColumns = false; //do not auto generate columns as we want custom headers
			
			DataGridViewColumn col = new DataGridViewTextBoxColumn(); //create a new text column
			dataGridView1.Columns.Add(col); //add the new column to the datagrid
			col.Name = "State"; //set the name of the column
			col.DataPropertyName = "State"; //set the name of the field bound to the column
			col.HeaderText = "Code"; //set the header text of the column
			col.Width = 40; //set the width of the column
			
			col = new DataGridViewTextBoxColumn(); //create a new text column
			dataGridView1.Columns.Add(col); //add the new column to the datagrid
			col.Name = "StateFull"; //set the name of the column
			col.DataPropertyName = "StateFull"; //set the name of the field bound to the column
			col.HeaderText = "State"; //set the header text of the column
			col.Width = 230; //set the width of the column
			
			dataGridView1.DefaultCellStyle.BackColor = this.BackColor;
		}
		
		//method that changes the sql
		private void SetSql()
		{
			state = Search_Box.Text;
			
			if(state == "" || state == null) //if the state search box is empty
			{
				sqlPost = "ORDER BY StateFull ASC"; //don't filter the results
			}
			else
			{
				sqlPost = "WHERE StateFull LIKE '%" + state + "%' ORDER BY StateFull ASC"; //filter results based on search box
			}
		}
		
		//method that populates the datagrid
		private void populateData()
		{
			DataSet ds = Tools.GetDataSet(sqlPre + sqlPost, "cad"); //get the dataset
			BindingSource bs = new BindingSource(); //create a binding source for the datagrid
			bs.DataSource = ds.Tables[0]; //set the binding source to the first table from the dataset
			dataGridView1.DataSource = bs; //set the datagridviews datasource to the binding source
			Tools.clearDataset(); //clear the dataset
		}
		
		//handles clicking of labels
		private void LblClick(object sender, EventArgs e)
		{
			Label lbl = (Label) sender;
			
			switch (lbl.Name) {
				case "ClearLbl": //clear label
					Search_Box.Text = ""; //set the search box text to an empty string
					break;
					
				case "RemoveLbl": //remove all label
					numStates = 0; //reset the number of states to 0
					Selected.Text = ""; //reset the selected text back to an empty string
					SelectedLbl.Text = "Selected (0/5):"; //reset the label to show that no states have been selected
					break;
					
				case "DoneLbl": //done label
					CallingForm.setMultState(Selected.Text);
					Close(); //close the form
					break;
					
				default:
					break;
			}
		}
		
		//when the search box changes, change the data in the grid
		private void Search_BoxTextChanged(object sender, EventArgs e)
		{
			SetSql();
			populateData();
		}
		
		//handles the cell content click
		private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dg = (DataGridView) sender; //cast the sender to a datagridview
			string comma = ","; //set the comma string to a comma
			string stateName = ""; //set the state name to an empty string
			 
			if(e.RowIndex >= 0 && e.ColumnIndex == 1) //if the cell clicked is not in the header row and in column 1
			{
				if(numStates < MAX_STATES) //if the number of states selected is less than or equal to the max states
				{

					stateName = dg[0, e.RowIndex].Value.ToString(); //get the state abbreviate from the first column
					
					if(numStates == 0) //if the number of states is 0
						comma = ""; //comma string becomes an empty string
					
					numStates++; //increment the number of states selected
					
					Selected.Text += comma + stateName; //add the comma string and the state abbreviation to the selected text
					SelectedLbl.Text = "Selected (" + numStates + "/5):"; //change the number of states selected in the label
				}
			}
		}
		
		//method to set the calling form
		public void setForm(DataForm form)
		{
			CallingForm = form;
		}
	}
}
