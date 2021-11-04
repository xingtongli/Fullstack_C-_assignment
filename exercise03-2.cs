using System;

namespace exercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            if (byte.MaxValue < max)
                Console.WriteLine("The range exceed the type maximum value.");
            for (byte i = 0; i < max; i++)
            {
                
                Console.WriteLine(i);
                
            }
            
        }
    }
}
