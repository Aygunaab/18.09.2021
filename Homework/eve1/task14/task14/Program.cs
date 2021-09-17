using System;

namespace task14
{
    class Program
    {
        static int Percent(int number,int percent)
        {
            return number * percent / 100;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.  I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel.Yekunda alinan cavabin 11 % tap.");
            try
            {
                Console.WriteLine("Eded sayini daxil edin:");
                int count = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                int Result1 = 0;
                int Result2 = 0;
                int Result3 = 0;
                int[] Numbers = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("{0} Ededi daxil edin",i+1);
       
                    Numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (Numbers[i]>=100000&&Numbers[i]<1000000)
                    {
                        sum = Numbers[0]+Numbers[1]+ Numbers[2] + Numbers[3]+ Numbers[4] + Numbers[5];
                        Result1 = (Numbers[0] * 1000000) + Numbers[2];
                        Result2 = Percent(sum - Result1,10);
                        Result3 = Percent(Result2 + Numbers[4] + Numbers[5], 11);

                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded 6 reqemli deyil");
                    }
                    
                }
                Console.WriteLine("6 dene 6 reqemli eded verilib. Evvel hamisini topla");
                Console.WriteLine("Cavab: {0}", sum);
                Console.WriteLine();
                Console.WriteLine("Sonra I ve III ededi bir birine yapishdir ve bir eded al.");
                Console.WriteLine("Cavab: {0}", Result1);
                Console.WriteLine();
                Console.WriteLine("I neticeden II neticeni cix.Alinan cavabin 10 % tap");
                Console.WriteLine("Cavab: " + Result2);
                Console.WriteLine();
                Console.WriteLine(".Neticenin uzerine V ve VI ededleri gel.Yekunda alinan cavabin 11 % tap");
                Console.WriteLine("Cavab: " + Result3);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
