/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/25/2015
 * Time: 5:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Change_Password.
	/// </summary>
	public partial class Change_Password : baseform
	{
		public Change_Password(Color back_color, Color fore_color) // This constructor allows you to use a set background and foreground color without forcing this color when the user changes their settings. The CAD calls the normal constructor which will apply the user chosen colors
		{
			this.BackColor = back_color;
			this.ForeColor = fore_color;
			InitializeComponent();
		}
		
		public Change_Password()
		{
			basecontrols();
			InitializeComponent();
		}
		
		private void Change_pass_form_btn(object sender, EventArgs e)
		{
			if ((Change_pass_newpass_fld.Text.Length < 30) && (Change_pass_username_fld.Text.Length < 30) && (Change_pass_oldpass_fld.Text.Length < 75)) //Making sure the program cannot be crashed with huge inputs
			{
				HashAlgorithm sha = new SHA512CryptoServiceProvider();
				string sqlStr;
				string old_salt = Tools.tableQuery("users", "Username", Change_pass_username_fld.Text, "Salt", false);
				    if (old_salt.Length > 0 && old_salt.Substring(0, 2) != "-1") //This is the first part of the expression returned if the lookup fails
					{
						//set the sql string to check the username and old password in the database so that passwords can't be changed by anyone
						sqlStr = "SELECT * FROM users WHERE Username = '" + Change_pass_username_fld.Text + "' AND Password = '" + Hash.HashPassword(Change_pass_oldpass_fld.Text, old_salt, sha) + "'"; // Will grab data from the users table if the username and password match. The passwerd is sent as a hash
						//create a dataset from the returned results
						Tools.clearDataset();
						DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
						//if 1 row is returned, username and password matched
						if(mDS.Tables[0].Rows.Count == 1)
						{
							if(Change_pass_newpass_fld.TextLength > 6)
							{
								string Salt = Hash.Salter(); //Hash.GenerateSaltValue();
								string Hash_pass = Hash.HashPassword(Change_pass_newpass_fld.Text, Salt, sha);
								//Don't forget the [] around password. it is a weird requirement for sql commands
								string sql = "UPDATE users SET [Password]= '" + Hash_pass + "', Salt= '" + Salt + "' WHERE Username = '" + Change_pass_username_fld.Text + "'";
								Tools.runSql(sql, "cad");
								MessageBox.Show("Your password has been successfully changed.");
								this.Close();
							}
							else
							{
								MessageBox.Show("Your new password must be longer than six characters long");
							}
						}
						else
						{
							MessageBox.Show("Your username or old password are not correct.");
						}		
					}
					else
					{
						MessageBox.Show("Your username or old password are not correct.");
					}
			}
			else
			{
				MessageBox.Show("You cannot enter more than 30 characters in a field.");
			}
		}	
		private void Change_pass_cancel_btnClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
