using System;

namespace task4
{
    class Program
    {
        static void ChequNumber(int number)
        {
            int firstDigit = number % 10;
            int LastDigit = number / 10;
            if (number > 10 && number < 99)
            {
                if (firstDigit == LastDigit)
                {
                    Console.WriteLine("beli");
                }
                else
                {
                    Console.WriteLine("Xeyr");
                }
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded ikireqemli deyil");
            }
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine(" Meselenin serti:Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana");
           
            Console.WriteLine("***********************************************************************************************");
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                ChequNumber(Number);

            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            goto start;

            
        }
    }
}
