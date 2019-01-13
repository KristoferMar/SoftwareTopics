using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Exception_Handling
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //This reads data to a file and closes the connection in the end.
        //    StreamReader streamReader = null;
        //    try
        //    {
        //        streamReader = new StreamReader(@"c:\file.zip");

        //        var content = streamReader.ReadToEnd();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Sorry, an unexpected error occurred.");
        //    }
        //    finally
        //    {
        //        //There we close the connection if something goes wrong.
        //        if(streamReader != null)
        //             streamReader.Dispose();
        //    }

        //    //Another way to do the same job is to use the "using" keyword.
        //    StreamReader streamReader2 = null;
        //    try
        //    {
        //        using (var myStreamReader = new StreamReader(@"c:\file.zip"))
        //        {
        //            var content = streamReader.ReadToEnd();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Sorry, an unexpected error occurred.");
        //    }


        //    //We can throw multiple exceptions and we can do it in many specific ways.
        //    try
        //    {
        //        var calculator = new Calculator();
        //        var result = calculator.Devide(5, 0);
        //    }
        //    catch(DivideByZeroException ex)
        //    {
        //        Console.WriteLine("You cannot divide by 0.");
        //    }
        //    catch (ArithmeticException ex)
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        Console.WriteLine("sorry an unexpected error occurred.");
        //    }
        //    //.NET 
        //    finally
        //    {

        //    }

        //    Console.ReadLine();
        //}
    }
}
