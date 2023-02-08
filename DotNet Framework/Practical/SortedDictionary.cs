using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorksApp.Practical
{
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> PhoneNo = new SortedDictionary<string, long>();

            PhoneNo.Add("sachin", 9743848369);
            PhoneNo.Add("aachin", 9743848369);
            PhoneNo.Add("bachin", 9743848369);
            PhoneNo.Add("kachin", 9743848369);
            PhoneNo.Add("szachin", 9743848369);
            PhoneNo.Add("lachin", 9743848369);

            foreach (var item in PhoneNo)
            {
                Console.WriteLine(item.Key +"------"+item.Value);
            }
        }
    }
}
