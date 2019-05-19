/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 12/31/2015
 * Time: 6:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Closed_Events
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
			this.EvtDatagrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.EvtDatagrid)).BeginInit();
			this.SuspendLayout();
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
			this.EvtDatagrid.Location = new System.Drawing.Point(0, 3);
			this.EvtDatagrid.Name = "EvtDatagrid";
			this.EvtDatagrid.RowHeadersVisible = false;
			this.EvtDatagrid.Size = new System.Drawing.Size(605, 379);
			this.EvtDatagrid.TabIndex = 10;
			this.EvtDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EvtDatagridCellContentClick);
			this.EvtDatagrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridCellPainting);
			// 
			// Closed_Events
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 384);
			this.Controls.Add(this.EvtDatagrid);
			this.Name = "Closed_Events";
			this.Text = "Closed_Events";
			this.Load += new System.EventHandler(this.Closed_EventsLoad);
			((System.ComponentModel.ISupportInitialize)(this.EvtDatagrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView EvtDatagrid;
	}
}
