namespace TryCatch;

class Program
{
    static void Main(string[] args)
    {

        #region Try Catch Konu Anlatımı

        /*
             * try catch => Hata Yakalaak icin kullanilan bir yapidir.
             * Hata => Hatalar 3 'e ayrilir
             *   1-Syntax Hatasi (Genelde IDE 'ler bu hatalari yazim sirasinda yakalarlar)
             *   2- RunTime Hatalari => Çalişma Zamani hatalari .
             *      Sifira Bolem Hatasi Calisma zamani hatasidir .
             *   3- Mantik hatalari =>Programcilarin yaptigi hatadir.
             *      Debug yaparak cozulur. 
             *      Bulunmasi ve cozumlenmesi ilk 2 duruma gore daha zordur.
             * 
             * Kullanimi => 
             * 
             *    try
             *    {
             *      Program akisinin gittigi yer
             *      Hata olursa eger catch bloguna düşecektir
             *    }
             *    catch (Exception ex)
             *    {
             *      Hata yakalandiginda ne yapilacaksa burada tanimlanir.
             *      
             *    }
             *    finally
             *    {
             *      // Bu bolum hata olsun olmasin mutlaka calisan bolumdur.
             *    }
             * 
             * 
             * 
             */




        #endregion

        #region Ornek 1




        //try
        //{
        //    int sayi1, sayi2;
        //    Console.WriteLine("Birinci sayiyi giriniz:");
        //    sayi1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ikinci sayiyi giriniz:");
        //    sayi2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Bolum :"+(sayi1/sayi2));
        //}

        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Sifira bolme hatasidir");
        //    //throw;
        //}

        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Duzgun sayi giriniz");
        //    //throw;
        //}
        //catch (OverflowException ex)
        //{
        //    Console.WriteLine("Cok buyuk sayi girdiniz.");
        //    //throw;
        //}
        //catch (Exception ex) // Exception hatasinin bulundugu catch blogu mutlaka en sona yazilmalidir
        //{
        //    Console.WriteLine("Bilinmeyen br hata ile karsilasildi");
        //    //throw;
        //}
        #endregion
        #region Kontrollu sayi okutulmasi
        // Butun veri tiplerinin tryparse metodunu vardir.
        int sayi1, sayi2;
        float fsayi;
        double dsayi;
        Console.WriteLine("Birinci sayiyi giriniz:");
        bool sonuc = int.TryParse(Console.ReadLine(), out sayi1);
        bool sonucd = double.TryParse(Console.ReadLine(), out dsayi);
        bool sonucf = float.TryParse(Console.ReadLine(), out fsayi);

        if (!sonuc)
        {
            Console.WriteLine("Okutulan Sayi Duzgun degildir");
        }
        Console.WriteLine("Ikinci sayiyi giriniz:");
        bool sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);

        #endregion
    }
}

