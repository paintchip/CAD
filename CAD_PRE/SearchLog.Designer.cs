/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/3/2015
 * Time: 5:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class SearchLog
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Banner_lbl = new System.Windows.Forms.Label();
			this.Date_from_lbl = new System.Windows.Forms.Label();
			this.Date_from_fld = new System.Windows.Forms.TextBox();
			this.Date_to_lbl = new System.Windows.Forms.Label();
			this.Date_to_fld = new System.Windows.Forms.TextBox();
			this.Unit_called_lbl = new System.Windows.Forms.Label();
			this.Unit_called_fld = new System.Windows.Forms.TextBox();
			this.Caller_lbl = new System.Windows.Forms.Label();
			this.Caller_fld = new System.Windows.Forms.TextBox();
			this.Reason_lbl = new System.Windows.Forms.Label();
			this.Reason_combo = new System.Windows.Forms.ComboBox();
			this.ID_lbl = new System.Windows.Forms.Label();
			this.ID_combo = new System.Windows.Forms.ComboBox();
			this.Search_nar_fld = new System.Windows.Forms.TextBox();
			this.Search_nar_lbl = new System.Windows.Forms.Label();
			this.Reset_btn = new System.Windows.Forms.Button();
			this.Export_btn = new System.Windows.Forms.Button();
			this.Calls_datagrid = new System.Windows.Forms.DataGridView();
			this.Search_btn = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			((System.ComponentModel.ISupportInitialize)(this.Calls_datagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Banner_lbl
			// 
			this.Banner_lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Banner_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.Banner_lbl.Location = new System.Drawing.Point(12, 9);
			this.Banner_lbl.Name = "Banner_lbl";
			this.Banner_lbl.Size = new System.Drawing.Size(685, 55);
			this.Banner_lbl.TabIndex = 0;
			this.Banner_lbl.Text = "Communications Log Search";
			this.Banner_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Banner_lbl.UseMnemonic = false;
			// 
			// Date_from_lbl
			// 
			this.Date_from_lbl.Location = new System.Drawing.Point(12, 67);
			this.Date_from_lbl.Name = "Date_from_lbl";
			this.Date_from_lbl.Size = new System.Drawing.Size(72, 23);
			this.Date_from_lbl.TabIndex = 1;
			this.Date_from_lbl.Text = "Date From:";
			// 
			// Date_from_fld
			// 
			this.Date_from_fld.Location = new System.Drawing.Point(78, 64);
			this.Date_from_fld.Name = "Date_from_fld";
			this.Date_from_fld.Size = new System.Drawing.Size(76, 20);
			this.Date_from_fld.TabIndex = 2;
			// 
			// Date_to_lbl
			// 
			this.Date_to_lbl.Location = new System.Drawing.Point(160, 67);
			this.Date_to_lbl.Name = "Date_to_lbl";
			this.Date_to_lbl.Size = new System.Drawing.Size(72, 23);
			this.Date_to_lbl.TabIndex = 3;
			this.Date_to_lbl.Text = "Date to:";
			// 
			// Date_to_fld
			// 
			this.Date_to_fld.Location = new System.Drawing.Point(212, 64);
			this.Date_to_fld.Name = "Date_to_fld";
			this.Date_to_fld.Size = new System.Drawing.Size(76, 20);
			this.Date_to_fld.TabIndex = 4;
			// 
			// Unit_called_lbl
			// 
			this.Unit_called_lbl.Location = new System.Drawing.Point(294, 67);
			this.Unit_called_lbl.Name = "Unit_called_lbl";
			this.Unit_called_lbl.Size = new System.Drawing.Size(100, 23);
			this.Unit_called_lbl.TabIndex = 5;
			this.Unit_called_lbl.Text = "Unit Called:";
			// 
			// Unit_called_fld
			// 
			this.Unit_called_fld.Location = new System.Drawing.Point(358, 64);
			this.Unit_called_fld.Name = "Unit_called_fld";
			this.Unit_called_fld.Size = new System.Drawing.Size(143, 20);
			this.Unit_called_fld.TabIndex = 6;
			// 
			// Caller_lbl
			// 
			this.Caller_lbl.Location = new System.Drawing.Point(507, 67);
			this.Caller_lbl.Name = "Caller_lbl";
			this.Caller_lbl.Size = new System.Drawing.Size(100, 23);
			this.Caller_lbl.TabIndex = 7;
			this.Caller_lbl.Text = "Caller:";
			// 
			// Caller_fld
			// 
			this.Caller_fld.Location = new System.Drawing.Point(545, 64);
			this.Caller_fld.Name = "Caller_fld";
			this.Caller_fld.Size = new System.Drawing.Size(100, 20);
			this.Caller_fld.TabIndex = 8;
			// 
			// Reason_lbl
			// 
			this.Reason_lbl.Location = new System.Drawing.Point(12, 100);
			this.Reason_lbl.Name = "Reason_lbl";
			this.Reason_lbl.Size = new System.Drawing.Size(100, 23);
			this.Reason_lbl.TabIndex = 9;
			this.Reason_lbl.Text = "Reason:";
			// 
			// Reason_combo
			// 
			this.Reason_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Reason_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Reason_combo.FormattingEnabled = true;
			this.Reason_combo.Location = new System.Drawing.Point(78, 97);
			this.Reason_combo.Name = "Reason_combo";
			this.Reason_combo.Size = new System.Drawing.Size(121, 21);
			this.Reason_combo.TabIndex = 10;
			// 
			// ID_lbl
			// 
			this.ID_lbl.Location = new System.Drawing.Point(212, 100);
			this.ID_lbl.Name = "ID_lbl";
			this.ID_lbl.Size = new System.Drawing.Size(100, 23);
			this.ID_lbl.TabIndex = 11;
			this.ID_lbl.Text = "ID #";
			// 
			// ID_combo
			// 
			this.ID_combo.FormattingEnabled = true;
			this.ID_combo.Location = new System.Drawing.Point(247, 97);
			this.ID_combo.Name = "ID_combo";
			this.ID_combo.Size = new System.Drawing.Size(72, 21);
			this.ID_combo.TabIndex = 12;
			// 
			// Search_nar_fld
			// 
			this.Search_nar_fld.Location = new System.Drawing.Point(325, 97);
			this.Search_nar_fld.Multiline = true;
			this.Search_nar_fld.Name = "Search_nar_fld";
			this.Search_nar_fld.Size = new System.Drawing.Size(320, 77);
			this.Search_nar_fld.TabIndex = 13;
			// 
			// Search_nar_lbl
			// 
			this.Search_nar_lbl.Location = new System.Drawing.Point(219, 123);
			this.Search_nar_lbl.Name = "Search_nar_lbl";
			this.Search_nar_lbl.Size = new System.Drawing.Size(100, 23);
			this.Search_nar_lbl.TabIndex = 14;
			this.Search_nar_lbl.Text = "Search Narrative:";
			// 
			// Reset_btn
			// 
			this.Reset_btn.ForeColor = System.Drawing.Color.Black;
			this.Reset_btn.Location = new System.Drawing.Point(163, 149);
			this.Reset_btn.Name = "Reset_btn";
			this.Reset_btn.Size = new System.Drawing.Size(75, 23);
			this.Reset_btn.TabIndex = 15;
			this.Reset_btn.Text = "Reset";
			this.Reset_btn.UseVisualStyleBackColor = true;
			this.Reset_btn.Click += new System.EventHandler(this.Reset_btnClick);
			// 
			// Export_btn
			// 
			this.Export_btn.ForeColor = System.Drawing.Color.Black;
			this.Export_btn.Location = new System.Drawing.Point(244, 149);
			this.Export_btn.Name = "Export_btn";
			this.Export_btn.Size = new System.Drawing.Size(75, 23);
			this.Export_btn.TabIndex = 16;
			this.Export_btn.Text = "Export";
			this.Export_btn.UseVisualStyleBackColor = true;
			this.Export_btn.Click += new System.EventHandler(this.Export_btnClick);
			// 
			// Calls_datagrid
			// 
			this.Calls_datagrid.AllowUserToAddRows = false;
			this.Calls_datagrid.AllowUserToDeleteRows = false;
			this.Calls_datagrid.AllowUserToResizeRows = false;
			this.Calls_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Calls_datagrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.Calls_datagrid.Location = new System.Drawing.Point(4, 192);
			this.Calls_datagrid.Name = "Calls_datagrid";
			this.Calls_datagrid.RowHeadersVisible = false;
			this.Calls_datagrid.Size = new System.Drawing.Size(693, 255);
			this.Calls_datagrid.TabIndex = 17;
			this.Calls_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Calls_datagridCellContentClick);
			// 
			// Search_btn
			// 
			this.Search_btn.ForeColor = System.Drawing.Color.Black;
			this.Search_btn.Location = new System.Drawing.Point(82, 149);
			this.Search_btn.Name = "Search_btn";
			this.Search_btn.Size = new System.Drawing.Size(75, 23);
			this.Search_btn.TabIndex = 18;
			this.Search_btn.Text = "Search";
			this.Search_btn.UseVisualStyleBackColor = true;
			this.Search_btn.Click += new System.EventHandler(this.Search_btnClick);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// SearchLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 459);
			this.Controls.Add(this.Search_btn);
			this.Controls.Add(this.Calls_datagrid);
			this.Controls.Add(this.Export_btn);
			this.Controls.Add(this.Reset_btn);
			this.Controls.Add(this.Search_nar_lbl);
			this.Controls.Add(this.Search_nar_fld);
			this.Controls.Add(this.ID_combo);
			this.Controls.Add(this.ID_lbl);
			this.Controls.Add(this.Reason_combo);
			this.Controls.Add(this.Reason_lbl);
			this.Controls.Add(this.Caller_fld);
			this.Controls.Add(this.Caller_lbl);
			this.Controls.Add(this.Unit_called_fld);
			this.Controls.Add(this.Unit_called_lbl);
			this.Controls.Add(this.Date_to_fld);
			this.Controls.Add(this.Date_to_lbl);
			this.Controls.Add(this.Date_from_fld);
			this.Controls.Add(this.Date_from_lbl);
			this.Controls.Add(this.Banner_lbl);
			this.Name = "SearchLog";
			this.Text = "SearchLog";
			this.Load += new System.EventHandler(this.SearchLogLoad);
			((System.ComponentModel.ISupportInitialize)(this.Calls_datagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Button Search_btn;
		private System.Windows.Forms.DataGridView Calls_datagrid;
		private System.Windows.Forms.Button Export_btn;
		private System.Windows.Forms.Button Reset_btn;
		private System.Windows.Forms.Label Search_nar_lbl;
		private System.Windows.Forms.TextBox Search_nar_fld;
		private System.Windows.Forms.ComboBox ID_combo;
		private System.Windows.Forms.Label ID_lbl;
		private System.Windows.Forms.ComboBox Reason_combo;
		private System.Windows.Forms.Label Reason_lbl;
		private System.Windows.Forms.TextBox Caller_fld;
		private System.Windows.Forms.Label Caller_lbl;
		private System.Windows.Forms.TextBox Unit_called_fld;
		private System.Windows.Forms.Label Unit_called_lbl;
		private System.Windows.Forms.TextBox Date_to_fld;
		private System.Windows.Forms.Label Date_to_lbl;
		private System.Windows.Forms.TextBox Date_from_fld;
		private System.Windows.Forms.Label Date_from_lbl;
		private System.Windows.Forms.Label Banner_lbl;
	}
}
