using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Job_Interview_tasks
{
    /*
     * Given an arrat of ints, write a c# method to total all the values that are even numbers.
     */
    public class IntArrayOnlyEvenNumbers
    {
        //This would be
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(TotalEvenNumbers(intArray));
            Console.ReadLine();
        }

        public static int TotalEvenNumbers(int[] intArray)
        {
            var intReturn = intArray.Where(i => i % 2 == 0).Sum();

            return intReturn;
        }
    }
}
