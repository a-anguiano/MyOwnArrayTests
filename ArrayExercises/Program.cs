using System;
//using System.Linq;

namespace ArrayExercises
{
    class Program
    {
        static void Main()
        {
            ///// Given an array length greater than 1, reduce the array size in half rounded down.
            ///// </summary>
            //[TestCase(new int[5] { 1, 2, 3, 0, 0 }, new int[2] { 1, 2 })]
            //[TestCase(new int[4] { 1, 0, 0, 0 }, new int[2] { 1, 0 })]
            //[TestCase(new int[6] { 1, 2, 3, 4, 5, 0 }, new int[3] { 1, 2, 3 })]

            int i;
            string input = PromptUser("Give me a numeric array: ");
            string items = input.Replace("{ ", "");
            items = items.Replace("}", "");
            string[] Arr = items.Split(",");

            int[] intArr = new int[Arr.Length];

            for (i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(Arr[i]);
            }

            if (intArr.Length%2 == 0)
            {
                Array.Resize(ref intArr, intArr.Length/2);

            }
            else
            {
                Array.Resize(ref intArr, (intArr.Length - 1) / 2);
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
