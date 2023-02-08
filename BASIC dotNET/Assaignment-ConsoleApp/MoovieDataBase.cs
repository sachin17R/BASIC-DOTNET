using System;
using System.Collections.Generic;
using Assaignment_ConsoleApp;

namespace Assaignment_ConsoleApp
{
    class MoovieClass
    {
        public int MoovieId { get; set; }
        public string MoovieName { get; set; }
        public string MoovieProduction { get; set; }
        public int MoovieRating { get; set; }
    }
    interface IMoovieMethods
    {
        void AddMoovie(MoovieClass data);
        void UpdateMoovie(MoovieClass data);
        void RemoveMoovie(int Id);
        void FindMoovie(int Id);
    }
    class MoovieRepo : IMoovieMethods
    {
        static List<MoovieClass> _moovieArray = new List<MoovieClass>();

        public void AddMoovie(MoovieClass data)
        {
            _moovieArray.Add(data);
            Console.WriteLine($"Your Moovie {data.MoovieName} is added successfully");

            //Console.WriteLine(data.MoovieId +"   "  + data.MoovieName);
            //for (int i = 0; i < _moovieArray.count; i++)
            //{
            //    //Console.WriteLine(_moovieArray[i]);
            //    if (_moovieArray[i] == null)
            //    {
            //        _moovieArray[i] = data;
            //        Console.WriteLine($"Your Moovie {data.MoovieName} is added successfully");
            //        return;
            //    }
            //    else
            //    {
            //        throw new Exception("List Is Full");
            //    }
            //}
        }
        public bool Confirmer(int id)
        {
            foreach (var item in _moovieArray)
            {
                if(item.MoovieId == id)
                {
                    return true;
                }
            }
            //throw new Exception("Moovie Id Not Found To Update");
            return false;
        }
        public void UpdateMoovie(MoovieClass data)
        {
            foreach (var item in _moovieArray)
            {
                if (item.MoovieId == data.MoovieId)
                {
                    item.MoovieName = data.MoovieName;
                    item.MoovieProduction = data.MoovieProduction;
                    item.MoovieRating = data.MoovieRating;
                    Console.WriteLine($"Moovie {item.MoovieName} Updated Successfully");
                    return;
                }
            }
        }

        public void RemoveMoovie(int Id)
        {
            foreach (var item in _moovieArray)
            {
                if(item.MoovieId == Id)
                {
                    
                }
            }
        }

        public void FindMoovie(int Id)
        {
            throw new NotImplementedException();
        }
    }
    public class MoovieUIClass
    {
        static MoovieRepo obj;
        public static void DisplayMenu()
        {
            obj = new MoovieRepo();
            Console.WriteLine("**********************Moovie DataBase**********************\n" +
                                    "1).---------Add Moovies--------------- > Press 1.\n" +
                                    "2).---------Update Moovie------------- > Press 2.\n" +
                                    "3).---------remove Moovie------------- > Press 3.\n" +
                                    "4).---------Find Moovie--------------- > Press 4.\n");

            int choice = help.number("Enter The Choice You Want to Perform");

            switch (choice)
            {
                case 1:
                    AddingMoovieManager();
                    break;
                case 2:
                    UpdateMoovieManger();
                    break;
                case 3:
                    RemoveMoovieManager();
                    break;
                    // case 4:
                    // FindMoovieManager();
                    break;
                default:
                    break;
            }
        }

        private static void RemoveMoovieManager()
        {
            int moovieId = help.number("Enter the Moovie Id You Want to Update");
            obj.RemoveMoovie(moovieId);
        }

        private static void UpdateMoovieManger()
        {
            int moovieId = help.number("Enter the Moovie Id You Want to Update");
            bool check = false;

            check = obj.Confirmer(moovieId);

            if (check == true)
            {
                string moovieName = help.text("Enter the Moovie Name");
                string moovieProduction = help.text("Enter the Production Name");
                int moovieRating = help.number("Enter the Rating for the Moovie");
                var moovieObject = new MoovieClass {MoovieId=moovieId, MoovieName = moovieName, MoovieProduction = moovieProduction, MoovieRating = moovieRating };
                obj.UpdateMoovie(moovieObject);
                help.text("Press Enter to Clear The Console");
                Console.Clear();
                DisplayMenu();
            }

        }

        private static void AddingMoovieManager()
        {
            int moovieId = help.number("Enter the Moovie Id");
            string moovieName = help.text("Enter the Moovie Name");
            string moovieProduction = help.text("Enter the Production Name");
            int moovieRating = help.number("Enter the Rating for the Moovie");
            var moovieObject = new MoovieClass { MoovieId = moovieId, MoovieName = moovieName, MoovieProduction = moovieProduction, MoovieRating = moovieRating };
            try
            {
                obj.AddMoovie(moovieObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            help.text("Press Enter to Clear The Console");
            Console.Clear();
            DisplayMenu();


        }
    }


    class MoovieDataBase
    {
        static void Main(string[] args)
        {

            MoovieUIClass.DisplayMenu();
        }
    }
}
