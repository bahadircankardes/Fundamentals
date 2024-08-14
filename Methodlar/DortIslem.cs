using System;
namespace Methodlar
{
	public class DortIslem
	{
        public static void Carpcıkarbol(double sayi1, double sayi2)
        {
            Console.WriteLine("Girilen İki Sayinin Çarpımı: " + sayi1 * sayi2);
            if (sayi2 < sayi1)
            {
                Console.WriteLine("Sayi1-Sayi2 = " + (sayi1 - sayi2));

            }
            else
            {
                Console.WriteLine("Sayi2-Sayi1 = " + (sayi2 - sayi1));

            }
            double bolum = (sayi1 / sayi2);
            Console.WriteLine("Birinci sayinin ikinci sayiya bolumu: " + bolum);
        }
    }
}

