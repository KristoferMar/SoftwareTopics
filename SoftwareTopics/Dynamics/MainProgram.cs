using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Dynamics
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //This is duable because the type is dynamic.
            dynamic name = "Kristofer";
            name = 10;

            //in this case the var will become dynamic in the end.
            dynamic a = 10;
            dynamic b = 20;
            var c = a + b;

            //With the use of dynamics it enables us to ignore casting in many cases.
        }
    }
}
