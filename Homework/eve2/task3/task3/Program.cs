using System;

namespace task3
{
    class Program
    {
        static int GetDigitMidSum(int number)
        {
            int sum = 0;
            int newNumber = (number % 1000000) / 1000;
            while (newNumber>0)
            {
                sum += newNumber % 10;
                newNumber /= 10;
            }
            return sum;
        }
    
        //static int GetDigit(int number,int digit)
        //{
        //    for (int i = 0; i < digit-1; i++)
        //    {
        //        number /= 10;
        //    }return number %= 10;
        //}
        //static int GetSumDigMedium(int digitone, int digittwo,int digitthree)
        //{
        //    return digitone + digittwo + digitthree;
        //}
        static void Main(string[] args)
        {   start:
            Console.WriteLine("Meselenin serti:Verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemini tapin");
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************");
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=100000000&&Number<1000000000)
                {
                    //Console.WriteLine("Cavab:{0}",GetSumDigMedium(GetDigit(Number,6),GetDigit(Number,5),GetDigit(Number,4)));
                    Console.WriteLine(GetDigitMidSum(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
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
