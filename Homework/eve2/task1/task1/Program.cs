using System;

namespace task1
{
    class Program
    {
        static int GetDigitSum(int number)
        {
            int sum = 0;
            for (int i = 0; i <4; i++)
            {
                
                sum += number%10;
                number /= 10;
            }return sum;
        }
        static void Main(string[] args)
        {   start:
            Console.WriteLine("verilmish 4 reqemli ededin reqemlerinin cemini tap");
            Console.WriteLine("**************************************************");
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=1000&&Number<10000)
                {
                    Console.WriteLine(GetDigitSum(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil.");
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
