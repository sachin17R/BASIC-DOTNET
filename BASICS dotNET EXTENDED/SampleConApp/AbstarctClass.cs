using System;


namespace SampleConApp
{
    
   abstract class SbAccount
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public int  balance { get; private set; } = 1000;
       
        public void Credit(int amount) => balance += amount;
       

        public void AccCreation(string name, int acc)
        {
            this.Name = name;
            this.AccNo = acc;
            Console.WriteLine($"your account created with name:{Name} and account no:{AccNo}");
        }
        public void Debit(int amount)
        {
            if (amount > balance)
                throw new Exception("insufficient balance");
            else
                balance -= amount;
        }

        public abstract void interest();
    }
 

    class SbDerived : SbAccount
    {
        public override void interest()
        {
            var price = balance;
            var time = 0.6;
            var rate = 2;

            var interest = (price * time * rate) / 100;

            Credit((int)interest);
        }
    }
    class FdDerived : SbAccount
    {
        public override void interest()
        {
            var price = balance;
            var time = 0.5;
            var rate = 5;

            var interest = (price * time * rate) / 100;

            Credit((int)interest);
        }
    }
    class RdDerived : SbAccount
    {
        public override void interest()
        {
            var price = balance;
            var time = 0.5;
            var rate = 3;

            var interest = (price * time * rate) / 100;

            Credit((int)interest);
        }
    }

    enum accounts { SbAccount, FdAccount, RdAcount };

    class AccountManager
    {
        public static SbAccount AccSelector(string account)
        {
            if(account == "SbAccount")
            {
                return new SbDerived();
            }
            else if (account == "RdAccount")
            {
                return new RdDerived();
            }
           else if (account == "FdAccount")
            {
                return new FdDerived();
            }
            else
            {
                throw new Exception("account type doest match");
            }
           
        }
    }

    class AbstarctClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create an accout in our bank");
            string name = Utilities.Prompt("enter the holder name");
            int accno = Utilities.GetNumber("enyter the acc no");
            RdDerived hhh = new RdDerived();
            hhh.AccCreation(name, accno);
            Console.WriteLine("do transaction by selecting the accunt type");
          //  Console.WriteLine("select the accounr type u need");
            Array accshow = Enum.GetValues(typeof(accounts));
            foreach (var item in accshow)
            {
                Console.WriteLine(item);
            }

            string AccType = Utilities.Prompt("anter the account type as shown above");
            try
            {
                SbAccount obj = AccountManager.AccSelector(AccType);
                
                int amt = Utilities.GetNumber("enter the amount you want to add");
                obj.Credit(amt);
                Console.WriteLine($"your account is added with Rs {obj.balance}");
                obj.interest();
                Console.WriteLine($"interest has been cedited {obj.balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          

            //SbAccount acc = new DerivedClass1();
            //acc.Name = "sachin";
            //acc.AccNo = 1234;
            //acc.Credit(10000);
            //Console.WriteLine($"credited amount is {acc.balance}");
            //acc.interest();
            //Console.WriteLine($"interested amount is {acc.balance}");

        }
    }
}
