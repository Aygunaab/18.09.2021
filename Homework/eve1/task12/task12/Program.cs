using System;

namespace task12
{
    class Program
    {
        static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;
        }
        static double GetSum(double number1,double number2,double number3 , double number4)
        {
            return number1 + number2 + number3 + number4;
        }
        static double Getmultiply(double numberone,double numbertwo)
        {
            return numberone * numbertwo;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla. Sonra yekunda alinanlar iki cavabi vur biri birine.Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("4 dene 6 reqemli eded verilib. Ededleri daxil edin");
                Console.WriteLine("**************************************************");
                Console.WriteLine("I ededi daxil edin");
                double NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("II ededi daxil edin");
                double NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("III ededi daxil edin");
                double NumberThree = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("IV ededi daxil edin");
                double NumberFour = Convert.ToDouble(Console.ReadLine());
                if (NumberOne>=100000&&NumberOne<1000000&&NumberTwo>=100000&&NumberTwo<1000000 && NumberThree >= 100000 && NumberThree < 1000000 && NumberFour >= 100000 && NumberFour < 1000000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ededlerin hamisinin 10 faizini tap ve topla.");
                    Console.WriteLine();
                    double ResultOnePercent = Percent(NumberOne, 10);
                    double ResultTwoPercent = Percent(NumberTwo, 10);
                    double ResultThreePercent = Percent(NumberThree, 10);
                    double ResultFourPercent = Percent(NumberFour, 10);
                    double ResultSum = GetSum(ResultOnePercent, ResultTwoPercent, ResultThreePercent, ResultFourPercent);
                    Console.WriteLine("Cavab: {0}-dir",ResultSum);
                    Console.WriteLine();
                    Console.WriteLine("Ededlerin hamisinin 15 faizini tap ve topla.");
                    double ResultOnePercent1 = Percent(NumberOne, 15);
                    double ResultTwoPercent2 = Percent(NumberTwo, 15);
                    double ResultThreePercent3 = Percent(NumberThree, 15);
                    double ResultFourPercent4 = Percent(NumberFour, 15);
                    double ResultSum1 = GetSum(ResultOnePercent1, ResultTwoPercent2, ResultThreePercent3, ResultFourPercent4);
                    Console.WriteLine("Cavab: {0}-dir", ResultSum1);
                    Console.WriteLine();
                    Console.WriteLine("Sonra yekunda alinan iki cavabi vur biri birine");
                    double Resultmultypli = Getmultiply(ResultSum, ResultSum1);
                    Console.WriteLine("Cavab: {0}-dir",Resultmultypli);
                    Console.WriteLine();
                    Console.WriteLine("Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap");
                    double Result = Percent((Percent(Resultmultypli, 10)), 11);
                    Console.WriteLine("Son netice: {0}-dir",Result);


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin"); ;
            }
            goto start;

        }
    }
}
