namespace Topic_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int minInt, maxInt, dice1, dice2, decimalRound, minDecimalPrecision, maxDecimalPrecision;
            double minDouble, maxDouble, minDecimal, maxDecimal, doubleRandomNumber;
            bool done = false;

            minInt = 0;
            minDecimal = 0;
            minDouble = 0;
            maxInt = 0;
            maxDecimal = 0;
            maxDouble = 0;
            decimalRound = 0;
            minDecimalPrecision = 0;
            maxDecimalPrecision = 0;
            doubleRandomNumber = 0;

            Console.Write("Please enter a min: ");
            while (!Int32.TryParse(Console.ReadLine(), out minInt))
            {
                Console.Write("Invalid input, please try again... ");
            }

            Console.WriteLine();

            while (!done)
            {
                Console.Write("Please enter a max: ");
                while (!Int32.TryParse(Console.ReadLine(), out maxInt))
                {
                    Console.Write("Invalid input, please try again... ");
                }

                if (minInt > maxInt)
                {
                    Console.WriteLine();

                    Console.WriteLine("The min can't be bigger than the max! Please enter a valid max");

                    Console.WriteLine();
                }
                else
                {
                    done = true;
                }
            }

            done = false;

            Console.WriteLine();

            Console.WriteLine("Generating a number between " + minInt + " and " + maxInt + "...");

            Thread.Sleep(1000);

            Console.WriteLine();

            Console.WriteLine("The number is: " + generator.Next(minInt, maxInt + 1));

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("It's time to roll some dice! ");

            dice1 = generator.Next(1, 7);
            dice2 = generator.Next(1, 7);

            Thread.Sleep(1000);

            Console.WriteLine("The first dice rolled a " + dice1 + " and the second dice rolled a " + dice2 + "! The sum of the two dice rolls is " + (dice1 + dice2));

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("It's time to generate some numbers with decimals! But first you must specify some things...");

            Console.WriteLine();

            while (!done)
            {
                Console.Write("How many decimals do you want the number to be rounded to? ");
                while (!Int32.TryParse(Console.ReadLine(), out decimalRound))
                {
                    Console.Write("Invalid input, please try again... ");
                }
                if (decimalRound < 0)
                {
                    Console.WriteLine("The decimal to round to cannot be a negative... Please enter a valid number.");
                }
                else if (decimalRound > 15)
                {
                    Console.WriteLine("The decimal to round to cannot be bigger than 15... Please enter a valid number.");
                }
                else
                {
                    done = true;
                }
            }

            done = false;

            Console.Write("Please specify the min with decimals: " + minInt + ".");
            while (!Int32.TryParse(Console.ReadLine(), out minDecimalPrecision))
            {
                Console.Write("Invalid input, please try again... ");
            }

            Console.WriteLine();

            minDecimal = minDecimalPrecision;

            while (!done)
            {
                Console.Write("Please specify the max with decimals: " + maxInt + ".");
                while (!Int32.TryParse(Console.ReadLine(), out maxDecimalPrecision))
                {
                    Console.Write("Invalid input, please try again... ");
                }

                maxDecimal = maxDecimalPrecision;

                while (minDecimal >= 1)
                {
                    minDecimal = minDecimal / 10;                   
                }
               
                minDouble = minInt + minDecimal;

                minDouble = Math.Round(minDouble, decimalRound);
                
                while (maxDecimal >= 1)
                {
                    maxDecimal = maxDecimal / 10;
                }

                maxDouble = maxInt + maxDecimal;
                
                maxDouble = Math.Round(maxDouble, decimalRound);

                if (minDouble > maxDouble)
                {
                    Console.WriteLine();

                    Console.WriteLine("Invalid because the min: " + minDouble + " is bigger than the max: " + maxDouble + "! Please enter a valid max");

                    Console.WriteLine();
                }
                else
                {
                    done = true;
                }
            }

            done = false;

            while (!done)
            {
                doubleRandomNumber = generator.Next(minInt, maxInt);
                doubleRandomNumber = doubleRandomNumber + generator.NextDouble();

                doubleRandomNumber = Math.Round(doubleRandomNumber, decimalRound);

                if (minDouble < doubleRandomNumber && maxDouble > doubleRandomNumber)
                {
                    done = true;
                }
            }
            Console.WriteLine();
            
            Console.WriteLine("The number is: " + doubleRandomNumber);
        }
    }
}
