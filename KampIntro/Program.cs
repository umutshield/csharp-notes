using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 3.50;
            double dolarBugun = 3.50;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Sabittir butonu");
            }
        }
    }
} 