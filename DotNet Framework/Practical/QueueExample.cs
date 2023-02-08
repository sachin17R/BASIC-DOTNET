using System;
using System.Collections.Generic;


namespace FrameWorksApp.Practical
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            // QueueFunc();
            sortedListfunc();

        }
        static Queue<string> _recent = new Queue<string>();
        static SortedList<string, long> contact = new SortedList<string, long>();


        private static void sortedListfunc()
        {
            for(int i=0;i<=3;i++)
            {
                Console.WriteLine("enter the contact name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the phone number");
                long num = long.Parse(Console.ReadLine());

                sortedListManagre(name, num);
            }

            foreach (var item in contact)
            {
                Console.WriteLine($"{item.Key }-{item.Value}");
            }
        }

        private static void sortedListManagre(string name, long num)
        {
            contact.Add(name, num);
            Console.Clear();

        }

        private static void QueueFunc()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("enter the option u want to add");
                string option = Console.ReadLine();

                QueueMaintainer(option);
                Console.ForegroundColor = ConsoleColor.DarkRed;

                var data = new List<string>(_recent.ToArray());
                data.Reverse();
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                    //Console.WriteLine("---------");
                }
            }
            while (true);
        }

        private static void QueueMaintainer(string option)
        {
            if (_recent.Count == 5)
                _recent.Dequeue();

            _recent.Enqueue(option);
            Console.WriteLine("---------");

        }
    }
}
