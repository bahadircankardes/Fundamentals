namespace _3_KararYapıları;

internal class Program
{
    static void Main(string[] args)
    {
        //Klavyeden Girilensuyun sicakligina gore katıi sivi gaz mesajini ekrana basalim

        short SuSicakligi;

        Console.Write("Suyun Sicakligini Giriniz:");

        SuSicakligi = short.Parse(Console.ReadLine());

        if (SuSicakligi == 0)
        {
            Console.WriteLine();
        }

        else

        {
            Console.WriteLine();
        }

        if (SuSicakligi > 100)
        {
            Console.WriteLine("Gaz Haldedir.");
        }

        else if (SuSicakligi > 0)
        {
            Console.WriteLine("Sivi Haldedir.");
        }

        else

        {
            Console.WriteLine("Kati Haldedir.");
        }


        Console.WriteLine("Hello, World!");
    }
}

