/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 1:41 PM
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
	/// Custom control that will hold the most recent calls
	/// </summary>
	public partial class CAD_Calls : UserControl
	{
		//used to determine whether the control is docked in the CAD form or not
		private bool isDocked;
		
		public CAD_Calls()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Dock = DockStyle.Fill;
			toolStripMenuItem1.Text = "Dock";
			this.isDocked = false;
			CreateCallsDataTable();
		}
		
		public CAD_Calls(string text, bool docked)
		{
			InitializeComponent();
			this.Dock = DockStyle.None;
			toolStripMenuItem1.Text = text;
			this.isDocked = docked;
			CreateCallsDataTable();
		}
		
		//method to create the datatable for the calls
		private void CreateCallsDataTable()
		{
			//do not auto generate columns based on bound data
			dataGridView3.AutoGenerateColumns = false;
			//create an  for the names of the columns, used to bind data to the data grid
			string[] titles = new string[6] {"CallDate", "Time1", "Caller", "Reason", "Narrative", "Out"};
			//create an array for the column widths
			int[] colWidths = new int[6] {37, 36, 95, 59, 140, 10};
			
			//loop through all items in the titles, names and width arrays
			for(int x = 0; x < 6; x++)
			{
				//create a new text box column, add it to the data grid, change attributes
				DataGridViewColumn col = new DataGridViewTextBoxColumn();
				//add the new column to the data grid
				dataGridView3.Columns.Add(col);
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

			//when control is docked in CAD form, hide the column headers, else set them visible
			if(isDocked)
			{
				dataGridView3.ColumnHeadersVisible = false;
			}
			else
			{
				dataGridView3.ColumnHeadersVisible = true;
			}
			
			//update the data table
			UpdateDataTable(dataGridView3, @"SELECT * FROM ActiveCalls");
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
		}
		
		//method that updates the call data publicly
		public void UpdateCalls()
		{
			//update the data table
			UpdateDataTable(dataGridView3, @"SELECT * FROM ActiveCalls");
		}
		
		//method that handles the clicks in the calls datagrid
		private void DataGridView3CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//cast the sender object to a data grid
			DataGridView sg = (DataGridView) sender;
			
			//check for only clicks that aren't in the header and from the narrative column
			if(e.RowIndex >= 0 && e.ColumnIndex == 4)
			{
				DataGridViewCell tc = sg[e.ColumnIndex, e.RowIndex];
				//check if the value of the narrative is longer than 16 characters				
				Clipboard.SetText(tc.Value.ToString());
				if(tc.Value.ToString().Length > 17)
				{
					//bring up a message box to show the full narrative
					MessageBox.Show(tc.Value.ToString(), "Call Details");
					//copy the narrative to the clipboard
				}
			}
		}
		
		//method for the cell formatting event for the calls datagrid, all individual button formatting is done here
		private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridViewTextBoxCell tc;
		
			switch(e.ColumnIndex)
			{
				case 0:
				case 1:
					if(e.RowIndex >= 0)
					{
						tc = dataGridView3[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
						//set the color of the text box
						tc.Style.ForeColor = Color.FromArgb(255, 255, 64);
						//set the color of the text box when it is selected
						tc.Style.SelectionForeColor = Color.FromArgb(255, 255, 64);
					}
					break;
				default:
					//set an integer to the outgoing call value
					if(e.RowIndex >= 0)
					{
						try
						{
							int outCall = int.Parse(dataGridView3[5, e.RowIndex].Value.ToString());
							//if the call is outgoing
							if(outCall == 1)
							{
								tc = dataGridView3[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
								//set the color of the text box
								tc.Style.ForeColor = Color.Cyan;
								//set the color of the text box when it is selected
								tc.Style.SelectionForeColor = Color.Cyan;
							}
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					break;
			}
		}
		
		//handle the clicking of the right click menu
		private void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			//case based on whether the control is docked or not
			if(isDocked) //if the control is docked in the CAD form
			{
				//create a new component form
				ComponentForm cf = new ComponentForm(this.Left, this.Top, this.Height, this.Width+10);
				//add CAD_CALLS tag to the component form
				cf.Tag = "CAD_CALLS";
				cf.Name = "CAD_CALLS";
				//add a new CAD_Calls control to the component form
				cf.Controls.Add(new CAD_Calls());
				//hide the current CAD_Control
				this.Visible = false;
				//show the component form
				cf.Show();
				//set the location of the component form to the location of the CAD_Calls control on the CAD form
				//cf.Location = new Point(Application.OpenForms["CAD"].Left + this.Left, Application.OpenForms["CAD"].Top + this.Top);
			}
			else //else if the control is already docked in the component form
			{
				//create an form instance and assign it to the open CAD form
				Form cad = Application.OpenForms["CAD"];
				
				//loop through all of the controls in the CAD form
				foreach (Control ctl in cad.Controls) {
					//if the ctl is a CAD_Calls control
					if(ctl is CAD_Calls)
					{
						//set the control to visible
						ctl.Visible = true;
					}
				}
					
				//loop through all of the open forms				
				foreach (System.Windows.Forms.Form f in Application.OpenForms) {
					//if the form is a CAD CALLS form
					if(f.Name.Equals("CAD_CALLS"))
					{
						//close the form
						f.Close();
						//break out of the loop
						break;
					}
				}
			}
		}
		
		//handles the button click on the data grid
		private void DataGridView3MouseDown(object sender, MouseEventArgs e)
		{
			//if the button clicked is the right mouse button
			if(e.Button == MouseButtons.Right)
			{
				//show the context menu at the current cursor location
				contextMenuStrip1.Show((DataGridView) sender, e.Location.X, e.Location.Y);
			}
		}
		
		//handles the timer tick
		private void Timer1Tick(object sender, EventArgs e)
		{
			//check if the control has focus
			if(!this.Focused)
			{
				//update the data table
				UpdateDataTable(dataGridView3, @"SELECT * FROM ActiveCalls");
			}
		}
		
		//handles the event fired when the visibility of the control is changed
		private void CAD_CallsVisibleChanged(object sender, EventArgs e)
		{
			//set the timer enabled to the form visibility
			this.timer1.Enabled = this.Visible;
		}
	}
}
