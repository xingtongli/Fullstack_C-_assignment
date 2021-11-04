using System;

namespace array4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many number you want to input");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array seperate with space");
            string arr = Console.ReadLine();
            Console.WriteLine("Enter number K");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;
            
            for(int i=0; i < arr.Length; i++)
            {
                
                if(arr[i]!=' ')
                {
                    string number = "";
                    
                    while (i < arr.Length && arr[i]!=' ')
                    {
                        number += arr[i];
                        i++;
                    }
                    array[count] = Int32.Parse(number);
                    count++;
                }
            }
            int[] sum = new int[n];
            for (int r = 1; r <= k; r++)
            {
                for(int l = 0; l < n; l++)
                {
                    sum[(l + r) % n] += array[l];
                }
            }

            for(int i=0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
