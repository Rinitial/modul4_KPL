using System;
using System.Reflection;

internal class KodeProduk
{
	public enum produk { Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera };

	private static String[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

	public static String GetKodeProduk(produk produk)
	{
		return kodeProduk[(int)produk];
	}
}

