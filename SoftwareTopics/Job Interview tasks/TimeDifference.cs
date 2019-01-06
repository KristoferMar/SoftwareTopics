using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Job_Interview_tasks
{
    //This is a programming task i had to do for Palintir

    //Create a mathod which can tell you the time difference between two time spans.
    class TimeDifference
    {
        static void Main(string[] args)
        {
            TimeDifference td = new TimeDifference();
            Console.WriteLine(td.TimesBetween("4:20", "3:44"));
            Console.ReadLine();
        }

        public string TimesBetween(string timeOne, string timeTwo)
        {
            //Split strings
            string[] timeOneVariables = timeOne.Split(':');
            string[] timeTwoVariables = timeTwo.Split(':');

            //Variable 1 area
            int firstHour = Int32.Parse(timeOneVariables[0]);
            int firstMinute = Int32.Parse(timeOneVariables[1]);

            //Variable 2 area
            int secondHour = Int32.Parse(timeTwoVariables[0]);
            int secondMinute = Int32.Parse(timeTwoVariables[1]);

            var hours = 0;
            var minutes = 0;

            if (firstHour - secondHour < 0)
            {
                hours = 0;
            }
            else
            {
                hours = firstHour - secondHour;
            }

            if (firstMinute - secondMinute < 0)
            {
                minutes = firstMinute - secondMinute;

                if(minutes < 0 && hours >= 1)
                {
                    hours = hours - 1;
                    minutes = minutes + 60;
                }
            }
            else
            {
                minutes = firstMinute - secondMinute;
            }

            return "Time between is: " + hours.ToString() + " Hours " + minutes.ToString() + " minutes";
        }
    }
}
