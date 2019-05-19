/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/31/2015
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Officer.
	/// </summary>
	public class Officer
	{
		 //An object for the officers so the region ID can be stored with the officer's name instad of it being looked up every time an officer is selected
		
			private string name;
			private int region_id;
			private int shield;
			public Officer(string n, int rid, int sh)
			{
				name = n;
				region_id = rid;
				shield = sh;
			}
			public override string ToString() // This overrides the tostring method and allows you to display only the name instead off useless object information
   			{
   		     return name;
   			}
			public int returnid()
			{
				return region_id;
			}
			public int returnshield()
			{
				return shield;
			}
	}
}
