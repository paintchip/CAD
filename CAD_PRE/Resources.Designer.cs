/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/25/2015
 * Time: 1:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Resources : baseform
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resources));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PARKSLbl = new System.Windows.Forms.LinkLabel();
			this.RefLbl = new System.Windows.Forms.LinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SSG_lbl = new System.Windows.Forms.Label();
			this.Member_Contacts_lbl = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Central_Guide_btn = new System.Windows.Forms.Button();
			this.TI_Guide_btn = new System.Windows.Forms.Button();
			this.FL_Guide_btn = new System.Windows.Forms.Button();
			this.Guide_Covers_lbl = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.Cen_Member_btn = new System.Windows.Forms.Button();
			this.TI_Member_btn = new System.Windows.Forms.Button();
			this.FL_Member_btn = new System.Windows.Forms.Button();
			this.Combined_Member_btn = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.Agency_Guide_btn = new System.Windows.Forms.Button();
			this.Hazmat_lbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(374, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(80, 80);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Additional Resources";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// PARKSLbl
			// 
			this.PARKSLbl.BackColor = this.BackColor;
			this.PARKSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PARKSLbl.LinkColor = this.ForeColor;
			this.PARKSLbl.Location = new System.Drawing.Point(86, 41);
			this.PARKSLbl.Name = "PARKSLbl";
			this.PARKSLbl.Size = new System.Drawing.Size(76, 23);
			this.PARKSLbl.TabIndex = 3;
			this.PARKSLbl.TabStop = true;
			this.PARKSLbl.Tag = "PARKSLbl";
			this.PARKSLbl.Text = "PARKS";
			this.PARKSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.PARKSLbl, "Open PARKS");
			this.PARKSLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// RefLbl
			// 
			this.RefLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefLbl.BackColor = this.BackColor;
			this.RefLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RefLbl.LinkColor = this.ForeColor;
			this.RefLbl.Location = new System.Drawing.Point(235, 41);
			this.RefLbl.Name = "RefLbl";
			this.RefLbl.Size = new System.Drawing.Size(133, 23);
			this.RefLbl.TabIndex = 4;
			this.RefLbl.TabStop = true;
			this.RefLbl.Tag = "RefLbl";
			this.RefLbl.Text = "Online References";
			this.RefLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.RefLbl, "Open NYSPP Online References");
			this.RefLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// SSG_lbl
			// 
			this.SSG_lbl.Location = new System.Drawing.Point(12, 95);
			this.SSG_lbl.Name = "SSG_lbl";
			this.SSG_lbl.Size = new System.Drawing.Size(106, 16);
			this.SSG_lbl.TabIndex = 5;
			this.SSG_lbl.Text = "Shift Sheet Genrator";
			this.SSG_lbl.Click += new System.EventHandler(this.SSG_lblClick);
			// 
			// Member_Contacts_lbl
			// 
			this.Member_Contacts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Member_Contacts_lbl.Location = new System.Drawing.Point(241, 192);
			this.Member_Contacts_lbl.Name = "Member_Contacts_lbl";
			this.Member_Contacts_lbl.Size = new System.Drawing.Size(120, 16);
			this.Member_Contacts_lbl.TabIndex = 6;
			this.Member_Contacts_lbl.Text = "Member Contacts";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(230, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 68);
			this.panel1.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(234, 169);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(134, 5);
			this.panel2.TabIndex = 8;
			// 
			// Central_Guide_btn
			// 
			this.Central_Guide_btn.ForeColor = System.Drawing.Color.Black;
			this.Central_Guide_btn.Location = new System.Drawing.Point(241, 140);
			this.Central_Guide_btn.Name = "Central_Guide_btn";
			this.Central_Guide_btn.Size = new System.Drawing.Size(35, 23);
			this.Central_Guide_btn.TabIndex = 8;
			this.Central_Guide_btn.Text = "Cen";
			this.Central_Guide_btn.UseVisualStyleBackColor = true;
			this.Central_Guide_btn.Click += new System.EventHandler(this.Central_Guide_btnClick);
			// 
			// TI_Guide_btn
			// 
			this.TI_Guide_btn.ForeColor = System.Drawing.Color.Black;
			this.TI_Guide_btn.Location = new System.Drawing.Point(282, 140);
			this.TI_Guide_btn.Name = "TI_Guide_btn";
			this.TI_Guide_btn.Size = new System.Drawing.Size(35, 23);
			this.TI_Guide_btn.TabIndex = 9;
			this.TI_Guide_btn.Text = "TI";
			this.TI_Guide_btn.UseVisualStyleBackColor = true;
			this.TI_Guide_btn.Click += new System.EventHandler(this.TI_Guide_btnClick);
			// 
			// FL_Guide_btn
			// 
			this.FL_Guide_btn.ForeColor = System.Drawing.Color.Black;
			this.FL_Guide_btn.Location = new System.Drawing.Point(326, 140);
			this.FL_Guide_btn.Name = "FL_Guide_btn";
			this.FL_Guide_btn.Size = new System.Drawing.Size(35, 23);
			this.FL_Guide_btn.TabIndex = 10;
			this.FL_Guide_btn.Text = "FL";
			this.FL_Guide_btn.UseVisualStyleBackColor = true;
			this.FL_Guide_btn.Click += new System.EventHandler(this.FL_Guide_btnClick);
			// 
			// Guide_Covers_lbl
			// 
			this.Guide_Covers_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Guide_Covers_lbl.Location = new System.Drawing.Point(246, 114);
			this.Guide_Covers_lbl.Name = "Guide_Covers_lbl";
			this.Guide_Covers_lbl.Size = new System.Drawing.Size(115, 23);
			this.Guide_Covers_lbl.TabIndex = 11;
			this.Guide_Covers_lbl.Text = "Guide Covers";
			this.Guide_Covers_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(367, 106);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(5, 68);
			this.panel3.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(235, 106);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(133, 5);
			this.panel4.TabIndex = 13;
			// 
			// panel5
			// 
			this.panel5.Location = new System.Drawing.Point(230, 184);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(142, 5);
			this.panel5.TabIndex = 14;
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(230, 189);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(5, 106);
			this.panel6.TabIndex = 15;
			// 
			// panel7
			// 
			this.panel7.Location = new System.Drawing.Point(367, 184);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(5, 111);
			this.panel7.TabIndex = 16;
			// 
			// Cen_Member_btn
			// 
			this.Cen_Member_btn.ForeColor = System.Drawing.Color.Black;
			this.Cen_Member_btn.Location = new System.Drawing.Point(241, 218);
			this.Cen_Member_btn.Name = "Cen_Member_btn";
			this.Cen_Member_btn.Size = new System.Drawing.Size(35, 23);
			this.Cen_Member_btn.TabIndex = 18;
			this.Cen_Member_btn.Text = "Cen";
			this.Cen_Member_btn.UseVisualStyleBackColor = true;
			this.Cen_Member_btn.Click += new System.EventHandler(this.Cen_Member_btnClick);
			// 
			// TI_Member_btn
			// 
			this.TI_Member_btn.ForeColor = System.Drawing.Color.Black;
			this.TI_Member_btn.Location = new System.Drawing.Point(282, 218);
			this.TI_Member_btn.Name = "TI_Member_btn";
			this.TI_Member_btn.Size = new System.Drawing.Size(35, 23);
			this.TI_Member_btn.TabIndex = 19;
			this.TI_Member_btn.Text = "TI";
			this.TI_Member_btn.UseVisualStyleBackColor = true;
			this.TI_Member_btn.Click += new System.EventHandler(this.TI_Member_btnClick);
			// 
			// FL_Member_btn
			// 
			this.FL_Member_btn.ForeColor = System.Drawing.Color.Black;
			this.FL_Member_btn.Location = new System.Drawing.Point(326, 218);
			this.FL_Member_btn.Name = "FL_Member_btn";
			this.FL_Member_btn.Size = new System.Drawing.Size(35, 23);
			this.FL_Member_btn.TabIndex = 20;
			this.FL_Member_btn.Text = "FL";
			this.FL_Member_btn.UseVisualStyleBackColor = true;
			this.FL_Member_btn.Click += new System.EventHandler(this.FL_Member_btnClick);
			// 
			// Combined_Member_btn
			// 
			this.Combined_Member_btn.ForeColor = System.Drawing.Color.Black;
			this.Combined_Member_btn.Location = new System.Drawing.Point(241, 247);
			this.Combined_Member_btn.Name = "Combined_Member_btn";
			this.Combined_Member_btn.Size = new System.Drawing.Size(119, 22);
			this.Combined_Member_btn.TabIndex = 21;
			this.Combined_Member_btn.Text = "Combined Phones";
			this.Combined_Member_btn.UseVisualStyleBackColor = true;
			this.Combined_Member_btn.Click += new System.EventHandler(this.Combined_Member_btnClick);
			// 
			// panel8
			// 
			this.panel8.Location = new System.Drawing.Point(230, 295);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(142, 5);
			this.panel8.TabIndex = 22;
			// 
			// Agency_Guide_btn
			// 
			this.Agency_Guide_btn.ForeColor = System.Drawing.Color.Black;
			this.Agency_Guide_btn.Location = new System.Drawing.Point(241, 270);
			this.Agency_Guide_btn.Name = "Agency_Guide_btn";
			this.Agency_Guide_btn.Size = new System.Drawing.Size(119, 22);
			this.Agency_Guide_btn.TabIndex = 23;
			this.Agency_Guide_btn.Text = "Agency Directory";
			this.Agency_Guide_btn.UseVisualStyleBackColor = true;
			this.Agency_Guide_btn.Click += new System.EventHandler(this.Agency_Guide_btnClick);
			// 
			// Hazmat_lbl
			// 
			this.Hazmat_lbl.Location = new System.Drawing.Point(12, 116);
			this.Hazmat_lbl.Name = "Hazmat_lbl";
			this.Hazmat_lbl.Size = new System.Drawing.Size(106, 16);
			this.Hazmat_lbl.TabIndex = 24;
			this.Hazmat_lbl.Text = "Hazmat Search";
			this.Hazmat_lbl.Click += new System.EventHandler(this.Hazmat_lblClick);
			// 
			// Resources
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 353);
			this.Controls.Add(this.Hazmat_lbl);
			this.Controls.Add(this.Agency_Guide_btn);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.Combined_Member_btn);
			this.Controls.Add(this.FL_Member_btn);
			this.Controls.Add(this.TI_Member_btn);
			this.Controls.Add(this.Cen_Member_btn);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Guide_Covers_lbl);
			this.Controls.Add(this.FL_Guide_btn);
			this.Controls.Add(this.TI_Guide_btn);
			this.Controls.Add(this.Central_Guide_btn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Member_Contacts_lbl);
			this.Controls.Add(this.SSG_lbl);
			this.Controls.Add(this.RefLbl);
			this.Controls.Add(this.PARKSLbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Resources";
			this.Text = "Additional Resources";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResourcesKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ResourcesKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Hazmat_lbl;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button Agency_Guide_btn;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button Cen_Member_btn;
		private System.Windows.Forms.Button TI_Member_btn;
		private System.Windows.Forms.Button FL_Member_btn;
		private System.Windows.Forms.Button Combined_Member_btn;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Central_Guide_btn;
		private System.Windows.Forms.Button TI_Guide_btn;
		private System.Windows.Forms.Button FL_Guide_btn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label Guide_Covers_lbl;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label Member_Contacts_lbl;
		private System.Windows.Forms.Label SSG_lbl;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.LinkLabel RefLbl;
		private System.Windows.Forms.LinkLabel PARKSLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
