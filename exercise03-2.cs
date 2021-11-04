using System;

namespace exercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine("Hello, world!");
                }
            }
            catch (Exception ex)
            {
                # warning The max number exceed the type range  
            }


        }
    }
}
