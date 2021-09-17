using System;

namespace task11
{
    class Program
    {
        static int GetSumNumber(int number){
            int sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Meselenin serti:Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse o zamanbu ededdin ilk 2 reqemini son 2 reqemine yapishdir.Neticenin ustune ortaya dushen 2 reqemini gel.");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());

                if (Number >= 100000 && Number <= 999999)
                {
                    int Number1 = Number / 1000;
                    int Number2 = Number % 1000;
                    int sum1 = GetSumNumber(Number1);

                    Console.WriteLine("Ededin ilk uc reqeminin cemi:" + sum1);
                    int sum2 = GetSumNumber(Number2);
                    Console.WriteLine("Ededin son uc reqeminin cemi:" + sum2);
                    if (sum1 == sum2)
                    {
                        int Number3 = Number / 10000;
                        int Number4 = Number % 100;
                        int Number5 = Number / 100 % 100;
                        int Number6 = Number3 * 100 + Number4;
                        int result = Number6 + Number5;
                        Console.WriteLine("Netice:" + result);

                    }
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

