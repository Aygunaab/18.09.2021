using System;

namespace task14
{
    class Program
    {
        static int Percent(int number,int percent)
        {
            return number * percent / 100;
        }
        static int GetdigitMultiply(int number)
        {
            int multiply = 1;
            int Numbernew = number / 10000;
            while (Numbernew>0)
            {
                multiply *= Numbernew %10;
                Numbernew /= 10;
            }
            return multiply;

        }
        static void Main(string[] args)
        {
            //  4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            // Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            // Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.
           start:
            try
            {
                int sum = 0;
                int sum1 = 0;
                int multiply = 1;
                int result = 0;


                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("{0} .6 reqemli ededi daxil edin", i + 1);
                    int Number = Convert.ToInt32(Console.ReadLine());
                    int NewNumber;
                    if (Number >= 100000 && Number < 1000000)
                    {
                        NewNumber = Number / 1000;

                        sum += NewNumber;
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                    }
                }
                Console.WriteLine("7 reqemli ededi daxil edin");
                int NumberOne = Convert.ToInt32(Console.ReadLine());
                if (NumberOne >= 1000000 && NumberOne < 10000000)
                {
                    int NewNumberone = NumberOne % 10000;
                    sum1 = sum + NewNumberone;
                    multiply = GetdigitMultiply(NumberOne);
                    result = sum1 - multiply;

                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 7 reqemli deyil");
                }
                int Result = (Percent(result, 60)) * 100 + 60;
                int ResultOne = (Percent(result, 60)) * 100 + 60;
                Console.WriteLine("6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.");
                Console.WriteLine("Cavab: " + sum);
                Console.WriteLine();
                Console.WriteLine(" Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel");
                Console.WriteLine("Cavab: " + sum1);
                Console.WriteLine();
                Console.WriteLine("Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.");
                Console.WriteLine("Cavab: " + result);
                Console.WriteLine();
                Console.WriteLine("Neticenin 60 % tap.Cavabin axirina 60 artir.");
                Console.WriteLine("Cavab: " + Result);
                Console.WriteLine();
                Console.WriteLine("Neticeden 18 % cix.");
                Console.WriteLine("Cavab:{0}", Result - Percent(Result, 18));
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            
           
        }
    }
}
