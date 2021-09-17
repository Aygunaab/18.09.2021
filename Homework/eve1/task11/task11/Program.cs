using System;

namespace task11
{
    class Program
    {
        static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;
        }
        static double GetMultypli(double numberone,double numbertwo)
        {
            return numberone * numbertwo;
        }
        static double GetSum(double numberone,double numbertwo)
        {
            return numberone + numbertwo;
        }
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Meselenin serti:4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.Sonra cavablari vur birbirine.Alinan neticeden III ededin 3 % -ni cix.");
            try
            {
                Console.WriteLine("Birinci ededi daxil edin");
                double NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin");
                double NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ucuncu ededi daxil edin");
                double NumberThree = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dorduncu ededi daxil edin");
                double NumberFour = Convert.ToDouble(Console.ReadLine());
                if (NumberOne > 10000 && NumberOne < 100000 && NumberTwo > 10000 && NumberTwo < 100000 && NumberThree > 10000 && NumberThree < 100000 && NumberFour > 10000 && NumberFour < 100000)
                {

                    Console.WriteLine(" Her I ededin ustune III ededi gel");
                    double ResultSumOne = GetSum(NumberOne, NumberThree);
                    Console.WriteLine("Cavab: {0}-dir ", ResultSumOne);
                    Console.WriteLine(" Her II ededin ustune IV ededi gel");
                    double ResultSumTwo = GetSum(NumberTwo, NumberFour);
                    Console.WriteLine("Cavab: {0}-dir ", ResultSumTwo);
                    Console.WriteLine();
                    Console.WriteLine("Sonra cavablari vur birbirine");
                    double ResultMultypli = GetMultypli(ResultSumOne, ResultSumTwo);
                    Console.WriteLine("Cavab: {0}-dir", ResultMultypli);
                    Console.WriteLine("Alinan neticeden III ededin 3 % -ni cix.");
                    double Result = ResultMultypli - Percent(NumberThree, 3);
                    Console.WriteLine("Meselenin sertine uygun netice: {0}-dir", Result);
                }

                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
                }
            }


            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
        }
    }
}
