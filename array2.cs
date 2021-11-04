using System;
using System.Collections.Generic;
namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            var list = new List<string> { };
            while (done == false) {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                
                string input = Console.ReadLine();
                if (input.Substring(0,1) == "+ ")
                {
                    list.Add(input.Substring(2));
                }
                else if (input.Substring(0,1) == "- ")
                {
                    list.Remove(input.Substring(2));
                }
                else if (input == "--")
                {
                    list.Clear();
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                for(int i = 0; i<list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            
        }
    }
}
