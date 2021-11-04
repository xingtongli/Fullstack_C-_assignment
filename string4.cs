using System;

namespace string4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string s1 = "";
            string s2 = "";
            string s3 = "";
            string cur = "";
            for(int i=0; i < input.Length; i++)
            {

                if (input[i] == ':')
                {
                    s1 = cur;
                    cur = "";
                    i += 2;
                    continue;
                }
                else if(input[i] == '/')
                {
                    s2 = cur;
                    cur = "";
                    continue;
                }
                cur += input[i];

            }
            if (s2 == "") s2 = cur;
            else s3 = cur;
            Console.WriteLine($"[protocol] = \"{s1}\"");
            Console.WriteLine($"[server] = \"{s2}\"");
            Console.WriteLine($"[resource] = \"{s3}\"");
        }
    }
}
