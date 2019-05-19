/*
 * Created by SharpDevelop.
 * User: folandr
 * Date: 9/24/2015
 * Time: 11:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;

namespace NYSPP_CAD
{
	/// <summary>
	/// Description of Hash.
	/// </summary>
	public class Hash
	{
		private static int SaltValueSize = 8;
		public string hashed_pass;
		
		public static string Salter() // Their salt generator doesn't create anything like a Hex value, which is required by their pass generator when it converts the salt to a binary number.ToString This creates a random faux hex number
		{
			Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));
			string salt = "";
			while (salt.Length < SaltValueSize)
			{
				int rand_num = rnd.Next(48,122);
				if (!((rand_num > 57 && rand_num < 65) || (rand_num > 70 && rand_num < 123)))
				{
					salt = salt + Convert.ToChar(rand_num);
				}
			}
			return salt;
		}
		//This class isn't working correctly. it crashes the password hasher.
		public static string RandomPass()
		{
			Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));
			string pass = "";
			while (pass.Length < 8)
			{
				int rand_num = rnd.Next(48,122);
				if (!((rand_num > 57 && rand_num < 65) || (rand_num > 90 && rand_num < 97)))
				{
					pass = pass + Convert.ToChar(rand_num);
				}	
			}
			return pass;
		}
		public static string GenerateSaltValue()
		{
			//ASCIIEncoding utf16 = new ASCIIEncoding();
			UnicodeEncoding utf16 = new UnicodeEncoding();
			
		    if (utf16 != null)
		    {
		        // Create a random number object seeded from the value
		        // of the last random seed value. This is done
		        // interlocked because it is a static value and we want
		        // it to roll forward safely.
		
		        Random random = new Random(unchecked((int)DateTime.Now.Ticks));
		
		        if (random != null)
		        {
		            // Create an array of random values.
		
		            byte[] saltValue = new byte[SaltValueSize];
		
		            random.NextBytes(saltValue);
		
		            // Convert the salt value to a string. Note that the resulting string
		            // will still be an array of binary values and not a printable string. 
		            // Also it does not convert each byte to a double byte.
		
		            string saltValueString = utf16.GetString(saltValue);
		            // Return the salt value as a string.
		
		            return saltValueString;
		        }
		    }
		
		    return null;
		}
		
		public static string HashPassword(string clearData, string saltValue, HashAlgorithm hash)
		{
		    UnicodeEncoding encoding = new UnicodeEncoding();
		
		    if (clearData != null && hash != null && encoding != null)
		    {
		        // If the salt string is null or the length is invalid then
		        // create a new valid salt value.
		
		        if (saltValue == null)
		        {
		            // Generate a salt string.
		            saltValue = GenerateSaltValue();
		        }
		
		        // Convert the salt string and the password string to a single
		        // array of bytes. Note that the password string is Unicode and
		        // therefore may or may not have a zero in every other byte.
		
		        byte[] binarySaltValue = new byte[SaltValueSize];
		       //System.Windows.Forms.MessageBox.Show(saltValue.Substring(0, 1));
		        binarySaltValue[0] = byte.Parse(saltValue.Substring(0, 2), System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat);
		        binarySaltValue[1] = byte.Parse(saltValue.Substring(2, 2), System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat);
		        binarySaltValue[2] = byte.Parse(saltValue.Substring(4, 2), System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat);
		        binarySaltValue[3] = byte.Parse(saltValue.Substring(6, 2), System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat);
		        byte[] valueToHash = new byte[SaltValueSize + encoding.GetByteCount(clearData)];
		        byte[] binaryPassword = encoding.GetBytes(clearData);
		
		        // Copy the salt value and the password to the hash buffer.
		
		        binarySaltValue.CopyTo(valueToHash, 0);
		        binaryPassword.CopyTo(valueToHash, SaltValueSize);
		
		        byte[] hashValue = hash.ComputeHash(valueToHash);
		
		        // The hashed password is the salt plus the hash value (as a string).
		
		        string hashedPassword = saltValue;
		
		        foreach (byte hexdigit in hashValue)
		        {
		            hashedPassword += hexdigit.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
		        }
		
		        // Return the hashed password as a string.
		
		        return hashedPassword;
		    }
		
		    return null;
		}
	}
}
