﻿/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/18/2015
 * Time: 8:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */ 
namespace NYSPP_CAD
{
	partial class ComponentForm : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentForm));
			this.SuspendLayout();
			// 
			// ComponentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 380);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ComponentForm";
			this.Text = "ComponentForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComponentFormFormClosed);
			this.ResumeLayout(false);
		}
	}
}
