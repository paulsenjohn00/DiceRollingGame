using System;

namespace DiceRollingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice rolling simulator!");

            string stringRolls = "";
            int numRolls = 0;
            Console.WriteLine("");
            Console.Write("How many dice rolls would you like to simulate? ");

            stringRolls = Console.ReadLine();

            numRolls = Convert.ToInt16(stringRolls);
            Console.WriteLine("");
            
            // set all elements in array to 0 to prevent null values
            int[] nums = new int[12];
            for (int i = 0; i < 12; i++)
            {
                nums[i] = 0;
            }

            // Generate two random rolls, add them together then store the count to array 
            for (int i = 0; i < numRolls; i++)
            {
                Random rd = new Random();
                int rand_num1 = rd.Next(1, 7);
                int rand_num2 = rd.Next(1, 7);

                int rollTotal = rand_num1 + rand_num2;

                nums[rollTotal - 2]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);
            Console.WriteLine("");

            // This whole statement connects the 
            int diceLabel = 2;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Calculate the percentage
                int percent = (int)Math.Round((double)(100 * nums[i]) / numRolls);
                // * for every percent
                string frequency = new string('*', percent);
                // Print the Histogram
                Console.WriteLine(diceLabel + ": " + frequency);
                // move to the next dice roll
                diceLabel = diceLabel + 1;
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice rolling simulator. Goodbye!");
        }
    }
}
