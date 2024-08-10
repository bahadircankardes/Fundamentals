namespace Donguler;

class Program
{
    static void Main(string[] args)
    {
        #region For Dongusu
        /*
             For dongusu : Bir başlangic degeri olan ve bir kosula dek devam eden ve belirledigimiz artişa göre hareket eden bir yapidir
             Syntax : 
                for(başlangiç;koşul;artim)
                {

                }
             */

        //1-100 arasındaki tek sayiları yazdıralım.

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine((i%2==0?"":"Tek"+i));
        }

        for (int i = 1; i < 100; i=i+2)
        {
            Console.WriteLine(i);
        }
        #endregion

        #region Dizinin eleman sayisini degistirme
        //int[] sayilar = {1,2,3,4,5,6,7,8,9};
        //for (int i = 0; i < sayilar.Length; i++)
        //{

        //    Console.WriteLine(sayilar[i]);
        //}
        //int[] yeniDizi;
        //int elemansayisi ;
        ////yeniDizi = sayilar;
        //Console.WriteLine("Yeni eleman sayisini giriniz:");
        //elemansayisi = int.Parse(Console.ReadLine());

        //yeniDizi = new int[elemansayisi];
        //yeniDizi =sayilar;
        //for (int i = 0;i < sayilar.Length;i++) 
        //{
        //    yeniDizi[i] = sayilar[i];

        //}
        //sayilar = yeniDizi;

        //for (int i = 0; i < sayilar.Length; i++)
        //{

        //    Console.WriteLine(sayilar[i]);
        //}
        //yeniDizi[0] = 99999;
        //Console.WriteLine(sayilar[0]);
        #endregion


        #region While Dongusu
        //While döngüsü koşul doğru olduğu sürece işlemleri gerçekleştiren bir döngü tipidir.
        //Eğer koşu yanlış işe döngü tamamlanır.
        //for döngüsünde olduğu gibi, bir koşul sağlandığı sürece dönmeye devam eder.
        //Koşul yanlış(false) sonucunu verdiği zaman ise sonlandırılır.
        //Genel yazım şekli şöyledir:

        //while (kosul)
        //{
        //    continue;
        //    break;
        //}

        #endregion

        #region Ornekler
        // 1-10 arasindaki tek sayilari bastiralim

        //int sayac = 1;
        //while (sayac <= 10)
        //{
        //    int sonuc = sayac % 2;
        //    if(sonuc != 0) Console.WriteLine(sayac);
        //    sayac++;
        //}


        #endregion

        #region Devam etmek istiyormusunuz [E/H] sorusuna 'H' diyene kadar calisack while dongusu

        string cevap = "";
        int sayac = 0;
        while (cevap != "H")
        {
            Console.WriteLine(sayac);
            cevap = Console.ReadLine().ToUpper();
            sayac++;
        }



        #endregion
    }
}

