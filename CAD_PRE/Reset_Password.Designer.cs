/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 10/14/2015
 * Time: 4:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Reset_Password
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
			this.Password_reset_lbl = new System.Windows.Forms.Label();
			this.Password_reset_user_lbl = new System.Windows.Forms.Label();
			this.Password_reset_user_fld = new System.Windows.Forms.TextBox();
			this.Password_reset_email_lbl = new System.Windows.Forms.Label();
			this.Password_reset_email_fld = new System.Windows.Forms.TextBox();
			this.Pass_reset_btn = new System.Windows.Forms.Button();
			this.Pass_reset_cancel_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Password_reset_lbl
			// 
			this.Password_reset_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_reset_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Password_reset_lbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Password_reset_lbl.Location = new System.Drawing.Point(12, 9);
			this.Password_reset_lbl.Name = "Password_reset_lbl";
			this.Password_reset_lbl.Size = new System.Drawing.Size(233, 32);
			this.Password_reset_lbl.TabIndex = 0;
			this.Password_reset_lbl.Text = "Password Reset";
			this.Password_reset_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Password_reset_user_lbl
			// 
			this.Password_reset_user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_reset_user_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Password_reset_user_lbl.Location = new System.Drawing.Point(37, 41);
			this.Password_reset_user_lbl.Name = "Password_reset_user_lbl";
			this.Password_reset_user_lbl.Size = new System.Drawing.Size(100, 23);
			this.Password_reset_user_lbl.TabIndex = 1;
			this.Password_reset_user_lbl.Text = "Username:";
			this.Password_reset_user_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Password_reset_user_fld
			// 
			this.Password_reset_user_fld.Location = new System.Drawing.Point(37, 67);
			this.Password_reset_user_fld.Name = "Password_reset_user_fld";
			this.Password_reset_user_fld.Size = new System.Drawing.Size(148, 20);
			this.Password_reset_user_fld.TabIndex = 2;
			// 
			// Password_reset_email_lbl
			// 
			this.Password_reset_email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_reset_email_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Password_reset_email_lbl.Location = new System.Drawing.Point(37, 88);
			this.Password_reset_email_lbl.Name = "Password_reset_email_lbl";
			this.Password_reset_email_lbl.Size = new System.Drawing.Size(100, 23);
			this.Password_reset_email_lbl.TabIndex = 3;
			this.Password_reset_email_lbl.Text = "E-mail:";
			this.Password_reset_email_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Password_reset_email_fld
			// 
			this.Password_reset_email_fld.Location = new System.Drawing.Point(37, 114);
			this.Password_reset_email_fld.Name = "Password_reset_email_fld";
			this.Password_reset_email_fld.Size = new System.Drawing.Size(148, 20);
			this.Password_reset_email_fld.TabIndex = 4;
			// 
			// Pass_reset_btn
			// 
			this.Pass_reset_btn.ForeColor = System.Drawing.Color.Black;
			this.Pass_reset_btn.Location = new System.Drawing.Point(37, 168);
			this.Pass_reset_btn.Name = "Pass_reset_btn";
			this.Pass_reset_btn.Size = new System.Drawing.Size(75, 23);
			this.Pass_reset_btn.TabIndex = 5;
			this.Pass_reset_btn.Text = "Reset";
			this.Pass_reset_btn.UseVisualStyleBackColor = true;
			this.Pass_reset_btn.Click += new System.EventHandler(this.Pass_reset_btnClick);
			// 
			// Pass_reset_cancel_btn
			// 
			this.Pass_reset_cancel_btn.Location = new System.Drawing.Point(138, 168);
			this.Pass_reset_cancel_btn.Name = "Pass_reset_cancel_btn";
			this.Pass_reset_cancel_btn.Size = new System.Drawing.Size(75, 23);
			this.Pass_reset_cancel_btn.TabIndex = 6;
			this.Pass_reset_cancel_btn.Text = "Cancel";
			this.Pass_reset_cancel_btn.UseVisualStyleBackColor = true;
			this.Pass_reset_cancel_btn.Click += new System.EventHandler(this.Pass_reset_cancel_btnClick);
			// 
			// Reset_Password
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(257, 214);
			this.Controls.Add(this.Pass_reset_cancel_btn);
			this.Controls.Add(this.Pass_reset_btn);
			this.Controls.Add(this.Password_reset_email_fld);
			this.Controls.Add(this.Password_reset_email_lbl);
			this.Controls.Add(this.Password_reset_user_fld);
			this.Controls.Add(this.Password_reset_user_lbl);
			this.Controls.Add(this.Password_reset_lbl);
			this.Name = "Reset_Password";
			this.Text = "Reset_Password";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Pass_reset_cancel_btn;
		private System.Windows.Forms.Button Pass_reset_btn;
		private System.Windows.Forms.TextBox Password_reset_email_fld;
		private System.Windows.Forms.Label Password_reset_email_lbl;
		private System.Windows.Forms.TextBox Password_reset_user_fld;
		private System.Windows.Forms.Label Password_reset_user_lbl;
		private System.Windows.Forms.Label Password_reset_lbl;
	}
}
