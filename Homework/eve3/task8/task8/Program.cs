
using System;

namespace task8
{
    class Program
    { static void GetDayWeek(int number)
        {
            int LastDigit = number % 10;
            switch (LastDigit)
            {
                case 1:
                    Console.WriteLine("I gun");
                    break;
                case 2:
                    Console.WriteLine("II gun");
                    break;
                case 3:
                    Console.WriteLine("III gun");
                    break;
                case 4:
                    Console.WriteLine("VI gun");
                    break;
                case 5:
                    Console.WriteLine("V gun");
                    break;
                case 6:
                    Console.WriteLine("VI gun");
                    break;
                case 7:
                    Console.WriteLine("VII gun");
                    break;
                default:
                    Console.WriteLine("Daxil edilen eded serte uygun deyil");
                    break;
            }
        }
        static void Main(string[] args)
        {

            // SWITCH operatoru ile yoxla. 
            //Verilmish ededdin sonuncu reqemi

            //1 olarsa - "I gun" sozunu

            // 2 olarsa - "II gun" sozunu...
            //7 olarsa - "VI gun" sozunu yaz

            int i = 1;
            while (i < 3)
            {
                Console.WriteLine("Meselenin serti:Verilmish ededdin sonuncu reqemi 1 olarsa - I gun sozunu 2 olarsa - II gun sozunu...7 olarsa - VII gun sozunu yaz  ");
                Console.WriteLine();
                Console.WriteLine("****************************************************************************************************************");
                Console.WriteLine();
                try
                {
                    Console.WriteLine("Ededi daxil edin");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    GetDayWeek(Number);
                }
                catch (Exception)
                {

                    Console.WriteLine("Dogru ededi daxil edin");
                }

            }


        }
    }
}
