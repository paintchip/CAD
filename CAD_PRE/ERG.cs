/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/10/2015
 * Time: 1:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of ERG. Emergency Reference Guide
	/// TODO
	/// when done designing redo resources file and designer file
	/// </summary>
	public partial class ERG : baseform
	{
		private DataSet ds;
		private int curRec;
		private int maxRec;
		private int zoneId;
		
		public ERG(int zoneId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			basecontrols();
			InitializeComponent();
			panel1.BackColor = return_bg();
			panel2.BackColor = return_bg();
			panel3.BackColor = return_bg();
			 //We want the form to look like the others and not to take on the color of the other panels
			string database = ""; //string that will hold the database location
			string sql = ""; //string that will hold the sql to get the erg info
			
			//switch case based on zoneId
			switch(zoneId)
			{
				case 5: //central selected
					database = "cen_guide"; //set the central database
					break;
				case 1: //ti selected
					database = "ti_guide"; //set the ti database
					break;
				case 6: //fl selected
					database = "fl_guide"; //set the fl database
					break;
				default:
					break;
			}
			
			//set the zoneId
			this.zoneId = zoneId;
			
			//generate the sql to get all records from the erg
			sql = "SELECT * FROM [PANIC BOOK] ORDER BY [Park / Facility] ASC";
			//set the dataset from the returned dataset
			ds = Tools.GetDataSet(sql, database);
			//clear the dataset
			Tools.clearDataset();
			
			//initialize fields starting at the first record
			initFields(0);
			
			//set the maximum number of records
			maxRec = ds.Tables[0].Rows.Count - 1;
		}
		
		//initialize field values
		private void initFields(int recordId)
		{		
			//TODO Think about throwing  this is a background thread so that you can mouse through the options faster. right now you have to mouse through really slowly. Presumably because everything is still loading.
			//set the current record
			curRec = recordId;
			//data row holding the information for the selected row
			DataRow row = ds.Tables[0].Rows[recordId];
			
			//set the fields values from the row
			park.Text = row["Park / Facility"].ToString();
			address.Text = row["Copy of Address"].ToString();
			park_phone.Text = row["Park Phone"].ToString();
			manager.Text = row["Manager"].ToString();
			manager_home.Text = row["Mgr Phone"].ToString();
			manager_cell.Text = row["Mgr Cell"].ToString();
			asst_manager.Text = row["Assistant"].ToString();
			asst_manager_home.Text = row["Asst Phone"].ToString();
			asst_manager_cell.Text = row["Asst Cell"].ToString();
			local_agency_1.Text = row["Local Agency1"].ToString();
			local_agency_1_num.Text = row["Local Agency1 Num"].ToString();
			local_agency_2.Text = row["Local Agency2"].ToString();
			local_agency_2_num.Text = row["Local Agency2 Num"].ToString();
			local_agency_3.Text = row["Local NYSP"].ToString();
			local_agency_3_num.Text = row["Local NYSP Num"].ToString();
			county_agency.Text = row["COUNTY"].ToString() + " COUNTY";
			county_agency_num.Text = row["SHERIFF"].ToString();
			fire_num.Text = row["FIRE / EMS / AMBULANCE"].ToString();
			encon_num.Text = row["NYSP / EN-CON"].ToString();
			poison_num.Text = row["POISON CONTROL"].ToString();
			hazmat_num.Text = "1-800-457-7362";
			hospital.Text = row["Field1"].ToString();
			hospital_num.Text = row["Field2"].ToString();
			tow_1.Text = row["Tow Truck Name"].ToString();
			tow_1_num.Text = row["Tow Truck"].ToString();
			tow_2.Text = row["Tow Truck 2 Name"].ToString();
			tow_2_num.Text = row["Tow Truck 2"].ToString();
			tow_3.Text = row["Tow Truck 3 Name"].ToString();
			tow_3_num.Text = row["Tow Truck 3"].ToString();
			
			if(zoneId == 5 || zoneId == 1)
			{
				string vetStr = row["Veterinarian Name/Number"].ToString();
				if(vetStr != null && !vetStr.Equals(""))
				{
					string vetNum = vetStr.Substring(vetStr.IndexOf('('));
					string vetName = vetStr.Replace(vetNum, "");
					
					vet_name.Text = vetName.Trim();
					vet_num.Text = vetNum;
				}
			}else{
				vet_name.Text = row["Veterinarian Name"].ToString();
				vet_num.Text = row["Vet Num"].ToString();
			}
			
			animal_control.Text = row["Animal Control Name"].ToString();
			animal_control_num.Text = row["Animal Control"].ToString();
			locksmith_1.Text = row["Locksmith Name"].ToString();
			locksmith_1_num.Text = row["Locksmith"].ToString();
			locksmith_2.Text = row["Locksmith 2 Name"].ToString();
			locksmith_2_num.Text = row["Locksmith 2"].ToString();
			locksmith_3.Text = row["Locksmith 3 Name"].ToString();
			locksmith_3_num.Text = row["Locksmith 3"].ToString();
			payphones.Text = row["Payphone Location /Number"].ToString();
			misc_nums.Text = row["MEMO"].ToString();
			court.Text = row["Court"].ToString();
			court_num.Text = row["Court Phone"].ToString();
			court_address.Text = row["Court Address"].ToString();
			court_time.Text = row["Court Hours"].ToString();
			justice_1.Text = row["Jusitice1"].ToString();
			justice_1_home.Text = row["Justice1H"].ToString();
			justice_1_cell.Text = row["Justice1C"].ToString();
			justice_2.Text = row["Justice2"].ToString();
			justice_2_home.Text = row["Justice2H"].ToString();
			justice_2_cell.Text = row["Justice2C"].ToString();
			alarm_co.Text = row["Alarm Company"].ToString();
			alarm_co_num.Text = row["Alarm Phone"].ToString();
			call_1st.Text = row["1st Contact"].ToString();
			call_2nd.Text = row["2nd Contact"].ToString();
			building_1.Text = row["Building 1"].ToString();
			code_1.Text = row["Alarm Codes"].ToString();
			building_2.Text = row["Building 2"].ToString();
			code_2.Text = row["Codes 2"].ToString();
		}
		
		//handles the navigation button click
		private void PictureBox1Click(object sender, EventArgs e)
		{
			//cast the sender to a picture box
			PictureBox p = (PictureBox) sender;
			
			//switch based on tag
			switch (p.Tag.ToString()) {
				case "first": //move to first record
					//navigate to the first record
					initFields(0);
					break;
				case "last": //move to last record
					//navigate to the last record
					initFields(maxRec);
					break;
				case "prev": //move to previous record
					if(curRec > 0) //make sure not at first record
					{
						//navigate to previous record
						initFields(curRec-1);
					}
					break;
				case "next": //move to next record
					if(curRec < maxRec) //make sure not at last record
					{
						//navigate to the next record
						initFields(curRec+1);
					}
					break;
				default:
					break;
			}
		}
		
		//handles the mouse enter event
		private void PictureBox1MouseEnter(object sender, EventArgs e)
		{
			//PictureBox p = (PictureBox) sender; //cast the sender to a picturebox
			//imgSwitch(p, "enter"); //call the image switching function
		}
		
		//handles the mouse leave event
		private void PictureBox1MouseLeave(object sender, EventArgs e)
		{
			//PictureBox p = (PictureBox) sender; //cast the sender to a picturebox
			//imgSwitch(p, "leave"); //call the image switching function
		}
		
		//handles the mouse up event
		private void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			//PictureBox p = (PictureBox) sender; //cast the sender to a picturebox
			//imgSwitch(p, "up"); //call the image switching function
		}
		
		//handles the mouse down event
		private void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			//PictureBox p = (PictureBox) sender; //cast the sender to a picturebox
			//imgSwitch(p, "down"); //call the image switching function
		}
		
		//handles the image switching for the nav buttons
		private void imgSwitch(PictureBox p, string action)
		{
			//FIXME This doesn't work because the tags do not set the image to anything. This can be fixed by calling the current images set tot he picture box, but then this completely defeats the purpose of this.
			//For now I am going to leave this as  a dead feature.
			//resource manager
			System.ComponentModel.ComponentResourceManager r = new System.ComponentModel.ComponentResourceManager(typeof(ERG));
			
			//string to hold name of file to get
			string fileName = p.Tag.ToString();
			
			if(action.Equals("down")) //if the mouse action is down
			{
				fileName += "_dk"; //select the darker image
			}
			else if(action.Equals("enter") || action.Equals("up")) //if the mouse action is enter or up
			{
				fileName += "_bl"; //select the blue image
			}
			
			//change the image of the picturebox
			//p.Image = (System.Drawing.Image) r.GetObject("pictureBox1.Image"); 
		}
		
		void ERGLoad(object sender, EventArgs e)
		{
			//FIXME This is probably not the best solution. I didn't see why I couldn't initialize these colors so I just set them on load.
			panel1.BackColor = return_bg();
			panel2.BackColor = return_bg();
			panel3.BackColor = return_bg();
		}
	}
}
