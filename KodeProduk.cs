using System;
using System.Reflection;

public class KodeProduk
{
	public static String[] produk = { Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera };

	public static String[] kodeProduk = { E100, E101, E102, E103, E104, E105, E106, E107, E108, E109 };

	public static int GetKodeProduk(String namaProduk)
	{
		for (int i = 0; i < produk.Length; i++)
		{
			if (produk[i] == namaProduk)
			{
				return KodeProduk[i];
			}
		}
		throw new ArgumentException("Produk Tidak Ditemuakan");
	}
}
