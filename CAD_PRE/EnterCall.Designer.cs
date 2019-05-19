/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/13/2015
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NYSPP_CAD
{
	partial class EnterCall : baseform
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterCall));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.CallDate = new System.Windows.Forms.TextBox();
			this.CallTime = new System.Windows.Forms.TextBox();
			this.Caller = new System.Windows.Forms.ComboBox();
			this.Reason = new System.Windows.Forms.ComboBox();
			this.DispatchID = new System.Windows.Forms.ComboBox();
			this.Narrative = new System.Windows.Forms.TextBox();
			this.Outgoing = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(89, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Time";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(148, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Caller";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(316, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Reason";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(443, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "ID #";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Narrative";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(443, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Outgoing";
			// 
			// CallDate
			// 
			this.CallDate.Location = new System.Drawing.Point(12, 28);
			this.CallDate.Name = "CallDate";
			this.CallDate.Size = new System.Drawing.Size(75, 20);
			this.CallDate.TabIndex = 15;
			this.toolTip1.SetToolTip(this.CallDate, "Call Date");
			// 
			// CallTime
			// 
			this.CallTime.Location = new System.Drawing.Point(93, 28);
			this.CallTime.Name = "CallTime";
			this.CallTime.Size = new System.Drawing.Size(49, 20);
			this.CallTime.TabIndex = 16;
			this.toolTip1.SetToolTip(this.CallTime, "Call Time");
			// 
			// Caller
			// 
			this.Caller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Caller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Caller.FormattingEnabled = true;
			this.Caller.Location = new System.Drawing.Point(148, 28);
			this.Caller.Name = "Caller";
			this.Caller.Size = new System.Drawing.Size(162, 21);
			this.Caller.TabIndex = 0;
			this.toolTip1.SetToolTip(this.Caller, "Caller");
			// 
			// Reason
			// 
			this.Reason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.Reason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Reason.FormattingEnabled = true;
			this.Reason.Location = new System.Drawing.Point(316, 28);
			this.Reason.Name = "Reason";
			this.Reason.Size = new System.Drawing.Size(121, 21);
			this.Reason.TabIndex = 10;
			this.toolTip1.SetToolTip(this.Reason, "Call Reason");
			// 
			// DispatchID
			// 
			this.DispatchID.FormattingEnabled = true;
			this.DispatchID.Location = new System.Drawing.Point(443, 28);
			this.DispatchID.Name = "DispatchID";
			this.DispatchID.Size = new System.Drawing.Size(47, 21);
			this.DispatchID.TabIndex = 13;
			this.toolTip1.SetToolTip(this.DispatchID, "Dispatcher ID");
			// 
			// Narrative
			// 
			this.Narrative.Location = new System.Drawing.Point(68, 55);
			this.Narrative.Multiline = true;
			this.Narrative.Name = "Narrative";
			this.Narrative.Size = new System.Drawing.Size(369, 83);
			this.Narrative.TabIndex = 11;
			this.toolTip1.SetToolTip(this.Narrative, "Call Narrative");
			// 
			// Outgoing
			// 
			this.Outgoing.Font = new System.Drawing.Font("Rockwell Extra Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Outgoing.ForeColor = System.Drawing.Color.Red;
			this.Outgoing.Location = new System.Drawing.Point(460, 71);
			this.Outgoing.Name = "Outgoing";
			this.Outgoing.Size = new System.Drawing.Size(30, 31);
			this.Outgoing.TabIndex = 14;
			this.Outgoing.Click += new System.EventHandler(this.OutgoingClick);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(443, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "Enter";
			this.toolTip1.SetToolTip(this.button1, "Enter the call into the log");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(443, 144);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 31);
			this.button2.TabIndex = 15;
			this.button2.Text = "Create Event";
			this.toolTip1.SetToolTip(this.button2, "Create an event from this call");
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(499, 107);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(36, 31);
			this.button3.TabIndex = 16;
			this.toolTip1.SetToolTip(this.button3, "Cancel the call");
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 350;
			this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
			// 
			// EnterCall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 183);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Outgoing);
			this.Controls.Add(this.Narrative);
			this.Controls.Add(this.DispatchID);
			this.Controls.Add(this.Reason);
			this.Controls.Add(this.Caller);
			this.Controls.Add(this.CallTime);
			this.Controls.Add(this.CallDate);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "EnterCall";
			this.Text = "Enter Call";
			this.Load += new System.EventHandler(this.EnterCallLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Outgoing;
		private System.Windows.Forms.TextBox Narrative;
		private System.Windows.Forms.ComboBox DispatchID;
		private System.Windows.Forms.ComboBox Reason;
		private System.Windows.Forms.ComboBox Caller;
		private System.Windows.Forms.TextBox CallTime;
		private System.Windows.Forms.TextBox CallDate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
