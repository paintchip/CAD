/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of CAD_Officers.
	/// </summary>
	public partial class CAD_Officers : UserControl
	{
		private bool isDocked;
		private int officerZone;
		private string officerSql;
		private bool isvOnly = false;

		public CAD_Officers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CreateOfficersDataTable();
			this.Dock = DockStyle.Fill;
			toolStripMenuItem1.Text = "Dock";
			isDocked = false;
		}
		
		public CAD_Officers(string text, bool docked)
		{
			InitializeComponent();
			CreateOfficersDataTable();
			this.Dock = DockStyle.None;
			toolStripMenuItem1.Text = text;
			isDocked = docked;
		}
		
		//method to create the datatable for the officers
		private void CreateOfficersDataTable()
		{
			officerZone = 5;
			//set up sql strings
			officerSql = @"SELECT * FROM ActiveOfficers WHERE pZone = "+ officerZone +" ORDER BY OfficerInfo ASC";
			
			//do not auto generate columns based on bound data
			dataGridView2.AutoGenerateColumns = false;
			//create an array for the names of the columns, used to bind data to the data grid
			string[] titles = new string[4] {"OfficerInfo", "pId", "Avail", "Isv"};
			//create an array for the column widths
			int[] colWidths = new int[4] {275, 10, 10, 10};
			//width for all buttons
			int btnWidth = 20;
			
			//loop through all items in the titles, names and width arrays
			for(int x = 0; x < 4; x++)
			{
				//create a new text box column, add it to the data grid, change attributes
				DataGridViewColumn col = new DataGridViewTextBoxColumn();
				dataGridView2.Columns.Add(col);
				col.Name = titles[x];
				col.DataPropertyName = titles[x];
				col.Width = colWidths[x];
				
				//hide all columns except the first
				if(x > 0)
				{
					col.Visible = false;	
				}
			}
			
			//create a new button column, add it to the data grid, change attributes
			DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
			dataGridView2.Columns.Add(btn);
			btn.Name = "Call";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView2.Columns.Add(btn);
			btn.Name = "Info";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			//create a new button column, add it to the data grid, change attributes
			btn = new DataGridViewButtonColumn();
			dataGridView2.Columns.Add(btn);
			btn.Name = "Event";
			btn.UseColumnTextForButtonValue = true;
			btn.Width = btnWidth;
			btn.HeaderText = "";
			
			UpdateDataTable(dataGridView2, officerSql);
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
		
		//method that updates the officer control publicly
		public void UpdateOfficers()
		{
			UpdateDataTable(dataGridView2, officerSql);
		}
		
		//method that handles the clicks in the officers datagrid
		private void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header
			if(e.RowIndex >= 0)
			{
				int officerId = Int32.Parse(sg[1, e.RowIndex].Value.ToString());
				
				switch (e.ColumnIndex){
					//officer text is clicked
					case 0:
						//create a dialog result from a message box that shows 3 buttons, yes, no, and cancel
						DialogResult d = MessageBox.Show("Create in-service entry in log?", "In-service Entry", MessageBoxButtons.YesNoCancel);
						//if user clicked yes
						if(d == DialogResult.Yes)
						{
							//create a new assignment with the officer id
							Assignment a = new Assignment(officerId, true);
							//set a new CAD object from the existing CAD object
							CAD c = (CAD) Application.OpenForms["CAD"];
							//create a new user object from the CAD objects user
							User u = c.getUser();
							
							//generate the sql to insert a call indicating a member called in service with todays time and date
							string sql = @"INSERT INTO commlog (Date1, Time1, UnitCalled, SourceCall, Reason, Narrative, Dispatcher) VALUES ('"
								+ DateTime.Today.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToString("HH:mm") + "', '', '" + a.Shield.ToString()
								+ "', 'ISV', '', " + u.getDispatchId() + ")";
							
							//run the sql
							Tools.runSql(sql, "cad");
							
							//requery the calls control
							Tools.requeryUserControls("c");
							
							//create a new browser object to enter the assignment into PARKS
							Browser br = new Browser("assign", 0, a, "p", null);
							//show the new browser object
							br.Show();
						}
						//if the user clicked no
						else if(d == DialogResult.No)
						{
							//create a new browser object to enter the assignment
							Browser br = new Browser("assign", 0, new Assignment(officerId, true), "p", null);
							//show the new browser object
							br.Show();
						}
						break;
					//call button is clicked
					case 4:
					//info button is clicked
					case 5:
					//event button is clicked
					case 6:
						//create a new button object from the clicked object
						DataGridViewButtonCell b = (DataGridViewButtonCell) sg[e.ColumnIndex, e.RowIndex];
						//handle the button click
						CAD_ButtonClick(b, e, officerId, 1);
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
				
			//if the type of object clicked was a button
			if(sender.GetType().Name.ToString().Equals("Button"))
			{
				//cast the sender to a button object
				Button b = (Button) sender;
				//set the tag to the tag of the button
				tag = b.Tag.ToString();
			}
			else //else the type of object clicked was a datagrid button
			{
				//cast the sender to a datagrid button
				DataGridViewButtonCell dg = (DataGridViewButtonCell) sender;
				//set the tag to the tag of the datagrid button
				tag = dg.Tag.ToString();
			}
			
			//handle the button click through the static CAD_Buttons class
			CAD_Buttons.checkButton(tag, id, idType);
		}
		
		//method for the cell formatting event for the officers datagrid, all individual button formatting is done here
		private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridViewButtonCell bc;
			DataGridViewTextBoxCell tc;
			//new font object used for the text of the buttons
			Font f = new Font("Microsoft Sans Serif", 6.0f, FontStyle.Regular);
			
			switch(e.ColumnIndex)
			{
				case 0: //info column with name, shield, and car
					//set the avail int to the value in the 2nd column
					int avail = (int) dataGridView2[2, e.RowIndex].Value;
					//set the inv int to the value in the 3rd column
					int isv = (int) dataGridView2[3, e.RowIndex].Value;
					
					tc = dataGridView2[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
					
					if(isv == 1) //if the user is in service
					{
						if(avail == 1)//if the user is available
						{
							//set the fore color and fore color when selected to cyan
							tc.Style.ForeColor = Color.Cyan;
							tc.Style.SelectionForeColor = Color.Cyan;
						}
						else//the user is in unavailable status
						{
							//set the fore color and fore color when selected to red
							tc.Style.ForeColor = Color.FromArgb(192, 0, 0);
							tc.Style.SelectionForeColor = Color.FromArgb(192, 0, 0);
						}
					}
					break;
				case 4: //column holding the call button
					bc = dataGridView2[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell;
					e.CellStyle.Font = f; //set the font of the button
					e.Value = "C"; //set the text of the button
					bc.ToolTipText = "Generate Call for Selected Officer"; //set the tool tip of the button
					bc.Tag = "Call_Entry_Ofc"; //set the tag of the button
					e.FormattingApplied = true; //applies the formatting
					break;
				case 5: //column holding the info button
					bc = dataGridView2[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell;
					e.CellStyle.Font = f; //set the font of the button
					e.Value = "I"; //set the text of the button
					bc.ToolTipText = "Lookup Contact Info for Selected Officer"; //set the tool tip of the button
					bc.Tag = "Contact_Info"; //set the tag of the button
					e.FormattingApplied = true; //applies the formatting
					break;
				case 6: //column holding the event button
					bc = dataGridView2[e.ColumnIndex, e.RowIndex] as DataGridViewButtonCell;
					e.CellStyle.Font = f; //set the font of the button
					e.Value = "E"; //set the text of the button
					bc.ToolTipText = "Create PARKS Event for Selected Officer"; //set the tool tip of the button
					bc.Tag = "Parks_Event"; //set the tag of the button
					e.FormattingApplied = true; //applies the formatting
					break;
				default:
					break;
			}
		}
		
		//handles the right click menu items click event
		private void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			//if the control is docked in the main CAD form
			if(isDocked)
			{
				//create a new component form using the coordinates, height, and width of the current control
				ComponentForm cf = new ComponentForm(this.Left, this.Top, this.Height, this.Width+10);
				//set the tag of the new form
				cf.Tag = "CAD_OFFICERS";
				cf.Name = "CAD_OFFICERS";
				//add a new CAD_Officers control to the form
				cf.Controls.Add(new CAD_Officers());
				//hide the current control
				this.Visible = false;
				//show the component form
				cf.Show();
				//set the location of the new component form to the location of the current control
				//cf.Location = new Point(Application.OpenForms["CAD"].Left + this.Left, Application.OpenForms["CAD"].Top + this.Top);
			}
			else //the control is in an existing component form
			{
				//get the CAD form
				Form cad = Application.OpenForms["CAD"];
				
				//loop through all the controls on the cad form
				foreach (Control ctl in cad.Controls) {
					if(ctl is CAD_Officers) //if the control is a CAD_Officers control
					{
						//unhide the control
						ctl.Visible = true;
					}
				}
					
				//loop through all of the open forms				
				foreach (System.Windows.Forms.Form f in Application.OpenForms) {
					if(f.Name.Equals("CAD_OFFICERS")) //if the form is a CAD OFFICERS form
					{
						f.Close(); //close the form
						break; //break out of the loop
					}
				}
			}
		}
		
		//handles the mouse down event for the datagrid object
		private void DataGridView2MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right) //if the right mouse button is clicked
			{
				//show the context menu, at the current mouse location
				contextMenuStrip1.Show((DataGridView) sender, e.X, e.Y);
			}
		}
		
		//handles tab change event, changes the selected zone for the officers list
		private void TabControl1Selected(object sender, TabControlEventArgs e)
		{
			switch (tabControl1.SelectedIndex) {
				case 0: //the first tab is selected
					officerZone = 5; //set the officer zone to 5, CEN
					break;
				case 1: //the second tab is selected
					officerZone = 1; //set the officer zone to 1, TI
					break;
				case 2: //the third tab is selected
					officerZone = 6; //set the officer zone to 6, FL
					break;
				default:
					break;
			}
			
			//call sql reset method to change officer zone
			resetSql();
			//update the officer data grid
			UpdateDataTable(dataGridView2, officerSql);
		}
		
		//resets officer sql for updated zone change based on tab selection
		private void resetSql()
		{
			if(!isvOnly) //set sql based on whether the isv only button is active
			{
				officerSql = @"SELECT * FROM ActiveOfficers WHERE pZone = "+ officerZone +" ORDER BY OfficerInfo ASC";
			}
			else
			{
				officerSql = @"SELECT * FROM ActiveOfficers WHERE pZone = " + officerZone + " AND Isv = 1 ORDER BY OfficerInfo ASC";
			}
		}
		
		//handles the isv only button click
		private void Button1Click(object sender, EventArgs e)
		{
			if(isvOnly) //if isv only is true
			{
				isvOnly = false; //set isv only to false
				button1.Text = "Isv Only"; //set the text of button 1
			}
			else
			{
				isvOnly = true; //set isv only to true
				button1.Text = "All"; //set the text of button 1
			}
			
			//reset the sql
			resetSql();
			//update the data table
			UpdateDataTable(dataGridView2, officerSql);
		}
	}
}
