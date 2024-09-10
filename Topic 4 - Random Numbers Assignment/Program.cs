namespace Topic_4___Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int minInt, maxInt, dice1, dice2;
            bool done = false;

            minInt = 0;
            maxInt = 0;

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

                    Console.WriteLine("The maximum can't be bigger than the minimum");

                    Console.WriteLine();
                }
                else
                {
                    done = true;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Generating a number between " + minInt + " and " + maxInt +"...");

            Thread.Sleep(1000);

            Console.WriteLine();

            Console.WriteLine("The number is: " + generator.Next(minInt, maxInt + 1));

            Console.WriteLine();

            Console.Write("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.Write("It's time to roll some dice! ");
            Console.ReadLine();

            dice1 = generator.Next(1, 7);
            dice2 = generator.Next(1, 7);

            Thread.Sleep(1000);

            Console.WriteLine("The first dice rolled a " + dice1 + " and the second dice rolled a " + dice2 + "! The sum of the two dice rolls is " + (dice1 + dice2));
        }
    }
}
