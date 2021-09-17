using System;

namespace task7
{
    class Program
    { 
       static int ReverceNumber(int number)
        {
            int Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number = number / 10;
            }
            return Reverse;
        }
        static int AddDigit(int number)
        {
            return (ReverceNumber(number) + 80000) * 10 + 8;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir");
            Console.WriteLine("********************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            try
            {
                int Number = int.Parse(Console.ReadLine());
                if (Number>=1000&&Number<10000)

                {
                    
                    Console.WriteLine("Cavab: "+AddDigit(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }

        }
    }
}
