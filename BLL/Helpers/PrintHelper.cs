using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;

namespace BLL
{
	public class PrintHelper
	{
		public static bool CheckStatusAfter(Zebra.Sdk.Printer.ZebraPrinter printer)
		{
			PrinterStatus printerStatus = null;
			try
			{
				VerifyConnection(printer);
				printerStatus = printer.GetCurrentStatus();
				while ((printerStatus.numberOfFormatsInReceiveBuffer > 0) && (printerStatus.isReadyToPrint))
				{
					Thread.Sleep(500);
					printerStatus = printer.GetCurrentStatus();
				}
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error getting status from printer: {e.Message}");
			}

			if (printerStatus.isReadyToPrint)
			{
				Console.WriteLine($"Ready To Print");
				return true;
			}
			else if (printerStatus.isPaused)
			{
				Console.WriteLine($"Cannot Print because the printer is paused.");
			}
			else if (printerStatus.isHeadOpen)
			{
				Console.WriteLine($"Cannot Print because the printer head is open.");
			}
			else if (printerStatus.isPaperOut)
			{
				Console.WriteLine($"Cannot Print because the paper is out.");
			}
			else
			{
				Console.WriteLine($"Cannot Print.");
			}
			return false;
		}
		public static bool Print(Zebra.Sdk.Printer.ZebraPrinter printer, string printstring)
		{
			bool sent = false;
			try
			{
				VerifyConnection(printer);
				printer.Connection.Write(Encoding.UTF8.GetBytes(printstring));
				sent = true;
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Unable to write to printer: {e.Message}");
			}
			return sent;
		}
		public static bool SetPageLanguage(Zebra.Sdk.Printer.ZebraPrinter printer)
		{
			bool set = false;
			string setLang = "zpl";
			if (PrinterLanguage.ZPL != printer.PrinterControlLanguage)
			{
				setLang = "line_print";
			}

			try
			{
				VerifyConnection(printer);
				SGD.SET("device.languages", setLang, printer.Connection);
				string getLang = SGD.GET("device.languages", printer.Connection);
				if (getLang.Contains(setLang))
				{
					set = true;
				}
				else
				{
					Console.WriteLine($"This is not a {setLang} printer.");
				}
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Unable to set print language: {e.Message}");
			}
			return set;
		}
		public static bool CheckStatus(Zebra.Sdk.Printer.ZebraPrinter printer)
		{
			PrinterStatus printerStatus = null;
			try
			{
				VerifyConnection(printer);
				printerStatus = printer.GetCurrentStatus();
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error getting status from printer: {e.Message}");
			}

			if (null == printerStatus)
			{
				Console.WriteLine($"Unable to get status.");
			}
			else if (printerStatus.isReadyToPrint)
			{
				Console.WriteLine($"Ready To Print");
				return true;
			}
			else if (printerStatus.isPaused)
			{
				Console.WriteLine($"Cannot Print because the printer is paused.");
			}
			else if (printerStatus.isHeadOpen)
			{
				Console.WriteLine($"Cannot Print because the printer head is open.");
			}
			else if (printerStatus.isPaperOut)
			{
				Console.WriteLine($"Cannot Print because the paper is out.");
			}
			else
			{
				Console.WriteLine($"Cannot Print.");
			}
			return false;
		}
		public static bool VerifyConnection(Zebra.Sdk.Printer.ZebraPrinter printer)
		{
			bool ok = false;
			try
			{
				if (!printer.Connection.Connected)
				{
					printer.Connection.Open();
					if (printer.Connection.Connected)
						ok = true;
				}
				else ok = true;
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Unable to connect to printer: {e.Message}");
			}
			return ok;
		}
		public static Zebra.Sdk.Printer.ZebraPrinter Connect(Connection connection, PrinterLanguage language)
		{
            Zebra.Sdk.Printer.ZebraPrinter printer = null;
			try
			{
				connection.Open();
				if (connection.Connected)
				{
					printer = ZebraPrinterFactory.GetInstance(language, connection);
					Console.WriteLine($"Printer Connected");
				}
				else Console.WriteLine($"Printer Not Connected!");
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error connecting to printer: {e.Message}");
			}
			return printer;
		}
		public static Zebra.Sdk.Printer.ZebraPrinter Connect(DiscoveredPrinter discoveredPrinter, PrinterLanguage language)
		{
            Zebra.Sdk.Printer.ZebraPrinter printer = null;
			try
			{
				Connection connection = discoveredPrinter.GetConnection();
				printer = ZebraPrinterFactory.GetInstance(language, connection);
				printer.Connection.Open();
				if (printer.Connection.Connected)
					Console.WriteLine($"Printer Connected");
				else Console.WriteLine($"Printer Not Connected!");
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error connecting to printer: {e.Message}");
			}
			return printer;
		}
		public static Zebra.Sdk.Printer.ZebraPrinter Disconnect(Zebra.Sdk.Printer.ZebraPrinter printer)
		{
			try
			{
				printer.Connection.Close();
				Console.WriteLine($"Printer Disconnected");
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error disconnecting from printer: {e.Message}");
			}
			return printer;
		}

		//
		public static string replaceUTF8HEX(string str)
		{
			string[] hex = new string[14];
			hex[0] = "_c3_81";
			hex[1] = "_c3_89";
			hex[2] = "_c3_8d";
			hex[3] = "_c3_93";
			hex[4] = "_c3_9a";
			hex[5] = "_c3_a1";
			hex[6] = "_c3_a9";
			hex[7] = "_c3_ad";
			hex[8] = "_c3_b3";
			hex[9] = "_c3_ba";
			hex[10] = "_c3_91";
			hex[11] = "_c3_b1";
			hex[12] = "_c3_9c";
			hex[13] = "_c3_bc";

			string[] letter = new string[14];
			letter[0] = "Á";
			letter[1] = "É";
			letter[2] = "Í";
			letter[3] = "Ó";
			letter[4] = "Ú";
			letter[5] = "á";
			letter[6] = "é";
			letter[7] = "í";
			letter[8] = "ó";
			letter[9] = "ú";
			letter[10] = "Ñ";
			letter[11] = "ñ";
			letter[12] = "Ü";
			letter[13] = "ü";

			for (int i = 0; i <= letter.Length - 1; i++)
			{
				str = str.Replace(letter[i], hex[i]);
			}

			return str;
		}
	}
}
