using System;

namespace task9
{
    class Program
    {


        static int ReverseNumber(int number)
        {
            int reverse = 0, rem;

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
            while (number > 0)
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

            while (number > 0)
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

        static void Main(string[] args)
        {   start:
            Console.WriteLine("9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(  );
            Console.WriteLine("Ededi daxil edin");
            try
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number>=100000000&&Number<1000000000)
                {
                    Console.WriteLine(ReverseNumber(GetOneRowDigitİnNumber(Number)));
                   
                }
            }
            catch (Exception)
            {

                Console.WriteLine( "Dogru ededi daxil edin");
            }
            goto start;
        }
    }
}
