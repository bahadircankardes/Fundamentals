namespace _3_KararYapıları;

internal class Program
{
    static void Main(string[] args)

    {
        #region Not Ort.Odev
        /* 2 vize 1 final okutun . vizenin %30 finalin %70'ni alin 
        *
             * Ckan sonuc  0-30 arasinda ise FF
             * 30-50 araligi DD
             * 50-70 arasi BB
             * 70-100 arasi AA
             * Olacak sekilde kullaniciyi bilgilendirin.

        int vize1;
        int vize2;
        int final;
        double NotOrtalamasi;

        Console.WriteLine("1. Vize Notunuzu Giriniz:");
        vize1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2. Vize Notunuzu Giriniz:");
        vize2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Final Notunuzu Giriniz:");
        final = int.Parse(Console.ReadLine());

        NotOrtalamasi = (((vize1 + vize2) / 2) * 0.30) + (final * 0.70);

        if (NotOrtalamasi >= 0 && NotOrtalamasi<30)
        {
            Console.WriteLine("Not Ortalamanız: " + NotOrtalamasi + "----> FF");
        }

        if (NotOrtalamasi >= 30 && NotOrtalamasi < 50)
        {
            Console.WriteLine("Not Ortalamanız: " + NotOrtalamasi + "----> DD");
        }

        if (NotOrtalamasi >= 50 && NotOrtalamasi < 70)
        {
            Console.WriteLine("Not Ortalamanız: " + NotOrtalamasi + "----> BB");
        }

        if (NotOrtalamasi >= 70 && NotOrtalamasi <= 100)
        {
            Console.WriteLine("Not Ortalamanız: " + NotOrtalamasi + "----> AA");
        } 
        */







        #endregion

        #region Siparis Sayısı Odev2

        /** 
            Urun fiyati:5 Tl olsun
            Disaridan girilecek siparis sayisina gore
            20 de az ise toplam ucretten % 5 indirim yapilacak
            20 - 50 arasinda ise % 10 indirim
            50 - 100 arasinda ise % 15 indirim
            100 ve uzeri icin % 20 indirim yapilsin
            Ekrana Toplam tutar ,indirim miktari ve Odenecek tutar bilgilerini yazdirin



        int UrunFiyati;
        int SiparisAdedi;
        int ToplamTutar;
        double IndirimMiktari;
        double OdenecekTutar;

        UrunFiyati = 5;
        SiparisAdedi = 1;
     
        while (SiparisAdedi != 0)            
        {
            Console.WriteLine("Siparis Adedi Giriniz veya CIkmak icin -0- giriniz");
            SiparisAdedi = int.Parse(Console.ReadLine());
            if (SiparisAdedi < 20 && SiparisAdedi > 0)
            {
                Console.WriteLine("Toplam Tutar =" + (ToplamTutar = UrunFiyati * SiparisAdedi));
                Console.WriteLine("Indirim Miktari =" + (IndirimMiktari = ToplamTutar * 0.05));
                Console.WriteLine("Odenecek Tutar =" + (OdenecekTutar = ToplamTutar - IndirimMiktari));
            }

            else if (SiparisAdedi < 50 && SiparisAdedi >= 20)
            {
                Console.WriteLine("Toplam Tutar =" + (ToplamTutar = UrunFiyati * SiparisAdedi));
                Console.WriteLine("Indirim Miktari =" + (IndirimMiktari = ToplamTutar * 0.10));
                Console.WriteLine("Odenecek Tutar =" + (OdenecekTutar = ToplamTutar - IndirimMiktari));
            }

            else if (SiparisAdedi < 100 && SiparisAdedi >= 50)
            {
                Console.WriteLine("Toplam Tutar =" + (ToplamTutar = UrunFiyati * SiparisAdedi));
                Console.WriteLine("Indirim Miktari =" + (IndirimMiktari = ToplamTutar * 0.15));
                Console.WriteLine("Odenecek Tutar =" + (OdenecekTutar = ToplamTutar - IndirimMiktari));
            }

            else if (SiparisAdedi >= 100)
            {
                Console.WriteLine("Toplam Tutar =" + (ToplamTutar = UrunFiyati * SiparisAdedi));
                Console.WriteLine("Indirim Miktari =" + (IndirimMiktari = ToplamTutar * 0.20));
                Console.WriteLine("Odenecek Tutar =" + (OdenecekTutar = ToplamTutar - IndirimMiktari));
            }
            else if (SiparisAdedi == 0)
            {
                SiparisAdedi = 0;
                Console.WriteLine("Çıkış Yapılıyor. İyi Günler Dileriz");
            }

        }*/




        #endregion

        #region Urun Tanimlama Odev
        /*
        Disaridan urun adi girilecek
        program urunun hangi reyonda oldugunu soyleyecek
        Domates,biber,patlican icin Sebze Reyonu
        Diş mancunu, Parfum, Krem icin Kozmetik reyonu
        Telefon, Bilgisayar, Ses sistemleri icin Teknoloji reyonu
        Bunlardan farkli  bir urun girer ise "Bu urun bizde yok " uyarisi verecek
        
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
        }*/

        #endregion

        #region Haftanin Günleri

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

        #region Madde Hali

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

        #region Ternary IF

        /*Eger tek satırda bir kontrol yapılacaksa ? operatoru kullanılabılır
         Kullanımı; degisken = atanacakDeger== null? true

        string temp1=="", temp2;

        temp2 = temp1 == "" ? "Boş" : "Test";

        /*
        if (temp1 == "")

        {
        temp2 = "Boş"
        }

        else
        {
         temp2 = "Test"
        }

  
         */
        #endregion

        #region Ternary IF

        /*Console.WriteLine("Adinizi Giriniz:");
        string ad;

        ad = Console.ReadLine();
        temp1 = ad == null ? "" : "";
        */


        #endregion

        #region switch case kopyala

        /*
             * 
             * if - else mantigiyla benzerdir. Aradaki fark if-else buyukluk ,kucukluk gibi durmlari kontrol ederken ,switch case esitlik durumlarinda kullanilir.
             * EKndisine ait bir indexleme yapisi vardir 
             * O nedenle cok fazla sayida if else kullanilan durumlarda performans icin switch case tercih edilir
             * 
            

        string plakakodu;
        Console.WriteLine("Plaka kodunu giriniz");
        plakakodu = Console.ReadLine();

        if (plakakodu == "01")
        {
            Console.WriteLine("Adana");
        }
        else if (plakakodu == "02")
        {
            Console.WriteLine("Adiyaman");
        }
        else if (plakakodu == "03")
        {
            Console.WriteLine("Afyon");
        }
        else if (plakakodu == "04")
        {
            Console.WriteLine("Agri");
        }
        else if (plakakodu == "05")
        {
            Console.WriteLine("Amasya");
        }
        else if (plakakodu == "06")
        {
            Console.WriteLine("Ankara");
        }
        else if (plakakodu == "07")
        {
            Console.WriteLine("Antalya");
        }
        else if (plakakodu == "08")
        {
            Console.WriteLine("Artvin");
        }
        else if (plakakodu == "09")
        {
            Console.WriteLine("Aydin");
        }
        else if (plakakodu == "10")
        {
            Console.WriteLine("Balikesir");
        }

        switch (plakakodu)
        {

            case "01":
                Console.WriteLine("Adana");
                break;
            case "02":
                Console.WriteLine("Adiyaman");
                break;
            case "03":
                Console.WriteLine("Afyon");
                break;
            case "04":
                Console.WriteLine("Agri");
                break;
            case "05":
                Console.WriteLine("Amasya");
                break;
            case "06":
                Console.WriteLine("Ankara");
                break;
            case "07":
                Console.WriteLine("Antalya");
                break;
            case "08":
                Console.WriteLine("Artvin");
                break;
            case "09":
                Console.WriteLine("Aydin");
                break;
            case "10":
                Console.WriteLine("Balikesir");
                break;
            default:
                // Yukaridakilerin hicbiri olmaz ise default kismi calisir
                Console.WriteLine("Tanimsiz ");
                break;
        }


         */

        #endregion

        #region Kopyala

        /*string rol;
        Console.WriteLine("Rol Giriniz:");

        */

        #endregion

        #region Ekrandan girilen ayı okutma

        /*

        string ay;
        Console.WriteLine("Ay giriniz. [1-12]:");
        ay = Console.ReadLine();

        switch (ay)
        {
            case "1":
                Console.WriteLine("Ocak");
                break;

            case "2":
                Console.WriteLine("Şubat");
                break;

            case "3":
                Console.WriteLine("Mart");
                break;

            case "4":
                Console.WriteLine("Nisan");
                break;

            case "5":
                Console.WriteLine("Mayıs");
                break;

            case "6":
                Console.WriteLine("Haziran");
                break;

            case "7":
                Console.WriteLine("Temmuz");
                break;

            case "8":
                Console.WriteLine("Ağustos");
                break;

            case "9":
                Console.WriteLine("Eylül");
                break;

            case "10":
                Console.WriteLine("Ekim");
                break;

            case "11":
                Console.WriteLine("Kasım");
                break;

            case "12":
                Console.WriteLine("Aralık");
                break;

            default:

                Console.WriteLine("Tanimsiz ");
                break;
        }

                



        */


        #endregion

        #region

        string mevsim;
        Console.WriteLine("Mevsim adı giriniz.");
        mevsim = Console.ReadLine();

        switch (mevsim)
        {
            case "sonbahar":
                Console.WriteLine("Eylül, Ekim, Kasım");
                break;

            case "kis":
                Console.WriteLine("Aralık, Ocak, Şubat");
                break;

            case "ilkbahar":
                Console.WriteLine("Mart, Nisan, Mayıs");
                break;

            case "yaz":
                Console.WriteLine("Haziran, Temmuz, Ağustos");
                break;

            default:
                Console.WriteLine("Tanımsız");
                break;

        }


        #endregion


    }

}