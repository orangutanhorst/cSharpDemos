using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine("Get Value or Default: " + date.GetValueOrDefault());
            Console.WriteLine("Has Value: " + date.HasValue);


            // short way to check if date is null
            DateTime date2 = date ?? DateTime.Today;
        }
    }
}
