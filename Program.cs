// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Kode Laptop : {KodeProduk.GetKodeProduk(KodeProduk.produk.Laptop)}");
Console.WriteLine($"Kode Smarthphone : {KodeProduk.GetKodeProduk(KodeProduk.produk.Smartphone)}");
Console.WriteLine($"Kode Keyboard : {KodeProduk.GetKodeProduk(KodeProduk.produk.Keyboard)}");
Console.WriteLine($"Kode Mouse : {KodeProduk.GetKodeProduk(KodeProduk.produk.Mouse)}");
Console.WriteLine($"Kode Printer : {KodeProduk.GetKodeProduk(KodeProduk.produk.Printer)}");
Console.WriteLine($"Kode Monitor : {KodeProduk.GetKodeProduk(KodeProduk.produk.Monitor)}");
Console.WriteLine($"Kode Smartwatch : {KodeProduk.GetKodeProduk(KodeProduk.produk.Smartwatch)}");
Console.WriteLine($"Kode Kamera : {KodeProduk.GetKodeProduk(KodeProduk.produk.Kamera)}");

Console.WriteLine();
FanLaptop fan = new FanLaptop();
fan.GetFanStatus();

string input = "";
while (input.ToLower() != "Quit")
{
    Console.WriteLine("Command (Up, Down, Shortcut) : ");
    input = Console.ReadLine();

    if (Enum.TryParse(input, out FanLaptop.trigger trigger))
    {
        fan.StateChange(trigger);
        fan.GetFanStatus();
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Command Not Valid");
        Console.WriteLine();
    }
}