using System;

namespace task7
{
    class Program
    {
        static void ChequeNumber(int number)
        {
            int FirstDigit = number / 100;
            int LastDigit = number % 10;
            int Digit3 = (number % 100 - LastDigit) / 10;
            if (FirstDigit + LastDigit + Digit3 == FirstDigit * FirstDigit)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Meselenin serti:Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine();
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());


                if (number >= 100 && number <= 999)
                {

                    ChequeNumber(number);

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 3 reqemli deyil");
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

