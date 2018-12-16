using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Custom Implementaion of HashTable
/// </summary>
namespace HashTable
{

    /// <summary>
    /// This hastable is implemented to store only string value with integer keys 
    /// </summary>
    public class HashTableImplementation
    {
        private string[] bucket;


        /// <summary>
        /// Indexer to provide array like encapsulation to hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[int key]
        {
            get {
                int index = HashFunc(key) % bucket.Length;
                return this.bucket[index];
            }
            set {
                int index = HashFunc(key) % bucket.Length;
                bucket[index] = value;
            }
        }
        // Creating bucket with initial size 1000        
        public HashTableImplementation(){
            this.bucket = new string[1000];
        }
        //Method to compute the hash
        private int HashFunc(int key)
        {
            int hash = key % 2069;
            return hash;
        }
        /// <summary>
        /// Method to add values to bucket
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        
        public void Add(int key,string value)
        {
            if (value == null)
            {
                throw new NotImplementedException();
            }
            
            int index = HashFunc(key) % bucket.Length;
            bucket[index] = value;
        }
    }
}
