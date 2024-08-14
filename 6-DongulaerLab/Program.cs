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

        #region zar simulasyon

        //1-6 arasinda rasgele sayilar olusturulacak.
        //6 elemanli bir dizide gelen sayisi toplanacak 
        //Deneme sayisi ekrandan okutulacak
        //Random rnd = new Random();
        //int gelenDeger = 0;
        //gelenDeger = rnd.Next(1, 7);
        //int denemeSayisi = 0;
        //Console.WriteLine("Deneme Sayisini Giriniz");
        //denemeSayisi =int.Parse(Console.ReadLine());
        //int[] zarlar=new int[6];

        //for (int i = 0; i < denemeSayisi; i++) 
        //{
        //    gelenDeger = rnd.Next(1, 7);
        //    //Console.WriteLine(gelenDeger);
        // #region Spagetti kod ornegi

        //    //switch (gelenDeger)
        //    //{
        //    //    case 1:
        //    //        //zarlar[0] = zarlar[0] + 1;
        //    //        zarlar[0]++;
        //    //        break;
        //    //    case 2:
        //    //         zarlar[1]++;
        //    //        break;
        //    //    case 3:
        //    //        zarlar[2]++;
        //    //        break;
        //    //    case 4:
        //    //        zarlar[3]++;
        //    //        break;
        //    //    case 5:
        //    //        zarlar[4]++;
        //    //        break;
        //    //    case 6:
        //    //        zarlar[5]++;
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}


        // #endregion

        //    zarlar[gelenDeger - 1]++;
        //}

        //for (int i = 0; i < zarlar.Length; i++)
        //{
        //    double olasilik = zarlar[i]/Convert.ToDouble(denemeSayisi);
        //    Console.WriteLine((i + 1) + " Gelen Sayi " + zarlar[i] + " Olasilik : " + olasilik);
        //}

        //zarlar[gelenDeger - 1]++;
        //}

        //for (int i = 0; i < zarlar.Length; i++)
        //{
        //    double olasilik = zarlar[i]/Convert.ToDouble(denemeSayisi);
        //    Console.WriteLine((i + 1) + " Gelen Sayi " + zarlar[i] + " Olasilik : " + olasilik);
        //}
        #endregion

        #region Sayı Tahmin Oyunu (1-50) tekrar yap

        /*
             * Bilgisayar bir sayi tutacak. (1-50) arasinda
             * Kullaniciya 5 tahmin hakki verilecek.
             * Tahminden buyuk girdiyse daha kucuk bir sayi giriniz diyecek
             * Tahminden kucuk girdiyse daha buyuk bir sayi giriniz diyecek
             * Bidiginde kaçinci denemede  bildini de yaziniz 
             * 
             * DEneme hakki bittiginde devam etmek istiyormusunuz sorunu sorsun. 
             * Hayir demedigi surece oyuna devam etsin
             */
        //int tutulansayi, tahmin, denemeSayisi = 5;
        //Random rnd = new Random();

        //string cevap = "E";
        //do
        //{
        //    tutulansayi = rnd.Next(50) + 1;
        //    for (int i = 1; i <= denemeSayisi; i++)
        //    {
        //        Console.Write(i + ". Hakkinizi giriniz:");
        //        tahmin = int.Parse(Console.ReadLine());
        //        if (tahmin == tutulansayi)
        //        {
        //            //Console.WriteLine("Tebrikler "+i+" deneme de bildiniz");
        //            Console.WriteLine($"Tebrikler {i}. deneme de bildiniz");
        //            break;
        //        }
        //        else if (tahmin > tutulansayi)
        //        {
        //            Console.WriteLine("Daha kucuk bir sayi giriniz");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Daha buyuk bir sayi giriniz");

        //        }

        //    }

        //    Console.WriteLine($"Tutulan Sayi:{tutulansayi} idi. Oyuna Devam Etmek Istiyormusunuz");
        //    cevap = Console.ReadLine().ToUpper();
        //} while (cevap != "H");


        #endregion

        #region ilk 20 fibonacciyi bulun

        /*
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
        Console.ReadLine();
        */



        #endregion

        #region İlk 20 asal sayı diziye atma
        /*

        int[] AsalSayilar = new int[20];
        int i = 0;
        int sayac = 1, altSayac = 0;
        AsalSayilar[0] = 2;

        for (i = 3; i < 10000; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    altSayac++;
                }
            }

            if (altSayac == 2)
            {
                AsalSayilar[sayac] = i;
                sayac++;
            }
            altSayac = 0;
            if (sayac == 20) break;

            //    }
            //Console.WriteLine("Index:"+i);
            foreach (var item in AsalSayilar)
            {
                Console.WriteLine(item);
            }


            */

        #endregion

        #region Dizi içerisindekien en büyük ve en küçük elemanı bulma


        /*
        int [] sayilar = new int[5];
        int buyuksayi = 0, kucuksayı;
        Random rnd = new Random();


        for (int i = 0; i < 5; i++)
        {
            sayilar[i] = rnd.Next(1000);
            Console.WriteLine(sayilar[i]);
            
        }

        for (int j = 0; j < 5; j++)
        {
            if (buyuksayi < sayilar[j])
            {
                buyuksayi = sayilar[j];
            }
           
        }
        Console.WriteLine("Buyuk Sayı = "+ buyuksayi);
        kucuksayı = buyuksayi;
        
        for (int k = 0; k < 5; k++)
        {
            if (kucuksayı > sayilar[k])
            {
                kucuksayı = sayilar[k];
            }
        }

        Console.WriteLine("Kucuk Sayı = " + kucuksayı);

        Console.ReadLine();


        */

        #endregion

        #region Diziyi kucukten buyuge dogru siralayiniz.

        

        int[] sayilar = new int[5];
        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            sayilar[i] = rnd.Next(1000);
            Console.WriteLine(sayilar[i]);

        }

        
        Console.ReadLine();
        

        #endregion


        #region Hazır Metodlar
        /*

        int[] array = {2, 4, 2, 6, 7,  8, 4, 5, 99, 8, 7 };
        int[] array = { 3, 4, 2, 6, 7, 8, 4, 5, 99, 8, 7 };

        Console.WriteLine("Dizi Toplamı: "+ array.Sum());
        Console.WriteLine("Dizideki en buyuk eleman: " + array.Max());
        Console.WriteLine("Dizideki en kucuk eleman: " + array.Min());
        Console.WriteLine("Dizideki sayilarin ortalamaları: " + array.Average());
        Console.ReadLine();
        */
       
        #endregion

    }
}

