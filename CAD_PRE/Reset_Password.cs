/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 10/14/2015
 * Time: 4:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Reset_Password.
	/// </summary>
	public partial class Reset_Password : Form
	{
		public Reset_Password()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void Pass_reset_btnClick(object sender, EventArgs e)
		{
			if (Password_reset_email_fld.TextLength < 100 && Password_reset_user_fld.TextLength < 100)
			{
				string sqlStr = "SELECT * FROM users WHERE Username = '" + Password_reset_user_fld.Text + "'" ;
				Tools.clearDataset();
				DataSet mDS = Tools.GetDataSet(sqlStr, "cad");
				if (mDS.Tables[0].Rows.Count == 1)
				{
					DataRow r = mDS.Tables[0].Rows[0];
					if (r["Email"].ToString() == Password_reset_email_fld.Text)
					{
						HashAlgorithm sha = new SHA512CryptoServiceProvider();
						string temp_pass = Hash.RandomPass();
						string Salt = Hash.Salter(); //Hash.GenerateSaltValue();
						string Hash_pass = Hash.HashPassword(temp_pass, Salt, sha);
						//Don't forget the [] around password. it is a weird requirement for sql commands in c#
						string sql = "UPDATE users SET [Password]= '" + Hash_pass + "', Salt= '" + Salt + "' WHERE Username = '" + Password_reset_user_fld.Text + "'";
						Tools.runSql(sql, "cad");
						Email.SendMailWithOutlook("Your Temporary CAD Password", "Your temporary password is: " + temp_pass, Password_reset_email_fld.Text, true);
						MessageBox.Show("Your password has been reset. A temporary password has been sent to your e-mail address.");
						this.Close();
					}
					else{
						MessageBox.Show("The E-mail address you provided does no match the E-mail address associated with the provided username.");
					}
				}
				else{
					MessageBox.Show("Username not found.");
				}
			}
			else{
				MessageBox.Show("Your username or e-mail has too many characters.");
			}
		}
		
		void Pass_reset_cancel_btnClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
