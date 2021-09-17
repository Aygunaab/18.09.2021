using System;

namespace task12
{
    class Program
    {
        static int GetDigitSum(int number)
        {
            int sum = 0, digit;
           
            while (number > 0)
            {
                digit = number % 10;
                sum = sum + digit;
                number = number / 10;
            }
            return sum;
        }
        static int GetDigitMultiply(int number)
        {
            int multiply=1 , digit;

            while (number > 0)
            {
                digit = number % 10;
                multiply = multiply * digit;
                number = number / 10;
            }
            return multiply;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("2 dene 5 reqemli eded daxil et.  I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.Neticenin axirina I ededin en axiinci reqemini artir.");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("I 5 reqemli ededi daxil edin");
                int NumberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("II 5 reqemli ededi daxil edin");
                int NumberTwo = Convert.ToInt32(Console.ReadLine());
                if (NumberOne>=10000&&NumberOne<100000&& NumberTwo >= 10000 && NumberTwo < 100000)
                {
                    int SumNumberOne = GetDigitSum(NumberOne);
                    Console.WriteLine("Birinci ededin reqemleri cemi: {0}-dir",SumNumberOne);
                    Console.WriteLine();
                    int MultiplyNumberTwo = GetDigitMultiply(NumberTwo);
                    Console.WriteLine("Ikinci ededin reqemleri hasili: {0}-dir", MultiplyNumberTwo);
                    Console.WriteLine();
                    int Sum = SumNumberOne + MultiplyNumberTwo;
                    Console.WriteLine("Birinci ededin reqemleri cemini ile ikinci ededin reqemlerinin hasilinin toplanmasindan alinan eded: {0}",Sum);
                    Console.WriteLine();
                    int Result = Sum * 10 + NumberOne % 10;
                    Console.WriteLine("Meselenin sertine uygun olaraq alinan cavab: {0}",Result);
                    Console.WriteLine();
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
