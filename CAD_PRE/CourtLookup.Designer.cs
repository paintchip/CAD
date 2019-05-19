/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/11/2015
 * Time: 1:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class CourtLookup :baseform
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
			//basecontrols();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourtLookup));
			this.courtLbl = new System.Windows.Forms.Label();
			this.county = new System.Windows.Forms.ComboBox();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.countyLbl = new System.Windows.Forms.Label();
			this.searchLbl = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.courtNameLbl = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// courtLbl
			// 
			this.courtLbl.BackColor = this.BackColor;
			this.courtLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.courtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtLbl.ForeColor = this.ForeColor;
			this.courtLbl.Location = new System.Drawing.Point(0, 0);
			this.courtLbl.Name = "courtLbl";
			this.courtLbl.Size = new System.Drawing.Size(351, 23);
			this.courtLbl.TabIndex = 0;
			this.courtLbl.Text = "Court Lookup";
			this.courtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// county
			// 
			this.county.FormattingEnabled = true;
			this.county.Location = new System.Drawing.Point(141, 26);
			this.county.Name = "county";
			this.county.Size = new System.Drawing.Size(121, 21);
			this.county.TabIndex = 1;
			this.county.SelectedIndexChanged += new System.EventHandler(this.CountySelectedIndexChanged);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(141, 53);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(121, 20);
			this.searchBox.TabIndex = 2;
			this.searchBox.TextChanged += new System.EventHandler(this.SearchBoxTextChanged);
			// 
			// countyLbl
			// 
			this.countyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countyLbl.Location = new System.Drawing.Point(71, 26);
			this.countyLbl.Name = "countyLbl";
			this.countyLbl.Size = new System.Drawing.Size(64, 23);
			this.countyLbl.TabIndex = 4;
			this.countyLbl.Text = "County:";
			// 
			// searchLbl
			// 
			this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchLbl.Location = new System.Drawing.Point(71, 53);
			this.searchLbl.Name = "searchLbl";
			this.searchLbl.Size = new System.Drawing.Size(64, 23);
			this.searchLbl.TabIndex = 5;
			this.searchLbl.Text = "Search:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = this.BackColor;
			this.pictureBox1.Location = new System.Drawing.Point(0, 78);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(352, 7);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(293, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "DONE";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// courtNameLbl
			// 
			this.courtNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtNameLbl.Location = new System.Drawing.Point(71, 88);
			this.courtNameLbl.Name = "courtNameLbl";
			this.courtNameLbl.Size = new System.Drawing.Size(53, 18);
			this.courtNameLbl.TabIndex = 8;
			this.courtNameLbl.Text = "Court:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = this.BackColor;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.GridColor = this.BackColor;
			this.dataGridView1.Location = new System.Drawing.Point(71, 109);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = this.BackColor;//System.Drawing.SystemColors.Control;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = this.ForeColor;//System.Drawing.SystemColors.ControlText;
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = this.BackColor;//System.Drawing.SystemColors.Control;
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = this.ForeColor;//System.Drawing.SystemColors.ControlText;
			this.dataGridView1.Size = new System.Drawing.Size(216, 325);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// CourtLookup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 446);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.courtNameLbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.searchLbl);
			this.Controls.Add(this.countyLbl);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.county);
			this.Controls.Add(this.courtLbl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CourtLookup";
			this.Text = "CourtLookup";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label courtNameLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label searchLbl;
		private System.Windows.Forms.Label countyLbl;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.ComboBox county;
		private System.Windows.Forms.Label courtLbl;
	}
}
