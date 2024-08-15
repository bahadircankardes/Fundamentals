namespace _14_HazirMethodlar;

class Program
{
    static void Main(string[] args)
    {
        string tcno = "12345678901";
        Console.WriteLine(tcno.Substring(7, 4));
        Console.WriteLine(tcno.Substring(7));


        string soyad = "Yilmaz";
        Console.WriteLine(soyad.Substring(1, 1));
        Console.WriteLine(soyad.Substring(3, 1));
        Console.WriteLine(soyad.Substring(0, 5));

        Console.ReadLine();

    }
}

