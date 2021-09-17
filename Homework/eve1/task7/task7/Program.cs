using System;

namespace task7
{
    class Program
    {
        public static double GetSum(double numberone,double numbertwo)
        {
            return numberone + numbertwo;
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
                    Console.WriteLine("2 dene 5 reqemli eded verilib. Bu ededleri toplayib.Alinan cavabin evvelineve axirina 5 artir.Neticenin 5 % tap");
                    Console.WriteLine("***************************************************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("Birinci ededi daxil edin");
                    double NumberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikinci ededi daxil edin");
                    double NumberTwo = Convert.ToInt32(Console.ReadLine());
                    if (NumberOne>=10000&&NumberTwo>=10000&&NumberOne<100000&&NumberTwo<100000)
                    {
                        double NewNumber = GetSum(NumberOne, NumberTwo);
                        Console.WriteLine("Daxil etdiyiniz ededin toplami: " + NewNumber);
                        Console.WriteLine("Alinan cavabin evveline ve sonuna 5 artir");
                        if (NewNumber >= 10000 && NewNumber < 100000)
                        {
                            double ResultOne = (NewNumber + 500000) * 10 + 5;
                            Console.WriteLine("Evveloine ve sonuna 5 reqemi artirmaqla alinan yeni reqem: "+ResultOne);
                            Console.WriteLine();
                            Console.WriteLine("Alinan neticenin nece faizin hesablamaq isteyirsiz? Faizi daxil edin");
                            int percent = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Percent(ResultOne,percent));
                        }
                        else if (NewNumber >= 100000)
                        {
                            double ResultTwo = (NewNumber + 5000000) * 10 + 5;
                            Console.WriteLine("Evveloine ve sonuna 5 reqemi artirmaqla alinan yeni reqem: " + ResultTwo);
                            Console.WriteLine();
                            Console.WriteLine("Alinan neticenin nece faizin hesablamaq isteyirsiz? Faizi daxil edin");
                            int percent = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Percent(ResultTwo, percent));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 5 reqemli deyil");
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
