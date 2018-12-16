using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("################### HashTable Implementation #########################");

            Console.Write("How many keys your want to enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = n;
            while (i > 0)
            {
                Console.Write("Please enter the key :");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Please enter the value :");
                string value = Console.ReadLine();
                HashTableImplementation ht = new HashTableImplementation();
                ht.Add(key, value);                
                i--;
            }            
            Console.ReadKey();
        }
    }
}
