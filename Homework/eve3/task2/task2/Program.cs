
using System;

namespace task2
{
    class Program
    {
        static void ChequeNumber(double numberone,double numbertwo)
        {

            if (numberone % numbertwo == 0)
            {
                double divaded = numberone / numbertwo;
                Console.WriteLine(divaded);
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }
        }
        static void Main(string[] args)
        {

            start:
                Console.WriteLine(" Meselenin serti:Iki eded verilib .Eger birinci eded ikinci edede tam bolunurse o zaman cavabi cixart.Eks halda bolunmur sozunu cap et");
                Console.WriteLine();
                Console.WriteLine("***********************************************************************************************************************");
                Console.WriteLine();
            try
            {
                Console.WriteLine("Birinci ededi daxil edin");
                double NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin");
                double NumberTwo = Convert.ToDouble(Console.ReadLine());
                ChequeNumber(NumberOne, NumberTwo);

            }
            catch (Exception)
            {

                Console.WriteLine("Dogru ededi daxil edin");
            }
            goto start;

            }
        }
    }

