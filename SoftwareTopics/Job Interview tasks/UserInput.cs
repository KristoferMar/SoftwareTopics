using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftwareTopics.Job_Interview_tasks
{
    /*
        User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

            Implement the class TextInput that contains:
            - Public method void Add(char c) - adds the given character to the current value
            - Public method string GetValue() - returns the current value

            Implement the class NumericInput that:
            - Inherits TextInput
            - Overrides the Add method so that each non-numeric character is ignored
    */

    public class TextInput
    {
        public IList<char> list = new List<char>();

        //Mark it virtual to be able to override it.
        public virtual void Add(char c)
        {
            list.Add(c);
        }

        public string GetValue()
        {
            string value = "";

            foreach (char element in list)
            {
                value = value + element;
            }
            return value;
        }
    }

    public class NumericInput : TextInput
    {
        //Override the add method.
        public override void Add(char c)
        {

            //if (c == Regex.Matches(new string(c), @"[a-zA-Z]").Count) { }
            if (c < '0' || c > '9')
            {
            }
            else
            {
                list.Add(c);
            }
        }
    }

    public class UserInput
    {
        //This would be
        //public static void Main(string[] args)
        //{ 
        public void MainClass()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadLine();
        }
    }
}
