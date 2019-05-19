/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/3/2015
 * Time: 6:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class RunData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunData));
			this.DataDateLbl = new System.Windows.Forms.Label();
			this.Data_Date = new System.Windows.Forms.TextBox();
			this.Data_Time = new System.Windows.Forms.TextBox();
			this.DateTimeLbl = new System.Windows.Forms.Label();
			this.OfficerLbl = new System.Windows.Forms.Label();
			this.Officers = new System.Windows.Forms.ComboBox();
			this.DataLocation = new System.Windows.Forms.TextBox();
			this.LocationLbl = new System.Windows.Forms.Label();
			this.Cancel = new System.Windows.Forms.Button();
			this.dataForm = new NYSPP_CAD.DataForm();
			this.SuspendLayout();
			// 
			// DataDateLbl
			// 
			this.DataDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.DataDateLbl.Location = new System.Drawing.Point(12, 9);
			this.DataDateLbl.Name = "DataDateLbl";
			this.DataDateLbl.Size = new System.Drawing.Size(48, 18);
			this.DataDateLbl.TabIndex = 0;
			this.DataDateLbl.Text = "Date:";
			// 
			// Data_Date
			// 
			this.Data_Date.Location = new System.Drawing.Point(66, 9);
			this.Data_Date.Name = "Data_Date";
			this.Data_Date.Size = new System.Drawing.Size(116, 20);
			this.Data_Date.TabIndex = 1;
			this.Data_Date.Tag = "Data_Date";
			// 
			// Data_Time
			// 
			this.Data_Time.Location = new System.Drawing.Point(66, 36);
			this.Data_Time.Name = "Data_Time";
			this.Data_Time.Size = new System.Drawing.Size(116, 20);
			this.Data_Time.TabIndex = 3;
			this.Data_Time.Tag = "Data_Time";
			// 
			// DateTimeLbl
			// 
			this.DateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.DateTimeLbl.Location = new System.Drawing.Point(12, 36);
			this.DateTimeLbl.Name = "DateTimeLbl";
			this.DateTimeLbl.Size = new System.Drawing.Size(48, 18);
			this.DateTimeLbl.TabIndex = 2;
			this.DateTimeLbl.Text = "Time:";
			// 
			// OfficerLbl
			// 
			this.OfficerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.OfficerLbl.Location = new System.Drawing.Point(188, 9);
			this.OfficerLbl.Name = "OfficerLbl";
			this.OfficerLbl.Size = new System.Drawing.Size(64, 18);
			this.OfficerLbl.TabIndex = 4;
			this.OfficerLbl.Text = "Officer:";
			// 
			// Officers
			// 
			this.Officers.FormattingEnabled = true;
			this.Officers.Location = new System.Drawing.Point(258, 8);
			this.Officers.Name = "Officers";
			this.Officers.Size = new System.Drawing.Size(157, 21);
			this.Officers.TabIndex = 5;
			this.Officers.Tag = "Officers";
			this.Officers.Leave += new System.EventHandler(this.OfficersLeave);
			// 
			// DataLocation
			// 
			this.DataLocation.Location = new System.Drawing.Point(258, 36);
			this.DataLocation.Name = "DataLocation";
			this.DataLocation.Size = new System.Drawing.Size(116, 20);
			this.DataLocation.TabIndex = 7;
			this.DataLocation.Tag = "DataLocation";
			this.DataLocation.Leave += new System.EventHandler(this.DataLocationLeave);
			// 
			// LocationLbl
			// 
			this.LocationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.LocationLbl.Location = new System.Drawing.Point(188, 36);
			this.LocationLbl.Name = "LocationLbl";
			this.LocationLbl.Size = new System.Drawing.Size(73, 18);
			this.LocationLbl.TabIndex = 6;
			this.LocationLbl.Text = "Location:";
			// 
			// Cancel
			// 
			this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
			this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Cancel.Location = new System.Drawing.Point(398, 267);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(85, 30);
			this.Cancel.TabIndex = 44;
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// dataForm
			// 
			this.dataForm.BackColor = System.Drawing.Color.Transparent;
			this.dataForm.Location = new System.Drawing.Point(12, 60);
			this.dataForm.Name = "dataForm";
			this.dataForm.Size = new System.Drawing.Size(479, 201);
			this.dataForm.TabIndex = 45;
			// 
			// RunData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 302);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.DataLocation);
			this.Controls.Add(this.LocationLbl);
			this.Controls.Add(this.Officers);
			this.Controls.Add(this.OfficerLbl);
			this.Controls.Add(this.Data_Time);
			this.Controls.Add(this.DateTimeLbl);
			this.Controls.Add(this.Data_Date);
			this.Controls.Add(this.DataDateLbl);
			this.Controls.Add(this.dataForm);
			this.Name = "RunData";
			this.Text = "RunData";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Label LocationLbl;
		private System.Windows.Forms.TextBox DataLocation;
		private System.Windows.Forms.ComboBox Officers;
		private System.Windows.Forms.Label OfficerLbl;
		private System.Windows.Forms.Label DateTimeLbl;
		private System.Windows.Forms.TextBox Data_Time;
		private System.Windows.Forms.TextBox Data_Date;
		private System.Windows.Forms.Label DataDateLbl;
		private NYSPP_CAD.DataForm dataForm;
	}
}
