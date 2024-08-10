namespace Diziler;

internal class Program
{
    static void Main(string[] args)
    {
        /*
      Array => Dizi
     Birden fazla ayni tipten veriyi bir arada tutmamizi saglayan nesnelerdir
     Dizilerde eleman sayisi sabittir. Sonradan degistirilemezler. 

     Cok karsilasilan hata:  Index was outside the bounds of the array 
     Eger bu hatayi alirsaniz bilinki dizinin boyutunu asacak bir islem yapmaktasiniz.


      */
        // Dizi Tanimlama
        int[] sayilar;
        string[] gunler;

        // ilk deger atanmasi 
        //int[] notlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 
        // Dizideki elemanlara erişim 
        //Console.WriteLine(notlar[3]);

        // Dizilerde deger atama

        //notlar[20] = 1;

        //for (int i = 0; i < notlar.Length; i++)
        //{
        //    Console.WriteLine(notlar[i]);
        //}

        //char ch = 'a';// tek tirnak icerisinde tanimlanir ve tek bir karakter alir
        //string kelime = "cumartesi";


        //for (int i = 0; i < kelime.Length; i++)
        //{
        //    Console.WriteLine(kelime[i]);
        //}

        //int elemanSayisi = 0;
        //Console.WriteLine("Eleman Sayisinin Giriniz:");
        //elemanSayisi = int.Parse(Console.ReadLine());

        //// 2. Dizi Tanimalama Yontemi
        //int[] sayilar2 = new int[elemanSayisi];

        Random random = new Random();
        int temp;
        // Rastgele DEgerler atama
        //for (int i = 0; i < elemanSayisi; i++)
        //{
        //    temp = random.Next();
        //    sayilar2[i] = temp;
        //    Console.WriteLine(temp);
        //}
        //for (int i = 0; i < elemanSayisi; i++)
        //{
        //    Console.WriteLine(sayilar2[i]);
        //}
        #region Cok Boyutlu diziler
        // 2 boyut diziler icin tanimalama sekli 
        int[,] matris = new int[3, 3];
        // 3 boyutlu tanimlama icin 
        int[,,] vektor = new int[3, 3, 3];
        // Matris uzerinde deger atamasi icin ic ice 2 adet dogu kullanilir
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matris[i, j] = random.Next(100);
            }

        }

        // elelmana ulasmak icin 
        Console.WriteLine(matris[1, 2]);

        #region Sinavlari tutan dizi ornegi
        /* Sinvalari tutan dizi ornegi
            *  notlar[,] = new int[10,3]
            *  notlar[]
            * 
            * 
            */

        int[,] notlar = new int[10, 3];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                notlar[i, j] = random.Next(100);
            }
        }

        // 1. Ogrenci vize1:30 , Vize2 : 40 , Final :50 ; ortalamasi :50
        string mesaj = "";
        for (int i = 0; i < 10; i++)
        {
            mesaj = (i + 1) + ". Ogrencinin ";
            for (int j = 0; j < 3; j++)
            {


                mesaj += " " + (j + 1) + ". Sinavi: " + notlar[i, j];
            }
            Console.WriteLine(mesaj);
            mesaj = "";
        }

        #endregion
        #endregion
    }
}
