using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Mumbai");
            ht.Add(2, "Pune");
            ht.Add(3, "Hyderabad");
            ht.Add(4, "Pune");
            ht.Add(5, null);
            ht.Add(6, "Chennai");

            Console.WriteLine("HashTable Data : ");
            foreach (object key in ht.Keys)
            {
                Console.Write("Key : " + key + "\t");
                Console.WriteLine("Value : " + ht[key]);
            }

            Console.ReadKey();
        }
    }
}
