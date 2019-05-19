/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/20/2015
 * Time: 8:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Event.
	/// </summary>
	public class Event
	{
		#region Properties
		private string eventDate;		//actual date of the event
		private string assignedDate;	//date the event was assigned
		private string occursStartDate;	//date when the event occurred
		private string callTime;		//time when the officer calls in the event
		private string arrivedTime;		//time when officer arrived on scene
		private string occursStartTime;	//time when the event occurred
		private string assignedTime;	//time when the event was assigned
		private int category;			//parks int code for the category
		private int district;			//parks int code for the district
		private int zone;				//parks int code for the zone
		private int county;				//parks int code for the county
		private int station;			//parks int code for the station
		private int park;				//parks int code for the park
		private int town;				//parks int code for the town
		private string address; 		//address of the event
		private string narrative; 		//narrative of the event
		private int status = 1418; 		//hardcode status to always be pending classification
		private string business;		//business if applicable
		private string localNo;			//local number field of event
		#endregion
		
		#region Constructors
		public Event(List<string> evt_lst)
		{
			
			eventDate = evt_lst[0];
			assignedDate = evt_lst[1];
			occursStartTime = evt_lst[2];
			callTime = evt_lst[3]; //There has to be a less stupid way to remove the : from the string
			arrivedTime = evt_lst[4];
			occursStartTime = evt_lst[5]; //FIXME you added this twice. I am going to account for this in the Short_Event_Parser. I don't want to change it yet, because it may break PARKS loader
			assignedTime = evt_lst[6];
			category = Int32.Parse(evt_lst[7]);
			district = Int32.Parse(evt_lst[8]);
			zone = Int32.Parse(evt_lst[9]);
			county = Int32.Parse(evt_lst[10]);
			station = Int32.Parse(evt_lst[11]);
			park = Int32.Parse(evt_lst[12]);
			town= Int32.Parse(evt_lst[13]);
			address = evt_lst[14];
			narrative = evt_lst[15];
			business = evt_lst[16];
			localNo = evt_lst[17];
			occursStartDate = evt_lst[18];
		}
		public Event(string evt_date, string ass_date, string start_date, string c_time, string arr_time, string start_time, string ass_time, int cat, int dis, int zn, int cnty, int st, int prk, int twn, string addr, string nar, string bus, string evt_num, string evt_oc_date)
		{
			eventDate = evt_date;
			assignedDate = ass_date;
			occursStartTime = start_date; //Same problem here. should it be date??
			callTime = c_time;
			arrivedTime = arr_time;
			occursStartTime = start_time;
			assignedTime = ass_time;
			category = cat;
			district = dis;
			zone = zn;
			county = cnty;
			station = st;
			park = prk;
			town= twn;
			address = addr;
			narrative = nar;
			business = bus;
			localNo = evt_num;
			occursStartDate = evt_oc_date;
		}
		#endregion
		
		#region Getters & Setters
		public string EventDate {
			get { return eventDate; }
			set { eventDate = value; }
		}

		public string AssignedDate {
			get { return assignedDate; }
			set { assignedDate = value; }
		}

		public string OccursStartDate {
			get { return occursStartDate; }
			set { occursStartDate = value; }
		}

		public string CallTime {
			get { return callTime; }
			set { callTime = value; }
		}

		public string ArrivedTime {
			get { return arrivedTime; }
			set { arrivedTime = value; }
		}

		public string OccursStartTime {
			get { return occursStartTime; }
			set { occursStartTime = value; }
		}

		public string AssignedTime {
			get { return assignedTime; }
			set { assignedTime = value; }
		}

		public int Category {
			get { return category; }
			set { category = value; }
		}

		public int District {
			get { return district; }
			set { district = value; }
		}

		public int Zone {
			get { return zone; }
			set { zone = value; }
		}

		public int County {
			get { return county; }
			set { county = value; }
		}

		public int Station {
			get { return station; }
			set { station = value; }
		}

		public int Park {
			get { return park; }
			set { park = value; }
		}

		public int Town {
			get { return town; }
			set { town = value; }
		}

		public string Address {
			get { return address; }
			set { address = value; }
		}

		public string Narrative {
			get { return narrative; }
			set { narrative = value; }
		}

		public int Status {
			get { return status; }
			set { status = value; }
		}

		public string Business {
			get { return business; }
			set { business = value; }
		}

		public string LocalNo {
			get { return localNo; }
			set { localNo = value; }
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Event EventDate={0}, AssignedDate={1}, OccursStartDate={2}, CallTime={3}, ArrivedTime={4}, OccursStartTime={5}, AssignedTime={6}, Category={7}, District={8}, Zone={9}, County={10}, Station={11}, Park={12}, Town={13}, Address={14}, Narrative={15}, Status={16}, Business={17}, LocalNo={18}]", eventDate, assignedDate, occursStartDate, callTime, arrivedTime, occursStartTime, assignedTime, category, district,
zone, county, station, park, town, address, narrative, status, business, localNo);
		}
		
		public string FillParksToString()
		{
			//I removed the Leading and trailing [ and ] because they were being sent to the event and showing up in front of the date
			return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}", eventDate,
			                     assignedDate, occursStartDate, callTime, arrivedTime, occursStartTime, assignedTime, category, district, 
			                     zone, county, station, park, town, address, narrative, status, business, localNo);
		}

	}
}
