using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Job_Interview_tasks
{
    /*
     * Given the instance of the following circle class.
     * 
     * Write code to calculate the circumference(omkredsen) of the circle, without modifying the circle class itself.
     */

    public sealed class CalculateCircumferenceOfCircle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }

    public class MainClass
    {
        //This would be
        //public static void Main(string[] args)
        //{ 
        public void MainClass1()
        {
            CalculateCircumferenceOfCircle calc = new CalculateCircumferenceOfCircle();

            Console.WriteLine(calc.Calculate(r => 2 * Math.PI * r));
            Console.ReadLine();
        }
    }
}
