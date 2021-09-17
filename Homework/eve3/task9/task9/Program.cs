using System;

namespace task9
{
    class Program
    {
        static void GetMonth(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("Serte uygun eded deyil");
                    break;
            }
        }
        static void Main(string[] args)
        {
            // SWITCH operatoru ile yoxla. 
            //Verilmish ededdin 1 - ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
            // Eger bu eded
            //1 olarsa - "Yanvar" sozunu
            //2 olarsa - "Fevral" sozunu...
            //12 olarsa - "Dekabr" sozunu yaz

            int i = 1;
            while (i<3)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    GetMonth(number);
                }
                catch (Exception)
                {

                    Console.WriteLine("Dogru ededi daxil edin");
                }

              

            }



        }
    }
}
