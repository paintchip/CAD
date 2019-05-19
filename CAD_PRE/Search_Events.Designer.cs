/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/22/2015
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Search_Events
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Search_Events_lbl = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Zone_lbl = new System.Windows.Forms.Label();
			this.Date_lbl = new System.Windows.Forms.Label();
			this.Member_lbl = new System.Windows.Forms.Label();
			this.Search_Events_Zone_combo = new System.Windows.Forms.ComboBox();
			this.Search_Events_Member_combo = new System.Windows.Forms.ComboBox();
			this.Search_Events_Date_txt = new System.Windows.Forms.TextBox();
			this.Search_Events_btn = new System.Windows.Forms.Button();
			this.EvtDatagrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.EvtDatagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Search_Events_lbl
			// 
			this.Search_Events_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.Search_Events_lbl.Location = new System.Drawing.Point(4, 9);
			this.Search_Events_lbl.Name = "Search_Events_lbl";
			this.Search_Events_lbl.Size = new System.Drawing.Size(173, 27);
			this.Search_Events_lbl.TabIndex = 0;
			this.Search_Events_lbl.Text = "Search Events";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(-4, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 5);
			this.panel1.TabIndex = 1;
			// 
			// Zone_lbl
			// 
			this.Zone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Zone_lbl.Location = new System.Drawing.Point(12, 64);
			this.Zone_lbl.Name = "Zone_lbl";
			this.Zone_lbl.Size = new System.Drawing.Size(100, 23);
			this.Zone_lbl.TabIndex = 2;
			this.Zone_lbl.Text = "Zone";
			// 
			// Date_lbl
			// 
			this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Date_lbl.Location = new System.Drawing.Point(12, 97);
			this.Date_lbl.Name = "Date_lbl";
			this.Date_lbl.Size = new System.Drawing.Size(100, 23);
			this.Date_lbl.TabIndex = 3;
			this.Date_lbl.Text = "Date";
			// 
			// Member_lbl
			// 
			this.Member_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Member_lbl.Location = new System.Drawing.Point(243, 64);
			this.Member_lbl.Name = "Member_lbl";
			this.Member_lbl.Size = new System.Drawing.Size(64, 23);
			this.Member_lbl.TabIndex = 4;
			this.Member_lbl.Text = "Member";
			// 
			// Search_Events_Zone_combo
			// 
			this.Search_Events_Zone_combo.FormattingEnabled = true;
			this.Search_Events_Zone_combo.Items.AddRange(new object[] {
									"Central",
									"Thousand Islands",
									"Finger Lakes"});
			this.Search_Events_Zone_combo.Location = new System.Drawing.Point(58, 61);
			this.Search_Events_Zone_combo.Name = "Search_Events_Zone_combo";
			this.Search_Events_Zone_combo.Size = new System.Drawing.Size(169, 21);
			this.Search_Events_Zone_combo.TabIndex = 5;
			this.Search_Events_Zone_combo.SelectedIndexChanged += new System.EventHandler(this.Search_Events_Zone_comboDropDownClosed);
			// 
			// Search_Events_Member_combo
			// 
			this.Search_Events_Member_combo.FormattingEnabled = true;
			this.Search_Events_Member_combo.Location = new System.Drawing.Point(313, 61);
			this.Search_Events_Member_combo.Name = "Search_Events_Member_combo";
			this.Search_Events_Member_combo.Size = new System.Drawing.Size(198, 21);
			this.Search_Events_Member_combo.TabIndex = 6;
			// 
			// Search_Events_Date_txt
			// 
			this.Search_Events_Date_txt.Location = new System.Drawing.Point(58, 96);
			this.Search_Events_Date_txt.Name = "Search_Events_Date_txt";
			this.Search_Events_Date_txt.Size = new System.Drawing.Size(115, 20);
			this.Search_Events_Date_txt.TabIndex = 7;
			// 
			// Search_Events_btn
			// 
			this.Search_Events_btn.ForeColor = System.Drawing.Color.Black;
			this.Search_Events_btn.Location = new System.Drawing.Point(206, 97);
			this.Search_Events_btn.Name = "Search_Events_btn";
			this.Search_Events_btn.Size = new System.Drawing.Size(77, 23);
			this.Search_Events_btn.TabIndex = 8;
			this.Search_Events_btn.Text = "Search";
			this.Search_Events_btn.UseVisualStyleBackColor = true;
			this.Search_Events_btn.Click += new System.EventHandler(this.Search_Events_btnClick);
			// 
			// EvtDatagrid
			// 
			this.EvtDatagrid.AllowUserToAddRows = false;
			this.EvtDatagrid.AllowUserToDeleteRows = false;
			this.EvtDatagrid.AllowUserToOrderColumns = true;
			this.EvtDatagrid.AllowUserToResizeRows = false;
			this.EvtDatagrid.BackgroundColor = System.Drawing.Color.Black;
			this.EvtDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EvtDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.EvtDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.EvtDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.EvtDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EvtDatagrid.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.EvtDatagrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.EvtDatagrid.EnableHeadersVisualStyles = false;
			this.EvtDatagrid.GridColor = System.Drawing.Color.Black;
			this.EvtDatagrid.Location = new System.Drawing.Point(9, 149);
			this.EvtDatagrid.Name = "EvtDatagrid";
			this.EvtDatagrid.RowHeadersVisible = false;
			this.EvtDatagrid.Size = new System.Drawing.Size(701, 241);
			this.EvtDatagrid.TabIndex = 9;
			this.EvtDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EvtDatagridCellContentClick);
			this.EvtDatagrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridCellPainting);
			// 
			// Search_Events
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 402);
			this.Controls.Add(this.EvtDatagrid);
			this.Controls.Add(this.Search_Events_btn);
			this.Controls.Add(this.Search_Events_Date_txt);
			this.Controls.Add(this.Search_Events_Member_combo);
			this.Controls.Add(this.Search_Events_Zone_combo);
			this.Controls.Add(this.Member_lbl);
			this.Controls.Add(this.Date_lbl);
			this.Controls.Add(this.Zone_lbl);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Search_Events_lbl);
			this.Name = "Search_Events";
			this.Text = "Search_Events";
			((System.ComponentModel.ISupportInitialize)(this.EvtDatagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView EvtDatagrid;
		private System.Windows.Forms.Button Search_Events_btn;
		private System.Windows.Forms.TextBox Search_Events_Date_txt;
		private System.Windows.Forms.ComboBox Search_Events_Member_combo;
		private System.Windows.Forms.ComboBox Search_Events_Zone_combo;
		private System.Windows.Forms.Label Member_lbl;
		private System.Windows.Forms.Label Date_lbl;
		private System.Windows.Forms.Label Zone_lbl;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Search_Events_lbl;
		
		void ComboBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Populate the member's list based on the zone selection
		}
	}
}
