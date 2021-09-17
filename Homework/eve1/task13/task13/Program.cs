using System;

namespace eve13
{

    class Program
    {
        static int Percent(int number, int percent)
        {
            return number * percent / 100;
        }


        static void Main(string[] args)
        {
        start:
            Console.WriteLine("5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.\n 5 reqemli ededlerin 5 % tap, neticeleri vur bir birine.\n Sonra 3 reqemli ededlerin 3 % tap, neticeleri topla.\nSonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.");

            Console.WriteLine("Ededleri daxil edin");
            Console.WriteLine("Birinci 5 reqemli ededi daxil edin");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci 5 reqemli ededi daxil edin");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu 5 reqemli ededi daxil edin");
            int NumberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dorduncu 3 reqemli ededi daxil edin");
            int NumberFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Besinci 3 reqemli ededi daxil edin");
            int NumberFive = Convert.ToInt32(Console.ReadLine());

            if (NumberOne >= 10000 && NumberOne < 100000 && NumberTwo >= 10000 && NumberTwo < 100000 && NumberThree >= 10000 && NumberThree < 100000 && NumberFour >= 100 && NumberFour < 1000 && NumberFive >= 100 && NumberFive < 1000)
            {
                int ResultOne = Percent(NumberOne, 5) * Percent(NumberTwo, 5) * Percent(NumberThree, 5);
                int ResultTwo = Percent(NumberFour, 3) + Percent(NumberFive, 3);
                Console.WriteLine(Percent(ResultOne, 10) + Percent(ResultTwo, 10));
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded serte uygun deyil");
            }

            goto start;

        }
    }
}
