using System;
using System.IO;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            var streamReader = new StreamReader(@".\..\..\file.zip");
            try
            {
                //var calculator = new Calculator();
                //calculator.Divide(5, 0);

                //var content = streamReader.ReadToEnd();
                //throw new Exception("oops");

                var api = new YouTubeApi();
                var listVideos = api.GetVideo("Icke32");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can not divide by zero.");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            catch (Exception e)
            {
                Console.WriteLine("something happened...");
                //Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }


            // instead it is also possible to use the using keyword here
            //try
            //{
            //    using (var streamReader = new StreamReader(@".\..\..\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("sorry, something unexpectated happened...");

            //}

        }
    }
}
