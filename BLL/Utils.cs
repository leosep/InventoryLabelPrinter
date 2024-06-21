using System;
using System.Text;

namespace BLL
{
	public class Utils
	{
		public static string hexToASCII(string hexValue)
		{
			StringBuilder output = new StringBuilder("");
			for (int i = 0; i < hexValue.Length; i += 2)
			{
				string str = hexValue.Substring(i, 2);
				output.Append((char)Convert.ToInt32(str, 16));
			}
			return output.ToString();
		}

		public static string ASCIITohex(string ASCIIValue)
		{
			byte[] ba = Encoding.Default.GetBytes(ASCIIValue.Trim());
			var hexString = BitConverter.ToString(ba);
			hexString = hexString.Replace("-", "");

			return hexString;
		}
	}
}
