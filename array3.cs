using System;

namespace arrary3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start num");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end num");
            int e = int.Parse(Console.ReadLine());
            int[] array = FindPrimesInRange(s,e);
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] array = new int[endNum-startNum];
            int count = 0;
            for(int n = startNum; n <= endNum; n++)
            {
                int m = n / 2;
                int flag = 0;
                for(int i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    array[count]=n;
                    count++;
                }
            }
            int total = 0;
            for(int i=0; i < array.Length; i++)
            {
                if (array[i] == 0 && i > 0) break;
                total++;
            }
            int[] array2 = new int[total];
            for(int i =0; i < array2.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
    }
}
