// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Produk      Kode");
        Console.WriteLine($"Laptop      {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Laptop)}");
        Console.WriteLine($"Smartphone  {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Smartphone)}");
        Console.WriteLine($"Tablet      {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Tablet)}");
        Console.WriteLine($"Headset     {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Headset)}");
        Console.WriteLine($"Keyboard    {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Keyborad)}");
        Console.WriteLine($"Mouse       {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Mouse)}");
        Console.WriteLine($"Printer     {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Printer)}");
        Console.WriteLine($"Monitor     {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Monitor)}");
        Console.WriteLine($"Smartwatch  {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Smartwatch)}");
        Console.WriteLine($"Kamera      {KodeProduk.getKodeProduk(KodeProduk.Produk_elektro.Kamera)}");
    }
}

class KodeProduk 
{
    public enum Produk_elektro 
    {Laptop,Smartphone,Tablet,Headset,Keyborad,Mouse,Printer,Monitor,
    Smartwatch,Kamera}
    private static String[] kode_produk =
    { "E100","E101","E102","E103","E104","E105","E106",
        "E107","E108","E109"};

    public static String getKodeProduk(Produk_elektro produk)
    {
        return kode_produk[(int) produk];
    }
}




