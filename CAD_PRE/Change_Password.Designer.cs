/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/25/2015
 * Time: 5:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Change_Password : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
			this.label1 = new System.Windows.Forms.Label();
			this.Change_pass_username_fld = new System.Windows.Forms.TextBox();
			this.Change_pass_oldpass_fld = new System.Windows.Forms.TextBox();
			this.Change_pass_newpass_fld = new System.Windows.Forms.TextBox();
			this.Change_pass_btn = new System.Windows.Forms.Button();
			this.Change_pass_cancel_btn = new System.Windows.Forms.Button();
			this.Change_pass_username_lbl = new System.Windows.Forms.Label();
			this.Change_pass_oldpass_lbl = new System.Windows.Forms.Label();
			this.Change_pass_newpass_lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Change Password";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Change_pass_username_fld
			// 
			this.Change_pass_username_fld.Location = new System.Drawing.Point(59, 78);
			this.Change_pass_username_fld.Name = "Change_pass_username_fld";
			this.Change_pass_username_fld.Size = new System.Drawing.Size(160, 20);
			this.Change_pass_username_fld.TabIndex = 1;
			// 
			// Change_pass_oldpass_fld
			// 
			this.Change_pass_oldpass_fld.Location = new System.Drawing.Point(59, 126);
			this.Change_pass_oldpass_fld.Name = "Change_pass_oldpass_fld";
			this.Change_pass_oldpass_fld.Size = new System.Drawing.Size(160, 20);
			this.Change_pass_oldpass_fld.TabIndex = 2;
			this.Change_pass_oldpass_fld.UseSystemPasswordChar = true;
			// 
			// Change_pass_newpass_fld
			// 
			this.Change_pass_newpass_fld.Location = new System.Drawing.Point(59, 171);
			this.Change_pass_newpass_fld.Name = "Change_pass_newpass_fld";
			this.Change_pass_newpass_fld.Size = new System.Drawing.Size(160, 20);
			this.Change_pass_newpass_fld.TabIndex = 3;
			this.Change_pass_newpass_fld.UseSystemPasswordChar = true;
			// 
			// Change_pass_btn
			// 
			this.Change_pass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change_pass_btn.ForeColor = System.Drawing.Color.Black;
			this.Change_pass_btn.Location = new System.Drawing.Point(59, 208);
			this.Change_pass_btn.Name = "Change_pass_btn";
			this.Change_pass_btn.Size = new System.Drawing.Size(74, 31);
			this.Change_pass_btn.TabIndex = 4;
			this.Change_pass_btn.Text = "Change";
			this.Change_pass_btn.UseVisualStyleBackColor = true;
			this.Change_pass_btn.Click += new System.EventHandler(this.Change_pass_form_btn);
			// 
			// Change_pass_cancel_btn
			// 
			this.Change_pass_cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change_pass_cancel_btn.ForeColor = System.Drawing.Color.Black;
			this.Change_pass_cancel_btn.Location = new System.Drawing.Point(147, 208);
			this.Change_pass_cancel_btn.Name = "Change_pass_cancel_btn";
			this.Change_pass_cancel_btn.Size = new System.Drawing.Size(72, 31);
			this.Change_pass_cancel_btn.TabIndex = 5;
			this.Change_pass_cancel_btn.Text = "Cancel";
			this.Change_pass_cancel_btn.UseVisualStyleBackColor = true;
			this.Change_pass_cancel_btn.Click += new System.EventHandler(this.Change_pass_cancel_btnClick);
			// 
			// Change_pass_username_lbl
			// 
			this.Change_pass_username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change_pass_username_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.Change_pass_username_lbl.Location = new System.Drawing.Point(59, 57);
			this.Change_pass_username_lbl.Name = "Change_pass_username_lbl";
			this.Change_pass_username_lbl.Size = new System.Drawing.Size(100, 18);
			this.Change_pass_username_lbl.TabIndex = 6;
			this.Change_pass_username_lbl.Text = "Username:";
			// 
			// Change_pass_oldpass_lbl
			// 
			this.Change_pass_oldpass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change_pass_oldpass_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.Change_pass_oldpass_lbl.Location = new System.Drawing.Point(59, 105);
			this.Change_pass_oldpass_lbl.Name = "Change_pass_oldpass_lbl";
			this.Change_pass_oldpass_lbl.Size = new System.Drawing.Size(120, 18);
			this.Change_pass_oldpass_lbl.TabIndex = 7;
			this.Change_pass_oldpass_lbl.Text = "Old Password:";
			// 
			// Change_pass_newpass_lbl
			// 
			this.Change_pass_newpass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change_pass_newpass_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.Change_pass_newpass_lbl.Location = new System.Drawing.Point(59, 149);
			this.Change_pass_newpass_lbl.Name = "Change_pass_newpass_lbl";
			this.Change_pass_newpass_lbl.Size = new System.Drawing.Size(120, 18);
			this.Change_pass_newpass_lbl.TabIndex = 8;
			this.Change_pass_newpass_lbl.Text = "New Password:";
			// 
			// Change_Password
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.Change_pass_newpass_lbl);
			this.Controls.Add(this.Change_pass_oldpass_lbl);
			this.Controls.Add(this.Change_pass_username_lbl);
			this.Controls.Add(this.Change_pass_cancel_btn);
			this.Controls.Add(this.Change_pass_btn);
			this.Controls.Add(this.Change_pass_newpass_fld);
			this.Controls.Add(this.Change_pass_oldpass_fld);
			this.Controls.Add(this.Change_pass_username_fld);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Change_Password";
			this.Text = "Change_Password";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label Change_pass_newpass_lbl;
		private System.Windows.Forms.Label Change_pass_oldpass_lbl;
		private System.Windows.Forms.Label Change_pass_username_lbl;
		private System.Windows.Forms.Button Change_pass_cancel_btn;
		private System.Windows.Forms.Button Change_pass_btn;
		private System.Windows.Forms.TextBox Change_pass_newpass_fld;
		private System.Windows.Forms.TextBox Change_pass_oldpass_fld;
		private System.Windows.Forms.TextBox Change_pass_username_fld;
		private System.Windows.Forms.Label label1;
	}
}
