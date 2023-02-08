using SampleFrameworksApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Assaignment_ConsoleApp;
namespace SampleFrameworksApp
{
    class Ex07XmlFileIODemo
    {
        static MoovieClass[] getAllMoovies(string fileName)
        {
            List<MoovieClass> allMoovies = new List<MoovieClass>();
            var allLines = File.ReadAllLines(fileName);
            foreach (var line in allLines)
            {
                //Split each line based on Comma. 
                var words = line.Split(',');
                MoovieClass cst = new MoovieClass();
                cst.MoovieId = int.Parse(words[0]);
                cst.MoovieName = words[1];
                cst.MoovieProduction = words[2];
                cst.MoovieRating = double.Parse(words[3]);
                allMoovies.Add(cst);
            }
            return allMoovies.ToArray();
        }

        static void writeToxml(MoovieClass[] data, string fileName)
        {
            DataTable table = new DataTable("Moovies");
            table.Columns.Add("MoovieId", typeof(int));
            table.Columns.Add("MoovieName", typeof(string));
            table.Columns.Add("MoovieProduction", typeof(string));
            table.Columns.Add("MoovieRating", typeof(double));
            //Populate the data into the Table....
            foreach (var cst in data)
            {
                DataRow row = table.NewRow();
                row[0] = cst.MoovieId;
                row[1] = cst.MoovieName;
                row[2] = cst.MoovieProduction;
                row[3] = cst.MoovieRating;
                table.Rows.Add(row);
            }
            table.AcceptChanges();
            DataSet ds = new DataSet("ALL MOOVIES");
            ds.Tables.Add(table);
            ds.WriteXml(fileName);

        }
        static void Main(string[] args)
        {
            var data = getAllMoovies("../../CSVfileExample.csv");
            writeToxml(data, "../../CSVtoXML.xml");
            //Console.WriteLine(ds.GetXml());
        }
    }
}
