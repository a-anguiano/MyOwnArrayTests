using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main()

            /// Given a size greater than zero, return a new array of ints
        //[TestCase(3, new int[3] { 0, 0, 0 })]
        //[TestCase(1, new int[1] { 0 })]
        //[TestCase(5, new int[5] { 0, 0, 0, 0, 0 })]
        {
            int length = PromptUser4Int("Enter length of array: ");
            int[] newArray = new int[length];
            foreach (var entry in newArray)
            {
                Console.Write(entry);
            }
            //Console.Write($"{newArray}");
        }

        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptUser4Int(string message)
        {
            int result;
            while (!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid Input! Press any key to continue");
            }

            return result;
        }
    }
}
