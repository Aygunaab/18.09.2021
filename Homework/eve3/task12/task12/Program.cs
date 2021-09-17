using System;

namespace task12
{
    class Program
    {
        public static int GetDigit(int number, int digit)
        {
            for (var i = 0; i < digit - 1; i++)
                number /= 10;
            return number % 10;
        }

        static void Main(string[] args)
        { 
            // Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
            //Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
            //Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.

            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number>=100000&&Number<=999999)
            {
                int NewNumber = (Number + 8000000) * 10 + 8;
                Console.WriteLine( "Daxil olan ededin evveline ve axrina 8 artirmaqla alinan yeni eded: "+NewNumber);
                int FirstfourDigit = NewNumber / 10000;
                int LastfourDigit = NewNumber % 10000;
                int NewNumberReverse = LastfourDigit * 10000 + FirstfourDigit;
                Console.WriteLine( "Yeni reqemin son 4 reqemi ile ilk 4 reqeminin yerini deyismekle alinan eded: "+NewNumberReverse);


                
               
                int Result = ((((((GetDigit(NewNumberReverse, 7)) * 10 + (GetDigit(NewNumberReverse, 6) * 0)) * 10 + GetDigit(NewNumberReverse, 5)) * 10 + (GetDigit(NewNumberReverse, 4) * 0)) * 10 + GetDigit(NewNumberReverse, 3)) * 10 + (GetDigit(NewNumberReverse, 2) * 0)) * 10 + GetDigit(NewNumberReverse, 1);
                int decimalLength = Result.ToString("D").Length + 1;
                Console.WriteLine("Ededin tek yerde duran reqemlerini 0-a cevirmekle alinan eded:" +Result.ToString("D" + decimalLength.ToString()));
                


            }


           
        }
    }
}
