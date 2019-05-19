/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 8:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of ComponentForm.
	/// </summary>
	public partial class ComponentForm : baseform
	{
		public ComponentForm(int x, int y, int h, int w)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//this.Size = new Size(w, h);			
			//this.Location = new Point(x, y);
		}
		
		private void ComponentFormFormClosed(object sender, FormClosedEventArgs e)
		{
			switch (this.Tag.ToString()) {
				case "CAD_EVENTS":
					foreach (Control ctl in Application.OpenForms["CAD"].Controls) {
						if(ctl is CAD_Events)
						{
							ctl.Visible = true;
						}
					}
					break;
				case "CAD_CALLS":
					foreach (Control ctl in Application.OpenForms["CAD"].Controls) {
						if(ctl is CAD_Calls)
						{
							ctl.Visible = true;
						}
					}
					break;
				case "CAD_OFFICERS":
					foreach (Control ctl in Application.OpenForms["CAD"].Controls) {
						if(ctl is CAD_Officers)
						{
							ctl.Visible = true;
						}
					}
					break;
				default:
					
					break;
			}
		}
	}
}
