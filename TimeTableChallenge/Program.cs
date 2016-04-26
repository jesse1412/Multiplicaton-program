using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableChallenge
{
    class Program
    {

        // Function to convert ints to words
        static string intToWord(int inputtedNumber)
        {

            string[] NineteenNumberStringNames = new string[20] 
                { 
                    "",
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine",
                    "ten",
                    "eleven",
                    "twelve",
                    "thirteen",
                    "fourteen",
                    "fifteen",
                    "sixteen",
                    "seventeen",
                    "eighteen",
                    "nineteen"
                };

            string[] TensStringNames = new string[10] 
                { 
                    "",
                    "ten",
                    "twenty",
                    "thirty",
                    "fourty",
                    "fifty",
                    "sixty",
                    "seventy",
                    "eighty",
                    "ninety",
                };

            bool greaterThanHundred = false;
            string outputString = "";

            if(inputtedNumber >= 100)
            {
                greaterThanHundred = true;
                inputtedNumber-=100;
            }
            if (inputtedNumber > 19)
            {
                outputString += TensStringNames[inputtedNumber / 10] + " " + NineteenNumberStringNames[(inputtedNumber - (inputtedNumber/10)*10)];
            }
            else
            {
                outputString = NineteenNumberStringNames[inputtedNumber];
            }
            if( greaterThanHundred )
            {
                outputString = "one hundred and " + outputString;
            }

            return outputString;
        }
        static void Main(string[] args)
        {
            do
            {

                string[] NineteenNumberStringNames = new string[19] 
                { 
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine",
                    "ten",
                    "eleven",
                    "twelve",
                    "thirteen",
                    "fourteen",
                    "fifteen",
                    "sixteen",
                    "seventeen",
                    "eighteen",
                    "nineteen"
                };
                int inputNumber = 0;

                Console.WriteLine("\nPlease enter a number between one & twelve:\n");
                string inputString = Console.ReadLine().ToLower();
                try
                {
                    inputNumber = int.Parse(inputString);
                }
                catch (Exception)
                {
                    for (int i = 1; i < 13; i++)
                    {
                        if (inputString == NineteenNumberStringNames[i - 1])
                        {
                            inputNumber = i;
                            break;
                        }
                    }
                }

                Console.WriteLine("\n");

                for (int i = 1; i < 13; i++)
                {
                    Console.WriteLine(intToWord(inputNumber) + " times " + intToWord(i) + " equals " + (intToWord(i * inputNumber)));
                }
            }
            while (true);
        }
    }
}
