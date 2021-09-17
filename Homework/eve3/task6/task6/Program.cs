using System;

namespace task6
{
    class Program
    {
        static void ChequeDigit (int number)
        {
            int firstDigit = number % 10;
            int MidDigit = (number % 100 - firstDigit) / 10;
            int LastDigit = number / 100;
            int sum = firstDigit + LastDigit;

            if (sum == MidDigit)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
        static void Main(string[] args)
        { start:
            Console.WriteLine("Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana");
                Console.WriteLine();
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine();
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100 && Number <= 999)
                {
                    ChequeDigit(Number);

                }
                else
                {
                    Console.WriteLine(" Daxil edilmis eded 3 reqemli deyil");
                }
            }
            catch (Exception)
            {

                Console.WriteLine(  "Dogru ededi daxil edin");
            }
            goto start;
                
            
        }
    }
}
