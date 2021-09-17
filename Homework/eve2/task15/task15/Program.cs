using System;

namespace task15
{
    class Program
    {
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
        static int GetDigitSum(int number)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {

                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static int ReverceNumber(int number)
        {
            int Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number = number / 10;
            }
            return Reverse;
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
            for (int i = 0; i < arr.Length; i++)
            {
                newnumber *= 10;
                newnumber += arr[i];
                i++;

            }
            return newnumber;

        }

        static void Main(string[] args)
        {
            //5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap 
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix. 
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //Cavabin axirina 11 artir.
            //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            start:
            Console.WriteLine("5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.");
            Console.WriteLine();
            Console.WriteLine("Nece dene eded daxil etmek isteyirsiniz ? Ededin sayini daxil edin");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[count];
            int ResultOne = 0;
            int sum = 0;
            int sum2 = 0;
            int sumdigit = 0;
            int Result1 = 0;
            int Result2 = 0;
            int Result3 = 0;
            int Result4 = 0;
            int Result5 = 0;
            int Resultminus = 0;
            int Result6 = 0;
            int NewSumNumber = 0;


            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("{0}.Ededi daxil edin",i+1);
                int Number = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = Number;
               int counter= GetCount(Number);
               
                if (counter==3)
                {
                   
                    sum +=  Numbers[i];

                    
                   Result1=  Numbers[i]*1000+ Numbers[i-1] ;
                   
                    ResultOne = sum + Result1;

                }
                else if (counter==6)
                {
                    sum2 += Numbers[i];
                    NewSumNumber = sum2 % 1000;
                    
                }
                else if (counter==7)
                {
                   int newNumber = Number % 100000;
                    Result2 = ResultOne - newNumber;
                    sumdigit = GetDigitSum(Numbers[i]);
                    int reverse = ReverceNumber(sumdigit);
                    Result3 = NewSumNumber + Result2; 
                    Result4 = Result3 + reverse;
                    Result5 = Result4 * 100 + 11;
                    Resultminus = ReverceNumber(GetOneRowDigitİnNumber(Numbers[i]));
                    Result6 = Resultminus - Result5;

                }
        
            }
            Console.WriteLine("3 reqemli ededlerin cemini tap .");
            Console.WriteLine("Cavab:{0} ",sum);
            Console.WriteLine();
            Console.WriteLine("Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.");
            
            Console.WriteLine("Cavab: {0}",ResultOne);
            Console.WriteLine();
            Console.WriteLine("Cavabdan 7 reqemli ededin son 5 reqemini cix. ");
            Console.WriteLine("Cavab: {0}",Result2);
            Console.WriteLine();
            Console.WriteLine("Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.");
            Console.WriteLine("Cavab: {0}",Result3);
            Console.WriteLine();
            Console.WriteLine("Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.");
            Console.WriteLine("Cavab: {0}",Result4);
            Console.WriteLine();
            Console.WriteLine("Cavabin axirina 11 artir.");
            Console.WriteLine("Cavab: {0}",Result5);
            Console.WriteLine();
            Console.WriteLine("Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.");
            Console.WriteLine("Cavab: {0}",Result6);
            goto start;

        }
    }
}
