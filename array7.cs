using System;

namespace array7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array seperate with space");
            string arr = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != ' ')
                {

                    while (i < arr.Length && arr[i] != ' ')
                    {
                        i++;
                    }
                    count++;
                }
            }

            int[] array = new int[count];
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != ' ')
                {
                    string number = "";

                    while (i < arr.Length && arr[i] != ' ')
                    {
                        number += arr[i];
                        i++;
                    }
                    array[count] = Int32.Parse(number);
                    count++;
                }
            }

            int[] sum = new int[20];
            for(int i=0; i < array.Length; i++)
            {
                sum[array[i]]++;
            }
            int maxi = 0;
            string maxii = "";
            int c = 0;
            for(int i=0; i < 20; i++)
            {
                if (sum[i] > maxi)
                {
                    maxi = sum[i];
                }
            }
            
            for (int i=0; i<20; i++)
            {
                if (sum[i] == maxi)
                {
                    maxii += i.ToString() + ' ';
                    c++;
                }
            }
            int[] maxarr = new int[c];
            c = 0;
            for (int i = 0; i < 20; i++)
            {
                if (sum[i] == maxi)
                {
                    maxarr[c] = i;
                    c++;
                }
            }
            int left = 0;
            bool flag = false;
            for(int i =0; i < array.Length; i++)
            {
                for(int j=0; j < maxarr.Length; j++)
                {
                    if (array[i] == maxarr[j])
                    {
                        left = maxarr[j];
                        flag = true;
                    }
                    if (flag) break;
                }
                if (flag) break;
            }



            if (maxii.Length > 2)
            {
                Console.WriteLine($"The numbers {maxii} have the same maximal frequence (each occurs {maxi} times). the leftmost of them is {left}");
            }
            else
            {
                Console.WriteLine($"The numbers {maxii} have the most frequence (each occurs {maxi} times).");
            }

        }
    }
}
