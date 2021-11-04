using System;
using System.Collections.Generic;
namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();

            List<string> result = new List<string>();

            for(int i=0; i < arr.Length; i++)
            {
                string word = "";
                //(arr[i]>='a' && arr[i] <= 'z')|| (arr[i] >= 'A' && arr[i] <= 'Z')
                while (i<arr.Length && Char.IsLetter(arr[i]))
                {
                    word += arr[i];
                    i++;
                }
                if(word!="") result.Add(word);
            }
           /* for(int i=0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }*/
            List<string> palindrome = new List<string>();
            for (int i = 0; i < result.Count; i++)
            {
                if (isPalindrome(result[i]))
                {
                    palindrome.Add(result[i]);
                }
            }
            palindrome.Sort();
            for(int i=0; i < palindrome.Count; i++)
            {
                Console.Write(palindrome[i]);
                if(i!= palindrome.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }
        static bool isPalindrome(string word)
        {
            bool isPali = true;
            int s = 0;
            int e = word.Length - 1;
            while (s < e)
            {
                if (word[s] != word[e])
                {
                    isPali = false;
                    break;
                }
                s++;
                e--;
            }
            return isPali;
        }
    }
}
