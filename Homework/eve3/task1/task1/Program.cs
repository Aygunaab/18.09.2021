using System;

namespace task1
{
    class Program
    {
        static void EvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Eded cutdur");
            }
            else
            {
                Console.WriteLine("Eded tekdir");
            }
        }
        static void Main(string[] args)
        {
           start:
            try
            {
                Console.WriteLine("Meselenin serti:Verilmis ededlerin tek ve ya cut oldugunu yoxla");
                Console.WriteLine();
                Console.WriteLine("***************************************************************");
                Console.WriteLine();
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                EvenNumber(Number);

            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            goto start;
            
               
            
        }
    }
}
