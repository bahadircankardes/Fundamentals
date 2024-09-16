using static Odevler.Program;

namespace Odevler;

internal class Program
{
    public struct Urun
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
        #region Urunleri Dosyadan Okutalım ve liste içinde tutalım
        List<Urun> urunler = new List<Urun>();//Dosyadan Gelen veiler tutulacak bu listede
        string [] satirlar = File.ReadAllLines(@"/Users/bahadircankardes/Desktop/urunler.csv");
        for (int i = 1; i < satirlar.Length; i++ )
        {
            satirlar[i] = satirlar[i].Replace('"', ' ');
            //Console.WriteLine(satirlar[i]);
            //Console.WriteLine("--------------------------");
            satirlar[i] = satirlar[i].Trim();
            var sutunlar = satirlar[i].Split(";");
            Urun urun = new Urun();
            urun.UrunAdi = sutunlar[0];
            urun.Fiyat = double.Parse(sutunlar[1]);
            urun.Adet = double.Parse(sutunlar[2]);
            urun.Kdv = double.Parse(sutunlar[3]);
            urunler.Add(urun);
            urun.ToplamKdv = urun.Fiyat * urun.Adet * urun.Kdv / 100;
            urun.ToplamTutar = urun.Fiyat * urun.Adet + urun.ToplamKdv;

        }
        Console.WriteLine("Urun Adı:"+ "\t"+ "Urun Fiyati:" + "\t" + "Urun Adedi:" + "    " + "Urun Kdv:" + "    \t" + "ToplamKdv:" + " " + "Toplam Tutar");
        double totalkdv = 0;
        double totaltutar = 0;
        
        foreach (var urun in urunler)
        {
            totalkdv += urun.ToplamKdv;
            totaltutar += urun.ToplamTutar;
            Console.WriteLine($"{ urun.UrunAdi} \t{urun.Fiyat}\t{urun.Adet}\t\t{urun.Kdv}\t{urun.ToplamKdv}\t{urun.ToplamTutar}\n");
            
            //Console.WriteLine(urun.UrunAdi);
            //Console.WriteLine(urun.Fiyat);
            //Console.WriteLine(urun.Adet);
            //Console.WriteLine(urun.Kdv);
        }

        //for (int i = 0; i < urunler.Count; i ++)
        //{
        //    Console.WriteLine(urunler[i]);
        //}

        //urun.UrunAdi = sutunlar[1]

        //var sutunlar = satirlar[i].Split(";");

        //foreach (var sutuna in collection)
        //{

        //}

        //for (int i = 0; i < satirlar.Length; i++)
        //{
        //    Urun urun = new Urun();
        //    urun.UrunAdi = sutunlar[0].Replace('"', ' ');
        //    urun.Fiyat = double.Parse(sutunlar[1].Replace('"', ' '));
        //    urun.Adet = double.Parse(sutunlar[2].Replace('"', ' '));
        //    urun.Kdv = double.Parse(sutunlar[3].Replace('"', ' '));
        //    urunler.Add(urun);


        //} 

        ////for (int i = 0; i < urunler.Count; i++)
        ////{

        ////}
        ///

        Console.ReadLine();
        #endregion

        

       
        


       
    }
}
