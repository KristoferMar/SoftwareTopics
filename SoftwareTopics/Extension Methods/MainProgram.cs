using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Extension_Methods
{
    class MainProgram
    {
        //This would be Main(string[] args)
        public void MainClass()
        {
            string post = "This is a supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
            Console.ReadLine();
        }
    }
}
