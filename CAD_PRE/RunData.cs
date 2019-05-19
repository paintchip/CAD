/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/3/2015
 * Time: 6:39 AM
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
	/// Description of RunData.
	/// </summary>
	public partial class RunData : baseform
	{
		#region Properties
		private int eventId;
		#endregion
		
		#region Constructors
		public RunData()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			
			eventId = 0;
			
			InitFields();
		}
		
		public RunData(int EventID)
		{
			basecontrols();
			InitializeComponent();

			eventId = EventID;
			
			InitFields();
		}
		#endregion
		
		private void InitFields()
		{
			//fill date and time fields with current date and time
			Data_Date.Text = DateTime.Today.ToString("MM/dd/yyyy");
			Data_Time.Text = DateTime.Now.ToString("HH:mm");
			
			//create a dataset of all in-service officers
			DataSet ds = Tools.GetDataSet("SELECT * FROM parksIDs WHERE Isv=1 ORDER BY Avail DESC, CarNo ASC", "cad");
			//clear the dataset
			Tools.clearDataset();
			
			//set the datatable to the first table in the dataset
			DataTable dt = ds.Tables[0];
			
			//create a new data column called DisplayInfo
			DataColumn dc = new DataColumn("DisplayInfo");
			//set the data type to string
			dc.DataType = System.Type.GetType("System.String");
			//set the data of the column to be a concatenation of the car and last name fields
			dc.Expression = "CarNo + ' - ' + offLastName";
			//add the new column to the datatable
			dt.Columns.Add(dc);			
	
			//create a row that prompts the user to select an officer
			DataRow dr = dt.NewRow();
			dr["CarNo"] = "--- SELECT OFFICER ---";
			dr["offLastName"] = "";
			dr["offShield"] = 0;
			dt.Rows.InsertAt(dr, 0);

			//set the source of the combobox to the datatable
			Officers.DataSource = dt;
			//set the column to display as the new column
			Officers.DisplayMember = "DisplayInfo";
			//set the column with the bound data to the parks id field
			Officers.ValueMember = "offShield";
			//select the first item in the list
			Officers.SelectedIndex = 0;
			
			//if the event id is not 0
			if(eventId > 0)
			{
				//look up the officer associated with that event
				String sql = "SELECT Shield FROM events WHERE [ID] = " + eventId;
				ds = Tools.GetDataSet(sql, "cad");
				Tools.clearDataset();
				dt = ds.Tables[0];
				dr = dt.Rows[0];
				int shield = int.Parse(dr[0].ToString());
				//lookup parks id of officer
				sql = "SELECT pId FROM parksIDs WHERE offShield = " + shield;
				ds = Tools.GetDataSet(sql, "cad");
				Tools.clearDataset();
				dt = ds.Tables[0];
				dr = dt.Rows[0];
				int id = int.Parse(dr[0].ToString());
				dataForm.setEvent(eventId);
				
				//loop through each item in the drop down
				foreach (DataRowView drv in Officers.Items) {
					//if the officer is in the list
					if(!drv.Row[0].ToString().Equals("") && id == int.Parse(drv.Row[0].ToString()))
					{
						//select the correct officer in the list
						Officers.SelectedValue = id;
						dataForm.setOId(id);
					}
				}
			}
		}
		
		//handles the cancel button click
		private void CancelClick(object sender, EventArgs e)
		{
			//close the form
			this.Close();
		}
		
		//handles when the focus is removed from the officers drop down
		private void OfficersLeave(object sender, EventArgs e)
		{
			ComboBox cb = (ComboBox) sender; //cast the sender to a combobox
			dataForm.setOfficer(cb.Text); //set the dataForms officer property to the text displayed in the combobox
			dataForm.setOId(Int32.Parse(cb.SelectedValue.ToString())); //set the dataForms officer id to the value of the combobox
		}
		
		//handles when the focus is removed from the data location field
		private void DataLocationLeave(object sender, EventArgs e)
		{
			TextBox tb = (TextBox) sender; //cast the sender to a text box
			dataForm.setLoc(tb.Text + ""); //set the dataForms location property to the location value
		}
	}
}
