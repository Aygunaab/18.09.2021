using System;

namespace task8
{
    class Program
    { static int GetDigit(int Number,int digit)
        {
            for (int i = 0; i < digit-1; i++)
            {
                Number /= 10;
                
            }return Number %= 10;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  ");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine();
            Console.WriteLine("Ededi daxil edin");
            try
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=100)
                {
                    int Result = GetDigit(Number, 3) + GetDigit(Number, 1);
                    Console.WriteLine("Cavab:" +Result);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded serte uygun deyil");
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
