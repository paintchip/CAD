/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/25/2015
 * Time: 1:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Registration_Form : baseform
	{
		public Registration_Form()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		//handles cancel button click
		private void Cancel_reg_form_btn(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//handles registration button click
		private void Registration_btn(object sender, EventArgs e)
		{
			if (Username_reg_fld.TextLength > 0 && Username_reg_fld.TextLength < 100  && EJUsername_reg_fld.TextLength > 0 && EJUsername_reg_fld.TextLength < 100 && Email_reg_fld.TextLength > 0 && Email_reg_fld.TextLength < 100 && Shield_reg_fld.TextLength > 0)
			{
				if (Password_reg_fld.TextLength > 6 && Password_reg_fld.TextLength < 100)
				{
					//This Regex was snagged from MSDN because it catches quite a bit while allowing some different e-mails
					if (System.Text.RegularExpressions.Regex.IsMatch(Email_reg_fld.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", System.Text.RegularExpressions.RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
					{
						if (System.Text.RegularExpressions.Regex.IsMatch(Shield_reg_fld.Text, @"^\d+$") && Shield_reg_fld.TextLength < 7)
						{
							HashAlgorithm sha = new SHA512CryptoServiceProvider();
							string Salt = Hash.Salter(); //Hash.GenerateSaltValue(); // generates a random salt value
							string Hash_pass = Hash.HashPassword(Password_reg_fld.Text, Salt, sha); //creates a hashed password from the password entered
						 	//generate the sql to insert the call for association with the event
						 	//Don't forget the [] around password. it is a reserved field in sql
							string sql = @"INSERT INTO users (DispatchID, Username, EJusticeUsername, [Password], Salt, Email) VALUES ('" + Shield_reg_fld.Text + "', '" + Username_reg_fld.Text + "', '" + EJUsername_reg_fld.Text + "', '" +  Hash_pass + "', '" + Salt + "', '" + Email_reg_fld.Text + "')";
							Tools.runSql(sql, "cad");
							sql = @"INSERT INTO Settings (DispID, Username) VALUES ('" + Shield_reg_fld.Text + "', '" + Username_reg_fld.Text + "')";
							Tools.runSql(sql, "cad");
							MessageBox.Show("Your account has been successfully created!");
							this.Close();
						}
						else
						{
							MessageBox.Show("Your shield must be numeric and less than 7 numbers long.");
						}
					}
					else
					{
					   	MessageBox.Show("Please input a valid e-mail address.");	
					}
				}
				else
				{
						MessageBox.Show("Your password must be between 6 and 100 characters long.");
				}
			}
			else
			{
				MessageBox.Show("Please make sure that the form is completed and that none of the fields have more than 100 characters in them.");
			}			
		}
	}
}
