using System;

namespace Convertor
{
    class Program
    {
        public enum Currency
        {
            USD = 1,
            EUR = 2,
            UAH = 3
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть значення 1,2 або 3:");
            Console.WriteLine("USD = 1");
            Console.WriteLine("EUR = 2");
            Console.WriteLine("UAH = 3");
            var a = Console.ReadLine();
            int i = Convert.ToInt32(a);
            Enum.TryParse<Currency>(a, out var b);
            switch (b)
            {
                case Currency.USD:
                    Console.WriteLine("До якого значення конвертувати 2 або 3:");
                    Console.WriteLine("EUR = 2");
                    Console.WriteLine("UAH = 3");
                    var c = Console.ReadLine();
                    Enum.TryParse<Currency>(c, out var d);
                    switch (d)
                        {
                            case Currency.EUR:
                            double ute = 0.87;
                            Console.WriteLine("Конвертацiя USD до EUR");
                            Console.WriteLine("Введiть суму в USD");
                            var p = Console.ReadLine();
                            int m = Convert.ToInt32(p);
                            Console.WriteLine("Cума в EUR = " + m * ute);
                                break;
                            case Currency.UAH:
                            double utu = 27.68;
                            Console.WriteLine("Конвертацiя USD до UAH");
                            Console.WriteLine("Введiть суму в USD");
                            var x = Console.ReadLine();
                            int v = Convert.ToInt32(x);
                            Console.WriteLine("Cума в UAH = " + v * utu);
                            break;
                        }
                    break;
                case Currency.EUR:
                    Console.WriteLine("До якого значення конвертувати 1 або 3:");
                    Console.WriteLine("USD = 1");
                    Console.WriteLine("UAH = 3");
                    var e = Console.ReadLine();
                    Enum.TryParse<Currency>(e, out var f);
                    switch (f)
                    {
                        case Currency.USD:
                            double etu = 1.15;
                            Console.WriteLine("Конвертацiя EUR до USD");
                            Console.WriteLine("Введiть суму в EUR");
                            var q = Console.ReadLine();
                            int n = Convert.ToInt32(q);
                            Console.WriteLine("Cума в USD = " + n * etu);
                            break;
                        case Currency.UAH:
                            double etua = 31.90;
                            Console.WriteLine("Конвертацiя EUR до UAH");
                            Console.WriteLine("Введiть суму в EUR");
                            var y = Console.ReadLine();
                            int z = Convert.ToInt32(y);
                            Console.WriteLine("Cума в UAH = " + z * etua);
                            break;
                    }
                    break;
                case Currency.UAH:
                    Console.WriteLine("До якого значення конвертувати 2 або 2:");
                    Console.WriteLine("USD = 1");
                    Console.WriteLine("EUR = 2");
                    var g = Console.ReadLine();
                    Enum.TryParse<Currency>(g, out var h);
                    switch (h)
                    {
                        case Currency.EUR:
                            double uteu = 0.031;
                            Console.WriteLine("Конвертацiя UAH до EUR");
                            Console.WriteLine("Введiть суму в UAH");
                            var l = Console.ReadLine();
                            int o = Convert.ToInt32(l);
                            Console.WriteLine("Cума в EUR = " + o * uteu);
                            break;
                        case Currency.USD:
                            double utusd = 0.036;
                            Console.WriteLine("Конвертацiя UAH до USD");
                            Console.WriteLine("Введiть суму в UAH");
                            var u = Console.ReadLine();
                            int s = Convert.ToInt32(u);
                            Console.WriteLine("Cума в USD = " + s * utusd);
                            break;
                    }
                    break;
            }
        }
    }
}
