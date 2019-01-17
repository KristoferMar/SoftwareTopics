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

        public static long TotalEvenNumbers(int[] intArray)
        {
            //The reason i convert to long is to minimize the chance of overflow exception.
            var intReturn = intArray.Where(i => i % 2 == 0).Sum(i => (long)i);

            return intReturn;
        }
    }
}
