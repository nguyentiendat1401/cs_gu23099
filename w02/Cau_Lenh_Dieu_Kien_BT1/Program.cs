using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap so ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number < 10)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }
        }
        else if (number >= 10 && number < 20)
        {
            int ones = number % 10;

            switch (ones)
            {
                case 0:
                    Console.WriteLine("ten");
                    break;
                case 1:
                    Console.WriteLine("eleven");
                    break;
                case 2:
                    Console.WriteLine("twelve");
                    break;
                case 3:
                    Console.WriteLine("thirteen");
                    break;
                case 4:
                    Console.WriteLine("fourteen");
                    break;
                case 5:
                    Console.WriteLine("fifteen");
                    break;
                case 6:
                    Console.WriteLine("sixteen");
                    break;
                case 7:
                    Console.WriteLine("seventeen");
                    break;
                case 8:
                    Console.WriteLine("eighteen");
                    break;
                case 9:
                    Console.WriteLine("nineteen");
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }
        }
        else if (number >= 20 && number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;

            string tensText = "";
            string onesText = "";

            switch (tens)
            {
                case 2:
                    tensText = "twenty";
                    break;
                case 3:
                    tensText = "thirty";
                    break;
                case 4:
                    tensText = "forty";
                    break;
                case 5:
                    tensText = "fifty";
                    break;
                case 6:
                    tensText = "sixty";
                    break;
                case 7:
                    tensText = "seventy";
                    break;
                case 8:
                    tensText = "eighty";
                    break;
                case 9:
                    tensText = "ninety";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }

            switch (ones)
            {
                case 0:
                    onesText = "";
                    break;
                case 1:
                    onesText = "one";
                    break;
                case 2:
                    onesText = "two";
                    break;
                case 3:
                    onesText = "three";
                    break;
                case 4:
                    onesText = "four";
                    break;
                case 5:
                    onesText = "five";
                    break;
                case 6:
                    onesText = "six";
                    break;
                case 7:
                    onesText = "seven";
                    break;
                case 8:
                    onesText = "eight";
                    break;
                case 9:
                    onesText = "nine";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }

            Console.WriteLine(tensText + " " + onesText);
        }
        else if (number >= 100 && number < 1000)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = (number % 100) % 10;

            string hundredsText = "";
            string tensText = "";
            string onesText = "";

            switch (hundreds)
            {
                case 1:
                    hundredsText = "one hundred";
                    break;
                case 2:
                    hundredsText = "two hundred";
                    break;
                case 3:
                    hundredsText = "three hundred";
                    break;
                case 4:
                    hundredsText = "four hundred";
                    break;
                case 5:
                    hundredsText = "five hundred";
                    break;
                case 6:
                    hundredsText = "six hundred";
                    break;
                case 7:
                    hundredsText = "seven hundred";
                    break;
                case 8:
                    hundredsText = "eight hundred";
                    break;
                case 9:
                    hundredsText = "nine hundred";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }

            switch (tens)
            {
                case 2:
                    tensText = "twenty";
                    break;
                case 3:
                    tensText = "thirty";
                    break;
                case 4:
                    tensText = "forty";
                    break;
                case 5:
                    tensText = "fifty";
                    break;
                case 6:
                    tensText = "sixty";
                    break;
                case 7:
                    tensText = "seventy";
                    break;
                case 8:
                    tensText = "eighty";
                    break;
                case 9:
                    tensText = "ninety";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }

            switch (ones)
            {
                case 0:
                    onesText = "";
                    break;
                case 1:
                    onesText = "one";
                    break;
                case 2:
                    onesText = "two";
                    break;
                case 3:
                    onesText = "three";
                    break;
                case 4:
                    onesText = "four";
                    break;
                case 5:
                    onesText = "five";
                    break;
                case 6:
                    onesText = "six";
                    break;
                case 7:
                    onesText = "seven";
                    break;
                case 8:
                    onesText = "eight";
                    break;
                case 9:
                    onesText = "nine";
                    break;
                default:
                    Console.WriteLine("Out of ability");
                    break;
            }

            Console.WriteLine(hundredsText + " and " + tensText + " " + onesText);
        }
        else
        {
            Console.WriteLine("Out of ability");
        }
    }
}