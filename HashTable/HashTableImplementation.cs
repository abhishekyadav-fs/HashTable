using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTableImplementation
    {
        private string[] bucket;

        //Method to compute the hash
        private int HashFunc(int key)
        {
            int hash = key % 2069;
            return hash;
        }

        public void Add(int key,string value)
        {

        }
    }
}
