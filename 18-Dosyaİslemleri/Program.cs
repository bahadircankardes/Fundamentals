using Bogus;
namespace _18_Dosyaİslemleri;

internal class Program
{
    public struct Sehir
    {
        public string PlakaKodu;
        public string IL;
    }

    public struct Ilce
    {
        public string IlceKodu;
        public string Ilkodu;
        public string IlceAdi;
    }

    public struct Customer
    {
        public int Index;
        public string CustomerId;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Email;
        public DateTime SubscriptionDate;
        public string Website;

    }


    static void Main(string[] args)
    {
        #region Konu Anlatimi
        /*
         Dosya  icin hazır File sinifi kullanilabilir.
         *
        List<Sehir> sehirler = new List<Sehir>();//Dosyadan gelecek verileri tutmak icin
        string pathilDosyasi = @"//Users//bahadircankardes//source//repos//Wissen2024//Fundamentals//FundaMentals//18-Dosyaİslemleri//il.csv";
        string[] satirlar = File.ReadAllLines(pathilDosyasi);

        */

        /*
            *   "15","BURDUR" => 0. index deki satir
            *   "26","ESKİŞEHİR" => 1. index'deki satir
            *   "18","ÇANKIRI"
            * 
            */
        // Console.WriteLine("Plaka\t Sehir");
        /*

        foreach (var satir in satirlar)
        {
            Sehir sehir = new Sehir();
            string[] sutunlar = satir.Split(',');//0. Eleman PlakaKodu,1. Eleman Sehir
            sehir.PlakaKodu = sutunlar[0];
            sehir.IL = sutunlar[1];
            sehirler.Add(sehir);

            //Console.WriteLine(sutunlar[0] + "\t" + sutunlar[1]);//Gelen veriyi , ile ayirip
            //ayri bir dizi verir
        }
        */

        #endregion

        #region Tirnak Isaretinden Kurtulalım.
        /*
        for (int i = 0; i < sehirler.Count; i++)
        {
            Sehir sehir = sehirler[i];
            sehir.PlakaKodu = sehir.PlakaKodu.Replace('"', ' ');
            sehir.IL = sehir.IL.Replace('"', ' ');
            sehirler[i] = sehir;
        }

        */
        #endregion

        #region Ekrana Bastıralım
        /*
        foreach (var sehir in sehirler)
        {
            Console.WriteLine(sehir.PlakaKodu + " " + sehir.IL);
        }

        */
        #endregion

        #region İlceler
        /*
        var sonuc = IlceOku("//Users//bahadircankardes//source//repos//Wissen2024//Fundamentals//FundaMentals//18-Dosyaİslemleri//ilce.csv");
        Console.WriteLine("IlceKodu\tIlKodu\tIlceAdi");
        foreach (var item in sonuc)
        {
            Console.WriteLine(item.IlceKodu + "\t" + "\t" + item.Ilkodu + "\t" + item.IlceAdi);
        }
        */
        #endregion

        #region Büyük Dosya Okuma

        TimeSpan timeSpan = new TimeSpan();
        var startDate = DateTime.Now;
        var result = MusterileriOku(@"//Users//bahadircankardes//Downloads//customers.csv");
        Console.WriteLine("Hello, World!");
        timeSpan = DateTime.Now - startDate;
        Console.WriteLine("Toplam Okuma Suresi:" + timeSpan.TotalSeconds);
        #endregion

        #region Bogus Nuget



        #endregion
    }




    public static List<Ilce> IlceOku(string path)
    {
        List<Ilce> ilceler = new List<Ilce>();

        string[] ilceSatirlari = File.ReadAllLines(path);

        foreach (string item in ilceSatirlari)
        {
            Ilce ilce = new Ilce();
            string[] sutunlar = item.Split(',');
            ilce.IlceKodu = sutunlar[0];
            ilce.Ilkodu = sutunlar[1];
            ilce.IlceAdi = sutunlar[2];
            ilceler.Add(ilce);
        }
        return ilceler;
    }
    public static List<Customer>MusterileriOku(string path)
    {
        List<Customer> musteriler = new List<Customer>();

        string[] satirlar = File.ReadAllLines(path);
        for (int i = 1; i < satirlar.Length; i++)
        {
            Customer customer = new Customer();
            string[] sutunlar = satirlar[i].Split(',');
            int.TryParse(sutunlar[0], out customer.Index);
            customer.FirstName = sutunlar[1];
            customer.LastName = sutunlar[2];
            customer.Company = sutunlar[3];
            customer.City = sutunlar[4];
            customer.Country = sutunlar[5];
            customer.Phone1 = sutunlar[6];
            customer.Phone2 = sutunlar[7];
            customer.Email = sutunlar[8];
            DateTime.TryParse(sutunlar[9].ToString(), out customer.SubscriptionDate);
            customer.Website = sutunlar[10];

            musteriler.Add(customer);
        }
        return musteriler;
    }
}

