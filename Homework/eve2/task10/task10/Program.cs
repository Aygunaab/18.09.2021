using System;

namespace task10
{
    class Program
    {
        static int ReverseNumber(int number)
        {
            int  reverse = 0, rem;

            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            return reverse;
            }

        static int GetCount(int number)
        {
            int count = 0;
            while (number>0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
        static int[] GetDigitarr(int number)
        {
            int counter = GetCount(number);
            int[] arr = new int[counter];
            int index = 0;
           
            while (number>0)
            {
                arr[index] = number % 10;
                number /= 10;
                index++;

            }
            return arr;
        }
        static int GetOneRowDigitİnNumber(int number)
        {
            int[] arr = GetDigitarr(number);
            int newnumber = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                newnumber *= 10;
                newnumber += arr[i];
                i++;

            }
            return newnumber;

        }
        static int GetDoubleRowDigitİnNumber(int number)
        {
            int[] arr = GetDigitarr(number);
            int newnumber = 0;
            int result = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                newnumber *= 10;
                newnumber += arr[i];
                i++;

            }
            return newnumber;

        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Meselenin serti:9 reqemli ededdi tek yerde dayananlardan bir eded duzlet, sonra cut yerde dayanlarinda bir eded duzlet,sonra onlari topla");
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("9 reqemli ededi daxil edin:");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetCount(Number));

                if (Number > 100000000 && Number < 1000000000)
                {
                    int NumberOneRow = ReverseNumber(GetOneRowDigitİnNumber(Number));
                    Console.WriteLine("Tek yerde duran ededlerden duzelen yeni eded:  " + NumberOneRow);
                    Console.WriteLine();
                    int NumberDoubleRow = ReverseNumber(GetDoubleRowDigitİnNumber(Number));
                    Console.WriteLine("Cut yerde duran ededlerden duzelen yeni eded:  " + NumberDoubleRow);
                    Console.WriteLine();
                    Console.WriteLine("Ededin tek ve cut yerlerinde duran reqemlerinden alinan yeni ededlerin cemi:{0} ",NumberOneRow+NumberDoubleRow );


                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 9 reqemli deyil");
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
