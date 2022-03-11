using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main()
        {
            ///// Given an empty array, fill each element with the index + 1
            ///// </summary>
            //[TestCase(new int[3] { 0, 0, 0 }, new int[3] { 1, 2, 3 })]
            //[TestCase(new int[1] { 0 }, new int[1] { 1 })]
            //[TestCase(new int[5] { 0, 0, 0, 0, 0 }, new int[5] { 1, 2, 3, 4, 5 })]

            //Oops!!! I did where is was an empty string array, as in { , , } null values
            //Would've been easier with numbers anyways

            int i;
            string input = PromptUser("Give me an empty array of any length: ");
            string items = input.Replace("{ ", "");
            items = items.Replace("}", "");

            string[] Arr = items.Split(",");
            int[] intArr = new int[Arr.Length];

            for (i = 0; i < Arr.Length; i++)
            {
                intArr[i] = i+1;
            }
            foreach (var entry in intArr)
            {
                Console.Write(entry);
            }

            static string PromptUser(string message)
            {
                Console.Write(message);
                return Console.ReadLine();
            }
        }

    }
}
