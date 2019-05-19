/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/25/2015
 * Time: 1:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class Registration_Form : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
			this.label1 = new System.Windows.Forms.Label();
			this.Username_reg_fld = new System.Windows.Forms.TextBox();
			this.EJUsername_reg_fld = new System.Windows.Forms.TextBox();
			this.Password_reg_fld = new System.Windows.Forms.TextBox();
			this.Shield_reg_fld = new System.Windows.Forms.TextBox();
			this.Email_reg_fld = new System.Windows.Forms.TextBox();
			this.Username_lbl = new System.Windows.Forms.Label();
			this.Password_lbl = new System.Windows.Forms.Label();
			this.Ejustice_usr_lbl = new System.Windows.Forms.Label();
			this.shield_lbl = new System.Windows.Forms.Label();
			this.eaddress_lbl = new System.Windows.Forms.Label();
			this.Register_btn = new System.Windows.Forms.Button();
			this.Cancel_reg_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(117, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Register";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Username_reg_fld
			// 
			this.Username_reg_fld.Location = new System.Drawing.Point(45, 90);
			this.Username_reg_fld.Name = "Username_reg_fld";
			this.Username_reg_fld.Size = new System.Drawing.Size(169, 20);
			this.Username_reg_fld.TabIndex = 1;
			// 
			// EJUsername_reg_fld
			// 
			this.EJUsername_reg_fld.Location = new System.Drawing.Point(45, 152);
			this.EJUsername_reg_fld.Name = "EJUsername_reg_fld";
			this.EJUsername_reg_fld.Size = new System.Drawing.Size(169, 20);
			this.EJUsername_reg_fld.TabIndex = 3;
			// 
			// Password_reg_fld
			// 
			this.Password_reg_fld.Location = new System.Drawing.Point(286, 90);
			this.Password_reg_fld.Name = "Password_reg_fld";
			this.Password_reg_fld.PasswordChar = '*';
			this.Password_reg_fld.Size = new System.Drawing.Size(169, 20);
			this.Password_reg_fld.TabIndex = 4;
			// 
			// Shield_reg_fld
			// 
			this.Shield_reg_fld.Location = new System.Drawing.Point(286, 152);
			this.Shield_reg_fld.Name = "Shield_reg_fld";
			this.Shield_reg_fld.Size = new System.Drawing.Size(169, 20);
			this.Shield_reg_fld.TabIndex = 5;
			// 
			// Email_reg_fld
			// 
			this.Email_reg_fld.Location = new System.Drawing.Point(45, 221);
			this.Email_reg_fld.Name = "Email_reg_fld";
			this.Email_reg_fld.Size = new System.Drawing.Size(410, 20);
			this.Email_reg_fld.TabIndex = 6;
			// 
			// Username_lbl
			// 
			this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Username_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Username_lbl.Location = new System.Drawing.Point(45, 67);
			this.Username_lbl.Name = "Username_lbl";
			this.Username_lbl.Size = new System.Drawing.Size(100, 20);
			this.Username_lbl.TabIndex = 7;
			this.Username_lbl.Text = "Username:";
			// 
			// Password_lbl
			// 
			this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Password_lbl.Location = new System.Drawing.Point(286, 67);
			this.Password_lbl.Name = "Password_lbl";
			this.Password_lbl.Size = new System.Drawing.Size(100, 20);
			this.Password_lbl.TabIndex = 8;
			this.Password_lbl.Text = "Password:";
			// 
			// Ejustice_usr_lbl
			// 
			this.Ejustice_usr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ejustice_usr_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.Ejustice_usr_lbl.Location = new System.Drawing.Point(45, 129);
			this.Ejustice_usr_lbl.Name = "Ejustice_usr_lbl";
			this.Ejustice_usr_lbl.Size = new System.Drawing.Size(137, 20);
			this.Ejustice_usr_lbl.TabIndex = 9;
			this.Ejustice_usr_lbl.Text = "EJustice Username:";
			// 
			// shield_lbl
			// 
			this.shield_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shield_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.shield_lbl.Location = new System.Drawing.Point(286, 129);
			this.shield_lbl.Name = "shield_lbl";
			this.shield_lbl.Size = new System.Drawing.Size(136, 20);
			this.shield_lbl.TabIndex = 10;
			this.shield_lbl.Text = "Dispatch ID / Shield:";
			// 
			// eaddress_lbl
			// 
			this.eaddress_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eaddress_lbl.ForeColor = System.Drawing.Color.Yellow;
			this.eaddress_lbl.Location = new System.Drawing.Point(45, 198);
			this.eaddress_lbl.Name = "eaddress_lbl";
			this.eaddress_lbl.Size = new System.Drawing.Size(121, 20);
			this.eaddress_lbl.TabIndex = 11;
			this.eaddress_lbl.Text = "E-Mail Address:";
			// 
			// Register_btn
			// 
			this.Register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Register_btn.ForeColor = System.Drawing.Color.Black;
			this.Register_btn.Location = new System.Drawing.Point(77, 260);
			this.Register_btn.Name = "Register_btn";
			this.Register_btn.Size = new System.Drawing.Size(137, 31);
			this.Register_btn.TabIndex = 12;
			this.Register_btn.Text = "Register";
			this.Register_btn.UseVisualStyleBackColor = true;
			this.Register_btn.Click += new System.EventHandler(this.Registration_btn);
			// 
			// Cancel_reg_btn
			// 
			this.Cancel_reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel_reg_btn.ForeColor = System.Drawing.Color.Black;
			this.Cancel_reg_btn.Location = new System.Drawing.Point(286, 260);
			this.Cancel_reg_btn.Name = "Cancel_reg_btn";
			this.Cancel_reg_btn.Size = new System.Drawing.Size(137, 31);
			this.Cancel_reg_btn.TabIndex = 13;
			this.Cancel_reg_btn.Text = "Cancel";
			this.Cancel_reg_btn.UseVisualStyleBackColor = true;
			this.Cancel_reg_btn.Click += new System.EventHandler(this.Cancel_reg_form_btn);
			// 
			// Registration_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(511, 312);
			this.Controls.Add(this.Cancel_reg_btn);
			this.Controls.Add(this.Register_btn);
			this.Controls.Add(this.eaddress_lbl);
			this.Controls.Add(this.shield_lbl);
			this.Controls.Add(this.Ejustice_usr_lbl);
			this.Controls.Add(this.Password_lbl);
			this.Controls.Add(this.Username_lbl);
			this.Controls.Add(this.Email_reg_fld);
			this.Controls.Add(this.Shield_reg_fld);
			this.Controls.Add(this.Password_reg_fld);
			this.Controls.Add(this.EJUsername_reg_fld);
			this.Controls.Add(this.Username_reg_fld);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Registration_Form";
			this.Text = "Registration Form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Cancel_reg_btn;
		private System.Windows.Forms.Button Register_btn;
		private System.Windows.Forms.Label eaddress_lbl;
		private System.Windows.Forms.Label shield_lbl;
		private System.Windows.Forms.Label Ejustice_usr_lbl;
		private System.Windows.Forms.Label Password_lbl;
		private System.Windows.Forms.Label Username_lbl;
		private System.Windows.Forms.TextBox Email_reg_fld;
		private System.Windows.Forms.TextBox Shield_reg_fld;
		private System.Windows.Forms.TextBox Password_reg_fld;
		private System.Windows.Forms.TextBox EJUsername_reg_fld;
		private System.Windows.Forms.TextBox Username_reg_fld;
		private System.Windows.Forms.Label label1;
		

	}
}
