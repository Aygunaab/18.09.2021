using System;

namespace task13
{
    class Program
    {
        static int GetCount(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;

            }
            return count;
        }
        static int GetNewNumber(int number)
        {

            int count = GetCount(number);
            int num = 1;
            for (int i = 0; i < count-1; i++)
            {
                num=num *= 10;
            }
           
            return number / num * 10 + number % 10;

        }
        static int Percent(int number,int percent)
        {
            return number * percent / 100;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("3 dene 5 reqemli eded var.Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet.Alinan neticeleri topla Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededleri daxil edin");
            Console.WriteLine( );
            try
            {
                Console.WriteLine("I eded:");
                int NumberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("II eded:");
                int NumberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("III eded:");
                int NumberThree = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (NumberOne>=10000&&NumberOne<100000&& NumberTwo >= 10000 && NumberTwo < 100000&& NumberThree >= 10000 && NumberThree < 100000)
                {
                    Console.WriteLine("Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet");
                    int NewNumberOne = GetNewNumber(NumberOne);
                    int NewNumberTwo = GetNewNumber(NumberTwo);
                    int NewNumberThree = GetNewNumber(NumberThree);
                    Console.WriteLine();
                    Console.WriteLine("Yeni ededler: Birinci ededden alinan yeni eded:{0} Ikinci ededden alinan yeni eded {1} Ucuncu ededden alinan yeni eded{2}",NewNumberOne,NewNumberTwo,NewNumberThree);
                    Console.WriteLine();
                    Console.WriteLine("Alinan neticeleri topla ");
                    int Sum = NewNumberOne + NewNumberTwo + NewNumberThree;
                    Console.WriteLine("Cavab:"+Sum);
                    Console.WriteLine();
                    Console.WriteLine("Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.");
                    int Result = Sum + Percent(Sum, 50);
                    Console.WriteLine("Yekun cavab"+Result);

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
