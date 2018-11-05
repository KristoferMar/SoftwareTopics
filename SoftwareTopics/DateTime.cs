using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics
{
    class DateTime
    {
        static void Main(string[] args)
        {
            System.DateTime myValue = System.DateTime.Now;
            //ToString gives us the entire data + time.
            Console.WriteLine(myValue.ToString());

            //ToShortDateString = only date, ToShortTimeString = only time.
            Console.WriteLine(myValue.ToShortDateString());

            //ToLongDateString = Only date but with nice long printout, ToLongTimeString = Only time but with nice long printout also seconds.
            Console.WriteLine(myValue.ToLongTimeString());

            //with .Add you can add serveral values to the datetime. Days, seconds, minuts and so on..
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //Subtrat days values from datetime.
            Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //Only get the int of a month
            Console.WriteLine(myValue.Month.ToString());

            //Create an instance of DateTime with parameters from one day of the year. 
            System.DateTime myBirthday = new System.DateTime(1996, 02, 15);
            Console.WriteLine(myBirthday.ToLongDateString());

            System.DateTime myBirth = System.DateTime.Parse("12/7/1969");
            TimeSpan myAge = System.DateTime.Now.Subtract(myBirthday);

            //print out the subtraction
            Console.WriteLine("I have existed for: " + myAge.TotalDays);

            //Calcuate how many days you have been alive.
            string year = Console.ReadLine();
            string month = Console.ReadLine();
            string day = Console.ReadLine();

            DateTime datetime = new DateTime();
            var yourAge = datetime.HowOldAreyou(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));

            Console.WriteLine("You have existed for: " + yourAge.TotalDays);

            Console.ReadLine();

        }

        //How old are you?
        public TimeSpan HowOldAreyou(int year, int month, int days)
        {
            try
            {
                System.DateTime birthday = new System.DateTime(year, month, days);
                TimeSpan Age = System.DateTime.Now.Subtract(birthday);

                return Age;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
