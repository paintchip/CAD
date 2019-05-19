/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 8/12/2015
 * Time: 12:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of InputBox.  A message box style input field that captures the users input
	/// </summary>
	public static class InputBox
	{
		public static DialogResult Show(string title, string promptText, ref string value)
		{
			//create a new form
			Form form = new Form();
			//create a new label
			Label label = new Label();
			//create a new textbox
			TextBox textBox = new TextBox();
			//create a new ok button
			Button buttonOk = new Button();
			//create a new cancel button
			Button buttonCancel = new Button();
			
			//set the form caption to the title parameter
			form.Text = title;
			//set the label text to the promptText parameter
			label.Text = promptText;
			//set the textbox text to be the value passed as a parameter
			textBox.Text = value;
			
			//set the text of the ok button
			buttonOk.Text = "OK";
			//set the text of the cancel button
			buttonCancel.Text = "Cancel";
			//set the type of dialogresult returned from the button clicks
			buttonOk.DialogResult = DialogResult.OK;
			buttonCancel.DialogResult = DialogResult.Cancel;
			
			//set the size of the label, textbox, and buttons
			label.SetBounds(9, 20, 372, 13);
			textBox.SetBounds(12, 36, 372, 20);
			buttonOk.SetBounds(228, 72, 75, 23);
			buttonCancel.SetBounds(309, 72, 75, 23);
			
			//set the anchor settings of the label, textbox, and buttons
			label.AutoSize = true;
			textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
			buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			
			//set the form options
			form.ClientSize = new Size(396, 107);
			form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
			form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = buttonOk;
			form.CancelButton = buttonCancel;
			
			//create a dialog result to return from the forms dialog result
			DialogResult dialogResult = form.ShowDialog();
			//set the value to the text of the text box
			value = textBox.Text;
			//return the dialog result
			return dialogResult;
		}
	}
}
