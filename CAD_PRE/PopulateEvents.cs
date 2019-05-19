/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/4/2015
 * Time: 1:45 PM
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
	/// Description of PopulateEvents.
	/// </summary>
	public partial class PopulateEvents : baseform
	{
		private Vehicle veh;
		private Person per;
		
		public PopulateEvents(Vehicle vehicle, Person person)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			InitControls();
			veh = vehicle;
			per = person;
		}
		
		private void InitControls()
		{
			//do not auto generate columns based on bound data
			dataGridView1.AutoGenerateColumns = false;
			//create an array for the names of the columns, used to bind data to the data grid
			string[] titles = new string[6] {"EvtDate", "EvtTime", "Type", "Location", "Officer", "ID"};
			//create an array for the headers of the columns
			string[] hText = new String[6] {"Date:", "Time:", "Type:", "Location:", "Officer:", "ID:"};
			//create an array for the column widths
			int[] colWidths = new int[6] {70, 40, 130, 130, 110, 10};
			//width for all buttons
			int btnWidth = 25;
			
			//create a new button column, add it to the data grid, change attributes
			DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.Name = "AddData";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";

			//loop through all items in the titles, names and width arrays
			for(int x = 0; x < 6; x++)
			{
				//create a new text box column, add it to the data grid, change attributes
				DataGridViewColumn col = new DataGridViewTextBoxColumn();
				dataGridView1.Columns.Add(col);
				col.Name = titles[x];
				col.DataPropertyName = titles[x];
				col.HeaderText = hText[x];
				col.Width = colWidths[x];
				//disable sorting
				//col.SortMode = DataGridViewColumnSortMode.NotSortable;
				
				//hide the last column, we do not want to see the id column
				if(x == 5)
				{
					col.Visible = false;	
				}
			}
			
			UpdateDataTable(dataGridView1, @"SELECT * FROM ActiveEvents ORDER BY EvtDate DESC, EvtTime DESC");
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
		
		//method handling the cell formatting event for events datagrid, all individual button formatting is done here
		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//create a button cell from the current cell
			DataGridViewButtonCell bc = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell;

			if(e.ColumnIndex == 0)
			{
				bc.ToolTipText = "Add Call to Event";
				bc.Tag = "Call_Entry_Evt";
				e.Value = "";
				e.FormattingApplied = true;
			}
		}
		
		//method for handling the cell painting event, can only add images to buttons from here
		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
			//create variables for the icon and the x and y coordinates to draw the icon on the button
			Icon i;
			int x, y;
			
			if(e.RowIndex >= 0)
			{
				if(dataGridView1.Columns[e.ColumnIndex].Name.Equals("AddData"))
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
					i = new Icon("add_data.ico", 10, 10);
					x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
					y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
					e.Graphics.DrawIcon(i, x, y);
					e.Handled = true;
				}		
			}
        }
		
		//method that handles the clicks in the events datagrid
		private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView) sender;
			
			//check only for button columns and row index is not header row			
			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				//grab the corresponding event id from the row that houses the button being clicked
				int eventId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
		
				DataGridViewButtonCell b = (DataGridViewButtonCell) senderGrid[e.ColumnIndex, e.RowIndex];
				
				//switch case on the column index
				if(e.ColumnIndex == 0)
				{
					//add data to event
					AddDataToEvent(eventId);
				}
			}
		}
		
		//method that adds the data to the selected event
		private void AddDataToEvent(int eventId)
		{
			if(veh == null && per == null)
			{
				TimedMessageBox.Show("No data was selected to populate!", "NO DATA", 1000);
				//MessageBox.Show("No data was selected to populate!");
				return;
			}
			
			if(veh == null)
			{
				per.EventNum = eventId;
				//import person
				per.InsertPerson();
				return;
			}
			
			if(per == null)
			{
				veh.EventNum = eventId;
				//import vehicle
				veh.InsertVehicle();
				return;
			}
			
			this.Close();
		}
	}
}
