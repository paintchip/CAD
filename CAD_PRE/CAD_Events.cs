/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of CAD_Events.  Custom control for displaying the current events.
	/// </summary>
	public partial class CAD_Events : UserControl
	{	
		//boolean to determine whether the control is docked in the CAD form or not
		private bool isDocked;		
		
		public CAD_Events()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Dock = DockStyle.Fill;
			CreateEventsDataTable();
			toolStripMenuItem1.Text = "Dock";
			isDocked = false;
		}
		
		public CAD_Events(string text, bool docked)
		{
			InitializeComponent();
			this.Dock = DockStyle.None;
			CreateEventsDataTable();
			toolStripMenuItem1.Text = text;
			isDocked = docked;
		}
		
		//method to create the data table for the current events
		private void CreateEventsDataTable()
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
			btn.Name = "AddCall";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.Name = "Status";
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
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.Name = "OpenEvent";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.Name = "RunData";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView1.Columns.Add(btn);
			btn.Name = "Clear";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			//change active to 1 on live release
			UpdateDataTable(dataGridView1, @"SELECT * FROM ActiveEvents WHERE Active=1");
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
		
		//method that updates the events data table publicly
		public void UpdateEvents()
		{
			//change active to 1 on live release
			UpdateDataTable(dataGridView1, @"SELECT * FROM ActiveEvents WHERE Active=1");
		}
		
		//method that handles the clicks in the events datagrid
		private void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView) sender;
			
			//check only for button columns and row index is not header row			
			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				//grab the corresponding event id from the row that houses the button being clicked
				int eventId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
		
				DataGridViewButtonCell b = (DataGridViewButtonCell) senderGrid[e.ColumnIndex, e.RowIndex];
				
				//switch case on the column index
				switch (e.ColumnIndex) {
					//add call button. This was under case 10 and was only triggering because of the switch cascading with no breaks
					case 0:
						CAD_ButtonClick(b, e, eventId, 2);
						break;
					case 1:
						//status button. This was listed as view event, but triggered while clicking the status button
						status_checked(eventId);
						//TODO Change the color of the cell back to blue. ATM this seems to be hard set to red after 5 minutes from the initial event time.
						break;
					case 8:
						//view event button
						View_Event_Form vef = new View_Event_Form(eventId); // should be adjusted to trigger like above
						vef.Show();
						break;
					case 9:
						//run data button
						CAD_ButtonClick(b, e, eventId, 2);
						break;
					case 10:
						//clear event button
						clear_event(eventId);
						break;
					default:
						break;
				}
			}
		}
		
		//method that handles button clicks
		private void CAD_ButtonClick(object sender, EventArgs e)
		{
			CAD_ButtonClick(sender, e, 0, 0);
		}
		
		//method that handles button clicks
		private void CAD_ButtonClick(object sender, EventArgs e, int id, int idType)
		{	
			//set the tag to an empty string
			string tag = "";
			
			//check the type of the object sending the click event			
			if(sender.GetType().Name.ToString().Equals("Button")) //if the object is a button
			{
				//create a button object from the sender
				Button b = (Button) sender;
				//set the tag to the button tag
				tag = b.Tag.ToString();
			}
			else
			{
				//create a datagrid button from the sender
				DataGridViewButtonCell dg = (DataGridViewButtonCell) sender;
				//set the tag to the button tag
				tag = dg.Tag.ToString();
			}
			//call the static method checkButton to handle the button click
			CAD_Buttons.checkButton(tag, id, idType);
		}
		
		//method handling the cell formatting event for events datagrid, all individual button formatting is done here
		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//create a button cell from the current cell
			DataGridViewButtonCell bc = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell;
			//switch case on column index to catch only button columns
			switch (e.ColumnIndex) {
				//add call button
				case 0:
					bc.ToolTipText = "Add Call to Event";
					bc.Tag = "Call_Entry_Evt";
					e.Value = "";
					e.FormattingApplied = true;
					break;
				//status check button
				case 1:
					bc.ToolTipText = "Status Check Unit on Call";
					bc.Tag = "Status";
					e.Value = "";
					e.FormattingApplied = true;
					break;
				//open event button
				case 8:
					bc.ToolTipText = "Open Event";
					bc.Tag = "Open_Event";
					e.Value = "";
					e.FormattingApplied = true;
					break;
				//run data button
				case 9:
					bc.ToolTipText = "Run Data for Event";
					bc.Tag = "Run_Data_Evt";
					e.Value = "";
					e.FormattingApplied = true;
					break;
				//clear event button
				case 10:
					bc.ToolTipText = "Clear Event";
					bc.Tag = "Clear_Event";
					e.Value = "";
					e.FormattingApplied = true;
					break;
				//text boxes
				default:
					//get time of event
					DateTime d = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString());
					//get current time
					DateTime n = DateTime.Now;
					//get the difference between the 2 times
					TimeSpan ts = n - d;
	
					//check if the difference is over 5 minutes
					if(Math.Abs(ts.TotalMinutes) > 5)
					{
						//set the current cell to a text cell
						DataGridViewTextBoxCell tc = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
						//change the text color to red
						tc.Style.ForeColor = Color.Red;
						tc.Style.SelectionForeColor = Color.Red;
					}
					break;
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
				switch (dataGridView1.Columns[e.ColumnIndex].Name) {
					//add call button
	            	case "AddCall":
						e.Paint(e.CellBounds, DataGridViewPaintParts.All);
						i = new Icon(@"img\edit.ico", 10, 10);
						x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
						y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
						e.Graphics.DrawIcon(i, x, y);
						e.Handled = true;
	            		break;
	            	//status check button
	            	case "Status":
	            		e.Paint(e.CellBounds, DataGridViewPaintParts.All);
						i = new Icon(@"img\check.ico", 10, 10);
						x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
						y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
						e.Graphics.DrawIcon(i, x, y);
						e.Handled = true;
	            		break;
	            	//open event button
	            	case "OpenEvent":
	            		e.Paint(e.CellBounds, DataGridViewPaintParts.All);
						i = new Icon(@"img\open_folder.ico", 10, 10);
						x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
						y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
						e.Graphics.DrawIcon(i, x, y);
						e.Handled = true;
	            		break;
	            	//run data button
	            	case "RunData":
	            		e.Paint(e.CellBounds, DataGridViewPaintParts.All);
						i = new Icon(@"img\search.ico", 10, 10);
						x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
						y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
						e.Graphics.DrawIcon(i, x, y);
						e.Handled = true;
	            		break;
	            	//clear event button
	            	case "Clear":
	            		e.Paint(e.CellBounds, DataGridViewPaintParts.All);
						i = new Icon(@"img\clear.ico", 10, 10);
						x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
						y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
						e.Graphics.DrawIcon(i, x, y);
						e.Handled = true;
	            		break;
	            	default:
	            		break;
	            }
			}
        }
		
		//handles the menu click option
		private void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			//check if the control is docked
			if(isDocked) //if docked in CAD form
			{
				//create a new component form the size of the CAD_Events control
				ComponentForm cf = new ComponentForm(this.Left, this.Top, this.Height, this.Width+10);
				//add a the "CAD_EVENTS" tag to the form
				cf.Tag = "CAD_EVENTS";
				cf.Name = "CAD_EVENTS";
				//add a cad event control to the form
				cf.Controls.Add(new CAD_Events());
				//hide the current cad event control on the CAD form
				this.Visible = false;
				//show the new component form
				cf.Show();
				//set the location of the new component form to the location of the current events control
				//cf.Location = new Point(Application.OpenForms["CAD"].Left + this.Left, Application.OpenForms["CAD"].Top + this.Top);
			}
			else //if not docked in CAD form
			{
				//create a form object from the current open
				Form cad = Application.OpenForms["CAD"];
				
				//loop through all of the controls on the CAD form
				foreach (Control ctl in cad.Controls) {
					//if the control is a CAD_Events control
					if(ctl is CAD_Events)
					{
						//set the control to be visible
						ctl.Visible = true;
					}
				}
				
				//loop through all of the open forms				
				foreach (System.Windows.Forms.Form f in Application.OpenForms) {
					//if the form is a CAD_EVENTS form
					if(f.Name.Equals("CAD_EVENTS"))
					{
						//close the form
						f.Close();
						//break out of the loop
						break;
					}
				}
			}
		}
		
		//handles clicking of the datagrid
		private void DataGridView1MouseDown(object sender, MouseEventArgs e)
		{
			//if the button clicked is the right mouse button
			if(e.Button == MouseButtons.Right)
			{
				//show the right click context menu
				contextMenuStrip1.Show((DataGridView) sender, e.Location.X, e.Location.Y);
			}
		}
		
		//set the text of the right click menu
		public void SetMenuText(string text)
		{
			toolStripMenuItem1.Text = text;
		}
		//method run when the status check button is clicked. Sends a call to the log and updates the color of the event text
		private void status_checked(int evt_id)
		{
			//TODO Either move this to the button created for it in CAD_Buttons or delete the entry there.
			List<string> evt_info = new List<string>{"Off", "Type"};
			evt_info = Tools.tableQuery("events", "ID", evt_id.ToString(), evt_info,true);
			if (evt_info.Count > 1) // if it's only one then it did not find the event number
			{
				CAD cad = (CAD) Application.OpenForms["CAD"];
				string date = DateTime.Today.ToString("MM/dd/yyyy");
				string time = DateTime.Now.ToString("HH:mm");
				string sql = @"INSERT INTO commlog (Date1, Time1, UnitCalled, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"+ date + "', '" + time + "', '" + evt_info[0] + "', 'MS', 'STATUS', '" + evt_info[1] + "', " + cad.getUser().getDispatchId() + ")";
				Tools.runSql(sql, "cad");
				Tools.requeryUserControls("c");
			}
		}
		private void clear_event(int evt_id)
		{
			CAD cad = (CAD) Application.OpenForms["CAD"];
			string off_name = Tools.tableQuery("events", "ID", evt_id.ToString(), "Off" ,true);	
			if (off_name.Substring(0,2) != "-1")
			{
				string date = DateTime.Today.ToString("MM/dd/yyyy");
				string time = DateTime.Now.ToString("HH:mm");
				
				//Send CLR to the commlog
				string sql = @"INSERT INTO commlog (Date1, Time1, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"+ date + "', '" + time + "', '" + off_name + "', 'CLR', 'EVENT', " + cad.getUser().getDispatchId() + ")";
				Tools.runSql(sql, "cad");
				Tools.requeryUserControls("c");
				
				//Update the events table
				sql = @"UPDATE events SET LastTime='" + time + "', LastDate='" + date + "', Active=" + 0 + " WHERE ID=" + evt_id;
				Tools.runSql(sql, "cad");
				Tools.requeryUserControls("e");
			}
			
		}
	}
}
