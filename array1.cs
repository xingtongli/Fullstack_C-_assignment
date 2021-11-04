using System;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            for(int i =0; i < 10; i++)
            {
                array1[i] = i;
            }
            int arrlength = array1.Length;
            int[] array2 = new int[arrlength];
            for(int i=0; i < arrlength; i++)
            {
                array2[i] = array1[i];
            }

            for(int i=0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
        }
    }
}
