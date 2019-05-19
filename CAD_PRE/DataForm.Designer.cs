/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 10/30/2015
 * Time: 6:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class DataForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
			this.RunVIN = new System.Windows.Forms.Button();
			this.Make = new System.Windows.Forms.ComboBox();
			this.MakeLbl = new System.Windows.Forms.Label();
			this.Year = new System.Windows.Forms.TextBox();
			this.YearLbl = new System.Windows.Forms.Label();
			this.VIN = new System.Windows.Forms.TextBox();
			this.VINLbl = new System.Windows.Forms.Label();
			this.RunPlate = new System.Windows.Forms.Button();
			this.Exp = new System.Windows.Forms.TextBox();
			this.ExpLbl = new System.Windows.Forms.Label();
			this.Plate_Type = new System.Windows.Forms.ComboBox();
			this.PlateTypeLbl = new System.Windows.Forms.Label();
			this.Plate_State = new System.Windows.Forms.ComboBox();
			this.PlateStateLbl = new System.Windows.Forms.Label();
			this.Plate = new System.Windows.Forms.TextBox();
			this.PlateLbl = new System.Windows.Forms.Label();
			this.RunCID = new System.Windows.Forms.Button();
			this.RunPerson = new System.Windows.Forms.Button();
			this.CID = new System.Windows.Forms.TextBox();
			this.CIDLbl = new System.Windows.Forms.Label();
			this.StateSearch = new System.Windows.Forms.LinkLabel();
			this.Person_State = new System.Windows.Forms.ComboBox();
			this.PersonStateLbl = new System.Windows.Forms.Label();
			this.DOB = new System.Windows.Forms.TextBox();
			this.DOBLbl = new System.Windows.Forms.Label();
			this.Gender = new System.Windows.Forms.ComboBox();
			this.GenderLbl = new System.Windows.Forms.Label();
			this.Middle_Init = new System.Windows.Forms.TextBox();
			this.MiddleInitLbl = new System.Windows.Forms.Label();
			this.First_Name = new System.Windows.Forms.TextBox();
			this.FirstNameLbl = new System.Windows.Forms.Label();
			this.Last_Name = new System.Windows.Forms.TextBox();
			this.LastNameLbl = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Mult_State = new System.Windows.Forms.TextBox();
			this.RunCCH = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RunVIN
			// 
			this.RunVIN.ForeColor = System.Drawing.Color.Black;
			this.RunVIN.Image = ((System.Drawing.Image)(resources.GetObject("RunVIN.Image")));
			this.RunVIN.Location = new System.Drawing.Point(422, 164);
			this.RunVIN.Name = "RunVIN";
			this.RunVIN.Size = new System.Drawing.Size(54, 35);
			this.RunVIN.TabIndex = 80;
			this.RunVIN.Tag = "VIN";
			this.RunVIN.UseVisualStyleBackColor = true;
			this.RunVIN.Click += new System.EventHandler(this.RunDataClick);
			// 
			// Make
			// 
			this.Make.FormattingEnabled = true;
			this.Make.Location = new System.Drawing.Point(251, 178);
			this.Make.Name = "Make";
			this.Make.Size = new System.Drawing.Size(110, 21);
			this.Make.TabIndex = 79;
			this.Make.Tag = "Make";
			// 
			// MakeLbl
			// 
			this.MakeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.MakeLbl.Location = new System.Drawing.Point(251, 157);
			this.MakeLbl.Name = "MakeLbl";
			this.MakeLbl.Size = new System.Drawing.Size(50, 18);
			this.MakeLbl.TabIndex = 78;
			this.MakeLbl.Text = "Make:";
			// 
			// Year
			// 
			this.Year.Location = new System.Drawing.Point(192, 179);
			this.Year.Name = "Year";
			this.Year.Size = new System.Drawing.Size(53, 20);
			this.Year.TabIndex = 77;
			this.Year.Tag = "Year";
			// 
			// YearLbl
			// 
			this.YearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.YearLbl.Location = new System.Drawing.Point(192, 158);
			this.YearLbl.Name = "YearLbl";
			this.YearLbl.Size = new System.Drawing.Size(45, 18);
			this.YearLbl.TabIndex = 76;
			this.YearLbl.Text = "Year:";
			// 
			// VIN
			// 
			this.VIN.Location = new System.Drawing.Point(13, 179);
			this.VIN.Name = "VIN";
			this.VIN.Size = new System.Drawing.Size(173, 20);
			this.VIN.TabIndex = 75;
			this.VIN.Tag = "VIN";
			// 
			// VINLbl
			// 
			this.VINLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.VINLbl.Location = new System.Drawing.Point(13, 158);
			this.VINLbl.Name = "VINLbl";
			this.VINLbl.Size = new System.Drawing.Size(48, 18);
			this.VINLbl.TabIndex = 74;
			this.VINLbl.Text = "VIN:";
			// 
			// RunPlate
			// 
			this.RunPlate.ForeColor = System.Drawing.Color.Black;
			this.RunPlate.Image = ((System.Drawing.Image)(resources.GetObject("RunPlate.Image")));
			this.RunPlate.Location = new System.Drawing.Point(422, 117);
			this.RunPlate.Name = "RunPlate";
			this.RunPlate.Size = new System.Drawing.Size(54, 35);
			this.RunPlate.TabIndex = 73;
			this.RunPlate.Tag = "REG";
			this.RunPlate.UseVisualStyleBackColor = true;
			this.RunPlate.Click += new System.EventHandler(this.RunDataClick);
			// 
			// Exp
			// 
			this.Exp.Location = new System.Drawing.Point(363, 134);
			this.Exp.Name = "Exp";
			this.Exp.Size = new System.Drawing.Size(53, 20);
			this.Exp.TabIndex = 72;
			this.Exp.Tag = "Exp";
			// 
			// ExpLbl
			// 
			this.ExpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.ExpLbl.Location = new System.Drawing.Point(363, 113);
			this.ExpLbl.Name = "ExpLbl";
			this.ExpLbl.Size = new System.Drawing.Size(45, 18);
			this.ExpLbl.TabIndex = 71;
			this.ExpLbl.Text = "Exp:";
			// 
			// Plate_Type
			// 
			this.Plate_Type.FormattingEnabled = true;
			this.Plate_Type.Location = new System.Drawing.Point(247, 134);
			this.Plate_Type.Name = "Plate_Type";
			this.Plate_Type.Size = new System.Drawing.Size(110, 21);
			this.Plate_Type.TabIndex = 70;
			this.Plate_Type.Tag = "Plate_Type";
			// 
			// PlateTypeLbl
			// 
			this.PlateTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.PlateTypeLbl.Location = new System.Drawing.Point(247, 113);
			this.PlateTypeLbl.Name = "PlateTypeLbl";
			this.PlateTypeLbl.Size = new System.Drawing.Size(50, 18);
			this.PlateTypeLbl.TabIndex = 69;
			this.PlateTypeLbl.Text = "Type:";
			// 
			// Plate_State
			// 
			this.Plate_State.FormattingEnabled = true;
			this.Plate_State.Location = new System.Drawing.Point(145, 134);
			this.Plate_State.Name = "Plate_State";
			this.Plate_State.Size = new System.Drawing.Size(96, 21);
			this.Plate_State.TabIndex = 68;
			this.Plate_State.Tag = "Plate_State";
			// 
			// PlateStateLbl
			// 
			this.PlateStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.PlateStateLbl.Location = new System.Drawing.Point(145, 113);
			this.PlateStateLbl.Name = "PlateStateLbl";
			this.PlateStateLbl.Size = new System.Drawing.Size(50, 18);
			this.PlateStateLbl.TabIndex = 67;
			this.PlateStateLbl.Text = "State:";
			// 
			// Plate
			// 
			this.Plate.Location = new System.Drawing.Point(13, 135);
			this.Plate.Name = "Plate";
			this.Plate.Size = new System.Drawing.Size(126, 20);
			this.Plate.TabIndex = 66;
			this.Plate.Tag = "Plate";
			// 
			// PlateLbl
			// 
			this.PlateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.PlateLbl.Location = new System.Drawing.Point(13, 114);
			this.PlateLbl.Name = "PlateLbl";
			this.PlateLbl.Size = new System.Drawing.Size(48, 18);
			this.PlateLbl.TabIndex = 65;
			this.PlateLbl.Text = "Plate #:";
			// 
			// RunCID
			// 
			this.RunCID.ForeColor = System.Drawing.Color.Black;
			this.RunCID.Image = ((System.Drawing.Image)(resources.GetObject("RunCID.Image")));
			this.RunCID.Location = new System.Drawing.Point(402, 61);
			this.RunCID.Name = "RunCID";
			this.RunCID.Size = new System.Drawing.Size(35, 35);
			this.RunCID.TabIndex = 63;
			this.RunCID.Tag = "CID";
			this.RunCID.UseVisualStyleBackColor = true;
			this.RunCID.Click += new System.EventHandler(this.RunDataClick);
			// 
			// RunPerson
			// 
			this.RunPerson.ForeColor = System.Drawing.Color.Black;
			this.RunPerson.Image = ((System.Drawing.Image)(resources.GetObject("RunPerson.Image")));
			this.RunPerson.Location = new System.Drawing.Point(363, 61);
			this.RunPerson.Name = "RunPerson";
			this.RunPerson.Size = new System.Drawing.Size(35, 35);
			this.RunPerson.TabIndex = 62;
			this.RunPerson.Tag = "DOB";
			this.RunPerson.UseVisualStyleBackColor = true;
			this.RunPerson.Click += new System.EventHandler(this.RunDataClick);
			// 
			// CID
			// 
			this.CID.Location = new System.Drawing.Point(247, 75);
			this.CID.Name = "CID";
			this.CID.Size = new System.Drawing.Size(110, 20);
			this.CID.TabIndex = 61;
			this.CID.Tag = "CID";
			// 
			// CIDLbl
			// 
			this.CIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.CIDLbl.Location = new System.Drawing.Point(247, 54);
			this.CIDLbl.Name = "CIDLbl";
			this.CIDLbl.Size = new System.Drawing.Size(48, 18);
			this.CIDLbl.TabIndex = 60;
			this.CIDLbl.Text = "CID:";
			// 
			// StateSearch
			// 
			this.StateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StateSearch.Location = new System.Drawing.Point(213, 75);
			this.StateSearch.Name = "StateSearch";
			this.StateSearch.Size = new System.Drawing.Size(28, 23);
			this.StateSearch.TabIndex = 59;
			this.StateSearch.TabStop = true;
			this.StateSearch.Tag = "StateSearch";
			this.StateSearch.Text = "[+]";
			this.StateSearch.Click += new System.EventHandler(this.StateSearchClick);
			// 
			// Person_State
			// 
			this.Person_State.FormattingEnabled = true;
			this.Person_State.Location = new System.Drawing.Point(115, 75);
			this.Person_State.Name = "Person_State";
			this.Person_State.Size = new System.Drawing.Size(96, 21);
			this.Person_State.TabIndex = 58;
			this.Person_State.Tag = "Person_State";
			// 
			// PersonStateLbl
			// 
			this.PersonStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.PersonStateLbl.Location = new System.Drawing.Point(115, 54);
			this.PersonStateLbl.Name = "PersonStateLbl";
			this.PersonStateLbl.Size = new System.Drawing.Size(50, 18);
			this.PersonStateLbl.TabIndex = 57;
			this.PersonStateLbl.Text = "State:";
			// 
			// DOB
			// 
			this.DOB.Location = new System.Drawing.Point(13, 75);
			this.DOB.Name = "DOB";
			this.DOB.Size = new System.Drawing.Size(96, 20);
			this.DOB.TabIndex = 56;
			this.DOB.Tag = "DOB";
			// 
			// DOBLbl
			// 
			this.DOBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.DOBLbl.Location = new System.Drawing.Point(13, 54);
			this.DOBLbl.Name = "DOBLbl";
			this.DOBLbl.Size = new System.Drawing.Size(48, 18);
			this.DOBLbl.TabIndex = 55;
			this.DOBLbl.Text = "DOB:";
			// 
			// Gender
			// 
			this.Gender.FormattingEnabled = true;
			this.Gender.Location = new System.Drawing.Point(373, 31);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(92, 21);
			this.Gender.TabIndex = 54;
			this.Gender.Tag = "Gender";
			// 
			// GenderLbl
			// 
			this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.GenderLbl.Location = new System.Drawing.Point(373, 10);
			this.GenderLbl.Name = "GenderLbl";
			this.GenderLbl.Size = new System.Drawing.Size(69, 18);
			this.GenderLbl.TabIndex = 53;
			this.GenderLbl.Text = "Gender:";
			// 
			// Middle_Init
			// 
			this.Middle_Init.Location = new System.Drawing.Point(329, 31);
			this.Middle_Init.Name = "Middle_Init";
			this.Middle_Init.Size = new System.Drawing.Size(38, 20);
			this.Middle_Init.TabIndex = 52;
			this.Middle_Init.Tag = "Middle_Init";
			// 
			// MiddleInitLbl
			// 
			this.MiddleInitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.MiddleInitLbl.Location = new System.Drawing.Point(329, 10);
			this.MiddleInitLbl.Name = "MiddleInitLbl";
			this.MiddleInitLbl.Size = new System.Drawing.Size(28, 18);
			this.MiddleInitLbl.TabIndex = 51;
			this.MiddleInitLbl.Text = "M:";
			// 
			// First_Name
			// 
			this.First_Name.Location = new System.Drawing.Point(171, 31);
			this.First_Name.Name = "First_Name";
			this.First_Name.Size = new System.Drawing.Size(152, 20);
			this.First_Name.TabIndex = 50;
			this.First_Name.Tag = "First_Name";
			// 
			// FirstNameLbl
			// 
			this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.FirstNameLbl.Location = new System.Drawing.Point(171, 10);
			this.FirstNameLbl.Name = "FirstNameLbl";
			this.FirstNameLbl.Size = new System.Drawing.Size(87, 18);
			this.FirstNameLbl.TabIndex = 49;
			this.FirstNameLbl.Text = "First Name:";
			// 
			// Last_Name
			// 
			this.Last_Name.Location = new System.Drawing.Point(13, 31);
			this.Last_Name.Name = "Last_Name";
			this.Last_Name.Size = new System.Drawing.Size(152, 20);
			this.Last_Name.TabIndex = 48;
			this.Last_Name.Tag = "Last_Name";
			// 
			// LastNameLbl
			// 
			this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.LastNameLbl.Location = new System.Drawing.Point(13, 10);
			this.LastNameLbl.Name = "LastNameLbl";
			this.LastNameLbl.Size = new System.Drawing.Size(87, 18);
			this.LastNameLbl.TabIndex = 47;
			this.LastNameLbl.Text = "Last Name:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Yellow;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(5, 200);
			this.panel2.TabIndex = 46;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Yellow;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(477, 5);
			this.panel1.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Yellow;
			this.panel3.Location = new System.Drawing.Point(0, 104);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(477, 5);
			this.panel3.TabIndex = 64;
			// 
			// Mult_State
			// 
			this.Mult_State.Location = new System.Drawing.Point(115, 75);
			this.Mult_State.Name = "Mult_State";
			this.Mult_State.Size = new System.Drawing.Size(96, 20);
			this.Mult_State.TabIndex = 81;
			this.Mult_State.Visible = false;
			// 
			// RunCCH
			// 
			this.RunCCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RunCCH.ForeColor = System.Drawing.Color.Black;
			this.RunCCH.Location = new System.Drawing.Point(441, 61);
			this.RunCCH.Name = "RunCCH";
			this.RunCCH.Size = new System.Drawing.Size(35, 35);
			this.RunCCH.TabIndex = 82;
			this.RunCCH.Tag = "CCH";
			this.RunCCH.Text = "CCH";
			this.RunCCH.UseVisualStyleBackColor = true;
			this.RunCCH.Click += new System.EventHandler(this.RunDataClick);
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.RunCCH);
			this.Controls.Add(this.RunVIN);
			this.Controls.Add(this.Make);
			this.Controls.Add(this.MakeLbl);
			this.Controls.Add(this.Year);
			this.Controls.Add(this.YearLbl);
			this.Controls.Add(this.VIN);
			this.Controls.Add(this.VINLbl);
			this.Controls.Add(this.RunPlate);
			this.Controls.Add(this.Exp);
			this.Controls.Add(this.ExpLbl);
			this.Controls.Add(this.Plate_Type);
			this.Controls.Add(this.PlateTypeLbl);
			this.Controls.Add(this.Plate_State);
			this.Controls.Add(this.PlateStateLbl);
			this.Controls.Add(this.Plate);
			this.Controls.Add(this.PlateLbl);
			this.Controls.Add(this.RunCID);
			this.Controls.Add(this.RunPerson);
			this.Controls.Add(this.CID);
			this.Controls.Add(this.CIDLbl);
			this.Controls.Add(this.StateSearch);
			this.Controls.Add(this.Person_State);
			this.Controls.Add(this.PersonStateLbl);
			this.Controls.Add(this.DOB);
			this.Controls.Add(this.DOBLbl);
			this.Controls.Add(this.Gender);
			this.Controls.Add(this.GenderLbl);
			this.Controls.Add(this.Middle_Init);
			this.Controls.Add(this.MiddleInitLbl);
			this.Controls.Add(this.First_Name);
			this.Controls.Add(this.FirstNameLbl);
			this.Controls.Add(this.Last_Name);
			this.Controls.Add(this.LastNameLbl);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.Mult_State);
			this.Name = "DataForm";
			this.Size = new System.Drawing.Size(479, 201);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button RunCCH;
		private System.Windows.Forms.TextBox Mult_State;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label LastNameLbl;
		private System.Windows.Forms.TextBox Last_Name;
		private System.Windows.Forms.Label FirstNameLbl;
		private System.Windows.Forms.TextBox First_Name;
		private System.Windows.Forms.Label MiddleInitLbl;
		private System.Windows.Forms.TextBox Middle_Init;
		private System.Windows.Forms.Label GenderLbl;
		private System.Windows.Forms.ComboBox Gender;
		private System.Windows.Forms.Label DOBLbl;
		private System.Windows.Forms.TextBox DOB;
		private System.Windows.Forms.Label PersonStateLbl;
		private System.Windows.Forms.ComboBox Person_State;
		private System.Windows.Forms.LinkLabel StateSearch;
		private System.Windows.Forms.Label CIDLbl;
		private System.Windows.Forms.TextBox CID;
		private System.Windows.Forms.Button RunPerson;
		private System.Windows.Forms.Button RunCID;
		private System.Windows.Forms.Label PlateLbl;
		private System.Windows.Forms.TextBox Plate;
		private System.Windows.Forms.Label PlateStateLbl;
		private System.Windows.Forms.ComboBox Plate_State;
		private System.Windows.Forms.Label PlateTypeLbl;
		private System.Windows.Forms.ComboBox Plate_Type;
		private System.Windows.Forms.Label ExpLbl;
		private System.Windows.Forms.TextBox Exp;
		private System.Windows.Forms.Button RunPlate;
		private System.Windows.Forms.Label VINLbl;
		private System.Windows.Forms.TextBox VIN;
		private System.Windows.Forms.Label YearLbl;
		private System.Windows.Forms.TextBox Year;
		private System.Windows.Forms.Label MakeLbl;
		private System.Windows.Forms.ComboBox Make;
		private System.Windows.Forms.Button RunVIN;
	}
}
