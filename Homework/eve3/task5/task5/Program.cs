using System;

namespace task5
{
    class Program
    {
        static int Getdigit(int number,int digit)
        {
            for (int i = 0; i < digit-1; i++)
            {
                
                number /= 10;
            }return number %= 10;

        }
        static int GetSum(int numberone,int numbertwo)
        {
            return numberone + numbertwo;
        }
        static int GetMultiply(int numberone,int numbertwo)
        {
            return numberone * numbertwo;
        }
        static void Main(string[] args)
        {start:

            Console.WriteLine(" Meselenin serti:Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman  hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.");
            
                Console.WriteLine();
                Console.WriteLine("************************************************************************************************");
                Console.WriteLine();
            try
            {
                Console.WriteLine("Ededi daxil edin");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number > 10 && Number < 99)
                {
                    
                    int sum = GetSum(Getdigit(Number, 2), Getdigit(Number, 1));
                    
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine(GetMultiply(Getdigit(Number,2),Getdigit(Number,1)));
                    }
                    else
                    {
                        Console.WriteLine("Verilmis ededin reqemleri cemi cut deyil");
                    }
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded 2 reqemli deyil");
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
    

