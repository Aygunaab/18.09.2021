using System;

namespace task6
{
    class Program
    { static int DeletDigitFirstLast(int number)
        {
            return ((number % 10000000) - (number % 10))/10;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et ");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            try
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=10000000&&Number<100000000)
                {
                    Console.WriteLine( "Cavab: "+DeletDigitFirstLast(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 8 reqemli deyil");
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
