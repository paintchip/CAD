/*
 * Created by SharpDevelop.
 * User: russom
 * Date: 11/12/2015
 * Time: 10:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of TransparentTextBox.
	/// </summary>
	public partial class TransparentTextBox : TextBox
	{
		public TransparentTextBox()
		{
			InitializeComponent();
			SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.UserPaint, true);
        	BackColor = Color.Transparent;
		}
	}
}
