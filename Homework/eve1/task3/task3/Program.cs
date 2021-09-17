using System;

namespace task3
{
    class Program
    {
        public static double FindPersent( double number,int persent)
        {
            return (double)number * persent / 100;
        }
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                while (i<5)
                {
                    Console.WriteLine("5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.");
                    Console.WriteLine();
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("Ededi daxil edin");
                    Console.WriteLine();
                    int Number = Convert.ToInt32(Console.ReadLine());
                    if (Number >= 10000 && Number < 100000)
                    {

                        double number = FindPersent(Number, 18);
                        Console.WriteLine();
                        Console.WriteLine("Verilmis ededin 18 faizi:" + number + "dir");
                        Console.WriteLine();
                        Console.WriteLine("Alinan neticenin 3 faizi " + FindPersent(number, 3) + "dur");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
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
