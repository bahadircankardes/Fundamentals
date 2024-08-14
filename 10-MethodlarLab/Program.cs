namespace _10_MethodlarLab;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(Kdvdahil(100, 20));
        Console.WriteLine(Kdvharic(120, 20));
        Console.WriteLine(SehirSec());
        Console.WriteLine(HızHesapla(200, 90));
        Console.WriteLine(Faktoriyel(4));
        //Console.WriteLine(DiziOlustur(5));

        Console.ReadLine();
    }

    #region Kdv Hesaplaama Metodu

    /* Kdv Hesaplaama Metodu Yaziniz KDV Hesapla(100,20) = 120 tl geri dönecek*/

    public static double Kdvdahil(double fiyat, double kdv)
    {
        Console.WriteLine("Kdv'li Fiyat:"); return(fiyat*((100+kdv)/100));

    }

    #endregion

    #region Kdv siz fiyatı geri dönen Metod

    /* Kdv siz fiyatı geri dönen Metodu Yaziniz*/

    public static double Kdvharic(double Kdvlifiyat, double kdv)
    {
        Console.WriteLine("Kdv'siz Fiyat:");
        return (Kdvlifiyat/((100+kdv)/100));

    }

    #endregion

    #region Random Sehir Dönen Metod
    //Asagidaki sehirlerden rastgele bir sehir geri donen metod yaziniz.

    public static string SehirSec()
    {
        string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
"Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
"Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
"Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
"Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
"Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
"Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
"Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
"Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        Random random = new Random();
        int sayi = random.Next(1, sehirler.Length);
        return (sehirler[sayi]);
    }





    #endregion

    #region HızHesapla Metodu

    /* HizHesapla(yoluzunlugu,sure) => geri donusu bu yolu ne kadar 
             *                          hizla gidecegi olacak*/

    public static double HızHesapla(double yol, double zaman)
    {
        
        return (yol / (zaman/60));

    }

    #endregion

    #region DiziOlusturma Metodu olmadı tekrar bak

    /* DiziOlustur(elemanSayisi) => verilen elemanSayisi kadar dizi 
             *   olusturup  1-100 aasinda rasgele degerlerle dolu bir 
             *   dizi geri donecek*/

    /*public static int[] DiziOlustur(int elemansayisi)
    {
        Random rnd = new Random();
        int[] sayilar = new int [elemansayisi];
        
        for (int i= 0; i < sayilar.Length; i++)
        {
            sayilar[i] = rnd.Next(1, 100);
            return (sayilar);
        }

        for (int j = 0; j < sayilar.Length; j++)
        {
            Console.WriteLine(sayilar[j]);
        }


    }
    */

    #endregion

    #region Recursive Fonsksiyonlar
    /*Kendi kendini çağıran fonksiyonlardır.
     * Bu durum fonksiyonun bir koşul sağlanana kadar kendini tekrar tekrar çağırması
     * demektir.
     */
    public static long Faktoriyel (int sayi)
    {
        if (sayi == 0)
        {
            return 1;
        }

        else
        {
            return sayi * Faktoriyel(sayi - 1);
        }
    }
    #endregion

}

