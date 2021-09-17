using System;

namespace task10
{
    class Program
    {
        static void GetMaxMinNumber(){
            int max = 0, min = 0 ,number;
            for (int j = 1; j <= 6; j++)
            {
                Console.Write("{0}. Ededi daxil edin: ", j);
                number = Convert.ToInt32(Console.ReadLine());
                if (j == 1)
                {
                    max = number;
                    min = number;
                }
                if (min > number)
                { min = number; }
                if (max < number)
                { max = number; }

            }

            Console.WriteLine("En boyuk eded {0}", max);
            Console.WriteLine("En balaca eded {0}", min);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
           start:
            try
            {
                GetMaxMinNumber();
            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }



        }
    }
}
