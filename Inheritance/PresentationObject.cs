using System;

namespace Inheritance
{
    class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
            
        }
    }
}