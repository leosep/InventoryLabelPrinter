using System;
using System.Threading.Tasks;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;

namespace BLL
{
	public class ZebraPrinter
	{
		public async Task printUsb(string item, string code)
		{			
			// Convert to hexadecimal			
			string hexCode;
			hexCode = Utils.ASCIITohex(code.Trim());

			string ZPL_STRING = "^XA" +
								"^CI28" +
								"^FO50,50^A0N,20^FH^FD" + Globals.cia + "  " + PrintHelper.replaceUTF8HEX(item.Trim()) + "^FS" +// Text
								"^FT70,150^BY3^A0N,40,30^BC,70,Y,N,N,A^FD" + code.Trim() + "^FS" + // Bar code
								"^RS8^RFW,H^FD" + hexCode + "^FS" + // RFID
								"^XZ";	

			await Task.Run(() =>
			{
				DiscoveredPrinter discoveredPrinter = GetUSBPrinter();

                Zebra.Sdk.Printer.ZebraPrinter printer = PrintHelper.Connect(discoveredPrinter, PrinterLanguage.ZPL);
				PrintHelper.SetPageLanguage(printer);
				if (PrintHelper.CheckStatus(printer))
				{
					PrintHelper.Print(printer, ZPL_STRING);
					if (PrintHelper.CheckStatusAfter(printer))
					{
						Console.WriteLine($"Label Printed");
					}
				}
				printer = PrintHelper.Disconnect(printer);
				Console.WriteLine("Done Printing");
			});
		}

		public DiscoveredPrinter GetUSBPrinter()
		{
			DiscoveredPrinter discoveredPrinter = null;
			try
			{
				foreach (DiscoveredUsbPrinter usbPrinter in UsbDiscoverer.GetZebraUsbPrinters())
				{
					discoveredPrinter = usbPrinter;
					Console.WriteLine(usbPrinter);
				}
			}
			catch (ConnectionException e)
			{
				Console.WriteLine($"Error discovering local printers: {e.Message}");
			}

			Console.WriteLine("Done discovering local printers.");
			return discoveredPrinter;
		}
	}
}
