using System;

namespace task3
{
    class Program
    {
        static void ChequeNumber(int number)
        {
            int LastDigit = number % 10;
            if (LastDigit == 7)
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
            Console.WriteLine("Meselenin serti:Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana");
            Console.WriteLine( );
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                ChequeNumber(Number);
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            goto start;
        }
    }
}
