using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Generics
{
    public class GenericMethods
    {

        //This would be Main(string[] args)
        public void MainClass()
        {
            string variable1 = "hi";
            string variable2 = "hello";

            GenericMethods method = new GenericMethods();

            method.Swap(ref variable1, ref variable2);

            Console.WriteLine(variable1 + " " + variable2);
            Console.ReadLine();
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
