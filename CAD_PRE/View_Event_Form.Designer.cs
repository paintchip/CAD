/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 10/1/2015
 * Time: 5:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class View_Event_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Event_Form));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.View_Event_Date_lbl = new System.Windows.Forms.Label();
			this.View_Event_Date_fld = new System.Windows.Forms.TextBox();
			this.View_Event_time_lbl = new System.Windows.Forms.Label();
			this.View_Event_time_fld = new System.Windows.Forms.TextBox();
			this.View_Event_Officer_lbl = new System.Windows.Forms.Label();
			this.View_Event_Officer_combo = new System.Windows.Forms.ComboBox();
			this.View_Event_park_lbl = new System.Windows.Forms.Label();
			this.View_Event_park_combo = new System.Windows.Forms.ComboBox();
			this.View_Event_addr_lbl = new System.Windows.Forms.Label();
			this.New_Event_xst_lbl = new System.Windows.Forms.Label();
			this.View_Event_xst_fld = new System.Windows.Forms.TextBox();
			this.View_Event_nar_lbl = new System.Windows.Forms.Label();
			this.View_Event_nar_fld = new System.Windows.Forms.TextBox();
			this.View_Event_incident_lbl = new System.Windows.Forms.Label();
			this.View_Event_incident_fld = new System.Windows.Forms.ComboBox();
			this.View_Event_com_list = new System.Windows.Forms.ListBox();
			this.View_Event_addr_fld = new System.Windows.Forms.TextBox();
			this.Create_PARKS_Event = new System.Windows.Forms.Button();
			this.Close_btn = new System.Windows.Forms.Button();
			this.Save_Event_btn = new System.Windows.Forms.Button();
			this.Parks_created_lbl = new System.Windows.Forms.Label();
			this.veh_datagrid = new System.Windows.Forms.DataGridView();
			this.plp_datagrid = new System.Windows.Forms.DataGridView();
			this.Map_browser = new System.Windows.Forms.WebBrowser();
			this.Map_browser_btn = new System.Windows.Forms.Button();
			this.Add_calls_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.veh_datagrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.plp_datagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// View_Event_Date_lbl
			// 
			this.View_Event_Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_Date_lbl.Location = new System.Drawing.Point(12, 9);
			this.View_Event_Date_lbl.Name = "View_Event_Date_lbl";
			this.View_Event_Date_lbl.Size = new System.Drawing.Size(46, 23);
			this.View_Event_Date_lbl.TabIndex = 0;
			this.View_Event_Date_lbl.Text = "Date:";
			// 
			// View_Event_Date_fld
			// 
			this.View_Event_Date_fld.Location = new System.Drawing.Point(55, 6);
			this.View_Event_Date_fld.Name = "View_Event_Date_fld";
			this.View_Event_Date_fld.Size = new System.Drawing.Size(116, 20);
			this.View_Event_Date_fld.TabIndex = 20;
			// 
			// View_Event_time_lbl
			// 
			this.View_Event_time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_time_lbl.Location = new System.Drawing.Point(12, 32);
			this.View_Event_time_lbl.Name = "View_Event_time_lbl";
			this.View_Event_time_lbl.Size = new System.Drawing.Size(46, 23);
			this.View_Event_time_lbl.TabIndex = 2;
			this.View_Event_time_lbl.Text = "Time:";
			// 
			// View_Event_time_fld
			// 
			this.View_Event_time_fld.Location = new System.Drawing.Point(55, 29);
			this.View_Event_time_fld.Name = "View_Event_time_fld";
			this.View_Event_time_fld.Size = new System.Drawing.Size(116, 20);
			this.View_Event_time_fld.TabIndex = 21;
			// 
			// View_Event_Officer_lbl
			// 
			this.View_Event_Officer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_Officer_lbl.Location = new System.Drawing.Point(177, 15);
			this.View_Event_Officer_lbl.Name = "View_Event_Officer_lbl";
			this.View_Event_Officer_lbl.Size = new System.Drawing.Size(54, 23);
			this.View_Event_Officer_lbl.TabIndex = 6;
			this.View_Event_Officer_lbl.Text = "Officer:";
			this.View_Event_Officer_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// View_Event_Officer_combo
			// 
			this.View_Event_Officer_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.View_Event_Officer_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.View_Event_Officer_combo.FormattingEnabled = true;
			this.View_Event_Officer_combo.Location = new System.Drawing.Point(237, 12);
			this.View_Event_Officer_combo.Name = "View_Event_Officer_combo";
			this.View_Event_Officer_combo.Size = new System.Drawing.Size(134, 21);
			this.View_Event_Officer_combo.TabIndex = 0;
			this.View_Event_Officer_combo.DropDownClosed += new System.EventHandler(this.View_Event_Officer_comboDropDownClosed);
			// 
			// View_Event_park_lbl
			// 
			this.View_Event_park_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_park_lbl.Location = new System.Drawing.Point(12, 69);
			this.View_Event_park_lbl.Name = "View_Event_park_lbl";
			this.View_Event_park_lbl.Size = new System.Drawing.Size(118, 23);
			this.View_Event_park_lbl.TabIndex = 8;
			this.View_Event_park_lbl.Text = "Park/Municipality:";
			this.View_Event_park_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// View_Event_park_combo
			// 
			this.View_Event_park_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.View_Event_park_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.View_Event_park_combo.FormattingEnabled = true;
			this.View_Event_park_combo.Location = new System.Drawing.Point(12, 95);
			this.View_Event_park_combo.Name = "View_Event_park_combo";
			this.View_Event_park_combo.Size = new System.Drawing.Size(359, 21);
			this.View_Event_park_combo.TabIndex = 9;
			// 
			// View_Event_addr_lbl
			// 
			this.View_Event_addr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_addr_lbl.Location = new System.Drawing.Point(12, 119);
			this.View_Event_addr_lbl.Name = "View_Event_addr_lbl";
			this.View_Event_addr_lbl.Size = new System.Drawing.Size(100, 23);
			this.View_Event_addr_lbl.TabIndex = 10;
			this.View_Event_addr_lbl.Text = "Address:";
			this.View_Event_addr_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// New_Event_xst_lbl
			// 
			this.New_Event_xst_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Event_xst_lbl.Location = new System.Drawing.Point(12, 169);
			this.New_Event_xst_lbl.Name = "New_Event_xst_lbl";
			this.New_Event_xst_lbl.Size = new System.Drawing.Size(100, 23);
			this.New_Event_xst_lbl.TabIndex = 12;
			this.New_Event_xst_lbl.Text = "Cross Street:";
			this.New_Event_xst_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// View_Event_xst_fld
			// 
			this.View_Event_xst_fld.Location = new System.Drawing.Point(12, 195);
			this.View_Event_xst_fld.Name = "View_Event_xst_fld";
			this.View_Event_xst_fld.Size = new System.Drawing.Size(359, 20);
			this.View_Event_xst_fld.TabIndex = 13;
			// 
			// View_Event_nar_lbl
			// 
			this.View_Event_nar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_nar_lbl.Location = new System.Drawing.Point(12, 218);
			this.View_Event_nar_lbl.Name = "View_Event_nar_lbl";
			this.View_Event_nar_lbl.Size = new System.Drawing.Size(100, 23);
			this.View_Event_nar_lbl.TabIndex = 14;
			this.View_Event_nar_lbl.Text = "Narrative:";
			this.View_Event_nar_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// View_Event_nar_fld
			// 
			this.View_Event_nar_fld.Location = new System.Drawing.Point(12, 244);
			this.View_Event_nar_fld.Multiline = true;
			this.View_Event_nar_fld.Name = "View_Event_nar_fld";
			this.View_Event_nar_fld.Size = new System.Drawing.Size(359, 80);
			this.View_Event_nar_fld.TabIndex = 15;
			// 
			// View_Event_incident_lbl
			// 
			this.View_Event_incident_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_Event_incident_lbl.Location = new System.Drawing.Point(12, 327);
			this.View_Event_incident_lbl.Name = "View_Event_incident_lbl";
			this.View_Event_incident_lbl.Size = new System.Drawing.Size(100, 23);
			this.View_Event_incident_lbl.TabIndex = 16;
			this.View_Event_incident_lbl.Text = "Incident Type:";
			this.View_Event_incident_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// View_Event_incident_fld
			// 
			this.View_Event_incident_fld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.View_Event_incident_fld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.View_Event_incident_fld.FormattingEnabled = true;
			this.View_Event_incident_fld.Location = new System.Drawing.Point(12, 353);
			this.View_Event_incident_fld.Name = "View_Event_incident_fld";
			this.View_Event_incident_fld.Size = new System.Drawing.Size(359, 21);
			this.View_Event_incident_fld.TabIndex = 17;
			// 
			// View_Event_com_list
			// 
			this.View_Event_com_list.FormattingEnabled = true;
			this.View_Event_com_list.Location = new System.Drawing.Point(12, 380);
			this.View_Event_com_list.Name = "View_Event_com_list";
			this.View_Event_com_list.Size = new System.Drawing.Size(359, 95);
			this.View_Event_com_list.TabIndex = 19;
			// 
			// View_Event_addr_fld
			// 
			this.View_Event_addr_fld.Location = new System.Drawing.Point(12, 146);
			this.View_Event_addr_fld.Name = "View_Event_addr_fld";
			this.View_Event_addr_fld.Size = new System.Drawing.Size(359, 20);
			this.View_Event_addr_fld.TabIndex = 10;
			// 
			// Create_PARKS_Event
			// 
			this.Create_PARKS_Event.ForeColor = System.Drawing.Color.Black;
			this.Create_PARKS_Event.Image = ((System.Drawing.Image)(resources.GetObject("Create_PARKS_Event.Image")));
			this.Create_PARKS_Event.Location = new System.Drawing.Point(467, 453);
			this.Create_PARKS_Event.Name = "Create_PARKS_Event";
			this.Create_PARKS_Event.Size = new System.Drawing.Size(101, 22);
			this.Create_PARKS_Event.TabIndex = 22;
			this.Create_PARKS_Event.UseVisualStyleBackColor = true;
			this.Create_PARKS_Event.Click += new System.EventHandler(this.Create_PARKS_EventClick);
			// 
			// Close_btn
			// 
			this.Close_btn.ForeColor = System.Drawing.Color.Black;
			this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
			this.Close_btn.Location = new System.Drawing.Point(681, 453);
			this.Close_btn.Name = "Close_btn";
			this.Close_btn.Size = new System.Drawing.Size(101, 22);
			this.Close_btn.TabIndex = 23;
			this.Close_btn.UseVisualStyleBackColor = true;
			this.Close_btn.Click += new System.EventHandler(this.Close_btnClick);
			// 
			// Save_Event_btn
			// 
			this.Save_Event_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_Event_btn.Image")));
			this.Save_Event_btn.Location = new System.Drawing.Point(574, 453);
			this.Save_Event_btn.Name = "Save_Event_btn";
			this.Save_Event_btn.Size = new System.Drawing.Size(101, 22);
			this.Save_Event_btn.TabIndex = 24;
			this.Save_Event_btn.UseVisualStyleBackColor = true;
			this.Save_Event_btn.Click += new System.EventHandler(this.Save_Event_btnClick);
			// 
			// Parks_created_lbl
			// 
			this.Parks_created_lbl.Location = new System.Drawing.Point(377, 218);
			this.Parks_created_lbl.Name = "Parks_created_lbl";
			this.Parks_created_lbl.Size = new System.Drawing.Size(375, 14);
			this.Parks_created_lbl.TabIndex = 25;
			this.Parks_created_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// veh_datagrid
			// 
			this.veh_datagrid.BackgroundColor = System.Drawing.Color.Black;
			this.veh_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.veh_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.veh_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.veh_datagrid.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.veh_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.veh_datagrid.GridColor = System.Drawing.Color.Black;
			this.veh_datagrid.Location = new System.Drawing.Point(377, 353);
			this.veh_datagrid.Name = "veh_datagrid";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.veh_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.veh_datagrid.RowHeadersVisible = false;
			this.veh_datagrid.Size = new System.Drawing.Size(405, 94);
			this.veh_datagrid.TabIndex = 27;
			this.veh_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Veh_datagridCellContentClick);
			this.veh_datagrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridCellPainting);
			// 
			// plp_datagrid
			// 
			this.plp_datagrid.BackgroundColor = System.Drawing.Color.Black;
			this.plp_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.plp_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.plp_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.plp_datagrid.ColumnHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.plp_datagrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.plp_datagrid.GridColor = System.Drawing.Color.Black;
			this.plp_datagrid.Location = new System.Drawing.Point(377, 244);
			this.plp_datagrid.Name = "plp_datagrid";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.plp_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.plp_datagrid.RowHeadersVisible = false;
			this.plp_datagrid.Size = new System.Drawing.Size(405, 94);
			this.plp_datagrid.TabIndex = 28;
			this.plp_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Plp_datagridCellContentClick);
			this.plp_datagrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridCellPainting);
			// 
			// Map_browser
			// 
			this.Map_browser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Map_browser.Location = new System.Drawing.Point(380, 10);
			this.Map_browser.Margin = new System.Windows.Forms.Padding(0);
			this.Map_browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.Map_browser.Name = "Map_browser";
			this.Map_browser.ScrollBarsEnabled = false;
			this.Map_browser.Size = new System.Drawing.Size(402, 190);
			this.Map_browser.TabIndex = 29;
			this.Map_browser.WebBrowserShortcutsEnabled = false;
			// 
			// Map_browser_btn
			// 
			this.Map_browser_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Map_browser_btn.BackgroundImage")));
			this.Map_browser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Map_browser_btn.FlatAppearance.BorderSize = 0;
			this.Map_browser_btn.Location = new System.Drawing.Point(758, 218);
			this.Map_browser_btn.Name = "Map_browser_btn";
			this.Map_browser_btn.Size = new System.Drawing.Size(24, 23);
			this.Map_browser_btn.TabIndex = 30;
			this.Map_browser_btn.UseMnemonic = false;
			this.Map_browser_btn.UseVisualStyleBackColor = true;
			this.Map_browser_btn.Click += new System.EventHandler(this.Map_browser_btnClick);
			// 
			// Add_calls_btn
			// 
			this.Add_calls_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_calls_btn.BackgroundImage")));
			this.Add_calls_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Add_calls_btn.ForeColor = System.Drawing.Color.Black;
			this.Add_calls_btn.Location = new System.Drawing.Point(377, 448);
			this.Add_calls_btn.Name = "Add_calls_btn";
			this.Add_calls_btn.Size = new System.Drawing.Size(44, 32);
			this.Add_calls_btn.TabIndex = 31;
			this.Add_calls_btn.UseVisualStyleBackColor = true;
			this.Add_calls_btn.Click += new System.EventHandler(this.Add_calls_btnClick);
			// 
			// View_Event_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 481);
			this.Controls.Add(this.Add_calls_btn);
			this.Controls.Add(this.Map_browser_btn);
			this.Controls.Add(this.Map_browser);
			this.Controls.Add(this.plp_datagrid);
			this.Controls.Add(this.veh_datagrid);
			this.Controls.Add(this.Parks_created_lbl);
			this.Controls.Add(this.Save_Event_btn);
			this.Controls.Add(this.Close_btn);
			this.Controls.Add(this.Create_PARKS_Event);
			this.Controls.Add(this.View_Event_com_list);
			this.Controls.Add(this.View_Event_addr_fld);
			this.Controls.Add(this.View_Event_incident_fld);
			this.Controls.Add(this.View_Event_incident_lbl);
			this.Controls.Add(this.View_Event_nar_fld);
			this.Controls.Add(this.View_Event_nar_lbl);
			this.Controls.Add(this.View_Event_xst_fld);
			this.Controls.Add(this.New_Event_xst_lbl);
			this.Controls.Add(this.View_Event_addr_lbl);
			this.Controls.Add(this.View_Event_park_combo);
			this.Controls.Add(this.View_Event_park_lbl);
			this.Controls.Add(this.View_Event_Officer_combo);
			this.Controls.Add(this.View_Event_Officer_lbl);
			this.Controls.Add(this.View_Event_time_fld);
			this.Controls.Add(this.View_Event_time_lbl);
			this.Controls.Add(this.View_Event_Date_fld);
			this.Controls.Add(this.View_Event_Date_lbl);
			this.Name = "View_Event_Form";
			this.Text = "View_Event_Form";
			this.Load += new System.EventHandler(this.View_Event_FormLoad);
			((System.ComponentModel.ISupportInitialize)(this.veh_datagrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.plp_datagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Add_calls_btn;
		private System.Windows.Forms.Button Map_browser_btn;
		private System.Windows.Forms.WebBrowser Map_browser;
		private System.Windows.Forms.DataGridView plp_datagrid;
		private System.Windows.Forms.DataGridView veh_datagrid;
		private System.Windows.Forms.Label Parks_created_lbl;
		private System.Windows.Forms.Button Close_btn;
		private System.Windows.Forms.Button Save_Event_btn;
		private System.Windows.Forms.Button Create_PARKS_Event;
		private System.Windows.Forms.ListBox View_Event_com_list;
		private System.Windows.Forms.TextBox View_Event_addr_fld;
		private System.Windows.Forms.ComboBox View_Event_incident_fld;
		private System.Windows.Forms.Label View_Event_incident_lbl;
		private System.Windows.Forms.TextBox View_Event_nar_fld;
		private System.Windows.Forms.Label View_Event_nar_lbl;
		private System.Windows.Forms.TextBox View_Event_xst_fld;
		private System.Windows.Forms.Label New_Event_xst_lbl;
		private System.Windows.Forms.Label View_Event_addr_lbl;
		private System.Windows.Forms.ComboBox View_Event_park_combo;
		private System.Windows.Forms.Label View_Event_park_lbl;
		private System.Windows.Forms.ComboBox View_Event_Officer_combo;
		private System.Windows.Forms.Label View_Event_Officer_lbl;
		private System.Windows.Forms.TextBox View_Event_time_fld;
		private System.Windows.Forms.Label View_Event_time_lbl;
		private System.Windows.Forms.TextBox View_Event_Date_fld;
		private System.Windows.Forms.Label View_Event_Date_lbl;
	}
}
