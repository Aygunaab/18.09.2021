using System;

namespace task4
{
    class Program
    {
        public static double AdLastNumber(double number)
        {
           return number * 10 + 7;
        }
        public static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;
        }
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                while (i<5)
                {
                    Console.WriteLine("3 reqemli eded verilib. Bu ededin axirina 7 artir.Sonra cavabin 7 % tap; ");
                    Console.WriteLine();
                    Console.WriteLine("Ededi daxil edin");
                    double Number = Convert.ToDouble(Console.ReadLine());
                    if (Number > 100 && Number < 1000)
                    {

                        double NewNumber = (AdLastNumber(Number));
                        Console.WriteLine("Ededin sonuna 7 reqemi elave etmekle alinan eded:" + NewNumber);
                        Console.WriteLine();
                        Console.WriteLine("Yeni ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin;");
                        int Persent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yeni ededin  faizi:" + Percent(NewNumber, Persent));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 3 reqemli deyil");
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Duzgun ededi daxil edin");
            }


        }
    }
}
