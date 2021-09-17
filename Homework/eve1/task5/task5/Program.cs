using System;

namespace task5
{
    class Program
    {
        public static double Persent(double number,int persent)
        {
            return (double)number * persent / 100;
        }
        public static double AddFirstLastNumber(double number, int firstNumber, int lastTwoNumber)
        {
            return (number + 10000*firstNumber) * 100 + lastTwoNumber;
        }
        static void Main(string[] args)
        {

            try
            {
                int i = 0;
                while (i<5)
                {
                    Console.WriteLine("Meselenin serti:4 reqemli eded verilib. Bu ededin evvelin 4 reqemi,axirina ise 44 ededini artir.Alinan cavabin 44 % tap.");
                    Console.WriteLine();
                    Console.WriteLine(  "**********************************************************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("Ededi daxil edin");
                    double Number = Convert.ToDouble(Console.ReadLine());
                    if (Number >= 1000 && Number < 10000)
                    {
                        Console.WriteLine("Reqemin evveline elave edeceyiniz reqemi daxil edin");
                        int firsNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Reqemin sonuna elave edeceyiniz iki reqemli ededi daxil edin");
                        int lastTwoNumber = Convert.ToInt32(Console.ReadLine());
                        if (lastTwoNumber >= 10 && lastTwoNumber < 100 && firsNumber > 0 && firsNumber < 10)
                        {
                            double newNumber=AddFirstLastNumber(Number, firsNumber, lastTwoNumber);
                            Console.WriteLine("Ededin evveline ve sonuna elave etdiyiniz reqemlerle alinan yeni eded:" + newNumber);
                            Console.WriteLine("Yeni ededin nece faizini hesablamaq isteyirsiniz? Faizi daxil edin:");
                            int persent = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yenin ededin hesabladiginiz faizi: "+Persent(newNumber,persent));
                        }
                        else
                        {
                            Console.WriteLine("Ededin evveline ve sonuna elave edeceyiniz ededler serte uygun deyil.Yeniden serte uygun dogru reqemleri daxil edin");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
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
