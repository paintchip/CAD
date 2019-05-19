/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/27/2015
 * Time: 9:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing; //why is this not inherited ?
namespace NYSPP_CAD
{
	partial class Settings : baseform
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// // It will also erase your manual edits. This is for when you inevitably erase the combobox colors:
		/// foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
		///	{   
     	///		if (prop.PropertyType.FullName == "System.Drawing.Color")
        ///     	BG_Color_combo.Items.Add(prop.Name);
		///	}
		/// </summary>
		private void InitializeComponent()
		{
			this.Settings_Form_lbl = new System.Windows.Forms.Label();
			this.Backgorund_Color_lbl = new System.Windows.Forms.Label();
			this.Text_Color_Lbl = new System.Windows.Forms.Label();
			this.Save_btn = new System.Windows.Forms.Button();
			this.Cancel_btn = new System.Windows.Forms.Button();
			this.Panel_lbl = new System.Windows.Forms.Label();
			this.Test_panel_1 = new System.Windows.Forms.Panel();
			this.Color_Dialog_Back = new System.Windows.Forms.Button();
			this.Color_Dialog_Text = new System.Windows.Forms.Button();
			this.Color_Dialog_Panel = new System.Windows.Forms.Button();
			this.Test_panel_2 = new System.Windows.Forms.Panel();
			this.Test_panel_3 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Settings_Form_lbl
			// 
			this.Settings_Form_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Settings_Form_lbl.Location = new System.Drawing.Point(49, 9);
			this.Settings_Form_lbl.Name = "Settings_Form_lbl";
			this.Settings_Form_lbl.Size = new System.Drawing.Size(184, 35);
			this.Settings_Form_lbl.TabIndex = 0;
			this.Settings_Form_lbl.Text = "Settings";
			this.Settings_Form_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Backgorund_Color_lbl
			// 
			this.Backgorund_Color_lbl.Location = new System.Drawing.Point(12, 59);
			this.Backgorund_Color_lbl.Name = "Backgorund_Color_lbl";
			this.Backgorund_Color_lbl.Size = new System.Drawing.Size(66, 23);
			this.Backgorund_Color_lbl.TabIndex = 3;
			this.Backgorund_Color_lbl.Text = "Background";
			// 
			// Text_Color_Lbl
			// 
			this.Text_Color_Lbl.Location = new System.Drawing.Point(12, 82);
			this.Text_Color_Lbl.Name = "Text_Color_Lbl";
			this.Text_Color_Lbl.Size = new System.Drawing.Size(66, 23);
			this.Text_Color_Lbl.TabIndex = 4;
			this.Text_Color_Lbl.Text = "Text";
			// 
			// Save_btn
			// 
			this.Save_btn.ForeColor = System.Drawing.Color.Black;
			this.Save_btn.Location = new System.Drawing.Point(103, 221);
			this.Save_btn.Name = "Save_btn";
			this.Save_btn.Size = new System.Drawing.Size(75, 23);
			this.Save_btn.TabIndex = 5;
			this.Save_btn.Text = "Save";
			this.Save_btn.UseVisualStyleBackColor = true;
			this.Save_btn.Click += new System.EventHandler(this.Save_btnClick);
			// 
			// Cancel_btn
			// 
			this.Cancel_btn.ForeColor = System.Drawing.Color.Black;
			this.Cancel_btn.Location = new System.Drawing.Point(197, 221);
			this.Cancel_btn.Name = "Cancel_btn";
			this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
			this.Cancel_btn.TabIndex = 6;
			this.Cancel_btn.Text = "Cancel";
			this.Cancel_btn.UseVisualStyleBackColor = true;
			this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btnClick);
			// 
			// Panel_lbl
			// 
			this.Panel_lbl.Location = new System.Drawing.Point(12, 105);
			this.Panel_lbl.Name = "Panel_lbl";
			this.Panel_lbl.Size = new System.Drawing.Size(66, 23);
			this.Panel_lbl.TabIndex = 7;
			this.Panel_lbl.Text = "Panels";
			// 
			// Test_panel_1
			// 
			this.Test_panel_1.Location = new System.Drawing.Point(1, 123);
			this.Test_panel_1.Name = "Test_panel_1";
			this.Test_panel_1.Size = new System.Drawing.Size(145, 5);
			this.Test_panel_1.TabIndex = 9;
			// 
			// Color_Dialog_Back
			// 
			this.Color_Dialog_Back.ForeColor = System.Drawing.Color.Black;
			this.Color_Dialog_Back.Location = new System.Drawing.Point(75, 55);
			this.Color_Dialog_Back.Name = "Color_Dialog_Back";
			this.Color_Dialog_Back.Size = new System.Drawing.Size(61, 20);
			this.Color_Dialog_Back.TabIndex = 12;
			this.Color_Dialog_Back.Text = "Select";
			this.Color_Dialog_Back.UseVisualStyleBackColor = true;
			this.Color_Dialog_Back.Click += new System.EventHandler(this.Color_DialogClick);
			// 
			// Color_Dialog_Text
			// 
			this.Color_Dialog_Text.ForeColor = System.Drawing.Color.Black;
			this.Color_Dialog_Text.Location = new System.Drawing.Point(75, 78);
			this.Color_Dialog_Text.Name = "Color_Dialog_Text";
			this.Color_Dialog_Text.Size = new System.Drawing.Size(61, 20);
			this.Color_Dialog_Text.TabIndex = 13;
			this.Color_Dialog_Text.Text = "Select";
			this.Color_Dialog_Text.UseVisualStyleBackColor = true;
			this.Color_Dialog_Text.Click += new System.EventHandler(this.Color_Dialog_TextClick);
			// 
			// Color_Dialog_Panel
			// 
			this.Color_Dialog_Panel.ForeColor = System.Drawing.Color.Black;
			this.Color_Dialog_Panel.Location = new System.Drawing.Point(75, 101);
			this.Color_Dialog_Panel.Name = "Color_Dialog_Panel";
			this.Color_Dialog_Panel.Size = new System.Drawing.Size(61, 20);
			this.Color_Dialog_Panel.TabIndex = 14;
			this.Color_Dialog_Panel.Text = "Select";
			this.Color_Dialog_Panel.UseVisualStyleBackColor = true;
			this.Color_Dialog_Panel.Click += new System.EventHandler(this.Color_Dialog_PanelClick);
			// 
			// Test_panel_2
			// 
			this.Test_panel_2.Location = new System.Drawing.Point(1, 47);
			this.Test_panel_2.Name = "Test_panel_2";
			this.Test_panel_2.Size = new System.Drawing.Size(145, 5);
			this.Test_panel_2.TabIndex = 15;
			// 
			// Test_panel_3
			// 
			this.Test_panel_3.Location = new System.Drawing.Point(141, 50);
			this.Test_panel_3.Name = "Test_panel_3";
			this.Test_panel_3.Size = new System.Drawing.Size(5, 75);
			this.Test_panel_3.TabIndex = 16;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.Test_panel_3);
			this.Controls.Add(this.Test_panel_2);
			this.Controls.Add(this.Color_Dialog_Panel);
			this.Controls.Add(this.Color_Dialog_Text);
			this.Controls.Add(this.Color_Dialog_Back);
			this.Controls.Add(this.Test_panel_1);
			this.Controls.Add(this.Panel_lbl);
			this.Controls.Add(this.Cancel_btn);
			this.Controls.Add(this.Save_btn);
			this.Controls.Add(this.Text_Color_Lbl);
			this.Controls.Add(this.Backgorund_Color_lbl);
			this.Controls.Add(this.Settings_Form_lbl);
			this.Name = "Settings";
			this.Text = "User Settings";
			this.Load += new System.EventHandler(this.SettingsLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel Test_panel_3;
		private System.Windows.Forms.Panel Test_panel_2;
		private System.Windows.Forms.Button Color_Dialog_Panel;
		private System.Windows.Forms.Button Color_Dialog_Text;
		private System.Windows.Forms.Button Color_Dialog_Back;
		private System.Windows.Forms.Panel Test_panel_1;
		private System.Windows.Forms.Label Panel_lbl;
		private System.Windows.Forms.Button Cancel_btn;
		private System.Windows.Forms.Button Save_btn;
		private System.Windows.Forms.Label Text_Color_Lbl;
		private System.Windows.Forms.Label Backgorund_Color_lbl;
		private System.Windows.Forms.Label Settings_Form_lbl;
		
		void Cancel_btnClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
