/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/2/2015
 * Time: 4:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of ClientIDDataObject.
	/// </summary>
	public class ClientIDDataObject : RunDataObject
	{
		#region Properties
		private string clientID;
		private string states;
		#endregion
		
		#region Constructors
		public ClientIDDataObject()
		{
			 states = "NY";
			 clientID = "";
		}
		#endregion
		
		#region Getters and Setters
		public string ClientID {
			get { return clientID; }
			set { clientID = value; }
		}
		
		public string States {
			get { return states; }
			set { states = value; }
		}
		#endregion
	}
}
