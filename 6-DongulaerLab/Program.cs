using System;

namespace _6_DongulaerLab;

class Program
{
    static void Main(string[] args)
    {
        #region continue ve break komutları
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

        /*int sayac = 0;
        while (sayac < 10)
        {
            Console.WriteLine(sayac);
            sayac++;
        }
        Console.WriteLine("Program bitti");

        */
        #endregion

        #region zar simulasyon kopyala

        //1-6 arasında sayilar oluşturulacak 6 elemanlı bir dizide gelen sayısı toplanaak deneme sayısı ekrandan okutulacak.

        /*Random rnd = new Random();
        int gelendeger = 0, denemesayisi;
        int[] zarlar = new int[6];
        Console.WriteLine("Deneme sayisini giriniz:");
        denemesayisi = int.Parse (Console.ReadLine());
        

        for (int i = 0; i < denemesayisi; i++)
        {
            gelendeger = rnd.Next(1, 7);
            Console.WriteLine(gelendeger);
            if (gelendeger == 1)
            {
                zarlar[gelendeger-1]++1;
            }
        }

        */
        #endregion region

        #region Sayı Tahmin Oyunu (1-50) tekrar yap

        /*

        int tahmin, sayi, tahminhakki = 5;
        Random rnd = new Random();
        sayi = rnd.Next(50);
        Console.WriteLine("Tutulan Sayi:"+sayi);
        do
        {
            Console.WriteLine("Tahminizi Giriniz:");
            tahmin = int.Parse(Console.ReadLine());

            if (tahmin < sayi)
            {
                Console.WriteLine("Daha Buyuk Bir Sayı Gırınız. Kalan Tahmin Hakkı:" + (tahminhakki - 1));
                tahminhakki = tahminhakki - 1;
            }

            else if (tahmin > sayi)
            {
                Console.WriteLine("Daha Kucuk Bir Sayı Gırınız. Kalan Tahmin Hakkı:" + (tahminhakki - 1));
                tahminhakki = tahminhakki - 1;

            }

            else
            {
                Console.WriteLine("Tebrikler Sayıyı bildiniz. Kalan Tahmin Hakki: " + tahminhakki);
                tahminhakki = 0;
            }
            

        } while (tahminhakki!=0);

        Console.WriteLine(tahminhakki);

        Console.ReadLine();


        */


        #endregion

        #region ilk 20 fibonacciyi bulun

        int sayac1 = 0, sayac2 = 2;
        int[] sayilar = new int[20];
        sayilar[0] = 1;
        sayilar[1] = 1;

        while (sayac2 < 20)
        {
            sayilar[sayac2] = sayilar[sayac1] + sayilar[sayac1+1];
            sayac2 = sayac2 + 1;
            sayac1 = sayac1 + 1;
       
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(sayilar[i]);
        }




        #endregion



    }
}

