using System;
using System.Collections.Generic;
using System.IO;


namespace FrameWorksApp
{
    class Basic_IO_class
    {
        static void Main(string[] args)
        {
            string filePath = "../../Basic_IO_class.cs";
            //ReadingfileExample(filePath);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "sachin.txt";
            WritingFileExample(desktopPath);
           
        }

        private static void WritingFileExample(string desktopPath)
        {
            
                File.WriteAllText(desktopPath, "hello i am sachin");
            
        }

        private static void ReadingfileExample(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file path is wrong");
            }
            else
            {
                string contets = File.ReadAllText(filePath);
                Console.WriteLine(contets);
            }
        }
    }
}
