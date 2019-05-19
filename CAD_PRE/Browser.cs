/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 8:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using mshtml;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Browser.
	/// </summary>
	public partial class Browser : baseform
	{
		#region Properties
		private int eventId;
		private string page;
		private string domain;
		private Assignment assign;
		private User u = null;
		private RunDataObject dataObject = null;
		private string pgname;
		private bool dataRun = false;
		private int iterations = 0;
		private string subPage;
		private Person personObj;
		private Vehicle vehicleObj;
		private Event eventObj;
		private string narrative;
		#endregion
		//creating a constructor for passing in vehicle and person objects to be put in PARKS
		public Browser(string sub, int id, Assignment a, Vehicle veh, Person per, Event evt, string nar)
		{
			InitializeComponent();
			subPage = sub;
			if (per != null)
				personObj = per;
			if (veh != null)
				vehicleObj = veh;
			if (nar != null)
				narrative = nar;;
			if (evt != null)
				eventObj = evt;
			assign = a;
			eventId = id;
			if (per != null || veh !=null || nar != null)
			{
				pgname = "exEvent"; // This is to fire an already existing conditional in browsercomplete that you should change
				domain = "http://PoliceBlotter/";
				page = "Events.aspx?slctEventId="+ eventId +"&OfficerId=" + assign.OfficerId;
			}
			else if(evt != null)
			{
				pgname = "newEvent";
				domain = "http://PoliceBlotter/";
				page = "Events.aspx?slctEventId=&OfficerId="+ assign.OfficerId +"&AssignmentId="+ assign.AssignmentId +"&SecondaryId="+ assign.SecondaryId;
				this.Name = "NewParksEvent";
			}
		}
			
		
		public Browser(string pageName, int id, Assignment a, string domainInit, RunDataObject passInDataObject)
		{
			pgname = pageName;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted); // for testing PARKS event fill in
			CAD cad = null;
			dataObject = passInDataObject;

			//change the domain based on the domainInit parameter
			if(domainInit.Equals("p"))
			{
				domain = "http://PoliceBlotter/";
			}
			else if(domainInit.Equals("e"))
			{
				domain = "https://www.ejusticeny.ny.gov/";
			}
			else if (domainInit.Equals("g"))
			{
				domain = "http://maps.googleapis.com/maps/api/staticmap?center=" + pageName + "&zoom=14&size=1000x1000&sensor=false&visual_refresh=true&maptype=hybrid";
				page = "";
				this.Name = "Map";
			}
			else
			{
				domain = "";
			}
			
			//set the event id to the passed in parameter
			eventId = id;
			//set the assignment to the passed in assignment
			assign = a;
			
			string assignmentId, secondaryId;
			
			if(assign != null)
			{
				//get the assignment id from the assignment
				assignmentId = assign.AssignmentId.ToString();
				//get the secondary assignment id from the assignment
				secondaryId = assign.SecondaryId.ToString();
			}
			else
			{
				assignmentId = "0";
				secondaryId = "0";
			}
			
			//check the assignment id
			if(assignmentId.Equals("0"))
			{
				//set the assignment id to an empty string
				assignmentId = "";
			}
			
			//check the secondary assignment
			if(secondaryId.Equals("0"))
			{
				//set the secondary id to an empty string
				secondaryId = "";
			}
			
			//switch on the page name passed in as a parameter
			switch (pageName) {
				case "assign":
					//if the page name is assign, set the assignment page location
					page = "Assignment.aspx?slctAssignmentId="+ assignmentId +"&SecondaryId="+ secondaryId +"&OfficerId="+ assign.OfficerId +"&zoneId="+ assign.ZoneId +"&Page=Assignment";
					this.Name = "ParksAssignment";
					break;
				case "newEvent":
					//if the page name is newEvent, set the event page location for a new event
					subPage = "new";
					page = "Events.aspx?slctEventId=&OfficerId="+ assign.OfficerId +"&AssignmentId="+ assign.AssignmentId +"&SecondaryId="+ assign.SecondaryId;
					this.Name = "NewParksEvent";
					break;
				case "exEvent":
					//if the page name is exEvent, set the event page location for an existing event
					page = "Events.aspx?slctEventId="+ eventId +"&OfficerId=" + assign.OfficerId;
					this.Name = "ExistingParksEvent";
					break;
				case "SearchPersons":
					//if the page name is searchPersons, set the page location to search parks for that person
					PersonDataObject pdo = (PersonDataObject) dataObject;
					page = pageName + ".aspx?sLastName=" + pdo.LastName + "&sFirstName=" + pdo.FirstName;
					this.Name = "ParksSearchPersons";
					break;
				case "SearchLicensePlates":
					//if the page name is searchLicensePlates, set the page location to search parks for that plate
					PlateDataObject pldo = (PlateDataObject) dataObject;
					page = pageName + ".aspx?sPlateNo=" + pldo.Plate;
					this.Name = "ParksSearchPlates";
					break;
				case "inbox":
					//if the page name is inbox, set the ejustice inbox link
					//look up the current user from the cad screen
					cad = (CAD) Application.OpenForms["CAD"];
					u = cad.getUser();
					
					//check if the user is logged into ejustice
					if(u.getLoggedIn() == 1) //user is logged in
					{
						page = u.getEJLink().Replace(domain, "") + "L2dJQSEvUUt3QS80SmlFL1o2XzMwRzIwOFJHSVRGNEIwMlBCOUFTN04xRzQw/";
						this.Name = "EJusticeInbox";
					}
					else //user is not logged in
					{
						page = "";
					}
					break;
				case "dispatch":
					//if the page name is dispatch, set the ejustice dispatch link
					cad = (CAD) Application.OpenForms["CAD"];
					u = cad.getUser();
					
					//check if user is logged into ejustice
					if(u.getLoggedIn() == 1) //user is logged in
					{
						page = u.getEJLink().Replace(domain, "") + "L2dJQSEvUUt3QS80SmlFL1o2XzMwRzIwOFJHSTUwQjQwMjUxMTQ0VjMwMEk2/";
						this.Name = "EJusticeSearch";
					}
					else //user is not logged in
					{
						page = "";
					}
					break;
				case "cch":
					//if the page name is cch, set the ejustice cch link
					cad = (CAD) Application.OpenForms["CAD"];
					u = cad.getUser();
					
					//check if user is logged into ejustice
					if(u.getLoggedIn() == 1) //user is logged in
					{
						page = u.getEJLink().Replace(domain, "") + "L2dJQSEvUUt3QS80SmlFL1o2XzVOTzY5QjFBMDA2ODgwSU4zQko5RzIxMDgz/";
						this.Name = "EJusticeCCHSearch";
					}
					else //user is not logged in
					{
						page = "";
					}
					break;
				default:
					page = "";
					break;
			}
			
			this.Text = this.Name;
		}
		
		//browser load event
		private void BrowserLoad(object sender, EventArgs e)
		{
			//allow navigation
			webBrowser1.AllowNavigation = true;
			//navigate to the webpage
			webBrowser1.Navigate(domain + page);
		}
		
		//handles the document complete event
		private void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			//ejustice login screen	
			if(e.Url.ToString().StartsWith("https://www.ejusticeny.ny.gov/ijlogin/ijlogin.fcc"))
			{
				//set the htmlDoc to the html of the document loaded in the web browser object
				mshtml.HTMLDocument htmlDoc = (mshtml.HTMLDocument) webBrowser1.Document.DomDocument;
				//get a group of html elements
				IHTMLElementCollection pageSource = htmlDoc.getElementsByName("USER");
				//get the username field
				IHTMLInputElement userFld = (IHTMLInputElement) pageSource.item("USER", 0);
				//set the value of the username field
				userFld.value = u.getEJUsername();
				
				//exit the function
				return;
			}
			//ejustice logged in screen
			if(e.Url.ToString().Equals("https://www.ejusticeny.ny.gov/wps/myportal") && u.getLoggedIn() == 0)
			{
				//set the user to be logged in
				u.setLoggedIn(1);

				//set the htmlDoc to the html of the document loaded in the web browser object
				mshtml.HTMLDocument htmlDoc = (mshtml.HTMLDocument) webBrowser1.Document.DomDocument;
				//capture the inbox link
				HTMLAnchorElement aInbox = (HTMLAnchorElement) htmlDoc.getElementById("inboxlink");
				//create a string to hold the link to get the personalized portion of the ejustice link
				string inboxLink = aInbox.getAttributeNode("href").nodeValue.ToString();
				
				//declare variables to hold the indexes and length
				int ind1, ind2, len;
				
				//get index of "/wps/myportal/"
				ind1 = inboxLink.IndexOf("/wps/myportal/");
				//get index of "/dl5/d5"
				ind2 = inboxLink.IndexOf("/dl5/d5");
				//get length of substring
				len = ind2 - ind1 + 8;
				
				//get the substring of the link containing the personalized portion of ejustice link
				string persLink = inboxLink.Substring(ind1, len);
				//store the new ejustice link
				u.setEJLink(domain + persLink);
				
				//exit the method, will be adding more url cases and don't want to run them
				return;
			}
			//Parks
			if(e.Url.ToString().StartsWith("http://policeblotter/"))
			{
				if(pgname == "newEvent")
				{
					//not sure wtf, but if we let this run 5 times we get functionality back for javascript
					//and it saves the entries that we've made
					if(iterations <= 5)
						FillParks();
					
				}
				if (pgname == "exEvent")
				{
					//If you have called for the existing event to be loaded with the person tab open
					if (subPage == "person")
					{
						webBrowser1.Navigate("javascript:__doPostBack('ctl00$Container$tab2','')");
						System.Threading.Thread waiting_thread;
						waiting_thread = new System.Threading.Thread(new System.Threading.ThreadStart(FillPerson));
						waiting_thread.Start();
					}
					//If you have called for the existing event to be loaded with the vehicle tab open
					if (subPage == "vehicle")
					{
						webBrowser1.Navigate("javascript:__doPostBack('ctl00$Container$tab6','')"); 
						//creating a new thread for a method to load the next navigation so that I can pause it and wait for this page to navigate
						System.Threading.Thread waiting_thread;
						waiting_thread = new System.Threading.Thread(new System.Threading.ThreadStart(FillVeh));
						waiting_thread.Start();
					}
					if (subPage == "add_calls")
					{
						Elementchanger("ctl00$Container$uctrlEvent$txtNarrative","value", narrative); //Add the narrative
						//GOLIVE uncomment for production Elementchanger("ctl00$Container$uctrlEvent$btnUpdate", "click", "invoke member"); // click update to save the changes
						MessageBox.Show("Don't forget to uncomment the line that saves the page!");
					}
				}
				return;
			}
			//ejustice dispatch page
			if(u.getLoggedIn() == 1 && pgname.Equals("dispatch"))
			{
				AddPopulate();
				
				if(dataObject != null && !dataRun)
				{
					switch (dataObject.GetType().ToString())
					{
						case "NYSPP_CAD.PlateDataObject":
							RunPlateData();
							break;
						case "NYSPP_CAD.PersonDataObject":
							RunPersonData();
							break;
						case "NYSPP_CAD.ClientIDDataObject":
							RunCidData();
							break;
						case "NYSPP_CAD.VinDataObject":
							RunVinData();
							break;
					}
				}
			}
			
			//add populate when on dispatch page, handles when going to dispatch from the inbox
			if(u.getLoggedIn() == 1 && webBrowser1.Url.ToString().Contains("L2dJQSEvUUt3QS80SmlFL1o2XzMwRzIwOFJHSTUwQjQwMjUxMTQ0VjMwMEk2"))
			{
				AddPopulate();
			}
			
			//ejustice cch search page
			if(u.getLoggedIn() == 1 && pgname.Equals("cch"))
				RunCCHData();
		}
		//This method is necessary so that you can call it as a separate thread from within document loaded. as a separate thread you can paus this thread while the document finishes loading
		//If you don't wait for the html to load there is to javascript to call and you can't navigate properly
		private void FillPerson()
		{
			System.Threading.Thread.Sleep(2000);
			//webBrowser1.Invoke(new Action(() => {
			FillParks(); 
			//}));
		}
		private void FillVeh()
		{
			System.Threading.Thread.Sleep(3000);
			webBrowser1.Navigate("javascript:__doPostBack('ctl00$Container$uctrlProperty$lnkProperty2','')");
			//starting another thread to be started for the fill parks method. it needs to wait for this to finish loading before it can do its thing
			System.Threading.Thread waiting_thread;
			waiting_thread = new System.Threading.Thread(new System.Threading.ThreadStart(FillParks));
			waiting_thread.Start();
		}
		private string Elementchanger(string element, string value, string new_value)
		{
			if (new_value == "invoke member" && value == "onchange")
			{
				HtmlElement he = webBrowser1.Document.All.GetElementsByName(element)[0];
				he.InvokeMember(value);	
			}
			if (new_value == "invoke member" && value == "click")
			{
				HtmlElement he = webBrowser1.Document.All.GetElementsByName(element)[0];
				he.InvokeMember(value);	
			}
			if (new_value == "")
			{
				HtmlElement he = webBrowser1.Document.All.GetElementsByName(element)[0];
					return he.GetAttribute(value);	
			}
			else
			{
				HtmlElement he = webBrowser1.Document.All.GetElementsByName(element)[0];
					he.SetAttribute(value, new_value);
			}
			return "";
		}
		
		void BrowserFormClosed(object sender, FormClosedEventArgs e)
		{
			//Creating the action to grab the event id from parks so tthat I can save it to the events table. You may be able to move this from the event close action if you can capture the save event button click within the form.
			//If page is equal to the value set to the assign page. THis is so it only saves when there is a new event created
			if (pgname == "newEvent") //Need new variable to make sure the assign page has been launched
			{
				if (Elementchanger("ctl00$Container$txtEventNo","value", "") != "") //make sure the event number fld isn't blank
				{
					string evt_num = (Elementchanger("ctl00$Container$hdnEventId","value", ""));
					string sql = "UPDATE events SET pid= " + evt_num + " WHERE ID = " + eventId;
					Tools.runSql(sql, "cad");
				}
			}
		}
		
		#region Getters & Setters
		public Vehicle VehicleObj {
			get { return vehicleObj; }
			set { vehicleObj = value; }
		}
		
		public Person PersonObj {
			get { return personObj; }
			set { personObj = value; }
		}
		
		public string SubPage
		{
			get { return subPage; }
			set { subPage = value; }
		}
		
		public Event EventObj
		{
			get { return eventObj; }
			set { eventObj = value; }
		}
		#endregion
		
		#region EJustice Search Section
		#region Ejustice Element Class
		private class ejElem
		{
			private string elemName;
			private string val;
			private string elemType;
			
			public ejElem(string eName, string strVal, string type)
			{
				elemName = eName;
				val = strVal;
				elemType = type;
			}
			
			#region Getters and Setters
			public string ElemName
			{
				get { return elemName; }
				set { elemName = value; }
			}
			
			public string Val
			{
				get { return val; }
				set { val = value; }
			}
			
			public string ElemType
			{
				get { return elemType; }
				set { elemType = value; }
			}
			#endregion
		}
		#endregion
		
		private void looper(ejElem[] elements)
		{
			HtmlElementCollection hec = webBrowser1.Document.All;
			HtmlElement elem;
			string pre = "viewns_Z7_5NO69B1A0GKL30IDSVA5OL30C4_";
			
			if(pgname == "cch") //change form field pre name if cch
				pre = "viewns_Z7_5NO69B1A006880IN3BJ9G21042_";
			
			for(int x = 0; x < elements.Length; x++)
			{
				elem = (HtmlElement) hec.GetElementsByName(pre + elements[x].ElemName)[0];
				int elemType = Int16.Parse(elements[x].ElemType);
				
				if(elemType == 1)
				{
					elem.InvokeMember("click");
				}
				else if(elemType == 2)
				{
					elem.SetAttribute("checked", "true");
				}
				else
				{
					elem.SetAttribute("value", elements[x].Val);
				}
			}
			
			dataRun = true; //make sure data only gets run once
		}
		
		//run plate data method
		private void RunPlateData()
		{
			PlateDataObject pdo = (PlateDataObject) dataObject;
			ejElem[] elems = new ejElem[]
			{
				new ejElem(":navForm:regPlateButton", "", "1"),
				new ejElem(":searchForm:registrationByLicenseDestinations", pdo.State, "0"),
				new ejElem(":searchForm:dispatchFor", pdo.Officer, "0"),
				new ejElem(":searchForm:dispatchLocation", pdo.Location, "0"),
				new ejElem(":searchForm:licensePlate0", pdo.Plate, "0"),
				new ejElem(":searchForm:licensePlateType0", pdo.Type.ToString(), "0"),
				new ejElem(":searchForm:licensePlateExpires0", pdo.Expires.ToString(), "0"),
				new ejElem(":searchForm:registrationByLicenseIncludeHistory", "", "2"),
				new ejElem(":searchForm:_id67", "", "1")
			};

			looper(elems);
		}
		
		//run person data method
		private void RunPersonData()
		{
			PersonDataObject psdo = (PersonDataObject) dataObject;
			ejElem[] elems = new ejElem[]
			{
				new ejElem(":navForm:licByNameButton", "", "1"),
				new ejElem(":searchForm:dispatchFor", psdo.Officer, "0"),
				new ejElem(":searchForm:dispatchLocation", psdo.Location, "0"),
				new ejElem(":searchForm:driversLicenseByNameDestinations", psdo.States ,"0"),
				new ejElem(":searchForm:lastName0", psdo.LastName, "0"),
				new ejElem(":searchForm:firstName0", psdo.FirstName, "0"),
				new ejElem(":searchForm:middleName0", psdo.MiddleName, "0"),
				new ejElem(":searchForm:birthDate0", psdo.BirthDate, "0"),
				new ejElem(":searchForm:sex0", psdo.Gender, "0"),
				new ejElem(":searchForm:driversLicenseByNameIncludeHistory", "", "2"),
				new ejElem(":searchForm:_id183","","1")
			};
			
			looper(elems);
		}
		
		//run cch data method
		private void RunCCHData()
		{
			PersonDataObject psdo = (PersonDataObject) dataObject;
			ejElem[] elems = new ejElem[]
			{
				new ejElem(":inquiryForm1:fName", "", "0"),
				new ejElem(":inquiryForm1:lastname", psdo.LastName, "0"),
				new ejElem(":inquiryForm1:firstname", psdo.FirstName, "0"),
				new ejElem(":inquiryForm1:middlename", psdo.MiddleName, "0"),
				new ejElem(":inquiryForm1:sex", psdo.GenderFirstInit(), "0"),
				new ejElem(":inquiryForm1:dateOfBirth", psdo.BirthDate, "0"),
				new ejElem(":inquiryForm1:state", psdo.States, "0")
			};
		
			looper(elems);
		}
		
		//run cid data method
		private void RunCidData()
		{
			ClientIDDataObject cdo = (ClientIDDataObject) dataObject;
			ejElem[] elems = new ejElem[]
			{
				new ejElem(":navForm:licByLicenseNumberButton", "", "1"),
				new ejElem(":searchForm:dispatchFor", cdo.Officer, "0"),
				new ejElem(":searchForm:dispatchLocation", cdo.Location, "0"),
				new ejElem(":searchForm:licenseNumber0", cdo.ClientID, "0"),
				new ejElem(":searchForm:driversLicenseByLicenseNumberDestinations", cdo.States , "0"),
				new ejElem(":searchForm:driversLicenseByLicenseNumberIncludeHistory", "", "2"),
				new ejElem(":searchForm:_id140","","1")
			};
			
			looper(elems);
		}
		
		//run vin data method
		private void RunVinData()
		{
			VinDataObject vdo = (VinDataObject) dataObject;
			ejElem[] elems = new ejElem[]
			{
				new ejElem(":navForm:regVinButton", "", "1"),
				new ejElem(":searchForm:dispatchFor", vdo.Officer, "0"),
				new ejElem(":searchForm:dispatchLocation", vdo.Location, "0"),
				new ejElem(":searchForm:registrationByVehicleDestinations", vdo.VehState ,"0"),
				new ejElem(":searchForm:vehicleId0", vdo.VehIDNum, "0"),
				new ejElem(":searchForm:vehicleYear0", vdo.VehYear.ToString(), "0"),
				new ejElem(":searchForm:vehicleMake0", vdo.VehMake, "0"),
				new ejElem(":searchForm:registrationByVehicleIncludeHistory", "", "2"),
				new ejElem(":searchForm:_id108","","1")
			};
			
			looper(elems);
		}
		#endregion
		
		#region EJustice Populate Section
		//add populate button method
		private void AddPopulate()
		{
			HtmlElement form = webBrowser1.Document.GetElementById("viewns_Z7_5NO69B1A0GKL30IDSVA5OL30C4_:navForm");
			
			if(!form.InnerHtml.Contains("populateButton"))
			{
				form.InnerHtml = form.InnerHtml + "<input type='button' id='populateButton' name='populateButton' class='dispatchActionButton' value='populate' >";
				
				HtmlElement pop = webBrowser1.Document.GetElementById("populateButton");
				pop.Click += new HtmlElementEventHandler(this.PopulateEvent);
			}
			
		}
		
		//populate method
		private void PopulateEvent(object sender, HtmlElementEventArgs e)
		{
			HTMLDocument HTMLdoc = (HTMLDocument) webBrowser1.Document.DomDocument;
			IHTMLElement elem;
			
			elem = HTMLdoc.getElementById("_id30_recordTable_0"); //holds person data from a dob search
			if(elem != null)
			{
				storeNYPerson(elem);
				return;
			}
			
			elem = HTMLdoc.getElementById("_id31_recordTable_0"); //holds person data from a cid search
			if(elem != null)
			{
				storeNYPerson(elem);
				return;
			}
			
			elem = HTMLdoc.getElementById("dmvRegistrationResponse_recordTable_0"); //holds reg data from reg or vin search
			if(elem != null)
			{
				storeNYPlate(elem);
				return;
			}
			
			foreach (HtmlElement he in webBrowser1.Document.All) {
				if(he.GetAttribute("class").Equals("summaryDetail")) //holds out of state data info
				{
					TimedMessageBox.Show("Import currently only available for NYS data :(", "OUT OF STATE", 1000);
					return;
				}
			}
			
			TimedMessageBox.Show("Unable to capture data", "DATA FAILURE", 1000);
		}
		
		//ejustice capture NY plate data
		private void storeNYPlate(IHTMLElement elem)
		{
			string altRow = "3/1"; //string used for alternate table row in certain cases
			string chkStr; //string used to keep track of which row and cell the loop is currently in
			string tmp; //temp string used during parsing html for veh info
			int x, y; //counters used while looping through rows and cells
			Vehicle veh = new Vehicle(); //create a vehicle object to store all of the captured information
			
			try {
				HTMLTableClass table = null;
				
				foreach (IHTMLElement e in (IHTMLElementCollection) elem.children) {
					if(e.GetType().ToString().Equals("mshtml.HTMLTableClass"))
					{
						table = (HTMLTableClass) e;
					}
				}
								
				if(elem.innerHTML.Contains("BOT - Boat")) //if the reg data being run is for a boat
				{
					altRow = "4/1"; //change the alt row to row 4
				}
				
				x = 0;

				//loop through each row in the table
				foreach (IHTMLTableRow tRow in table.rows) {
					y = 0;
					//loop through each cell in each row
					foreach (IHTMLTableCell tCell in tRow.cells) {
						chkStr = x + "/" + y; //set the check string to current row and current cell
						
						IHTMLElement e = (IHTMLElement) tCell; //cast the current cell to an html element for parsing
						tmp = e.innerHTML;
						
						if(chkStr.Equals("0/1"))
						{
							veh.PlateStatus = e.innerHTML.Substring(0, e.innerHTML.IndexOf("&nbsp;"));
							veh.PlateExp = e.innerHTML.Substring(e.innerHTML.IndexOf("Expiration:") + 25, 10);
							if(veh.PlateExp.Equals("<SPAN clas"))
								veh.PlateExp = e.innerHTML.Substring(e.innerHTML.IndexOf("Expiration:") + 47, 10);
						}
						else if(chkStr.Equals("1/1"))
						{
							veh.PlateNum = e.innerHTML.Substring(0, e.innerHTML.IndexOf("&nbsp;"));
							tmp = tmp.Substring(tmp.IndexOf("(") + 1, tmp.IndexOf(")") - tmp.IndexOf("(")-1);
							veh.PlateType = Int16.Parse(tmp);
						}
						else if(chkStr.Equals(altRow))
						{
							List<int> l = new List<int>{
								36, 84, 86, 87, 90
							};
							
							if(l.Contains(veh.PlateType))
							{
								veh.VehYear = Int32.Parse(tmp.Substring(0, tmp.IndexOf(";")));
								tmp = tmp.Replace(veh.VehYear.ToString(), "");
								tmp = tmp.Substring(1);
								tmp = tmp.Trim();
								
								if(veh.PlateType == 90)
								{
									veh.VehStyle = tmp;
								}
								else
								{
									veh.VehStyle = tmp.Substring(0, tmp.IndexOf(";"));
									tmp = tmp.Replace(veh.VehStyle, "");
									veh.VehColor = tmp.Trim();
								}
							}
							else
							{
								veh.VehYear = Int32.Parse(tmp.Substring(0, tmp.IndexOf(";"))); 
								tmp = tmp.Replace(veh.VehYear.ToString(), "");
								tmp = tmp.Substring(1);
								tmp = tmp.Trim();
								veh.VehMake = tmp.Substring(0, tmp.IndexOf(";"));
								tmp = tmp.Replace(veh.VehMake, "");
								tmp = tmp.Substring(1);
								tmp = tmp.Trim();
								veh.VehModel = tmp.Substring(0, tmp.IndexOf(";"));
								tmp = tmp.Replace(veh.VehModel, "");
								tmp = tmp.Substring(1);
								tmp = tmp.Trim();
								veh.VehStyle = tmp.Substring(0, tmp.IndexOf(";"));
								tmp = tmp.Replace(veh.VehStyle, "");
								tmp = tmp.Substring(1);
								veh.VehColor = tmp.Trim();
							}
						}
						else if(chkStr.Equals("5/1"))
						{
							veh.VehIdNum = e.innerHTML;
						}
						
						y++;
					}
					
					x++;
				}
				//still need to insert into table and assoc an event
				PopulateEvents pe = new PopulateEvents(veh, null);
				pe.Show();
			} catch (Exception e) {
				MessageBox.Show(e.Message + "\n" + e.StackTrace);
			}
		}
		
		//ejustice capture NY person data
		private void storeNYPerson(IHTMLElement elem)
		{
			string altRow = "2/1"; //string used for alternate table row in certain cases
			string altRow2 = "3/1";
			string altRow3 = "4/1";
			string chkStr; //string used to keep track of which row and cell the loop is currently in
			string tmp; //temp string used during parsing html for veh info
			string fullName; //temp string used to parse the full name of the person
			int x, y; //counters used while looping through rows and cells
			Person per = new Person(); //create a person object to store all of the captured information
			
			try {
				HTMLTableClass table = null;
				
				foreach (IHTMLElement e in (IHTMLElementCollection) elem.children) {
					if(e.GetType().ToString().Equals("mshtml.HTMLTableClass"))
					{
						table = (HTMLTableClass) e;
					}
				}
								
				if(elem.innerHTML.Contains("Permit")) //if the reg data being run is for a boat
				{
					altRow = "3/1"; //change the alt row to row 3
					altRow2 = "4/1";
					altRow3 = "5/1";
				}
				
				x = 0;
				
				//loop through each row in the table
				foreach (IHTMLTableRow tRow in table.rows) {
					y = 0;
					//loop through each cell in each row
					foreach (IHTMLTableCell tCell in tRow.cells) {
						chkStr = x + "/" + y; //set the check string to current row and current cell
						
						IHTMLElement e = (IHTMLElement) tCell; //cast the current cell to an html element for parsing
						tmp = e.innerHTML;
						
						if(chkStr.Equals("1/1"))
						{
							tmp = tmp.Substring(0, tmp.LastIndexOf("*"));
							per.LicenseClass = tmp.Replace("*", "");
							tmp = e.innerHTML;
							per.LicenseExp = tmp.Substring(tmp.IndexOf("Expiration:") + 25, 10);
						}
						else if(chkStr.Equals(altRow))
						{	
							fullName = tmp.Substring(0, tmp.IndexOf("&nbsp;"));
							tmp = tmp.Replace(fullName, "");
							per.LastName = fullName.Substring(0, fullName.IndexOf(","));
							fullName = fullName.Replace(per.LastName, "");
							fullName = fullName.Substring(1);
							fullName = fullName.Trim();
							if(fullName.Contains(" "))
							{
								per.FirstName = fullName.Substring(0, fullName.IndexOf(" "));
								fullName = fullName.Replace(per.FirstName, "");
								per.MiddleName = fullName.Trim();
							}
							else
							{
								per.FirstName = fullName.Trim();
							}
							per.LicenseNumber = tmp.Substring(tmp.LastIndexOf(";")+1);
						}
						else if(chkStr.Equals(altRow2))
						{
							per.DateOfBirth = tmp.Substring(0, tmp.IndexOf("</SPAN>"));
							per.DateOfBirth = per.DateOfBirth.Substring(per.DateOfBirth.Length - 10);
							tmp = tmp.Substring(tmp.IndexOf("Sex Code"));
							per.Gender = tmp.Substring(1, tmp.IndexOf("</SPAN>")-1);
							per.Gender = per.Gender.Substring(per.Gender.IndexOf(">")+1);
							tmp = tmp.Substring(tmp.IndexOf("Eye Color:"));
							per.EyeColor = tmp.Substring(tmp.IndexOf("&nbsp;"));
							per.EyeColor = per.EyeColor.Replace("&nbsp;", "");
						}
						else if(chkStr.Equals(altRow3))
						{
							per.StreetAddress = tmp.Substring(tmp.IndexOf(">")+1, tmp.IndexOf("<BR>") - tmp.IndexOf(">") - 1);
							tmp = tmp.Substring(tmp.IndexOf("<BR>"));
							per.Town = tmp.Substring(4, tmp.IndexOf(",")-4);
							per.ZipCode = Int32.Parse(tmp.Substring(tmp.IndexOf("</DIV>") - 5, 5));
							tmp = tmp.Substring(tmp.IndexOf("</LABEL>"));
							tmp = tmp.Substring(tmp.IndexOf("&nbsp;"));
							tmp = tmp.Substring(6, tmp.IndexOf("</SPAN>") - 6);
							per.County = tmp;
							per.State = "NY";
						}
						
						y++;
					}
					
					x++;
				}
				//MessageBox.Show(per.ToString());
				//still need to insert into table and assoc an event
				PopulateEvents pe = new PopulateEvents(null, per);
				pe.Show();
			}
			catch (Exception e) {
				MessageBox.Show(e.Message + "\n" + e.StackTrace);
			}
		}
		#endregion
		
		#region PARKS Javascript and Fill Section
		private string GenerateJavascript(string prefix, string control, string[] elemNames, string[] elemVals, string[] elemJsCall)
		{
			string jsFunc = "";
			
			//javascript function
			jsFunc = @"var theForm = document.forms['aspnetForm'];
						var waitPeriod = 0;
						
						if(!theForm)
							theForm = document.aspnetForm;
							
						function __doPostback(eventTarget, eventArgument) {
    						if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
        						theForm.__EVENTTARGET.value = eventTarget;
        						theForm.__EVENTARGUMENT.value = eventArgument;
        						theForm.submit();
    						}
    						waitPeriod = 0;
						}
						
						function newSetTimeout()
						{
							var elemName;
							var elemId;
							var sc;
							var z;
							var prefix = '" + prefix + @"';
							var control = '" + control + @"';
							var elems = [" + ArrayToString(elemNames, false) + @"];
							var vals = [" + ArrayToString(elemVals, false) + @"];
							var js = [" + ArrayToString(elemJsCall, true) + @"];
							for(var x = 0; x < elems.length; x++)
							{
								elemName = prefix + control + elems[x];
								document.getElementById(elemName).value = vals[x];
								if(js[x] == 1 && x < elems.length-1)
								{
									elemId = elemName.replace(/_/g, '$');
									waitPeriod = 1;
									__doPostback(elemId, '');
									//sc = '__doPostBack(\'' + elemId + '\', \'\')';
									//setTimeout(sc, 0);
									while(waitPeriod == 1)
									{
										z++;
									}
								}
							}
							return (document.getElementById(elemName).value == null || document.getElementById(elemName).value == '');
						}";
							
			return jsFunc;
		}

		private string ArrayToString(string[] array, bool intArray)
		{
			string retString = ""; //string to return
			string quote = "'"; //quote string, depends on intArray
			
			if(intArray) //if int array
				quote = ""; //change single quote to empty string
			
			for(int x = 0; x < array.Length; x++) //loop through each string in the array
			{
				retString += quote + array[x] + quote + ", "; //add the array element surrounded with single quotes and trailed by a comma and space
			}
					
			retString = retString.Substring(0, retString.Length - 2); //trim the last 2 characters off the string
			return retString; //return the string
		}
		
		private void FillParks()
		{
			//TODO
			//***We still need a way to use cElem.selectedIndex = 1 for the town value after a park is selected.***
			string control = ""; //the parks control name, ie event, person, property
			string prefix = "ctl00_Container_uctrl"; //the prefix for all controls in parks
			string elemNames = ""; //string with all element names, will be split into an array
			string elemVals = ""; //string with all element values, will be split into an array
			string callJSs = ""; //string with all js values, will be split into an array
			string[] elemName; //array that holds all element names
			string[] elemVal; //array that holds all the values for the elements
			string[] callJS; //array that holds an integer value for whether the javascript should be called for that elemtent, 1 yes, 0 no
			HtmlDocument HTMLDoc; //html document
			HtmlElementCollection elemColl; //collection of elements from the html document
			
			if(pgname.Equals("newEvent")) //if filling a new event
			{
				control = "Event_"; //the control the elements are contained in
				//element names in one string, to be split to an array
				elemNames = @"txtEventDate|txtAssignedDate|txtOccursStartDate|txtCallTime|txtArrivedTime|txtOccursStartTime|txtAssignedTime|lstCategory|lstDistrict|lstZone|lstCounty|lstStation|lstPark|lstTown|txtAddress|txtNarrative|lstStatus|txtBusiness|txtLocalNo";
				//javascript values, 1 to call, 0 not to call
				callJSs = "0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,1,0";
				elemVals = eventObj.FillParksToString();
			}
			
			if(pgname.Equals("exEvent")) //if filling an existing event
			{
				if(subPage.Equals("person"))
				{
					System.Threading.Thread.Sleep(1500); // give the navigation call a chance to load
					control = "People_"; //the control the elements are contained in
					//element names in one string to be split to an array
					elemNames = "txtLastName|txtFirstName|txtMiddleInt|txtAddress|txtCity|lstState|txtZip|lstGender|lstEye|txtDateOfBirth";
					//uctrlCommentsModule$txtComments| this line was cut becaus it was causing errors
					//to call js on elem or not
					callJSs = "0,0,0,0,0,0,0,0,0,1";
					//get the values based on the person data object
					elemVals = personObj.FillParksToString();
					
					//need to click person tab
				}
				else if(subPage.Equals("vehicle"))
				{
					System.Threading.Thread.Sleep(3000); // give the navigation call a chance to load
					control = "Property_"; //the control the elements are contained in
					//element names in one string to be split to an array
					elemNames = "lstVehicleStatus|txtVehiclePlate|chkFullPlate|lstVehicleState|txtExpireYear|txtVehicleYear|txtPlateType|txtVIN|txtVehicleModel|txtVehicleStyle|txtVehicleColor|lstVehicleMake";
					//to call js on elem or not
					callJSs = "0,0,0,0,0,0,0,0,0,0,0,0,0";
					//hardcoding values
					elemVals = vehicleObj.FillParksToString();
					
					//need to click vehicle tab
				}
				else if(subPage.Equals("calls"))
				{
					control = "Event_"; //the control the elements are contained in
					//have to add calls to narrative
					
					//click event update button
					HtmlElement but = webBrowser1.Document.All.GetElementsByName("ctl00$Container$uctrlEvent$btnUpdate")[0];
					HTMLButtonElementClass button = (HTMLButtonElementClass) but.DomElement;
					button.click();
				}
			}
			
			elemName = elemNames.Split('|'); //split the element names string by the pipe character
			elemVal = elemVals.Split(','); //split the element values string by the comma
			callJS = callJSs.Split(','); //split the js by the comma
// If the subpage is vehicle or person, then this is running in a separate thread and I need to call the webbrowser from the normal thread
webBrowser1.Invoke(new Action(() => {				// If you don't then you can not set anything within the browser
//I'm leaving this out so we don't forget to fix this. This only needs to happen when this method is running in a different thread. It will be a mess cleaning it up right now so I will get everything working first.
			HTMLDoc = webBrowser1.Document; //capture the html document
			elemColl = HTMLDoc.All;
			try {
				//loop through each element in the collection
				for(int x = 0; x < elemColl.Count; x++) {					
					if(elemColl[x].Id != "" && elemColl[x].Id != null) //if the elements id value is not empty or null
					{
						if(elemColl[x].Id.StartsWith(prefix + control)) //if the elements id value starts with prefix and control
						{
							if(elemColl[x].DomElement.GetType().ToString().Equals("mshtml.HTMLSelectElementClass"))
							{
								IHTMLSelectElement se = (IHTMLSelectElement) elemColl[x].DomElement;
								if (se.onchange.ToString() != "" && se.onchange.ToString() != null)
								{
									HTMLSelectElementClass sec = (HTMLSelectElementClass) elemColl[x].DomElement;
									string outerHtml = sec.outerHTML;
									string onchange = outerHtml.Substring(outerHtml.IndexOf("onchange"), outerHtml.IndexOf("class") - outerHtml.IndexOf("onchange"));
									outerHtml = outerHtml.Replace(onchange, "");
									sec.outerHTML = outerHtml;
								}
							}
							
							if(elemColl[x].DomElement.GetType().ToString().Equals("mshtml.HTMLInputElementClass"))
							{
								if(elemColl[x].GetAttribute("className").Equals("button-stamp"))
								{
									HTMLInputElementClass bec = (HTMLInputElementClass) elemColl[x].DomElement;
									string butOuter = bec.outerHTML;
									string onclick = butOuter.Substring(butOuter.IndexOf("onclick"), butOuter.IndexOf("name") - butOuter.IndexOf("onclick"));
									butOuter = butOuter.Replace(onclick, "");
									bec.outerHTML = butOuter;
									
									if(bec.value.Equals("T"))
									{
										//bec.HTMLButtonElementEvents_Event_onclick += new HTMLButtonElementEvents_onclickEventHandler(this.setTime);
										elemColl[x].Click += new HtmlElementEventHandler(this.setTime);
									}
									
									if(bec.value.Equals("D"))
									{
										//bec.HTMLButtonElementEvents_Event_onclick += new HTMLButtonElementEvents_onclickEventHandler(this.setDate);
										elemColl[x].Click += new HtmlElementEventHandler(this.setDate);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message + "\n" + e.StackTrace);
			}
			
			HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0]; //get the head element
			HtmlElement newScript = webBrowser1.Document.CreateElement("script"); //create a new Html Element
			IHTMLScriptElement sc = (IHTMLScriptElement) newScript.DomElement; //cast the new object to a script element
			sc.text = GenerateJavascript(prefix, control, elemName, elemVal, callJS); //generate the text of the script element
			head.AppendChild(newScript); //add the script element to the head element
			if(!subPage.Equals("calls")) //don't call the script if only filling in the calls to the narrative section
				webBrowser1.Document.InvokeScript("newSetTimeout"); //call the newSetTimeout function
			iterations++;
//the ending part of the above cast. You only need this to end the above if it is running in another thread
})); //I'm leaving these out so we don't forget to fix this
			                              
		}
		
		//set time to html buttons
		private void setTime(object sender, HtmlElementEventArgs e)
		{
			HtmlElement but = (HtmlElement) sender;
			string elemName = but.Name.Replace("btn", "txt");
			HtmlElement txtFld = (HtmlElement) webBrowser1.Document.All.GetElementsByName(elemName)[0];
			IHTMLInputElement txt = (IHTMLInputElement) txtFld.DomElement;
			txt.value = DateTime.Now.ToString("HHmm");
		}
		
		//set date to html buttons
		private void setDate(object sender, HtmlElementEventArgs e)
		{
			HtmlElement but = (HtmlElement) sender;
			string elemName = but.Name.Replace("btn", "txt");
			HtmlElement txtFld = (HtmlElement) webBrowser1.Document.All.GetElementsByName(elemName)[0];
			IHTMLInputElement txt = (IHTMLInputElement) txtFld.DomElement;
			txt.value = DateTime.Today.ToString("MM/dd/yyyy");
		}
		#endregion
	}
}
