/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/26/2015
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	partial class New_Event_Form : baseform
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
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Event_Form));
			this.Nevent_date_fld = new System.Windows.Forms.TextBox();
			this.Nevent_time_fld = new System.Windows.Forms.TextBox();
			this.Nevent_officer_combo = new System.Windows.Forms.ComboBox();
			this.Nevent_incident_combo = new System.Windows.Forms.ComboBox();
			this.Incident_Type_lbl = new System.Windows.Forms.Label();
			this.Nevent_addr_fld = new System.Windows.Forms.TextBox();
			this.New_Event_Add_lbl = new System.Windows.Forms.Label();
			this.New_Event_xst_lbl = new System.Windows.Forms.Label();
			this.Nevent_xst_fld = new System.Windows.Forms.TextBox();
			this.Nevent_park_combo = new System.Windows.Forms.ComboBox();
			this.New_Event_PM_lbl = new System.Windows.Forms.Label();
			this.New_Event_Nar_lbl = new System.Windows.Forms.Label();
			this.Nevent_nar_fld = new System.Windows.Forms.TextBox();
			this.Nevent_save_btn = new System.Windows.Forms.Button();
			this.New_Event_Date_lbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Nevent_cancel_btn = new System.Windows.Forms.Button();
			this.dataForm1 = new NYSPP_CAD.DataForm();
			this.SuspendLayout();
			// 
			// Nevent_date_fld
			// 
			this.Nevent_date_fld.BackColor = System.Drawing.SystemColors.Window;
			this.Nevent_date_fld.Location = new System.Drawing.Point(56, 12);
			this.Nevent_date_fld.Name = "Nevent_date_fld";
			this.Nevent_date_fld.Size = new System.Drawing.Size(131, 20);
			this.Nevent_date_fld.TabIndex = 14;
			// 
			// Nevent_time_fld
			// 
			this.Nevent_time_fld.BackColor = System.Drawing.SystemColors.Window;
			this.Nevent_time_fld.Location = new System.Drawing.Point(56, 38);
			this.Nevent_time_fld.Name = "Nevent_time_fld";
			this.Nevent_time_fld.Size = new System.Drawing.Size(131, 20);
			this.Nevent_time_fld.TabIndex = 15;
			// 
			// Nevent_officer_combo
			// 
			this.Nevent_officer_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Nevent_officer_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Nevent_officer_combo.FormattingEnabled = true;
			this.Nevent_officer_combo.Location = new System.Drawing.Point(258, 25);
			this.Nevent_officer_combo.Name = "Nevent_officer_combo";
			this.Nevent_officer_combo.Size = new System.Drawing.Size(116, 21);
			this.Nevent_officer_combo.TabIndex = 0;
			this.Nevent_officer_combo.SelectedIndexChanged += new System.EventHandler(this.Nevent_officer_comboDropDownClosed);
			// 
			// Nevent_incident_combo
			// 
			this.Nevent_incident_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Nevent_incident_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Nevent_incident_combo.FormattingEnabled = true;
			this.Nevent_incident_combo.Location = new System.Drawing.Point(12, 94);
			this.Nevent_incident_combo.Name = "Nevent_incident_combo";
			this.Nevent_incident_combo.Size = new System.Drawing.Size(362, 21);
			this.Nevent_incident_combo.TabIndex = 4;
			// 
			// Incident_Type_lbl
			// 
			this.Incident_Type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Incident_Type_lbl.Location = new System.Drawing.Point(12, 68);
			this.Incident_Type_lbl.Name = "Incident_Type_lbl";
			this.Incident_Type_lbl.Size = new System.Drawing.Size(100, 23);
			this.Incident_Type_lbl.TabIndex = 5;
			this.Incident_Type_lbl.Text = "Incident Type:";
			this.Incident_Type_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nevent_addr_fld
			// 
			this.Nevent_addr_fld.Location = new System.Drawing.Point(12, 142);
			this.Nevent_addr_fld.Name = "Nevent_addr_fld";
			this.Nevent_addr_fld.Size = new System.Drawing.Size(362, 20);
			this.Nevent_addr_fld.TabIndex = 6;
			// 
			// New_Event_Add_lbl
			// 
			this.New_Event_Add_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_Add_lbl.Location = new System.Drawing.Point(12, 118);
			this.New_Event_Add_lbl.Name = "New_Event_Add_lbl";
			this.New_Event_Add_lbl.Size = new System.Drawing.Size(100, 23);
			this.New_Event_Add_lbl.TabIndex = 7;
			this.New_Event_Add_lbl.Text = "Address:";
			this.New_Event_Add_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// New_Event_xst_lbl
			// 
			this.New_Event_xst_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_xst_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.New_Event_xst_lbl.Location = new System.Drawing.Point(12, 165);
			this.New_Event_xst_lbl.Name = "New_Event_xst_lbl";
			this.New_Event_xst_lbl.Size = new System.Drawing.Size(100, 23);
			this.New_Event_xst_lbl.TabIndex = 8;
			this.New_Event_xst_lbl.Text = "Cross Street:";
			this.New_Event_xst_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nevent_xst_fld
			// 
			this.Nevent_xst_fld.Location = new System.Drawing.Point(12, 191);
			this.Nevent_xst_fld.Name = "Nevent_xst_fld";
			this.Nevent_xst_fld.Size = new System.Drawing.Size(362, 20);
			this.Nevent_xst_fld.TabIndex = 9;
			// 
			// Nevent_park_combo
			// 
			this.Nevent_park_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Nevent_park_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Nevent_park_combo.FormattingEnabled = true;
			this.Nevent_park_combo.Location = new System.Drawing.Point(12, 240);
			this.Nevent_park_combo.Name = "Nevent_park_combo";
			this.Nevent_park_combo.Size = new System.Drawing.Size(362, 21);
			this.Nevent_park_combo.TabIndex = 10;
			// 
			// New_Event_PM_lbl
			// 
			this.New_Event_PM_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_PM_lbl.Location = new System.Drawing.Point(12, 214);
			this.New_Event_PM_lbl.Name = "New_Event_PM_lbl";
			this.New_Event_PM_lbl.Size = new System.Drawing.Size(143, 23);
			this.New_Event_PM_lbl.TabIndex = 11;
			this.New_Event_PM_lbl.Text = "Park  / Municipality:";
			this.New_Event_PM_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.New_Event_PM_lbl.UseMnemonic = false;
			// 
			// New_Event_Nar_lbl
			// 
			this.New_Event_Nar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_Nar_lbl.Location = new System.Drawing.Point(12, 264);
			this.New_Event_Nar_lbl.Name = "New_Event_Nar_lbl";
			this.New_Event_Nar_lbl.Size = new System.Drawing.Size(84, 21);
			this.New_Event_Nar_lbl.TabIndex = 12;
			this.New_Event_Nar_lbl.Text = "Narrative:";
			this.New_Event_Nar_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Nevent_nar_fld
			// 
			this.Nevent_nar_fld.Location = new System.Drawing.Point(12, 288);
			this.Nevent_nar_fld.Multiline = true;
			this.Nevent_nar_fld.Name = "Nevent_nar_fld";
			this.Nevent_nar_fld.Size = new System.Drawing.Size(362, 168);
			this.Nevent_nar_fld.TabIndex = 13;
			// 
			// Nevent_save_btn
			// 
			this.Nevent_save_btn.ForeColor = System.Drawing.Color.Black;
			this.Nevent_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Nevent_save_btn.Image")));
			this.Nevent_save_btn.Location = new System.Drawing.Point(611, 447);
			this.Nevent_save_btn.Name = "Nevent_save_btn";
			this.Nevent_save_btn.Size = new System.Drawing.Size(101, 22);
			this.Nevent_save_btn.TabIndex = 14;
			this.Nevent_save_btn.UseVisualStyleBackColor = true;
			this.Nevent_save_btn.Click += new System.EventHandler(this.Nevent_save_btnClick);
			// 
			// New_Event_Date_lbl
			// 
			this.New_Event_Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_Date_lbl.Location = new System.Drawing.Point(12, 12);
			this.New_Event_Date_lbl.Name = "New_Event_Date_lbl";
			this.New_Event_Date_lbl.Size = new System.Drawing.Size(38, 23);
			this.New_Event_Date_lbl.TabIndex = 15;
			this.New_Event_Date_lbl.Text = "Date:";
			this.New_Event_Date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Time:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(193, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Officer:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Nevent_cancel_btn
			// 
			this.Nevent_cancel_btn.ForeColor = System.Drawing.Color.Transparent;
			this.Nevent_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("Nevent_cancel_btn.Image")));
			this.Nevent_cancel_btn.Location = new System.Drawing.Point(718, 447);
			this.Nevent_cancel_btn.Name = "Nevent_cancel_btn";
			this.Nevent_cancel_btn.Size = new System.Drawing.Size(101, 22);
			this.Nevent_cancel_btn.TabIndex = 51;
			this.Nevent_cancel_btn.UseVisualStyleBackColor = true;
			this.Nevent_cancel_btn.Click += new System.EventHandler(this.Nevent_cancel_btnClick);
			// 
			// dataForm1
			// 
			this.dataForm1.BackColor = System.Drawing.Color.Transparent;
			this.dataForm1.Location = new System.Drawing.Point(383, 240);
			this.dataForm1.Name = "dataForm1";
			this.dataForm1.Size = new System.Drawing.Size(479, 201);
			this.dataForm1.TabIndex = 54;
			// 
			// New_Event_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 471);
			this.Controls.Add(this.dataForm1);
			this.Controls.Add(this.Nevent_cancel_btn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.New_Event_Date_lbl);
			this.Controls.Add(this.Nevent_save_btn);
			this.Controls.Add(this.Nevent_nar_fld);
			this.Controls.Add(this.New_Event_Nar_lbl);
			this.Controls.Add(this.New_Event_PM_lbl);
			this.Controls.Add(this.Nevent_park_combo);
			this.Controls.Add(this.Nevent_xst_fld);
			this.Controls.Add(this.New_Event_xst_lbl);
			this.Controls.Add(this.New_Event_Add_lbl);
			this.Controls.Add(this.Nevent_addr_fld);
			this.Controls.Add(this.Incident_Type_lbl);
			this.Controls.Add(this.Nevent_incident_combo);
			this.Controls.Add(this.Nevent_officer_combo);
			this.Controls.Add(this.Nevent_time_fld);
			this.Controls.Add(this.Nevent_date_fld);
			this.Name = "New_Event_Form";
			this.Text = "New_Event_Form";
			this.Load += new System.EventHandler(this.New_Event_FormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private NYSPP_CAD.DataForm dataForm1;
		private System.Windows.Forms.Button Nevent_cancel_btn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label New_Event_Date_lbl;
		private System.Windows.Forms.Button Nevent_save_btn;
		private System.Windows.Forms.TextBox Nevent_nar_fld;
		private System.Windows.Forms.Label New_Event_Nar_lbl;
		private System.Windows.Forms.Label New_Event_PM_lbl;
		private System.Windows.Forms.ComboBox Nevent_park_combo;
		private System.Windows.Forms.TextBox Nevent_xst_fld;
		private System.Windows.Forms.Label New_Event_xst_lbl;
		private System.Windows.Forms.Label New_Event_Add_lbl;
		private System.Windows.Forms.TextBox Nevent_addr_fld;
		private System.Windows.Forms.Label Incident_Type_lbl;
		private System.Windows.Forms.ComboBox Nevent_incident_combo;
		private System.Windows.Forms.ComboBox Nevent_officer_combo;
		private System.Windows.Forms.TextBox Nevent_time_fld;
		private System.Windows.Forms.TextBox Nevent_date_fld;
		
		void Nevent_cancel_btnClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
