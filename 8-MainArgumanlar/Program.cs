namespace _8_MainArgumanlar;

class Program
{
    static void Main(string[] args)
    {
        /*
         * MainArgumanlari 3 5 *
         * 
         * string[] args dizisi disaridan programa  atanan degerleri tutar.
         * 
         */
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            if (args.Length == 0)
            {
                Console.WriteLine(@"Program Kullanimi 
<birinciSayi> <ikincisayi> <operator>
Ornek: MainArgumanlari 3 5 +");
            }

            switch (args[2])
            {

                case "+":
                    Console.WriteLine("Toplam:" + (int.Parse(args[0]) + int.Parse(args[1])));
                    break;
                case "-":
                    Console.WriteLine("Cikarma:" + (int.Parse(args[0]) - int.Parse(args[1])));
                    break;
                case "*":
                    Console.WriteLine("CArpma:" + (int.Parse(args[0]) * int.Parse(args[1])));
                    break;
                case "/":
                    Console.WriteLine("Bolme:" + (int.Parse(args[0]) / int.Parse(args[1])));
                    break;
                default:
                    Console.WriteLine("+ , - , * , / ifadelerinden birisini kullaniniz");
                    break;
            }
        }
    }
}
