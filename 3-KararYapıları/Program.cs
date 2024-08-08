namespace _3_KararYapıları;

internal class Program
{
    static void Main(string[] args)

    {
        #region Urun Tanimlama
        /*
        Disaridan urun adi girilecek
        program urunun hangi reyonda oldugunu soyleyecek
        Domates,biber,patlican icin Sebze Reyonu
        Diş mancunu, Parfum, Krem icin Kozmetik reyonu
        Telefon, Bilgisayar, Ses sistemleri icin Teknoloji reyonu
        Bunlardan farkli  bir urun girer ise "Bu urun bizde yok " uyarisi verecek
        */
        string urun;

        urun = "Patates";

        

        while (urun != "cıkıs"  )
        {
            Console.WriteLine("Urun Giriniz veya Cıkmak ıcın -e- -E- giriniz.");
            urun = Console.ReadLine();

            if (urun == "Domates" || urun == "Biber" || urun == "patlican")
            {
                Console.WriteLine("Sebze reyonuna gidiniz");
            }

            else if (urun == "Diş Macunu" || urun == "Parfum" || urun == "Krem")
            {
                Console.WriteLine("Kozmetik reyonuna gidiniz");
            }

            else if (urun == "Telefon" || urun == "Bilgisayar" || urun == "Ses Sistemleri")
            {
                Console.WriteLine("Teknoloji reyonuna gidiniz");
            }

            else if (urun == "e" || urun == "E")

            {
                Console.WriteLine("İyi GÜnler Dileriz. Çıkış yapılıyor.");
                urun = "cıkıs";
                
            }

            else

            {
                Console.WriteLine("Bu ürün Bizde Bulunmuyor.");

            }
        }
        
        #endregion

        #region

        //Ekrandan haftanin kacinci gununde oldugunu ısteyın ve gunu yazdirin.Baslangıc gununu pazartesi olarak alalim.


        /*byte gun;
        string temp;
        Console.WriteLine("Bulundugunuz Gunu Bulunuz(1-7)");
        temp = Console.ReadLine();
        if (temp != null)
        {
            gun = byte.Parse(temp);
            if (gun <= 7 && gun > 0)
            {
                if (gun == 1)
                {
                    Console.WriteLine("Pazartesi");
                }

                else if (gun == 2)
                {
                    Console.WriteLine("Sali");
                }

                else if (gun == 3)
                {
                    Console.WriteLine("Carsamba");
                }

                else if (gun == 4)
                {
                    Console.WriteLine("Perşembe");
                }

                else if (gun == 5)
                {
                    Console.WriteLine("Cuma");
                }

                else if (gun == 6)
                {
                    Console.WriteLine("Cumartesi");
                }
                else
                {
                    Console.WriteLine("Pazar");
                }
            }

        } */
        #endregion

        #region

        //Klavyeden Girilensuyun sicakligina gore katıi sivi gaz mesajini ekrana basalim

        /*short SuSicakligi;

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

        */

        #endregion
    }
}