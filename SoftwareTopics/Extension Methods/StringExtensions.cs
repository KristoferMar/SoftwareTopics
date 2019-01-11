using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Extension_Methods
{

    //Every method in this class is an extension method.

    //We alway use static with extension methods
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            //This if is defencive programming
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numbersOfWords should be greater than or equal to 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
