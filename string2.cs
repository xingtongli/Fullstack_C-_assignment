using System;
using System.Collections.Generic;
namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            string arr = Console.ReadLine();
            
            List<string> w_list = new List<string>();
            List<string> p_list = new List<string>();

            string word = "";
            string punc = "";
            
            for(int i = 0; i < arr.Length; i++)
            {
                while (i < arr.Length && !ispunctuation(arr[i]))
                {
                    word += arr[i];
                    i++;
                }
                
                while (i<arr.Length && ispunctuation(arr[i]))
                {
                    punc += arr[i];
                    i++;
                }
                i--;
                if (word != "") w_list.Add(word);
                if (punc != "") p_list.Add(punc); 
                word = "";
                punc = "";
            }
            string result = "";
            for(int i = 0; i < w_list.Count; i++)
            {
                result += (w_list[w_list.Count-i-1] + p_list[i]);
            }

            Console.WriteLine(result);
            
        }
        static bool ispunctuation(char c)
        {
            char[] punctuation = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            for(int i=0; i < punctuation.Length; i++)
            {
                if (c == punctuation[i]) return true;
            }
            return false;
        }
    }
}
