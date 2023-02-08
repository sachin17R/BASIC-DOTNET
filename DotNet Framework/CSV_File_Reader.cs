using System;
using System.Collections.Generic;
using Assaignment_ConsoleApp;
using System.IO;

namespace FrameWorksApp
{
    class CSV_File_Reader
    {
        
        static void Main(string[] args)
        {
            
            StartFunc();

        }

        private static void StartFunc()
        {
            string filePath = "../../CSVfileExample.csv";
        RETRY:
            int choice = HelperClasses.GetNumber("enter 1 for Adding moovies    2 for view Moovies");
            if (choice == 1)
                WritingToCSV(filePath);
            else if (choice == 2)
                ReadingFromCSV(filePath);
            else
            {
                Console.WriteLine("invalid choice please enter Properly");
                goto RETRY;
            }
        }

        private static void ReadingFromCSV(string filePath)
        {
            List<MoovieClass> allMoovies = new List<MoovieClass>();

            var AllLines = File.ReadAllLines(filePath);
            foreach (var item in AllLines)
            {
                var data = item.Split(',');
                MoovieClass obj = new MoovieClass();
                obj.MoovieId = int.Parse(data[0]);
                obj.MoovieName = data[1];
                obj.MoovieProduction = data[2];
                obj.MoovieRating = double.Parse(data[3]);

                allMoovies.Add(obj);
            }
            foreach (var item in allMoovies)
            {
                Console.WriteLine($"{item.MoovieId}   {item.MoovieName}  {item.MoovieProduction}  {item.MoovieRating}");
            }
            HelperClasses.GetValue("press enter to clear");
            Console.Clear();
            StartFunc();

        }

        private static void WritingToCSV(string filePath)
        {
            MoovieClass data = new MoovieClass
            {
                MoovieId = HelperClasses.GetNumber("enter moovie ID"),
                MoovieName = HelperClasses.GetValue("enter Moovie Name"),
                MoovieProduction = HelperClasses.GetValue("enter Moovie Production Name"),
                MoovieRating = HelperClasses.GetDouble("enter moovie Reting between[1-5]")
            };
            File.AppendAllText(filePath, data.ToString());
            Console.WriteLine("appended successfull");
            HelperClasses.GetValue("press enter to clear");
            Console.Clear();
            StartFunc();
        }
    }
}
