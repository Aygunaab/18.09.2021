using System;

namespace task11
{
    class Program
    { 
        static int Percent(int number,int percent)
        {
            return number * percent / 100;
        }
        static int GetCount(int number){
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
            int[] arr = new int[counter/2];
            int index = 0;

            while (number > 0)
            {
                arr[index] = number % 100;
                number /= 100;
                index++;

            }
            return arr;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("8 reqemli ededin reqemlerini iki -iki qruplashdir. Qruplarin cemini tap.Alinan cavabin axirina 99 artir.Sonra cavabin ozunden onun 18 % ni cix; ");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("8 reqemli ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 10000000 && Number < 100000000)
                {
                    Console.WriteLine();
                    int[] arr = GetDigitarr(Number);
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {

                        sum += arr[i];
                    }
                    Console.WriteLine("8reqemli ededin iki iki qruplasdirilmasinin toplanmasindan alinan cavab: " + sum);
                    Console.WriteLine();
                    int NewNumber = sum * 100 + 99;
                    Console.WriteLine("Cavabin sonuna 99 artirmaqla alinan yeni eded: "+ NewNumber);
                    Console.WriteLine();
                    int result = NewNumber - Percent(NewNumber, 18);
                    Console.WriteLine("Alinan yeni ededden ozunun 18 faizini cixmaqla alinan cavab: "+result);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 8 reqemli deyil");
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
