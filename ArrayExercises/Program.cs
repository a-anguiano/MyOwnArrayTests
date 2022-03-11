using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main()
        {
            ///// Given an array larger than 0, return the last element in the array
            ///// </summary>
            //[TestCase(new int[] { 1, 2, 3 }, 3)]
            //[TestCase(new int[] { 1, 3, 7, 11, 5, 5 }, 5)]
            //[TestCase(new int[] { 10 }, 10)]
            string input = PromptUser("Give me an array of numbers larger than zero: ");
            //string items = input.Replace(", ", "");
            string[] Arr = input.Split(",");                //works if user enters as 1,2,3
                                                            //may need to consider spaces and otherwise...
                                                            //or have user enter one number at a time??

            if (Arr.Length > 0)
            {
                string lastItem = Arr[Arr.Length - 1];
                Console.Write($"The last item is {lastItem}");
            }
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
