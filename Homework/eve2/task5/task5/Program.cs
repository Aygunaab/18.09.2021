using System;

namespace task5
{
    class Program
    {
        static int AddFirtNumberLast(int number)
        {
            int FirstDigit = number / 100000;
            return number * 10 + FirstDigit;
        }

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at. ");
            Console.WriteLine("******************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            try
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=100000&&Number<1000000)
                {
                    Console.WriteLine(AddFirtNumberLast(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            goto start;
        }
    }
}
