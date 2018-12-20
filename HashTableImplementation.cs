using System;
using System.Collections;
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
    public class HashTableImplementation : IEnumerable
    {
        private string[] bucket;

        /// <summary>
        ///  Rrturning the count in hashtable
        /// </summary>
        public int Count {
            get
            {
                int cnt = 0;
                foreach(var i in bucket) {
                    if(i!=null || i != string.Empty)
                    {
                        cnt++;
                    }
                }
                return cnt;
            }
        }
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
        // Ctor with capacity
        public HashTableImplementation(int capacity)
        {
            this.bucket = new string[capacity];
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

        /// <summary>
        /// Check if hashtable contains key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(int key)
        {
            int hash = HashFunc(key);
            int index = hash % bucket.Length;
            if(bucket[index]!=null || String.IsNullOrEmpty(bucket[index])) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Check if the hashtable has the value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ContainsValue(string value)
        {
            foreach(var item in bucket)
            {
                if (item == value) { return true; }
                
            }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return bucket.GetEnumerator();
        }
    }
}
