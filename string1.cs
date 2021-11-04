using System;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            char[] arr = new char[ss.Length];
            for(int i=0; i < ss.Length; i++)
            {
                arr[i] = ss[i];
            }

            string output = "";
            for(int i = arr.Length-1; i>=0; i--)
            {
                output += arr[i];
            }
            Console.WriteLine(output);
        }
    }
}
