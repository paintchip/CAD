/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/23/2015
 * Time: 1:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class CourtInfo : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourtInfo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.courtLbl = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.countyLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.county = new System.Windows.Forms.TextBox();
			this.mail_addy = new System.Windows.Forms.TextBox();
			this.phy_addy = new System.Windows.Forms.TextBox();
			this.CTV1 = new System.Windows.Forms.TextBox();
			this.courtPhoneLbl = new System.Windows.Forms.Label();
			this.courtFaxLbl = new System.Windows.Forms.Label();
			this.court_phone = new System.Windows.Forms.TextBox();
			this.court_fax = new System.Windows.Forms.TextBox();
			this.locCodeLbl = new System.Windows.Forms.Label();
			this.loc_code = new System.Windows.Forms.TextBox();
			this.oriLbl = new System.Windows.Forms.Label();
			this.court_ori = new System.Windows.Forms.TextBox();
			this.courtNotesLbl = new System.Windows.Forms.Label();
			this.court_notes = new System.Windows.Forms.TextBox();
			this.justicesLbl = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ClerkLbl = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// courtLbl
			// 
			this.courtLbl.BackColor = System.Drawing.Color.Transparent;
			this.courtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtLbl.ForeColor = this.ForeColor;
			this.courtLbl.Location = new System.Drawing.Point(12, 9);
			this.courtLbl.Name = "courtLbl";
			this.courtLbl.Size = new System.Drawing.Size(75, 20);
			this.courtLbl.TabIndex = 0;
			this.courtLbl.Tag = "courtLbl";
			this.courtLbl.Text = "Court Info";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(573, 43);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// countyLbl
			// 
			this.countyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countyLbl.Location = new System.Drawing.Point(12, 46);
			this.countyLbl.Name = "countyLbl";
			this.countyLbl.Size = new System.Drawing.Size(75, 17);
			this.countyLbl.TabIndex = 2;
			this.countyLbl.Text = "County";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(118, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mailing Address";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = this.ForeColor;
			this.label2.Location = new System.Drawing.Point(324, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Physical Address";
			// 
			// county
			// 
			this.county.BackColor = System.Drawing.Color.White;
			this.county.ForeColor = System.Drawing.Color.Black;
			this.county.Location = new System.Drawing.Point(12, 66);
			this.county.Name = "county";
			this.county.Size = new System.Drawing.Size(98, 20);
			this.county.TabIndex = 5;
			this.county.Tag = "county";
			// 
			// mail_addy
			// 
			this.mail_addy.BackColor = System.Drawing.Color.White;
			this.mail_addy.ForeColor = System.Drawing.Color.Black;
			this.mail_addy.Location = new System.Drawing.Point(118, 66);
			this.mail_addy.Name = "mail_addy";
			this.mail_addy.Size = new System.Drawing.Size(200, 20);
			this.mail_addy.TabIndex = 6;
			this.mail_addy.Tag = "mail_addy";
			// 
			// phy_addy
			// 
			this.phy_addy.BackColor = System.Drawing.Color.White;
			this.phy_addy.ForeColor = System.Drawing.Color.Black;
			this.phy_addy.Location = new System.Drawing.Point(324, 66);
			this.phy_addy.Multiline = true;
			this.phy_addy.Name = "phy_addy";
			this.phy_addy.Size = new System.Drawing.Size(193, 46);
			this.phy_addy.TabIndex = 7;
			this.phy_addy.Tag = "phy_addy";
			// 
			// CTV1
			// 
			this.CTV1.BackColor = System.Drawing.Color.White;
			this.CTV1.ForeColor = System.Drawing.Color.Black;
			this.CTV1.Location = new System.Drawing.Point(118, 92);
			this.CTV1.Name = "CTV1";
			this.CTV1.Size = new System.Drawing.Size(200, 20);
			this.CTV1.TabIndex = 8;
			this.CTV1.Tag = "CTV1";
			// 
			// courtPhoneLbl
			// 
			this.courtPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtPhoneLbl.ForeColor = this.ForeColor;
			this.courtPhoneLbl.Location = new System.Drawing.Point(12, 115);
			this.courtPhoneLbl.Name = "courtPhoneLbl";
			this.courtPhoneLbl.Size = new System.Drawing.Size(98, 17);
			this.courtPhoneLbl.TabIndex = 10;
			this.courtPhoneLbl.Text = "Court Phone";
			// 
			// courtFaxLbl
			// 
			this.courtFaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtFaxLbl.ForeColor = this.ForeColor;
			this.courtFaxLbl.Location = new System.Drawing.Point(145, 115);
			this.courtFaxLbl.Name = "courtFaxLbl";
			this.courtFaxLbl.Size = new System.Drawing.Size(98, 17);
			this.courtFaxLbl.TabIndex = 11;
			this.courtFaxLbl.Text = "Court Fax";
			// 
			// court_phone
			// 
			this.court_phone.BackColor = System.Drawing.Color.White;
			this.court_phone.ForeColor = System.Drawing.Color.Black;
			this.court_phone.Location = new System.Drawing.Point(12, 135);
			this.court_phone.Name = "court_phone";
			this.court_phone.Size = new System.Drawing.Size(127, 20);
			this.court_phone.TabIndex = 12;
			this.court_phone.Tag = "court_phone";
			// 
			// court_fax
			// 
			this.court_fax.BackColor = System.Drawing.Color.White;
			this.court_fax.ForeColor = System.Drawing.Color.Black;
			this.court_fax.Location = new System.Drawing.Point(145, 135);
			this.court_fax.Name = "court_fax";
			this.court_fax.Size = new System.Drawing.Size(127, 20);
			this.court_fax.TabIndex = 13;
			this.court_fax.Tag = "court_fax";
			// 
			// locCodeLbl
			// 
			this.locCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locCodeLbl.ForeColor = this.ForeColor;
			this.locCodeLbl.Location = new System.Drawing.Point(305, 115);
			this.locCodeLbl.Name = "locCodeLbl";
			this.locCodeLbl.Size = new System.Drawing.Size(85, 17);
			this.locCodeLbl.TabIndex = 14;
			this.locCodeLbl.Text = "Loc Code";
			// 
			// loc_code
			// 
			this.loc_code.BackColor = System.Drawing.Color.White;
			this.loc_code.ForeColor = System.Drawing.Color.Black;
			this.loc_code.Location = new System.Drawing.Point(305, 135);
			this.loc_code.Name = "loc_code";
			this.loc_code.Size = new System.Drawing.Size(85, 20);
			this.loc_code.TabIndex = 15;
			this.loc_code.Tag = "loc_code";
			// 
			// oriLbl
			// 
			this.oriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oriLbl.ForeColor = this.ForeColor;
			this.oriLbl.Location = new System.Drawing.Point(396, 115);
			this.oriLbl.Name = "oriLbl";
			this.oriLbl.Size = new System.Drawing.Size(98, 17);
			this.oriLbl.TabIndex = 16;
			this.oriLbl.Text = "Court ORI";
			// 
			// court_ori
			// 
			this.court_ori.BackColor = System.Drawing.Color.White;
			this.court_ori.ForeColor = System.Drawing.Color.Black;
			this.court_ori.Location = new System.Drawing.Point(396, 135);
			this.court_ori.Name = "court_ori";
			this.court_ori.Size = new System.Drawing.Size(121, 20);
			this.court_ori.TabIndex = 17;
			this.court_ori.Tag = "court_ori";
			// 
			// courtNotesLbl
			// 
			this.courtNotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.courtNotesLbl.ForeColor = this.ForeColor;
			this.courtNotesLbl.Location = new System.Drawing.Point(12, 158);
			this.courtNotesLbl.Name = "courtNotesLbl";
			this.courtNotesLbl.Size = new System.Drawing.Size(98, 17);
			this.courtNotesLbl.TabIndex = 18;
			this.courtNotesLbl.Text = "Court Notes";
			// 
			// court_notes
			// 
			this.court_notes.BackColor = System.Drawing.Color.White;
			this.court_notes.ForeColor = System.Drawing.Color.Black;
			this.court_notes.Location = new System.Drawing.Point(12, 178);
			this.court_notes.Multiline = true;
			this.court_notes.Name = "court_notes";
			this.court_notes.Size = new System.Drawing.Size(505, 51);
			this.court_notes.TabIndex = 19;
			this.court_notes.Tag = "court_notes";
			// 
			// justicesLbl
			// 
			this.justicesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.justicesLbl.ForeColor = this.ForeColor;
			this.justicesLbl.Location = new System.Drawing.Point(12, 232);
			this.justicesLbl.Name = "justicesLbl";
			this.justicesLbl.Size = new System.Drawing.Size(98, 17);
			this.justicesLbl.TabIndex = 20;
			this.justicesLbl.Text = "Justices";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView2.BackgroundColor = this.BackColor;
			this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView2.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView2.GridColor = this.BackColor;
			this.dataGridView2.Location = new System.Drawing.Point(24, 363);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
			this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
			this.dataGridView2.Size = new System.Drawing.Size(549, 109);
			this.dataGridView2.TabIndex = 23;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// ClerkLbl
			// 
			this.ClerkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClerkLbl.ForeColor = this.ForeColor;
			this.ClerkLbl.Location = new System.Drawing.Point(12, 343);
			this.ClerkLbl.Name = "ClerkLbl";
			this.ClerkLbl.Size = new System.Drawing.Size(98, 17);
			this.ClerkLbl.TabIndex = 22;
			this.ClerkLbl.Text = "Clerks";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = this.BackColor;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.GridColor = this.BackColor;
			this.dataGridView1.Location = new System.Drawing.Point(12, 248);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Size = new System.Drawing.Size(549, 92);
			this.dataGridView1.TabIndex = 24;
			// 
			// CourtInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 484);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.ClerkLbl);
			this.Controls.Add(this.justicesLbl);
			this.Controls.Add(this.court_notes);
			this.Controls.Add(this.courtNotesLbl);
			this.Controls.Add(this.court_ori);
			this.Controls.Add(this.oriLbl);
			this.Controls.Add(this.loc_code);
			this.Controls.Add(this.locCodeLbl);
			this.Controls.Add(this.court_fax);
			this.Controls.Add(this.court_phone);
			this.Controls.Add(this.courtFaxLbl);
			this.Controls.Add(this.courtPhoneLbl);
			this.Controls.Add(this.CTV1);
			this.Controls.Add(this.phy_addy);
			this.Controls.Add(this.mail_addy);
			this.Controls.Add(this.county);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countyLbl);
			this.Controls.Add(this.courtLbl);
			this.Controls.Add(this.pictureBox1);
			this.MinimumSize = new System.Drawing.Size(589, 475);
			this.Name = "CourtInfo";
			this.Text = "CourtInfo";
			this.Load += new System.EventHandler(this.CourtInfoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label ClerkLbl;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label justicesLbl;
		private System.Windows.Forms.TextBox court_notes;
		private System.Windows.Forms.Label courtNotesLbl;
		private System.Windows.Forms.TextBox court_ori;
		private System.Windows.Forms.Label oriLbl;
		private System.Windows.Forms.TextBox loc_code;
		private System.Windows.Forms.Label locCodeLbl;
		private System.Windows.Forms.TextBox court_fax;
		private System.Windows.Forms.TextBox court_phone;
		private System.Windows.Forms.Label courtFaxLbl;
		private System.Windows.Forms.Label courtPhoneLbl;
		private System.Windows.Forms.TextBox CTV1;
		private System.Windows.Forms.TextBox phy_addy;
		private System.Windows.Forms.TextBox mail_addy;
		private System.Windows.Forms.TextBox county;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label countyLbl;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label courtLbl;
	}
}
