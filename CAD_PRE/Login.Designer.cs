/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 7/31/2015
 * Time: 7:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.Username_Fld = new System.Windows.Forms.TextBox();
			this.Username_Lbl = new System.Windows.Forms.Label();
			this.Password_Fld = new System.Windows.Forms.TextBox();
			this.Password_Lbl = new System.Windows.Forms.Label();
			this.LogIn_Btn = new System.Windows.Forms.Button();
			this.Reset_Password_Lnk = new System.Windows.Forms.LinkLabel();
			this.Register_Lnk = new System.Windows.Forms.LinkLabel();
			this.Change_Password_Lnk = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Log In";
			// 
			// Username_Fld
			// 
			this.Username_Fld.AcceptsTab = true;
			this.Username_Fld.Location = new System.Drawing.Point(64, 85);
			this.Username_Fld.Name = "Username_Fld";
			this.Username_Fld.Size = new System.Drawing.Size(145, 20);
			this.Username_Fld.TabIndex = 1;
			this.Username_Fld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_FldKeyDown);
			// 
			// Username_Lbl
			// 
			this.Username_Lbl.BackColor = System.Drawing.Color.Transparent;
			this.Username_Lbl.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Username_Lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Username_Lbl.Location = new System.Drawing.Point(41, 59);
			this.Username_Lbl.Name = "Username_Lbl";
			this.Username_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Username_Lbl.Size = new System.Drawing.Size(100, 23);
			this.Username_Lbl.TabIndex = 2;
			this.Username_Lbl.Text = "Username:";
			// 
			// Password_Fld
			// 
			this.Password_Fld.Location = new System.Drawing.Point(64, 134);
			this.Password_Fld.Name = "Password_Fld";
			this.Password_Fld.PasswordChar = '*';
			this.Password_Fld.Size = new System.Drawing.Size(145, 20);
			this.Password_Fld.TabIndex = 2;
			this.Password_Fld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_FldKeyDown);
			// 
			// Password_Lbl
			// 
			this.Password_Lbl.BackColor = System.Drawing.Color.Transparent;
			this.Password_Lbl.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_Lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Password_Lbl.Location = new System.Drawing.Point(41, 108);
			this.Password_Lbl.Name = "Password_Lbl";
			this.Password_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Password_Lbl.Size = new System.Drawing.Size(100, 23);
			this.Password_Lbl.TabIndex = 4;
			this.Password_Lbl.Text = "Password:";
			// 
			// LogIn_Btn
			// 
			this.LogIn_Btn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogIn_Btn.Location = new System.Drawing.Point(64, 164);
			this.LogIn_Btn.Name = "LogIn_Btn";
			this.LogIn_Btn.Size = new System.Drawing.Size(145, 25);
			this.LogIn_Btn.TabIndex = 3;
			this.LogIn_Btn.Text = "Log In";
			this.LogIn_Btn.UseVisualStyleBackColor = true;
			this.LogIn_Btn.Click += new System.EventHandler(this.LogIn_BtnClick);
			// 
			// Reset_Password_Lnk
			// 
			this.Reset_Password_Lnk.LinkColor = System.Drawing.Color.White;
			this.Reset_Password_Lnk.Location = new System.Drawing.Point(64, 192);
			this.Reset_Password_Lnk.Name = "Reset_Password_Lnk";
			this.Reset_Password_Lnk.Size = new System.Drawing.Size(145, 16);
			this.Reset_Password_Lnk.TabIndex = 5;
			this.Reset_Password_Lnk.TabStop = true;
			this.Reset_Password_Lnk.Text = "Reset Password";
			this.Reset_Password_Lnk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Reset_Password_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reset_Password_LnkLinkClicked);
			// 
			// Register_Lnk
			// 
			this.Register_Lnk.LinkColor = System.Drawing.Color.White;
			this.Register_Lnk.Location = new System.Drawing.Point(64, 224);
			this.Register_Lnk.Name = "Register_Lnk";
			this.Register_Lnk.Size = new System.Drawing.Size(145, 16);
			this.Register_Lnk.TabIndex = 6;
			this.Register_Lnk.TabStop = true;
			this.Register_Lnk.Text = "Register";
			this.Register_Lnk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Register_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Open_Registration);
			// 
			// Change_Password_Lnk
			// 
			this.Change_Password_Lnk.LinkColor = System.Drawing.Color.White;
			this.Change_Password_Lnk.Location = new System.Drawing.Point(64, 208);
			this.Change_Password_Lnk.Name = "Change_Password_Lnk";
			this.Change_Password_Lnk.Size = new System.Drawing.Size(145, 16);
			this.Change_Password_Lnk.TabIndex = 7;
			this.Change_Password_Lnk.TabStop = true;
			this.Change_Password_Lnk.Text = "Change Password";
			this.Change_Password_Lnk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Change_Password_Lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Change_Password_LnkLinkClicked);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(272, 262);
			this.Controls.Add(this.Change_Password_Lnk);
			this.Controls.Add(this.Register_Lnk);
			this.Controls.Add(this.Reset_Password_Lnk);
			this.Controls.Add(this.LogIn_Btn);
			this.Controls.Add(this.Password_Fld);
			this.Controls.Add(this.Password_Lbl);
			this.Controls.Add(this.Username_Fld);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Username_Lbl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel Change_Password_Lnk;
		private System.Windows.Forms.LinkLabel Register_Lnk;
		private System.Windows.Forms.LinkLabel Reset_Password_Lnk;
		private System.Windows.Forms.Button LogIn_Btn;
		private System.Windows.Forms.Label Password_Lbl;
		private System.Windows.Forms.TextBox Password_Fld;
		private System.Windows.Forms.Label Username_Lbl;
		private System.Windows.Forms.TextBox Username_Fld;
		private System.Windows.Forms.Label label1;
	}
}
