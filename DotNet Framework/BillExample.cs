using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FrameWorksApp;

namespace FrameWorksApp.sachin
{

    class ItemsClass
    {
        int itemId;
        string itemName;
        int itemPrice;
        static List<ItemsClass> Items = new List<ItemsClass>();
        public static void addItems()
        {
            Random billno = new Random();
            string Holder = HelperClasses.GetValue("enter the bill holder name");
            DateTime date = DateTime.Now;
            // Console.WriteLine(date.ToShortDateString());
            Items.Add(new ItemsClass { itemId = 111, itemName = "rice", itemPrice = 100 });
            Items.Add(new ItemsClass { itemId = 112, itemName = "corn", itemPrice = 30 });
            Items.Add(new ItemsClass { itemId = 113, itemName = "vegi", itemPrice = 50 });
            Items.Add(new ItemsClass { itemId = 114, itemName = "Weat", itemPrice = 49 });
            Items.Add(new ItemsClass { itemId = 115, itemName = "Ragi", itemPrice = 39 });
            Items.Add(new ItemsClass { itemId = 116, itemName = "bisc", itemPrice = 20 });
            Items.Add(new ItemsClass { itemId = 117, itemName = "badm", itemPrice = 145 });
           
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("ItemId \t ItemName(ItemPrice)");
            Console.WriteLine("-------------------------------------------------");

            foreach (var item in Items)
            {
                Console.WriteLine($"{item.itemId} \t {item.itemName}({item.itemPrice})");
            }
            Console.WriteLine();
            bool selection = true;
            do
            {
                Console.WriteLine("--------*---------*----------*----------*-----------*----------");

                int choice = HelperClasses.GetNumber("press 1 for purchase press 2 for generate bill");
                if (choice == 1)
                {
                    Console.WriteLine("enter the item ID you want to buy");
                    int IdChoice = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Items.Count; i++)
                    {
                        var data = Items[i];
                        if (data.itemId == IdChoice)
                        {
                            Console.WriteLine("enter the quantity");
                            int qty = int.Parse(Console.ReadLine());
                            bool okay = printClass.checkFunc(data.itemId, qty, data.itemPrice);
                            if (okay == false)
                                printClass.printingfunc(data.itemId, data.itemName, data.itemPrice, qty);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("puchased successfully");
                            Console.ForegroundColor = ConsoleColor.Black;

                        }
                    }
                }
                else if (choice == 2)
                {
                    printClass.generatebill(billno, Holder, date);
                    HelperClasses.GetValue("press enter to clear the value");
                    selection = false;
                    Console.Clear();

                   
                }
            } while (selection);


        }
    }
    class printClass
    {
        int showId;
        string showName;
        int showPrice;
        int showqty;
        int showtotal;
        //int grandTotal;
        static int val;
        static List<printClass> showData = new List<printClass>();

        public static Boolean checkFunc(int itemId,int qty,int itemPrice)
        {
            for (int i = 0; i < showData.Count; i++)
            {
                var data = showData[i];
                if (data.showId == itemId)
                {
                    data.showqty += qty;
                    data.showtotal += (qty * itemPrice);
                    val  += (qty * itemPrice);
                    return true;
                }
                
            }
           return false;
        }

        public static void printingfunc(int itemId, string itemName, int itemPrice, int qty)
        {
            showData.Add(new printClass { showId = itemId, showName = itemName, showPrice = itemPrice, showqty = qty, showtotal = (qty * itemPrice) });
            val += qty * itemPrice;
            //Console.WriteLine(val);
            //foreach (var item in showData)
            //{
            //    Console.WriteLine($"{item.showId} {item.showqty} {item.showName} {item.showtotal} {val}");
            //}

        }

        public static void generatebill(Random billno, string hname, DateTime dte)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Holder Name:{hname}                          date:{dte}");
            Console.WriteLine($"Bill Number: {billno.Next(1000, 9999)}");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("ItemID \t ItemName \t ItemPrice \t Quantity \t TotalAmount");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var item in showData)
            {
                Console.WriteLine($"{item.showId}  \t   {item.showName}     \t     {item.showPrice}    \t    {item.showqty}    \t    {item.showtotal}");
            }
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine($"                                               Grand Total: {printClass.val}");
            Console.WriteLine("_____________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Black;


        }
    }
    class mainClass
    {
        static void Main(string[] args)
        {
            ItemsClass.addItems();
        }
    }
}
