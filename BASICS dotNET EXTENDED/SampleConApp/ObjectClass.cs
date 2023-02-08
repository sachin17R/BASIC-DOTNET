using System;

namespace SampleConApp
{
    class BMTC_old
    {
        public virtual void Ticket(string mode, int amount)
        {
            if(mode == "online")
            {
                Console.WriteLine("payment not accepted");
            }
            else
            {
                Console.WriteLine($"your transaction mode is {mode} and take your ticket at {amount}");
            }
        }
    }

    class BMTC_new : BMTC_old
    {
        public override void Ticket(string mode, int amount)
        {
            if(mode == "check")
            {
                Console.WriteLine($"your transaction mode is {mode} so not succeeed");
            }
            else
            {
                Console.WriteLine($"your transaction mode is {mode} and take your ticket at {amount}");
            }
        }
    }
    class ObjecManager
    {
        public static BMTC_old selector(string type) 
        {
            if (type == "old")
            {
                return new BMTC_old();
            }
            else if (type == "new")
            {
                return new BMTC_new();
            }
            else
            {
                throw new Exception("version mode is not available");
            }
        }
    }
    class MethodOverRiding
    {
        static void Main(string[] args)
        {
            string type = Utilities.Prompt("enter the version *old* or *new*");
            BMTC_old obj = ObjecManager.selector(type);
            string mode = Utilities.Prompt("select payment mode *online* or other");
            int amount = Utilities.GetNumber("enter the amount ");
            obj.Ticket(mode, amount);

        }
    }
}
