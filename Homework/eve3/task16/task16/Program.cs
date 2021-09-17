using System;

namespace task16
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
        static void Main(string[] args)
        {
            //Verilmish 6 reqemli ededde nece unikal reqem var ? (UNIKAL - Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)

            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("Meselenin serti:Verilmish 6 reqemli ededde nece unikal reqem var ?");
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine();
                Console.WriteLine("Serte uygun yoxlayacaginiz ededi daxil edin:");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 100000 && Number <= 999999)
                {

                    
                    int digit;
                    int seen=0;
                    int count=0;

                    do
                    {
                        digit = Number % 10;
                        if ((seen & (1<< digit))==0)
                        {
                            ++count;
                            seen = seen | (1 << digit);
                        }
                        Number = Number / 10;
                    } while (Number>0);
                    Console.WriteLine( "Verilmis 6 reqemli ededde {0} eded unikal reqem var: ",count);


                }

            }
        }
    }
}
