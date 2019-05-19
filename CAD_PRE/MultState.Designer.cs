/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/12/2015
 * Time: 10:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class MultState
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
			this.Search_Box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Selected = new System.Windows.Forms.TextBox();
			this.SelectedLbl = new System.Windows.Forms.Label();
			this.ClearLbl = new System.Windows.Forms.Label();
			this.RemoveLbl = new System.Windows.Forms.Label();
			this.DoneLbl = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Search_Box
			// 
			this.Search_Box.Location = new System.Drawing.Point(120, 9);
			this.Search_Box.Name = "Search_Box";
			this.Search_Box.Size = new System.Drawing.Size(100, 20);
			this.Search_Box.TabIndex = 0;
			this.Search_Box.TextChanged += new System.EventHandler(this.Search_BoxTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search:";
			// 
			// Selected
			// 
			this.Selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Selected.Location = new System.Drawing.Point(120, 38);
			this.Selected.Name = "Selected";
			this.Selected.Size = new System.Drawing.Size(100, 13);
			this.Selected.TabIndex = 2;
			// 
			// SelectedLbl
			// 
			this.SelectedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectedLbl.Location = new System.Drawing.Point(12, 36);
			this.SelectedLbl.Name = "SelectedLbl";
			this.SelectedLbl.Size = new System.Drawing.Size(102, 19);
			this.SelectedLbl.TabIndex = 3;
			this.SelectedLbl.Text = "Selected (0/5):";
			// 
			// ClearLbl
			// 
			this.ClearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearLbl.Location = new System.Drawing.Point(267, 10);
			this.ClearLbl.Name = "ClearLbl";
			this.ClearLbl.Size = new System.Drawing.Size(46, 15);
			this.ClearLbl.TabIndex = 4;
			this.ClearLbl.Text = "clear";
			this.ClearLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClearLbl.Click += new System.EventHandler(this.LblClick);
			// 
			// RemoveLbl
			// 
			this.RemoveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemoveLbl.Location = new System.Drawing.Point(256, 25);
			this.RemoveLbl.Name = "RemoveLbl";
			this.RemoveLbl.Size = new System.Drawing.Size(57, 16);
			this.RemoveLbl.TabIndex = 5;
			this.RemoveLbl.Text = "remove all";
			this.RemoveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.RemoveLbl.Click += new System.EventHandler(this.LblClick);
			// 
			// DoneLbl
			// 
			this.DoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoneLbl.Location = new System.Drawing.Point(256, 38);
			this.DoneLbl.Name = "DoneLbl";
			this.DoneLbl.Size = new System.Drawing.Size(57, 16);
			this.DoneLbl.TabIndex = 6;
			this.DoneLbl.Text = "DONE";
			this.DoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DoneLbl.Click += new System.EventHandler(this.LblClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
			this.pictureBox1.Location = new System.Drawing.Point(12, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(301, 7);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(326, 293);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MultState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 378);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.DoneLbl);
			this.Controls.Add(this.RemoveLbl);
			this.Controls.Add(this.ClearLbl);
			this.Controls.Add(this.SelectedLbl);
			this.Controls.Add(this.Selected);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Search_Box);
			this.Name = "MultState";
			this.Text = "MultState";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label DoneLbl;
		private System.Windows.Forms.Label RemoveLbl;
		private System.Windows.Forms.Label ClearLbl;
		private System.Windows.Forms.Label SelectedLbl;
		private System.Windows.Forms.TextBox Selected;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Search_Box;
	}
}
