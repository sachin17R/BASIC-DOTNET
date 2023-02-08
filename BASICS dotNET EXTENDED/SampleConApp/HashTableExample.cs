using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class HashTableExample
    {
        static void Main(string[] args)
        {
            HashTableExampleFunc();
        }

        private static void HashTableExampleFunc()
        {
            Hashtable hash = new Hashtable();
            hash.Add("name", "sachin");
            hash.Add("age", "22");
            hash.Add("address", "mysore");
            hash.Add("company", "starmark");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
                //Console.WriteLine("{0},{1}",item.Key,item.Value);
            }
        }
    }
}
