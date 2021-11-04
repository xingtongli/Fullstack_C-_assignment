using System;

namespace counting
{
    class Program
    {
        static void Main(string[] args)
        {
            int increment = 1;
            for(int i=0; i < 4; i++)
            {
                for(int j=0; j < 25; j += increment)
                {
                    Console.Write(j);
                    if (j == 24)
                    {
                        break;
                    }
                    Console.Write(",");
                }
                Console.WriteLine();
                increment += 1;
            }
            
        }
    }
}
