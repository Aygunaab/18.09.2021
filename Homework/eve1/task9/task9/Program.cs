using System;

namespace task9
{
    class Program
    {
        public static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;

        }
        public static double GetSum(double numberone,double numbertwo,double numbertree)
        {
            return numberone + numbertwo + numbertree;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.");
            Console.WriteLine("*****************************************************************************************************");
            try
            {
                start:
                    Console.WriteLine();
                    Console.WriteLine("Birinci ededi daxil edin");
                    double NumberOne = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin");
                   double NumberTwo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ucuncu ededi daxil edin");
                    double NumberThree = Convert.ToDouble(Console.ReadLine());
                    if (NumberOne>100000&&NumberOne<1000000&& NumberTwo > 100000 && NumberTwo < 1000000&& NumberThree > 100000 && NumberThree < 1000000)
                    {
                        Console.WriteLine("Birinci ededin hesablamaq istediyiniz faizin daxil edin");
                        int PercentOne = Convert.ToInt32(Console.ReadLine());
                        double ResultOne = Percent(NumberOne, PercentOne);
                        Console.WriteLine("Cavab: "+ResultOne);
                        Console.WriteLine("Ikinci ededin hesablamaq istediyiniz faizin daxil edin");
                        int PercentTwo = Convert.ToInt32(Console.ReadLine());
                        double ResultTwo = Percent(NumberOne, PercentOne);
                        Console.WriteLine("Cavab: " + ResultTwo);
                        Console.WriteLine("Ucuncu ededin hesablamaq istediyiniz faizin daxil edin");
                        int PercentThree = Convert.ToInt32(Console.ReadLine());
                        double ResultThree = Percent(NumberThree, PercentThree);
                        Console.WriteLine("Cavab: " + ResultThree);
                        double Sum = ResultOne + ResultTwo + ResultThree;
                        Console.WriteLine("Daxil edilen ededlerin daxil etdiyiniz faiz qiymetleri ile toplanmasindan alinan cavab: "+Sum);
                        Console.WriteLine("Ededlerin faizinin toplanmasindan alinan ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin");
                        int percent = Convert.ToInt32(Console.ReadLine());

                        double Result = Percent(Sum, percent);
                        Console.WriteLine("Alinan netice : "+Result);

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
