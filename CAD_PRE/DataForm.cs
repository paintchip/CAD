/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/30/2015
 * Time: 6:49 AM
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
	/// Description of DataForm.
	/// </summary>
	public partial class DataForm : UserControl
	{
		#region Properties
		private int eventId;
		private int offId;
		private string Officers;
		private string DataLocation;
		#endregion
		
		#region Constructors
		public DataForm()
		{
			//basecontrols();
			InitializeComponent();
			
			eventId = 0;
			
			InitFields();
		}
		#endregion
		
		private void InitFields()
		{			
			System.Threading.Thread LoadingThread; //I am going to attempt to make the form(This and the New event form which loads this) open more quickly for the user. I would like the form to load instantly and have the lists fill in before the user actuall gets to click anything
			LoadingThread = new System.Threading.Thread(new System.Threading.ThreadStart(BackLoad));
			LoadingThread.Start();

//			//fill gender combobox
//			Gender.DisplayMember = "Text";
//			Gender.ValueMember = "Value";
//			Gender.Items.Add(new { Value = "0", Text = "--- SELECT ---" });
//			Gender.Items.Add(new { Value = "1", Text = "M" });
//			Gender.Items.Add(new { Value = "2", Text = "F" });
//			Gender.SelectedIndex = 0;
//			
//			//set the dataset for the states combobox
//			DataSet ds = Tools.GetDataSet("SELECT State FROM states", "cad");
//			Tools.clearDataset();
//			
//			//set the datasource for the states combo boxes
//			Person_State.DataSource = ds.Tables[0];
//			Plate_State.DataSource = ds.Tables[0];
//			Person_State.DisplayMember = "State";
//			Plate_State.DisplayMember = "State";
//			Person_State.ValueMember = "State";
//			Plate_State.ValueMember = "State";
//			//set ny as the default selection for both
//			Person_State.SelectedValue = "NY";
//			Plate_State.SelectedValue = "NY";
//			
//			//set the dataset for the type combobox
//			ds = Tools.GetDataSet("SELECT * FROM plateTypes", "cad");
//			Tools.clearDataset();
//			//set the data source of the type combobox
//			Plate_Type.DataSource = ds.Tables[0];
//			Plate_Type.DisplayMember = "Type";
//			Plate_Type.ValueMember = "TypeNo";
//			//set pc as the default selection
//			Plate_Type.SelectedValue = 16;
//			
//			//set the dataset for the make combobox
//			ds = Tools.GetDataSet("SELECT * FROM makes", "cad");
//			Tools.clearDataset();
//			DataTable dt = ds.Tables[0];
			
			//create a row that prompts the user to select a make
//			DataRow dr = dt.NewRow();
//			dr["FullMakes"] = "--- SELECT MAKE ---";
//			dr["makes"] = 0;
//			dt.Rows.InsertAt(dr, 0);
			
//			//set the data source of the make combobox
//			Make.DataSource = dt;
//			Make.DisplayMember = "FullMakes";
//			Make.ValueMember = "makes";
//			Make.SelectedValue = 0;
			
			//set the default value for the expiration
			Exp.Text = DateTime.Today.AddYears(1).ToString("yyyy");
		}
		
		private bool CheckFields(string dataType)
		{
			string chk = "";
			int chkNum;
			
			//check officer
			if(Officers == null || Officers.Equals(""))
			{
				MessageBox.Show("Please Enter: Officer");
				return false;
			}
			
			//check location
			if(DataLocation == null || DataLocation.Equals(""))
			{
				MessageBox.Show("Please Enter: DataLocation");
				return false;
			}
				
			//switch on the data type
			switch (dataType) {
				case "DOB": //person data
					chk += TextBoxValidator(Last_Name) + TextBoxValidator(First_Name) + TextBoxValidator(Middle_Init) + ComboValidator(Gender);
					chk += TextBoxValidator(DOB) + ComboValidator(Person_State);
					break;
				case "CCH": //cch data
					chk += TextBoxValidator(Last_Name) + TextBoxValidator(First_Name) + TextBoxValidator(Middle_Init) + ComboValidator(Gender);
					chk += TextBoxValidator(DOB) + ComboValidator(Person_State);
					break;
				case "CID": //cid data
					chk += TextBoxValidator(CID) + ComboValidator(Person_State);
					break;
				case "REG": //reg data
					chk += TextBoxValidator(Plate);
					break;
				case "VIN": //vin data
					chk += TextBoxValidator(VIN) + TextBoxValidator(Year) + ComboValidator(Make) + ComboValidator(Plate_State);
					break;
				default:
					break;
			}
			
			chkNum = int.Parse(chk); //parse the check string to a number
			
			return (chkNum == 0);
		}
		
		private int TextBoxValidator(TextBox tb)
		{
			if(tb.Text.Equals("") || tb.Text == null)
			{
				MessageBox.Show("Please enter: " + tb.Name);
				return 1;
			}
			
			return 0;
		}
		
		private int ComboValidator(ComboBox cb)
		{
			if(cb.Text.Equals("") || cb.Text == null || cb.Text.StartsWith("--- S"))
			{
				MessageBox.Show("Please select: " + cb.Name);
				return 1;
			}
			
			return 0;
		}
		
		private void RunDataClick(object sender, EventArgs e)
		{
			//cast the sender to a button
			Button b = (Button) sender;
			RunDataObject rdo = null;
			
			//if validation check true
			if(CheckFields(b.Tag.ToString()))
			{
				string narr = "";
				
				switch (b.Tag.ToString())
				{
					case "DOB":
						//create person data object and fill with data
						PersonDataObject pdo = new PersonDataObject();
						pdo.LastName = Last_Name.Text;
						pdo.FirstName = First_Name.Text;
						pdo.MiddleName = Middle_Init.Text;
						pdo.BirthDate = DOB.Text;
						pdo.Gender = Gender.Text;
						
						if(StateSearch.Text.Contains("+"))
							pdo.States = Person_State.Text;
						else
							pdo.States = Mult_State.Text;
						
						rdo = pdo;
						narr = @"(" + pdo.States + ") " + pdo.LastName + ", " + pdo.FirstName
							+ " " + pdo.MiddleName + ", " + pdo.BirthDate;
						Browser searchDOB = new Browser("SearchPersons", 0, null, "p", rdo);
						searchDOB.Show();
						break;
					case "CCH":
						//create person data object and fill with data for cch
						PersonDataObject psdo = new PersonDataObject();
						psdo.LastName = Last_Name.Text;
						psdo.FirstName = First_Name.Text;
						psdo.MiddleName = Middle_Init.Text;
						psdo.BirthDate = DOB.Text;
						psdo.Gender = Gender.Text;
						psdo.States = Person_State.Text;
						rdo = psdo;
						break;
					case "CID":
						//create client id data object and fill with data
						ClientIDDataObject CIDdo = new ClientIDDataObject();
						CIDdo.ClientID = CID.Text;
						CIDdo.States = Person_State.Text;
						rdo = CIDdo;
						narr = "(" + CIDdo.States + ") " + CIDdo.ClientID;
						break;
					case "REG":
						//create plate data object and fill with data
						PlateDataObject pldo = new PlateDataObject();
						pldo.Plate = Plate.Text;
						pldo.State = Plate_State.Text;
						pldo.Expires = int.Parse(Exp.Text);
						rdo = pldo;
						narr = "(" + pldo.State + ") " + pldo.Plate;
						Browser searchPlate = new Browser("SearchLicensePlates", 0, null, "p", rdo);
						searchPlate.Show();
						break;
					case "VIN":
						//create vin data object and fill with data
						VinDataObject vdo = new VinDataObject();
						vdo.VehIDNum = VIN.Text;
						vdo.VehYear = int.Parse(Year.Text);
						vdo.VehMake = Make.Text;
						vdo.VehState = Plate_State.Text;
						narr = "(" + vdo.VehState + ") " + vdo.VehIDNum;
						rdo = vdo;
						break;
					default:
						break;
				}
				
				rdo.Officer = Officers;
				rdo.Location = DataLocation;
				
				DataSet ds = Tools.GetDataSet("SELECT pId FROM parksIDs WHERE offShield=" + offId, "cad");
				DataRow dr = ds.Tables[0].Rows[0];
				rdo.OfficerId = int.Parse(dr[0].ToString());
				
				if (eventId > 0) {
					rdo.EventId = eventId;
				}
				
				if(b.Tag.ToString().Equals("CCH")) //if running a cch
				{
					Browser searchCCH = new Browser("cch", 0, null, "e", rdo); //create a browser object to go to cch page
					searchCCH.Show(); //show the browser object
				}
				else //running regular data
				{
					//enter call in log for data
					narr += " @ " + DataLocation;
					rdo.DataToCall(narr);
					//open browser object to run data
					Browser br = new Browser("dispatch", eventId, null, "e", rdo);
					br.Show();
				}
			}
		}
		
		#region Getters and Setters
		public void setEvent(int evtId)
		{
			eventId = evtId;
		}
		
		public string getOfficer()
		{
			return Officers;
		}
		
		public void setOfficer(string off)
		{
			Officers = off;
		}
		
		public void setLoc(string loc)
		{
			DataLocation = loc;
		}
		
		public void setOId(int officerId)
		{
			offId = officerId;
		}
		#endregion
		
		//handles switching the multiple state and single state inputs
		private void StateSwitch()
		{
			//set the visibility of each field to the opposite of what it was
			Mult_State.Visible = !Mult_State.Visible;
			Person_State.Visible = !Person_State.Visible;
		}
		
		//handles the clicking of the state search link
		private void StateSearchClick(object sender, EventArgs e)
		{
			Label lbl = (Label) sender;
			
			if(lbl.Text.Contains("+"))
			{
				MultState ms = new MultState();
				ms.setForm(this);
				ms.Show();
				
				lbl.Text = lbl.Text.Replace("+", "-");
				StateSwitch();
			}
			else if(lbl.Text.Contains("-"))
			{
				
				lbl.Text = lbl.Text.Replace("-", "+");
				StateSwitch();
			}                     
		}
		
		//method to allow multiple value string to be set outside of the form
		public void setMultState(string multValue)
		{
			Mult_State.Text = multValue;
		}
		
		//method to change panel colors from outside the form
		public void changeColors(string colorName)
		{
			panel1.BackColor = System.Drawing.ColorTranslator.FromHtml(colorName);
			panel2.BackColor = System.Drawing.ColorTranslator.FromHtml(colorName);
			panel3.BackColor = System.Drawing.ColorTranslator.FromHtml(colorName);
		}
	
		private void BackLoad()
		{
				//set the dataset for the states combobox
				DataSet ds = Tools.GetDataSet("SELECT State FROM states", "cad");
				Tools.clearDataset();
				
				//set the datasource for the states combo boxes
				try {
					
				this.Invoke((MethodInvoker)(() => Person_State.DataSource = ds.Tables[0]));
				this.Invoke((MethodInvoker)(() => Plate_State.DataSource = ds.Tables[0]));
				this.Invoke((MethodInvoker)(() => Person_State.DisplayMember = "State"));
				this.Invoke((MethodInvoker)(() => Plate_State.DisplayMember = "State"));
				this.Invoke((MethodInvoker)(() => Person_State.ValueMember = "State"));
				this.Invoke((MethodInvoker)(() => Plate_State.ValueMember = "State"));
				//set ny as the default selection for both
				this.Invoke((MethodInvoker)(() => Person_State.SelectedValue = "NY"));
				this.Invoke((MethodInvoker)(() => Plate_State.SelectedValue = "NY"));
				
				//fill gender combobox
				this.Invoke((MethodInvoker)(() => Gender.DisplayMember = "Text"));
				this.Invoke((MethodInvoker)(() => Gender.ValueMember = "Value"));
				this.Invoke((MethodInvoker)(() => Gender.Items.Add(new { Value = "0", Text = "--- SELECT ---" })));
				this.Invoke((MethodInvoker)(() => Gender.Items.Add(new { Value = "1", Text = "M" })));
				this.Invoke((MethodInvoker)(() => Gender.Items.Add(new { Value = "2", Text = "F" })));
				this.Invoke((MethodInvoker)(() => Gender.SelectedIndex = 0));
				
				//set the dataset for the type combobox
				ds = Tools.GetDataSet("SELECT * FROM plateTypes", "cad");
				Tools.clearDataset();
				//set the data source of the type combobox
				this.Invoke((MethodInvoker)(() => Plate_Type.DataSource = ds.Tables[0]));
				this.Invoke((MethodInvoker)(() => Plate_Type.DisplayMember = "Type"));
				this.Invoke((MethodInvoker)(() => Plate_Type.ValueMember = "TypeNo"));
				//set pc as the default selection
				this.Invoke((MethodInvoker)(() => Plate_Type.SelectedValue = 16));
				
				//set the dataset for the make combobox
				ds = Tools.GetDataSet("SELECT * FROM makes", "cad");
				Tools.clearDataset();
				DataTable dt = ds.Tables[0];
				DataRow dr = dt.NewRow();
				dr["FullMakes"] = "--- SELECT MAKE ---";
				dr["makes"] = 0;
				dt.Rows.InsertAt(dr, 0);
				
				//set the data source of the make combobox
				this.Invoke((MethodInvoker)(() => Make.DataSource = dt));
				this.Invoke((MethodInvoker)(() => Make.DisplayMember = "FullMakes"));
				this.Invoke((MethodInvoker)(() => Make.ValueMember = "makes"));
				this.Invoke((MethodInvoker)(() => Make.SelectedValue = 0));
				}
				catch(InvalidOperationException)
				{}
		}
	}
}
