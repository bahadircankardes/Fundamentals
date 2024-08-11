using System;

namespace _6_DongulaerLab;

class Program
{
    static void Main(string[] args)
    {

        // 2015 2025 arasindaki yillari bastiralim. Ancak 2020 yilini bastirmayacagiz.
        /*for (int i = 2015; i < 2026; i++)
        {
            //break;// Donguyu kirmak istedigimizde kullanilir
            return;// Programdan cikar
                   // 1. Yol 
                   //if (i != 2020)
                   //{
                   //    Console.WriteLine(i);
                   //}

            //2. Yol
            if (i == 2020)
            {
                continue; // Dongude bir sonraki step'e geçer
            }
            Console.WriteLine(i);
        }
        */

        int sayac = 0;
        while (sayac < 10)
        {
            Console.WriteLine(sayac);
            sayac++;
        }
        Console.WriteLine("Program bitti");




    }
}

