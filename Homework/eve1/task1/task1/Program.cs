using System;

namespace task1
{
    class Program
    {
        public static int AddLastAndFirstNumber (int number)
        {
            int newNumber = (number + 70000) * 10 + 8;
            return newNumber;
        }
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                try
                {
                    Console.WriteLine("4 reqemli eded verilib.Bu ededin eveline 7 reqemini,axirinada 8 reqemini artir.");
                    Console.WriteLine();
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("Ededi daxil edin");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    if (Number >= 1000 && Number < 10000)
                    {
                        Console.WriteLine(AddLastAndFirstNumber(Number));
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 4 reqemli deyil");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun reqemi daxil edin");
                }
            }
        }
    }
}
