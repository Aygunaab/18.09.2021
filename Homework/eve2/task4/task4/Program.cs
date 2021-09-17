using System;

namespace task4
{
    class Program
    { static int GetDigit(int Number,int digit)
        {
            for (int i = 0; i < digit-1; i++)
            {
                Number /= 10;
            }return Number %= 10;
        }
        static int GetQuadratic(int number)
        {
            return number * number;
        }
        static void Main(string[] args)
        { start:
            Console.WriteLine(" Meselenin serti:Verilmis 5 reqemli ededin ilk ve son reqemlerinin ceminin kvadratini tapin");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine();
                try
            {
                Console.WriteLine("5 reqemli ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (Number>=10000&&Number<100000)
                {
                    int sum=((GetDigit(Number,1)+GetDigit(Number,5)));
                    Console.WriteLine(GetQuadratic(sum));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
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
