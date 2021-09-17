using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {       //    
                // IF operatoru ile yoxla. 
                //Verilmish ededdin 1 - ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
                //Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster

            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number>=1&&Number<=365)
            {
                if (Number>=1&&Number<=31)
                {
                    Console.WriteLine("Yanvar ayidir");
                    if (Number>=1&&Number<=20)
                    {
                        Console.WriteLine("Oxatan burcudur");
                    }
                    else
                    {
                        Console.WriteLine("Oglaq burcudur");
                    }
                   
                }
                else if (Number>=32&&Number<=60)
                {
                    Console.WriteLine("Fevral ayidir");
                }
                else if (Number > 60 && Number <= 91)
                {
                    Console.WriteLine("Mart ayidir");
                }
                else if(Number>91&&Number<=121){
                    Console.WriteLine("Aprel ayidir");
                }
                else if (Number>121&&Number<=151)
                {
                    Console.WriteLine("May ayidir");
                }
                else if (Number>151&&Number<=181)
                {
                    Console.WriteLine("Iyun ayidir");
                }
                else if (Number > 181 && Number <= 212)
                {
                    Console.WriteLine("Iyul ayidir");
                }
                else if (Number > 212 && Number <= 243)
                {
                    Console.WriteLine("Avqust ayidir");
                }
                else if (Number > 243&& Number <= 273)
                {
                    Console.WriteLine("Sentyabr ayidir");
                }
                else if (Number > 272 && Number <= 304)
                {
                    Console.WriteLine("Oktyabr ayidir");
                }
                else if (Number>304&&Number<=335)
                {
                    Console.WriteLine("Noyabr ayidir");
                }
                else if (Number>335 &&Number<=365)
                {
                    Console.WriteLine("Dekabr ayidir");
                }


            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz eded serte uygun deyil");
            }
        }
    }
}
