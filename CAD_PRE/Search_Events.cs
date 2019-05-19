/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/22/2015
 * Time: 9:27 PM
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
	/// Description of Search_Events.
	/// </summary>
	public partial class Search_Events : baseform
	{
		public Search_Events()
		{
			//TODO YOu have copied a lot of code from the CAD-Events form. you need to make the code generic, put it in tools and use it there, here, and in the upcoming closed events form
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			this.EvtDatagrid.ForeColor = System.Drawing.Color.Yellow;
			string[] evt_flds = new string[5]{"eventDate", "callTime", "narrative", "address", "business"}; //these names are weird because you had to shoehorn in the data to the event class. the class is set up to take integers and the like for creating parks events. I don't need any of that so I had the parser just stuff the info in available slots
			int[] evt_col_width = new int[5]{65, 45, 95, 165, 115};
			Fill_grid(EvtDatagrid, evt_flds, evt_col_width);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Search_Events_btnClick(object sender, EventArgs e)
		{
			string sql =  @"SELECT * FROM events WHERE Shield=" + ((Officer)Search_Events_Member_combo.SelectedItem).returnshield().ToString();
			string search_date = Search_Events_Date_txt.Text;
			if (Tools.Date_Fixer(ref search_date) == 0)
			{
				sql = sql + " AND EvtDate=" + search_date;
			}
			DataSet mDS = Tools.GetDataSet(sql, "cad");
			List<string> evt_values = new List<string>();
			foreach (DataRow r in mDS.Tables[0].Rows ) {
				evt_values.Add(r["EvtDate"].ToString());
				evt_values.Add(r["OutTime"].ToString());
				evt_values.Add(r["Type"].ToString());
				evt_values.Add(r["Location"].ToString());
				evt_values.Add(r["Off"].ToString());
				evt_values.Add(r["ID"].ToString());
			}
			EvtLoad(evt_values);
		}
		
		private void UpdateDataTable(DataGridView dg, List<Event> events)
		{
			//clear any current data source
			dg.DataSource = null; //
			//create a binding source for the data grid
			BindingSource bs = new BindingSource();
			//set the table from the dataset to the binding source
			bs.DataSource = events;
			//set the datasource to the binding source, binding the data from the dataset to the datagrid
			dg.DataSource = bs;
		}
		
		private void Fill_grid(DataGridView datagrid, string[] fields, int[] width)
		{
			    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
				datagrid.Columns.Add(btn);
				btn.Name = "View";
				btn.UseColumnTextForButtonValue = true;
				btn.Width = 20;
				btn.HeaderText = "";
				int counter = 0;
				foreach (string field in fields) {
					DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
	      			column1.Name = field;
	      			column1.HeaderText = field;
	      			column1.DataPropertyName = field;
	      			if (width[counter] != 0)
	      				column1.Width = width[counter];
	      			else
	      				column1.Width = width[95];
	         		datagrid.Columns.Add(column1);
	         		counter++;
				}

		}
		void datagridCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
			if(e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 0)
				{
					//create variables for the icon and the x and y coordinates to draw the icon on the button
					Icon i;
					int x, y;
					
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
					i = new Icon(@"img\open_folder.ico", 10, 10);
					x = (int) (e.CellBounds.Width/2 - i.Width/2) + e.CellBounds.X;
					y = (int) (e.CellBounds.Height/2 - i.Height/2) + e.CellBounds.Y;
					e.Graphics.DrawIcon(i, x, y);
					e.Handled = true;
				}
			}
		}
		private void EvtDatagridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		    var senderGrid = (DataGridView)sender;
		    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
		        e.RowIndex >= 0)
		    {
		    	Event evt = (Event)EvtDatagrid.CurrentRow.DataBoundItem;
		    	View_Event_Form vef = new View_Event_Form(Int32.Parse(evt.LocalNo));
		    	vef.Show();
		    }
		}
		
		private void EvtLoad(List<String> evt_values)
		{
			if (evt_values.Count != 0) //Don't bother with the rest if there are no events
			{
				List<Event> evt_lst = new List<Event>();
				evt_lst = Tools.Short_Event_Parser(evt_values);
				EvtDatagrid.AutoGenerateColumns = false;
				try{
					UpdateDataTable(EvtDatagrid, evt_lst);
				}
				catch (InvalidOperationException) 
				{
					Console.WriteLine("Failed to bind the data source to the evt grid. ");
				}
				
			
			}
			else
				EvtDatagrid.DataSource = null; //If there were no events in the results, clear the grid
		}

		void Search_Events_Zone_comboDropDownClosed(object sender, EventArgs e)
		{
			string zone = "";
			//This is about the third time you've put in these hardcoded associations. Maybe you should create a likke lookup method.
			switch (Search_Events_Zone_combo.Text) //I'm hardcoding in the region names to the numbers to avoid another table lookup
			{
				case "Thousand Islands":
					zone = "1";
					break;
				case "Central":
					zone = "5";
					break;
				case "Finger Lakes":
					zone = "6";
					break;
				default:
					zone = "0";
					break;
			}
			
			//create a dataset of all in-service officers
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE pZone=" + zone + " ORDER BY offLastName ASC", "cad");
		
			//loop through all of the records in the in-service dataset
			foreach (DataRow dr in ds.Tables[0].Rows) 
			{
				//add the current item to the drop down for the caller
				string officer_name = dr["offLastName"].ToString() + ", " + dr["offFirstName"].ToString();
				try {
					Search_Events_Member_combo.Items.Add(new Officer(officer_name, Int32.Parse(dr["pZone"].ToString()), Int32.Parse(dr["offShield"].ToString())));
				}
				catch (InvalidOperationException) 
				{}
			}
			Tools.clearDataset();
		}
	}
}
