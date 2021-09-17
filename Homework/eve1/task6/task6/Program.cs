using System;

namespace task6
{
    class Program
    {
        public static double Percent(double number,int persent)
        {
            return (double)number * persent / 100;
        }
        public static double GetQuadratic(double number)
        {
            return number * number;
        }
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                while (i<5)
                {
                    Console.WriteLine("***************************************************************************************************************");
                    Console.WriteLine("4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10 % tap.Alinan  cavabin kvadratini tap. ");
                    Console.WriteLine("***************************************************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("Ededi daxil edin");
                    Console.WriteLine();
                    double Number = Convert.ToDouble(Console.ReadLine());
                    if (Number>=1000&&Number<10000)
                    {
                        Console.WriteLine("Ededin nece faizin hesablamaq isteyirsiniz?Faizi daxil edin");
                        int percent = Convert.ToInt32(Console.ReadLine());
                        double NewNumber = Percent(Number,percent);
                        Console.WriteLine("Faizin tapmaqla aldiginizi eded: " +NewNumber);
                        Console.WriteLine("Faizin tapmaqla aldiginiz cavabin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin");
                        Console.WriteLine();
                        int PercentOne = Convert.ToInt32(Console.ReadLine());
                        double NewNumberTwo = Percent(NewNumber, PercentOne);
                        Console.WriteLine("Alinan cavab: " + NewNumberTwo);
                        Console.WriteLine();
                        Console.WriteLine("Kvadratin hesablamaq istediyiniz ededi daxil edin");
                        double Quadratic = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Daxil etdiyiniz ededin  kvadrati"+GetQuadratic(Quadratic));

                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Duzgun eded daxil edin");
            }


        }
    }
}
