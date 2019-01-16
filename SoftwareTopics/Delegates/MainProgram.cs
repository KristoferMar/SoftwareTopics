using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Delegates
{
    //Imagine that in this section you as a consumer or a developer is writing code to the framework or application.
    public class MainProgram
    {
        //This would be Main(string[] args)
        public void MainClass()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;

            //Because of delegation we can easily apply and add other filters.
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;


            processor.Process("Photo.jpg", filterHandler);
            Console.ReadLine();

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
