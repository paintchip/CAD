/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 9/4/2015
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class ContactForm : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Addy_2 = new System.Windows.Forms.TextBox();
			this.Addy_1 = new System.Windows.Forms.TextBox();
			this.Station = new System.Windows.Forms.TextBox();
			this.NameFld = new System.Windows.Forms.TextBox();
			this.Shield = new System.Windows.Forms.TextBox();
			this.Rank = new System.Windows.Forms.TextBox();
			this.Phone_1 = new System.Windows.Forms.TextBox();
			this.Phone_2 = new System.Windows.Forms.TextBox();
			this.Phone_3 = new System.Windows.Forms.TextBox();
			this.EmailAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 29);
			this.label1.TabIndex = 0;
			this.label1.Tag = "";
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 29);
			this.label2.TabIndex = 1;
			this.label2.Tag = "";
			this.label2.Text = "Shield";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 29);
			this.label3.TabIndex = 2;
			this.label3.Tag = "";
			this.label3.Text = "Rank";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 29);
			this.label4.TabIndex = 3;
			this.label4.Tag = "";
			this.label4.Text = "Location";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 29);
			this.label5.TabIndex = 4;
			this.label5.Tag = "";
			this.label5.Text = "Address Line 1";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 29);
			this.label6.TabIndex = 5;
			this.label6.Tag = "";
			this.label6.Text = "Address Line 2";
			// 
			// Addy_2
			// 
			this.Addy_2.Location = new System.Drawing.Point(137, 154);
			this.Addy_2.Name = "Addy_2";
			this.Addy_2.Size = new System.Drawing.Size(173, 20);
			this.Addy_2.TabIndex = 6;
			this.Addy_2.Tag = "Addy_2";
			// 
			// Addy_1
			// 
			this.Addy_1.Location = new System.Drawing.Point(137, 125);
			this.Addy_1.Name = "Addy_1";
			this.Addy_1.Size = new System.Drawing.Size(173, 20);
			this.Addy_1.TabIndex = 7;
			this.Addy_1.Tag = "Addy_1";
			// 
			// Station
			// 
			this.Station.Location = new System.Drawing.Point(137, 96);
			this.Station.Name = "Station";
			this.Station.Size = new System.Drawing.Size(173, 20);
			this.Station.TabIndex = 8;
			this.Station.Tag = "Station";
			// 
			// NameFld
			// 
			this.NameFld.Location = new System.Drawing.Point(137, 9);
			this.NameFld.Name = "NameFld";
			this.NameFld.Size = new System.Drawing.Size(173, 20);
			this.NameFld.TabIndex = 11;
			this.NameFld.Tag = "Name";
			// 
			// Shield
			// 
			this.Shield.Location = new System.Drawing.Point(137, 38);
			this.Shield.Name = "Shield";
			this.Shield.Size = new System.Drawing.Size(173, 20);
			this.Shield.TabIndex = 10;
			this.Shield.Tag = "Shield";
			// 
			// Rank
			// 
			this.Rank.Location = new System.Drawing.Point(137, 67);
			this.Rank.Name = "Rank";
			this.Rank.Size = new System.Drawing.Size(173, 20);
			this.Rank.TabIndex = 9;
			this.Rank.Tag = "Rank";
			// 
			// Phone_1
			// 
			this.Phone_1.Location = new System.Drawing.Point(398, 9);
			this.Phone_1.Name = "Phone_1";
			this.Phone_1.Size = new System.Drawing.Size(173, 20);
			this.Phone_1.TabIndex = 19;
			this.Phone_1.Tag = "Phone_1";
			// 
			// Phone_2
			// 
			this.Phone_2.Location = new System.Drawing.Point(398, 38);
			this.Phone_2.Name = "Phone_2";
			this.Phone_2.Size = new System.Drawing.Size(173, 20);
			this.Phone_2.TabIndex = 18;
			this.Phone_2.Tag = "Phone_2";
			// 
			// Phone_3
			// 
			this.Phone_3.Location = new System.Drawing.Point(398, 67);
			this.Phone_3.Name = "Phone_3";
			this.Phone_3.Size = new System.Drawing.Size(173, 20);
			this.Phone_3.TabIndex = 17;
			this.Phone_3.Tag = "Phone_3";
			// 
			// EmailAddress
			// 
			this.EmailAddress.Location = new System.Drawing.Point(398, 96);
			this.EmailAddress.Name = "EmailAddress";
			this.EmailAddress.Size = new System.Drawing.Size(173, 20);
			this.EmailAddress.TabIndex = 16;
			this.EmailAddress.Tag = "EmailAddress";
			this.EmailAddress.Click += new System.EventHandler(this.EmailClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(316, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 29);
			this.label7.TabIndex = 15;
			this.label7.Tag = "";
			this.label7.Text = "Email";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(316, 67);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 29);
			this.label8.TabIndex = 14;
			this.label8.Tag = "";
			this.label8.Text = "Phone 3";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(316, 38);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 29);
			this.label9.TabIndex = 13;
			this.label9.Tag = "";
			this.label9.Text = "Phone 2";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(316, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 29);
			this.label10.TabIndex = 12;
			this.label10.Tag = "";
			this.label10.Text = "Phone 1";
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 184);
			this.Controls.Add(this.Phone_1);
			this.Controls.Add(this.Phone_2);
			this.Controls.Add(this.Phone_3);
			this.Controls.Add(this.EmailAddress);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.NameFld);
			this.Controls.Add(this.Shield);
			this.Controls.Add(this.Rank);
			this.Controls.Add(this.Station);
			this.Controls.Add(this.Addy_1);
			this.Controls.Add(this.Addy_2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ContactForm";
			this.Text = "ContactForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox EmailAddress;
		private System.Windows.Forms.TextBox Phone_3;
		private System.Windows.Forms.TextBox Phone_2;
		private System.Windows.Forms.TextBox Phone_1;
		private System.Windows.Forms.TextBox Rank;
		private System.Windows.Forms.TextBox Shield;
		private System.Windows.Forms.TextBox NameFld;
		private System.Windows.Forms.TextBox Station;
		private System.Windows.Forms.TextBox Addy_1;
		private System.Windows.Forms.TextBox Addy_2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
