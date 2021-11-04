using System;

namespace print_a_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 4;
            int star = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j=space; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k=0; k < star; k++)
                {
                    Console.Write("*");
                }
                space -= 1;
                star += 2;
                Console.WriteLine();
            }
            
        }
    }
}
