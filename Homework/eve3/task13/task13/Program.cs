using System;

namespace task13
{
    class Program
    {
        public static int GetDigit(int number, int digit)
        {
            for (int i = 0; i < digit - 1; i++)
            {
                number /= 10;
            }
            return number %= 10;
        }
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

        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish 7 reqemli eded polindromdursa o zaman onun daxilnde nece dene 0 reqemi oldugunu tap");

            
            start:
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 1000000 && Number <= 9999999)
                {
                    int Reversenumber = ReverseNumber(Number);

                    if (Number == Reversenumber)
                    {
                        int count = 0;
                        int[] digits = GetDigitarr(Reversenumber);
                         
                        for (int j = 0; j < digits.Length; j++)
                        {
                            if (0 == digits[j])
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Verilmis ededde 0 reqemi tapilmadi");
                        }
                        else
                        {
                            Console.WriteLine("Bu ededde {0} dene 0 var", count);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Daxil edilen eded palindrom deyil");
                    }

                }
                else
                {
                    Console.WriteLine("Daxil edilen eded 7 reqemli deyil");
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