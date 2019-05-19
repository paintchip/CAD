/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/31/2015
 * Time: 6:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Closed_Events.
	/// </summary>
	public partial class Closed_Events : Form
	{
		public Closed_Events()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string[] evt_flds = new string[5]{"eventDate", "callTime", "narrative", "address", "business"}; //these names are weird because you had to shoehorn in the data to the event class. the class is set up to take integers and the like for creating parks events. I don't need any of that so I had the parser just stuff the info in available slots
			int[] evt_col_width = new int[5]{65, 45, 95, 165, 115};
			Fill_grid(EvtDatagrid, evt_flds, evt_col_width);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
					EvtDatagrid.DataSource = evt_lst;
				}
				catch (InvalidOperationException) 
				{
					Console.WriteLine("Failed to bind the data source to the evt grid. ");
				}
				
			
			}
			else
				EvtDatagrid.DataSource = null; //If there were no events in the results, clear the grid
		}
		
		void Closed_EventsLoad(object sender, EventArgs e)
		{
			string sql =  @"SELECT * FROM events WHERE EvtDate= #" + DateTime.Today.ToString("MM/dd/yyyy") + "# OR EvtDate= #" + DateTime.Today.AddDays(-1).ToString("MM/dd/yyyy") + "# ORDER BY EvtDate DESC";
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
	}
}
