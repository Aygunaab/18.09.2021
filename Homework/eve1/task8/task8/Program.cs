using System;

namespace task8
{
    class Program
    {
        public static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;
        }
        public static double GetSum (double NumberOne,double Numbertwo)
        {
            return NumberOne + Numbertwo;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Meselenin serti:2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir. I ededin 4 % -ni tap.Sonra II ededin 9 % ni tap.Sonra Cavalari toplayib 10 % ni tap.");
            try
            {
                 start:
                    Console.WriteLine("Dord reqemli ededi daxil edin");
                    double NumberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Yeddi reqemli ededi daxil edin");
                    double NumberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    if (NumberOne>=1000&&NumberOne<10000 && NumberTwo >= 1000000 && NumberTwo < 10000000)
                    {
                        Console.WriteLine("4 reqemli ededin hesablayacaginiz faizini daxil edin:");
                        int percent = Convert.ToInt32(Console.ReadLine());
                        double NumberPercentOne = Percent(NumberOne, percent);
                        Console.WriteLine("Alinan cavab: "+NumberPercentOne);
                        Console.WriteLine();
                        Console.WriteLine("7 reqemli ededin hesablayacaginiz faizi daxil edin:");
                        int percentone = Convert.ToInt32(Console.ReadLine());
                        double NumberPercentTwo = Percent(NumberTwo, percent);
                        Console.WriteLine("Alinan cavab: " + NumberPercentTwo);
                        Console.WriteLine();
                        double Sum=GetSum(NumberPercentOne, NumberPercentTwo);
                        Console.WriteLine("Faizleri tapilmaqla alinan cavablarin toplami: "+Sum);
                        Console.WriteLine();
                        Console.WriteLine("Alinan cavabin 10%-i: " +Percent(Sum,10));
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded serte uygun deyil");
                    }
                goto start;
                

            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
        }
    }
}
