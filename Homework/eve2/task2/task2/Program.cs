using System;

namespace task2
{
    class Program
    {
        //static int GetDigit(int Number,int digit)
        //{
        //    for (int i = 0; i < digit-1; i++)
        //    {
        //        Number /= 10;
        //    }return Number % 10;
        //}
        //static int GetSum(int numberone,int numbertwo,int numberthree)
        //{
        //    return numberone + numbertwo + numberthree;
        //}
        static int GetDigitSum(int number)
        {
            int sum = 0;
            int newnumber = number / 1000;
            while (newnumber>0)
            {
                sum += newnumber % 10;
                newnumber /= 10;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Meselenin serti: Verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3");
            try
            {
                Console.WriteLine("Ededi daxil edin");
                Console.WriteLine("*****************");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100000 && Number < 1000000)
                {
                    //Console.WriteLine(GetSum((GetDigit(Number, 6)), (GetDigit(Number, 5)), (GetDigit(Number, 4))));
                    Console.WriteLine(GetDigitSum(Number));
                }
                else
                {
                    Console.WriteLine("Daxil etdiiniz eded 6 reqemli deyil");
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
