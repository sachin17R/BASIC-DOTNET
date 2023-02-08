//using SampleExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
//using SampleExample.sachin;
//using HelperClasses = SampleExample.HelperClasses;

namespace FrameWorksApp
{
    [Serializable]
    public class XML_CustomerClass
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerPhone { get; set; }
        public override string ToString()
        {
            return ($"{CustomerId}       {CustomerName}       {CustomerAddress}   {CustomerPhone}");
        }

    }

    interface ICustomerCrudMethods
    {
        void AddNewCustomer(XML_CustomerClass data);
        void UpdateCustomer(XML_CustomerClass data);
        XML_CustomerClass FindCustomer(int id);
        void RemoveCustomer(int id);

    }

    class RepoCustomerClass : ICustomerCrudMethods
    {
        public static List<XML_CustomerClass> CustomerList1 = new List<XML_CustomerClass>();
        SerializerClass SerialObj = new SerializerClass();
        public void initializerFuns(List<XML_CustomerClass> data)
        {
            CustomerList1 = data;
            Console.WriteLine("DEserialization successfull");
        }


        public void AddNewCustomer(XML_CustomerClass data)
        {
            CustomerList1.Add(data);
            Console.WriteLine($"data added to list   {data.CustomerName}");
            SerialObj.PushData(CustomerList1);
            HelperClasses.GetValue("press enter to clear the value");
            Console.Clear();
            UICustomer.MenuDisplay();
        }
        public XML_CustomerClass FindCustomer(int id)
        {
            foreach (var item in CustomerList1)
            {
                if (item.CustomerId == id)
                {
                    return item;
                }

            }

            throw new Exception("Id Not Found");
        }

        public void RemoveCustomer(int id)
        {
            for (int i = 0; i < CustomerList1.Count; i++)
            {
                if (CustomerList1[i].CustomerId == id)
                {
                    CustomerList1.Remove(CustomerList1[i]);
                    Console.WriteLine("removed successfully");
                    return;
                }
            }
            //var item = CustomerList1[i];
            //if (item.CustomerId == id)
            //{
            //    CustomerList1.Remove(item);
            //    Console.WriteLine("removed successfully");
            //    SerialObj.PushData(CustomerList1);
            //    HelperClasses.GetValue("press enter to clear the console");
            //    Console.Clear();
            //    UICustomer.MenuDisplay();
            //    return;
            //}



        }

        public void UpdateCustomer(XML_CustomerClass data)
        {
            for (int i = 0; i < CustomerList1.Count; i++)
            {
                var item = CustomerList1[i];
                if (item.CustomerId == data.CustomerId)
                {
                    item.CustomerName = data.CustomerName;
                    item.CustomerAddress = data.CustomerAddress;
                    item.CustomerPhone = data.CustomerPhone;
                    SerialObj.PushData(CustomerList1);
                    HelperClasses.GetValue("press enter to clear the console");
                    Console.Clear();
                    UICustomer.MenuDisplay();
                }
            }

        }

        internal bool IdChecker(int id)
        {
            for (int i = 0; i < CustomerList1.Count; i++)
            {
                var item = CustomerList1[i];
                //Console.WriteLine(item.CustomerId.GetType());
                if (id == item.CustomerId)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class SerializerClass
    {

        public void PushData(List<XML_CustomerClass> lists)
        {
            FileStream fs = new FileStream("XMLCustomer.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer pusher = new XmlSerializer(typeof(List<XML_CustomerClass>));
            pusher.Serialize(fs, lists);
            //fs.FlushAsync();
            fs.Flush();
            fs.Close();
            Console.WriteLine("serialization successfull");
        }

        public static void GetData()
        {
            RepoCustomerClass obj = new RepoCustomerClass();
            List<XML_CustomerClass> CustomerList = null;
            if (!File.Exists("XMLCustomer.xml"))
            {
                FileStream fs = new FileStream("XMLCustomer.xml", FileMode.CreateNew, FileAccess.Write);
                //XmlSerializer pusher = new XmlSerializer(typeof(List<XML_CustomerClass>));
                fs.Close();
                return;
            }
            else
            {

                FileStream fs = new FileStream("XMLCustomer.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer getter = new XmlSerializer(typeof(List<XML_CustomerClass>));
                CustomerList = getter.Deserialize(fs) as List<XML_CustomerClass>;
                fs.Close();
                obj.initializerFuns(CustomerList);
            }


        }
    }
    class UICustomer
    {
        public static void MenuDisplay()
        {

            Console.WriteLine("**********************Moovie DataBase**********************\n" +
                                    "1).---------Add Customer Details------------------- > Press 1.\n" +
                                    "2).---------Update Customer details---------------- > Press 2.\n" +
                                    "3).---------remove Customer details---------------- > Press 3.\n" +
                                    "4).---------Find Customer details------------------ > Press 4.\n" +
                                    "5).---------Show All Customer details-------------- > Press 5.\n");
            int choice = HelperClasses.GetNumber("enter the choice You want to perform");
            if (choice == 1)
                AddCustomerManager();
            else if (choice == 2)
                UpdateCustomerManager();
            else if (choice == 3)
                RemoveCustomerManager();
            else if (choice == 4)
                FindcustomerManager();
            else if (choice == 5)
                ShowAllCustomerManager();

        }

        private static void ShowAllCustomerManager()
        {
            SerializerClass SerialObj = new SerializerClass();

            RepoCustomerClass repo = new RepoCustomerClass();
            SerializerClass.GetData();
            Console.WriteLine(" Id   \t       Name \t    Address   \t Number");
            Console.WriteLine("________________________________________________________________________");
            foreach (var item in RepoCustomerClass.CustomerList1)
            {
                Console.WriteLine($"   {item.CustomerId}        {item.CustomerName}         {item.CustomerAddress}       {item.CustomerPhone}");
            }
            Console.WriteLine("________________________________________________________________________");

            SerialObj.PushData(RepoCustomerClass.CustomerList1);

            HelperClasses.GetValue("press enter to clear the console");
            Console.Clear();
            MenuDisplay();

        }

        private static void FindcustomerManager()
        {
            SerializerClass SerialObj = new SerializerClass();

            RepoCustomerClass repo = new RepoCustomerClass();
            SerializerClass.GetData();
            int id = HelperClasses.GetNumber("enter the Id you want to Find");
            bool check = repo.IdChecker(id);
            if (check == true)
            {

                XML_CustomerClass data = repo.FindCustomer(id);
                SerialObj.PushData(RepoCustomerClass.CustomerList1);
                Console.WriteLine($"CustomerId        :    {data.CustomerId}");
                Console.WriteLine($"Customer Name     :    {data.CustomerName}");
                Console.WriteLine($"Customer Address  :    {data.CustomerAddress}");
                Console.WriteLine($"Customer Phone    :    {data.CustomerPhone}");
                HelperClasses.GetValue("press enter to clear the console");
                Console.Clear();
                MenuDisplay();
            }
        }

        private static void RemoveCustomerManager()
        {
            SerializerClass SerialObj = new SerializerClass();
            RepoCustomerClass repo = new RepoCustomerClass();

            SerializerClass.GetData();

            int id = HelperClasses.GetNumber("enter the Id you want to remove");
            bool check = repo.IdChecker(id);
            if (check == true)
            {
                repo.RemoveCustomer(id);
                SerialObj.PushData(RepoCustomerClass.CustomerList1);
                HelperClasses.GetValue("press enter to clear the console");
                Console.Clear();
                MenuDisplay();
            }
        }

        private static void UpdateCustomerManager()
        {
            RepoCustomerClass repo = new RepoCustomerClass();
            SerializerClass.GetData();
            bool check = false;
            int id = HelperClasses.GetNumber("enter the customer Id");
            check = repo.IdChecker(id);
            if (check == true)
            {
                string name = HelperClasses.GetValue("enter the customer Name");
                string address = HelperClasses.GetValue("enter the address");
                long number = HelperClasses.GetNumber("enter phone number");
                XML_CustomerClass data = new XML_CustomerClass { CustomerId = id, CustomerName = name, CustomerAddress = address, CustomerPhone = number };
                repo.UpdateCustomer(data);
            }



        }

        private static void AddCustomerManager()
        {
            RepoCustomerClass repo = new RepoCustomerClass();
            SerializerClass.GetData();
            int id = HelperClasses.GetNumber("enter the customer Id");
            string name = HelperClasses.GetValue("enter the customer Name");
            string address = HelperClasses.GetValue("enter the address");
            long number = HelperClasses.GetNumber("enter phone number");
            XML_CustomerClass data = new XML_CustomerClass { CustomerId = id, CustomerName = name, CustomerAddress = address, CustomerPhone = number };
            repo.AddNewCustomer(data);
        }
    }
    class MainCustomer
    {
        static void Main(string[] args)
        {

            UICustomer.MenuDisplay();
        }
    }
}