using System;

namespace array5
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

            int maxi = 1;
            int cur = 1;
            string output = "";
            string max_out = "";
            for(int i=1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    output += array[i].ToString() + ' ';
                    cur++;
                    
                }
                else
                {
                    if (cur > maxi)
                    {
                        maxi = cur;
                        max_out = output;
                    }
                    cur = 1;
                    output = "";
                }
            }
            max_out += max_out[0];
            Console.WriteLine(max_out);
        }
    }
}
