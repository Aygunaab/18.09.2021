using System;

namespace task10
{
    class Program
    {
        static double Percent(double number,int percent)
        {
            return (double)number * percent / 100;
        }
        static double MinusNumber(double numberone, double numbertwo, double numberthree)
        {
            return numberone - numbertwo - numberthree;
        }
        static double GetSum(double numberone,double numbertwo)
        {

            return numberone + numbertwo;
        }
        static void Main(string[] args)
        {
        start:
            Console.WriteLine(" Meselenin serti:3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.  Neticeleri bir birinden cix.Alinan cavabin ustune III ededin 7 % faizini gel");
            try
            {
           
                Console.WriteLine("Birinci ededi daxil edin");
                double NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ikinci ededi daxil edin");
                double NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ucuncu ededi daxil edin");
                double NumberThree = Convert.ToDouble(Console.ReadLine());
                if (NumberOne>=1000&&NumberOne<10000&& NumberTwo >= 1000 && NumberTwo < 10000&& NumberThree >= 1000 && NumberThree < 10000)
                {
                    Console.WriteLine("Birinci ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin");
                    int PercentOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikinci ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin");
                    int PercentTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ucuncu ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin");
                    int PercentThree = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Birinci ededin faizinden alinan cavab: " + Percent(NumberOne,PercentOne));
                    Console.WriteLine("Ikinci ededin faizinden alinan cavab: " + Percent(NumberTwo,PercentTwo));
                    Console.WriteLine("Ucuncu ededin faizinden alinan cavab: " + Percent(PercentThree,PercentThree));
                    Console.WriteLine("Cixmaq istediyiniz ededleri daxil edin");
                    Console.WriteLine("I ededi yazin");
                    double NumberOneMinus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("II ededi yazin");
                    double NumberTwoMinus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("III ededi yazin");
                    double NumberThreeMinus = Convert.ToDouble(Console.ReadLine());
                    double ResultMinus = MinusNumber(NumberOneMinus, NumberTwoMinus, NumberThreeMinus);
                    Console.WriteLine("Cavab: " + ResultMinus);
                    Console.WriteLine();
                    Console.WriteLine("Meselenin sertine uygun neticeni cixaraq: ");
                    Console.WriteLine();
                    double Result = ResultMinus + Percent(NumberOne, 7);
                    Console.WriteLine("Netice: " + Result);
                    Console.WriteLine();
                    Console.WriteLine("********************************************************************************************");

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
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
