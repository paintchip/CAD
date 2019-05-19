/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/3/2015
 * Time: 5:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of SearchLog.
	/// </summary>
	public partial class SearchLog : baseform
	{
		public SearchLog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			this.Calls_datagrid.ForeColor = System.Drawing.Color.Black;
		
		}	
	
		void SearchLogLoad(object sender, EventArgs e)
		{
			//Populating the Reasons combo
			List<String> reasons = new List<string>{"Reason Code"};
			reasons = Tools.tableQuery("ReasonCodes", "","", reasons, false);
			foreach (string reason in reasons) {
				Reason_combo.Items.Add(reason);
			}
			//Populating the Dispatcher ids
			List<string> IDs = new List<string>{"DispatchID"};
			IDs = Tools.tableQuery("users","","",IDs,false);
			foreach (string id in IDs) {
				ID_combo.Items.Add(id);
			}
			CreateCallsDataTable();
			
		}
			private void CreateCallsDataTable()
			{
				//do not auto generate columns based on bound data
				Calls_datagrid.AutoGenerateColumns = false;
				//create an  for the names of the columns, used to bind data to the data grid
				string[] titles = new string[6] {"Date1", "Time1", "SourceCall", "Reason", "Narrative", "Dispatcher"};
				//create an array for the column widths
				int[] colWidths = new int[6] {67, 36, 40, 59, 140, 10};
				
				//loop through all items in the titles, names and width arrays
				for(int x = 0; x < 6; x++)
				{
					//create a new text box column, add it to the data grid, change attributes
					DataGridViewColumn col = new DataGridViewTextBoxColumn();
					//add the new column to the data grid
					Calls_datagrid.Columns.Add(col);
					//change the column name to the string in the index of the titles array
					col.Name = titles[x];
					//change the data property name of the column to the string in the index, data property should be name of column in SQL
					col.DataPropertyName = titles[x];
					//change the width of the column to the width at the index of the colWidths array
					col.Width = colWidths[x];
					
					//last visible column
					if(x == 4)
					{
						//allow column to be resizeable
						col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						col.Resizable = DataGridViewTriState.True;
					}
					
					//hide the last column
					if(x > 4)
					{
						col.Visible = false;	
					}
				}
				
				//update the data table
				UpdateDataTable(Calls_datagrid, @"SELECT * FROM commlog");
			}
			
			//method that binds datagrid data
			private void UpdateDataTable(DataGridView dg, string sql)
			{
				//use the tools class to get the dataset to bind to the data grid
				DataSet ds = Tools.GetDataSet(sql, "cad");
				//create a binding source for the data grid
				BindingSource bs = new BindingSource();
				//set the table from the dataset to the binding source
				bs.DataSource = ds.Tables[0];
				//set the datasource to the binding source, binding the data from the dataset to the datagrid
				dg.DataSource = bs;
				
				//using the tools class, clear the dataset
				Tools.clearDataset();
			}
		
		
		void Search_btnClick(object sender, EventArgs e)
		{
			string[] search_values = new string[5]{Caller_fld.Text, Unit_called_fld.Text, Reason_combo.Text, Search_nar_fld.Text, ID_combo.Text};
			string[] column_names = new string[5]{"SourceCall", "UnitCalled", "Reason", "Narrative", "Dispatcher"};
			string sql = @"SELECT * FROM commlog";
			string from_date = Date_from_fld.Text;
			string to_date = Date_to_fld.Text;
			//I may go through the regex nightmare of adjusting other inputs, but not right now.
			if (Date_from_fld.TextLength > 0 && Date_to_fld.TextLength > 0)
			{
				if (Tools.Date_Fixer(ref from_date) == 0 && Tools.Date_Fixer(ref to_date) == 0)
				{
					if (from_date == to_date)
					{
						sql = sql + " WHERE Date1= '" + from_date + "' ";
					}
					else if (Convert.ToDateTime(from_date) < Convert.ToDateTime(to_date))
					{
						sql = sql + " WHERE Date1 >= '" + from_date + "' AND Date1 <= '" + to_date + "' ";
					}
					else if (Convert.ToDateTime(from_date) > Convert.ToDateTime(to_date))
					{
						MessageBox.Show("From date must be earlier than To date.");
					}
				}
				else
				{
					MessageBox.Show("Date must be in MM/DD/YYYY format");
				}
			}
				else if(Date_from_fld.TextLength <= 0 && Date_to_fld.TextLength > 0)
				{
					if (Tools.Date_Fixer(ref to_date) == 0)
					{
						sql = sql + " WHERE Date1= '" + to_date + "' ";
					}
					else
						MessageBox.Show("Date must be in MM/DD/YYYY format");
				}
				else if (Date_from_fld.TextLength > 0 && Date_to_fld.TextLength <= 0)
				{
					if (Tools.Date_Fixer(ref from_date) == 0)
					{
						sql = sql + " WHERE Date1= '" + from_date + "' ";
					}
					else
						MessageBox.Show("Date must be in MM/DD/YYYY format");
				}
				for(int i = 0; i < search_values.Length; i++)
				{
					if (search_values[i] != "")
					{
						if (sql.Length == 21) // If this is the first values added you need to add the where and then the search field followed by the value
						{
							sql = sql + " WHERE ";
							switch (i) {
								case 3: //For the narrative
									sql = sql + column_names[i] + " ALike '%" + search_values[i] + "%'";
									break;
								default:
									sql = sql + column_names[i] + "= '" + search_values[i] + "' ";
									break;
							}
						}
						else //Add another search value by sing and
						{
							switch (i) {
								case 3: //For the narrative
									sql = sql + "AND " + column_names[i] + " ALike '%" + search_values[i] + "%'";
									break;
								default:
									sql = sql + "AND " + column_names[i] + "= '" + search_values[i] + "' ";
									break;
							}
						}
					}	
				}	
				UpdateDataTable(Calls_datagrid, sql);
		}
		//FIXME this is working correctly
		//method that handles the clicks in the calls datagrid.
		private void Calls_datagridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//cast the sender object to a data grid
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header and from the narrative column
			if(e.RowIndex >= 0 && e.ColumnIndex == 4)
			{
				DataGridViewCell tc = sg[e.ColumnIndex, e.RowIndex];
				Clipboard.SetText(tc.Value.ToString());
				//check if the value of the narrative is longer than 16 characters				
				if(tc.Value.ToString().Length > 17)
				{
					//bring up a message box to show the full narrative
					MessageBox.Show(tc.Value.ToString(), "Call Details");
				}
			}
		}		
		
		void Export_btnClick(object sender, EventArgs e)
		{
			//PrintPreviewDialog
		}
		
		void Reset_btnClick(object sender, EventArgs e)
		{
			foreach (Control c in this.Controls)
            {
				Console.WriteLine(c.GetType().ToString());
				if (c.GetType().ToString() == "System.Windows.Forms.TextBox" || c.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    c.Text = "";
                }
            }
		}
	}
}

