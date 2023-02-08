using System;

namespace SampleConApp
{

    class Book
    {
        public string BookName { get; set; }    
        public string AuthorName { get; set; }
        public int Price { get; set; }
    }
   class Store : Book
    {
        public void AddBook()
        {
            string name = Utilities.Prompt("enter the book name");
            string author = Utilities.Prompt("enter the author name");
            int price = Utilities.GetNumber("enter the amount");

            BookName = name;
            AuthorName = author;
            Price = price;
        }
        public void DeleteBook()
        {
            BookName = null;
            AuthorName = null;
            Price = 0;
        }

        public void GetBook()
        {
            Console.WriteLine($"book name is : {BookName}");
            Console.WriteLine($"author name is : {AuthorName}");
            Console.WriteLine($"book price is : {Price}");
        }
    }
    class InheritenceTopic
    {
        static void Main(string[] args)
        {
            Store str = new Store();

            str.AddBook();
            str.GetBook();
        }
    }
}
