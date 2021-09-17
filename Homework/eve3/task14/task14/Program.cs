using System;

namespace task14
{
    class Program
    {
        static int GetCount(int number)
        {
            int count = 0;
            while (number>0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        static int AddFirstDigit(int number)
        {
            int counter = GetCount(number);
            int result = 0;
            int multiplynumber=1;
            for (int i = 0; i < counter; i++)
            {
                multiplynumber *= 10;
                result = number + multiplynumber;
            }
            return result;
        }
        static void Main(string[] args)
        { start:
            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler\n" +
                "(bu o demekdirki 1, 2, 3, 4, 5, 6, 7 reqemlide ola biler Bu ededin evvelin 1 reqemini artir.");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine();

            try
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 0 && Number <= 99999999)
                {

                    Console.WriteLine(AddFirstDigit(Number));
                }
                else
                {
                    Console.WriteLine("Daxil edilen eded serte uygun deyil");
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