using System;
//using System.Linq;

namespace ArrayExercises
{
    class Program
    {
        static void Main()
        {
            ///// <summary>
            ///// Given an array, and n. Add more slots to an array. eg. An array with 5 elements, and n = 2, return an array with 7 elements.
            ///// </summary>
            //[TestCase(new int[3] { 1, 2, 3 }, 2, new int[5] { 1, 2, 3, 0, 0 })]
            //[TestCase(new int[1] { 1 }, 3, new int[4] { 1, 0, 0, 0 })]
            //[TestCase(new int[5] { 1, 2, 3, 4, 5 }, 1, new int[6] { 1, 2, 3, 4, 5, 0 })]


            //I still have not been able to handle any other format besides 1,4,5 etc
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

            int n = PromptUser4Int("Enter number of slots you wish to add: ");
            for (i = 0; i < n; i++)
            {
                Array.Resize(ref intArr, intArr.Length + 1);
                intArr[intArr.Length - 1] = 0;
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

            static int PromptUser4Int(string message)
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
}
