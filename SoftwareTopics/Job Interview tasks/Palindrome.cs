using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Job_Interview_tasks
{
    /*
        A palindrome is a word that reads the same backward or forward.

        Write a function that checks if a given word is a palindrome. Character case should be ignored.

        For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
     */

    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            var reversedString = new string(charArray);

            //Inline if else
            return word.ToLower() == reversedString.ToLower() ? true : false;
        }


        //This would be
        //public static void Main(string[] args)
        //{ 
        public void MainClass()
        {
            Console.WriteLine(Palindrome.IsPalindrome("diana"));
            Console.ReadLine();
        }
    }
}
