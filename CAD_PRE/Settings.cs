/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/27/2015
 * Time: 9:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Settings : baseform
	{
		private User Cuser;
		private string bg_color;
		private string fg_color;
		private string pn_color;
		private string custom_colors;
		public Settings(User cu)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.defaultLocation = new Point(0,0);
			this.defaultSize = new Size(300, 300);
			basecontrols();
			InitializeComponent();
			Cuser = cu;
		}
		void SettingsLoad(object sender, EventArgs e)
		{
			bg_color = Cuser.getBG_Color();
			fg_color = Cuser.getText_Color();
			pn_color = Cuser.getPanel_Color();
			custom_colors = Cuser.getCustom_Colors();
			Test_panel_1.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
			Test_panel_2.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
			Test_panel_3.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
		}
		void Save_btnClick(object sender, EventArgs e)
		{
			Cuser.set_settings(bg_color, fg_color, pn_color, custom_colors);
			string sql = "UPDATE Settings SET Background= '" + bg_color + "', Text_Color= '" + fg_color + "', Panel_Color= '" + pn_color + "', Custom_Colors= '" + custom_colors + "' WHERE DispId = '" + Cuser.getDispatchId().ToString() + "'";
			Tools.runSql(sql,"cad");
			baseform.colorset(bg_color, fg_color, pn_color);
			foreach(Form f in Application.OpenForms)
			{
				if(f is NYSPP_CAD.baseform)
				{
					baseform b = (baseform) f;
					b.basecontrols();
					b.LoadSettings(b);
				}
			}
			TimedMessageBox.Show("Settings Saved","Saved", 300);
			this.Close();
		}
		void Color_DialogClick(object sender, EventArgs e)
		{
			Color_Selector("background", bg_color);
		}
		
		void Color_Dialog_TextClick(object sender, EventArgs e)
		{
			Color_Selector("text", fg_color);
		}
		void Color_Dialog_PanelClick(object sender, EventArgs e)
		{
			Color_Selector("panel", pn_color);
		}
		void Color_Selector(string color_area, string start_color)
		{
		 	System.Windows.Forms.ColorDialog cd = new ColorDialog();
		 	cd.ShowHelp = true;
			cd.SolidColorOnly = true;
		 	string[] grab_colors = custom_colors.Split('|');
			cd.CustomColors = Array.ConvertAll(grab_colors, int.Parse);
			cd.Color = System.Drawing.ColorTranslator.FromHtml(start_color);
			//cd.Color = Cuser.getBG_Color();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				custom_colors = string.Join("|", cd.CustomColors);
				switch (color_area) 
				{
			 		case "background":
						bg_color = cd.Color.ToArgb().ToString();
			 			this.BackColor = System.Drawing.ColorTranslator.FromHtml(bg_color);
			 			break;
			 		case "text":
			 			fg_color = cd.Color.ToArgb().ToString();
			 		this.ForeColor = System.Drawing.ColorTranslator.FromHtml(fg_color);
			 			break;
			 		case "panel":
			 			pn_color = cd.Color.ToArgb().ToString();
			 			Test_panel_1.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
			 			Test_panel_2.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
			 			Test_panel_3.BackColor = System.Drawing.ColorTranslator.FromHtml(pn_color);
			 			break;
				}
			
		 	}
		}
	}
}
