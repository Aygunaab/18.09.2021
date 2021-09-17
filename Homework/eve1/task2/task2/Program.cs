using System;

namespace task2
{
    class Program
    {
        public static int AddThreeLastDigit(int number)
        {
            int newNumber = number * 1000 + number;
            return newNumber;
        }
        static void Main(string[] args)
        {

            try
            {
                int i = 0;
                while (i<5)
                {
                    Console.WriteLine("3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.");
                    Console.WriteLine("************************************************************************** ");
                    Console.WriteLine("Ededi daxil edin");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    if (Number >= 100 && Number < 1000)
                    {
                        Console.WriteLine(AddThreeLastDigit(Number));
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 3 reqemli deyil");
                    }

                }

            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
        }
    }
}
