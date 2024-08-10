namespace Donguler;

class Program
{
    static void Main(string[] args)
    {
        #region For Dongusu

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
    }
}

