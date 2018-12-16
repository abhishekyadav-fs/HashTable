using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abacdfrab";
            Version v = new Version(5,56,17,0);
            Console.WriteLine( v.Build);
            Dictionary<char, int> dt = new Dictionary<char, int>();
            for(char c = 'a'; c <= 'z'; c++)
            {                
                dt.Add(c, 0);
            }
            for(int i = 0; i < s.Length; i++)
            {
                dt[s[i]]++;
            }
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c +" - " +dt[c]);
            }
            Console.ReadKey();

        }
    }
}
