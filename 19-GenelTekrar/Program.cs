namespace _19_GenelTekrar;

internal class Program
{
    struct Urun
    {
        public string UrunAdi;
        public double Fiyat;
        public double Adet;
        public double Kdv;
        public double ToplamTutar;
        public double ToplamKdv;

    }

    static void Main(string[] args)
    {
        #region Ekrandan Girilen Gunun Hangı Gun Oldugunu Gerıye Donen Method
        //Console.WriteLine("1-7 arasi bir sayi giriniz: ");
        //int gun = int.Parse(Console.ReadLine());

        //var sonuc = GunuBil(gun);
        //Console.WriteLine(sonuc);
        //Console.ReadLine();

        #endregion

        KasaOkut();
        Console.ReadLine();
    }

    public static string GunuBil(int gun)
    {
        switch (gun)
        {
            case (1):
                return "Pazartesi";
                break;
            case (2):
                return "Sali";
                break;
            case (3):
                return "Carsamba";
                break;
            case (4):
                return "Persembe";
                break;
            case (5):
                return "Cuma";
                break;
            case (6):
                return "Cumartesi";
                break;
            case (7):
                return "Pazar";
                break;
            default:
                return"Yanlıs giris yaptınız. 1-7 arası seçim yapiniz.";
                break;
        }
    }

    public static void KasaOkut()
    {
        List<Urun> urunlistesi = new List<Urun>();

        do
        {
            Urun urun = new Urun();
            Console.WriteLine("Urun Adi Giriniz:");
            urun.UrunAdi = Console.ReadLine();
            Console.WriteLine("Adet Giriniz:");
            urun.Adet = double.Parse(Console.ReadLine());
            if (urun.Adet == 0)
            {
                break;
            }
            Console.WriteLine("Fiyat Giriniz:");
            urun.Fiyat = double.Parse(Console.ReadLine());
            Console.WriteLine("KDV Giriniz:");
            urun.Kdv = double.Parse(Console.ReadLine());
            urun.ToplamTutar = urun.Adet * urun.Fiyat;
            urun.ToplamKdv = urun.ToplamTutar - (urun.ToplamTutar / ((100 + urun.Kdv) / 100));
            urunlistesi.Add(urun);


        } while (true);
        double toplamkdv = 0, toplamtutar = 0;
        Console.WriteLine("Urunadi\t\tAdet\tFiyat\tKdv\tToplamTutar\n");
        foreach (var urun in urunlistesi)
        {
            Console.WriteLine($"{urun.UrunAdi}\t\t{urun.Adet}\t{urun.Fiyat}\t{urun.Kdv}\t{urun.ToplamTutar}");
            toplamkdv += urun.ToplamKdv;
            toplamtutar += urun.ToplamTutar;

        }
        Console.WriteLine($"Toplam Kdv:{toplamkdv.ToString("0.00")}  ToplamTutar:{toplamtutar.ToString("0.00")}");
    }

}

